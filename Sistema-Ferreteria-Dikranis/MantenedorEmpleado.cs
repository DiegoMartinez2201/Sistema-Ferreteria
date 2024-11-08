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
            listaEmpleado(); 
            this.IdEmpleado = IdEmpleado; 
            lblIdEmpleado.Text = $"ID Empleado: {IdEmpleado}";
            grupBoxDatosEmpleado.Enabled = false;
            LlenarComboBoxCargoEmpleado();
            btnAgregar.Visible = false;
            btnModificar.Visible = false;   
            dtPickerFechaCreacion.Enabled = false;
            cbkEstado.Enabled = false;
            txtIdEmpleado.Enabled = false;
        }
        private void listaEmpleado()
        {
            dgvEmpleado.DataSource = logEmpleado.Instancia.ListarEmpleado();
        }
        private void LlenarComboBoxCargoEmpleado()
        {
            List<entCargoEmpleado> listaCargoEmpleado = logCargoEmpleado.Instancia.ListarCargoEmpleado();
            cbxIdCargo.DataSource = listaCargoEmpleado;
            cbxIdCargo.DisplayMember = "nombre";
            cbxIdCargo.ValueMember = "IdCargo";
        }
        public void LimpiarVariables()
        {
            txtIdEmpleado.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtDni.Clear();
            txtTelefono.Clear();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            grupBoxDatosEmpleado.Enabled = true;
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
                empleado.Estado = true;
                empleado.IdCargo = (int)cbxIdCargo.SelectedValue;
                empleado.FechaCreacion = dtPickerFechaCreacion.Value;
                empleado.NameLogin = txtNameLogin.Text.Trim();
                empleado.Password = txtPassword.Text.Trim();
                empleado.IdEmpleadoRegistro = IdEmpleado;
                logEmpleado.Instancia.InsertaEmpleado(empleado);
                   
            }   
            catch(Exception ex) 
            {
                MessageBox.Show("Error.. "+ ex);
            }
            LimpiarVariables();
            grupBoxDatosEmpleado.Enabled=false;
            btnAgregar.Visible=false;
            listaEmpleado();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            grupBoxDatosEmpleado.Enabled = true;
            btnModificar.Visible = true;
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entEmpleado empleado = new entEmpleado();
                empleado.IdEmpleado = int.Parse(txtIdEmpleado.Text.Trim());
                logEmpleado.Instancia.DeshabilitarEmpleado(empleado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error..." + ex);
            }
            LimpiarVariables();
            grupBoxDatosEmpleado.Enabled = false;
            listaEmpleado();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entEmpleado empleado = new entEmpleado();
                empleado.IdEmpleado = int.Parse(txtIdEmpleado.Text.Trim());
                empleado.Nombres = txtNombres.Text.Trim();
                empleado.Apellidos = txtApellidos.Text.Trim();
                empleado.telefono = txtTelefono.Text.Trim();
                empleado.IdCargo = (int)cbxIdCargo.SelectedValue;
                empleado.NameLogin = txtNameLogin.Text.Trim();
                empleado.Password = txtPassword.Text.Trim();
                empleado.IdEmpleadoRegistro = IdEmpleado;
                logEmpleado.Instancia.EditarEmpleado(empleado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error..."+ex);
            }
            LimpiarVariables();
            grupBoxDatosEmpleado.Enabled = false;
            btnModificar.Visible = false;
            listaEmpleado();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            grupBoxDatosEmpleado.Enabled = false;
            btnAgregar.Visible = false;
            btnModificar.Visible=false;
        }

        private void btnAgregarCargo_Click(object sender, EventArgs e)
        {
            MantenedorCargoEmpleado mantenedorCargo = new MantenedorCargoEmpleado(IdEmpleado);
            mantenedorCargo.ShowDialog();
        }

        private void cbxIdCargo_Click(object sender, EventArgs e)
        {
            LlenarComboBoxCargoEmpleado();
        }
    }
}
