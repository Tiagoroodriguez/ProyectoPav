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
    public partial class frmObraSocial : Form
    {

        private ObraSocialService oObraSocialService;
        public frmObraSocial()
        {
            InitializeComponent();
            oObraSocialService = new ObraSocialService();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            {
                String condiciones = "";

                if (!chkTodos.Checked)
                {
                    if (txtId.Text != String.Empty)
                    {
                        condiciones += " AND idOS=" + txtId.Text;
                    }

                    if (txtNombre.Text != String.Empty)
                    {
                        condiciones += " AND nombreOS=" + "'" + txtNombre.Text + "'";
                    }

                    if (txtTelefono.Text != String.Empty)
                    {
                        condiciones += " AND telefono=" + txtTelefono.Text;
                    }

                    if (txtMail.Text != String.Empty)
                    {
                        condiciones += " AND email=" + "'" + txtMail.Text + "'";

                    }

                    if (txtCuit.Text != String.Empty)
                    {
                        condiciones += " AND CUIT=" + txtCuit.Text;
                    }
                    if (condiciones != "")
                    {
                        grdObraSocial.DataSource = oObraSocialService.ConsultarConCondiciones(condiciones);
                    }

                    else
                        MessageBox.Show("Debe ingresar al menos un criterio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                    grdObraSocial.DataSource = oObraSocialService.TraerTodos();
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            frmABMObraSocial formulario = new frmABMObraSocial();
            formulario.ShowDialog();
            btnBuscar_Click_1(sender, e);
        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            frmABMObraSocial formulario = new frmABMObraSocial();
            var obrasocial = (ObraSocial)grdObraSocial.CurrentRow.DataBoundItem;
            formulario.SeleccionarObraSocial(frmABMObraSocial.FormMode.update, obrasocial);
            formulario.ShowDialog();
            btnBuscar_Click_1(sender, e);
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            frmABMObraSocial formulario = new frmABMObraSocial();
            var obrasocial = (ObraSocial)grdObraSocial.CurrentRow.DataBoundItem;
            formulario.SeleccionarObraSocial(frmABMObraSocial.FormMode.delete, obrasocial);
            formulario.ShowDialog();
            btnBuscar_Click_1(sender, e);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
