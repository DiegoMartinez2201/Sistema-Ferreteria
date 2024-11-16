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
            this.IdEmpleado = IdEmpleado;
            lblIdEmpleado.Text = $"ID Empleado: {IdEmpleado}";
            txtIdCargo.Enabled = false;
            grupBoxDatosCargo.Enabled = false;
            btnModificar.Visible = false;
            btnAgregar.Visible = false;
            dtPickerFechaCreacion.Enabled = false;
            cbkEstado.Enabled = false;
            ListarCargo();
        }
        public void LimpiarVariables()
        {
            txtIdCargo.Clear();
            txtNombre.Clear();
        }
        public void ListarCargo()
        {
            dgvCargo.DataSource = logCargoEmpleado.Instancia.ListarCargo();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            grupBoxDatosCargo.Enabled = true;
            btnAgregar.Visible=true;
            LimpiarVariables();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entCargoEmpleado cargo = new entCargoEmpleado();
                cargo.nombre = txtNombre.Text.Trim();
                cargo.FechaCreacion = dtPickerFechaCreacion.Value;
                cargo.Estado = true;
                cargo.IdEmpleado = IdEmpleado;
               
                logCargoEmpleado.Instancia.InsertarCargo(cargo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatosCargo.Enabled = false;
            ListarCargo();
            btnAgregar.Visible = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            grupBoxDatosCargo.Enabled = true;
            btnModificar.Visible = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entCargoEmpleado cargo = new entCargoEmpleado();
                cargo.IdCargo = int.Parse(txtIdCargo.Text.Trim());
                cargo.nombre = txtNombre.Text.Trim();
                cargo.IdEmpleado = IdEmpleado;
                
                logCargoEmpleado.Instancia.EditarCargo(cargo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatosCargo.Enabled = false;
            ListarCargo();
            btnModificar.Visible = false;
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entCargoEmpleado cargo = new entCargoEmpleado();
                cargo.IdCargo = int.Parse(txtIdCargo.Text.Trim());
                logCargoEmpleado.Instancia.DeshabilitarCargo(cargo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatosCargo.Enabled = false;
            ListarCargo();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            grupBoxDatosCargo.Enabled = false;
            LimpiarVariables();
            btnAgregar.Visible = false;
            btnModificar.Visible = false;
        }

        private void dgvCargo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvCargo.Rows[e.RowIndex];
            txtIdCargo.Text = filaActual.Cells[0].Value.ToString();
            txtNombre.Text = filaActual.Cells[1].Value.ToString();
        }
    }
}
