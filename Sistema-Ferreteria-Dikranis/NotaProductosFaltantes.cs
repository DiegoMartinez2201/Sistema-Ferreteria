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
    public partial class NotaProductosFaltantes : Form
    {
        public NotaProductosFaltantes()
        {
            InitializeComponent();
            // Suscribirse al evento TimerTick del GlobalTimer
            FormularioHelper.TimerTick += horaFecha_Tick;
        }

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }
    }
}
