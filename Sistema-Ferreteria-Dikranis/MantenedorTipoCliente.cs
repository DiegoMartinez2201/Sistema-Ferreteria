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
    public partial class MantenedorTipoCliente : Form
    {
        private int IdEmpleado;
        public MantenedorTipoCliente(int IdEmpleado)
        {
            InitializeComponent();
            this.IdEmpleado = IdEmpleado;
            lblIdEmpleado.Text = $"ID Empleado: {IdEmpleado}";
            btnModificar.Visible = false;
            btnAgregar.Visible = false; 
            dtPickerFechaCreacion.Enabled = false;
            txtCodigo.Enabled = false;
            groupBoxTipoCliente.Enabled = false;
            cbkEstado.Enabled = false;
            ListarTipoCliente();
        }
        public void ListarTipoCliente()
        {
            dgvTipoCliente.DataSource = logTipoCliente.Instancia.ListarTipoCliente();
        }
        public void LimpiarVariables()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            groupBoxTipoCliente.Enabled = true;
            btnAgregar.Visible = true;
            LimpiarVariables();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entTipoCliente tipoCliente = new entTipoCliente();
                tipoCliente.Nombre = txtNombre.Text;
                tipoCliente.FechaCreacion = dtPickerFechaCreacion.Value;
                tipoCliente.Estado = true;
                tipoCliente.IdEmpleado = IdEmpleado;
                logTipoCliente.Instancia.InsertarTipoCliente(tipoCliente);
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Error... "+ex);
            }
            LimpiarVariables();
            groupBoxTipoCliente.Enabled=false;
            ListarTipoCliente();
            btnAgregar.Visible=false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupBoxTipoCliente.Enabled = true;
            btnModificar.Visible = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            try
            {
                entTipoCliente tipoCliente = new entTipoCliente();
                tipoCliente.IdTipoCliente = int.Parse(txtCodigo.Text.Trim());
                tipoCliente.Nombre = txtNombre.Text.Trim();
                tipoCliente.IdEmpleado = IdEmpleado;
                logTipoCliente.Instancia.EditarTipoCliente(tipoCliente);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error..." + ex);
            }
            groupBoxTipoCliente.Enabled = false;
            LimpiarVariables();
            ListarTipoCliente() ;
            btnModificar.Visible = false;
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entTipoCliente tipoCliente = new entTipoCliente();
                tipoCliente.IdTipoCliente = int.Parse(txtCodigo.Text.Trim());
                logTipoCliente.Instancia.DeshabilitarTipoCliente(tipoCliente);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            groupBoxTipoCliente.Enabled=false;
            btnAgregar.Visible =false;  
            btnModificar.Visible=false; 
        }

        private void dgvTipoCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvTipoCliente.Rows[e.RowIndex];
            txtCodigo.Text = filaActual.Cells[0].Value.ToString();
            txtNombre.Text = filaActual.Cells[1].Value.ToString();
        }
    }
}
