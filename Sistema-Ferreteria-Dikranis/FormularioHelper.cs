using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Ferreteria_Dikranis
{
    public class FormularioHelper
    {
        private static Form formularioActual = null;

        public static void AbrirFormulario(Panel panelContainer, Form nuevoFormulario, int IdEmpleado)
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
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private static extern void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

        public static void MoveForm(Form form, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(form.Handle, 0x112, 0xf012, 0);
        }

        public static Timer TimerInstance { get; private set; } = new Timer();
        public static event EventHandler TimerTick;
        static FormularioHelper()
        {
            TimerInstance.Interval = 500; // Intervalo de 1 segundo
            TimerInstance.Tick += OnTimerTick;
            TimerInstance.Start();
        }
        private static void OnTimerTick(object sender, EventArgs e)
        {
            TimerTick?.Invoke(sender, e); // Llama al evento global para los suscriptores
        }
    }
}
