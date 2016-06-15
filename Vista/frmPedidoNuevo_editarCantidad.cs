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
using MaterialSkin;
using MaterialSkin.Animations;
using MaterialSkin.Controls;

namespace Vista
{
    public partial class frmPedidoNuevo_editarCantidad : MaterialForm
    {
        #region Atributos
        ModeloLineaPedido lineaPedidoActual;
        #endregion

        #region Constructores
        public frmPedidoNuevo_editarCantidad()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.nmrcUpDownCantidad.KeyPress += valorNumeroCantidad;
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
        #endregion

        #region Métodos
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
        #endregion
       
        #region Eventos
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.cargarControlesEnLineaPedido() != null)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Hide();
            }
        }
        
        private void valorNumeroCantidad(object sender, KeyPressEventArgs e)
        {
            // solo 0-9 y borrar 
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8))
            {
                e.Handled = true;
                return;
            }
        }
        #endregion

    }
}
