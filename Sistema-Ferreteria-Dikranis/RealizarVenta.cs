using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Ferreteria_Dikranis
{
    public partial class RealizarVenta : Form
    {
        private int IdEmpleado;
        public RealizarVenta(int IdEmpleado)
        {
            InitializeComponent();
            FormularioHelper.TimerTick += horaFecha_Tick;
            this.IdEmpleado = IdEmpleado;
            LlenarComboboxMetodoPago();
            txtIdCliente.Enabled = false;
            txtCodigoTicket.Enabled = false;
            txtCodigoProducto.Enabled = false;
        }
        private void horaFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }
        private void LlenarComboboxMetodoPago()
        {
            List<entMetodoPago> listaMetodoPago = logMetodoPago.Instancia.ListarMetodoPago();
            cbxMetodoPago.DataSource = listaMetodoPago;
            cbxMetodoPago.DisplayMember = "Nombre";
            cbxMetodoPago.ValueMember = "IdMetodoPago";
        }

        private void cbxTipoDocumento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTipoDocumento.Text == "Dni")
            {
                lblNombres.Text = "Nombres";
                lblApellidos.Visible = true;
                txtApellidos.Visible = true;
            }
            else if (cbxTipoDocumento.Text == "Ruc")
            {
                lblNombres.Text = "Razon Social";
                lblApellidos.Visible = false;
                txtApellidos.Visible = false;
            }
        }
        List<entTicketVentaDetalle> detalles = new List<entTicketVentaDetalle>();
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            entTicketVentaDetalle detalle = new entTicketVentaDetalle
            {
                IdProducto = Convert.ToInt32(txtCodigoProducto.Text),
                Cantidad = Convert.ToInt32(txtCantidad.Text),
                PrecioUnitario = Convert.ToDecimal(txtPrecioUnitario.Text)
            };

            detalles.Add(detalle);

            dgvVenta.DataSource = null;
            dgvVenta.DataSource = detalles;
        }

        private void btnRealizarVenta_Click(object sender, EventArgs e)
        {
            entTicketVenta ticket = new entTicketVenta
            {
                IdCliente = Convert.ToInt32(txtIdCliente.Text),
                FechaRegistro = DateTime.Now,
                IdMetodoPago = (int)cbxMetodoPago.SelectedValue,
                IdEmpleado = IdEmpleado,
                Detalle = detalles
            };

            logTicketVenta.Instancia.RegistrarTicket(ticket);

            MessageBox.Show("Ticket registrado correctamente");
        }

        private void txtNombreCompleto_KeyDown(object sender, KeyEventArgs e)
        {
            ConsultaClientes consultarCliente = new ConsultaClientes();
            consultarCliente.ClienteSeleccionado += (IdCliente, Dni,TipoDocumento,Nombres,Apellidos,Direccion,telefono) =>
            {
                txtNumeroDocumento.Text = Dni;
                txtIdCliente.Text = IdCliente;
                cbxTipoDocumento.Text = TipoDocumento;
                txtNombreCompleto.Text = Nombres;
                txtApellidos.Text = Apellidos;
                txtDireccion.Text = Direccion;
                txtTelefono.Text = telefono;

            };
            consultarCliente.ShowDialog();
        }

        private void txtNombreProducto_KeyDown(object sender, KeyEventArgs e)
        {
            ConsultarProducto consultarProducto = new ConsultarProducto();
            consultarProducto.ProductoSeleccionado += (IdProducto, Nombre, PrecioUnitario) =>
            {
                txtCodigoProducto.Text = IdProducto.ToString();
                txtNombreProducto.Text = Nombre;
                txtPrecioUnitario.Text = PrecioUnitario.ToString("F2");
            };
            consultarProducto.ShowDialog();
        }
    }
}
