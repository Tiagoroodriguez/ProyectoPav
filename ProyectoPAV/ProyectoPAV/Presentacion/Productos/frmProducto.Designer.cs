namespace ProyectoPAV.Presentacion.Productos
{
    partial class frmProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducto));
            this.grdProductos = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cboTipoProducto = new System.Windows.Forms.ComboBox();
            this.chkTodos = new System.Windows.Forms.CheckBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnModificacion = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // grdProductos
            // 
            this.grdProductos.AllowUserToAddRows = false;
            this.grdProductos.AllowUserToDeleteRows = false;
            this.grdProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProductos.Location = new System.Drawing.Point(12, 137);
            this.grdProductos.Name = "grdProductos";
            this.grdProductos.ReadOnly = true;
            this.grdProductos.Size = new System.Drawing.Size(612, 246);
            this.grdProductos.TabIndex = 0;
            this.grdProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProductos_CellClick);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(83, 27);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(209, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // cboTipoProducto
            // 
            this.cboTipoProducto.FormattingEnabled = true;
            this.cboTipoProducto.Location = new System.Drawing.Point(83, 68);
            this.cboTipoProducto.Name = "cboTipoProducto";
            this.cboTipoProducto.Size = new System.Drawing.Size(209, 21);
            this.cboTipoProducto.TabIndex = 4;
            // 
            // chkTodos
            // 
            this.chkTodos.AutoSize = true;
            this.chkTodos.Location = new System.Drawing.Point(83, 112);
            this.chkTodos.Name = "chkTodos";
            this.chkTodos.Size = new System.Drawing.Size(56, 17);
            this.chkTodos.TabIndex = 5;
            this.chkTodos.Text = "Todos";
            this.chkTodos.UseVisualStyleBackColor = true;
            this.chkTodos.CheckedChanged += new System.EventHandler(this.chkTodos_CheckedChanged);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(217, 108);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Tipo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nombre:";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::ProyectoPAV.Properties.Resources.Salir;
            this.btnSalir.Location = new System.Drawing.Point(549, 389);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 49);
            this.btnSalir.TabIndex = 14;
            this.toolTip1.SetToolTip(this.btnSalir, "Salir");
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Enabled = false;
            this.btnBaja.Image = global::ProyectoPAV.Properties.Resources.eliminarProducto;
            this.btnBaja.Location = new System.Drawing.Point(174, 389);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(75, 49);
            this.btnBaja.TabIndex = 13;
            this.toolTip1.SetToolTip(this.btnBaja, "Eliminar");
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.Image = ((System.Drawing.Image)(resources.GetObject("btnAlta.Image")));
            this.btnAlta.Location = new System.Drawing.Point(12, 389);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(75, 49);
            this.btnAlta.TabIndex = 9;
            this.toolTip1.SetToolTip(this.btnAlta, "Agregar");
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnModificacion
            // 
            this.btnModificacion.Enabled = false;
            this.btnModificacion.Image = global::ProyectoPAV.Properties.Resources.editarProducto;
            this.btnModificacion.Location = new System.Drawing.Point(93, 389);
            this.btnModificacion.Name = "btnModificacion";
            this.btnModificacion.Size = new System.Drawing.Size(75, 49);
            this.btnModificacion.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btnModificacion, "Editar");
            this.btnModificacion.UseVisualStyleBackColor = true;
            this.btnModificacion.Click += new System.EventHandler(this.btnModificacion_Click);
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.chkTodos);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.cboTipoProducto);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnModificacion);
            this.Controls.Add(this.grdProductos);
            this.Name = "frmProducto";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.frmProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.DataGridView grdProductos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnModificacion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cboTipoProducto;
        private System.Windows.Forms.CheckBox chkTodos;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}