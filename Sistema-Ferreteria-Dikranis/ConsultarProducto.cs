﻿using CapaEntidad;
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
    public partial class ConsultarProducto : Form
    {
        public event Action<int, string, decimal> ProductoSeleccionado;
        public event Action<int, string, int> ProductoSeleccionado2;


        public ConsultarProducto()
        {
            InitializeComponent();
            CargarProductos();
            txtIdProducto.Enabled = false;
            txtPrecio.Enabled = false;
        }
        public void CargarProductos()
        {
            dgvProducto.DataSource = logProducto.Instancia.Listarproductos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int IdProducto = Convert.ToInt32(txtIdProducto.Text.Trim());
            string Nombre = txtNombre.Text.Trim();
            decimal PrecioUnitario = Convert.ToDecimal(txtPrecio.Text.Trim());
            ProductoSeleccionado?.Invoke(IdProducto,Nombre,PrecioUnitario);
            this.Close();
        }

        private void dgvProducto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvProducto.Rows[e.RowIndex];
            txtIdProducto.Text = filaActual.Cells[0].Value.ToString();
            txtNombre.Text = filaActual.Cells[1].Value.ToString();
            txtPrecio.Text = filaActual.Cells[10].Value.ToString();
            txtIdProveedor.Text = filaActual.Cells[5].Value.ToString();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }
        public void DesactivarBotonTV()
        {
            btnAceptar.Visible = false;
            
        }
        public void ActivarBotonTv()
        {
            btnAceptar.Visible = true;
            txtIdProveedor.Visible = false;
            lblCodigoProveedor.Visible = false;
        }
        public void DesactivarBotonNE()
        {
            btnAceptar2.Visible = false;
        }
        public void ActivarBotonNE()
        {
            btnAceptar2.Visible = true;
            txtIdProveedor.Visible = true;
            lblCodigoProveedor.Visible = true;
        }

        private void btnAceptar2_Click(object sender, EventArgs e)
        {
            int IdProducto = Convert.ToInt32(txtIdProducto.Text.Trim());
            string Nombre = txtNombre.Text.Trim();
            int IdProveedor = Convert.ToInt32(txtIdProveedor.Text.Trim());
            ProductoSeleccionado2?.Invoke(IdProducto, Nombre,IdProveedor);
            this.Close();
        }
    }
}
