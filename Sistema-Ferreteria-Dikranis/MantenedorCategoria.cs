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
        private int IdEmpleado;
        public MantenedorCategoria(int IdEmpleado)
        {
            InitializeComponent();
            this.IdEmpleado = IdEmpleado;
            listarCategoria();
            lblIdEmpleado.Text = $"ID Empleado: {IdEmpleado}";
            grupBoxDatosCategoria.Enabled = false;
            btnAgregar.Visible = false;
            btnModificar.Visible = false;   
            dtPickerFechaCreacion.Enabled = false;
            cbkEstado.Enabled = false;
            txtIdCategoria.Enabled = false;
            
        }
        private void listarCategoria()
        {
            dvgCategoria.DataSource = logCategoria.Instancia.ListarCategoria();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            grupBoxDatosCategoria.Enabled = true;
            btnAgregar.Visible = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entCategoria categoria = new entCategoria();
                categoria.Nombre = txtNombreCategoria.Text.Trim();
                categoria.Descripcion = txtDesCategoria.Text.Trim();
                categoria.FechaCreacion = dtPickerFechaCreacion.Value;
                categoria.Estado = true;
                categoria.IdEmpleado = IdEmpleado;
                logCategoria.Instancia.InsertarCategoria(categoria);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error... " + ex);
            }
            listarCategoria();
            btnAgregar.Visible = false;
            LimpiarCampos();
            grupBoxDatosCategoria.Enabled = false;
        }

        private void btnEdita_Click(object sender, EventArgs e)
        {
            btnModificar.Visible = true;
            grupBoxDatosCategoria.Enabled=true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                entCategoria categoria= new entCategoria();
                categoria.IdCategoria = int.Parse(txtIdCategoria.Text.Trim());
                categoria.Nombre = txtNombreCategoria.Text.Trim();
                categoria.Descripcion = txtDesCategoria.Text.Trim();
                categoria.IdEmpleado = IdEmpleado;
                logCategoria.Instancia.EditarCategoria(categoria);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error..."+ ex);
            }
            listarCategoria();
            LimpiarCampos();
            btnModificar.Visible = false;
            grupBoxDatosCategoria.Enabled = false;

        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            try
            {
                entCategoria categoria = new entCategoria();
                categoria.IdCategoria = int.Parse(txtIdCategoria.Text.Trim());
                logCategoria.Instancia.DeshabilitarCategoria(categoria);
            }
            catch( Exception ex)
            {
                MessageBox.Show("Error..." +ex);
            }
            listarCategoria();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            grupBoxDatosCategoria.Enabled = false;
            btnAgregar.Visible = false;
            btnModificar.Visible = false;
            LimpiarCampos();
        }

        private void dvgCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dvgCategoria.Rows[e.RowIndex];
            txtIdCategoria.Text = filaActual.Cells[0].Value.ToString();
            txtNombreCategoria.Text = filaActual.Cells[1].Value.ToString();
            txtDesCategoria.Text = filaActual.Cells[2].Value.ToString();
        }
        private void LimpiarCampos()
        {
            txtIdCategoria.Clear();
            txtNombreCategoria.Clear();
            txtDesCategoria.Clear();
        }
    }
}
