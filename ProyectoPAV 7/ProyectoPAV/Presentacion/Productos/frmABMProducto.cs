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

namespace ProyectoPAV.Presentacion.Productos
{
    public partial class frmABMProducto : Form
    {
        private FormMode formMode = FormMode.insert;

        private readonly ProductoService oProductoService;
        private readonly TipoProdService oTipoProdService;
        private Producto oProductoSelected;

        public frmABMProducto()
        {
            InitializeComponent();
            oProductoService = new ProductoService();
            oTipoProdService = new TipoProdService();
        }
        public enum FormMode
        {
            insert,
            update,
            delete
        }

        internal void SeleccionarProducto(FormMode op, Producto productoSelected)
        {
            formMode = op;
            oProductoSelected = productoSelected;
        }
        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void frmABMProducto_Load(object sender, EventArgs e)
        {
            LlenarCombo(cboTipoProducto, "", "", ""); // completar.
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        this.Text = "Nuevo Producto";
                        break;
                    }
                case FormMode.update:
                    {
                        this.Text = "Actualizacion de Producto";
                        MostrarDatos();
                        txtNombre.Enabled = false;
                        txtCantidad.Enabled = true;
                        txtPrecio.Enabled = true;
                        txtDescripcion.Enabled = true;
                        cboTipoProducto.Enabled = true;
                        break;
                    }
                case FormMode.delete:
                    {
                        MostrarDatos();
                        this.Text = "Baja de Producto";
                        txtNombre.Enabled = false;
                        txtCantidad.Enabled = false;
                        txtPrecio.Enabled = false;
                        txtDescripcion.Enabled = false;
                        cboTipoProducto.Enabled = false;
                        break;
                    }
            }
        }

        private void MostrarDatos()
        {
            if (oProductoSelected != null)
            {
                txtNombre.Text = oProductoSelected.Nombre;
                txtPrecio.Text = oProductoSelected.Precio.ToString();
                txtCantidad.Text = oProductoSelected.Cantidad.ToString();
                txtDescripcion.Text = oProductoSelected.Descripcion;
                cboTipoProducto.Text = oProductoSelected.TipoProducto.Nombre;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.insert:
                    {
                        if (ExisteProducto() == false)
                        {
                            if (ValidarCampos())
                            {

                                var oProducto = new Producto();
                                oProducto.Precio = Convert.ToInt32(txtPrecio.Text);
                                oProducto.Nombre = txtNombre.Text.ToString();
                                oProducto.Cantidad = Convert.ToInt32(txtCantidad.Text);
                                oProducto.Descripcion = txtDescripcion.Text;
                                oProducto.TipoProducto = new TipoProd();
                                oProducto.TipoProducto.idTipoProducto = (int)cboTipoProducto.SelectedValue;

                                if (oProductoService.CrearProducto(oProducto))
                                {
                                    MessageBox.Show("Producto creado con exito!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                            }

                        }
                        else
                            MessageBox.Show("Ya existe un producto registrado con ese nombre!!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                case FormMode.update:
                    {
                        oProductoSelected.Nombre = txtNombre.Text;
                        oProductoSelected.TipoProducto = new TipoProd();
                        oProductoSelected.TipoProducto.idTipoProducto = (int)cboTipoProducto.SelectedValue;
                        oProductoSelected.Cantidad = Convert.ToInt32(txtCantidad.Text);
                        oProductoSelected.Precio = Convert.ToInt32(txtPrecio.Text);

                        if (oProductoService.ActualizarProducto(oProductoSelected))
                        {
                            MessageBox.Show("Producto actualizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Dispose();
                        }
                        else
                            MessageBox.Show("Error al actualizar el producto!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }


                case FormMode.delete:
                    {
                        if (MessageBox.Show("Seguro que desea habilitar/deshabilitar el producto seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            if (oProductoService.ModificarBorrado(oProductoSelected))
                            {
                                MessageBox.Show("Producto Habilitado/Deshabilitado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Error al actualizar el producto!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        break;
                    }

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
            if (cboTipoProducto.SelectedValue == null)
            {
                cboTipoProducto.BackColor = Color.Red;
                cboTipoProducto.Focus();
                return false;
            }
            else
                cboTipoProducto.BackColor = Color.White;

            if (txtPrecio.Text == string.Empty)
            {
                txtPrecio.BackColor = Color.Red;
                txtPrecio.Focus();
                return false;
            }
            else
                txtPrecio.BackColor = Color.White;

            return true;
        }

        private bool ExisteProducto()
        {
            return oProductoService.ObtenerProducto(txtNombre.Text) != null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}