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
    public partial class ConsultaClientes : Form
    {
        public event Action<string,string, string,string,string,string,string> ClienteSeleccionado;
        public ConsultaClientes()
        {
            InitializeComponent();
            CargarClientes();
            txtIdCliente.Enabled = false;
        }
        public void CargarClientes()
        {
            dgvClientes.DataSource = logCliente.Instancia.ListarCliente();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string IdCliente = txtIdCliente.Text.Trim();
            string Dni = txtDniRuc.Text.Trim();
            string TipoDocumento = cbxTipoDocumento.Text.Trim();

            string Nombres = txtNombre.Text.Trim();
            string Apellidos = txtApellidos.Text.Trim();
            string Direccion = txtDireccion.Text.Trim();
            string telefono = txtTelefono.Text.Trim(); 

            
            ClienteSeleccionado?.Invoke(IdCliente, Dni, TipoDocumento,Nombres,Apellidos, Direccion, telefono);
            this.Close();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvClientes.Rows[e.RowIndex];
            txtIdCliente.Text = filaActual.Cells[0].Value.ToString();
            cbxTipoDocumento.Text = filaActual.Cells[2].Value.ToString();
            txtTelefono.Text = filaActual.Cells[3].Value.ToString();
            txtDireccion.Text = filaActual.Cells[4].Value.ToString();
            //dtPickerFechaCreacion.Text = filaActual.Cells[7].Value.ToString();
            if (cbxTipoDocumento.Text == "Dni")
            {
                txtDniRuc.Text = filaActual.Cells[9].Value.ToString();
                txtNombre.Text = filaActual.Cells[10].Value.ToString();
                txtApellidos.Text = filaActual.Cells[11].Value.ToString();
            }
            else
            {
                txtDniRuc.Text = filaActual.Cells[12].Value.ToString();
                txtNombre.Text = filaActual.Cells[13].Value.ToString();
            }
        }

        private void cbxTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTipoDocumento.Text == "Dni")
            {
                lblApellidos.Visible = true;
                txtApellidos.Visible = true;
            }
            else if (cbxTipoDocumento.Text == "Ruc")
            {
                lblApellidos.Visible = false;
                txtApellidos.Visible = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
