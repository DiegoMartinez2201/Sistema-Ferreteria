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
    public partial class MantenedorCategoria : Form
    {
        public int IdEmpleado;
        public MantenedorCategoria(int IdEmpleado)
        {
            InitializeComponent();
            ListarCategoria();
            this.IdEmpleado = IdEmpleado;
            grupBoxDatosCategoria.Enabled = false;
            txtIdCategoria.Enabled = false;
            lblIdEmpleado.Text = $"ID Empleado: {IdEmpleado}";
            btnModificar.Visible = false;
            btnAgregar.Visible = false;
            dtPickerFechaCreacion.Enabled = false;
            cbkEstado.Enabled = false;

        }
        public void ListarCategoria()
        {
            dvgCategoria.DataSource = logCategoria.Instancia.ListarCategoria();
        }
        public void LimpiarVariables()
        {
            txtNombreCategoria.Clear();
            txtDesCategoria.Clear();
            txtIdCategoria.Clear();
            
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            grupBoxDatosCategoria.Enabled = true;
            btnAgregar.Visible=true;
            LimpiarVariables();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entCategoria categoria = new entCategoria();
                categoria.Nombre = txtNombreCategoria.Text.Trim();
                categoria.Descripcion = txtDesCategoria.Text.Trim();
                categoria.FechaCreacion = dtPickerFechaCreacion.Value;
                categoria.IdEmpleado = IdEmpleado;
                categoria.Estado = true;

                logCategoria.Instancia.InsertaCategoria(categoria);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatosCategoria.Enabled = false;
            ListarCategoria();
        }

        private void btnEdita_Click(object sender, EventArgs e)
        {
            grupBoxDatosCategoria.Enabled = true;
            btnModificar.Visible=true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entCategoria categoria = new entCategoria();
                categoria.IdCategoria = int.Parse(txtIdCategoria.Text.Trim());
                categoria.Nombre = txtNombreCategoria.Text.Trim();
                categoria.Descripcion = txtDesCategoria.Text.Trim();
                categoria.IdEmpleado = IdEmpleado;
               
                logCategoria.Instancia.EditaCategoria(categoria);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatosCategoria.Enabled = false;
            ListarCategoria();
            btnModificar.Visible = false;
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entCategoria categoria = new entCategoria();
                categoria.IdCategoria = int.Parse(txtIdCategoria.Text.Trim());
                logCategoria.Instancia.DeshabilitarCategoria(categoria);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            grupBoxDatosCategoria.Enabled = false;
            ListarCategoria();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarVariables();
            grupBoxDatosCategoria.Enabled=false;
            btnAgregar.Visible = false;
            btnModificar.Visible=false;
        }

        private void dvgCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dvgCategoria.Rows[e.RowIndex];
            txtIdCategoria.Text = filaActual.Cells[0].Value.ToString();
            txtNombreCategoria.Text = filaActual.Cells[1].Value.ToString();
            txtDesCategoria.Text = filaActual.Cells[2].Value.ToString();
        }
    }
}
