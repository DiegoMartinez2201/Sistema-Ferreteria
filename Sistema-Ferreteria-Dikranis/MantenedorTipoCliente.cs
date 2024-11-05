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
            ListarTipoCliente();
            groupBoxTipoCliente.Enabled = false;
            btnAgregar.Visible = false;
            
        }
        public void ListarTipoCliente()
        {
            dgvTipoCliente.DataSource = logTipoCliente.Instancia.ListarTipoCliente();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            groupBoxTipoCliente.Enabled=true;
            btnAgregar.Visible=true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                entTipoCliente c = new entTipoCliente();
                c.Nombre = txtNombre.Text.Trim();
                c.FechaCreacion = dtpFechaCreacion.Value;
                c.Estado = cbkEstado.Checked;
                c.IdEmpleado = IdEmpleado;  
                logTipoCliente.Instancia.InsertarTipoCliente(c);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            ListarTipoCliente();
        }
    }
}
