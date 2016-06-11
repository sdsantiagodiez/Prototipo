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
using MaterialSkin;
using MaterialSkin.Animations;
using MaterialSkin.Controls;

namespace Vista
{
    public partial class frmPreferenciasFacturacion : MaterialForm
    {
        ControladorPedidoCliente glb_con_pedidoCliente = new ControladorPedidoCliente();
        public frmPreferenciasFacturacion()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            CompletaUltimosComprobantes();
        }

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
    }
}
