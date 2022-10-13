namespace ProyectoPAV.Presentacion.Ventas
{
    partial class frmFactura
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
            this.txtImporteTotal = new System.Windows.Forms.TextBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grdDetalle = new System.Windows.Forms.DataGridView();
            this.cboProductos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cboClientes = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cboObrasSociales = new System.Windows.Forms.ComboBox();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importeTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNroFactura = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCuil = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnQuitar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.txtImporte);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCantidad);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboProductos);
            this.groupBox1.Controls.Add(this.grdDetalle);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSubTotal);
            this.groupBox1.Controls.Add(this.txtDescuento);
            this.groupBox1.Controls.Add(this.txtImporteTotal);
            this.groupBox1.Location = new System.Drawing.Point(12, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 293);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle";
            // 
            // txtImporteTotal
            // 
            this.txtImporteTotal.Location = new System.Drawing.Point(670, 265);
            this.txtImporteTotal.Name = "txtImporteTotal";
            this.txtImporteTotal.Size = new System.Drawing.Size(100, 20);
            this.txtImporteTotal.TabIndex = 0;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(670, 239);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(100, 20);
            this.txtDescuento.TabIndex = 1;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(670, 213);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubTotal.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(618, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Subtotal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(591, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Descuento(%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(599, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Importe total";
            // 
            // grdDetalle
            // 
            this.grdDetalle.AllowUserToAddRows = false;
            this.grdDetalle.AllowUserToDeleteRows = false;
            this.grdDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.cantidadProducto,
            this.nombreProducto,
            this.descripcionProducto,
            this.precioProducto,
            this.importeTotal});
            this.grdDetalle.Location = new System.Drawing.Point(6, 57);
            this.grdDetalle.Name = "grdDetalle";
            this.grdDetalle.ReadOnly = true;
            this.grdDetalle.Size = new System.Drawing.Size(764, 150);
            this.grdDetalle.TabIndex = 6;
            // 
            // cboProductos
            // 
            this.cboProductos.FormattingEnabled = true;
            this.cboProductos.Location = new System.Drawing.Point(62, 30);
            this.cboProductos.Name = "cboProductos";
            this.cboProductos.Size = new System.Drawing.Size(133, 21);
            this.cboProductos.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Producto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Cantidad";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(272, 30);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(75, 20);
            this.txtCantidad.TabIndex = 10;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(412, 30);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(75, 20);
            this.txtPrecio.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(369, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Precio";
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(558, 30);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(75, 20);
            this.txtImporte.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(510, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Importe";
            // 
            // btnQuitar
            // 
            this.btnQuitar.Image = global::ProyectoPAV.Properties.Resources.eliminar_2;
            this.btnQuitar.Location = new System.Drawing.Point(693, 15);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(36, 36);
            this.btnQuitar.TabIndex = 17;
            this.btnQuitar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::ProyectoPAV.Properties.Resources.Salir;
            this.btnSalir.Location = new System.Drawing.Point(713, 389);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 49);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Image = global::ProyectoPAV.Properties.Resources.Guardar;
            this.btnGrabar.Location = new System.Drawing.Point(93, 389);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(75, 49);
            this.btnGrabar.TabIndex = 11;
            this.btnGrabar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::ProyectoPAV.Properties.Resources.Agregar;
            this.btnNuevo.Location = new System.Drawing.Point(12, 389);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 49);
            this.btnNuevo.TabIndex = 10;
            this.btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::ProyectoPAV.Properties.Resources.cancelar_2;
            this.btnCancelar.Location = new System.Drawing.Point(733, 15);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(36, 36);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = global::ProyectoPAV.Properties.Resources.agregar_2;
            this.btnAgregar.Location = new System.Drawing.Point(653, 15);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(36, 36);
            this.btnAgregar.TabIndex = 16;
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // cboClientes
            // 
            this.cboClientes.FormattingEnabled = true;
            this.cboClientes.Location = new System.Drawing.Point(74, 63);
            this.cboClientes.Name = "cboClientes";
            this.cboClientes.Size = new System.Drawing.Size(133, 21);
            this.cboClientes.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Cliente";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(307, 15);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(103, 20);
            this.dtpFecha.TabIndex = 20;
            this.dtpFecha.Value = new System.DateTime(2019, 9, 29, 17, 20, 8, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(264, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Fecha";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(239, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Obra Social";
            // 
            // cboObrasSociales
            // 
            this.cboObrasSociales.FormattingEnabled = true;
            this.cboObrasSociales.Location = new System.Drawing.Point(307, 63);
            this.cboObrasSociales.Name = "cboObrasSociales";
            this.cboObrasSociales.Size = new System.Drawing.Size(133, 21);
            this.cboObrasSociales.TabIndex = 22;
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "ID";
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Width = 50;
            // 
            // cantidadProducto
            // 
            this.cantidadProducto.HeaderText = "Cantidad";
            this.cantidadProducto.Name = "cantidadProducto";
            this.cantidadProducto.ReadOnly = true;
            // 
            // nombreProducto
            // 
            this.nombreProducto.HeaderText = "Nombre";
            this.nombreProducto.Name = "nombreProducto";
            this.nombreProducto.ReadOnly = true;
            this.nombreProducto.Width = 150;
            // 
            // descripcionProducto
            // 
            this.descripcionProducto.HeaderText = "Descripcion";
            this.descripcionProducto.Name = "descripcionProducto";
            this.descripcionProducto.ReadOnly = true;
            this.descripcionProducto.Width = 200;
            // 
            // precioProducto
            // 
            this.precioProducto.HeaderText = "Precio";
            this.precioProducto.Name = "precioProducto";
            this.precioProducto.ReadOnly = true;
            // 
            // importeTotal
            // 
            this.importeTotal.HeaderText = "Importe";
            this.importeTotal.Name = "importeTotal";
            this.importeTotal.ReadOnly = true;
            // 
            // txtNroFactura
            // 
            this.txtNroFactura.Location = new System.Drawing.Point(74, 15);
            this.txtNroFactura.Name = "txtNroFactura";
            this.txtNroFactura.Size = new System.Drawing.Size(133, 20);
            this.txtNroFactura.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Nro Factura";
            // 
            // txtCuil
            // 
            this.txtCuil.Location = new System.Drawing.Point(524, 63);
            this.txtCuil.Name = "txtCuil";
            this.txtCuil.Size = new System.Drawing.Size(151, 20);
            this.txtCuil.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(487, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "CUIL";
            // 
            // frmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCuil);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtNroFactura);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cboObrasSociales);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cboClientes);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmFactura";
            this.Text = "Nueva Factura";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboProductos;
        private System.Windows.Forms.DataGridView grdDetalle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtImporteTotal;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cboClientes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboObrasSociales;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn importeTotal;
        private System.Windows.Forms.TextBox txtNroFactura;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCuil;
        private System.Windows.Forms.Label label12;
    }
}