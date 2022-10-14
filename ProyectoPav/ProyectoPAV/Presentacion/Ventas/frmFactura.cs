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
using ProyectoPAV.Entidades;

namespace ProyectoPAV.Presentacion.Ventas
{
    public partial class frmFactura : Form
    {
        private ClienteService oClienteService;
        private ObraSocialService oObraSocialService;
        private FormaDePagoService oFormaDePago;
        private ProductoService oProductoService;
        private readonly DetalleFacturaService oDetalleFacturaService;
        public frmFactura()
        {
            InitializeComponent();
            oClienteService = new ClienteService();
            oObraSocialService = new ObraSocialService();
            oFormaDePago = new FormaDePagoService();
            oProductoService = new ProductoService();
            oDetalleFacturaService = new DetalleFacturaService();
        }

        private void LlenarCombo(ComboBox cbo, Object source, String display, string value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
            cbo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void frmFactura_Load(object sender, EventArgs e)
        {
            //LlenarCombo(cboClientes, oClienteService.ObtenerTodos(), "nombre", "nroDocumento");
            LlenarCombo(cboObrasSociales, oObraSocialService.TraerTodos(), "nombre", "id");
            LlenarCombo(cboFDP, oFormaDePago.ObtenerTodos(), "nombreFDP", "idFDP");
            LlenarCombo(cboProductos, oProductoService.ObtenerTodos(), "nombre", "idProducto");
        }

        private void cboProductos_SelectedValueChanged(object sender, EventArgs e)
        {
            Producto productoSeleccionado = new Producto();

            if (cboProductos.SelectedValue != null)
            {
                productoSeleccionado = (Producto)oProductoService.ObtenerProducto(cboProductos.Text);
                if (productoSeleccionado != null)
                {
                    txtPrecio.Text = productoSeleccionado.Precio.ToString();
                }

            }
        }

        private bool validarCamposDetalle()
        {
            if (txtCantidad.Text == String.Empty)
            {
                txtCantidad.BackColor = Color.Red;
                txtCantidad.Focus();
                return false;
            }
            else
                txtCantidad.BackColor = Color.White;

            if (cboProductos.SelectedValue == null)
            {
                cboProductos.BackColor = Color.Red;
                cboProductos.Focus();
                return false;
            }
            else
                cboProductos.BackColor = Color.White;

            if (txtNroFactura.Text == String.Empty)
            {
                txtNroFactura.BackColor = Color.Red;
                txtNroFactura.Focus();
                return false;
            }
            else
                txtNroFactura.BackColor = Color.White;

            return true;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto productoSeleccionado = new Producto();
            if (validarCamposDetalle())
            {
                if (cboProductos.SelectedValue != null)
                {
                    productoSeleccionado = (Producto)oProductoService.ObtenerProducto(cboProductos.Text);
                    DetalleFactura oDetalle = new DetalleFactura();
                    oDetalle.idProducto = productoSeleccionado.idProducto;
                    oDetalle.nombreProducto = productoSeleccionado.Nombre;
                    oDetalle.numeroFactura = Convert.ToInt32(txtNroFactura.Text);
                    oDetalle.cantidad = Convert.ToInt32(txtCantidad.Text);
                    oDetalle.importe = Convert.ToInt32(txtImporte.Text);
                    oDetalle.descripcionProducto = productoSeleccionado.Descripcion;
                    oDetalleFacturaService.CrearDetalle(oDetalle);
                    grdDetalle.DataSource = oDetalleFacturaService.TraerTodos(txtNroFactura.Text.ToString());
                    if (txtSubTotal.Text != String.Empty)
                    {
                        txtSubTotal.Text = ((Convert.ToInt32(txtSubTotal.Text)) + (Convert.ToInt32(oDetalle.importe))).ToString();
                    }
                    else
                        txtSubTotal.Text = oDetalle.importe.ToString();
                    if (txtDescuento.Text != String.Empty)
                    {
                        txtImporteTotal.Text = ((Convert.ToInt32(txtSubTotal.Text)) - ((Convert.ToInt32(txtSubTotal.Text)) * (Convert.ToDouble(txtDescuento.Text)))).ToString();
                    }
                    else
                        txtImporteTotal.Text = txtSubTotal.Text.ToString();
                }
            }


        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            if (txtPrecio != null)
            {
                txtImporte.Text = (Convert.ToInt32(txtCantidad.Text) * Convert.ToInt32(txtPrecio.Text)).ToString();
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            var detalleElegido = (DetalleFactura)grdDetalle.CurrentRow.DataBoundItem;

            if (oDetalleFacturaService.BorrarDetalle(detalleElegido.idProducto, detalleElegido.numeroFactura))
            {
                MessageBox.Show("Borrado");
            }
            grdDetalle.DataSource = oDetalleFacturaService.TraerTodos(txtNroFactura.Text.ToString());
        }


    }
}
