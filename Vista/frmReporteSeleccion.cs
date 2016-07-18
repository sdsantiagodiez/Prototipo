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
using Reportes;
using System.Globalization;
using LibreriaClasesCompartidas;

namespace Vista
{
    public partial class frmReporteSeleccion : frmMaterialSkinBase
    {
        #region Atributos
        private ControladorReportes glb_con_Reporte = new ControladorReportes();
        private FormReportes glb_frm_FormReportes;
        private ControladorBusqueda glb_con_busqueda = new ControladorBusqueda();
        #endregion

        #region Constructores
        public frmReporteSeleccion()
        {
            InitializeComponent();
            // creo el reporte
            glb_con_Reporte = new ControladorReportes();
            // Completo los reportes dentro de los Combobox.
            CompletaNombreReportes();
        }
        #endregion

        #region Métodos
        public override void inicializarForm(int ventanaAncho, int ventanaAlto)
        {
            this.tblLayoutPanelPrincipal.Width = ventanaAncho - 20; //un margen derecho de 20 para que se vea scrollbar
            this.pnlBase.Width = ventanaAncho - 3;  //un márgen derecho de 3
            this.pnlBase.Height = ventanaAlto - 60; //un márgen arriba para que se vea título
            if (pnlBase.Height < 300)
            {
                this.tblLayoutPanelPrincipal.Height = 300;  //Mínimo

                this.pnlBase.AutoScroll = true;
                ScrollBar vScrollBar = new VScrollBar();
                vScrollBar.Dock = DockStyle.Right;
                vScrollBar.Scroll += (sender, e) => { pnlBase.VerticalScroll.Value = vScrollBar.Value; };
                pnlBase.Controls.Add(vScrollBar);
            }
            else
            {
                this.tblLayoutPanelPrincipal.Height = pnlBase.Height; ; // 60 pixeles para que se vea título de ventana principal
            }

            int x = Convert.ToInt16(Math.Round(Convert.ToDouble((Width - this.tblLayoutPanelPrincipal.Width) / 2)));
            this.tblLayoutPanelPrincipal.Location = new Point(10, 0);
            this.pnlBase.Location = new Point(0, 60);
        }
        private void CompletaNombreReportes()
        { 
            this.cmbxPedidosReportes.Items.Add("Reporte de Pedidos Entre Fechas");//Ver como agregamos los Reportes
            this.cmbxVentasReportes.Items.Add("Reporte de Ventas Entre Fechas");
            this.cmbxVentasReportes.Items.Add("Listado Top 10 Articulos Vendidos");
            this.cmbxInventarioReportes.Items.Add("Informe de Stock");
            this.cmbxInventarioReportes.Items.Add("Informe de Descuentos");
        }
        #endregion

        #region Eventos
        private void btnGeneraReporteVentas_Click(object sender, EventArgs e)
        {
             DateTime lcl_var_DateFrom = DateTime.ParseExact(txtFecDesdeVentas.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
             DateTime lcl_var_DateTo = DateTime.ParseExact(txtFecHastaVentas.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            if (cmbxVentasReportes.Text == "Reporte de Ventas Entre Fechas")
            {
               
                if (txtFecDesdeVentas.Text == "" || txtFecHastaVentas.Text == "" )
                {
                    MessageBox.Show("No puedes dejar el campo vacio", "Campos Vacios", MessageBoxButtons.OK);
                }
                else
                {
                   
                        glb_frm_FormReportes = glb_con_Reporte.ReporteVentaEntreFechas(lcl_var_DateFrom, lcl_var_DateTo, 0);
                                      }
            }
            else
            {
                glb_frm_FormReportes = glb_con_Reporte.ReporteTop10Articulos(lcl_var_DateFrom,lcl_var_DateTo);

            }
            glb_frm_FormReportes.ShowDialog();
        }

        private void btnGeneraReportePedido_Click(object sender, EventArgs e)
        {
            DateTime lcl_var_DateFrom = DateTime.ParseExact(txtPedidoFechaDesde.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime lcl_var_DateTo = DateTime.ParseExact(txtPedidoFechaHasta.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            if (txtPedidoFechaDesde.Text == "" || txtPedidoFechaHasta.Text == "" )
            {
                MessageBox.Show("No puedes dejar el campo vacio", "Campos Vacios", MessageBoxButtons.OK);
            }
            else
            {
                    
                    glb_frm_FormReportes = glb_con_Reporte.ReportePedidoEntreFechas(lcl_var_DateFrom, lcl_var_DateTo, 0);
                    glb_frm_FormReportes.ShowDialog();
            }
        }

        private void btnGeneraReporteInvenario_Click(object sender, EventArgs e)
        {
            if (cmbxInventarioReportes.Text == "Informe de Stock")
            {
                glb_frm_FormReportes = glb_con_Reporte.StockInventario();
                glb_frm_FormReportes.ShowDialog();
            }
            else if (cmbxInventarioReportes.Text == "Informe de Descuentos")
            {
                if (this.tbxFechaInventario.Text == "")
                {
                    MessageBox.Show("No puedes dejar el campo fecha vacio", "Campos Vacios", MessageBoxButtons.OK);
                }
                else
                {
                    glb_frm_FormReportes = glb_con_Reporte.DescuentosVigentes(DateTime.Parse(tbxFechaInventario.Text));
                    glb_frm_FormReportes.ShowDialog();
                }
            }
        }

        private void cmbxInventarioReportes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbxInventarioReportes.Text == "Informe de Stock")
            {
                this.tbxFechaInventario.Visible = this.lblFechaInventario.Visible = false;
            }
            else 
            {
                this.tbxFechaInventario.Visible = this.lblFechaInventario.Visible = true;
            }
        }

        #endregion
    }
    
    
}

