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
    public partial class MantenedorCliente : Form
    {
        private int IdEmpleado; // Variable para almacenar el IdEmpleado
        public MantenedorCliente(int IdEmpleado)
        {
            InitializeComponent();
            listarCliente();
            this.IdEmpleado = IdEmpleado; // Asigna el IdEmpleado al campo privado
            grupBoxDatosCliente.Enabled = false;
            txtIdCliente.Enabled = false;
            LlenarComboBoxTipoCliente();
            lblIdEmpleado.Text = $"ID Empleado: {IdEmpleado}";


        }
        //Llenar ComboBox
        private void LlenarComboBoxTipoCliente()
        {
            List<entTipoCliente> listaTipoCliente = logTipoCliente.Instancia.ListarTipoCliente();
            cbxIdTipoCliente.DataSource = listaTipoCliente;
            cbxIdTipoCliente.DisplayMember = "Nombre";
            cbxIdTipoCliente.ValueMember = "IdTipoCliente";
        }
        public void listarCliente()
        {
            dgvCliente.DataSource = logCliente.Instancia.ListarCliente();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            grupBoxDatosCliente.Enabled = true;
            btnAgregar.Visible = true;
            LimpiarVariables();
            btnModificar.Visible = true;
        }
        public void LimpiarVariables()
        {
            txtNumeroDocumento.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entCliente c = new entCliente();
                c.Telefono = txtTelefono.Text.Trim();
                c.Direccion = txtDireccion.Text.Trim();
                c.Correo = txtCorreo.Text.Trim();
                c.TipoDocumento = cbxTipoDocumento.Text.Trim();
                c.IdTipoCliente = (int)cbxIdTipoCliente.SelectedValue;
                c.FechaCreacion = dtPickerFechaCreacion.Value;
                c.Estado = cbkEstado.Checked;
                c.IdEmpelado = IdEmpleado;
                c.DNI = txtNumeroDocumento.Text.Trim();
                c.Nombres = txtNombres.Text.Trim();
                c.Apellidos= txtApellidos.Text.Trim();
                c.Ruc = txtNumeroDocumento.Text.Trim();
                c.RazonSocial = txtNombres.Text.Trim();
                logCliente.Instancia.InsertaCliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatosCliente.Enabled = false;
            listarCliente();
        }

        private void cbxTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTipoDocumento.Text == "Dni")
            {
                lblNombres.Text = "Nombres";
                lblApellidos.Visible = true;
                txtApellidos.Visible=true;
            }
            else if (cbxTipoDocumento.Text =="Ruc")
            {
                lblNombres.Text = "Razon Social";
                lblApellidos.Visible = false;
                txtApellidos.Visible = false;
            }
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void MantenedorCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
