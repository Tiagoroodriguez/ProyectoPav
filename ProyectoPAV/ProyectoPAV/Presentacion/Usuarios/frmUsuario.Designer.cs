namespace ProyectoPAV.Presentacion.Usuarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCargo = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.grdUsuarios = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Legajo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cargo:";
            // 
            // cboCargo
            // 
            this.cboCargo.FormattingEnabled = true;
            this.cboCargo.Location = new System.Drawing.Point(85, 112);
            this.cboCargo.Name = "cboCargo";
            this.cboCargo.Size = new System.Drawing.Size(235, 21);
            this.cboCargo.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(85, 71);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(235, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(85, 30);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(235, 20);
            this.txtLegajo.TabIndex = 1;
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Location = new System.Drawing.Point(85, 150);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(56, 17);
            this.chkTodos.TabIndex = 5;
            this.chkTodos.Text = "Todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(245, 146);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::ProyectoPAV.Properties.Resources.Salir;
            this.btnSalir.Location = new System.Drawing.Point(549, 389);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 49);
            this.btnSalir.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnSalir, "Salir");
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Enabled = false;
            this.btnQuitar.Image = global::ProyectoPAV.Properties.Resources.Eliminar;
            this.btnQuitar.Location = new System.Drawing.Point(174, 389);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(75, 49);
            this.btnQuitar.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnQuitar, "Eliminar");
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Image = global::ProyectoPAV.Properties.Resources.Editar;
            this.btnEditar.Location = new System.Drawing.Point(93, 389);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 49);
            this.btnEditar.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnEditar, "Editar");
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::ProyectoPAV.Properties.Resources.Agregar;
            this.btnNuevo.Location = new System.Drawing.Point(12, 389);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 49);
            this.btnNuevo.TabIndex = 6;
            this.toolTip1.SetToolTip(this.btnNuevo, "Agregar");
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // grdUsuarios
            // 
            this.grdUsuarios.AllowUserToAddRows = false;
            this.grdUsuarios.AllowUserToDeleteRows = false;
            this.grdUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUsuarios.Location = new System.Drawing.Point(12, 175);
            this.grdUsuarios.Name = "grdUsuarios";
            this.grdUsuarios.ReadOnly = true;
            this.grdUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdUsuarios.Size = new System.Drawing.Size(612, 208);
            this.grdUsuarios.TabIndex = 41;
            this.grdUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdUsuarios_CellClick);
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 450);
            this.Controls.Add(this.grdUsuarios);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.chkTodos);
            this.Controls.Add(this.txtLegajo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cboCargo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmUsuario";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCargo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.CheckBox chkTodos;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView grdUsuarios;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}