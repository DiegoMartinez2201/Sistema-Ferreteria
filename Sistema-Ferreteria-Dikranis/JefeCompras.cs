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
        private Form formularioActual = null;
        public JefeCompras()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparm);

        private void JefeCompras_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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
    }
}
