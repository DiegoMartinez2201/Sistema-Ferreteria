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
    public partial class Administrador : Form
    {
        private int IdEmpleado;

        public Administrador(int IdEmpleado)
        {
            InitializeComponent();
            //form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.IdEmpleado = IdEmpleado;
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
            if (WindowState==FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState=FormWindowState.Normal;
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FormularioHelper.AbrirFormulario(panelForms, new ConsultarProducto(), IdEmpleado);
        }
        
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();  // Cierra el formulario actual
            Login.ObtenerInstancia().Show();  // Muestra el formulario de Login
        }

        private void btnOrdenRequerimiento_Click(object sender, EventArgs e)
        {
            FormularioHelper.AbrirFormulario(panelForms, new OrdenRequerimiento(), IdEmpleado);

        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            FormularioHelper.AbrirFormulario(panelForms, new MantenedorEmpleado(IdEmpleado), IdEmpleado);
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            FormularioHelper.AbrirFormulario(panelForms, new ConsultaProveedores(), IdEmpleado);

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            FormularioHelper.AbrirFormulario(panelForms, new ConsultaClientes(), IdEmpleado);

        }

        private void btnCargoEmpleado_Click(object sender, EventArgs e)
        {
            FormularioHelper.AbrirFormulario(panelForms, new MantenedorCargoEmpleado(IdEmpleado), IdEmpleado);
        }

        private void btnMetodoPago_Click(object sender, EventArgs e)
        {
            FormularioHelper.AbrirFormulario(panelForms, new MantenedorMetodoPago(IdEmpleado), IdEmpleado);
        }
    }
}
