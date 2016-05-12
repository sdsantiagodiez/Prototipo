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
    public partial class frmReporteSeleccion : Form
    {
        private ControladorReportes glb_con_Reporte = new ControladorReportes();
        private FormReportes glb_frm_FormReportes;
        private ControladorBusqueda glb_con_busqueda = new ControladorBusqueda();

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
            this.cmbxVentasReportes.Items.Add("Listado Top 10 Articulos Vendidos");
        }

        private void btnGeneraReporteVentas_Click(object sender, EventArgs e)
        {
             DateTime lcl_var_DateFrom = DateTime.ParseExact(txtFecDesdeVentas.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
             DateTime lcl_var_DateTo = DateTime.ParseExact(txtFecHastaVentas.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            if (cmbxVentasReportes.Text == "Reporte de Ventas Entre Fechas")
            {
               
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

        #region EventosControles

        private void cmbxVentasReportes_Leave(object sender, EventArgs e)
        {
            if (cmbxVentasReportes.SelectedText == "Reporte de Ventas Entre Fechas")
            {
                this.txtFecDesdeVentas.Visible = true;
                this.txtFecHastaVentas.Visible = true;
                this.chkAllClientes.Visible = true;
                this.lblNombreCliente.Visible = true;
                this.txtCliente.Visible = true;
                this.btnGeneraReporteVentas.Visible = true;
                this.lblCliente.Visible = true;
            }
            else if (cmbxVentasReportes.SelectedText == "Listado Top 10 Articulos Vendidos")
            {
                this.txtFecDesdeVentas.Text = "";
                this.txtFecHastaVentas.Text = "";
                this.chkAllClientes.Visible = false;
                this.lblNombreCliente.Visible = false;
                this.txtCliente.Visible = false;
                this.btnGeneraReporteVentas.Visible = true; 
                this.lblCliente.Visible = false;
            }
            else
            {
                //this.btnGeneraReporteVentas.Visible = false;
            }

        }

        private void cmbxVentasReportes_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbxVentasReportes.SelectedText == "Reporte de Ventas Entre Fechas")
            {
                this.txtFecDesdeVentas.Visible = true;
                this.txtFecHastaVentas.Visible = true;
                this.chkAllClientes.Visible = true;
                this.lblNombreCliente.Visible = true;
                this.txtCliente.Visible = true;
                this.btnGeneraReporteVentas.Visible = true;
                this.lblCliente.Visible = true;
            }
            else if (cmbxVentasReportes.SelectedText == "Listado Top 10 Articulos Vendidos")
            {
                this.txtFecDesdeVentas.Text = "";
                this.txtFecHastaVentas.Text = "";
                this.chkAllClientes.Visible = false;
                this.lblNombreCliente.Visible = false;
                this.txtCliente.Visible = false;
                this.btnGeneraReporteVentas.Visible = true;
                this.lblCliente.Visible = false;
            }
            else
            {
                //this.btnGeneraReporteVentas.Visible = false;
            }

        }

        private void chkAllClientes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAllClientes.Checked == true)
            {
                txtCliente.Visible = false;
                lblCliente.Visible = false;
                lblNombreCliente.Visible = false;
            }
            else
            {
                txtCliente.Visible = true;
                lblCliente.Visible = true;
                lblNombreCliente.Visible = true;
            }
        }

        private void txtProveedor_Leave(object sender, EventArgs e)
        {
           
            List<ModeloProveedor> lst_mod_Proveedor = new List<ModeloProveedor>();
            ModeloEntidad lcl_modelo_entidad  = new ModeloEntidad();
            lcl_modelo_entidad.codigo= Convert.ToInt32(this.txtProveedor.Text);
            lst_mod_Proveedor = ControladorBusqueda.buscar(lcl_modelo_entidad as ModeloProveedor,Constantes.ParametrosBusqueda.One) ;
            lcl_modelo_entidad = lst_mod_Proveedor[0];
            this.lblNombreProveedor.Text = lcl_modelo_entidad.cuit;
        }

        private void txtCliente_Leave(object sender, EventArgs e)
        {
          
            List<ModeloCliente> lst_mod_cliente = new List<ModeloCliente>();
            ModeloEntidad lcl_modelo_entCliente = new ModeloEntidad();
            lcl_modelo_entCliente.codigo = Convert.ToInt32(this.txtCliente.Text);
            lst_mod_cliente = ControladorBusqueda.buscar(lcl_modelo_entCliente as ModeloCliente, Constantes.ParametrosBusqueda.One);
            lcl_modelo_entCliente = lst_mod_cliente[0];
            this.lblNombreProveedor.Text = lcl_modelo_entCliente.cuit;

        }
        #endregion
    }
    
    
    }

