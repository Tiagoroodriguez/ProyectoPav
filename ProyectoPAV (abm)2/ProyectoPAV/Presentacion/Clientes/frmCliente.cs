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
        public frmCliente()
        {
            InitializeComponent();
            oClienteService = new ClienteService();
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
                
                if (txtNumero.Text != string.Empty)
                {
                    // agregar en la tabla el nro de telefono
                    condiciones += " AND telefono=" + "'" + txtNumero.Text+"'";
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
            grdClientes.ColumnCount = 4;
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
    }
}
