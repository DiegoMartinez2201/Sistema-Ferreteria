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
            btnModificar.Visible = false;
            btnAgregar.Visible = false;
            dtPickerFechaCreacion.Enabled = false;
            cbkEstado.Enabled = false;


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
            cbkEstado.Enabled = true;
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
        private void MantenedorCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            grupBoxDatosCliente.Enabled = true;
            btnModificar.Visible = true;
            btnAgregar.Visible = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
            try
            {
                entCliente c = new entCliente();
                c.IdCliente = int.Parse(txtIdCliente.Text.Trim());
                c.Telefono = txtTelefono.Text.Trim();
                c.Direccion = txtDireccion.Text.Trim();
                c.Correo = txtCorreo.Text.Trim();
                c.TipoDocumento = cbxTipoDocumento.Text.Trim();
                c.IdTipoCliente = (int)cbxIdTipoCliente.SelectedValue;
                c.IdEmpelado = IdEmpleado;
                //Parametros para persona natural
                c.DNI = txtNumeroDocumento.Text.Trim();
                c.Nombres = txtNombres.Text.Trim();
                c.Apellidos = txtApellidos.Text.Trim(); 
                //Parametros para empresa
                c.Ruc = txtNumeroDocumento.Text.Trim();
                c.RazonSocial = txtNombres.Text.Trim();
                logCliente.Instancia.EditaCliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.."+ex);
            }
            LimpiarVariables();
            grupBoxDatosCliente.Enabled=false;
            listarCliente();
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvCliente.Rows[e.RowIndex];
            txtIdCliente.Text = filaActual.Cells[0].Value.ToString();
            txtCorreo.Text= filaActual.Cells[1].Value.ToString();
            cbxTipoDocumento.Text = filaActual.Cells[2].Value.ToString();
            txtTelefono.Text = filaActual.Cells[3].Value.ToString();
            txtDireccion.Text = filaActual.Cells[4].Value.ToString();
            cbxIdTipoCliente.Text = filaActual.Cells[5].Value.ToString();
            //dtPickerFechaCreacion.Text = filaActual.Cells[7].Value.ToString();
            cbkEstado.Checked = Convert.ToBoolean(filaActual.Cells[8].Value);
            if(cbxTipoDocumento.Text == "Dni")
            {
                txtNumeroDocumento.Text = filaActual.Cells[9].Value.ToString();
                txtNombres.Text = filaActual.Cells[10].Value.ToString();
                txtApellidos.Text = filaActual.Cells[11].Value.ToString();
            }
            else
            {
                txtNumeroDocumento.Text = filaActual.Cells[12].Value.ToString();
                txtNombres.Text = filaActual.Cells[13].Value.ToString();
            }
            
        }
    }
}
