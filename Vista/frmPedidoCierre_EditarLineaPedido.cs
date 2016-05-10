using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos;

namespace Vista
{
    public partial class frmPedidoCierre_EditarLineaPedido : Form
    {
        private ModeloLineaPedido glb_mod_lineaActual;

        #region Constructores
        public frmPedidoCierre_EditarLineaPedido()
        {
            InitializeComponent();
            this.DialogResult = System.Windows.Forms.DialogResult.No;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.txtBoxCodigoOriginal.Enabled =
                this.txtBoxCodigoArticuloProveedor.Enabled =
                this.txtBoxDescripcion.Enabled =
                this.txtBoxValorParcialSinDescuento.Enabled =
                this.txtBoxValorParcialConDescuento.Enabled = false;
        }
        public frmPedidoCierre_EditarLineaPedido(Modelos.ModeloLineaPedido p_mod_lineaPedido,LibreriaClasesCompartidas.Constantes.CodigosTiposPedidos p_tipoPedido) : this()
        {
            glb_mod_lineaActual = p_mod_lineaPedido;
            this.cargarLineaEnControl(p_mod_lineaPedido);
            if (p_tipoPedido == LibreriaClasesCompartidas.Constantes.CodigosTiposPedidos.TipoPedidoPersona)
            {
                this.inicializarDataGridView();
                this.cargarDescuentosEnControl(p_mod_lineaPedido.descuentos);
            }
            else if (p_tipoPedido == LibreriaClasesCompartidas.Constantes.CodigosTiposPedidos.TipoPedidoProveedor)
            {
                this.grpBoxDescuentos.Enabled = false;
                this.checkBoxStockNegativo.Visible = false;
                this.checkBoxStockNegativo.Checked = true;
            }
        }
        #endregion
        
        #region Métodos
        
        #region Inicialización
        private void inicializarDataGridView()
        {
            dgvDescuentos.Columns.Add("descripcion","Nombre");
            dgvDescuentos.Columns[0].FillWeight = 1;
            dgvDescuentos.Columns.Add("descuento", "Descuento");
            dgvDescuentos.Columns[1].FillWeight = 1;
            dgvDescuentos.Columns.Add("porcentaje", "Porcentaje");
            dgvDescuentos.Columns[2].FillWeight = 1;
        }
        #endregion

        #region Modelo -> Controles
        private void cargarDescuentosEnControl(List<ModeloDescuento> p_lst_mod_descuento)
        {
            dgvDescuentos.Rows.Clear();
            DataGridViewRow row;
            int rowIndex;
            foreach (ModeloDescuento descuento in p_lst_mod_descuento)
            {
                rowIndex = dgvDescuentos.Rows.Add();
                row = dgvDescuentos.Rows[rowIndex];

                row.Cells["descripcion"].Value = descuento.descripcion;
                row.Cells["descuento"].Value = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}", descuento.descuento);
                row.Cells["porcentaje"].Value = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:P1}", descuento.porcentajeSobreTotal);
            }

            this.txtBoxDescuentoDescripcion.Text = "";
            this.txtBoxDescuentoNeto.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}", 0);
            this.txtBoxDescuentoPorcentaje.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:P1}", 0);
        }
        private void cargarLineaEnControl(ModeloLineaPedido p_mod_lineaPedido)
        {
            this.txtBoxCodigoOriginal.Text = p_mod_lineaPedido.articulo.codigoOriginal;
            this.txtBoxCodigoArticuloProveedor.Text = p_mod_lineaPedido.articulo.codigoArticuloProveedor;
            this.txtBoxDescripcion.Text = p_mod_lineaPedido.articulo.descripcion;
            this.checkBoxStockNegativo.Checked = p_mod_lineaPedido.permitirStockNegativo;

            this.txtBoxValorUnitario.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}", p_mod_lineaPedido.valorUnitario);
            this.nmrcUpDownCantidad.Value = p_mod_lineaPedido.cantidadArticulos;
            this.txtBoxValorParcialSinDescuento.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}", p_mod_lineaPedido.getValorParcialSinDescuentos()); 
            this.txtBoxValorParcialConDescuento.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}", p_mod_lineaPedido.getValorParcial()); 
        }
        #endregion

        public ModeloLineaPedido getLineaPedido()
        {
            return glb_mod_lineaActual;
        }
        #endregion

        #region Eventos

        private void btnAgrearDescuento_Click(object sender, EventArgs e)
        {
            decimal descuento;
            double porcentaje = 0;
            if (!Decimal.TryParse(this.txtBoxDescuentoNeto.Text.Replace("$", ""), out descuento) &&
                !Double.TryParse(this.txtBoxDescuentoPorcentaje.Text.Replace("%", "").Replace(".", ","), out porcentaje))
            {
                MessageBox.Show("Los datos ingresados para nuevo descuento no son válidos");
                return;
            }
            if (descuento == 0 && porcentaje == 0)
            {
                MessageBox.Show("Los descuentos no pueden ser cero");
                return;
            }
            porcentaje = porcentaje / 100;
            
            ModeloDescuento lcl_mod_descuento = new ModeloDescuento();

            lcl_mod_descuento.descripcion = this.txtBoxDescuentoDescripcion.Text;
            lcl_mod_descuento.descuento = descuento;
            lcl_mod_descuento.porcentajeSobreTotal = porcentaje;

            glb_mod_lineaActual.addDescuento(lcl_mod_descuento);

            this.cargarDescuentosEnControl(glb_mod_lineaActual.descuentos);
            this.cargarLineaEnControl(glb_mod_lineaActual);
        }

        private void btnQuitarDescuento_Click(object sender, EventArgs e)
        {
            ModeloDescuento lcl_mod_descuento = new ModeloDescuento();
            lcl_mod_descuento.descuento = (decimal)this.dgvDescuentos.CurrentRow.Cells["descuento"].Value;
            lcl_mod_descuento.descripcion = (string)this.dgvDescuentos.CurrentRow.Cells["descripcion"].Value;
            glb_mod_lineaActual.removeDescuento(lcl_mod_descuento);

            this.cargarDescuentosEnControl(glb_mod_lineaActual.descuentos);
            this.cargarLineaEnControl(glb_mod_lineaActual);
        }

        private void txtBoxValorUnitario_Leave(object sender, EventArgs e)
        {
            decimal valor;
            if (!Decimal.TryParse(this.txtBoxValorUnitario.Text.Replace("$", ""), out valor) || valor == glb_mod_lineaActual.valorUnitario)
            {
                this.txtBoxValorUnitario.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}", this.glb_mod_lineaActual.valorUnitario);
                return;
            }

            this.glb_mod_lineaActual.valorUnitario = valor;

            this.cargarLineaEnControl(this.glb_mod_lineaActual);
            this.cargarDescuentosEnControl(this.glb_mod_lineaActual.descuentos);
        }

        private void nmrcUpDownCantidad_ValueChanged(object sender, EventArgs e)
        {
            int cantidad = Convert.ToInt32(nmrcUpDownCantidad.Value);

            if (cantidad != glb_mod_lineaActual.cantidadArticulos)
            {
                this.glb_mod_lineaActual.cantidadArticulos = cantidad;
                this.cargarLineaEnControl(this.glb_mod_lineaActual);
                this.cargarDescuentosEnControl(this.glb_mod_lineaActual.descuentos);
            }
        }

        #endregion

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxStockNegativo_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                glb_mod_lineaActual.permitirStockNegativo = true;
                this.nmrcUpDownCantidad.Maximum = 999999;  
            }
            else
            {
                glb_mod_lineaActual.permitirStockNegativo = false;
                this.nmrcUpDownCantidad.Maximum = glb_mod_lineaActual.articulo.stockActual.Value;
            }
        }

      
        
    }
}
