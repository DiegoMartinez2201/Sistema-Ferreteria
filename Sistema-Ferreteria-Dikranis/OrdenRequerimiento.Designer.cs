namespace Sistema_Ferreteria_Dikranis
{
    partial class OrdenRequerimiento
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxCodigoProducto = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDatosProducto = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dtPickerFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigoOrdenRequerimiento = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbxCodigoProducto);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombreProducto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(513, 264);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Producto";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(184, 133);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(218, 24);
            this.txtCantidad.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cantidad:";
            // 
            // cbxCodigoProducto
            // 
            this.cbxCodigoProducto.FormattingEnabled = true;
            this.cbxCodigoProducto.Location = new System.Drawing.Point(184, 33);
            this.cbxCodigoProducto.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCodigoProducto.Name = "cbxCodigoProducto";
            this.cbxCodigoProducto.Size = new System.Drawing.Size(218, 26);
            this.cbxCodigoProducto.TabIndex = 9;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Beige;
            this.btnEliminar.Location = new System.Drawing.Point(357, 203);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(137, 42);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Beige;
            this.btnAgregar.Location = new System.Drawing.Point(28, 203);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(112, 42);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre Producto:";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(184, 84);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(218, 24);
            this.txtNombreProducto.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código del Producto:";
            // 
            // dgvDatosProducto
            // 
            this.dgvDatosProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosProducto.Location = new System.Drawing.Point(16, 317);
            this.dgvDatosProducto.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDatosProducto.Name = "dgvDatosProducto";
            this.dgvDatosProducto.RowHeadersWidth = 51;
            this.dgvDatosProducto.Size = new System.Drawing.Size(1081, 254);
            this.dgvDatosProducto.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(581, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "Fecha Registro:";
            // 
            // dtPickerFechaRegistro
            // 
            this.dtPickerFechaRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickerFechaRegistro.Location = new System.Drawing.Point(846, 116);
            this.dtPickerFechaRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.dtPickerFechaRegistro.Name = "dtPickerFechaRegistro";
            this.dtPickerFechaRegistro.Size = new System.Drawing.Size(265, 24);
            this.dtPickerFechaRegistro.TabIndex = 11;
            // 
            // btnAnular
            // 
            this.btnAnular.BackColor = System.Drawing.Color.Beige;
            this.btnAnular.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular.Location = new System.Drawing.Point(1120, 399);
            this.btnAnular.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(117, 58);
            this.btnAnular.TabIndex = 16;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Beige;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(1120, 317);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(117, 55);
            this.btnRegistrar.TabIndex = 15;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(581, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Código Orden Requerimiento:";
            // 
            // txtCodigoOrdenRequerimiento
            // 
            this.txtCodigoOrdenRequerimiento.Location = new System.Drawing.Point(846, 47);
            this.txtCodigoOrdenRequerimiento.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoOrdenRequerimiento.Name = "txtCodigoOrdenRequerimiento";
            this.txtCodigoOrdenRequerimiento.Size = new System.Drawing.Size(223, 22);
            this.txtCodigoOrdenRequerimiento.TabIndex = 17;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(584, 194);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(83, 22);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Estado";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // OrdenRequerimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1250, 584);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtCodigoOrdenRequerimiento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtPickerFechaRegistro);
            this.Controls.Add(this.dgvDatosProducto);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrdenRequerimiento";
            this.Text = "OrdenRequerimiento";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxCodigoProducto;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDatosProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtPickerFechaRegistro;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigoOrdenRequerimiento;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}