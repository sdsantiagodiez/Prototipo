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
    public partial class frmPreferenciasFacturacion : Form
    {
        ControladorPedidoCliente glb_con_pedidoCliente = new ControladorPedidoCliente();
        public frmPreferenciasFacturacion()
        {
            InitializeComponent();
            CompletaUltimosComprobantes();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void CompletaUltimosComprobantes()
        {
            this.txtComprobante1.Text = glb_con_pedidoCliente.UltimoComprobante("1"); // FCA
            this.txtComprobante2.Text=glb_con_pedidoCliente.UltimoComprobante("6"); // FCB
            this.txtComprobante3.Text=glb_con_pedidoCliente.UltimoComprobante("3"); // NCA
            this.txtComprobante4.Text = glb_con_pedidoCliente.UltimoComprobante("8"); // NCB

        }
    }
}
