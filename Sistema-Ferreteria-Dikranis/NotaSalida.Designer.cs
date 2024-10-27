namespace Sistema_Ferreteria_Dikranis
{
    partial class NotaSalida
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
            this.txtCodigoNotaSalida = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupDatosProductos = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtPickerFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.groupDatosProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigoNotaSalida
            // 
            this.txtCodigoNotaSalida.Location = new System.Drawing.Point(841, 52);
            this.txtCodigoNotaSalida.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoNotaSalida.Name = "txtCodigoNotaSalida";
            this.txtCodigoNotaSalida.Size = new System.Drawing.Size(209, 22);
            this.txtCodigoNotaSalida.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(624, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Código de Nota de Salida:";
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
            this.groupDatosProductos.Location = new System.Drawing.Point(29, 13);
            this.groupDatosProductos.Margin = new System.Windows.Forms.Padding(4);
            this.groupDatosProductos.Name = "groupDatosProductos";
            this.groupDatosProductos.Padding = new System.Windows.Forms.Padding(4);
            this.groupDatosProductos.Size = new System.Drawing.Size(487, 249);
            this.groupDatosProductos.TabIndex = 10;
            this.groupDatosProductos.TabStop = false;
            this.groupDatosProductos.Text = "Producto";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(190, 114);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(173, 24);
            this.txtCantidad.TabIndex = 13;
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
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Beige;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(369, 197);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(110, 44);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Beige;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(190, 197);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(132, 44);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(190, 75);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(4);
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
            this.txtCodigoProducto.Location = new System.Drawing.Point(190, 33);
            this.txtCodigoProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(218, 24);
            this.txtCodigoProducto.TabIndex = 7;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(624, 127);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Fecha de Registro:";
            // 
            // dtPickerFechaRegistro
            // 
            this.dtPickerFechaRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickerFechaRegistro.Location = new System.Drawing.Point(841, 123);
            this.dtPickerFechaRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.dtPickerFechaRegistro.Name = "dtPickerFechaRegistro";
            this.dtPickerFechaRegistro.Size = new System.Drawing.Size(265, 22);
            this.dtPickerFechaRegistro.TabIndex = 8;
            // 
            // dgvProducto
            // 
            this.dgvProducto.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Location = new System.Drawing.Point(143, 270);
            this.dgvProducto.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.RowHeadersWidth = 51;
            this.dgvProducto.Size = new System.Drawing.Size(963, 271);
            this.dgvProducto.TabIndex = 7;
            // 
            // btnAnular
            // 
            this.btnAnular.BackColor = System.Drawing.Color.Beige;
            this.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular.ForeColor = System.Drawing.Color.Black;
            this.btnAnular.Location = new System.Drawing.Point(13, 386);
            this.btnAnular.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(122, 52);
            this.btnAnular.TabIndex = 14;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Beige;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrar.Location = new System.Drawing.Point(9, 303);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(124, 54);
            this.btnRegistrar.TabIndex = 15;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // NotaSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1119, 554);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.txtCodigoNotaSalida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupDatosProductos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtPickerFechaRegistro);
            this.Controls.Add(this.dgvProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NotaSalida";
            this.groupDatosProductos.ResumeLayout(false);
            this.groupDatosProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigoNotaSalida;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupDatosProductos;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtPickerFechaRegistro;
        private System.Windows.Forms.DataGridView dgvProducto;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnRegistrar;
    }
}