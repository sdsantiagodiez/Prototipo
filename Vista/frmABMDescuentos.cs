﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos;
using Controladores;
using LibreriaClasesCompartidas;

namespace Vista
{
    public partial class frmABMDescuentos : frmMaterialSkinBase
    {//ver comentarios
        /*
         *Ver "//FALTA" 
         *Agregar errorProvider a porcentaje personalizado
         *Convertir punto en coma en porcentaje personalizado. para permitir por ejemplo 12.5 y que lo interprete como 12,5 para convertir a decimal
         *IMPLEMENTAR en la búsqueda eso de tener o no descuento vigente
         */
        #region Atributos
        public EventHandler abrirDescuentosArticuloProveedor;
        List<ModeloDescuento> glb_lst_DescuentosBase;
        DataGridView dgvResultadoBusqueda;
        List<ModeloArticuloProveedores> glb_lst_articulosProveedoresEncontrados;
        /// <summary>
        /// Se inicializa cuando se ven detalles de un artículo particular
        /// </summary>
        ModeloArticuloProveedores glb_mod_articuloProveedorSeleccionado;
        MaterialSkin.Controls.MaterialContextMenuStrip cntxMenuResultadoBusqueda;
        #endregion

        #region Constructores
        public frmABMDescuentos()
        {
            InitializeComponent();
            this.inicializarControles();
            this.glb_lst_articulosProveedoresEncontrados = new List<ModeloArticuloProveedores>();
            
            this.glb_mod_articuloProveedorSeleccionado = null;
        }

        public frmABMDescuentos(ModeloArticuloProveedores p_mod_articuloProveedor) : this()
        {
            if(p_mod_articuloProveedor == null)
            {
                MessageBox.Show("Error: No hay artículo seleccionado");
                this.Close();
            }
            this.glb_mod_articuloProveedorSeleccionado = p_mod_articuloProveedor;
            this.inicializarControlesArticuloProveedorSeleccionado();
            this.cargarArticuloProveedorEnControles(p_mod_articuloProveedor);
        }
        #endregion

        #region Métodos

        #region Inicialización
        public override void inicializarForm(int ventanaAncho, int ventanaAlto)
        {
            //copiado de frmABMEntidad
            this.tblLayoutPanelPrincipal.Width = ventanaAncho - 20; //un margen derecho de 20 para que se vea scrollbar
            this.pnlBase.Width = ventanaAncho ;  //un márgen derecho de 3
            this.pnlBase.Height = ventanaAlto - 60; //un márgen arriba para que se vea título
            if (pnlBase.Height < 700)
            {
                this.tblLayoutPanelPrincipal.Height = 700;  //Mínimo

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

        private void inicializarControlesArticuloProveedorSeleccionado()
        {
            this.Text = "Gestión de Descuentos de Artículo Seleccionado";
            this.chckBoxDescuentosActivos.Visible = false;

            this.inicializarBotonesArticuloProveedorSeleccionado();
            this.inicializarTextBoxArticuloProveedorSeleccionado();
            this.inicializarDataGridViewDescuentosArticuloProveedorSeleccionado();
            this.inicializarContextMenuArticuloProveedorSeleccionado();
        }
        private void inicializarBotonesArticuloProveedorSeleccionado()
        {
            this.btnBuscar.Text = "Volver";
            this.btnBuscar.Click += (s, e) => { this.Close(); };
            this.btnGuardarDescuento.Click += (s, e) => { this.actualizarDGVdescuentos(); };
        }
        private void inicializarTextBoxArticuloProveedorSeleccionado()
        {
            txtBoxCodigoOriginal.Enabled =
                txtBoxCodigoArticuloProveedor.Enabled =
                txtBoxDescripcion.Enabled =
                txtBoxModelo.Enabled =
                cmbBoxProveedores.Enabled = false;
        }
        private void inicializarDataGridViewDescuentosArticuloProveedorSeleccionado()
        {
            this.grpBoxResultadoBusqueda.Controls.Clear();
            this.dgvResultadoBusqueda = new DataGridView();
            this.grpBoxResultadoBusqueda.Controls.Add(this.dgvResultadoBusqueda);
            this.dgvResultadoBusqueda.MouseDown += this.dgvResultadoBusqueda_MouseDown;

            this.dgvResultadoBusqueda.Dock = DockStyle.Fill;
            this.dgvResultadoBusqueda.AutoGenerateColumns = false;
            this.dgvResultadoBusqueda.ReadOnly = true;
            this.dgvResultadoBusqueda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultadoBusqueda.RowHeadersVisible = false;
            this.dgvResultadoBusqueda.AllowUserToAddRows = false;
            this.dgvResultadoBusqueda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.dgvResultadoBusqueda.Columns.Add("dgvKey", "KEY");
            this.dgvResultadoBusqueda.Columns[0].FillWeight = 1;
            this.dgvResultadoBusqueda.Columns[0].Visible = false;
            int i = 0;

            this.dgvResultadoBusqueda.Columns.Add("codigoDescuento", "Código");
            this.dgvResultadoBusqueda.Columns[i++].FillWeight = 1;
            this.dgvResultadoBusqueda.Columns.Add("descripcionDescuento", "Descripción");
            this.dgvResultadoBusqueda.Columns[i++].FillWeight = 1;
            this.dgvResultadoBusqueda.Columns.Add("porcentajeDescuento", "Porcentaje");
            this.dgvResultadoBusqueda.Columns[i++].FillWeight = 1;
            this.dgvResultadoBusqueda.Columns.Add("fechaVigenciaDesdeDescuento", "Vigencia Desde");
            this.dgvResultadoBusqueda.Columns[i++].FillWeight = 1;
            this.dgvResultadoBusqueda.Columns[i ].DefaultCellStyle.Format = "dd/MM/yyyy";
            this.dgvResultadoBusqueda.Columns.Add("fechaVigenciaHastaDescuento", "Vigencia Hasta");
            this.dgvResultadoBusqueda.Columns[i++].FillWeight = 1;
            this.dgvResultadoBusqueda.Columns[i ].DefaultCellStyle.Format = "dd/MM/yyyy";
            this.dgvResultadoBusqueda.Columns.Add("vigenteDescuento", "Vigente");
            this.dgvResultadoBusqueda.Columns[i++].FillWeight = 1;
        }
        private void inicializarContextMenuArticuloProveedorSeleccionado()
        {
            this.cntxMenuResultadoBusqueda = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.cntxMenuResultadoBusqueda.Items.Add("Eliminar Descuento");
            this.cntxMenuResultadoBusqueda.Items[0].Click += (s, e) =>
            {
                this.eliminarDescuento();
            };
        }

        private void inicializarControles()
        {
            this.Text = "Gestión de Descuentos de Artículos";
            this.inicializarBotones();
            this.inicializarCmbBoxProveedores();
            this.inicializarCmbBoxPorcentajeDescuento();
            this.inicializarDataGridView();
            this.inicializarDateTimePickers();
            this.inicializarPorcentajePersonalizado(false);
            this.inicializarContextMenu();
        }
        private void inicializarBotones()
        {
            this.btnBuscar.Click += (s, e) => { this.buscar(); };
        }
        private void inicializarCmbBoxProveedores()
        {
            List<ModeloProveedor> lcl_lst_mod_proveedores = ControladorBusqueda.getProveedores().OrderBy(x => x.razonSocial).ToList();
            var dataSource = new List<ComboBoxItem>();

            dataSource.Add(new ComboBoxItem()
            {
                Name = "Todos",
                Value = null
            });

            for (int i = 0; i < lcl_lst_mod_proveedores.Count; i++)
            {
                dataSource.Add(new ComboBoxItem()
                {
                    Name = lcl_lst_mod_proveedores[i].razonSocial,
                    Value = lcl_lst_mod_proveedores[i]
                });
            }
            this.cmbBoxProveedores.DataSource = dataSource;
            if (dataSource.Count < 2)
            {//"Todos" null cuenta como 1
                this.cmbBoxProveedores.Enabled = false;
                return;
            }

            base.inicializarCmbBox(this.cmbBoxProveedores);
        }
        private void inicializarCmbBoxPorcentajeDescuento()
        {
            this.glb_lst_DescuentosBase = ControladorBusqueda.getDescuentosBase();

            var dataSource = new List<ComboBoxItem>();
            foreach (ModeloDescuento d in glb_lst_DescuentosBase)
            {
                dataSource.Add(new ComboBoxItem()
                {
                    Name = d.descripcion,
                    Value = d
                });
            }
            dataSource.Add(new ComboBoxItem()
            {
                Name = "Personalizado",
                Value = null
            });
            this.cmbBoxPorcentajeDescuento.DataSource = dataSource;

            base.inicializarCmbBox(this.cmbBoxPorcentajeDescuento);
        }
        private void inicializarDataGridView()
        {
            this.dgvResultadoBusqueda = new DataGridView();
            this.grpBoxResultadoBusqueda.Controls.Clear();
            this.dgvResultadoBusqueda.Dock = DockStyle.Fill;
            this.grpBoxResultadoBusqueda.Controls.Add(this.dgvResultadoBusqueda);
        }
        private void inicializarDateTimePickers()
        {
            this.dtpFechaDesdeDescuento.MinDate = this.dtpFechaHastaDescuento.MinDate = DateTime.Now.Date;
        }
        private void inicializarPorcentajePersonalizado(bool p_inicializar)
        {
            this.txtBoxPorcentajeDescuento.Enabled = p_inicializar;
            this.txtBoxDescripcionDescuento.Enabled = p_inicializar;

            if (!p_inicializar)
            {
                this.txtBoxDescripcionDescuento.Text = (this.cmbBoxPorcentajeDescuento.SelectedValue as ModeloDescuento).descripcion;
            }
            else
            {
                this.txtBoxDescripcionDescuento.Text = "";
            }
        }
        private void inicializarContextMenu()
        {
            this.cntxMenuResultadoBusqueda = new MaterialSkin.Controls.MaterialContextMenuStrip();
            this.cntxMenuResultadoBusqueda.Items.Add("Ver Descuentos Actuales");
            this.cntxMenuResultadoBusqueda.Items[0].Click += (s, e) =>
                {
                    this.abrirDescuentosAP();
                };
            
            #region Submenú de Descuentos Básicos
            List<ModeloDescuentoArticuloProveedor> lcl_lst_mod_descuentosAP = new List<ModeloDescuentoArticuloProveedor>();
            ModeloDescuentoArticuloProveedor lcl_mod_descuentoAP;
            foreach (ModeloDescuento d in glb_lst_DescuentosBase)
            {
                lcl_mod_descuentoAP = new ModeloDescuentoArticuloProveedor(d);
                lcl_mod_descuentoAP.fechaVigenciaDesde = lcl_mod_descuentoAP.fechaVigenciaHasta = DateTime.Today.Date;
                lcl_lst_mod_descuentosAP.Add(lcl_mod_descuentoAP);
            }

            cntxMenuResultadoBusqueda.Items.Add("Agregar Para el Día de Hoy Descuento de...");
            (this.cntxMenuResultadoBusqueda.Items[1] as ToolStripMenuItem).DropDownItems.Add(glb_lst_DescuentosBase[0].descripcion);
            (this.cntxMenuResultadoBusqueda.Items[1] as ToolStripMenuItem).DropDownItems[0].Click += (s, e) =>
            {
                this.guardarDescuento(lcl_lst_mod_descuentosAP[0]);
            };

            (this.cntxMenuResultadoBusqueda.Items[1] as ToolStripMenuItem).DropDownItems.Add(glb_lst_DescuentosBase[1].descripcion);
            (this.cntxMenuResultadoBusqueda.Items[1] as ToolStripMenuItem).DropDownItems[1].Click += (s, e) =>
            {

                this.guardarDescuento(lcl_lst_mod_descuentosAP[1]);
            };

            (this.cntxMenuResultadoBusqueda.Items[1] as ToolStripMenuItem).DropDownItems.Add(glb_lst_DescuentosBase[2].descripcion);
            (this.cntxMenuResultadoBusqueda.Items[1] as ToolStripMenuItem).DropDownItems[2].Click += (s, e) =>
            {

                this.guardarDescuento(lcl_lst_mod_descuentosAP[2]);
            };

            (this.cntxMenuResultadoBusqueda.Items[1] as ToolStripMenuItem).DropDownItems.Add(glb_lst_DescuentosBase[3].descripcion);
            (this.cntxMenuResultadoBusqueda.Items[1] as ToolStripMenuItem).DropDownItems[3].Click += (s, e) =>
            {

                this.guardarDescuento(lcl_lst_mod_descuentosAP[3]);
            };

            (this.cntxMenuResultadoBusqueda.Items[1] as ToolStripMenuItem).DropDownItems.Add(glb_lst_DescuentosBase[4].descripcion);
            (this.cntxMenuResultadoBusqueda.Items[1] as ToolStripMenuItem).DropDownItems[4].Click += (s, e) =>
            {

                this.guardarDescuento(lcl_lst_mod_descuentosAP[4]);
            };

            (this.cntxMenuResultadoBusqueda.Items[1] as ToolStripMenuItem).DropDownItems.Add(glb_lst_DescuentosBase[5].descripcion);
            (this.cntxMenuResultadoBusqueda.Items[1] as ToolStripMenuItem).DropDownItems[5].Click += (s, e) =>
            {

                this.guardarDescuento(lcl_lst_mod_descuentosAP[5]);
            };

            (this.cntxMenuResultadoBusqueda.Items[1] as ToolStripMenuItem).DropDownItems.Add(glb_lst_DescuentosBase[6].descripcion);
            (this.cntxMenuResultadoBusqueda.Items[1] as ToolStripMenuItem).DropDownItems[6].Click += (s, e) =>
            {

                this.guardarDescuento(lcl_lst_mod_descuentosAP[6]);
            };

            (this.cntxMenuResultadoBusqueda.Items[1] as ToolStripMenuItem).DropDownItems.Add(glb_lst_DescuentosBase[7].descripcion);
            (this.cntxMenuResultadoBusqueda.Items[1] as ToolStripMenuItem).DropDownItems[7].Click += (s, e) =>
            {

                this.guardarDescuento(lcl_lst_mod_descuentosAP[7]);
            };

            (this.cntxMenuResultadoBusqueda.Items[1] as ToolStripMenuItem).DropDownItems.Add(glb_lst_DescuentosBase[8].descripcion);
            (this.cntxMenuResultadoBusqueda.Items[1] as ToolStripMenuItem).DropDownItems[8].Click += (s, e) =>
            {

                this.guardarDescuento(lcl_lst_mod_descuentosAP[8]);
            };

            (this.cntxMenuResultadoBusqueda.Items[1] as ToolStripMenuItem).DropDownItems.Add(glb_lst_DescuentosBase[9].descripcion);
            (this.cntxMenuResultadoBusqueda.Items[1] as ToolStripMenuItem).DropDownItems[9].Click += (s, e) =>
            {

                this.guardarDescuento(lcl_lst_mod_descuentosAP[9]);
            };

            (this.cntxMenuResultadoBusqueda.Items[1] as ToolStripMenuItem).DropDownItems.Add(glb_lst_DescuentosBase[10].descripcion);
            (this.cntxMenuResultadoBusqueda.Items[1] as ToolStripMenuItem).DropDownItems[10].Click += (s, e) =>
            {

                this.guardarDescuento(lcl_lst_mod_descuentosAP[10]);
            };
            (this.cntxMenuResultadoBusqueda.Items[1] as ToolStripMenuItem).DropDownItems.Add(glb_lst_DescuentosBase[11].descripcion);
            (this.cntxMenuResultadoBusqueda.Items[1] as ToolStripMenuItem).DropDownItems[11].Click += (s, e) =>
            {

                this.guardarDescuento(lcl_lst_mod_descuentosAP[11]);
            };
            #endregion
        }
        #endregion

        #region Validación
        private bool validarParametrosBusqueda()
        {
            //No hay parametros a validar
            return true;
        }

        private bool validarDescuento()
        {
            return this.validarFechasDescuento() && this.validarPorcentajeDescuento();
            
        }
        private bool validarFechasDescuento()
        {
            DateTime lcl_dt_desde = this.dtpFechaDesdeDescuento.Value.Date;
            DateTime lcl_dt_hasta = this.dtpFechaHastaDescuento.Value.Date;
            return lcl_dt_desde >= lcl_dt_hasta;
        }
        private bool validarPorcentajeDescuento()
        {
            ModeloDescuento lcl_mod_descuentoTEMP = new ModeloDescuento();
            if (this.txtBoxPorcentajeDescuento.Enabled)
            {
                if (!lcl_mod_descuentoTEMP.asignarPorcentaje(this.txtBoxPorcentajeDescuento.Text))
                {
                    MessageBox.Show("Porcentaje personalizado no válido");  //Que sea errorProvider
                    return false;
                }
            }
            return true;
        }

        private bool validarAgregarDescuento(List<ModeloArticuloProveedores> p_lst_mod_articuloProveedor, ModeloDescuentoArticuloProveedor p_mod_descuento)
        {
            if (p_lst_mod_articuloProveedor == null)
            {
                MessageBox.Show("No hay artículos seleccionados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (p_mod_descuento == null)
            {
                return false;
            }
            
            bool valido = true;
            string mensajeError = "";
            string errorArticulo;
            foreach (ModeloArticuloProveedores ap in p_lst_mod_articuloProveedor)
            {
                if (!ap.validarAgregarDescuento(p_mod_descuento, out errorArticulo))
                {
                    mensajeError += errorArticulo + System.Environment.NewLine;
                    valido = false;
                }
            }
            if (!valido)
            {
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK);
            }
            return valido;
        }
        #endregion

        #region Controles -> Modelo
        private ModeloArticuloProveedores cargarControlesEnArticuloProveedor()
        {
            if (!this.validarParametrosBusqueda())
            {
                return null;
            }
            ModeloArticuloProveedores lcl_mod_articuloProveedor = new ModeloArticuloProveedores();

            lcl_mod_articuloProveedor.codigoOriginal = this.txtBoxCodigoOriginal.Text;
            lcl_mod_articuloProveedor.codigoArticuloProveedor = this.txtBoxCodigoArticuloProveedor.Text;
            lcl_mod_articuloProveedor.descripcion = this.txtBoxDescripcion.Text;
            lcl_mod_articuloProveedor.descripcionArticuloProveedor = this.txtBoxModelo.Text;
            //FALTA chckboxTieneDescuento

            return lcl_mod_articuloProveedor;

        }
        private ModeloDescuentoArticuloProveedor cargarControlesEnDescuento()
        {
            if (!this.validarDescuento())
            {
                return null;
            }
            ModeloDescuentoArticuloProveedor lcl_mod_descuento = new ModeloDescuentoArticuloProveedor();
            if (this.cmbBoxPorcentajeDescuento.SelectedValue == null)
            {
                 if(!lcl_mod_descuento.asignarPorcentaje(this.txtBoxPorcentajeDescuento.Text))
                 {
                     MessageBox.Show("Porcentaje personalizado no válido");
                     return null;
                 }
                 lcl_mod_descuento.codigoDescuento = 0;
                 lcl_mod_descuento.descripcion = String.IsNullOrWhiteSpace(this.txtBoxDescripcionDescuento.Text)? 
                                                    lcl_mod_descuento.ToString() + "%": 
                                                    this.txtBoxDescripcionDescuento.Text;
            }
            else
            {
                lcl_mod_descuento.codigoDescuento = (this.cmbBoxPorcentajeDescuento.SelectedValue as ModeloDescuento).codigoDescuento;
                lcl_mod_descuento.descripcion = (this.cmbBoxPorcentajeDescuento.SelectedValue as ModeloDescuento).descripcion;
                lcl_mod_descuento.porcentaje = (this.cmbBoxPorcentajeDescuento.SelectedValue as ModeloDescuento).porcentaje;
            }

            lcl_mod_descuento.fechaVigenciaDesde = this.dtpFechaDesdeDescuento.Value.Date;
            lcl_mod_descuento.fechaVigenciaHasta = this.dtpFechaHastaDescuento.Value.Date;

            return lcl_mod_descuento;
        }
        
        private List<ModeloArticuloProveedores> getArticulosProveedoresSeleccionados()
        {
            if (dgvResultadoBusqueda.SelectedRows.Count < 1)
            {
                return null;
            }

            List<ModeloArticuloProveedores> lcl_lst_articulosProveedoresSeleccionados = new List<ModeloArticuloProveedores>();

            int indice = 0;
            foreach (DataGridViewRow row in this.dgvResultadoBusqueda.SelectedRows)
            {
                indice = Convert.ToInt32(row.Cells[0].Value);
                lcl_lst_articulosProveedoresSeleccionados.Add(glb_lst_articulosProveedoresEncontrados[indice]);
            }

            return lcl_lst_articulosProveedoresSeleccionados;
        }

        private List<ModeloDescuentoArticuloProveedor> getDescuentosArticuloProveedor()
        {
            if (dgvResultadoBusqueda.SelectedRows.Count < 1)
            {
                return null;
            }

            List<ModeloDescuentoArticuloProveedor> lcl_lst_mod_descuentosAP = new List<ModeloDescuentoArticuloProveedor>();

            int indice = 0;
            foreach (DataGridViewRow row in this.dgvResultadoBusqueda.SelectedRows)
            {
                indice = Convert.ToInt32(row.Cells[0].Value);
                lcl_lst_mod_descuentosAP.Add(glb_mod_articuloProveedorSeleccionado.descuentos[indice]);
            }

            return lcl_lst_mod_descuentosAP;
        }
        #endregion

        #region Modelo -> Controles
        private void cargarArticuloProveedorEnControles(ModeloArticuloProveedores p_mod_articuloProveedor)
        {
            this.txtBoxCodigoOriginal.Text = p_mod_articuloProveedor.codigoOriginal;
            this.txtBoxCodigoArticuloProveedor.Text = p_mod_articuloProveedor.codigoArticuloProveedor;
            this.txtBoxDescripcion.Text = p_mod_articuloProveedor.descripcion;
            this.txtBoxModelo.Text = p_mod_articuloProveedor.modelos;
            this.cmbBoxProveedores.Text = p_mod_articuloProveedor.razonSocialProveedor;

            this.cargarDescuentosEnDGV(p_mod_articuloProveedor.descuentos);
        }

        private void actualizarDGVdescuentos()
        {
            this.cargarDescuentosEnDGV(this.glb_mod_articuloProveedorSeleccionado.descuentos);
        }
        private void cargarDescuentosEnDGV(List<ModeloDescuentoArticuloProveedor> p_lst_mod_descuentoAP)
        {
            int rowIndex;
            this.dgvResultadoBusqueda.Rows.Clear();
            DataGridViewRow row;
            foreach (ModeloDescuentoArticuloProveedor d in p_lst_mod_descuentoAP)
            {
                rowIndex = this.dgvResultadoBusqueda.Rows.Add();
                row = this.dgvResultadoBusqueda.Rows[rowIndex];

                row.Cells["dgvKey"].Value = rowIndex;

                row.Cells["codigoDescuento"].Value = d.codigoDescuento;
                row.Cells["descripcionDescuento"].Value = d.descripcion;
                row.Cells["porcentajeDescuento"].Value = d.ToString() +"%";
                row.Cells["fechaVigenciaDesdeDescuento"].Value = d.fechaVigenciaDesde.Date;
                row.Cells["fechaVigenciaHastaDescuento"].Value = d.fechaVigenciaHasta.Date;
                row.Cells["vigenteDescuento"].Value = d.esVigente()? "Sí":"No";
            }
        }
        #endregion

        #region Búsqueda

        private void buscar()
        {
            ModeloArticuloProveedores lcl_mod_articuloProveedor = this.cargarControlesEnArticuloProveedor();
            if (lcl_mod_articuloProveedor != null)
            {
                this.buscarArticulosProveedores(lcl_mod_articuloProveedor);
            }
        }

        private void buscarArticulosProveedores(ModeloArticuloProveedores p_mod_articuloProveedor)
        {
            frmResultadoBusqueda lcl_frm_resultadoBusqueda = new frmResultadoBusqueda(p_mod_articuloProveedor);
            if (lcl_frm_resultadoBusqueda.dataGridViewResultadoBusqueda.Rows.Count < 1)
            {
                MessageBox.Show("No se encontraron resultados con los parámetros ingresados.");
                return;
            }
            this.grpBoxResultadoBusqueda.Controls.Clear();
            this.dgvResultadoBusqueda = new DataGridView();
            this.dgvResultadoBusqueda = lcl_frm_resultadoBusqueda.dataGridViewResultadoBusqueda;
            this.dgvResultadoBusqueda.MouseDown += this.dgvResultadoBusqueda_MouseDown;
            this.glb_lst_articulosProveedoresEncontrados = lcl_frm_resultadoBusqueda.glb_lst_objectos.Cast<ModeloArticuloProveedores>().ToList();
            this.grpBoxResultadoBusqueda.Controls.Add(this.dgvResultadoBusqueda);
        }
        private void dgvResultadoBusqueda_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                int currentMouseOverRow = this.dgvResultadoBusqueda.HitTest(e.X, e.Y).RowIndex;
                if (currentMouseOverRow >= 0)
                {
                    if ((ModifierKeys & Keys.Control) != Keys.Control
                        && this.dgvResultadoBusqueda.Rows[currentMouseOverRow].Selected != true)
                    {//si selected == true significa que puede haber más elementos seleccionados anteriormente y no hay que perder selección
                        this.dgvResultadoBusqueda.ClearSelection();
                    }
                    this.dgvResultadoBusqueda.Rows[currentMouseOverRow].Selected = true;
                    
                    this.cntxMenuResultadoBusqueda.Show(this.dgvResultadoBusqueda, new Point(e.X, e.Y));
                }
            }
            
        }
        #endregion

        #region Agregar Descuento
        private void guardarDescuento(ModeloDescuentoArticuloProveedor p_mod_descuento)
        {
            List<ModeloArticuloProveedores> lcl_lst_articulosProveedoresDescuento = new List<ModeloArticuloProveedores>();
            if (glb_mod_articuloProveedorSeleccionado != null)//Si no es null, la ventana esta inicializada con un artículo seleccionado
            {
                lcl_lst_articulosProveedoresDescuento.Add(glb_mod_articuloProveedorSeleccionado);
            }
            else
            {
                lcl_lst_articulosProveedoresDescuento = this.getArticulosProveedoresSeleccionados();
            }

            if (!this.validarAgregarDescuento(lcl_lst_articulosProveedoresDescuento, p_mod_descuento))
            {
                return;
            }
            if(!this.confirmarAgregarDescuento(lcl_lst_articulosProveedoresDescuento, p_mod_descuento))
            {
                return;
            }

            this.agregarDescuento(lcl_lst_articulosProveedoresDescuento, p_mod_descuento);
        }
        /// <summary>
        /// Habría que mostrar el mensaje un una richTextBox en caso de que sean muchos artículos seleccionados
        /// http://stackoverflow.com/questions/8653430/how-can-i-show-a-message-box-with-details-in-winforms
        /// </summary>
        /// <param name="p_lst_mod_articuloProveedor"></param>
        /// <param name="p_mod_descuento"></param>
        /// <returns></returns>
        private bool confirmarAgregarDescuento(List<ModeloArticuloProveedores> p_lst_mod_articuloProveedor, ModeloDescuentoArticuloProveedor p_mod_descuento)
        {
            string descripcionDescuento = p_mod_descuento.ToString() + " %";
            string mensaje = dgvResultadoBusqueda.SelectedRows.Count > 1 ?
                    " a los artículos: " :
                    " al artículo: ";
            mensaje = "Se agregará un descuento de " + descripcionDescuento + mensaje;

            string detallesArticulos = "";
            foreach (ModeloArticuloProveedores ap in p_lst_mod_articuloProveedor)
            {
                detallesArticulos += System.Environment.NewLine + ap.codigoOriginal + ", " + ap.codigoArticuloProveedor + ", " + ap.descripcion;
            }
            mensaje += detallesArticulos;

            DialogResult dialogResult = MessageBox.Show(mensaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return (dialogResult == System.Windows.Forms.DialogResult.Yes);
        }
        private void agregarDescuento(List<ModeloArticuloProveedores> p_lst_mod_articuloProveedores, ModeloDescuentoArticuloProveedor p_mod_descuento)
        {
            bool resultado;
            string mensajeResultado;
            List<ModeloArticuloProveedores> lcl_lst_articulosProveedoresSinDescuento = this.agregarDescuento(p_lst_mod_articuloProveedores, p_mod_descuento, out mensajeResultado);
            int cantidadArticulosConDescuento = p_lst_mod_articuloProveedores.Count - lcl_lst_articulosProveedoresSinDescuento.Count;

            if (cantidadArticulosConDescuento == 0)
            {
                mensajeResultado = "No se ha podido asignar ningún descuento." + System.Environment.NewLine + mensajeResultado;
                resultado = false;
            }
            else if (cantidadArticulosConDescuento == p_lst_mod_articuloProveedores.Count)
            {
                mensajeResultado = "Se ha asignado el descuento a todos los artículos seleccionados." + System.Environment.NewLine + mensajeResultado;
                resultado = true;
            }
            else
            {
                mensajeResultado = "No se ha podido asignar algunos descuentos." + System.Environment.NewLine + mensajeResultado;
                resultado = false;
            }

            if (resultado)
            {
                MessageBox.Show(mensajeResultado, "Éxito", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show(mensajeResultado, "Error", MessageBoxButtons.RetryCancel);
                if (dialogResult == DialogResult.Retry)
                {
                    this.agregarDescuento(lcl_lst_articulosProveedoresSinDescuento, p_mod_descuento);
                }
            }
        }
        /// <summary>
        /// Agrega el descuento a la lista de artículos
        /// </summary>
        /// <param name="p_lst_mod_articuloProveedor"></param>
        /// <param name="p_mod_descuento"></param>
        /// <returns>Artículos a los que no se ha asignado descuento</returns>
        private List<ModeloArticuloProveedores> agregarDescuento(List<ModeloArticuloProveedores> p_lst_mod_articuloProveedor, ModeloDescuentoArticuloProveedor p_mod_descuento, out string mensajeResultado)
        {
            mensajeResultado = "";
            List<ModeloArticuloProveedores> lcl_lst_articulosProveedoresDescuento_noAgregado = new List<ModeloArticuloProveedores>();
            
            ControladorModificacion lcl_con_modificacion = new ControladorModificacion();
            ModeloArticuloProveedores lcl_mod_articuloProveedor_Auxiliar;
            foreach (ModeloArticuloProveedores ap in p_lst_mod_articuloProveedor)
            {
                mensajeResultado += ap.codigoOriginal + ", " + ap.codigoArticuloProveedor+": ";
                //Se hace una copia para el caso en que no se pueda agregar el descuento, el modelo original no lo tiene agregado
                //Si no, podría darse el caso de agregar el descuento al modelo y que no se guarde en Base de Datos, lo que mostraría en el formulario
                //que el descuento ya existe en el artículo, cuando esa situación no esta reflejada en la Base de Datos
                lcl_mod_articuloProveedor_Auxiliar = new ModeloArticuloProveedores();
                lcl_mod_articuloProveedor_Auxiliar = LibreriaClasesCompartidas.ObjectCopier.Clone(ap);
                if (lcl_mod_articuloProveedor_Auxiliar.agregarDescuento(p_mod_descuento))
                {
                    if (lcl_con_modificacion.modificar(lcl_mod_articuloProveedor_Auxiliar))
                    {
                        ap.agregarDescuento(p_mod_descuento);
                        mensajeResultado += "Agregado correctamente";
                    }
                    else
                    {
                        lcl_lst_articulosProveedoresDescuento_noAgregado.Add(ap);
                        mensajeResultado += "Error al guardar en base de datos";
                    }
                }
                else
                {
                    lcl_lst_articulosProveedoresDescuento_noAgregado.Add(ap);
                    mensajeResultado += "Descuento no válido";
                }
                mensajeResultado += System.Environment.NewLine;
            }
            return lcl_lst_articulosProveedoresDescuento_noAgregado;
        }
        #endregion

        #region Eliminar Descuento
        private void eliminarDescuento()
        {
            List<ModeloDescuentoArticuloProveedor> lcl_lst_descuentosSeleccionados = this.getDescuentosArticuloProveedor();
            if (lcl_lst_descuentosSeleccionados == null)
            {
                MessageBox.Show("No hay descuentos seleccionados");
                return;
            }
            if(!this.confirmarEliminarDescuento(lcl_lst_descuentosSeleccionados))
            {
                return ;
            }

            this.eliminarDescuento(lcl_lst_descuentosSeleccionados);

            this.actualizarDGVdescuentos();
        }
        private void eliminarDescuento(List<ModeloDescuentoArticuloProveedor> p_lst_mod_descuentosAP)
        {
            List<ModeloDescuentoArticuloProveedor> lcl_lst_descuentosNoEliminados = new List<ModeloDescuentoArticuloProveedor>();
            
            ModeloArticuloProveedores lcl_mod_articuloProveedor_auxiliar = new ModeloArticuloProveedores();
            lcl_mod_articuloProveedor_auxiliar = LibreriaClasesCompartidas.ObjectCopier.Clone(glb_mod_articuloProveedorSeleccionado);
            
            ControladorModificacion lcl_con_modificacion = new ControladorModificacion();
            foreach (ModeloDescuentoArticuloProveedor d in p_lst_mod_descuentosAP)
            {
                lcl_mod_articuloProveedor_auxiliar.eliminarDescuento(d);
                if (lcl_con_modificacion.modificar(lcl_mod_articuloProveedor_auxiliar))
                {
                    glb_mod_articuloProveedorSeleccionado.eliminarDescuento(d);
                }
                else
                {
                    lcl_lst_descuentosNoEliminados.Add(d);
                }
            }
            
            if(lcl_lst_descuentosNoEliminados.Count <1)
            {
                MessageBox.Show("Descuentos eliminados.","Éxito",MessageBoxButtons.OK);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Algunos descuentos no han podido ser eliminados","Error",MessageBoxButtons.RetryCancel);
                if (dialogResult == System.Windows.Forms.DialogResult.Retry)
                {
                    this.eliminarDescuento(lcl_lst_descuentosNoEliminados);
                }
            }
        }
        private bool confirmarEliminarDescuento(List<ModeloDescuentoArticuloProveedor> p_lst_mod_descuentosAP)
        {
            if (p_lst_mod_descuentosAP.Count < 1)
            {
                return false;
            }

            string mensaje = "Se eliminarán los siguientes descuentos:"+System.Environment.NewLine;
            foreach (ModeloDescuentoArticuloProveedor d_ap in p_lst_mod_descuentosAP)
            {
                mensaje += d_ap.ToString() + ": " + d_ap.descripcion + System.Environment.NewLine;
            }

            DialogResult dialogResult = MessageBox.Show(mensaje, "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return (dialogResult == System.Windows.Forms.DialogResult.Yes);
        }
        
        #endregion

        #region Abrir Descuentos de Artículo Proveedor
        private bool validarAbrirDescuentosAP()
        {
            List<ModeloArticuloProveedores> lcl_lst_articulosProveedoresDescuento = this.getArticulosProveedoresSeleccionados();
            if (lcl_lst_articulosProveedoresDescuento.Count != 1)
            {
                MessageBox.Show("No puede seleccionar más de un artículo para visualizar");
                return false;
            }
            return true;
        }
        private void abrirDescuentosAP()
        {
            if (!this.validarAbrirDescuentosAP())
            {
                return;
            }
            frmABMDescuentos lcl_frm_descuentosArticuloProveedor = new frmABMDescuentos(this.getArticulosProveedoresSeleccionados()[0]);
            this.abrirDescuentosArticuloProveedor(lcl_frm_descuentosArticuloProveedor,new EventArgs());
        }
        #endregion

        #endregion

        #region Eventos

        #region Buttons
        private void btnGuardarDescuento_Click(object sender, EventArgs e)
        {
            ModeloDescuentoArticuloProveedor lcl_mod_descuento = this.cargarControlesEnDescuento();
            if (lcl_mod_descuento != null)
            {
                this.guardarDescuento(lcl_mod_descuento);
            }
        }
        
        #endregion

        #region DataGridView
        #endregion

        #region DateTimePickers
        private void dtpFechaDesdeDescuento_ValueChanged(object sender, EventArgs e)
        {
            this.dtpFechaHastaDescuento.MinDate = this.dtpFechaDesdeDescuento.Value.Date;
        }
        #endregion
        
        #region ComboBox
        private void cmbBoxPorcentajeDescuento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            bool porcentajePersonalizado = this.cmbBoxPorcentajeDescuento.SelectedValue == null;
            if (!porcentajePersonalizado)
            {
                this.txtBoxDescripcionDescuento.Text = (this.cmbBoxPorcentajeDescuento.SelectedValue as ModeloDescuento).descripcion;
            }
            this.inicializarPorcentajePersonalizado(porcentajePersonalizado);
        }
        #endregion

        #region Validaciones
        private void txtBoxCodigoOriginal_Leave(object sender, EventArgs e)
        {
            bool respuesta = Validar.validarInputNoNumerico(txtBoxCodigoOriginal.Text.ToString(), Constantes.ParametrosBusqueda.Articulos.CodigoOriginal);
            if (!respuesta)
            {
                epCodigoOriginal.Icon = Properties.Resources.error;
                epCodigoOriginal.SetError(txtBoxCodigoOriginal, "Codigo Orignal no válido");
            }
            else
            {
                epCodigoOriginal.Icon = Properties.Resources.success;
                epCodigoOriginal.SetError(txtBoxCodigoOriginal, "OK");
            }
        }

        #endregion

        private void txtBoxDescripcion_Leave(object sender, EventArgs e)
        {
            bool respuesta = Validar.validarInputNoNumerico(txtBoxDescripcion.Text.ToString(), Constantes.ParametrosBusqueda.Articulos.Descripcion);
            if (!respuesta)
            {
                epDescripcionArticulo.Icon = Properties.Resources.error;
                epDescripcionArticulo.SetError(txtBoxDescripcion, "Descripción no válida");
            }
            else
            {
                epDescripcionArticulo.Icon = Properties.Resources.success;
                epDescripcionArticulo.SetError(txtBoxDescripcion, "OK");
            }
        }

        private void txtBoxCodigoArticuloProveedor_Leave(object sender, EventArgs e)
        {
            bool respuesta = Validar.validarInputNoNumerico(txtBoxCodigoArticuloProveedor.Text.ToString(), Constantes.ParametrosBusqueda.ArticulosProveedores.CodigoArticuloProveedor);
            if (!respuesta)
            {
                epCodigoArticuloProveedor.Icon = Properties.Resources.error;
                epCodigoArticuloProveedor.SetError(txtBoxCodigoArticuloProveedor, "Codigo Articulo no válido");
            }
            else
            {
                epCodigoArticuloProveedor.Icon = Properties.Resources.success;
                epCodigoArticuloProveedor.SetError(txtBoxCodigoArticuloProveedor, "OK");
            }
        }

        private void txtBoxModelo_Leave(object sender, EventArgs e)
        {
            bool respuesta = Validar.validarInputNoNumerico(txtBoxModelo.Text.ToString(), Constantes.ParametrosBusqueda.ArticulosProveedores.Modelo);
            if (!respuesta)
            {
                epModelo.Icon = Properties.Resources.error;
                epModelo.SetError(txtBoxModelo, "Modelo no válido");
            }
            else
            {
                epModelo.Icon = Properties.Resources.success;
                epModelo.SetError(txtBoxModelo, "OK");
            }
        }

        private void txtBoxPorcentajeDescuento_Leave(object sender, EventArgs e)
        {
            bool respuesta = Validar.validarInputNumerico(txtBoxPorcentajeDescuento.Text.ToString(), Constantes.Numericos.Porcentual);
            if (!respuesta)
            {
                epPorcentaje.Icon = Properties.Resources.error;
                epPorcentaje.SetError(txtBoxPorcentajeDescuento, "Porcentaje no válido");
            }
            else
            {
                epPorcentaje.Icon = Properties.Resources.success;
                epPorcentaje.SetError(txtBoxPorcentajeDescuento, "OK");
            }
        }

        private void txtBoxDescripcionDescuento_Leave(object sender, EventArgs e)
        {
            bool respuesta = Validar.validarInputNoNumerico(txtBoxDescripcionDescuento.Text.ToString(), Constantes.ParametrosBusqueda.Descuentos.Descripcion);
            if (!respuesta)
            {
                epPorcentaje.Icon = Properties.Resources.error;
                epPorcentaje.SetError(txtBoxDescripcionDescuento, "Descripcion no válida");
            }
            else
            {
                epPorcentaje.Icon = Properties.Resources.success;
                epPorcentaje.SetError(txtBoxDescripcionDescuento, "OK");
            }
        }
        #endregion
    }
}
