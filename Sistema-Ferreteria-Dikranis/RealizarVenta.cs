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
        private decimal TotalVenta = 0; // Variable para almacenar el total
        private List<entTicketVentaDetalle> detalle = new List<entTicketVentaDetalle>();



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

                if (string.IsNullOrWhiteSpace(txtPrecioUnitario.Text) || !decimal.TryParse(txtPrecioUnitario.Text, out decimal precioUnitario) || precioUnitario <= 0)
                {
                    MessageBox.Show("Ingrese un precio válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Calcular el total del producto
                decimal totalProducto = cantidad * precioUnitario;

                // Mostrar el total en el label
                txtTotal.Text = $"Total del Producto: {totalProducto:C}"; // Mostrar en formato moneda
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRealizarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones básicas
                if (cbxidproducto.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un cliente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cbxMetodoPago.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un método de pago.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

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

                if (string.IsNullOrWhiteSpace(txtPrecioUnitario.Text) || !decimal.TryParse(txtPrecioUnitario.Text, out decimal precioUnitario) || precioUnitario <= 0)
                {
                    MessageBox.Show("Ingrese un precio válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Calcular el total del producto
                decimal totalProducto = cantidad * precioUnitario;

                // Obtener valores para la venta
                string nombreCliente = cbxcodigocliente.Text;
                DateTime fechaRegistro = dtPickerFechaRegistro.Value; // Suponiendo que tienes un DateTimePicker
                string metodoPago = cbxMetodoPago.Text;
                string producto = cbxidproducto.Text;

                // Agregar datos al DataGridView
                dgvVenta.Rows.Add(
                    nombreCliente,
                    fechaRegistro.ToString("dd/MM/yyyy"),
                    metodoPago,
                    producto,
                    cantidad,
                    precioUnitario,
                    totalProducto
                );

                // Actualizar el total acumulado
                txtCantidad.Clear();
                txtPrecioUnitario.Clear();
                cbxidproducto.SelectedIndex = -1;
                cbxcodigocliente.SelectedIndex = -1;
                cbxMetodoPago.SelectedIndex = -1;

                // Actualizar el total general
                TotalVenta += totalProducto;
                txtTotal.Text = $"Total Venta: {TotalVenta:C}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            txtCantidad.Text = string.Empty;
            txtNombreProducto.Text = string.Empty;
            txtPrecioUnitario.Text = string.Empty;
            detalle.Clear();
            dgvVenta.DataSource = null;
            txtTotal.Text = "Total: $0.00";
            TotalVenta = 0;
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
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
