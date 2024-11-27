using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Ferreteria_Dikranis
{
    public partial class NotaSalida : Form
    {
        private int IdEmpleado;
        List<entProducto> listaProductos = logProducto.Instancia.Listarproductos();


        public NotaSalida(int IdEmpleado)
        {
            InitializeComponent();
            // Suscribirse al evento TimerTick del GlobalTimer
            FormularioHelper.TimerTick += horaFecha_Tick;
            txtIdTicketVenta.Enabled = false;
            txtCodigoNotaSalida.Enabled = false;
            this.IdEmpleado = IdEmpleado;
            lblIdEmpleado.Text = $"ID Empleado: {IdEmpleado}";
            dtPickerFechaRegistro.Visible = false;
            txtPrecioUnitario.Visible = false;
            ConfigurarDataGridView();
            txtCodigoProducto.Enabled = false;
        }
        private void ConfigurarDataGridView()
        {
            dgvProducto.Columns.Clear(); // Limpiar columnas existentes

            // Agregar columna para el Nombre del Producto
            dgvProducto.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NombreProducto",
                HeaderText = "Nombre del Producto",
                DataPropertyName = "Nombre", // Si tienes un DataSource
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            // Agregar columna para la Cantidad
            dgvProducto.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Cantidad",
                HeaderText = "Cantidad",
                DataPropertyName = "Cantidad",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            });

            // Agregar columna oculta para el ID del Producto
            dgvProducto.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "IdProducto",
                HeaderText = "ID Producto",
                DataPropertyName = "IdProducto",
                Visible = false // Ocultar esta columna
            });
        }
        private void horaFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void btnBuscarTickeVenta_Click(object sender, EventArgs e)
        {
            ConsultarTicketVenta consultarTicketVenta = new ConsultarTicketVenta();
            consultarTicketVenta.TicketSeleccionado += (IdTicketVenta) =>
            {
                txtIdTicketVenta.Text = IdTicketVenta.ToString();

            };
            consultarTicketVenta.ShowDialog();
        }

        private void btnConsultarProducto_Click(object sender, EventArgs e)
        {
            ConsultarProducto consultarProducto = new ConsultarProducto();
            consultarProducto.ProductoSeleccionado += (IdProducto, Nombre, PrecioUnitario) =>
            {
                txtCodigoProducto.Text = IdProducto.ToString();
                txtNombreProducto.Text = Nombre;
                txtPrecioUnitario.Text = PrecioUnitario.ToString("F2");
            };
            consultarProducto.ShowDialog();
        }
        private void LimpiarCamposProducto()
        {
            txtCodigoProducto.Clear();
            txtCantidad.Clear();
            txtNombreProducto.Clear();
            txtPrecioUnitario.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                // Validaciones básicas
                if (txtCodigoProducto.Text == null)
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
                int idProducto = Convert.ToInt32(txtCodigoProducto.Text.Trim()); // Obtiene el ID del producto seleccionado
                var productoSeleccionado = listaProductos.FirstOrDefault(p => p.IdProducto == idProducto);
                if (productoSeleccionado == null)
                {
                    MessageBox.Show("Producto no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Verificar duplicados
                foreach (DataGridViewRow row in dgvProducto.Rows)
                {
                    if (!row.IsNewRow && (int)row.Cells["IdProducto"].Value == idProducto)
                    {
                        MessageBox.Show("Este producto ya está agregado. Modifique la cantidad si es necesario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                

                // Agregar al DataGridView
                dgvProducto.Rows.Add(
                    productoSeleccionado.Nombre,
                    cantidad,
                    idProducto  // Columna oculta para guardar el ID
                );

                // Actualizar el total

                // Limpiar campos del producto
                LimpiarCamposProducto();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProducto.SelectedRows.Count > 0) // Verifica si hay una fila seleccionada
            {
                DataGridViewRow row = dgvProducto.SelectedRows[0]; // Obtén la fila seleccionada

                // Validar los datos ingresados
                if (string.IsNullOrWhiteSpace(txtCantidad.Text) || !int.TryParse(txtCantidad.Text, out int nuevaCantidad) || nuevaCantidad <= 0)
                {
                    MessageBox.Show("Ingrese una cantidad válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Actualizar los valores en la fila seleccionada

                row.Cells["Cantidad"].Value = nuevaCantidad;
                MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Seleccione un producto para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificar si hay una fila seleccionada
                if (dgvProducto.SelectedRows.Count > 0)
                {
                    // Obtener la fila seleccionada
                    DataGridViewRow filaSeleccionada = dgvProducto.SelectedRows[0];
                    // Eliminar la fila seleccionada
                    dgvProducto.Rows.Remove(filaSeleccionada);
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
        private void LimpiarFormulario()
        {
            txtCantidad.Clear();
            txtNombreProducto.Clear();
            txtPrecioUnitario.Clear();
            txtCodigoProducto.Clear();
            txtIdTicketVenta.Clear();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones básicas
                if (txtIdTicketVenta.Text == null)
                {
                    MessageBox.Show("Seleccione un Ticket de Venta.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (dgvProducto.Rows.Count == 0)
                {
                    MessageBox.Show("Agregue al menos un producto a la Nota de Salida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear el objeto Nota de Salida
                entNotaSalida notaSalida = new entNotaSalida
                {
                    IdTicketVenta = Convert.ToInt32(txtIdTicketVenta.Text.Trim()),
                    FechaRegistro = Convert.ToDateTime(dtPickerFechaRegistro.Value),
                    IdEmpleado = IdEmpleado
                };

                // Lista para almacenar los detalles
                List<entNotaSalidaDetalle> detalles = new List<entNotaSalidaDetalle>();

                // Recorrer el DataGridView para obtener los detalles
                foreach (DataGridViewRow row in dgvProducto.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        entNotaSalidaDetalle detalle = new entNotaSalidaDetalle
                        {
                            IdProducto = Convert.ToInt32(row.Cells["IdProducto"].Value),
                            Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value),
                        };
                        detalles.Add(detalle);
                    }
                }

                // Intentar guardar la venta
                bool resultado = logNotaSalida.Instancia.InsertarNotaSalida(notaSalida, detalles);

                if (resultado)
                {
                    MessageBox.Show("Nota de Salida realizada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show("Error al realizar la Nota de Salida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
