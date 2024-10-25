using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Ferreteria_Dikranis
{
    public class FormularioHelper
    {
        private static Form formularioActual = null;

        public static void AbrirFormulario(Panel panelContainer, Form nuevoFormulario)
        {
            if (formularioActual != null)
            {
                formularioActual.Close();
            }

            formularioActual = nuevoFormulario;
            nuevoFormulario.TopLevel = false;
            nuevoFormulario.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(nuevoFormulario);
            panelContainer.Tag = nuevoFormulario;
            nuevoFormulario.BringToFront();
            nuevoFormulario.Show();
        }
    }
}
