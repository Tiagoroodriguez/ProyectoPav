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
            InitializeDataGridView();
            oObraSocialService = new ObraSocialService();
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            {
                String condiciones = "";

                if (!chkTodos.Checked)
                {

                    if (txtNombre.Text != String.Empty)
                    {
                        condiciones += " AND nombreOS=" + "'" + txtNombre.Text + "'";
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

        private void InitializeDataGridView()
        {
            grdObraSocial.ColumnCount = 4;
            grdObraSocial.ColumnHeadersVisible = true;

            grdObraSocial.AutoGenerateColumns = false;

            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            grdObraSocial.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            grdObraSocial.Columns[0].Name = "Nombre";
            grdObraSocial.Columns[0].DataPropertyName = "Nombre";

            grdObraSocial.Columns[1].Name = "CUIT";
            grdObraSocial.Columns[1].DataPropertyName = "CUIT";

            grdObraSocial.Columns[2].Name = "Telefono";
            grdObraSocial.Columns[2].DataPropertyName = "Telefono";

            grdObraSocial.Columns[3].Name = "E-mail";
            grdObraSocial.Columns[3].DataPropertyName = "Mail";

            grdObraSocial.AutoResizeColumnHeadersHeight();

            grdObraSocial.AutoResizeRows(
                DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);

            grdObraSocial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
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
