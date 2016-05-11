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
    public partial class frmPedidoNuevo_editarCantidad : Form
    {
        ModeloLineaPedido lineaPedidoActual;
        public frmPedidoNuevo_editarCantidad()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public frmPedidoNuevo_editarCantidad(ModeloLineaPedido p_mod_lineaPedido, LibreriaClasesCompartidas.Constantes.CodigosTiposPedidos p_tipoPedido) : this()
        {
            this.lineaPedidoActual = p_mod_lineaPedido;
            this.cargarLineaPedidoEnControles(p_mod_lineaPedido);
            if (p_tipoPedido == LibreriaClasesCompartidas.Constantes.CodigosTiposPedidos.TipoPedidoProveedor)
            {
                this.chckBoxPermitirStockNegativo.Visible = false;
                this.chckBoxPermitirStockNegativo.Checked = true;
            }
        }
        #region Modelo -> Controles
        private void cargarLineaPedidoEnControles(ModeloLineaPedido p_mod_lineaPedido)
        {
            this.nmrcUpDownCantidad.Value = p_mod_lineaPedido.cantidadArticulos;
            this.chckBoxPermitirStockNegativo.Checked = p_mod_lineaPedido.permitirStockNegativo;
        }
        #endregion
        #region Controles -> Modelo
        private ModeloLineaPedido cargarControlesEnLineaPedido()
        {
            lineaPedidoActual.permitirStockNegativo = this.chckBoxPermitirStockNegativo.Checked;

            if(!this.validarCantidad(lineaPedidoActual))
            {
                return null;
            }
            lineaPedidoActual.cantidadArticulos = Convert.ToInt32(this.nmrcUpDownCantidad.Value); 
            return lineaPedidoActual;
        }
        #endregion
        #region Validación
        private bool validarCantidad(ModeloLineaPedido p_mod_lineaPedido)
        {
            if (p_mod_lineaPedido.cantidadArticulos < 0)
            {
                MessageBox.Show("La cantidad de artículos debe ser mayor o igual a 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!p_mod_lineaPedido.permitirStockNegativo && Convert.ToInt32(this.nmrcUpDownCantidad.Value) > p_mod_lineaPedido.articulo.stockActual)
            {
                MessageBox.Show("La cantidad solicitada es mayor al stock actual", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        #endregion

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.cargarControlesEnLineaPedido() != null)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Hide();
            }
        }


    }
}
