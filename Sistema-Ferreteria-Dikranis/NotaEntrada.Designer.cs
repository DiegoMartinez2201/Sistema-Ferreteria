namespace Sistema_Ferreteria_Dikranis
{
    partial class NotaEntrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotaEntrada));
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.dtPickerFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupDatosProductos = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigoNotaEntrada = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            this.groupDatosProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProducto
            // 
            this.dgvProducto.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Location = new System.Drawing.Point(16, 318);
            this.dgvProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.RowHeadersWidth = 51;
            this.dgvProducto.Size = new System.Drawing.Size(1000, 200);
            this.dgvProducto.TabIndex = 0;
            // 
            // dtPickerFechaRegistro
            // 
            this.dtPickerFechaRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickerFechaRegistro.Location = new System.Drawing.Point(204, 197);
            this.dtPickerFechaRegistro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtPickerFechaRegistro.Name = "dtPickerFechaRegistro";
            this.dtPickerFechaRegistro.Size = new System.Drawing.Size(265, 22);
            this.dtPickerFechaRegistro.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(13, 200);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fecha de Registro:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(13, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Código del Producto:";
            // 
            // groupDatosProductos
            // 
            this.groupDatosProductos.Controls.Add(this.txtCantidad);
            this.groupDatosProductos.Controls.Add(this.label5);
            this.groupDatosProductos.Controls.Add(this.btnEliminar);
            this.groupDatosProductos.Controls.Add(this.btnAgregar);
            this.groupDatosProductos.Controls.Add(this.txtNombreProducto);
            this.groupDatosProductos.Controls.Add(this.label4);
            this.groupDatosProductos.Controls.Add(this.txtCodigoProducto);
            this.groupDatosProductos.Controls.Add(this.label2);
            this.groupDatosProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDatosProductos.ForeColor = System.Drawing.Color.Black;
            this.groupDatosProductos.Location = new System.Drawing.Point(518, 48);
            this.groupDatosProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupDatosProductos.Name = "groupDatosProductos";
            this.groupDatosProductos.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupDatosProductos.Size = new System.Drawing.Size(498, 231);
            this.groupDatosProductos.TabIndex = 4;
            this.groupDatosProductos.TabStop = false;
            this.groupDatosProductos.Text = "Producto";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(360, 176);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(252, 176);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 28);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(200, 72);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(218, 24);
            this.txtNombreProducto.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(8, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nombre del Producto:";
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Location = new System.Drawing.Point(200, 33);
            this.txtCodigoProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(218, 24);
            this.txtCodigoProducto.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(10, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Código de Nota de Entrada:";
            // 
            // txtCodigoNotaEntrada
            // 
            this.txtCodigoNotaEntrada.Location = new System.Drawing.Point(247, 155);
            this.txtCodigoNotaEntrada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodigoNotaEntrada.Name = "txtCodigoNotaEntrada";
            this.txtCodigoNotaEntrada.Size = new System.Drawing.Size(222, 22);
            this.txtCodigoNotaEntrada.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(200, 108);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(218, 24);
            this.txtCantidad.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnAnular
            // 
            this.btnAnular.BackColor = System.Drawing.Color.Transparent;
            this.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular.ForeColor = System.Drawing.Color.Black;
            this.btnAnular.Location = new System.Drawing.Point(149, 246);
            this.btnAnular.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(108, 42);
            this.btnAnular.TabIndex = 11;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrar.Location = new System.Drawing.Point(13, 246);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(101, 42);
            this.btnRegistrar.TabIndex = 12;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(260, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 70);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // NotaEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1068, 554);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.txtCodigoNotaEntrada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupDatosProductos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtPickerFechaRegistro);
            this.Controls.Add(this.dgvProducto);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NotaEntrada";
            this.Text = "NotaEntrada";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            this.groupDatosProductos.ResumeLayout(false);
            this.groupDatosProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducto;
        private System.Windows.Forms.DateTimePicker dtPickerFechaRegistro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupDatosProductos;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigoNotaEntrada;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}