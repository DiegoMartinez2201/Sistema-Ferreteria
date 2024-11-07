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
    public partial class MantenedorUnidadMedida : Form
    {
        private int IdEmpleado;
        public MantenedorUnidadMedida(int IdEmpleado)
        {
            InitializeComponent();
            listarUnidadMedida();
            this.IdEmpleado = IdEmpleado;
            lblIdEmpleado.Text = $"ID Empleado: {IdEmpleado}";
            groupBoxUnidadMedida.Enabled = false;
            btnAgregar.Visible = false;
            btnModificar.Visible = false;
            dtPickerFechaCreacion.Enabled = false;
            cbkEstado.Enabled = false;
        }

        private void dgvUnidadMedida_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void listarUnidadMedida() 
        {
            dgvUnidadMedida.DataSource = logUnidadMedida.Instancia.ListarUnidadMedida();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            groupBoxUnidadMedida.Enabled = true;
            btnAgregar.Visible = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entUnidadMedida unidadMedida = new entUnidadMedida();
                unidadMedida.Nombre = txtNombre.Text.Trim();
                unidadMedida.Abreviatura = txtAbreviatura.Text.Trim();
                unidadMedida.FechaCreacion = dtPickerFechaCreacion.Value;
                unidadMedida.IdEmpleado = IdEmpleado;
                unidadMedida.Estado = true;
                logUnidadMedida.Instancia.InsertaUnidadMedida(unidadMedida);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            listarUnidadMedida();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            btnModificar.Visible = true;
            groupBoxUnidadMedida.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void dgvUnidadMedida_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
