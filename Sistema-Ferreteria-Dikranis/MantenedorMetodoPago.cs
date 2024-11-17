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
    public partial class MantenedorMetodoPago : Form
    {
        private int IdEmpleado;
        public MantenedorMetodoPago(int IdEmpleado)
        {
            InitializeComponent();
            ListarMetodoPago();
            this.IdEmpleado = IdEmpleado;
            groupDatosMetodoPago.Enabled = false;
            txtIdMetodoPago.Enabled=false;
            lblIdEmpleado.Text = $"ID Empleado: {IdEmpleado}";
            btnAgregar.Visible = false;
            btnModificar.Visible = false;
            dtPickerFechaCreacion.Enabled = false;
            cbkEstado.Enabled = false;
        }
        public void LimpiarVariables()
        {
            txtIdMetodoPago.Clear();
            txtNombre.Clear();
            txtDescripcion.Clear();
        }
        public void ListarMetodoPago()
        {
            dgvMetodoPago.DataSource = logMetodoPago.Instancia.ListarMetodoPago();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            groupDatosMetodoPago.Enabled = true;
            btnAgregar.Visible=true;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entMetodoPago metodoPago = new entMetodoPago();
                metodoPago.Nombre = txtNombre.Text.Trim();
                metodoPago.Descripcion = txtDescripcion.Text.Trim();
                metodoPago.FechaCreacion = dtPickerFechaCreacion.Value;
                metodoPago.Estado = true;
                metodoPago.IdEmpleado = IdEmpleado;
                
                logMetodoPago.Instancia.InsertarMetodoPago(metodoPago);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupDatosMetodoPago.Enabled = false;
            ListarMetodoPago();
            btnAgregar.Visible = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            groupDatosMetodoPago.Enabled = true;
            btnModificar.Visible = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entMetodoPago metodoPago = new entMetodoPago();
                metodoPago.IdMetodoPago = int.Parse(txtIdMetodoPago.Text.Trim());
                metodoPago.Nombre = txtNombre.Text.Trim();
                metodoPago.Descripcion = txtDescripcion.Text.Trim();
                metodoPago.IdEmpleado = IdEmpleado;
                
                logMetodoPago.Instancia.EditaMetodoPago(metodoPago);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            groupDatosMetodoPago.Enabled = false;
            ListarMetodoPago();
            btnModificar.Visible = false;
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entMetodoPago metodoPago = new entMetodoPago();
                metodoPago.IdMetodoPago = int.Parse(txtIdMetodoPago.Text.Trim());
                logMetodoPago.Instancia.DeshabilitarMetodoPago(metodoPago);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            ListarMetodoPago();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            groupDatosMetodoPago.Enabled = false;
            btnAgregar.Visible = false;
            btnModificar.Visible =false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvMetodoPago_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvMetodoPago.Rows[e.RowIndex];
            txtIdMetodoPago.Text = filaActual.Cells[0].Value.ToString();
            txtNombre.Text = filaActual.Cells[1].Value.ToString();
            txtDescripcion.Text = filaActual.Cells[2].Value.ToString();
        }
    }
}
