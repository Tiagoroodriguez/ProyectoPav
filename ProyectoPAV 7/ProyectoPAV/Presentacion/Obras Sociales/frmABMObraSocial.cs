using ProyectoPAV.Entidades;
using ProyectoPAV.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPAV.Presentacion
{
    public partial class frmABMObraSocial : Form
    {
        private FormMode formMode = FormMode.insert;

        private readonly ObraSocialService oObraSocialService;
        private ObraSocial oObraSocialSelected;
        public frmABMObraSocial()
        {
            InitializeComponent();
            oObraSocialService = new ObraSocialService();

        }
        public enum FormMode
        {
            insert,
            update,
            delete
        }

        private bool ExisteObraSocial()
        {
            return oObraSocialService.ObtenerOS(txtNombreOS.Text) != null;
        }

        private bool ValidarCampos()
        {
            if (txtNombreOS.Text == string.Empty)
            {
                txtNombreOS.BackColor = Color.Red;
                txtNombreOS.Focus();
                return false;
            }
            else
                txtNombreOS.BackColor = Color.White;
            if (txtTelefonoOS.Text == string.Empty)
            {
                txtTelefonoOS.BackColor = Color.Red;
                txtTelefonoOS.Focus();
                return false;
            }
            else
                txtTelefonoOS.BackColor = Color.White;
            if (txtMail.Text == string.Empty)
            {
                txtMail.BackColor = Color.Red;
                txtMail.Focus();
                return false;
            }
            else
                txtMail.BackColor = Color.White;
            return true;
        }

        public void SeleccionarObraSocial(FormMode op, ObraSocial ObraSocialSelected)
        {
            formMode = op;
            oObraSocialSelected = ObraSocialSelected;
        }

        private void MostrarDatos()
        {
            if (oObraSocialSelected != null)
            {
                txtNombreOS.Text = oObraSocialSelected.Nombre;
                txtTelefonoOS.Text = oObraSocialSelected.Telefono.ToString();
                txtMail.Text = oObraSocialSelected.Mail;
                txtCuit.Text = oObraSocialSelected.CUIT.ToString();
            }
        }

        private void frmABMObraSocial_Load_1(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nueva Obra Social";
                        break;
                    }
                case FormMode.update:
                    {
                        this.Text = "Actualizar Obra Social";
                        MostrarDatos();
                        txtNombreOS.Enabled = false;
                        txtTelefonoOS.Enabled = true;
                        txtCuit.Enabled = true;
                        txtMail.Enabled = true;
                        break;
                    }
                case FormMode.delete:
                    {
                        MostrarDatos();
                        this.Text = "Deshabilitar una Obra Social";
                        txtNombreOS.Enabled = false;
                        txtTelefonoOS.Enabled = false;
                        txtMail.Enabled = false;
                        txtCuit.Enabled = false;
                        break;
                    }
            }
        }

        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        if (ExisteObraSocial() == false)
                        {
                            if (ValidarCampos())
                            {
                                var oObraSocial = new ObraSocial();
                                oObraSocial.Nombre = txtNombreOS.Text;
                                oObraSocial.Telefono = Convert.ToInt32(txtTelefonoOS.Text);
                                oObraSocial.CUIT = Convert.ToInt32(txtCuit.Text);
                                oObraSocial.Mail = txtMail.Text;

                                if (oObraSocialService.CrearObraSocial(oObraSocial))
                                {
                                    MessageBox.Show("Obra Social insertada!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }

                            }
                        }
                        else
                            MessageBox.Show("Ya existe una Obra Social con ese nombre!. Ingrese un nombre diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    }
                case FormMode.update:
                    {
                        if (ValidarCampos())
                        {

                            oObraSocialSelected.Nombre = txtNombreOS.Text;
                            oObraSocialSelected.Telefono = Convert.ToInt32(txtTelefonoOS.Text);
                            oObraSocialSelected.CUIT = Convert.ToInt32(txtCuit.Text);
                            oObraSocialSelected.Mail = txtMail.Text;

                            if (oObraSocialService.ActualizarOS(oObraSocialSelected))
                            {
                                MessageBox.Show("Obra Social actualizada!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("Erro al actualizar!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    }
                case FormMode.delete:
                    {
                        if (MessageBox.Show("Seguro que desea habilitar/deshabilitar la Obra Social seleccionada?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            if (oObraSocialService.ModificarEstado(oObraSocialSelected))
                            {
                                MessageBox.Show("Obra Social Habilitado/Deshabilitado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Error al actualizar la Obra Social!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    }



            }
        }
    }
}

