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

namespace ProyectoPAV.Presentacion
{
    public partial class frmABMCliente : Form
    {
        private FormMode formMode = FormMode.insert;

        private readonly ClienteService oClienteService;
        private readonly TipoDocService oTipoDocService;
        private Cliente oClienteSelected;
        public frmABMCliente()
        {
            InitializeComponent();
            oClienteService = new ClienteService();
            oTipoDocService = new TipoDocService();
        }

        public enum FormMode
        {
            insert,
            update,
            delete
        }

        private void frmABMCliente_Load(object sender, EventArgs e)
        {
            LlenarCombo(cboTipoDoc, oTipoDocService.ObtenerTodos(), "nombreTipo", "idTipo");
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nuevo Cliente";
                        break;
                    }
                case FormMode.update:
                    {
                        this.Text = "Actualizacion de Cliente";
                        MostrarDatos();
                        txtNumero.Enabled = false;
                        txtApellido.Enabled = true;
                        txtFecha.Enabled = true;
                        txtNombre.Enabled = true;
                        cboTipoDoc.Enabled = true;
                        break;
                    }
                case FormMode.delete:
                    {
                        MostrarDatos();
                        this.Text = "Baja de Cliente";
                        txtNumero.Enabled = false;
                        txtApellido.Enabled = false;
                        txtFecha.Enabled = false;
                        txtNombre.Enabled = false;
                        cboTipoDoc.Enabled = false;
                        break;
                    }
            }
        }

        public void SeleccionarCliente(FormMode op, Cliente clienteSelected)
        {
            formMode = op;
            oClienteSelected = clienteSelected;
        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void MostrarDatos()
        {
            if (oClienteSelected != null)
            {
                txtNumero.Text = oClienteSelected.nroDocumento.ToString();
                txtNombre.Text = oClienteSelected.nombre;
                txtApellido.Text = oClienteSelected.apellido;
                txtFecha.Text = oClienteSelected.fechaNacimiento.ToString();
                cboTipoDoc.Text = oClienteSelected.tipoDocumento.nombreTipo;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        if (ExisteCliente() == false)
                        {
                            if (ValidarCampos())
                            {

                                var oCliente = new Cliente();
                                oCliente.nroDocumento = Convert.ToInt32(txtNumero.Text);
                                oCliente.fechaNacimiento = Convert.ToDateTime(txtFecha.Text);
                                oCliente.nombre = txtNombre.Text.ToString();
                                oCliente.apellido = txtApellido.Text.ToString();
                                oCliente.tipoDocumento = new TipoDoc();
                                oCliente.tipoDocumento.idTipo = (int)cboTipoDoc.SelectedValue;

                                if (oClienteService.CrearCliente(oCliente))
                                {
                                    MessageBox.Show("Cliente creado con exito!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                            }

                        }
                        else
                            MessageBox.Show("Ya existe un cliente registrado con ese documento!!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case FormMode.update:
                    {
                        oClienteSelected.nombre = txtNombre.Text;
                        oClienteSelected.tipoDocumento = new TipoDoc();
                        oClienteSelected.tipoDocumento.idTipo = (int)cboTipoDoc.SelectedValue;
                        oClienteSelected.nroDocumento = Convert.ToInt32(txtNumero.Text);
                        oClienteSelected.apellido = txtApellido.Text;
                        oClienteSelected.fechaNacimiento = Convert.ToDateTime(txtFecha.Text);

                        if (oClienteService.ActualizarCliente(oClienteSelected))
                        {
                            MessageBox.Show("Cliente actualizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Dispose();
                        }
                        else
                            MessageBox.Show("Error al actualizar el cliente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                    

                case FormMode.delete:
                    {
                        if (MessageBox.Show("Seguro que desea habilitar/deshabilitar el cliente seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            if (oClienteService.ModificarBorrado(oClienteSelected))
                            {
                                MessageBox.Show("Cliente Habilitado/Deshabilitado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Error al actualizar el cliente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        break;
                    }

            }

        }

        private bool ValidarCampos()
        {
            if (txtNumero.Text == string.Empty)
            {
                txtNumero.BackColor = Color.Red;
                txtNumero.Focus();
                return false;
            }
            else
                txtNumero.BackColor = Color.White;
            if (cboTipoDoc.SelectedValue == null)
            {
                cboTipoDoc.BackColor = Color.Red;
                cboTipoDoc.Focus();
                return false;
            }
            else
                cboTipoDoc.BackColor = Color.White;

            if (txtNombre.Text == string.Empty)
            {
                txtNombre.BackColor = Color.Red;
                txtNombre.Focus();
                return false;
            }
            else 
                txtNombre.BackColor= Color.White;

            if (txtApellido.Text == String.Empty)
            {
                txtApellido.BackColor = Color.Red;
                txtApellido.Focus();
                return false;
            }
            else
                txtApellido.BackColor= Color.White;

            if (txtFecha.Text == String.Empty)
            {
                txtFecha.BackColor = Color.Red;
                txtFecha.Focus();
                return false;
            }
            else 
                txtFecha.BackColor= Color.White;

            return true;
        }

        private bool ExisteCliente()
        {
            return oClienteService.ObtenerCliente(txtNumero.Text) != null;
        }
    }
}
