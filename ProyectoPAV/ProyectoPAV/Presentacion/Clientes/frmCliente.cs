using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoPAV.Entidades;
using ProyectoPAV.Servicios;

namespace ProyectoPAV.Presentacion
{
    public partial class frmCliente : Form
    {

        private ClienteService oClienteService;
        private ObraSocialService oObraSocialService;

        public frmCliente()
        {
            InitializeComponent();
            InitializeDataGridView();
            oClienteService = new ClienteService();
            oObraSocialService = new ObraSocialService();
        }
        private void btnAlta_Click(object sender, EventArgs e)
        {
            frmABMCliente nuevoForm = new frmABMCliente();
            nuevoForm.Show();
            this.Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String condiciones = "";

            if(!chkTodos.Checked)
            {
                if (txtNombre.Text != string.Empty)
                {
                    condiciones += " AND nombreCliente=" + "'" +  txtNombre.Text+"'";
                }
                
                if (cboObrasSociales.Text != string.Empty)
                {
                    condiciones += " AND idObraSocial=" + "'" + cboObrasSociales.SelectedValue+"'";
                }

                if (txtDocumento.Text != string.Empty)
                {
                    condiciones += " AND nroDocumento=" + "'" + txtDocumento.Text + "'";
                }

                if (condiciones != "")
                {
                    grdClientes.DataSource = oClienteService.ConsultarConCondiciones(condiciones);
                }
                else
                    MessageBox.Show("Debe ingresar al menos un criterio!!","AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                grdClientes.DataSource = oClienteService.ObtenerTodos();
        }

        private void InitializeDataGridView()
        {
            grdClientes.ColumnCount = 5;
            grdClientes.ColumnHeadersVisible = true;

            grdClientes.AutoGenerateColumns = false;

            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            grdClientes.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            grdClientes.Columns[0].Name = "Nombre";
            grdClientes.Columns[0].DataPropertyName = "nombre";

            grdClientes.Columns[1].Name = "Apellido";
            grdClientes.Columns[1].DataPropertyName = "apellido";

            grdClientes.Columns[2].Name = "Documento";
            grdClientes.Columns[2].DataPropertyName = "nroDocumento";

            grdClientes.Columns[3].Name = "Telefono";
            grdClientes.Columns[3].DataPropertyName = "telefono";

            grdClientes.Columns[4].Name = "Obra Social";
            grdClientes.Columns[4].DataPropertyName = "obraSocial";

            grdClientes.AutoResizeColumnHeadersHeight();

            grdClientes.AutoResizeRows(
                DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);

            grdClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            frmABMCliente formulario = new frmABMCliente();
            var cliente = (Cliente)grdClientes.CurrentRow.DataBoundItem;
            formulario.SeleccionarCliente(frmABMCliente.FormMode.update, cliente);
            formulario.Show();
            btnBuscar_Click(sender, e);
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            frmABMCliente formulario = new frmABMCliente();
            var cliente = (Cliente)grdClientes.CurrentRow.DataBoundItem;
            formulario.SeleccionarCliente(frmABMCliente.FormMode.delete, cliente);
            formulario.Show();
            btnBuscar_Click(sender,e);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void grdClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnBaja.Enabled = true;
            btnModificacion.Enabled = true;
        }
        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            LlenarCombo(cboObrasSociales, oObraSocialService.ObtenerTodos(), "nombre", "id");
            this.CenterToParent();
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
            {
                txtDocumento.Enabled = false;
                txtNombre.Enabled = false;
                cboObrasSociales.Enabled = false;
            }
            else
            {
                txtDocumento.Enabled = true;
                txtNombre.Enabled = true;
                cboObrasSociales.Enabled = true;
            }
        }
    }
}
