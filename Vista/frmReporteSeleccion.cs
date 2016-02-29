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
            DateTime lcl_var_DateFrom = DateTime.ParseExact(txtFecDesdeVentas.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime lcl_var_DateTo = DateTime.ParseExact(txtFecHastaVentas.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            if (txtFecDesdeVentas.Text == "" || txtFecHastaVentas.Text == "" || (txtCliente.Text == "" && chkAllClientes.Checked == false))
            {
                MessageBox.Show("No puedes dejar el campo vacio", "Campos Vacios", MessageBoxButtons.OK);
            }
            else
            {
                if (chkAllClientes.Checked == true)
                {
                    //glb_frm_FormReportes = glb_con_Reporte.ReporteVentaEntreFechas(Convert.ToDateTime(txtFecDesdeVentas.Text), Convert.ToDateTime(txtFecHastaVentas.Text), 0);
                    glb_frm_FormReportes = glb_con_Reporte.ReporteVentaEntreFechas(lcl_var_DateFrom, lcl_var_DateTo, 0);
                }
                else
                {
                    glb_frm_FormReportes = glb_con_Reporte.ReporteVentaEntreFechas(lcl_var_DateFrom, lcl_var_DateTo, Convert.ToInt32(txtCliente.Text));
                }

                glb_frm_FormReportes.ShowDialog();
            }
        }

        private void btnGeneraReportePedido_Click(object sender, EventArgs e)
        {
            DateTime lcl_var_DateFrom = DateTime.ParseExact(txtPedidoFechaDesde.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            DateTime lcl_var_DateTo = DateTime.ParseExact(txtPedidoFechaDesde.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            if (txtPedidoFechaDesde.Text == "" || txtPedidoFechaHasta.Text == "" || (txtProveedor.Text == "" && chkboxAllProv.Checked==false))
            {
                MessageBox.Show("No puedes dejar el campo vacio", "Campos Vacios", MessageBoxButtons.OK);
            }
            else
            {
                if (chkboxAllProv.Checked == true)
                {
                    
                    glb_frm_FormReportes = glb_con_Reporte.ReportePedidoEntreFechas(lcl_var_DateFrom, lcl_var_DateTo, 0);
                }
                else
                {
                    glb_frm_FormReportes = glb_con_Reporte.ReportePedidoEntreFechas(lcl_var_DateFrom, lcl_var_DateTo, Convert.ToInt32(txtProveedor.Text));
                }

                glb_frm_FormReportes.ShowDialog();
            }
        }
    
    
    }
}
