namespace ProyectoPAV.Presentacion
{
    partial class frmObraSocial
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
            this.txtMail = new System.Windows.Forms.MaskedTextBox();
            this.txtCuit = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtNombre = new System.Windows.Forms.MaskedTextBox();
            this.txtId = new System.Windows.Forms.MaskedTextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCuit = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.grdObraSocial = new System.Windows.Forms.DataGridView();
            this.lblFiltros = new System.Windows.Forms.Label();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblIdOS = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnModificacion = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdObraSocial)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(317, 58);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(100, 20);
            this.txtMail.TabIndex = 52;
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(317, 32);
            this.txtCuit.Mask = "999999999999999";
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(100, 20);
            this.txtCuit.TabIndex = 51;
            this.txtCuit.ValidatingType = typeof(int);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(139, 85);
            this.txtTelefono.Mask = "999999999999";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(81, 20);
            this.txtTelefono.TabIndex = 50;
            this.txtTelefono.ValidatingType = typeof(int);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(139, 58);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 49;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(139, 32);
            this.txtId.Mask = "9999999999999999999";
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 48;
            this.txtId.ValidatingType = typeof(int);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(255, 62);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 13);
            this.lblEmail.TabIndex = 47;
            this.lblEmail.Text = "- Mail : ";
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuit.Location = new System.Drawing.Point(255, 35);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(56, 13);
            this.lblCuit.TabIndex = 46;
            this.lblCuit.Text = "- CUIT : ";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(29, 88);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(73, 13);
            this.lblTelefono.TabIndex = 45;
            this.lblTelefono.Text = "- Telefono: ";
            // 
            // grdObraSocial
            // 
            this.grdObraSocial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdObraSocial.Location = new System.Drawing.Point(12, 147);
            this.grdObraSocial.Name = "grdObraSocial";
            this.grdObraSocial.Size = new System.Drawing.Size(544, 154);
            this.grdObraSocial.TabIndex = 40;
            // 
            // lblFiltros
            // 
            this.lblFiltros.AutoSize = true;
            this.lblFiltros.BackColor = System.Drawing.SystemColors.Control;
            this.lblFiltros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFiltros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltros.Location = new System.Drawing.Point(12, 9);
            this.lblFiltros.Name = "lblFiltros";
            this.lblFiltros.Size = new System.Drawing.Size(120, 15);
            this.lblFiltros.TabIndex = 39;
            this.lblFiltros.Text = "Filtros de búsqueda";
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Location = new System.Drawing.Point(32, 115);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(94, 17);
            this.chkTodos.TabIndex = 38;
            this.chkTodos.Text = "Mostrar Todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(453, 115);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(95, 26);
            this.btnBuscar.TabIndex = 37;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(29, 62);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(70, 13);
            this.lblNombre.TabIndex = 36;
            this.lblNombre.Text = "- Nombre : ";
            // 
            // lblIdOS
            // 
            this.lblIdOS.AutoSize = true;
            this.lblIdOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdOS.Location = new System.Drawing.Point(29, 35);
            this.lblIdOS.Name = "lblIdOS";
            this.lblIdOS.Size = new System.Drawing.Size(104, 13);
            this.lblIdOS.TabIndex = 35;
            this.lblIdOS.Text = "- Id Obra Social: ";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::ProyectoPAV.Properties.Resources.Salir;
            this.btnSalir.Location = new System.Drawing.Point(505, 317);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(43, 42);
            this.btnSalir.TabIndex = 44;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Image = global::ProyectoPAV.Properties.Resources.Eliminar;
            this.btnBaja.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBaja.Location = new System.Drawing.Point(110, 317);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(43, 42);
            this.btnBaja.TabIndex = 43;
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnModificacion
            // 
            this.btnModificacion.Image = global::ProyectoPAV.Properties.Resources.Editar;
            this.btnModificacion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificacion.Location = new System.Drawing.Point(61, 317);
            this.btnModificacion.Name = "btnModificacion";
            this.btnModificacion.Size = new System.Drawing.Size(43, 42);
            this.btnModificacion.TabIndex = 42;
            this.btnModificacion.UseVisualStyleBackColor = true;
            this.btnModificacion.Click += new System.EventHandler(this.btnModificacion_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Image = global::ProyectoPAV.Properties.Resources.Agregar;
            this.btnAlta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlta.Location = new System.Drawing.Point(12, 317);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(43, 42);
            this.btnAlta.TabIndex = 41;
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // frmObraSocial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 370);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtCuit);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCuit);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnModificacion);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.grdObraSocial);
            this.Controls.Add(this.lblFiltros);
            this.Controls.Add(this.chkTodos);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblIdOS);
            this.Name = "frmObraSocial";
            this.Text = "ObraSocial";
            ((System.ComponentModel.ISupportInitialize)(this.grdObraSocial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtMail;
        private System.Windows.Forms.MaskedTextBox txtCuit;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.MaskedTextBox txtNombre;
        private System.Windows.Forms.MaskedTextBox txtId;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnModificacion;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.DataGridView grdObraSocial;
        private System.Windows.Forms.Label lblFiltros;
        private System.Windows.Forms.CheckBox chkTodos;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblIdOS;
    }
}