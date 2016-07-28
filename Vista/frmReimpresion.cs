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
using Modelos;
using LibreriaClasesCompartidas;

namespace Vista
{
    public partial class frmReimpresion : frmMaterialSkinBase
    {
        ControladorPedidoCliente glb_con_pedidoCliente = new ControladorPedidoCliente();
        public ControladorBusqueda glb_con_busqueda = new ControladorBusqueda();
        public ControladorBusqueda controlador = new ControladorBusqueda();
        public List<ModeloPedido> glb_lst_mod_pedido = new List<ModeloPedido>();
        public ModeloPedido glb_mod_pedido = new ModeloPedido();
        public List<ModeloCliente> glb_lst_mod_cliente = new List<ModeloCliente>();
        public ModeloCliente glb_mod_cliente = new ModeloCliente();
        #region inicializadores
        public frmReimpresion()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            //inicializaClientes();
            }
        public void inicializaPedidos()
        {
            glb_lst_mod_pedido=ControladorBusqueda.buscar(glb_mod_pedido);
        }

        public void inicializaClientes()
        {
            glb_lst_mod_cliente = ControladorBusqueda.buscar(glb_mod_cliente,Constantes.ParametrosBusqueda.All);
        }

        #endregion   
        #region Metodos
        private void buscaComprobantes()
        {
           // if (glb_lst_mod_pedido.Count == 0)
            //{ inicializaPedidos(); }
            frmResultadoBusqueda lcl_frm_resultadoBusqueda = new frmResultadoBusqueda();
            glb_mod_pedido.tipoComprobante = 1;
            lcl_frm_resultadoBusqueda.mostrarBusqueda(glb_mod_pedido);
            if (lcl_frm_resultadoBusqueda.modeloSeleccionado != null)
            {
                glb_mod_pedido = new ModeloPedido();
                glb_mod_pedido = lcl_frm_resultadoBusqueda.modeloSeleccionado as ModeloPedido;
            }
        }
        private void buscaCliente()
        {
            if (glb_lst_mod_cliente.Count == 0)
            { inicializaClientes(); }
            frmResultadoBusqueda lcl_frm_resultadoBusqueda = new frmResultadoBusqueda();
            lcl_frm_resultadoBusqueda.mostrarBusqueda(glb_lst_mod_cliente);
            if (lcl_frm_resultadoBusqueda.modeloSeleccionado != null)
            {
                glb_mod_cliente = new ModeloCliente();
                glb_mod_cliente = lcl_frm_resultadoBusqueda.modeloSeleccionado as ModeloCliente;
            }
        }
        public void buscarCliente()
        {
            this.buscaCliente();
            this.txtBoxCliente.Text = glb_mod_cliente.codigo.ToString();
        }
        public void buscarComprobantesDesde()
        {
            this.buscaComprobantes();
            txtBoxComprobanteDesde.Text = glb_mod_pedido.numeroPedido.ToString();
        }
        public void buscarComprobantesHasta()
        {
            this.buscaComprobantes();
            txtBoxComprobanteHasta.Text = glb_mod_pedido.numeroPedido.ToString();
        }
        public void comprobantesAReimprimir()
        {
            if (glb_lst_mod_pedido.Count == 0)
            { glb_lst_mod_pedido = glb_con_pedidoCliente.getPedidosDesdeHasta(Convert.ToInt32(this.txtBoxComprobanteDesde.Text),Convert.ToInt32(this.txtBoxComprobanteHasta.Text)); }
            }

        public bool imprimir()
        {
            this.comprobantesAReimprimir();

            (new Reportes.frmImpresionLoteFacturas(glb_lst_mod_pedido)).ShowDialog();

            return true;
        }
        #endregion

        #region Eventos
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnBuscaComprobanteDesde_Click(object sender, EventArgs e)
        {

            this.buscarComprobantesDesde();
            
        }
        private void btnBuscaComprobanteHasta_Click(object sender, EventArgs e)
        {
            this.buscarComprobantesHasta();
        }
        private void btnBuscaCliente_Click(object sender, EventArgs e)
        {
            this.buscarCliente();
        }
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            this.imprimir();
        }

        #endregion


    }
}
