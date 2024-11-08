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
    public partial class MantenedorCargoEmpleado : Form
    {
        private int IdEmpleado;
        public MantenedorCargoEmpleado(int IdEmpleado)
        {
            InitializeComponent();
            listarCargoEmpleado();
            this.IdEmpleado = IdEmpleado;
            lblIdEmpleado.Text = $"ID Empleado: {IdEmpleado}";
            grupBoxDatosCargo.Enabled = false;
            btnAgregar.Visible = false;
            btnModificar.Visible = false;
            dtPickerFechaCreacion.Enabled = false;
            cbkEstado.Enabled = false;
            txtIdCargo.Enabled = false;
        }
        private void listarCargoEmpleado()
        {
            dgvCargo.DataSource = logCargoEmpleado.Instancia.ListarCargoEmpleado();
            
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            grupBoxDatosCargo.Enabled = true;
            btnAgregar .Visible = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entCargoEmpleado cargoEmpleado = new entCargoEmpleado();
                cargoEmpleado.nombre =txtNombre.Text.Trim();
                cargoEmpleado.FechaCreacion = dtPickerFechaCreacion.Value;
                cargoEmpleado.Estado = true;
                cargoEmpleado.IdEmpleado = IdEmpleado;
                logCargoEmpleado.Instancia.InsertaCargoEmpleado(cargoEmpleado); 
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error..." + ex);
            }
            listarCargoEmpleado();
            LimpiarCampos();
            btnAgregar.Visible = false;
            grupBoxDatosCargo.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnModificar.Visible = true;
            grupBoxDatosCargo.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entCargoEmpleado cargoEmpleado = new entCargoEmpleado();
                cargoEmpleado.IdCargo = int.Parse(txtIdCargo.Text.Trim());
                cargoEmpleado.nombre = txtNombre.Text.Trim();
                cargoEmpleado.IdEmpleado = IdEmpleado;
                logCargoEmpleado.Instancia.EditaCargoEmpleado(cargoEmpleado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error... "+ ex);
            }
            listarCargoEmpleado();
            LimpiarCampos();
            btnModificar.Visible=false;
            grupBoxDatosCargo.Enabled = false;
        }

        private void dgvCargo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvCargo.Rows[e.RowIndex];
            txtIdCargo.Text = filaActual.Cells[0].Value.ToString();
            txtNombre.Text = filaActual.Cells[1].Value.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entCargoEmpleado cargoEmpleado = new entCargoEmpleado();
                cargoEmpleado.IdCargo = int.Parse(txtIdCargo.Text.Trim());
                logCargoEmpleado.Instancia.DeshabilitaCargoEmpleado(cargoEmpleado);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error..." + ex);
            }
            listarCargoEmpleado();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            grupBoxDatosCargo.Enabled = false;
            btnAgregar.Visible = false;
            btnModificar.Visible = false;
            LimpiarCampos();

        }
        private void LimpiarCampos()
        {
            txtIdCargo.Clear();
            txtNombre.Clear();
        }
    }
}
