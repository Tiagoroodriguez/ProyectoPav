namespace ProyectoPAV.Presentacion
{
    partial class frmUsuario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.cboPerfil = new System.Windows.Forms.ComboBox();
            this.grdUsuario = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarU = new System.Windows.Forms.Button();
            this.btnEditarU = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnEliminarU = new System.Windows.Forms.Button();
            this.btnSalirU = new System.Windows.Forms.Button();
            this.btnGuardarU = new System.Windows.Forms.Button();
            this.btnCancelarU = new System.Windows.Forms.Button();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(226, 9);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre(*):";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(226, 108);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(74, 13);
            this.lblClave.TabIndex = 2;
            this.lblClave.Text = "Contraseña(*):";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(226, 141);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(38, 13);
            this.lblMail.TabIndex = 3;
            this.lblMail.Text = "E-mail:";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(226, 174);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(48, 13);
            this.lblCargo.TabIndex = 4;
            this.lblCargo.Text = "Cargo(*):";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(336, 6);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(222, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(336, 102);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(222, 20);
            this.txtClave.TabIndex = 7;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(336, 134);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(222, 20);
            this.txtMail.TabIndex = 8;
            // 
            // cboPerfil
            // 
            this.cboPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPerfil.FormattingEnabled = true;
            this.cboPerfil.Location = new System.Drawing.Point(336, 174);
            this.cboPerfil.Name = "cboPerfil";
            this.cboPerfil.Size = new System.Drawing.Size(222, 21);
            this.cboPerfil.TabIndex = 9;
            // 
            // grdUsuario
            // 
            this.grdUsuario.AllowUserToAddRows = false;
            this.grdUsuario.AllowUserToDeleteRows = false;
            this.grdUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Email});
            this.grdUsuario.Location = new System.Drawing.Point(12, 215);
            this.grdUsuario.Name = "grdUsuario";
            this.grdUsuario.ReadOnly = true;
            this.grdUsuario.Size = new System.Drawing.Size(776, 169);
            this.grdUsuario.TabIndex = 10;
            this.grdUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdUsuario_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 300;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 300;
            // 
            // btnAgregarU
            // 
            this.btnAgregarU.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregarU.Image")));
            this.btnAgregarU.Location = new System.Drawing.Point(12, 390);
            this.btnAgregarU.Name = "btnAgregarU";
            this.btnAgregarU.Size = new System.Drawing.Size(98, 48);
            this.btnAgregarU.TabIndex = 11;
            this.toolTip1.SetToolTip(this.btnAgregarU, "Agregar");
            this.btnAgregarU.UseVisualStyleBackColor = true;
            this.btnAgregarU.Click += new System.EventHandler(this.btnAgregarU_Click);
            // 
            // btnEditarU
            // 
            this.btnEditarU.Image = global::ProyectoPAV.Properties.Resources.Editar;
            this.btnEditarU.Location = new System.Drawing.Point(116, 390);
            this.btnEditarU.Name = "btnEditarU";
            this.btnEditarU.Size = new System.Drawing.Size(98, 48);
            this.btnEditarU.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btnEditarU, "Editar");
            this.btnEditarU.UseVisualStyleBackColor = true;
            this.btnEditarU.Click += new System.EventHandler(this.btnEditarU_Click);
            // 
            // btnEliminarU
            // 
            this.btnEliminarU.Image = global::ProyectoPAV.Properties.Resources.Eliminar;
            this.btnEliminarU.Location = new System.Drawing.Point(220, 390);
            this.btnEliminarU.Name = "btnEliminarU";
            this.btnEliminarU.Size = new System.Drawing.Size(98, 48);
            this.btnEliminarU.TabIndex = 13;
            this.toolTip1.SetToolTip(this.btnEliminarU, "Eliminar");
            this.btnEliminarU.UseVisualStyleBackColor = true;
            this.btnEliminarU.Click += new System.EventHandler(this.btnEliminarU_Click);
            // 
            // btnSalirU
            // 
            this.btnSalirU.Image = ((System.Drawing.Image)(resources.GetObject("btnSalirU.Image")));
            this.btnSalirU.Location = new System.Drawing.Point(690, 390);
            this.btnSalirU.Name = "btnSalirU";
            this.btnSalirU.Size = new System.Drawing.Size(98, 48);
            this.btnSalirU.TabIndex = 14;
            this.toolTip1.SetToolTip(this.btnSalirU, "Salir");
            this.btnSalirU.UseVisualStyleBackColor = true;
            this.btnSalirU.Click += new System.EventHandler(this.btnSalirU_Click);
            // 
            // btnGuardarU
            // 
            this.btnGuardarU.Image = global::ProyectoPAV.Properties.Resources.Guardar;
            this.btnGuardarU.Location = new System.Drawing.Point(422, 390);
            this.btnGuardarU.Name = "btnGuardarU";
            this.btnGuardarU.Size = new System.Drawing.Size(98, 48);
            this.btnGuardarU.TabIndex = 15;
            this.toolTip1.SetToolTip(this.btnGuardarU, "Guardar");
            this.btnGuardarU.UseVisualStyleBackColor = true;
            this.btnGuardarU.Click += new System.EventHandler(this.btnGuardarU_Click);
            // 
            // btnCancelarU
            // 
            this.btnCancelarU.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarU.Image")));
            this.btnCancelarU.Location = new System.Drawing.Point(526, 390);
            this.btnCancelarU.Name = "btnCancelarU";
            this.btnCancelarU.Size = new System.Drawing.Size(98, 48);
            this.btnCancelarU.TabIndex = 16;
            this.toolTip1.SetToolTip(this.btnCancelarU, "Cancelar");
            this.btnCancelarU.UseVisualStyleBackColor = true;
            this.btnCancelarU.Click += new System.EventHandler(this.btnCancelarU_Click);
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(226, 75);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(52, 13);
            this.lblLegajo.TabIndex = 17;
            this.lblLegajo.Text = "Legajo(*):";
            // 
            // txtLegajo
            // 
            this.txtLegajo.Enabled = false;
            this.txtLegajo.Location = new System.Drawing.Point(336, 70);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(222, 20);
            this.txtLegajo.TabIndex = 18;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(336, 38);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(222, 20);
            this.txtApellido.TabIndex = 19;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(226, 42);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(57, 13);
            this.lblApellido.TabIndex = 20;
            this.lblApellido.Text = "Apellido(*):";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(666, 174);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(122, 26);
            this.btnConsultar.TabIndex = 21;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.lblLegajo);
            this.Controls.Add(this.btnCancelarU);
            this.Controls.Add(this.btnGuardarU);
            this.Controls.Add(this.btnSalirU);
            this.Controls.Add(this.btnEliminarU);
            this.Controls.Add(this.btnEditarU);
            this.Controls.Add(this.btnAgregarU);
            this.Controls.Add(this.grdUsuario);
            this.Controls.Add(this.cboPerfil);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.ComboBox cboPerfil;
        private System.Windows.Forms.DataGridView grdUsuario;
        private System.Windows.Forms.Button btnAgregarU;
        private System.Windows.Forms.Button btnEditarU;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnEliminarU;
        private System.Windows.Forms.Button btnSalirU;
        private System.Windows.Forms.Button btnGuardarU;
        private System.Windows.Forms.Button btnCancelarU;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Button btnConsultar;
    }
}