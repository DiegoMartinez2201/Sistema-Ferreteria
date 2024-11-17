namespace Sistema_Ferreteria_Dikranis
{
    partial class MantenedorProducto
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
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.groupBoxDatosProducto = new System.Windows.Forms.GroupBox();
            this.cbkEstado = new System.Windows.Forms.CheckBox();
            this.txtBProveedor = new System.Windows.Forms.TextBox();
            this.btnMantenedorUnidadMedida = new System.Windows.Forms.Button();
            this.btnMantenedorCategoria = new System.Windows.Forms.Button();
            this.btnMantedorProveedor = new System.Windows.Forms.Button();
            this.dtPickerFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dtPickerFechaCreacion = new System.Windows.Forms.DateTimePicker();
            this.dtPickerFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxunidadmedida = new System.Windows.Forms.ComboBox();
            this.cbxcategoria = new System.Windows.Forms.ComboBox();
            this.txtPrecioCosto = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCodigoProducto = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblIdEmpleado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            this.groupBoxDatosProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProducto
            // 
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Location = new System.Drawing.Point(12, 294);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.RowHeadersWidth = 51;
            this.dgvProducto.Size = new System.Drawing.Size(1052, 187);
            this.dgvProducto.TabIndex = 2;
            this.dgvProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducto_CellClick);
            // 
            // groupBoxDatosProducto
            // 
            this.groupBoxDatosProducto.Controls.Add(this.cbkEstado);
            this.groupBoxDatosProducto.Controls.Add(this.txtBProveedor);
            this.groupBoxDatosProducto.Controls.Add(this.btnMantenedorUnidadMedida);
            this.groupBoxDatosProducto.Controls.Add(this.btnMantenedorCategoria);
            this.groupBoxDatosProducto.Controls.Add(this.btnMantedorProveedor);
            this.groupBoxDatosProducto.Controls.Add(this.dtPickerFechaIngreso);
            this.groupBoxDatosProducto.Controls.Add(this.label12);
            this.groupBoxDatosProducto.Controls.Add(this.label11);
            this.groupBoxDatosProducto.Controls.Add(this.btnCancelar);
            this.groupBoxDatosProducto.Controls.Add(this.label10);
            this.groupBoxDatosProducto.Controls.Add(this.dtPickerFechaCreacion);
            this.groupBoxDatosProducto.Controls.Add(this.dtPickerFechaVencimiento);
            this.groupBoxDatosProducto.Controls.Add(this.btnAgregar);
            this.groupBoxDatosProducto.Controls.Add(this.btnModificar);
            this.groupBoxDatosProducto.Controls.Add(this.txtPrecioVenta);
            this.groupBoxDatosProducto.Controls.Add(this.label9);
            this.groupBoxDatosProducto.Controls.Add(this.label6);
            this.groupBoxDatosProducto.Controls.Add(this.label7);
            this.groupBoxDatosProducto.Controls.Add(this.label8);
            this.groupBoxDatosProducto.Controls.Add(this.label5);
            this.groupBoxDatosProducto.Controls.Add(this.label4);
            this.groupBoxDatosProducto.Controls.Add(this.label3);
            this.groupBoxDatosProducto.Controls.Add(this.label2);
            this.groupBoxDatosProducto.Controls.Add(this.label1);
            this.groupBoxDatosProducto.Controls.Add(this.cbxunidadmedida);
            this.groupBoxDatosProducto.Controls.Add(this.cbxcategoria);
            this.groupBoxDatosProducto.Controls.Add(this.txtPrecioCosto);
            this.groupBoxDatosProducto.Controls.Add(this.txtStock);
            this.groupBoxDatosProducto.Controls.Add(this.txtNombreProducto);
            this.groupBoxDatosProducto.Controls.Add(this.txtDescripcion);
            this.groupBoxDatosProducto.Controls.Add(this.txtCodigoProducto);
            this.groupBoxDatosProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDatosProducto.Location = new System.Drawing.Point(12, 31);
            this.groupBoxDatosProducto.Name = "groupBoxDatosProducto";
            this.groupBoxDatosProducto.Size = new System.Drawing.Size(1184, 240);
            this.groupBoxDatosProducto.TabIndex = 3;
            this.groupBoxDatosProducto.TabStop = false;
            this.groupBoxDatosProducto.Text = "Datos del Producto ";
            // 
            // cbkEstado
            // 
            this.cbkEstado.AutoSize = true;
            this.cbkEstado.Location = new System.Drawing.Point(771, 214);
            this.cbkEstado.Name = "cbkEstado";
            this.cbkEstado.Size = new System.Drawing.Size(75, 20);
            this.cbkEstado.TabIndex = 21;
            this.cbkEstado.Text = "Estado";
            this.cbkEstado.UseVisualStyleBackColor = true;
            // 
            // txtBProveedor
            // 
            this.txtBProveedor.Location = new System.Drawing.Point(152, 172);
            this.txtBProveedor.Name = "txtBProveedor";
            this.txtBProveedor.Size = new System.Drawing.Size(192, 22);
            this.txtBProveedor.TabIndex = 20;
            this.txtBProveedor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBProveedor_KeyDown);
            // 
            // btnMantenedorUnidadMedida
            // 
            this.btnMantenedorUnidadMedida.Location = new System.Drawing.Point(350, 135);
            this.btnMantenedorUnidadMedida.Name = "btnMantenedorUnidadMedida";
            this.btnMantenedorUnidadMedida.Size = new System.Drawing.Size(155, 23);
            this.btnMantenedorUnidadMedida.TabIndex = 19;
            this.btnMantenedorUnidadMedida.Text = "M. Unidad Medida";
            this.btnMantenedorUnidadMedida.UseVisualStyleBackColor = true;
            // 
            // btnMantenedorCategoria
            // 
            this.btnMantenedorCategoria.Location = new System.Drawing.Point(394, 107);
            this.btnMantenedorCategoria.Name = "btnMantenedorCategoria";
            this.btnMantenedorCategoria.Size = new System.Drawing.Size(111, 23);
            this.btnMantenedorCategoria.TabIndex = 18;
            this.btnMantenedorCategoria.Text = "M. Categoria";
            this.btnMantenedorCategoria.UseVisualStyleBackColor = true;
            // 
            // btnMantedorProveedor
            // 
            this.btnMantedorProveedor.Location = new System.Drawing.Point(393, 170);
            this.btnMantedorProveedor.Name = "btnMantedorProveedor";
            this.btnMantedorProveedor.Size = new System.Drawing.Size(112, 23);
            this.btnMantedorProveedor.TabIndex = 17;
            this.btnMantedorProveedor.Text = "M. Proveedor";
            this.btnMantedorProveedor.UseVisualStyleBackColor = true;
            // 
            // dtPickerFechaIngreso
            // 
            this.dtPickerFechaIngreso.Location = new System.Drawing.Point(770, 51);
            this.dtPickerFechaIngreso.Name = "dtPickerFechaIngreso";
            this.dtPickerFechaIngreso.Size = new System.Drawing.Size(282, 22);
            this.dtPickerFechaIngreso.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(625, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 16);
            this.label12.TabIndex = 15;
            this.label12.Text = "Fecha de Ingreso:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(615, 178);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "Fecha de Creación:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Beige;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(1075, 148);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 33);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(592, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(165, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "Fecha de Vencimiento:";
            // 
            // dtPickerFechaCreacion
            // 
            this.dtPickerFechaCreacion.Location = new System.Drawing.Point(770, 172);
            this.dtPickerFechaCreacion.Name = "dtPickerFechaCreacion";
            this.dtPickerFechaCreacion.Size = new System.Drawing.Size(282, 22);
            this.dtPickerFechaCreacion.TabIndex = 12;
            // 
            // dtPickerFechaVencimiento
            // 
            this.dtPickerFechaVencimiento.Location = new System.Drawing.Point(770, 78);
            this.dtPickerFechaVencimiento.Name = "dtPickerFechaVencimiento";
            this.dtPickerFechaVencimiento.Size = new System.Drawing.Size(282, 22);
            this.dtPickerFechaVencimiento.TabIndex = 11;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Beige;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(1075, 22);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(103, 30);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Beige;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(1075, 77);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(103, 30);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(770, 142);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(147, 22);
            this.txtPrecioVenta.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(635, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Precio de Venta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(635, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Precio de Costo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(707, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Stock:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Proovedor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Descripcion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Unidad de Medida:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Categoria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Codigo:";
            // 
            // cbxunidadmedida
            // 
            this.cbxunidadmedida.FormattingEnabled = true;
            this.cbxunidadmedida.Location = new System.Drawing.Point(149, 140);
            this.cbxunidadmedida.Name = "cbxunidadmedida";
            this.cbxunidadmedida.Size = new System.Drawing.Size(94, 24);
            this.cbxunidadmedida.TabIndex = 3;
            // 
            // cbxcategoria
            // 
            this.cbxcategoria.FormattingEnabled = true;
            this.cbxcategoria.Location = new System.Drawing.Point(149, 106);
            this.cbxcategoria.Name = "cbxcategoria";
            this.cbxcategoria.Size = new System.Drawing.Size(147, 24);
            this.cbxcategoria.TabIndex = 3;
            // 
            // txtPrecioCosto
            // 
            this.txtPrecioCosto.Location = new System.Drawing.Point(770, 108);
            this.txtPrecioCosto.Name = "txtPrecioCosto";
            this.txtPrecioCosto.Size = new System.Drawing.Size(147, 22);
            this.txtPrecioCosto.TabIndex = 2;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(770, 22);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(147, 22);
            this.txtStock.TabIndex = 2;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(149, 50);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(178, 22);
            this.txtNombreProducto.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(149, 78);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(230, 22);
            this.txtDescripcion.TabIndex = 0;
            // 
            // txtCodigoProducto
            // 
            this.txtCodigoProducto.Location = new System.Drawing.Point(149, 21);
            this.txtCodigoProducto.Name = "txtCodigoProducto";
            this.txtCodigoProducto.Size = new System.Drawing.Size(100, 22);
            this.txtCodigoProducto.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Beige;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(1093, 447);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(103, 34);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.BackColor = System.Drawing.Color.Beige;
            this.btnDeshabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeshabilitar.Location = new System.Drawing.Point(1093, 399);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(103, 33);
            this.btnDeshabilitar.TabIndex = 17;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = false;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Beige;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(1093, 345);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(103, 33);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.Beige;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(1093, 294);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(103, 33);
            this.btnNuevo.TabIndex = 15;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lblIdEmpleado
            // 
            this.lblIdEmpleado.AutoSize = true;
            this.lblIdEmpleado.Location = new System.Drawing.Point(16, 512);
            this.lblIdEmpleado.Name = "lblIdEmpleado";
            this.lblIdEmpleado.Size = new System.Drawing.Size(66, 13);
            this.lblIdEmpleado.TabIndex = 19;
            this.lblIdEmpleado.Text = "Id Empleado";
            // 
            // MantenedorProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1313, 561);
            this.Controls.Add(this.lblIdEmpleado);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.groupBoxDatosProducto);
            this.Controls.Add(this.dgvProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MantenedorProducto";
            this.Text = "MantenedorProducto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            this.groupBoxDatosProducto.ResumeLayout(false);
            this.groupBoxDatosProducto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducto;
        private System.Windows.Forms.GroupBox groupBoxDatosProducto;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxunidadmedida;
        private System.Windows.Forms.ComboBox cbxcategoria;
        private System.Windows.Forms.TextBox txtPrecioCosto;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCodigoProducto;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtPickerFechaCreacion;
        private System.Windows.Forms.DateTimePicker dtPickerFechaVencimiento;
        private System.Windows.Forms.DateTimePicker dtPickerFechaIngreso;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblIdEmpleado;
        private System.Windows.Forms.Button btnMantenedorCategoria;
        private System.Windows.Forms.Button btnMantedorProveedor;
        private System.Windows.Forms.Button btnMantenedorUnidadMedida;
        private System.Windows.Forms.TextBox txtBProveedor;
        private System.Windows.Forms.CheckBox cbkEstado;
    }
}