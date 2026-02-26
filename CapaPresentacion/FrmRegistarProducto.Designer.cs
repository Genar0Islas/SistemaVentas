namespace CapaPresentacion
{
    partial class FrmRegistarProducto
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
            this.txtidproducto = new System.Windows.Forms.TextBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnguardar = new System.Windows.Forms.Button();
            this.rbtninactivo = new System.Windows.Forms.RadioButton();
            this.rbtactivo = new System.Windows.Forms.RadioButton();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtnombreproducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtprecioventa = new System.Windows.Forms.TextBox();
            this.txtpreciocompra = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtidcategoria = new System.Windows.Forms.TextBox();
            this.txtstock = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimefingreso = new System.Windows.Forms.DateTimePicker();
            this.dateTimefvencimiento = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtidproducto
            // 
            this.txtidproducto.Location = new System.Drawing.Point(104, 26);
            this.txtidproducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtidproducto.Name = "txtidproducto";
            this.txtidproducto.Size = new System.Drawing.Size(56, 20);
            this.txtidproducto.TabIndex = 32;
            this.txtidproducto.Visible = false;
            // 
            // btncancelar
            // 
            this.btncancelar.Location = new System.Drawing.Point(434, 339);
            this.btncancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(60, 19);
            this.btncancelar.TabIndex = 31;
            this.btncancelar.Text = "&Cancelar";
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(362, 339);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(60, 19);
            this.btnguardar.TabIndex = 30;
            this.btnguardar.Text = "&Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // rbtninactivo
            // 
            this.rbtninactivo.AutoSize = true;
            this.rbtninactivo.Location = new System.Drawing.Point(352, 283);
            this.rbtninactivo.Margin = new System.Windows.Forms.Padding(2);
            this.rbtninactivo.Name = "rbtninactivo";
            this.rbtninactivo.Size = new System.Drawing.Size(63, 17);
            this.rbtninactivo.TabIndex = 29;
            this.rbtninactivo.TabStop = true;
            this.rbtninactivo.Text = "Inactivo";
            this.rbtninactivo.UseVisualStyleBackColor = true;
            // 
            // rbtactivo
            // 
            this.rbtactivo.AutoSize = true;
            this.rbtactivo.Location = new System.Drawing.Point(299, 283);
            this.rbtactivo.Margin = new System.Windows.Forms.Padding(2);
            this.rbtactivo.Name = "rbtactivo";
            this.rbtactivo.Size = new System.Drawing.Size(55, 17);
            this.rbtactivo.TabIndex = 28;
            this.rbtactivo.TabStop = true;
            this.rbtactivo.Text = "Activo";
            this.rbtactivo.UseVisualStyleBackColor = true;
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(215, 49);
            this.txtdescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(130, 20);
            this.txtdescripcion.TabIndex = 27;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(31, 101);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(130, 20);
            this.txtcodigo.TabIndex = 24;
            // 
            // txtnombreproducto
            // 
            this.txtnombreproducto.Location = new System.Drawing.Point(31, 49);
            this.txtnombreproducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtnombreproducto.Name = "txtnombreproducto";
            this.txtnombreproducto.Size = new System.Drawing.Size(130, 20);
            this.txtnombreproducto.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 266);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Seleccione Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 144);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Fecha de Ingreso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Fecha de Vencimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Codigo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nombre";
            // 
            // txtprecioventa
            // 
            this.txtprecioventa.Location = new System.Drawing.Point(278, 210);
            this.txtprecioventa.Margin = new System.Windows.Forms.Padding(2);
            this.txtprecioventa.Name = "txtprecioventa";
            this.txtprecioventa.Size = new System.Drawing.Size(130, 20);
            this.txtprecioventa.TabIndex = 36;
            // 
            // txtpreciocompra
            // 
            this.txtpreciocompra.Location = new System.Drawing.Point(31, 210);
            this.txtpreciocompra.Margin = new System.Windows.Forms.Padding(2);
            this.txtpreciocompra.Name = "txtpreciocompra";
            this.txtpreciocompra.Size = new System.Drawing.Size(130, 20);
            this.txtpreciocompra.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(275, 195);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Precio de Venta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 194);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Precio de Compra";
            // 
            // txtidcategoria
            // 
            this.txtidcategoria.Location = new System.Drawing.Point(215, 101);
            this.txtidcategoria.Margin = new System.Windows.Forms.Padding(2);
            this.txtidcategoria.Name = "txtidcategoria";
            this.txtidcategoria.Size = new System.Drawing.Size(56, 20);
            this.txtidcategoria.TabIndex = 37;
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(32, 266);
            this.txtstock.Margin = new System.Windows.Forms.Padding(2);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(130, 20);
            this.txtstock.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 251);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Stock";
            // 
            // dateTimefingreso
            // 
            this.dateTimefingreso.Location = new System.Drawing.Point(31, 160);
            this.dateTimefingreso.Name = "dateTimefingreso";
            this.dateTimefingreso.Size = new System.Drawing.Size(200, 20);
            this.dateTimefingreso.TabIndex = 40;
            // 
            // dateTimefvencimiento
            // 
            this.dateTimefvencimiento.Location = new System.Drawing.Point(278, 159);
            this.dateTimefvencimiento.Name = "dateTimefvencimiento";
            this.dateTimefvencimiento.Size = new System.Drawing.Size(200, 20);
            this.dateTimefvencimiento.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(212, 86);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 42;
            this.label10.Text = "Categoria";
            // 
            // FrmRegistarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 369);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateTimefvencimiento);
            this.Controls.Add(this.dateTimefingreso);
            this.Controls.Add(this.txtstock);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtidcategoria);
            this.Controls.Add(this.txtprecioventa);
            this.Controls.Add(this.txtpreciocompra);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtidproducto);
            this.Controls.Add(this.btncancelar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.rbtninactivo);
            this.Controls.Add(this.rbtactivo);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.txtnombreproducto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegistarProducto";
            this.Text = "FrmRegistarProducto";
            this.Load += new System.EventHandler(this.FrmRegistarProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtidproducto;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.Button btnguardar;
        public System.Windows.Forms.RadioButton rbtninactivo;
        public System.Windows.Forms.RadioButton rbtactivo;
        public System.Windows.Forms.TextBox txtdescripcion;
        public System.Windows.Forms.TextBox txtcodigo;
        public System.Windows.Forms.TextBox txtnombreproducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtprecioventa;
        public System.Windows.Forms.TextBox txtpreciocompra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtidcategoria;
        public System.Windows.Forms.TextBox txtstock;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimefingreso;
        private System.Windows.Forms.DateTimePicker dateTimefvencimiento;
        private System.Windows.Forms.Label label10;
    }
}