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
    public partial class JefeVentas : Form
    {
        public JefeVentas()
        {
            InitializeComponent();
            //form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FormularioHelper.AbrirFormulario(panelForms, new ConsultarProducto());
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            FormularioHelper.AbrirFormulario(panelForms, new RealizarVenta());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormularioHelper.AbrirFormulario(panelForms, new MantenedorCliente());
        }

        private void btnReporteVentas_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();  // Cierra el formulario actual
            Login.ObtenerInstancia().Show();  // Muestra el formulario de Login
        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            FormularioHelper.MoveForm(this,e);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
