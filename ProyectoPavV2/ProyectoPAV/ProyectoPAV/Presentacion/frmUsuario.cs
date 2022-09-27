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
        private Usuario usuarioSeleccionado;

        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            CargarCombo(cboPerfil, oPerfil.traerTodos());
            HabilitarModoConsulta(true);
            MiAccion = Acciones.Modificacion;
        }
        
        private void HabilitarModoEdicion(bool v)
        {
            
            txtClave.Enabled = v;
            txtLegajo.Enabled = v;
            txtMail.Enabled = v;
            txtNombre.Enabled = v;
            txtApellido.Enabled = v;
            cboPerfil.Enabled = v;
            btnGuardarU.Enabled = v;
            btnCancelarU.Enabled = v;
            btnAgregarU.Enabled = !v;
            btnEditarU.Enabled = !v;
            btnSalirU.Enabled = !v;
            btnEliminarU.Enabled = !v;
            grdUsuario.Enabled = !v;

        }

        private void HabilitarModoConsulta(bool v)
        {
            txtClave.Enabled = !v;
            txtLegajo.Enabled = !v;
            txtMail.Enabled = !v;
            txtNombre.Enabled = !v;
            txtApellido.Enabled = !v;
            cboPerfil.Enabled = !v;
            btnGuardarU.Enabled = !v;
            btnCancelarU.Enabled = !v;
            btnAgregarU.Enabled = v;
            btnEditarU.Enabled = v;
            btnSalirU.Enabled = v;
            btnEliminarU.Enabled = v;
            grdUsuario.Enabled = !v;
        }
    

    


        private void LimpiarCampos()
        {
            txtMail.Text = String.Empty;
            txtNombre.Text = String.Empty;
            txtClave.Text = String.Empty;
            txtLegajo.Text = String.Empty;
            txtApellido.Text = String.Empty;
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
                grilla.Rows.Add(tabla.Rows[i]["idUsuario"],
                                tabla.Rows[i]["nombreUsu"],
                                tabla.Rows[i]["emailUsu"]);
            }
            grilla.Focus();
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
            MiAccion = Acciones.Modificacion;
            MessageBox.Show("Seleccione un usuario de la grilla, y modifique los campos.");
            CargarGrilla(grdUsuario, oUsuario.traerTodos());
            txtNombre.Enabled = true;
        }


        private void btnEliminarU_Click(object sender, EventArgs e)
        {
            MiAccion = Acciones.Baja;
            txtNombre.Enabled = true;
            btnGuardarU.Enabled = true;
            btnCancelarU.Enabled = true;
            txtNombre.Focus();
            HabilitarModoEdicion(true);
            MessageBox.Show("Ingrese el nombre del usuario que desea eliminar.");
        }

        private void btnGuardarU_Click(object sender, EventArgs e)
        {
            //VALIDAR LOS DATOS

            //CREAR y CARGAR el obejto

            if (MiAccion == Acciones.Alta)
            {
                
                if (ExisteUsuario() == false)
                {
                    if (ValidarCampos())
                    {
                        var usuarioCreado = new Usuario();
                        usuarioCreado.Nombre = txtNombre.Text;
                        usuarioCreado.Apellido = txtApellido.Text;
                        usuarioCreado.Password = txtClave.Text;
                        usuarioCreado.Legajo = Convert.ToInt32(txtLegajo.Text);
                        usuarioCreado.Email = txtMail.Text;
                        usuarioCreado.Perfil = new Perfil();
                        usuarioCreado.Perfil.idCargo = (int)cboPerfil.SelectedValue;


                        if (oUsuario.CrearUsuario(usuarioCreado))
                        {
                            MessageBox.Show("Se ha creado el usuario con exito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            CargarGrilla(grdUsuario, oUsuario.traerTodos());
                            LimpiarCampos();

                        }
                        else
                        {
                            MessageBox.Show("No se ha podido crear el usuario, intentelo nuevamente");
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Ya existe un usuario con ese nombre! Ingrese uno diferente!");
                }
            }
            if (MiAccion == Acciones.Baja)
            {
                if (ExisteUsuario() == true)
                {
                   if ( MessageBox.Show("¿Esta seguro que desea darlo de baja?", "El usuario existe", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        if (oUsuario.EliminarUsuario(txtNombre.Text))
                        {
                            MessageBox.Show("Usuario dado de baja.");
                            CargarGrilla(grdUsuario, oUsuario.traerTodos());
                            LimpiarCampos();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No existe un usario que corresponda con el nombre ingresado. Intentelo nuevamente.");
                    LimpiarCampos();
                }
            }
            if (MiAccion == Acciones.Modificacion)
            {
                //int idUsuarioModificado = oUsuario.ObtenerIdUsuario(txtNombre.Text);
                string Nombre = txtNombre.Text;
                string Apellido = txtApellido.Text;
                string Password = txtClave.Text;
                int legajo = Convert.ToInt32(txtLegajo.Text);
                string email = txtMail.Text;
                Perfil perfil = new Perfil();
                perfil.idCargo = (int)cboPerfil.SelectedValue;

                if (oUsuario.ModificarUsuario(Nombre, Apellido, Password, legajo, email, perfil))
                {
                    MessageBox.Show("Se ha modificado el usuario con exito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarGrilla(grdUsuario, oUsuario.traerTodos());
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("No se ha podido modificar el usuario, intentelo nuevamente");
                    LimpiarCampos();
                }
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
        //Llama al metodo que busca al usuario en la base de datos
        private bool ExisteUsuario()
        {
            if (oUsuario.ObtenerUsuario(txtNombre.Text) == null)
            {
                return false;
            }
            else
                return true;
            
        }
        //Valida que los campos obligatorios no esten vacios
        private bool ValidarCampos()
        {
            if (txtNombre.Text == String.Empty)
            {
                MessageBox.Show("Ingrese un nombre de usuario!");
                txtNombre.Focus();
                return false;
            }
            if (txtApellido.Text == String.Empty)
            {
                MessageBox.Show("Ingrese un apellido!");
                txtApellido.Focus();
                return false;
            }
            if (txtLegajo.Text == String.Empty)
            {
                MessageBox.Show("Ingrese un Legajo!");
                txtLegajo.Focus();
                return false;
            }  
            if (txtClave.Text == String.Empty)
            {
                MessageBox.Show("Ingrese una contraseña");
                txtClave.Focus();
                return false;
            }

            if (cboPerfil.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un cargo para el usuario!");
                cboPerfil.Focus();
                return false;
            }
            return true;

        }

        private void grdUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CargarGrilla(grdUsuario, oUsuario.traerTodos());
            btnConsultar.Enabled = false;
        }

        private void CargarCampos(int idUsuario)
        {
            DataTable tabla = oUsuario.traerPorId(idUsuario);
            txtNombre.Text = tabla.Rows[0]["nombreUsu"].ToString();
            //txtApellido.Text = tabla.Rows[0]["apellidoUsu"].ToString();
            txtClave.Text = tabla.Rows[0]["claveUsu"].ToString();
            txtMail.Text = tabla.Rows[0]["emailUsu"].ToString();
            cboPerfil.SelectedValue = tabla.Rows[0]["idCargoUsu"];

        
        }

        private void grdUsuario_SelectionChanged(object sender, EventArgs e)
        {
            CargarCampos((int)grdUsuario.CurrentRow.Cells[0].Value);
        }
    }
}
