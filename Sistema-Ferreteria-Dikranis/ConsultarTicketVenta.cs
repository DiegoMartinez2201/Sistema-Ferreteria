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

namespace Sistema_Ferreteria_Dikranis
{
    public partial class ConsultarTicketVenta : Form
    {
        public event Action<int> TicketSeleccionado;

        public ConsultarTicketVenta()
        {
            InitializeComponent();
            ConfigurarColumnasTicketVenta();
        }
        private void ConfigurarColumnasTicketVenta()
        {
            // Configurar el DataGridView para seleccionar filas completas
            dgvTicketVenta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTicketVenta.MultiSelect = false; // Permitir seleccionar solo una fila
            dgvTicketVenta.AutoGenerateColumns = false; // Usar columnas personalizadas

            // Configurar columnas visibles
            dgvTicketVenta.Columns.Clear(); // Limpiar las columnas existentes
            dgvTicketVenta.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "IdTicketVenta", // Nombre de la propiedad en los datos
                HeaderText = "ID Ticket",          // Texto del encabezado
                Name = "colIdTicketVenta"
            });
            dgvTicketVenta.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FechaRegistro",
                HeaderText = "Fecha Registro",
                Name = "colFechaRegistro"
            });

            // Conectar el evento SelectionChanged
            dgvTicketVenta.SelectionChanged += dgvTicketVenta_SelectionChanged;
            //Configurar dgv Detalle
            dgvTicketVentaDetalle.AutoGenerateColumns = false;
            dgvTicketVentaDetalle.Columns.Clear();
            dgvTicketVentaDetalle.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "IdProducto",
                HeaderText = "ID Producto",
                Name = "colIdProducto"
            });
            dgvTicketVentaDetalle.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Nombre",
                HeaderText = "Nombre Producto",
                Name = "colNombreProducto"
            });
            dgvTicketVentaDetalle.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Cantidad",
                HeaderText = "Cantidad Producto",
                Name = "colCantidadProducto"
            });
            dgvTicketVentaDetalle.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FechaRegistro",
                HeaderText = "Fecha Registro",
                Name = "colFechaRegistro"
            });

        }

        public void ListarTickeVenta(DateTime FechaInicio, DateTime FechaFin)
        {
            try
            {
                var tickets = logTicketVenta.Instancia.ListarTicketVenta(FechaInicio, FechaFin);

                if (tickets == null || tickets.Count == 0)
                {
                    MessageBox.Show("No se encontraron tickets en el rango de fechas seleccionado.",
                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvTicketVenta.DataSource = null;
                }
                else
                {
                    dgvTicketVenta.DataSource = tickets;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al listar los tickets: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MostrarDetalleTicketVenta(int IdTicketVenta)
        {
            try
            {
                var detalles = logTicketVentaDetalle.Instancia.ListarTicketVentaDetalle(IdTicketVenta);

                if (detalles == null || detalles.Count == 0)
                {
                    MessageBox.Show("No se encontraron detalles para el ticket seleccionado.",
                        "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvTicketVentaDetalle.DataSource = null;
                }
                else
                {
                    dgvTicketVentaDetalle.DataSource = detalles;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al cargar los detalles: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DateTime FechaInicio = dtPickerFechaInicio.Value.Date;
            DateTime FechaFin = dtPickerFechaFin.Value.Date;

            if (FechaInicio > FechaFin)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha de fin.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListarTickeVenta(FechaInicio, FechaFin);
        }

       

        private void txtIdTicketVenta_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtIdTicketVenta.Text.Trim(), out int IdTicketVenta))
            {
                MostrarDetalleTicketVenta(IdTicketVenta);
            }
            else
            {
                // Limpiar el DataGridView si el valor no es válido
                dgvTicketVentaDetalle.DataSource = null;
            }
        }

        private void dgvTicketVenta_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTicketVenta.SelectedRows.Count > 0) // Validar si hay una fila seleccionada
            {
                DataGridViewRow filaActual = dgvTicketVenta.SelectedRows[0];
                txtIdTicketVenta.Text = filaActual.Cells["colIdTicketVenta"]?.Value?.ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            int IdTicketVenta = Convert.ToInt32(txtIdTicketVenta.Text.Trim());
            TicketSeleccionado?.Invoke(IdTicketVenta);
            this.Close();
        }
    }
}
