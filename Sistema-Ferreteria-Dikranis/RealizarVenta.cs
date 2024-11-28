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
        List<entProducto> listaProductos = logProducto.Instancia.Listarproductos();


        public RealizarVenta(int IdEmpleado)
        {
            InitializeComponent();
            FormularioHelper.TimerTick += horaFecha_Tick;
            this.IdEmpleado = IdEmpleado;
            lblIdEmpleado.Text = $"ID Empleado: {IdEmpleado}";
            LlenarComboboxClientes();
            LlenarComboboxMetodoPago();
            LlenarComboboxProductos();
            LimpiarFormulario();
            txtCodigoTicket.Enabled = false;

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


        /*private void cbxTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
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
        }*/
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
               
                // Validaciones básicas
                if (cbxidproducto.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione un producto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtCantidad.Text) || !int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
                {
                    MessageBox.Show("Ingrese una cantidad válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Recuperar datos del producto seleccionado
                int idProducto = (int)cbxidproducto.SelectedValue; // Obtiene el ID del producto seleccionado
                var productoSeleccionado = listaProductos.FirstOrDefault(p => p.IdProducto == idProducto);
                if (productoSeleccionado == null)
                {
                    MessageBox.Show("Producto no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Verificar duplicados
                foreach (DataGridViewRow row in dgvVenta.Rows)
                {
                    if (!row.IsNewRow && (int)row.Cells["IdProducto"].Value == idProducto)
                    {
                        MessageBox.Show("Este producto ya está agregado. Modifique la cantidad si es necesario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

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
                    idProducto  // Columna oculta para guardar el ID
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
                    IdEmpleado = IdEmpleado
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
                txtidtipodocumento.Text = cliente.TipoDocumento;
                if (txtidtipodocumento.Text == "Dni")
                {
                    txtNumeroDocumento.Text = cliente.DNI;
                    txtNombreCompleto.Text = cliente.Nombres;
                    txtApellidos.Text = cliente.Apellidos;
                }
                else if (txtidtipodocumento.Text == "Ruc")
                {
                    txtNumeroDocumento.Text = cliente.Ruc;
                    txtNombreCompleto.Text = cliente.RazonSocial;
                }
                // Autocompletar los campos con la información del cliente
                txtTelefono.Text = cliente.Telefono;
                txtDireccion.Text = cliente.Direccion;
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

       

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            ConsultaClientes consultarCliente = new ConsultaClientes();
            consultarCliente.ClienteSeleccionado += (IdCliente, Dni, TipoDocumento, Nombres, Apellidos, Direccion, telefono) =>
            {
                txtNumeroDocumento.Text = Dni;
                cbxcodigocliente.Text = IdCliente;
                txtidtipodocumento.Text = TipoDocumento;
                txtNombreCompleto.Text = Nombres;
                txtApellidos.Text = Apellidos;
                txtDireccion.Text = Direccion;
                txtTelefono.Text = telefono;

            };
            consultarCliente.ShowDialog();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            
            ConsultarProducto consultarProducto = new ConsultarProducto();
            consultarProducto.DesactivarBotonNE();
            consultarProducto.ActivarBotonTv();
            consultarProducto.ProductoSeleccionado += (IdProducto, Nombre, PrecioUnitario) =>
            {
                cbxidproducto.SelectedValue = IdProducto;
                txtNombreProducto.Text = Nombre;
                txtPrecioUnitario.Text = PrecioUnitario.ToString("F2");
            };
            consultarProducto.ShowDialog();
        }

        private void txtidtipodocumento_TextChanged(object sender, EventArgs e)
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si hay una fila seleccionada
                if (dgvVenta.SelectedRows.Count > 0)
                {
                    // Obtener la fila seleccionada
                    DataGridViewRow filaSeleccionada = dgvVenta.SelectedRows[0];

                    // Obtener el total del producto a eliminar
                    decimal totalProducto = Convert.ToDecimal(filaSeleccionada.Cells["Total"].Value);

                    // Restar el total del producto del TotalVenta
                    TotalVenta -= totalProducto;

                    // Actualizar el campo Total
                    txtTotal.Text = $"Total Venta: {TotalVenta:C}";

                    // Eliminar la fila seleccionada
                    dgvVenta.Rows.Remove(filaSeleccionada);
                }
                else
                {
                    MessageBox.Show("Seleccione un producto para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al intentar eliminar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvVenta.Rows[e.RowIndex]; 
            cbxidproducto.Text = filaActual.Cells[3].Value.ToString();
            txtNombreProducto.Text = filaActual.Cells[3].Value.ToString();
            txtCantidad.Text = filaActual.Cells[4].Value.ToString();
            txtPrecioUnitario.Text = filaActual.Cells[5].Value.ToString();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvVenta.SelectedRows.Count > 0) // Verifica si hay una fila seleccionada
            {
                DataGridViewRow row = dgvVenta.SelectedRows[0]; // Obtén la fila seleccionada

                // Validar los datos ingresados
                if (string.IsNullOrWhiteSpace(txtCantidad.Text) || !int.TryParse(txtCantidad.Text, out int nuevaCantidad) || nuevaCantidad <= 0)
                {
                    MessageBox.Show("Ingrese una cantidad válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Actualizar los valores en la fila seleccionada
                decimal nuevoPrecioUnitario = Convert.ToDecimal(txtPrecioUnitario.Text);
                decimal nuevoTotal = nuevaCantidad * nuevoPrecioUnitario;

                row.Cells["Cantidad"].Value = nuevaCantidad;
                row.Cells["PrecioUnitario"].Value = nuevoPrecioUnitario;
                row.Cells["Total"].Value = nuevoTotal;

                // Actualizar el total de la venta
                RecalcularTotalVenta();

                MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Seleccione un producto para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void RecalcularTotalVenta()
        {
            TotalVenta = 0;
            foreach (DataGridViewRow row in dgvVenta.Rows)
            {
                if (!row.IsNewRow)
                {
                    TotalVenta += Convert.ToDecimal(row.Cells["Total"].Value);
                }
            }
            txtTotal.Text = $"Total Venta: {TotalVenta:C}";
        }

        private void lblMantenedorCliente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MantenedorCliente mantenedorCliente = new MantenedorCliente(IdEmpleado);
            mantenedorCliente.ShowDialog();
        }
    }
}
