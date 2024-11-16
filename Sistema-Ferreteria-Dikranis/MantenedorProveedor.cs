using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Ferreteria_Dikranis
{
    public partial class MantenedorProveedor : Form
    {
        public int IdEmpleado;
        public MantenedorProveedor(int IdEmpleado)
        {
            InitializeComponent();
            this.IdEmpleado = IdEmpleado;
            LlenarComboboxCategoria();
            ListarProveedor();
            lblIdEmpleado.Text = $"ID Empleado: {IdEmpleado}";
            btnModificar.Visible = false;
            btnAgregar.Visible = false;
            dtPickerFechaCreacion.Enabled = false;
            txtidProveedor.Enabled = false;
            grupBoxProveedor.Enabled=false;
            cbkEstado.Enabled = false;
            LimpiarVariables();
        }
        public void LlenarComboboxCategoria()
        {
            List<entCategoria> listaCategoria = logCategoria.Instancia.ListarCategoria();
            cbxCategoria.DataSource = listaCategoria;
            cbxCategoria.DisplayMember="Nombre";
            cbxCategoria.ValueMember = "IdCategoria";
        }
        public void ListarProveedor()
        {
            dgvProveedor.DataSource = logProveedor.Instancia.ListarProveedor();
        }
        public void LimpiarVariables()
        {
            txtidProveedor.Clear();
            txtRUC.Clear();
            txtRazonSocial.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            grupBoxProveedor.Enabled = true;
            btnAgregar.Visible=true;
            LimpiarVariables();
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            grupBoxProveedor.Enabled=true;
            btnModificar.Visible=true;
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entProveedor proveedor = new entProveedor();
                proveedor.IdProveedor = int.Parse(txtidProveedor.Text.Trim());
                logProveedor.Instancia.DeshabilitarProveedor(proveedor);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxProveedor.Enabled = false;
            ListarProveedor();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entProveedor proveedor = new entProveedor();
                proveedor.RUC = txtRUC.Text;
                proveedor.RazonSocial = txtRazonSocial.Text;
                proveedor.Correo = txtCorreo.Text;
                proveedor.Telefono = txtTelefono.Text;
                proveedor.Direccion = txtDireccion.Text;
                proveedor.FechaCreacion = dtPickerFechaCreacion.Value;
                proveedor.Estado = true;
                proveedor.IdEmpleado = IdEmpleado;
                proveedor.IdCategoria = (int)cbxCategoria.SelectedValue;
                logProveedor.Instancia.InsertaProveedor(proveedor);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxProveedor.Enabled = false;
            ListarProveedor();
            btnAgregar.Visible = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entProveedor proveedor = new entProveedor();
                proveedor.IdProveedor = int.Parse(txtidProveedor.Text.Trim());
                proveedor.RUC = txtRUC.Text.Trim();
                proveedor.RazonSocial = txtRazonSocial.Text.Trim();
                proveedor.Correo = txtCorreo.Text.Trim();
                proveedor.Telefono = txtTelefono.Text.Trim();
                proveedor.Direccion = txtDireccion.Text.Trim();
                proveedor.IdEmpleado = IdEmpleado;
                proveedor.IdCategoria = (int)cbxCategoria.SelectedValue;

                logProveedor.Instancia.EditaProveedor(proveedor);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxProveedor.Enabled = false;
            ListarProveedor();
            btnModificar.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            grupBoxProveedor.Enabled=false;
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            MantenedorCategoria mantenedorCategoria = new MantenedorCategoria(IdEmpleado);
            mantenedorCategoria.ShowDialog();
        }

        private void cbxCategoria_Click(object sender, EventArgs e)
        {
            LlenarComboboxCategoria();
        }

        private void dgvProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvProveedor.Rows[e.RowIndex];
            txtidProveedor.Text = filaActual.Cells[0].Value.ToString();
            txtRazonSocial.Text = filaActual.Cells[1].Value.ToString();
            cbxCategoria.Text = filaActual.Cells[9].Value.ToString();
            txtRUC.Text = filaActual.Cells[2].Value.ToString();
            txtCorreo.Text = filaActual.Cells[5].Value.ToString();
            txtTelefono.Text = filaActual.Cells[4].Value.ToString();
            txtDireccion.Text = filaActual.Cells[3].Value.ToString();

        }
    }
}
