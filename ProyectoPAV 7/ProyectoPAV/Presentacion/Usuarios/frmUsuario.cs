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

            if (!chkTodos.Checked)
            {
                if (txtLegajo.Text != String.Empty)
                {
                    condiciones += " AND legajoUsu=" + txtLegajo.Text;
                }

                if (txtNombre.Text != String.Empty)
                {
                    condiciones += " AND nombreUsu=" + "'" + txtNombre.Text + "'";
                }

                if (cboCargo.Text != String.Empty)
                {
                    condiciones += " AND idCargoUsu=" + cboCargo.SelectedValue;
                }

                if (condiciones != "")
                {
                    grdUsuarios.Rows.Clear();
                    CargarGrilla(oUsuarioService.ConsultarConCondiciones(condiciones));
                }

                else
                    MessageBox.Show("Debe ingresar al menos un criterio", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                grdUsuarios.Rows.Clear();
                CargarGrilla(oUsuarioService.TraerTodos());
                
            }
        }

        private void CargarGrilla(IList<Usuario> usuarios)
        {
            
            foreach (Usuario u in usuarios)
            {
                grdUsuarios.Rows.Add(u.Nombre, u.Apellido, u.Perfil.nombreCargo, u.Email);
            }
        }

      

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmABMUsuario formulario = new frmABMUsuario();
            formulario.ShowDialog();
            
        }

        private void btnEditar_Click(System.Object sender, System.EventArgs e)
        {
            frmABMUsuario formulario = new frmABMUsuario();
            var usuario = (Usuario)grdUsuarios.CurrentRow.DataBoundItem;
            formulario.SeleccionarUsuario(frmABMUsuario.FormMode.update, usuario);
            formulario.ShowDialog();
            btnConsultar_Click(sender, e);
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            frmABMUsuario formulario = new frmABMUsuario();
            var usuario = (Usuario)grdUsuarios.CurrentRow.DataBoundItem;
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
            LlenarCombo(cboCargo, oPerfilService.traerTodos(), "nombreCargo", "idCargo");
            this.CenterToParent();
        }
    }

}
