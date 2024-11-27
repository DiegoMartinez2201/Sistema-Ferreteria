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
    public partial class ConsultaProveedores : Form
    {
        // Evento para pasar datos al formulario llamador
        public event Action<string, string> ProveedorSeleccionado;

        public ConsultaProveedores()
        {
            InitializeComponent();
            CargarProveedores();
            txtIdProveedor.Enabled = false;

        }
        public void CargarProveedores()
        {
            dgvProveedor.DataSource = logProveedor.Instancia.ListarProveedor();
        }

        private void FiltrarProveedores(string filtro)
        {
            // Obtener todos los proveedores
            List<entProveedor> proveedores = logProveedor.Instancia.ListarProveedor();

            // Filtrar la lista de proveedores por el RUC
            var proveedoresFiltrados = proveedores.Where(p => p.RUC.Contains(filtro)).ToList();

            // Actualizar el DataGridView con los resultados filtrados
            dgvProveedor.DataSource = proveedoresFiltrados;
        }

        private void txtRuc_TextChanged(object sender, EventArgs e)
        {
            FiltrarProveedores(txtRuc.Text.Trim());
        }

        private void dgvProveedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvProveedor.Rows[e.RowIndex];
            txtIdProveedor.Text = filaActual.Cells[0].Value.ToString();
            txtRazonSocial.Text = filaActual.Cells[1].Value.ToString();
            txtRuc.Text = filaActual.Cells[2].Value.ToString();


            
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string IdProveedor = txtIdProveedor.Text.Trim();
            string RazonSocial = txtRazonSocial.Text.Trim();

            ProveedorSeleccionado?.Invoke(IdProveedor, RazonSocial);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
      
    }
}
