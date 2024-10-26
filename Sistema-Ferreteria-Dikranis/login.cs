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
using System.Runtime.InteropServices;

namespace Sistema_Ferreteria_Dikranis
{
    public partial class Login : Form
    {
        // Instancia estática privada
        private static Login instancia = null;
        private Login()
        {
            InitializeComponent();
            
        }
        public static Login ObtenerInstancia()
        {
            if (instancia == null || instancia.IsDisposed) // Verifica si la instancia es nula o ha sido cerrada
            {
                instancia = new Login();
            }
            return instancia;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparm);

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.LightGray;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.LightGray;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            if (txtContraseña.Text=="")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor= Color.DimGray;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text=="JefeCompras" & txtContraseña.Text == "compras")
            {
                JefeCompras JefeCompras = new JefeCompras();
                JefeCompras.Show();
                this.Hide();
            }
            else if (txtUsuario.Text=="JefeAlmacen" & txtContraseña.Text=="productos")
            {
                formJefeAlmacen jefeAlmacen = new formJefeAlmacen();
                jefeAlmacen.Show();
                this.Hide();
            }
            else if (txtUsuario.Text == "JefeVentas" & txtContraseña.Text =="ventas")
            {
                JefeVentas jefeVentas = new JefeVentas();
                jefeVentas.Show();
                this.Hide();
            }
        }
    }
}
