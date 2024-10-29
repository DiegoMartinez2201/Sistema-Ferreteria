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
            FormularioHelper.MoveForm(this,e);
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContraseña.Text.Trim();

            entEmpleado objEmpleado = logEmpleado.Instancia.ValidarEmpleado(usuario, contrasena);

            if (objEmpleado != null)
            {
                MessageBox.Show("Login exitoso. Bienvenido " + objEmpleado.Nombres);
                
                if (objEmpleado.IdCargo ==1)
                {
                    JefeVentas jefeVentas = new JefeVentas(objEmpleado.IdEmpleado);
                    jefeVentas.Show();
                    this.Hide();
                }
                else if (objEmpleado.IdCargo ==2)
                {
                    Administrador administrador = new Administrador(objEmpleado.IdEmpleado);
                    administrador.Show();
                    this.Hide();
                }
                else if (objEmpleado.IdCargo ==3)
                {
                    JefeCompras JefeCompras = new JefeCompras(objEmpleado.IdEmpleado);
                    JefeCompras.Show();
                    this.Hide();
                }
                else if (objEmpleado.IdCargo ==4)
                {
                    formJefeAlmacen jefeAlmacen = new formJefeAlmacen(objEmpleado.IdEmpleado);
                    jefeAlmacen.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos. Intente de nuevo.");
            }
        }
    }
}
