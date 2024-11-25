using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Sistema_Ferreteria_Dikranis
{
    public partial class RealizarVenta : Form
    {
        private int IdEmpleado;
        private decimal TotalVenta = 0;
        private List<entTicketVentaDetalle> detallesVenta = new List<entTicketVentaDetalle>();



        public RealizarVenta(int IdEmpleado)
        {
            InitializeComponent();
            FormularioHelper.TimerTick += horaFecha_Tick;
            this.IdEmpleado = IdEmpleado;
            LlenarComboboxClientes();
            LlenarComboboxMetodoPago();
            LlenarComboboxProductos();

            // Deshabilitamos los campos al inicio
            txtNombreCompleto.Enabled = false;
            txtApellidos.Enabled = false;
            txtTelefono.Enabled = false;
            txtDireccion.Enabled = false;
            txtidtipodocumento.Enabled = false;
            txtNombreProducto.Enabled = false;
            txtPrecioUnitario.Enabled = false;
        }
        private void LlenarComboboxClientes()
        {
            List<entCliente> listaClientes = logCliente.Instancia.ListarCliente();
            cbxcodigocliente.DataSource = listaClientes;
            cbxcodigocliente.DisplayMember = "IdCliente"; // Muestra el ID del cliente
            cbxcodigocliente.ValueMember = "IdCliente";
        }
        private void horaFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }
        private void LlenarComboboxMetodoPago()
        {
            List<entMetodoPago> listaMetodoPago = logMetodoPago.Instancia.ListarMetodoPago();
            cbxMetodoPago.DataSource = listaMetodoPago;
            cbxMetodoPago.DisplayMember = "Nombre";
            cbxMetodoPago.ValueMember = "IdMetodoPago";
        }

        private void LlenarComboboxProductos()
        {
            List<entProducto> listaProductos = logProducto.Instancia.Listarproductos();
            cbxidproducto.DataSource = listaProductos;
            cbxidproducto.DisplayMember = "Nombre";
            cbxidproducto.ValueMember = "IdProducto";
        }


        private void cbxTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtidtipodocumento.Text == "Dni")
            {
                lblNombres.Text = "Nombres";
                lblApellidos.Visible = true;
                txtApellidos.Visible = true;
            }
            else if (txtidtipodocumento.Text == "Ruc")
            {
                lblNombres.Text = "Razon Social";
                lblApellidos.Visible = false;
                txtApellidos.Visible = false;
            }
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones básicas
                if (cbxidproducto.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un producto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtCantidad.Text) || !int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
                {
                    MessageBox.Show("Ingrese una cantidad válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                entProducto productoSeleccionado = (entProducto)cbxidproducto.SelectedItem;
                decimal precioUnitario = productoSeleccionado.PrecioVenta;
                decimal totalProducto = cantidad * precioUnitario;

                // Agregar al DataGridView
                dgvVenta.Rows.Add(
                    cbxcodigocliente.Text,
                    DateTime.Now.ToString("dd/MM/yyyy"),
                    cbxMetodoPago.Text,
                    productoSeleccionado.Nombre,
                    cantidad,
                    precioUnitario,
                    totalProducto,
                    productoSeleccionado.IdProducto  // Columna oculta para guardar el ID
                );

                // Actualizar el total
                TotalVenta += totalProducto;
                txtTotal.Text = $"Total Venta: {TotalVenta:C}";

                // Limpiar campos del producto
                LimpiarCamposProducto();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarCamposProducto()
        {
            txtCantidad.Clear();
            txtNombreProducto.Clear();
            txtPrecioUnitario.Clear();
            cbxidproducto.SelectedIndex = -1;
        }

        private void btnRealizarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones básicas
                if (cbxcodigocliente.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dgvVenta.Rows.Count == 0)
                {
                    MessageBox.Show("Agregue al menos un producto a la venta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear el objeto TicketVenta
                entTicketVenta ticketVenta = new entTicketVenta
                {
                    IdCliente = Convert.ToInt32(cbxcodigocliente.SelectedValue),
                    FechaRegistro = DateTime.Now,
                    IdMetodoPago = Convert.ToInt32(cbxMetodoPago.SelectedValue),
                    IdEmpleado = this.IdEmpleado
                };

                // Lista para almacenar los detalles
                List<entTicketVentaDetalle> detalles = new List<entTicketVentaDetalle>();

                // Recorrer el DataGridView para obtener los detalles
                foreach (DataGridViewRow row in dgvVenta.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        entTicketVentaDetalle detalle = new entTicketVentaDetalle
                        {
                            IdProducto = Convert.ToInt32(row.Cells["IdProducto"].Value),
                            Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value),
                            PrecioUnitario = Convert.ToDecimal(row.Cells["PrecioUnitario"].Value)
                        };
                        detalles.Add(detalle);
                    }
                }

                // Intentar guardar la venta
                bool resultado = logTicketVenta.Instancia.InsertarVenta(ticketVenta, detalles);

                if (resultado)
                {
                    MessageBox.Show("Venta realizada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show("Error al realizar la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            txtCantidad.Clear();
            txtNombreProducto.Clear();
            txtPrecioUnitario.Clear();
            cbxidproducto.SelectedIndex = -1;
            cbxcodigocliente.SelectedIndex = -1;
            cbxMetodoPago.SelectedIndex = -1;
            dgvVenta.Rows.Clear();
            TotalVenta = 0;
            txtTotal.Text = $"Total Venta: {TotalVenta:C}";
        }
        private void txtNombreCompleto_KeyDown(object sender, KeyEventArgs e)
        {
            ConsultaClientes consultarCliente = new ConsultaClientes();
            consultarCliente.ClienteSeleccionado += (IdCliente, Dni,TipoDocumento,Nombres,Apellidos,Direccion,telefono) =>
            {
                txtNumeroDocumento.Text = Dni;
                txtCantidad.Text = IdCliente;
                txtidtipodocumento.Text = TipoDocumento;
                txtNombreCompleto.Text = Nombres;
                txtApellidos.Text = Apellidos;
                txtDireccion.Text = Direccion;
                txtTelefono.Text = telefono;

            };
            consultarCliente.ShowDialog();
        }

        private void txtNombreProducto_KeyDown(object sender, KeyEventArgs e)
        {
            ConsultarProducto consultarProducto = new ConsultarProducto();
            consultarProducto.ProductoSeleccionado += (IdProducto, Nombre, PrecioUnitario) =>
            {
                cbxidproducto.Text = IdProducto.ToString();
                txtNombreProducto.Text = Nombre;
                txtPrecioUnitario.Text = PrecioUnitario.ToString("F2");
            };
            consultarProducto.ShowDialog();
        }

        private void cbxidproducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxidproducto.SelectedItem != null)
            {
                entProducto producto = (entProducto)cbxidproducto.SelectedItem;
                txtNombreProducto.Text = producto.Nombre;
                txtPrecioUnitario.Text = producto.PrecioVenta.ToString("F2");
            }
        }

        private void cbxcodigocliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxcodigocliente.SelectedItem != null)
            {
                entCliente cliente = (entCliente)cbxcodigocliente.SelectedItem;

                // Autocompletar los campos con la información del cliente
                txtNombreCompleto.Text = cliente.Nombres;
                txtApellidos.Text = cliente.Apellidos;
                txtTelefono.Text = cliente.Telefono;
                txtDireccion.Text = cliente.Direccion;
                txtidtipodocumento.Text = cliente.TipoDocumento;
            }
        }

        private void RealizarVenta_Load(object sender, EventArgs e)
        {
            dgvVenta.Columns.Add("Cliente", "Nombre del Cliente");
            dgvVenta.Columns.Add("Fecha", "Fecha de Registro");
            dgvVenta.Columns.Add("MetodoPago", "Método de Pago");
            dgvVenta.Columns.Add("Producto", "Producto");
            dgvVenta.Columns.Add("Cantidad", "Cantidad");
            dgvVenta.Columns.Add("PrecioUnitario", "Precio Unitario");
            dgvVenta.Columns.Add("Total", "Total");
            dgvVenta.Columns.Add("IdProducto", "IdProducto");  // Columna oculta
            dgvVenta.Columns["IdProducto"].Visible = false;  // Ocultar la columna de ID
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
