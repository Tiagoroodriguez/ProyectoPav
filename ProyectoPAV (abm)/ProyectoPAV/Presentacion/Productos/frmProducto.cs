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
            InitializeDataGridView();
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
            
            if (!chkTodos.Checked)
            {
                if (txtNombre.Text != string.Empty)
                {
                    condiciones += " AND nombreProducto=" + "'" + txtNombre.Text + "'";
                }

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

        private void InitializeDataGridView()
        {
            grdProductos.ColumnCount = 5;
            grdProductos.ColumnHeadersVisible = true;

            grdProductos.AutoGenerateColumns = false;

            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            grdProductos.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            grdProductos.Columns[0].Name = "Nombre";
            grdProductos.Columns[0].DataPropertyName = "Nombre";

            grdProductos.Columns[1].Name = "Tipo Producto";
            grdProductos.Columns[1].DataPropertyName = "TipoProducto";

            grdProductos.Columns[2].Name = "Descripcion";
            grdProductos.Columns[2].DataPropertyName = "Descripcion";

            grdProductos.Columns[3].Name = "Precio";
            grdProductos.Columns[3].DataPropertyName = "Precio";

            grdProductos.Columns[4].Name = "Cantidad";
            grdProductos.Columns[4].DataPropertyName = "Cantidad";

            grdProductos.AutoResizeColumnHeadersHeight();

            grdProductos.AutoResizeRows(
                DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);

            grdProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
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
