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
    public partial class MantenedorProducto : Form
    {
        private int IdEmpleado;
        public MantenedorProducto(int IdEmpleado)
        {
            InitializeComponent();
            this.IdEmpleado = IdEmpleado;
            ListarProducto();
            LlenarComboBoxCategoria();
            LlenarComboBoxUnidadMedida();
            groupBoxDatosProducto.Enabled = false;
            txtCodigoProducto.Enabled = false;
            lblIdEmpleado.Text = $"ID Empleado: {IdEmpleado}";
            btnAgregar.Visible = false; 
            btnModificar.Visible = false;
            dtPickerFechaCreacion.Enabled = false;
            cbkEstado.Enabled = false;
        }
        public void ListarProducto()
        {
            dgvProducto.DataSource = logProducto.Instancia.Listarproductos();
        }
        private void LlenarComboBoxCategoria()
        {
            List<entCategoria> listaCategoria = logCategoria.Instancia.ListarCategoria();
            cbxcategoria.DataSource = listaCategoria;
            cbxcategoria.DisplayMember = "Nombre";
            cbxcategoria.ValueMember = "IdCategoria";
        }
        private void LlenarComboBoxUnidadMedida()
        {
            List<entUnidadMedida> listaUnidadMedida = logUnidadMedida.Instancia.ListarUnidadMedida();
            cbxunidadmedida.DataSource = listaUnidadMedida;
            cbxunidadmedida.DisplayMember = "Nombre";
            cbxunidadmedida.ValueMember = "IdUnidadMedida";
        }
        public void LimpiarVariables()
        {
            txtCodigoProducto.Clear();
            txtNombreProducto.Clear();
            txtPrecioCosto.Clear();
            txtPrecioVenta.Clear();
            txtStock.Clear();
            txtDescripcion.Clear();
        }
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entProducto producto = new entProducto();
                producto.Nombre = txtNombreProducto.Text.Trim();
                producto.Descripcion = txtDescripcion.Text.Trim();
                producto.IdCategoria = (int)cbxcategoria.SelectedValue;
                producto.IdUnidadMedida = (int)cbxunidadmedida.SelectedValue;
                producto.IdProveedor = int.Parse(txtBProveedor.Tag.ToString());
                producto.Stock = int.Parse(txtStock.Text.Trim());
                producto.FechaVencimiento = dtPickerFechaVencimiento.Value;
                producto.PrecioCompra = decimal.Parse(txtPrecioCosto.Text.Trim());
                producto.PrecioVenta = decimal.Parse(txtPrecioVenta.Text.Trim());
                producto.FechaCreacion = dtPickerFechaCreacion.Value;
                producto.Estado = true;
                producto.FechaIngreso = dtPickerFechaIngreso.Value;
                producto.IdEmpleado = IdEmpleado;

                logProducto.Instancia.InsertaProducto(producto);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBoxDatosProducto.Enabled = false;
            ListarProducto();
            btnAgregar.Visible = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            groupBoxDatosProducto.Enabled = true;
            btnAgregar.Visible = true;
            LimpiarVariables();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBoxDatosProducto.Enabled = true;
            btnModificar.Visible = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entProducto producto = new entProducto();
                producto.IdProducto = int.Parse(txtCodigoProducto.Text.Trim());
                producto.Nombre = txtNombreProducto.Text.Trim();
                producto.Descripcion = txtDescripcion.Text.Trim();
                producto.IdCategoria = (int)cbxcategoria.SelectedValue;
                producto.IdUnidadMedida = (int)cbxunidadmedida.SelectedValue;
                producto.IdProveedor = int.Parse(txtBProveedor.Tag.ToString());
                producto.Stock = int.Parse(txtStock.Text.Trim());
                producto.FechaVencimiento = dtPickerFechaVencimiento.Value;
                producto.PrecioCompra = decimal.Parse(txtPrecioCosto.Text.Trim());
                producto.PrecioVenta = decimal.Parse(txtPrecioVenta.Text.Trim());
                producto.FechaIngreso = dtPickerFechaIngreso.Value;
                producto.IdEmpleado = IdEmpleado;

                logProducto.Instancia.EditaProducto(producto);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBoxDatosProducto.Enabled = false;
            ListarProducto();
            btnModificar.Visible = false;
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entProducto producto = new entProducto();
                producto.IdProducto = int.Parse(txtCodigoProducto.Text.Trim());
                logProducto.Instancia.DeshabilitarProducto(producto);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBoxDatosProducto.Enabled = false;
            ListarProducto();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            groupBoxDatosProducto.Enabled = false;
            btnAgregar.Visible = false;
            btnModificar.Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtBProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            ConsultaProveedores consultarProveedor = new ConsultaProveedores();
            consultarProveedor.ProveedorSeleccionado += (IdProveedor, RazonSocial) =>
            {
                txtBProveedor.Text = RazonSocial;
                txtBProveedor.Tag = IdProveedor;

            };
            consultarProveedor.ShowDialog();
        }

        private void dgvProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvProducto.Rows[e.RowIndex];
            txtCodigoProducto.Text = filaActual.Cells[0].Value.ToString();
            txtNombreProducto.Text = filaActual.Cells[1].Value.ToString();
            txtDescripcion.Text = filaActual.Cells[2].Value.ToString();
            txtStock.Text = filaActual.Cells[6].Value.ToString();
            txtPrecioCosto.Text = filaActual.Cells[9].Value.ToString();
            txtPrecioVenta.Text = filaActual.Cells[10].Value.ToString();
        }

        private void btnMantenedorCategoria_Click(object sender, EventArgs e)
        {
            MantenedorCategoria mantenedorCategoria = new MantenedorCategoria(IdEmpleado);
            mantenedorCategoria.ShowDialog();
            LlenarComboBoxCategoria();
        }

        private void btnMantenedorUnidadMedida_Click(object sender, EventArgs e)
        {
            MantenedorUnidadMedida mantenedorUnidadMedida = new MantenedorUnidadMedida(IdEmpleado);
            mantenedorUnidadMedida.ShowDialog();
            LlenarComboBoxUnidadMedida();
        }

        private void btnMantedorProveedor_Click(object sender, EventArgs e)
        {
            MantenedorProveedor mantenedorProveedor = new MantenedorProveedor(IdEmpleado);
            mantenedorProveedor.ShowDialog();
        }
    }
}
