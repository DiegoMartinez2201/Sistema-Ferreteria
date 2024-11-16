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
    public partial class MantenedorEmpleado : Form
    {
        private int IdEmpleado;
        public MantenedorEmpleado(int IdEmpleado)
        {
            InitializeComponent();
            this.IdEmpleado= IdEmpleado;
            grupBoxDatosEmpleado.Enabled = false;
            btnAgregar.Visible = false; 
            btnModificar.Visible = false;
            lblIdEmpleado.Text = $"ID Empleado: {IdEmpleado}";
            dtPickerFechaCreacion.Enabled = false;
            cbkEstado.Enabled = false;
            txtIdEmpleado.Enabled = false;
            ListarEmpleado();
            LlenarComboboxCargoEmpleado();

        }
        private void LlenarComboboxCargoEmpleado()
        {
            List<entCargoEmpleado> listaCargoEmpleado = logCargoEmpleado.Instancia.ListarCargo();
            cbxIdCargo.DataSource = listaCargoEmpleado;
            cbxIdCargo.DisplayMember = "nombre";
            cbxIdCargo.ValueMember = "IdCargo";
        }
        public void ListarEmpleado()
        {
            dgvEmpleado.DataSource = logEmpleado.Instancia.ListarEmpleado();
        }
        public void LimpiarVariables()
        {
            txtIdEmpleado.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtDni.Clear();
            txtCorreo.Clear();
            txtContraseña.Clear();
            txtTelefono.Clear();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            grupBoxDatosEmpleado.Enabled =true;
            btnAgregar.Visible = true;
            LimpiarVariables();
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entEmpleado empleado = new entEmpleado();
                empleado.Dni = txtDni.Text.Trim();
                empleado.Nombres = txtNombres.Text.Trim();
                empleado.Apellidos = txtApellidos.Text.Trim();
                empleado.telefono = txtTelefono.Text.Trim();
                empleado.IdCargo = (int)cbxIdCargo.SelectedValue;
                empleado.FechaCreacion = dtPickerFechaCreacion.Value;
                empleado.NameLogin = txtCorreo.Text.Trim();
                empleado.Password = txtContraseña.Text.Trim();
                empleado.Estado = true;
                empleado.IdEmpleadoRegistro = IdEmpleado;
                logEmpleado.Instancia.InsertEmpleado(empleado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." +ex);
            }
            LimpiarVariables();
            grupBoxDatosEmpleado.Enabled =false;
            ListarEmpleado();
            btnAgregar.Visible =false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            grupBoxDatosEmpleado.Enabled = true;
            btnModificar.Visible = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entEmpleado empleado = new entEmpleado();
                empleado.IdEmpleado = int.Parse(txtIdEmpleado.Text.Trim());
                empleado.Dni = txtDni.Text.Trim();
                empleado.Nombres = txtNombres.Text.Trim();
                empleado.Apellidos = txtApellidos.Text.Trim();
                empleado.telefono = txtTelefono.Text.Trim();
                empleado.IdCargo = (int)cbxIdCargo.SelectedValue;
                empleado.NameLogin = txtCorreo.Text.Trim();
                empleado.Password = txtContraseña.Text.Trim();
                empleado.IdEmpleadoRegistro = IdEmpleado;
                logEmpleado.Instancia.EditaEmpleado(empleado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error..."+ex);
            }
            btnModificar.Visible=false;
            grupBoxDatosEmpleado.Enabled=false;
            LimpiarVariables();
            ListarEmpleado();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entEmpleado empleado = new entEmpleado();
                empleado.IdEmpleado = int.Parse(txtIdEmpleado.Text.Trim());
                logEmpleado.Instancia.DeshabilitarEmpleado(empleado);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            ListarEmpleado();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            grupBoxDatosEmpleado.Enabled = false;
            btnAgregar.Visible = false;
            btnModificar.Visible = false;
        }

        private void btnMantenedorCargo_Click(object sender, EventArgs e)
        {
            MantenedorCargoEmpleado mantenedorCargoEmpleado = new MantenedorCargoEmpleado(IdEmpleado);
            mantenedorCargoEmpleado.ShowDialog();
            LlenarComboboxCargoEmpleado();
        }

        private void dgvEmpleado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvEmpleado.Rows[e.RowIndex];
            txtIdEmpleado.Text = filaActual.Cells[0].Value.ToString();
            txtDni.Text = filaActual.Cells[1].Value.ToString();
            txtNombres.Text = filaActual.Cells[2].Value.ToString();
            txtApellidos.Text = filaActual.Cells[3].Value.ToString();
            txtTelefono.Text = filaActual.Cells[4].Value.ToString();
            txtCorreo.Text = filaActual.Cells[7].Value.ToString();
            txtContraseña.Text = filaActual.Cells[8].Value.ToString();
            
        }
    }
}
