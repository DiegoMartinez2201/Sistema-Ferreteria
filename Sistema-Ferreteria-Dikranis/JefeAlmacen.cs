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
    public partial class formJefeAlmacen : Form
    {
        public formJefeAlmacen()
        {
            InitializeComponent();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            lblBienvenida.Visible = false;
            FormularioHelper.AbrirFormulario(panelForms, new MantenedorProducto());
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            lblBienvenida.Visible = false;
            FormularioHelper.AbrirFormulario(panelForms, new MantenedorCategoria());
        }

        private void btnUnidadMedida_Click(object sender, EventArgs e)
        {
            lblBienvenida.Visible = false;
            FormularioHelper.AbrirFormulario(panelForms, new MantenedorUnidadMedida());
        }

        private void btnOrdenRequerimiento_Click(object sender, EventArgs e)
        {
            lblBienvenida.Visible = false;
            FormularioHelper.AbrirFormulario(panelForms, new OrdenRequerimiento());
        }

        private void btnNotaEntrada_Click(object sender, EventArgs e)
        {
            lblBienvenida.Visible = false;
            FormularioHelper.AbrirFormulario(panelForms, new NotaEntrada());
        }

        private void btnNotaSalida_Click(object sender, EventArgs e)
        {
            lblBienvenida.Visible = false;
            FormularioHelper.AbrirFormulario(panelForms, new NotaSalida());
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();  // Cierra el formulario actual
            Login.ObtenerInstancia().Show();  // Muestra el formulario de Login
        }
    }
}
