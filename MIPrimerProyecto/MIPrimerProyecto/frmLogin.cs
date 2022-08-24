using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIPrimerProyecto
{
    public partial class frmLogin : Form
    {
        private string usuario="admin";
        private string clave="1234";

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text=="")
            {
                MessageBox.Show("Debe ingresar usuario...");
                txtUsuario.Focus();
                return;
            }
            if (txtClave.Text==String.Empty)
            {
                MessageBox.Show("Debe ingresar contraseña...");
                txtClave.Focus();
                return;
            }

            if (this.validar(txtUsuario.Text,txtClave.Text))
            {
                MessageBox.Show("Usuario Válido!!!");
            }
            else
            {
                MessageBox.Show("");
            }
        }

        private bool validar(string u,string c)
        {
            //if (txtUsuario.Text == this.usuario && txtClave.Text == this.clave)
            if (u == this.usuario && c == this.clave)
                return true;
            else
                return false;
        }
    }
}
