namespace Sistema_Ferreteria_Dikranis
{
    partial class Administrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrador));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.panelForms = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnProveedores = new System.Windows.Forms.Button();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnOrdenCompra = new System.Windows.Forms.Button();
            this.btnOrdenRequerimiento = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.panelForms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(234)))), ((int)(((byte)(22)))));
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnProveedores);
            this.panel1.Controls.Add(this.btnEmpleado);
            this.panel1.Controls.Add(this.btnClientes);
            this.panel1.Controls.Add(this.btnOrdenCompra);
            this.panel1.Controls.Add(this.btnOrdenRequerimiento);
            this.panel1.Controls.Add(this.btnProductos);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 779);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(248, 177);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 130);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Administrador";
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.btnMaximizar);
            this.panelTitle.Controls.Add(this.btnCerrar);
            this.panelTitle.Controls.Add(this.btnMinimizar);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(248, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(4);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1093, 124);
            this.panelTitle.TabIndex = 2;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // panelForms
            // 
            this.panelForms.Controls.Add(this.label2);
            this.panelForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForms.Location = new System.Drawing.Point(248, 124);
            this.panelForms.Margin = new System.Windows.Forms.Padding(4);
            this.panelForms.Name = "panelForms";
            this.panelForms.Size = new System.Drawing.Size(1093, 655);
            this.panelForms.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(237, 244);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(604, 62);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bienvenido Administrador";
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(1019, 0);
            this.btnMaximizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(35, 36);
            this.btnMaximizar.TabIndex = 11;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1057, 1);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(32, 27);
            this.btnCerrar.TabIndex = 10;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(976, 1);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(35, 36);
            this.btnMinimizar.TabIndex = 9;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Image = ((System.Drawing.Image)(resources.GetObject("btnRegresar.Image")));
            this.btnRegresar.Location = new System.Drawing.Point(0, 727);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(248, 52);
            this.btnRegresar.TabIndex = 8;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(0, 489);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(248, 52);
            this.button3.TabIndex = 7;
            this.button3.Text = "Reporte de Ventas";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnProveedores
            // 
            this.btnProveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProveedores.FlatAppearance.BorderSize = 0;
            this.btnProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedores.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedores.Image = ((System.Drawing.Image)(resources.GetObject("btnProveedores.Image")));
            this.btnProveedores.Location = new System.Drawing.Point(0, 437);
            this.btnProveedores.Margin = new System.Windows.Forms.Padding(4);
            this.btnProveedores.Name = "btnProveedores";
            this.btnProveedores.Size = new System.Drawing.Size(248, 52);
            this.btnProveedores.TabIndex = 6;
            this.btnProveedores.Text = "Proveedores";
            this.btnProveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnProveedores.UseVisualStyleBackColor = true;
            this.btnProveedores.Click += new System.EventHandler(this.btnProveedores_Click);
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpleado.FlatAppearance.BorderSize = 0;
            this.btnEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpleado.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpleado.Image")));
            this.btnEmpleado.Location = new System.Drawing.Point(0, 385);
            this.btnEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(248, 52);
            this.btnEmpleado.TabIndex = 5;
            this.btnEmpleado.Text = "Empleados";
            this.btnEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEmpleado.UseVisualStyleBackColor = true;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClientes.FlatAppearance.BorderSize = 0;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.Location = new System.Drawing.Point(0, 333);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(248, 52);
            this.btnClientes.TabIndex = 4;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnOrdenCompra
            // 
            this.btnOrdenCompra.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrdenCompra.FlatAppearance.BorderSize = 0;
            this.btnOrdenCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenCompra.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenCompra.Image = ((System.Drawing.Image)(resources.GetObject("btnOrdenCompra.Image")));
            this.btnOrdenCompra.Location = new System.Drawing.Point(0, 281);
            this.btnOrdenCompra.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrdenCompra.Name = "btnOrdenCompra";
            this.btnOrdenCompra.Size = new System.Drawing.Size(248, 52);
            this.btnOrdenCompra.TabIndex = 3;
            this.btnOrdenCompra.Text = "Orden de Compra";
            this.btnOrdenCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnOrdenCompra.UseVisualStyleBackColor = true;
            // 
            // btnOrdenRequerimiento
            // 
            this.btnOrdenRequerimiento.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrdenRequerimiento.FlatAppearance.BorderSize = 0;
            this.btnOrdenRequerimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenRequerimiento.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenRequerimiento.Image = ((System.Drawing.Image)(resources.GetObject("btnOrdenRequerimiento.Image")));
            this.btnOrdenRequerimiento.Location = new System.Drawing.Point(0, 229);
            this.btnOrdenRequerimiento.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrdenRequerimiento.Name = "btnOrdenRequerimiento";
            this.btnOrdenRequerimiento.Size = new System.Drawing.Size(248, 52);
            this.btnOrdenRequerimiento.TabIndex = 2;
            this.btnOrdenRequerimiento.Text = "Orden de Requerimiento";
            this.btnOrdenRequerimiento.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnOrdenRequerimiento.UseVisualStyleBackColor = true;
            this.btnOrdenRequerimiento.Click += new System.EventHandler(this.btnOrdenRequerimiento_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnProductos.Image")));
            this.btnProductos.Location = new System.Drawing.Point(0, 177);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(4);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(248, 52);
            this.btnProductos.TabIndex = 1;
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(45, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(156, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(1341, 779);
            this.Controls.Add(this.panelForms);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Administrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.panelForms.ResumeLayout(false);
            this.panelForms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOrdenCompra;
        private System.Windows.Forms.Button btnOrdenRequerimiento;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnEmpleado;
        private System.Windows.Forms.Button btnProveedores;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Panel panelForms;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label label2;
    }
}