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
        // Metodo para habilitar y deshabilitar los text box y los botones apenas se ejecuta
        private void HabilitarModoEdicion(bool v)
        {
            // no se pone porque el id se genera automaticamente y el usuario no deberia poder cambiarlo.
            //txtId.Enabled = v;
            txtClave.Enabled = v;
            txtMail.Enabled = v;
            txtNombre.Enabled = v;
            cboPerfil.Enabled = v;
            btnGuardarU.Enabled = v;
            btnCancelarU.Enabled = v;
            // Niega el valor de v -> si v es true toma el valor de false
            btnAgregarU.Enabled = !v;
            btnEditarU.Enabled = !v;
            btnSalirU.Enabled = !v;
            grdUsuario.Enabled = !v;
        }
        // Pone todos los text box en blanco
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

        }
    }
}
