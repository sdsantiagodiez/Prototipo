using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladores;

namespace Vista
{
    public partial class frmPreferenciasFacturacion : frmMaterialSkinBase
    {
        #region Atributos
        ControladorPedidoCliente glb_con_pedidoCliente = new ControladorPedidoCliente();
        #endregion

        #region Constructores
        public frmPreferenciasFacturacion()
        {
            InitializeComponent();
           
            CompletaUltimosComprobantes();
        }
        #endregion

        #region Métodos
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CompletaUltimosComprobantes()
        {
            this.txtUltNumComp1.Text = glb_con_pedidoCliente.UltimoComprobante("1"); // FCA
            this.txtUltNumComp2.Text=glb_con_pedidoCliente.UltimoComprobante("6"); // FCB
            this.txtUltNumComp3.Text=glb_con_pedidoCliente.UltimoComprobante("3"); // NCA
            this.txtUltNumComp4.Text = glb_con_pedidoCliente.UltimoComprobante("8"); // NCB

        }
        #endregion
    }
}
