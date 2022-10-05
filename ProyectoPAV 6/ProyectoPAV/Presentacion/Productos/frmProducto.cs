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
    public partial class frmProducto : Form
    {
        private ProductoService oProductoService;

        public frmProducto()
        {
            InitializeComponent();
            oProductoService = new ProductoService();
            //LlenarCombo(cboTipoProducto, "","",""); // completar. 
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            frmABMProducto nuevoForm = new frmABMProducto();
            nuevoForm.Show();
            this.Hide();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            String condiciones = "";
            //var filtros = new Dictionary<string, object>();

            if (!chkTodos.Checked)
            {
                //Valida que el txt de nombre no este vacio y asigna su contenido
                if (txtNombre.Text != string.Empty)
                {
                    condiciones += " AND nombreProducto=" + "'" + txtNombre.Text + "'";
                }

                //Vlida que el cbo de tipo no esta vacio y asigna su valor a la consulta
                if ( cboTipoProducto.Text != string.Empty)
                {
                    condiciones += " AND tipoProducto=" + "'" + cboTipoProducto.SelectedValue.ToString() + "'";
                }

                if (condiciones != "")
                {
                    grdProductos.DataSource = oProductoService.ConsultarConCondiciones(condiciones);
                }
                else
                    MessageBox.Show("Debe ingresar al menos un criterio!!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                grdProductos.DataSource = oProductoService.ObtenerTodos();
        }

        private void btnModificacion_Click(object sender, EventArgs e)
        {
            frmABMProducto formulario = new frmABMProducto();
            var producto = (Producto)grdProductos.CurrentRow.DataBoundItem;
            formulario.SeleccionarProducto(frmABMProducto.FormMode.update, producto);
            formulario.Show();
            btnConsultar_Click(sender, e);
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            frmABMProducto formulario = new frmABMProducto();
            var producto = (Producto)grdProductos.CurrentRow.DataBoundItem;
            formulario.SeleccionarProducto(frmABMProducto.FormMode.delete, producto);
            formulario.Show();
            btnConsultar_Click(sender, e);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }
    }
}
