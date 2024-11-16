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
    public partial class MantenedorRepresentanteProveedor : Form
    {
        public int IdEmpleado;
        public MantenedorRepresentanteProveedor(int IdEmpleado)
        {
            InitializeComponent();
            this.IdEmpleado = IdEmpleado;
            lblIdEmpleado.Text = $"ID Empleado: {IdEmpleado}";
            btnAgregar.Visible = false;
            btnModificar.Visible = false;
            dtPickerFechaCreacion.Enabled = false;
            txtIdRepresentanteProveedor.Enabled = false;
            groupBoxRepresentanteProveedor.Enabled = false;
            cbkEstado.Enabled = false;
            LimpiarVariables();
            ListarRepresentateProveedor();
        }
        public void LimpiarVariables()
        {
            txtIdRepresentanteProveedor.Clear();
            txtIdProveedor.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
        }
        public void ListarRepresentateProveedor()
        {
            dgvRepresentanteProveedor.DataSource = logRepresentanteProveedor.Instancia.ListarRepresentateProveedor();
        }
        private void txtIdProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            ConsultaProveedores consultarProveedor = new ConsultaProveedores();
            consultarProveedor.ProveedorSeleccionado += (IdProveedor, RazonSocial) =>
            {
                txtIdProveedor.Text = RazonSocial;
                txtIdProveedor.Tag = IdProveedor;
                
            };
            consultarProveedor.ShowDialog();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            groupBoxRepresentanteProveedor.Enabled = true;
            btnAgregar.Visible = true;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entRepresentanteProveedor representanteProveedor = new entRepresentanteProveedor();
                representanteProveedor.IdProveedor = int.Parse(txtIdProveedor.Tag.ToString());
                representanteProveedor.Nombres = txtNombres.Text.Trim();
                representanteProveedor.Apellidos = txtApellidos.Text.Trim();
                representanteProveedor.Correo = txtCorreo.Text.Trim();
                representanteProveedor.Telefono = txtTelefono.Text.Trim();
                representanteProveedor.FechaCreacion = dtPickerFechaCreacion.Value;
                representanteProveedor.Estado = true;
                representanteProveedor.IdEmpleado = IdEmpleado;
               
                logRepresentanteProveedor.Instancia.InsertaRepresentanteProveedor(representanteProveedor);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBoxRepresentanteProveedor.Enabled = false;
            ListarRepresentateProveedor();
            btnAgregar.Visible = false;
        }

        private void btnEdita_Click(object sender, EventArgs e)
        {
            groupBoxRepresentanteProveedor.Enabled = true;
            btnModificar.Visible = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entRepresentanteProveedor representanteProveedor = new entRepresentanteProveedor();
                representanteProveedor.IdRepresentante = int.Parse(txtIdProveedor.Text.Trim());
                representanteProveedor.IdProveedor = int.Parse(txtIdProveedor.Tag.ToString());
                representanteProveedor.Nombres = txtNombres.Text.Trim();
                representanteProveedor.Apellidos = txtApellidos.Text.Trim();
                representanteProveedor.Correo = txtCorreo.Text.Trim();
                representanteProveedor.Telefono = txtTelefono.Text.Trim();
               
                logRepresentanteProveedor.Instancia.EditaRepresentanteProveedor(representanteProveedor);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBoxRepresentanteProveedor.Enabled = false;
            ListarRepresentateProveedor();
            btnModificar.Visible = false;
        }

        private void btnDeshabilita_Click(object sender, EventArgs e)
        {
            try
            {
                entRepresentanteProveedor representanteProveedor = new entRepresentanteProveedor();
                representanteProveedor.IdRepresentante = int.Parse(txtIdRepresentanteProveedor.Text.Trim());
                logRepresentanteProveedor.Instancia.DeshabilitarRepresentateProveedor(representanteProveedor);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupBoxRepresentanteProveedor.Enabled = false;
            ListarRepresentateProveedor();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            groupBoxRepresentanteProveedor.Enabled = false;
            btnAgregar.Visible = false;
            btnModificar.Visible = false;
        }

        private void dgvRepresentanteProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvRepresentanteProveedor.Rows[e.RowIndex];
            txtIdRepresentanteProveedor.Text = filaActual.Cells[0].Value.ToString();
            txtIdProveedor.Text = filaActual.Cells[1].Value.ToString();
            txtNombres.Text = filaActual.Cells[2].Value.ToString();
            txtApellidos.Text = filaActual.Cells[3].Value.ToString();
            txtCorreo.Text = filaActual.Cells[5].Value.ToString();
            txtTelefono.Text = filaActual.Cells[4].Value.ToString();
        }

        private void btnAbrirMantedorProveedor_Click(object sender, EventArgs e)
        {
            MantenedorProveedor mantenedorProveedor = new MantenedorProveedor(IdEmpleado);
            mantenedorProveedor.ShowDialog();
        }
    }
}
