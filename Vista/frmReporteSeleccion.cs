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

namespace Vista
{
    public partial class frmReporteSeleccion : Form
    {
        private ControladorReportes glb_con_Reporte = new ControladorReportes();
        private FormReportes glb_frm_FormReportes;

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

        private void btnGeneraReporteVentas_Click(object sender, EventArgs e)
        {
            if (txtFecDesdeVentas.Text == "" || txtFecHastaVentas.Text == "" || (txtCliente.Text == "" && chkAllClientes.Checked == false))
            {
                MessageBox.Show("No puedes dejar el campo vacio", "Campos Vacios", MessageBoxButtons.OK);
            }
            else
            {
                if (chkAllClientes.Checked == true)
                {
                    glb_frm_FormReportes = glb_con_Reporte.ReporteVentaEntreFechas(Convert.ToDateTime(txtFecDesdeVentas.Text), Convert.ToDateTime(txtFecHastaVentas.Text), 0);
                }
                else
                {
                    glb_frm_FormReportes = glb_con_Reporte.ReporteVentaEntreFechas(Convert.ToDateTime(txtFecDesdeVentas.Text), Convert.ToDateTime(txtFecHastaVentas.Text), Convert.ToInt32(txtCliente.Text));
                }

                glb_frm_FormReportes.ShowDialog();
            }
        }

        private void btnGeneraReportePedido_Click(object sender, EventArgs e)
        {
            if (txtPedidoFechaDesde.Text == "" || txtPedidoFechaHasta.Text == "" || (txtProveedor.Text == "" && chkboxAllProv.Checked==false))
            {
                MessageBox.Show("No puedes dejar el campo vacio", "Campos Vacios", MessageBoxButtons.OK);
            }
            else
            {
                if (chkboxAllProv.Checked == true)
                {
                    glb_frm_FormReportes = glb_con_Reporte.ReportePedidoEntreFechas(Convert.ToDateTime(txtPedidoFechaDesde.Text), Convert.ToDateTime(txtPedidoFechaHasta.Text), 0);
                }
                else
                {
                    glb_frm_FormReportes = glb_con_Reporte.ReportePedidoEntreFechas(Convert.ToDateTime(txtPedidoFechaDesde.Text), Convert.ToDateTime(txtPedidoFechaHasta.Text), Convert.ToInt32(txtProveedor.Text));
                }

                glb_frm_FormReportes.ShowDialog();
            }
        }
    
    
    }
}
