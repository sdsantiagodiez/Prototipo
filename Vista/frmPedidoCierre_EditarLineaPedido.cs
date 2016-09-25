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
    public partial class frmPedidoCierre_EditarLineaPedido : frmMaterialSkinBase
    {
        private ModeloLineaPedido glb_mod_lineaActual;

        #region Constructores
        public frmPedidoCierre_EditarLineaPedido()
        {
            InitializeComponent();
            
            dgvDescuentos.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvDescuentos.EnableHeadersVisualStyles = false; 
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
            if (p_tipoPedido == LibreriaClasesCompartidas.Constantes.CodigosTiposPedidos.Persona)
            {
                this.inicializarDataGridView();
                this.cargarDescuentosEnControl(p_mod_lineaPedido.descuentos);
                this.nmrcUpDownCantidad.Maximum = p_mod_lineaPedido.articulo.stockActual ?? default(int);
            }
            else if (p_tipoPedido == LibreriaClasesCompartidas.Constantes.CodigosTiposPedidos.Proveedor)
            {
                this.grpBoxDescuentos.Enabled = false;
                this.checkBoxStockNegativo.Visible = false;
                this.checkBoxStockNegativo.Checked = true;
            }
        }
        /// <summary>
        /// Exlusivo para editar lineas de pedidos en devoluciones
        /// </summary>
        /// <param name="p_mod_lineaPedidoActual"></param>
        /// <param name="p_mod_lineaPedidoOriginal"></param>
        public frmPedidoCierre_EditarLineaPedido(Modelos.ModeloLineaPedido p_mod_lineaPedidoActual,Modelos.ModeloLineaPedido p_mod_lineaPedidoOriginal) : this(p_mod_lineaPedidoActual,LibreriaClasesCompartidas.Constantes.CodigosTiposPedidos.Persona)
        {
            this.nmrcUpDownCantidad.Maximum = p_mod_lineaPedidoOriginal.cantidadArticulos;
            this.checkBoxStockNegativo.Visible = false;
        }
        #endregion
        
        #region Métodos
        
        #region Inicialización
        private void inicializarDataGridView()
        {
            dgvDescuentos.Columns.Add("codigoDescuento", "Código");
            dgvDescuentos.Columns[0].FillWeight = 1;
            dgvDescuentos.Columns[0].Visible = false;
            dgvDescuentos.Columns.Add("descripcion","Nombre");
            dgvDescuentos.Columns[1].FillWeight = 1;
            dgvDescuentos.Columns.Add("descuento", "Descuento");
            dgvDescuentos.Columns[2].FillWeight = 1;
            dgvDescuentos.Columns.Add("porcentaje", "Porcentaje");
            dgvDescuentos.Columns[3].FillWeight = 1;
        }
        #endregion

        #region Modelo -> Controles
        private void cargarDescuentosEnControl(List<ModeloDescuentoLineaPedido> p_lst_mod_descuento)
        {
            dgvDescuentos.Rows.Clear();
            DataGridViewRow row;
            int rowIndex;
            foreach (ModeloDescuentoLineaPedido descuento in p_lst_mod_descuento)
            {
                rowIndex = dgvDescuentos.Rows.Add();
                row = dgvDescuentos.Rows[rowIndex];

                row.Cells["codigoDescuento"].Value = descuento.codigoDescuento;
                row.Cells["descripcion"].Value = descuento.descripcion;
                row.Cells["descuento"].Value = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}", descuento.montoDescontadoSobreTotal);
                row.Cells["porcentaje"].Value = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:P1}", descuento.porcentaje);
            }

            this.txtBoxDescuentoDescripcion.Text = "";
            this.txtBoxDescuentoNeto.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}", 0);
            this.txtBoxDescuentoPorcentaje.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:P1}", 0);
        }
        private void cargarLineaEnControl(ModeloLineaPedido p_mod_lineaPedido)
        {
            this.txtBoxCodigoOriginal.Text = p_mod_lineaPedido.articulo.codigoOriginal;
            this.txtBoxCodigoArticuloProveedor.Text = p_mod_lineaPedido.articulo.codigoArticuloProveedor;
            this.txtBoxDescripcion.Text = p_mod_lineaPedido.articulo.getDescripciones();
            this.checkBoxStockNegativo.Checked = p_mod_lineaPedido.permitirStockNegativo;

            this.txtBoxValorUnitario.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}", p_mod_lineaPedido.valorUnitario);
            this.nmrcUpDownCantidad.Value = p_mod_lineaPedido.cantidadArticulos;
            this.txtBoxValorParcialSinDescuento.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}", p_mod_lineaPedido.getValorParcialSinDescuentos()); 
            this.txtBoxValorParcialConDescuento.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}", p_mod_lineaPedido.getValorParcialConDescuento()); 
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
            decimal porcentaje = 0;
            Decimal.TryParse(this.txtBoxDescuentoNeto.Text.Replace("$", ""), out descuento);
            Decimal.TryParse(this.txtBoxDescuentoPorcentaje.Text.Replace("%", "").Replace(".", ",").Trim(), out porcentaje);
            if (!Decimal.TryParse(this.txtBoxDescuentoNeto.Text.Replace("$", ""), out descuento) &&
                !Decimal.TryParse(this.txtBoxDescuentoPorcentaje.Text.Replace("%", "").Replace(".", ",").Trim(), out porcentaje))
            {
                MessageBox.Show("Los datos ingresados para nuevo descuento no son válidos");
                return;
            }
            if (descuento == 0 && porcentaje == 0)
            {
                MessageBox.Show("Los descuentos no pueden ser cero");
                return;
            }
            if(descuento > this.glb_mod_lineaActual.getValorParcialSinDescuentos())
            {
                MessageBox.Show("El descuento no puede ser superior al valor parcial de los elementos.");
                return;
            }
            porcentaje = porcentaje / 100;
            
            ModeloDescuentoLineaPedido lcl_mod_descuento = new ModeloDescuentoLineaPedido();

            lcl_mod_descuento.descripcion = this.txtBoxDescuentoDescripcion.Text;

            if (porcentaje > 0)
            {
                lcl_mod_descuento.asignarDescuentoPorcentual(this.glb_mod_lineaActual.getValorParcialSinDescuentos(), porcentaje);
            }
            else
            {
                lcl_mod_descuento.asignarDescuentoNeto(this.glb_mod_lineaActual.getValorParcialSinDescuentos(), descuento);
            }

            glb_mod_lineaActual.addDescuento(lcl_mod_descuento);

            this.cargarDescuentosEnControl(glb_mod_lineaActual.descuentos);
            this.cargarLineaEnControl(glb_mod_lineaActual);
        }

        private void btnQuitarDescuento_Click(object sender, EventArgs e)
        {
            if (this.dgvDescuentos.CurrentRow == null)
            {
                return;
            }

            ModeloDescuentoLineaPedido lcl_mod_descuento = new ModeloDescuentoLineaPedido();
            string str_monto = Convert.ToString(this.dgvDescuentos.CurrentRow.Cells["descuento"].Value);
            decimal monto;

            if (decimal.TryParse(System.Text.RegularExpressions.Regex.Replace(str_monto, @"\$", ""), out monto))
            {
                lcl_mod_descuento.montoDescontadoSobreTotal = monto;
            }
            else
            {
                MessageBox.Show("El valor no es válido","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            lcl_mod_descuento.codigoDescuento = (int)this.dgvDescuentos.CurrentRow.Cells["codigoDescuento"].Value;
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
