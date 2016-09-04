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
        public event EventHandler MostrarComprobante;
        #endregion

        #region Constructores
        public frmReporteSeleccion()
        {
            InitializeComponent();
            this.inicializarControles();
        }
        #endregion

        #region Métodos
        #region Inicialización
        public override void inicializarForm(int ventanaAncho, int ventanaAlto)
        {
            this.tblLayoutPanelPrincipal.Width = ventanaAncho - 20; //un margen derecho de 20 para que se vea scrollbar
            this.pnlBase.Width = ventanaAncho ;  //un márgen derecho de 3
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

        private void inicializarControles()
        {
            this.inicializarRadioButtons();
            this.inicializarNumericUpDown();
            this.inicializarComboBox();
        }
        private void inicializarNumericUpDown()
        {
            this.nmrcUpDown_Clientes.ReadOnly = true;
            this.nmrcUpDown_Proveedores.ReadOnly = true;
            this.nmrcUpDown_Articulos.ReadOnly = true;
            this.nmrcUpDown_Clientes.Minimum = 1;
            this.nmrcUpDown_Proveedores.Minimum = 1;
            this.nmrcUpDown_Articulos.Minimum = 1;
        }
        private void inicializarRadioButtons()
        {
            this.rdButtonTopX_Clientes.Checked = true;
            this.rdButtonTopX_Proveedores.Checked = true;
            this.rdButtonTopX_Articulos.Checked = true;
        }
        private void inicializarComboBox()
        {
            #region cmbBoxReportesSeleccion_Clientes
            this.cmbBoxReportesSeleccion_Clientes.DataSource = Enum.GetValues(typeof(Constantes.Reportes.Clientes));

            this.cmbBoxReportesSeleccion_Clientes.FormattingEnabled = true;
            this.cmbBoxReportesSeleccion_Clientes.Format += delegate(object sender, ListControlConvertEventArgs e)
            {
                e.Value = Constantes.GetDescription<Constantes.Reportes.Clientes>((Constantes.Reportes.Clientes)e.Value);
            };

            this.cmbBoxReportesSeleccion_Clientes.DropDownStyle = ComboBoxStyle.DropDownList;
            #endregion

            #region cmbBoxReportesSeleccion_Proveedores
            this.cmbBoxReportesSeleccion_Proveedores.DataSource = Enum.GetValues(typeof(Constantes.Reportes.Proveedores));

            this.cmbBoxReportesSeleccion_Proveedores.FormattingEnabled = true;
            this.cmbBoxReportesSeleccion_Proveedores.Format += delegate(object sender, ListControlConvertEventArgs e)
            {
                e.Value = Constantes.GetDescription<Constantes.Reportes.Proveedores>((Constantes.Reportes.Proveedores)e.Value);
            };

            this.cmbBoxReportesSeleccion_Proveedores.DropDownStyle = ComboBoxStyle.DropDownList;
            #endregion

            #region cmbBoxReportesSeleccion_Clientes
            this.cmbBoxReportesSeleccion_Articulos.DataSource = Enum.GetValues(typeof(Constantes.Reportes.Articulos));

            this.cmbBoxReportesSeleccion_Articulos.FormattingEnabled = true;
            this.cmbBoxReportesSeleccion_Articulos.Format += delegate(object sender, ListControlConvertEventArgs e)
            {
                e.Value = Constantes.GetDescription<Constantes.Reportes.Articulos>((Constantes.Reportes.Articulos)e.Value);
            };

            this.cmbBoxReportesSeleccion_Articulos.DropDownStyle = ComboBoxStyle.DropDownList;
            #endregion

            #region cmbBoxProveedores
            this.inicializarCmbBoxProveedores();
            #endregion
        }

        private void inicializarCmbBoxProveedores()
        {
            List<ModeloProveedor> lcl_lst_mod_proveedores = ControladorBusqueda.getProveedores().OrderBy(x => x.razonSocial).ToList();
            var dataSource = new List<ComboBoxItem>();

            for (int i = 0; i < lcl_lst_mod_proveedores.Count; i++)
            {
                dataSource.Add(new ComboBoxItem()
                {
                    Name = lcl_lst_mod_proveedores[i].razonSocial,
                    Value = lcl_lst_mod_proveedores[i]
                });
            }
            this.cmbBoxProveedores.DataSource = dataSource;
            if (dataSource.Count < 1)
            {
                this.cmbBoxProveedores.Enabled = false;
                return;
            }

            InicializarCmbBox(this.cmbBoxProveedores);
            this.cmbBoxProveedores.Enabled = false;
        }
        #endregion

        #region Mostrar Reporte
        private void mostrarReporte(Constantes.Reportes.TipoReporte p_tipoReporte)
        {
            frmImpresionReporte lcl_frm_reporte = new frmImpresionReporte();
            this.mostrarReporte(lcl_frm_reporte, p_tipoReporte);
            this.MostrarComprobante(lcl_frm_reporte, new EventArgs());
        }
        private void mostrarReporte(frmImpresionReporte p_frm_reporte, Constantes.Reportes.TipoReporte p_tipoReporte)
        {
            List <DateTime> periodo = this.getPeriodo(p_tipoReporte);

            switch (p_tipoReporte)
            {
                case Constantes.Reportes.TipoReporte.Clientes:
                    p_frm_reporte.mostrar(this.getReporteSeleccionado_Clientes(), periodo, this.getClienteSeleccionado(),this.getCantidadSeleccionado(p_tipoReporte));
                    break;
                case Constantes.Reportes.TipoReporte.Proveedores:
                    p_frm_reporte.mostrar(this.getReporteSeleccionado_Proveedores(), periodo, this.getProveedorSeleccionado(), this.getCantidadSeleccionado(p_tipoReporte));
                    break;
                case Constantes.Reportes.TipoReporte.Articulos:
                    p_frm_reporte.mostrar(this.getReporteSeleccionado_Articulos(), periodo, this.getCantidadSeleccionado(p_tipoReporte));
                    break;
            }            
        }
        #endregion

        #region Controles -> Modelos
        private Constantes.Reportes.Clientes getReporteSeleccionado_Clientes()
        {
            return (Constantes.Reportes.Clientes)this.cmbBoxReportesSeleccion_Clientes.SelectedValue;
        }
        private Constantes.Reportes.Proveedores getReporteSeleccionado_Proveedores()
        {
            return (Constantes.Reportes.Proveedores)this.cmbBoxReportesSeleccion_Proveedores.SelectedValue;
        }
        private Constantes.Reportes.Articulos getReporteSeleccionado_Articulos()
        {
            return (Constantes.Reportes.Articulos)this.cmbBoxReportesSeleccion_Articulos.SelectedValue;
        }

        private ModeloCliente getClienteSeleccionado()
        {
            if (esParticular(Constantes.Reportes.TipoReporte.Clientes))
            {
                return new ModeloCliente();
            }

            return new ModeloCliente();//cargar modelo
        }
        private ModeloProveedor getProveedorSeleccionado()
        {
            if (this.esParticular(Constantes.Reportes.TipoReporte.Proveedores))
            {
                return (ModeloProveedor)this.cmbBoxProveedores.SelectedValue;
            }

            return new ModeloProveedor();
        }
        private int getCantidadSeleccionado(Constantes.Reportes.TipoReporte p_tipoReporte)
        {
            switch (p_tipoReporte)
            {
                case Constantes.Reportes.TipoReporte.Clientes:
                    return Convert.ToInt32(this.nmrcUpDown_Clientes.Value);
                case Constantes.Reportes.TipoReporte.Proveedores:
                    if (!this.rdButtonTodos_Proveedores.Checked)
                    {
                        return Convert.ToInt32(this.nmrcUpDown_Proveedores.Value);    
                    }
                    break;
                case Constantes.Reportes.TipoReporte.Articulos:
                    if (!this.rdButtonTodos_Artículos.Checked)
                    {
                        return Convert.ToInt32(this.nmrcUpDown_Articulos.Value);
                    }
                    break;
                default:
                    return 0;
            }
            return 0;
        }
        private bool esParticular(Constantes.Reportes.TipoReporte p_tipoReporte)
        {
            switch (p_tipoReporte)
            {
                case Constantes.Reportes.TipoReporte.Proveedores:
                    return this.rdButtonParticular_Proveedores.Checked;
                case Constantes.Reportes.TipoReporte.Clientes:
                    
                case Constantes.Reportes.TipoReporte.Articulos:
                    
                default:
                    return false;
            }
        }

        private List<DateTime> getPeriodo(Constantes.Reportes.TipoReporte p_tipoReporte)
        {
            List<DateTime> periodos = new List<DateTime>();

            switch (p_tipoReporte)
            {
                case Constantes.Reportes.TipoReporte.Clientes:
                    periodos.Add(this.dtpFechaDesde_Clientes.Value);
                    periodos.Add(this.dtpFechaHasta_Clientes.Value);
                    break;
                case Constantes.Reportes.TipoReporte.Proveedores:
                    periodos.Add(this.dtpFechaDesde_Proveedores.Value);
                    periodos.Add(this.dtpFechaHasta_Proveedores.Value);
                    break;
                case Constantes.Reportes.TipoReporte.Articulos:
                    periodos.Add(this.dtpFechaDesde_Articulos.Value);
                    periodos.Add(this.dtpFechaHasta_Articulos.Value);
                    break;
            }

            return periodos;
        }
        #endregion
        #endregion


        #region Eventos
        private void btnGenerarReporte_Clientes_Click(object sender, EventArgs e)
        {
            this.mostrarReporte(Constantes.Reportes.TipoReporte.Clientes);
        }
        private void btnGenerarReporte_Proveedores_Click(object sender, EventArgs e)
        {
            this.mostrarReporte(Constantes.Reportes.TipoReporte.Proveedores);
        }
        private void btnGenerarReporte_Articulos_Click(object sender, EventArgs e)
        {
            this.mostrarReporte(Constantes.Reportes.TipoReporte.Articulos);
        }
        
        private void dtpFechaDesde_Clientes_ValueChanged(object sender, EventArgs e)
        {
            this.dtpFechaHasta_Clientes.MinDate = this.dtpFechaDesde_Clientes.Value;
        }
        private void dtpFechaDesde_Proveedores_ValueChanged(object sender, EventArgs e)
        {
            this.dtpFechaHasta_Proveedores.MinDate = this.dtpFechaDesde_Proveedores.Value;
        }
        private void dtpFechaDesde_Articulos_ValueChanged(object sender, EventArgs e)
        {
            this.dtpFechaHasta_Articulos.MinDate = this.dtpFechaDesde_Articulos.Value;
        }
        #endregion

        private void cmbBoxReportesSeleccion_Articulos_SelectedValueChanged(object sender, EventArgs e)
        {
            if (((Constantes.Reportes.Articulos)this.cmbBoxReportesSeleccion_Articulos.SelectedValue) != Constantes.Reportes.Articulos.ArticulosMasVendidos)
            {
                this.grpBoxPeriodos_Articulos.Enabled =
                    this.grpBoxSeleccion_Articulos.Enabled = false;
            }
            else
            {
                this.grpBoxPeriodos_Articulos.Enabled =
                    this.grpBoxSeleccion_Articulos.Enabled = true;
            }
        }

        private void rdButtonParticular_Proveedores_CheckedChanged(object sender, EventArgs e)
        {
            this.cmbBoxProveedores.Enabled = this.rdButtonParticular_Proveedores.Checked;
        }

        private void rdButtonTopX_Proveedores_CheckedChanged(object sender, EventArgs e)
        {
            this.nmrcUpDown_Proveedores.Enabled = this.rdButtonTopX_Proveedores.Checked;
        }

        private void rdButtonTopX_Articulos_CheckedChanged(object sender, EventArgs e)
        {
            this.nmrcUpDown_Articulos.Enabled = this.rdButtonTopX_Articulos.Checked;
        }

        private void rdButtonTopX_Clientes_CheckedChanged(object sender, EventArgs e)
        {
            this.nmrcUpDown_Clientes.Enabled = this.rdButtonTopX_Clientes.Checked;
        }
    }
    
    
}

