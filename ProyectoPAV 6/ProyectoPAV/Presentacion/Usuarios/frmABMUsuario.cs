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
    public partial class frmABMUsuario : Form
    {
        private FormMode formMode = FormMode.insert;

        private readonly UsuarioService oUsuarioService;
        private readonly PerfilService oPerfilService;
        private Usuario oUsuarioSelected;

        public frmABMUsuario()
        {
            InitializeComponent();
            oUsuarioService = new UsuarioService();
            oPerfilService = new PerfilService();
        }
        public enum FormMode
        {
            insert,
            update,
            delete
        }

       

        private void MostrarDato()
        {
            if (oUsuarioSelected != null)
            {
                txtLegajo.Text = oUsuarioSelected.Legajo.ToString();
                txtNombre.Text = oUsuarioSelected.Nombre;
                txtApellido.Text = oUsuarioSelected.Apellido;
                txtMail.Text = oUsuarioSelected.Email;
                txtClave.Text = oUsuarioSelected.Password;
                cboCargos.Text = oUsuarioSelected.Perfil.nombreCargo;
            }
        }

        private void LlenarCombo(ComboBox cbo, Object source, string dispaly, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = dispaly;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        internal void SeleccionarUsuario(FormMode op, Usuario usuarioSelected)
        {
            formMode = op;
            oUsuarioSelected = usuarioSelected;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        if (ExisteUsuario() == false)
                        {
                            if (ValidarCampos())
                            {
                                var oUsuario = new Usuario();
                                //oUsuario.Legajo = (int)txtLegajo.Text;
                                oUsuario.Nombre = txtNombre.Text;
                                oUsuario.Password = txtClave.Text;
                                oUsuario.Email = txtMail.Text;
                                oUsuario.Perfil = new Perfil();
                                oUsuario.Perfil.idCargo = (int)cboCargos.SelectedValue;

                                if (oUsuarioService.CrearUsuario(oUsuario))
                                {
                                    MessageBox.Show("Usuario creado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    this.Close();
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nombre de usuario encontrado!. Ingrese un nombre diferente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtNombre.Focus();
                        }
                        break;
                    }
                case FormMode.update:
                    if (ValidarCampos())
                    {
                        oUsuarioSelected.Nombre = txtNombre.Text;
                        oUsuarioSelected.Apellido = txtApellido.Text;
                        oUsuarioSelected.Email = txtMail.Text;
                        oUsuarioSelected.Password = txtClave.Text;
                        oUsuarioSelected.Perfil = new Perfil();
                        oUsuarioSelected.Perfil.idCargo = (int)cboCargos.SelectedValue;

                        if (oUsuarioService.ActualizarUsuario(oUsuarioSelected))
                        {
                            MessageBox.Show("Usuario actualizado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.Dispose();
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar el usuario", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            
                        }
                    }
                    break;
                case FormMode.delete:
                    if (MessageBox.Show("Seguro que desea habilitar/deshabilitar el usuario seleccionado?","Aviso",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        if (oUsuarioService.ModificarEstadoUsuario(oUsuarioSelected))
                        {
                            MessageBox.Show("Usuario habilitado/deshabilitadp", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Error al actualizar el usuario", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        private bool ValidarCampos()
        {
            if (txtNombre.Text == string.Empty)
            {
                txtNombre.BackColor = Color.Red;
                txtNombre.Focus();
                return false;
            }
            else
                txtNombre.BackColor = Color.White;
            return true;
        }

        private bool ExisteUsuario()
        {
            return oUsuarioService.ObtenerUsuario(txtNombre.Text) != null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmABMUsuario_Load(object sender, EventArgs e)
        {
            LlenarCombo(cboCargos, oPerfilService.traerTodos(), "nombreCargo", "idCargo");
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nuevo Usuario";
                        break;
                    }

                case FormMode.update:
                    {
                        this.Text = "Actualizar Usuario";
                        MostrarDato();
                        txtLegajo.Enabled = true;
                        txtNombre.Enabled = true;
                        txtApellido.Enabled = true;
                        txtMail.Enabled = true;
                        txtClave.Enabled = true;
                        cboCargos.Enabled = true;
                        break;
                    }

                case FormMode.delete:
                    {
                        this.Text = "Habilitar/Deshabilitar Usuario";
                        MostrarDato();
                        txtLegajo.Enabled = false;
                        txtNombre.Enabled = false;
                        txtApellido.Enabled = false;
                        txtMail.Enabled = false;
                        txtClave.Enabled = false;
                        cboCargos.Enabled = false;
                        break;
                    }

            }
        }
    }
}
