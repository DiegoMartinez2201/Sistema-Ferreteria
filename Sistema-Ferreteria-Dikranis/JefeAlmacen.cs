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
    public partial class formJefeAlmacen : Form
    {
        private int IdEmpleado;

        public formJefeAlmacen(int IdEmpleado)
        {
            InitializeComponent();
            //form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.IdEmpleado = IdEmpleado;   
        }
        private void btnProductos_Click(object sender, EventArgs e)
        {
            lblBienvenida.Visible = false;
            lblTitle.Text ="Mantenedor Productos";
            FormularioHelper.AbrirFormulario(panelForms, new MantenedorProducto(), IdEmpleado);
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            lblBienvenida.Visible = false;
            lblTitle.Text = "Mantenedor Categoría";
            FormularioHelper.AbrirFormulario(panelForms, new MantenedorCategoria(), IdEmpleado);
        }

        private void btnUnidadMedida_Click(object sender, EventArgs e)
        {
            lblBienvenida.Visible = false;
            lblTitle.Text = "Mantenedor Unidad de Medida";
            FormularioHelper.AbrirFormulario(panelForms, new MantenedorUnidadMedida(), IdEmpleado);
        }

        private void btnOrdenRequerimiento_Click(object sender, EventArgs e)
        {
            lblBienvenida.Visible = false;
            lblTitle.Text = "Realizar Orden de Requerimiento";
            FormularioHelper.AbrirFormulario(panelForms, new OrdenRequerimiento(), IdEmpleado);
        }

        private void btnNotaEntrada_Click(object sender, EventArgs e)
        {
            lblBienvenida.Visible = false;
            lblTitle.Text = "Realizar Nota de Entrada";
            FormularioHelper.AbrirFormulario(panelForms, new NotaEntrada(), IdEmpleado);
        }

        private void btnNotaSalida_Click(object sender, EventArgs e)
        {
            lblBienvenida.Visible = false;
            lblTitle.Text = "Realizar Nota de Salida";
            FormularioHelper.AbrirFormulario(panelForms, new NotaSalida(), IdEmpleado);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();  // Cierra el formulario actual
            Login.ObtenerInstancia().Show();  // Muestra el formulario de Login
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
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

        private void btnProductosFaltantes_Click(object sender, EventArgs e)
        {
            FormularioHelper.AbrirFormulario(panelForms, new NotaProductosFaltantes(), IdEmpleado);
        }
    }
}
