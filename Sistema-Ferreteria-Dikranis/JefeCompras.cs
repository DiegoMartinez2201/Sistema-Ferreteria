using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Ferreteria_Dikranis
{
    public partial class JefeCompras : Form
    {
        public JefeCompras()
        {
            InitializeComponent();
            //form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }
        private void btnProductos_Click(object sender, EventArgs e)
        {
            lblBienvenida.Visible = false;
            FormularioHelper.AbrirFormulario(panelForms, new MantenedorProducto());
        }

        private void btnOrdenCompra_Click(object sender, EventArgs e)
        {
            lblBienvenida.Visible = false;
            FormularioHelper.AbrirFormulario(panelForms, new OrdenCompra());
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            lblBienvenida.Visible = false;
            FormularioHelper.AbrirFormulario(panelForms, new MantenedorProveedor());
        }

        private void btnRepresentanteProveedor_Click(object sender, EventArgs e)
        {
            lblBienvenida.Visible = false;
            FormularioHelper.AbrirFormulario(panelForms, new MantenedorRepresentanteProveedor());
        }

        private void btnOrdenRequerimiento_Click(object sender, EventArgs e)
        {
            lblBienvenida.Visible = false;

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();  // Cierra el formulario actual
            Login.ObtenerInstancia().Show();  // Muestra el formulario de Login
        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            FormularioHelper.MoveForm(this, e);
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
            FormularioHelper.AbrirFormulario(panelForms, new ConsultarProducto());
        }
    }
}
