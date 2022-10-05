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

namespace ProyectoPAV.Presentacion.Usuarios
{
    public partial class frmUsuario : Form
    {
        private UsuarioService oUsuarioService;
        private PerfilService oPerfilService;
        public frmUsuario()
        {
            InitializeComponent();
            InitializeDataGridView();
            oUsuarioService = new UsuarioService();
            oPerfilService = new PerfilService();
        }
        
        private void LlenarCombo(ComboBox cbo, Object source, string dispaly, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = dispaly;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void InitializeDataGridView()
        {
            dgvUsers.ColumnCount = 3;
            dgvUsers.ColumnHeadersVisible = true;

            dgvUsers.AutoGenerateColumns = false;

            DataGridViewCellStyle columnHeadersStyle = new DataGridViewCellStyle();

            columnHeadersStyle.BackColor = Color.Beige;
            columnHeadersStyle.Font = new Font("Verdena", 8, FontStyle.Bold);
            dgvUsers.ColumnHeadersDefaultCellStyle = columnHeadersStyle;

            dgvUsers.Columns[0].Name = "Usuario";
            dgvUsers.Columns[0].DataPropertyName = "NombreUsuario";

            dgvUsers.Columns[1].Name = "Email";
            dgvUsers.Columns[1].DataPropertyName = "Email";

            dgvUsers.Columns[2].Name = "Cargo";
            dgvUsers.Columns[2].DataPropertyName = "Cargo";

            dgvUsers.AutoResizeColumnHeadersHeight();

            dgvUsers.AutoResizeRows(
                DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodos.Checked)
            {
                txtLegajo.Enabled = false;
                txtNombre.Enabled = false;
                cboCargo.Enabled = false;
            }
            else
            {
                txtLegajo.Enabled = true;
                txtNombre.Enabled = true;
                cboCargo.Enabled = true;
            }
        }

        private void btnConsultar_Click(System.Object sender, System.EventArgs e)
        {
            String condiciones = "";
            var filters = new Dictionary<string, object>();

            if (!chkTodos.Checked)
            {
                if (cboCargo.Text != string.Empty)
                {
                    filters.Add("idCargo", cboCargo.SelectedValue);
                    condiciones += "AND u.idCargo=" + cboCargo.SelectedValue.ToString();

                }
                if (txtNombre.Text != string.Empty)
                {
                    filters.Add("nombreUsu", txtNombre.Text);
                    condiciones += "AND u.nombreUsu=" + "'" + txtNombre.Text + "'";
                }
                if (filters.Count > 0)
                {
                    dgvUsers.DataSource = oUsuarioService.ConsultarConFiltrosSinParametros(condiciones);

                }
                else
                {
                    MessageBox.Show("Debe ingresar al menos un criterio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            else
                dgvUsers.DataSource = oUsuarioService.traerTodos();
        }

        private void dgvUsers_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            btnEditar.Enabled = true;
            btnQuitar.Enabled = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmABMUsuario formulario = new frmABMUsuario();
            formulario.ShowDialog();
            btnConsultar_Click(sender, e);
        }

        private void btnEditar_Click(System.Object sender, System.EventArgs e)
        {
            frmABMUsuario formulario = new frmABMUsuario();
            var usuario = (Usuario)dgvUsers.CurrentRow.DataBoundItem;
            formulario.SeleccionarUsuario(frmABMUsuario.FormMode.update, usuario);
            formulario.ShowDialog();
            btnConsultar_Click(sender, e);
        }

        private void btnQuitar_Click(System.Object sender, System.EventArgs e)
        {
            frmABMUsuario formulario = new frmABMUsuario();
            var usuario = (Usuario)dgvUsers.CurrentRow.DataBoundItem;
            formulario.SeleccionarUsuario(frmABMUsuario.FormMode.delete, usuario);
            formulario.ShowDialog();
            btnConsultar_Click(sender, e);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            LlenarCombo(cboCargo, oPerfilService.traerTodos(), "Nombre", "nombreCargo");
            this.CenterToParent();
        }
    }

}
