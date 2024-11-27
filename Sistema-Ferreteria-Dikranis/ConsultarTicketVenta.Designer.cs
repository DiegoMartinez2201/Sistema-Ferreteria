namespace Sistema_Ferreteria_Dikranis
{
    partial class ConsultarTicketVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTicketVenta = new System.Windows.Forms.DataGridView();
            this.dgvTicketVentaDetalle = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdTicketVenta = new System.Windows.Forms.TextBox();
            this.dtPickerFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtPickerFechaFin = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicketVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicketVentaDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultar Ticket Venta";
            // 
            // dgvTicketVenta
            // 
            this.dgvTicketVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTicketVenta.Location = new System.Drawing.Point(223, 238);
            this.dgvTicketVenta.Name = "dgvTicketVenta";
            this.dgvTicketVenta.Size = new System.Drawing.Size(275, 122);
            this.dgvTicketVenta.TabIndex = 1;
            this.dgvTicketVenta.SelectionChanged += new System.EventHandler(this.dgvTicketVenta_SelectionChanged);
            // 
            // dgvTicketVentaDetalle
            // 
            this.dgvTicketVentaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTicketVentaDetalle.Location = new System.Drawing.Point(54, 383);
            this.dgvTicketVentaDetalle.Name = "dgvTicketVentaDetalle";
            this.dgvTicketVentaDetalle.Size = new System.Drawing.Size(628, 131);
            this.dgvTicketVentaDetalle.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Código Ticket Venta:";
            // 
            // txtIdTicketVenta
            // 
            this.txtIdTicketVenta.Location = new System.Drawing.Point(184, 74);
            this.txtIdTicketVenta.Name = "txtIdTicketVenta";
            this.txtIdTicketVenta.Size = new System.Drawing.Size(100, 20);
            this.txtIdTicketVenta.TabIndex = 4;
            this.txtIdTicketVenta.TextChanged += new System.EventHandler(this.txtIdTicketVenta_TextChanged);
            // 
            // dtPickerFechaInicio
            // 
            this.dtPickerFechaInicio.Location = new System.Drawing.Point(184, 117);
            this.dtPickerFechaInicio.Name = "dtPickerFechaInicio";
            this.dtPickerFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dtPickerFechaInicio.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha Inicio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(411, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fecha Fin:";
            // 
            // dtPickerFechaFin
            // 
            this.dtPickerFechaFin.Location = new System.Drawing.Point(484, 117);
            this.dtPickerFechaFin.Name = "dtPickerFechaFin";
            this.dtPickerFechaFin.Size = new System.Drawing.Size(200, 20);
            this.dtPickerFechaFin.TabIndex = 8;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(327, 178);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(511, 577);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 10;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(607, 577);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ConsultarTicketVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(698, 610);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dtPickerFechaFin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtPickerFechaInicio);
            this.Controls.Add(this.txtIdTicketVenta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvTicketVentaDetalle);
            this.Controls.Add(this.dgvTicketVenta);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarTicketVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarTicketVenta";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicketVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTicketVentaDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTicketVenta;
        private System.Windows.Forms.DataGridView dgvTicketVentaDetalle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdTicketVenta;
        private System.Windows.Forms.DateTimePicker dtPickerFechaInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtPickerFechaFin;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}