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
            //var filtros = new Dictionary<string, object>();

            if(!chkTodos.Checked)
            {
                //Valida que el txt de nombre no este vacio y asigna su contenido
                if (txtNombre.Text != string.Empty)
                {
                    condiciones += " AND nombreCliente=" + "'" +  txtNombre.Text+"'";
                }

                //Valida que el txt de numero de documento no esta vacio y asigna su contenido
                if (txtNumero.Text != string.Empty)
                {
                    condiciones += " AND nroDocumento=" + "'" + txtNumero.Text+"'";
                }

                //Vlida que el txt de apellido no esta vacio y asigna su valor a la consulta
                if (txtApellido.Text != string.Empty)
                {
                    condiciones += " AND apellidoCliente=" + "'" + txtApellido.Text + "'";
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


















        private void label1_Click(object sender, EventArgs e)
        {

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
