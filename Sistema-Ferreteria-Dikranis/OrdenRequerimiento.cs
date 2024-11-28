    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.SqlClient;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using CapaLogica;
    using CapaEntidad;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement;

    namespace Sistema_Ferreteria_Dikranis
    {
        public partial class OrdenRequerimiento : Form
        {
            List<entOrdenRequerimientoDetalle> detalles = new List<entOrdenRequerimientoDetalle>();
            private List<DataGridViewRow> filasProductoTemporal = new List<DataGridViewRow>();
            private decimal TotalOrden = 0;
            private int IdEmpleado;

            public OrdenRequerimiento()
            {
                InitializeComponent();
                LlenarComboBoxProveedores();
                LlenarComboBoxProductos();
                lblempleado.Text = $"ID Empleado: {IdEmpleado}";

            }
            private void LlenarComboBoxProveedores()
            {
                List<entProveedor> listaProveedores = logProveedor.Instancia.ListarProveedor();

                // Asignar lista al ComboBox
                comboBox1.DataSource = listaProveedores;

                // Establecer el nombre que se muestra en el ComboBox
                comboBox1.DisplayMember = "IdProveedor";  // Mostrar RazonSocial
                comboBox1.ValueMember = "RazonSocial";    // El valor de cada elemento será el IdProveedor

                // Cuando seleccionas un proveedor, mostrar su correo en el TextBox
                comboBox1.SelectedIndexChanged += (sender, e) =>
                {
                    if (comboBox1.SelectedItem != null)
                    {
                        entProveedor proveedorSeleccionado = (entProveedor)comboBox1.SelectedItem;
                        txtrazonsocial.Text = proveedorSeleccionado.Correo; // Mostrar Correo del proveedor
                    }
                };
            }
            private void LlenarComboBoxProductos()
            {
                // Obtener lista de productos
                List<entProducto> listaProductos = logProducto.Instancia.Listarproductos();

                // Asignar lista al ComboBox
                cbxCodigoProducto.DataSource = listaProductos;

                // Establecer el nombre que se muestra en el ComboBox
                cbxCodigoProducto.DisplayMember = "IdProducto";  // Mostrar Nombre del producto
                cbxCodigoProducto.ValueMember = "Nombre"; // El valor de cada elemento será el IdProducto

                // Cuando seleccionas un producto, mostrar su nombre en el TextBox
                cbxCodigoProducto.SelectedIndexChanged += (sender, e) =>
                {
                    if (cbxCodigoProducto.SelectedItem != null)
                    {
                        entProducto productoSeleccionado = (entProducto)cbxCodigoProducto.SelectedItem;
                        txtNombreProducto.Text = productoSeleccionado.Nombre; // Mostrar Nombre del producto
                    }
                };
            }

            private void btnAgregar_Click(object sender, EventArgs e)
            {
                var producto = (entProducto)cbxCodigoProducto.SelectedItem;
                int cantidad = int.Parse(txtCantidad.Text); // Asegúrate de que esto se valide
                decimal subtotal = producto.PrecioVenta * cantidad;

                DataGridViewRow nuevaFila = new DataGridViewRow();
                nuevaFila.Cells.Add(new DataGridViewTextBoxCell { Value = producto.IdProducto });
                nuevaFila.Cells.Add(new DataGridViewTextBoxCell { Value = producto.Nombre });
                nuevaFila.Cells.Add(new DataGridViewTextBoxCell { Value = cantidad });
                nuevaFila.Cells.Add(new DataGridViewTextBoxCell { Value = producto.PrecioVenta });
                nuevaFila.Cells.Add(new DataGridViewTextBoxCell { Value = subtotal });

                // Añadir la fila a la lista temporal
                filasProductoTemporal.Add(nuevaFila);

                if (cbxCodigoProducto.SelectedValue == null || string.IsNullOrWhiteSpace(txtCantidad.Text))
                {
                    MessageBox.Show("Seleccione un producto y cantidad válida.");
                    return;
                }

                TotalOrden += subtotal;
                lblpreciototal.Text = $"Total: {TotalOrden:C}";
            }

            private void btnRegistrar_Click(object sender, EventArgs e)
            {
            try
            {
                // Debug: Check number of rows
                if (dgvDatosProducto.Rows.Count <= 1)
                {
                    MessageBox.Show("No hay productos para registrar.");
                    return;
                }

                // Debug: Validate provider selection
                if (comboBox1.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un proveedor.");
                    return;
                }
                // This is likely the problem area
                entOrdenRequerimiento orden = new entOrdenRequerimiento
                {
                    FechaRegistro = DateTime.Now,
                    Estado = true,
                    IdProveedor = (entProveedor)comboBox1.SelectedItem,
                };

                // Your current code directly uses the DataGridView for details
                List<entOrdenRequerimientoDetalle> detalles = new List<entOrdenRequerimientoDetalle>();

                foreach (DataGridViewRow row in dgvDatosProducto.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        detalles.Add(new entOrdenRequerimientoDetalle
                        {
                            IdProducto = new entProducto { IdProducto = Convert.ToInt32(row.Cells["ColumnIdProducto"].Value) },
                            Cantidad = Convert.ToInt32(row.Cells["ColumnCantidad"].Value),
                        });
                    }
                }

                // Potential issue: The method signature
                bool resultado = logOrdenRequerimiento.Instancia.InsertarOrdenRequerimiento(orden, detalles);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error detallado: {ex.Message}\n{ex.StackTrace}");
            }
        }
            private void LimpiarFormulario()
            {
                TotalOrden = 0;
                lblpreciototal.Text = $"Total: {TotalOrden:C}";
                dgvDatosProducto.Rows.Clear();
                txtCantidad.Clear();
            }
            private void InicializarDataGridView()
            {
                // Define las columnas del DataGridView si no lo has hecho ya en el diseño
                if (dgvDatosProducto.Columns.Count == 0)
                {
                    dgvDatosProducto.Columns.Add("IdProducto", "ID Producto");
                    dgvDatosProducto.Columns.Add("Nombre", "Nombre");
                    dgvDatosProducto.Columns.Add("Cantidad", "Cantidad");
                    dgvDatosProducto.Columns.Add("PrecioVenta", "Precio de Venta");
                    dgvDatosProducto.Columns.Add("Subtotal", "Subtotal");
                }
            }
        }
    }
