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
    public partial class NotaEntrada : Form
    {
        private int IdEmpleado;
        List<entProducto> listaProductos = logProducto.Instancia.Listarproductos();
        public NotaEntrada(int IdEmpleado)
        {
            InitializeComponent();
            //Suscribirse al envento TimerTick de FormularioHelper
            FormularioHelper.TimerTick += horaFecha_Tick;
            txtCodigoNotaEntrada.Enabled = false;
            ConfigurarDataGridView();
            this.IdEmpleado = IdEmpleado;
            lblIdEmpleado.Text = $"ID Empleado: {IdEmpleado}";

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
        private void LimpiarCamposProducto()
        {
            txtCodigoProducto.Clear();
            txtCantidad.Clear();
            txtNombreProducto.Clear();
            txtIdProveedor.Clear();
        }
        private void horaFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            
            ConsultarProducto consultarProducto = new ConsultarProducto();
            consultarProducto.DesactivarBotonTV();
            consultarProducto.ActivarBotonNE();
            consultarProducto.ProductoSeleccionado2 += (IdProducto, Nombre, IdProveedor) =>
            {
                txtCodigoProducto.Text = IdProducto.ToString();
                txtNombreProducto.Text = Nombre;
                txtIdProveedorP.Text = IdProveedor.ToString();
            };
            consultarProducto.ShowDialog();

        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            ConsultaProveedores consultaProveedores = new ConsultaProveedores();
            consultaProveedores.ProveedorSeleccionado += (IdProveedor, RazonSocial) =>
            {
                txtIdProveedor.Text = IdProveedor.ToString();
                txtRazonSocial.Text = RazonSocial.ToString();
            };
            consultaProveedores.ShowDialog();
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
        private void LimpiarFormulario()
        {
            txtCantidad.Clear();
            txtNombreProducto.Clear();
            txtCodigoProducto.Clear();
            txtIdProveedor.Clear();
            txtIdProveedorP.Clear();
            txtCodigoNotaEntrada.Clear();
            txtIdProveedor.Clear();
            txtRazonSocial.Clear();

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdGuiaRemision == null)
                {
                    MessageBox.Show("Ingrese El código de la Guia de Remisión", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtIdProveedor ==null )
                {
                    MessageBox.Show("Ingrese un Proveedor.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (dgvProducto.Rows.Count == 0)
                {
                    MessageBox.Show("Agregue al menos un producto a la Nota de Salida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Crear el objeto Nota de entNotaEntrada
                entNotaEntrada notaEntrada = new entNotaEntrada
                {
                    FechaRegistro = Convert.ToDateTime(dtPickerFechaRegistro.Value),
                    IdEmpleado = IdEmpleado,
                    IdGuiaRemision = Convert.ToInt32(txtIdGuiaRemision.Text.Trim()),
                    IdProveedor = Convert.ToInt32(txtIdProveedor.Text.Trim())
                };

                // Lista para almacenar los detalles
                List<entNotaEntradaDetalle> detalles = new List<entNotaEntradaDetalle>();

                // Recorrer el DataGridView para obtener los detalles
                foreach (DataGridViewRow row in dgvProducto.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        entNotaEntradaDetalle detalle = new entNotaEntradaDetalle
                        {
                            IdProducto = Convert.ToInt32(row.Cells["IdProducto"].Value),
                            Cantidad = Convert.ToInt32(row.Cells["Cantidad"].Value),
                        };
                        detalles.Add(detalle);
                    }
                }

                // Intentar guardar la venta
                bool resultado = logNotaEntrada.Instancia.InsertarNotaEntrada(notaEntrada, detalles);

                if (resultado)
                {
                    MessageBox.Show("Nota de Entrada realizada con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarFormulario();
                }
                else
                {
                    MessageBox.Show("Error al realizar la Nota de Entrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
