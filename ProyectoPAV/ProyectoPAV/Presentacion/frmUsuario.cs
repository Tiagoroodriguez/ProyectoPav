using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoPAV.Servicios;
using ProyectoPAV.Entidades;



namespace ProyectoPAV.Presentacion
{
    public partial class frmUsuario : Form
    {
        enum Acciones
        {
            Alta,
            Modificacion,
            Baja
        }
        Acciones MiAccion;
        PerfilService oPerfil = new PerfilService();
        UsuarioService oUsuario = new UsuarioService();

        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            CargarCombo(cboPerfil, oPerfil.traerTodos());
            CargarGrilla(grdUsuario, oUsuario.traerTodos());
            HabilitarModoEdicion(false);
            MiAccion = Acciones.Modificacion;

        }
        
        private void HabilitarModoEdicion(bool v)
        {
            
            txtClave.Enabled = v;
            txtMail.Enabled = v;
            txtNombre.Enabled = v;
            cboPerfil.Enabled = v;
            btnGuardarU.Enabled = v;
            btnCancelarU.Enabled = v;
            btnAgregarU.Enabled = !v;
            btnEditarU.Enabled = !v;
            btnSalirU.Enabled = !v;
            grdUsuario.Enabled = !v;
        }
        
        private void LimpiarCampos()
        {
            txtIdUsuario.Text = String.Empty;
            txtMail.Text = String.Empty;
            txtNombre.Text = String.Empty;
            txtClave.Text = String.Empty;
            cboPerfil.SelectedIndex = -1;
        }

        private void CargarCombo(ComboBox combo, DataTable tabla)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void CargarGrilla(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["id_usuario"],
                                tabla.Rows[i]["usuario"],
                                tabla.Rows[i]["email"]);
            }
        }
        private void btnAgregarU_Click(object sender, EventArgs e)
        {
            MiAccion = Acciones.Alta;
            HabilitarModoEdicion(true);
            LimpiarCampos();
            txtNombre.Focus();
        }

        private void btnEditarU_Click(object sender, EventArgs e)
        {
            HabilitarModoEdicion(true);
        }

        private void btnEliminarU_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar este usuario?",
                               "ELIMINANDO",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Warning,
                               MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                //Delete
            }
        }

        private void btnGuardarU_Click(object sender, EventArgs e)
        {
            //VALIDAR LOS DATOS

            //CREAR y CARGAR el obejto

            if (MiAccion == Acciones.Alta)
            {
                //INSERT
            }
            else
            {
                //UPDATE
            }
            MiAccion = Acciones.Modificacion;
            HabilitarModoEdicion(false);
        }

        private void btnCancelarU_Click(object sender, EventArgs e)
        {
            MiAccion = Acciones.Modificacion;
            LimpiarCampos();
            HabilitarModoEdicion(false);
        }

        private void btnSalirU_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
