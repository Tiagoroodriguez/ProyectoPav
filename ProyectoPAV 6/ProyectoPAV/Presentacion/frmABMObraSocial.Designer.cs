namespace ProyectoPAV.Presentacion
{
    partial class frmABMObraSocial
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
            this.txtCuit = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefonoOS = new System.Windows.Forms.MaskedTextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtNombreOS = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblcuit = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblNombreOS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(76, 60);
            this.txtCuit.Mask = "9999999999";
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(67, 20);
            this.txtCuit.TabIndex = 38;
            this.txtCuit.ValidatingType = typeof(int);
            // 
            // txtTelefonoOS
            // 
            this.txtTelefonoOS.Location = new System.Drawing.Point(76, 36);
            this.txtTelefonoOS.Mask = "9999999999";
            this.txtTelefonoOS.Name = "txtTelefonoOS";
            this.txtTelefonoOS.Size = new System.Drawing.Size(67, 20);
            this.txtTelefonoOS.TabIndex = 37;
            this.txtTelefonoOS.ValidatingType = typeof(int);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(76, 84);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(155, 20);
            this.txtMail.TabIndex = 36;
            // 
            // txtNombreOS
            // 
            this.txtNombreOS.Location = new System.Drawing.Point(76, 12);
            this.txtNombreOS.Name = "txtNombreOS";
            this.txtNombreOS.Size = new System.Drawing.Size(155, 20);
            this.txtNombreOS.TabIndex = 35;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(237, 110);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 28);
            this.btnCancelar.TabIndex = 34;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(141, 110);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(90, 28);
            this.btnAceptar.TabIndex = 33;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click_1);
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(10, 87);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(39, 13);
            this.lblMail.TabIndex = 32;
            this.lblMail.Text = "Mail(*):";
            // 
            // lblcuit
            // 
            this.lblcuit.AutoSize = true;
            this.lblcuit.Location = new System.Drawing.Point(10, 63);
            this.lblcuit.Name = "lblcuit";
            this.lblcuit.Size = new System.Drawing.Size(35, 13);
            this.lblcuit.TabIndex = 31;
            this.lblcuit.Text = "CUIT:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(10, 39);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(65, 13);
            this.lblTel.TabIndex = 30;
            this.lblTel.Text = "Telefono(*): ";
            // 
            // lblNombreOS
            // 
            this.lblNombreOS.AutoSize = true;
            this.lblNombreOS.Location = new System.Drawing.Point(10, 15);
            this.lblNombreOS.Name = "lblNombreOS";
            this.lblNombreOS.Size = new System.Drawing.Size(60, 13);
            this.lblNombreOS.TabIndex = 29;
            this.lblNombreOS.Text = "Nombre(*): ";
            // 
            // frmABMObraSocial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 149);
            this.Controls.Add(this.txtCuit);
            this.Controls.Add(this.txtTelefonoOS);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtNombreOS);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblcuit);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblNombreOS);
            this.Name = "frmABMObraSocial";
            this.Text = "frmABMObraSocial";
            this.Load += new System.EventHandler(this.frmABMObraSocial_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtCuit;
        private System.Windows.Forms.MaskedTextBox txtTelefonoOS;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtNombreOS;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblcuit;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblNombreOS;
    }
}