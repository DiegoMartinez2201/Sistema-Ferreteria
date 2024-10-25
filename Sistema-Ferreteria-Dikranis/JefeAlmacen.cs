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
            MantenedorProducto producto = new MantenedorProducto();
            producto.TopLevel = false;
            panelForms.Controls.Add(producto);
            producto.Show();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {

        }

        private void btnUnidadMedida_Click(object sender, EventArgs e)
        {

        }

        private void btnOrdenRequerimiento_Click(object sender, EventArgs e)
        {

        }

        private void btnNotaEntrada_Click(object sender, EventArgs e)
        {

        }

        private void btnNotaSalida_Click(object sender, EventArgs e)
        {

        }
    }
}
