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
using Modelos;

namespace Vista
{
    public partial class frmReporteSeleccion : Form
    {
        private ControladorReportes glb_con_Reporte;
        private ModeloReportePedidoEntreFechas glb_mod_PedidoEntreFechas;
        private ModeloReporteVentaEntreFechas glb_mod_VentaEntreFechas;
        private List<ModeloReportePedidoEntreFechas> glb_lst_mod_PedidoEntreFechas;
        private List<ModeloReporteVentaEntreFechas> glb_lst_mod_VentaEntreFechas;

        public frmReporteSeleccion()
        {
            InitializeComponent();
            // creo el reporte
            glb_con_Reporte = new ControladorReportes();
            // Completo los reportes dentro de los Combobox.
            CompletaNombreReportes();

        }

        private void CompletaNombreReportes()
        { 
            this.cmbxPedidosReportes.Items.Add("Reporte de Pedidos Entre Fechas");//Ver como agregamos los Reportes
            this.cmbxVentasReportes.Items.Add("Reporte de Ventas Entre Fechas");
        }
    
    
    }
}
