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
using ProyectoPAV.Presentacion.Usuarios;

namespace ProyectoPAV.Presentacion
{
    public partial class frmLogin : Form
    {
        private UsuarioService miGestor = new UsuarioService();
        private Usuario miUsuario = new Usuario();

        internal Usuario MiUsuario { get => miUsuario; set => miUsuario = value; }

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtUsuario.Text))
            {
                MessageBox.Show("Debe ingresar un Usuario", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUsuario.Focus();
                return;
            }
            if (this.txtClave.Text == string.Empty)
            {
                MessageBox.Show("Debe ingresar una Contraseña", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtClave.Focus();
                return;
            }

            this.miUsuario.Nombre = this.txtUsuario.Text;
            this.miUsuario.Password = this.txtClave.Text;
            this.miUsuario.Id_usuario = this.miGestor.encontrarUsuario(miUsuario.Nombre, miUsuario.Password);

            if (miUsuario.Id_usuario != 0)
            {
                MessageBox.Show("Login OK", "Ingreso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmMenu ventana = new frmMenu();
                ventana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos", "Validación de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUsuario.Text = "";
                this.txtClave.Text = string.Empty;
                this.txtUsuario.Focus();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmLogin_Load_1(object sender, EventArgs e)
        {

        }
    }
}
