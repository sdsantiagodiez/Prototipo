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
using LibreriaClasesCompartidas;

namespace Vista
{
    public partial class frmPedidoNuevo : frmMaterialSkinBase
    {
        #region Atributos
        public event EventHandler MostrarDetallesArticulo;
        ModeloArticuloProveedores glb_mod_articuloSeleccionadoBusqueda;
        public ControladorPedido controlador;
        ContextMenu cntxMenuResultadoBusqueda;
        ContextMenu cntxMenuLineasPedidos;
        //se usa para evitar mostrar mensaje de confirmación cuando se cierra la ventana y se selecciona continuar
        bool continuarPedido;
        #endregion

        #region Constructores
        public frmPedidoNuevo()
        {
            InitializeComponent();

            dgvArticulosResultadoBusqueda.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvArticulosResultadoBusqueda.EnableHeadersVisualStyles = false;
            dgvArticulosEnPedido.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvArticulosEnPedido.EnableHeadersVisualStyles = false;
            //this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.inicializarControles();
        }
        public frmPedidoNuevo(Constantes.CodigosTiposPedidos p_codigoTipoPedido) : this()
        {
            controlador = new ControladorPedido(p_codigoTipoPedido);

            if (controlador.pedidoActual.codigoTipoPedido == Constantes.CodigosTiposPedidos.Persona)
            {
                this.chckBoxPermitirStockNegativo.Visible = true;
                this.chckBoxPermitirStockNegativo.Checked = false;
            }
            else
            {
                this.chckBoxPermitirStockNegativo.Visible = false;
                this.chckBoxPermitirStockNegativo.Checked = true;
            }
        }
        /// <summary>
        /// Se agrega pedido para ser modificado
        /// </summary>
        /// <param name="p_mod_pedido"></param>
        public frmPedidoNuevo(ModeloPedido p_mod_pedido) : this(p_mod_pedido.codigoTipoPedido)
        {
            controlador.pedidoActual = p_mod_pedido;
            this.btnSiguiente.Text = "Guardar Cambios";

            this.cargarLineasPedidosEnControles();
        }
        #endregion
       
        #region Métodos
        #region Inicialización
        public override void inicializarForm(int ventanaAncho, int ventanaAlto)
        {
            this.tblLayoutPanelPrincipal.Width = ventanaAncho - 20; //un margen derecho de 20 para que se vea scrollbar
            this.pnlBase.Width = ventanaAncho - 3;  //un márgen derecho de 3
            this.pnlBase.Height = ventanaAlto - 60; //un márgen arriba para que se vea título
            if (pnlBase.Height < 560)
            {
                this.tblLayoutPanelPrincipal.Height = 560;  //Mínimo

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
            this.pnlBase.Location = new Point(0, 65);
        }
        private void inicializarControles()
        {
            this.txtDescripcionParcial.Leave += (s, e) => { txtDescripcionParcial_Leave(); };

            #region DataGridViews
            this.dgvArticulosResultadoBusqueda.MultiSelect = false;
            //seteo columnas de datagridviews
            this.dgvArticulosResultadoBusqueda.AutoGenerateColumns = false;
            this.dgvArticulosEnPedido.AutoGenerateColumns = false;
            #endregion

            #region ComboBoxCategoriaBusqueda
            //Creo lista categorias de búsqueda
            var dataSource = new List<ComboBoxItem>();
            dataSource.Add(new ComboBoxItem() { Name = "Seleccione...", Value = null });
            dataSource.Add(new ComboBoxItem() { Name = "Codigo Original", Value = Constantes.ParametrosBusqueda.ArticulosProveedores.CodigoOriginal });
            dataSource.Add(new ComboBoxItem() { Name = "Descripción", Value = Constantes.ParametrosBusqueda.ArticulosProveedores.DescripcionArticuloProveedor });
            dataSource.Add(new ComboBoxItem() { Name = "Codigo Proveedor", Value = Constantes.ParametrosBusqueda.ArticulosProveedores.CodigoArticuloProveedor });
            //Binding de categorias
            this.cbxCategoriaBusqueda.DataSource = dataSource;
            this.cbxCategoriaBusqueda.DisplayMember = "Name";
            this.cbxCategoriaBusqueda.ValueMember = "Value";
            this.cbxCategoriaBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;//Lo hago read only
            #endregion 

            #region ContextMenu
            cntxMenuResultadoBusqueda = new ContextMenu();
            cntxMenuResultadoBusqueda.MenuItems.Add("Ver Detalles Artículo");
            cntxMenuResultadoBusqueda.MenuItems[0].Click += (s,e)=>
                {
                    this.verDetallesArticulo(glb_mod_articuloSeleccionadoBusqueda);
                };
            cntxMenuResultadoBusqueda.MenuItems.Add("Agregar 1");
            cntxMenuResultadoBusqueda.MenuItems[1].Click += (s, e) =>
            {
                this.agregarArticuloProveedorAPedido(glb_mod_articuloSeleccionadoBusqueda, 1, this.chckBoxPermitirStockNegativo.Checked);
            };
            cntxMenuResultadoBusqueda.MenuItems.Add("Agregar 2");
            cntxMenuResultadoBusqueda.MenuItems[2].Click += (s,e)=>
                {
                    this.agregarArticuloProveedorAPedido(glb_mod_articuloSeleccionadoBusqueda,2, this.chckBoxPermitirStockNegativo.Checked);
                };
            cntxMenuResultadoBusqueda.MenuItems.Add("Agregar 5");
            cntxMenuResultadoBusqueda.MenuItems[3].Click += (s,e)=>
                {
                    this.agregarArticuloProveedorAPedido(glb_mod_articuloSeleccionadoBusqueda,5, this.chckBoxPermitirStockNegativo.Checked);
                };
            cntxMenuResultadoBusqueda.MenuItems.Add("Agregar 10");
            cntxMenuResultadoBusqueda.MenuItems[4].Click += (s, e) =>
                {
                    this.agregarArticuloProveedorAPedido(glb_mod_articuloSeleccionadoBusqueda, 10, this.chckBoxPermitirStockNegativo.Checked);
                };
            
            cntxMenuLineasPedidos = new ContextMenu();
            cntxMenuLineasPedidos.MenuItems.Add("Ver Detalles Artículo");
            cntxMenuLineasPedidos.MenuItems[0].Click += (s, e) =>
            {
                this.verDetallesArticulo(null);
            };
            cntxMenuLineasPedidos.MenuItems.Add("Editar Cantidad");
            cntxMenuLineasPedidos.MenuItems[1].Click += (s, e) =>
            {
                this.editarCantidadArticulosEnLineaPedido();
            };
            cntxMenuLineasPedidos.MenuItems.Add("Quitar seleccionado");
            cntxMenuLineasPedidos.MenuItems[2].Click += (s, e) =>
                {
                    this.eliminarArticuloProveedorDePedido();
                };
            cntxMenuLineasPedidos.MenuItems.Add("Quitar todos"); 
            cntxMenuLineasPedidos.MenuItems[3].Click += (s, e) =>
                {
                    this.eliminarArticuloProveedorDePedidoTodos();
                };
            #endregion

            #region Button
            this.btnAgregar.Click += (s, e) =>
                {
                    this.agregarArticuloProveedorAPedido();
                };
            this.btnQuitar.Click += (s, e) =>
                {
                    this.eliminarArticuloProveedorDePedido();  
                };
            this.btnBorrarDetalleActual.Click += (s, e) =>
                {
                    this.eliminarArticuloProveedorDePedidoTodos();
                };
            #endregion
        }
        private void inicializarContextMenuResultadoBusqueda()
        { 

        }
        private void inicializarContextMenuLineasPedido()
        {
            if (this.dgvArticulosEnPedido.SelectedRows.Count > 1)
            {
                this.cntxMenuLineasPedidos.MenuItems[0].Visible = false;
                this.cntxMenuLineasPedidos.MenuItems[1].Visible = false;
                this.cntxMenuLineasPedidos.MenuItems[2].Text = "Quitar seleccionados";
                if (this.dgvArticulosEnPedido.SelectedRows.Count == this.controlador.pedidoActual.lineasPedido.Count)
                {
                    this.cntxMenuLineasPedidos.MenuItems[2].Visible = false;
                }
                else
                {
                    this.cntxMenuLineasPedidos.MenuItems[2].Visible = true;
                }
            }
            else
            {
                this.cntxMenuLineasPedidos.MenuItems[0].Visible = true;
                this.cntxMenuLineasPedidos.MenuItems[1].Visible = true;
                this.cntxMenuLineasPedidos.MenuItems[2].Visible = true;
                this.cntxMenuLineasPedidos.MenuItems[2].Text = "Quitar seleccionado";
            }
        }
        #endregion
      
        #region Validación
        /// <summary>
        /// Informa de acuerdo a los parámetros del pedido si el artículo puede ser agregado
        /// </summary>
        /// <returns></returns>
        private bool validarAgregarArticulo()
        {
            bool respuesta = true;
            string mensajeError = "";

            //checkeo que haya un articulo seleccionado
            if (object.Equals(this.glb_mod_articuloSeleccionadoBusqueda, null))
            {
                mensajeError = "Por favor seleccione un articulo a agregar de la grilla de busqueda";
                respuesta = false;
            } 
            //Verifico la cantidad
            else if (!LibreriaClasesCompartidas.Validar.validarInputNumerico(this.nmrcUpDownCantidad.Value.ToString(),LibreriaClasesCompartidas.Constantes.Numericos.EnteroPositivoSinCero))
            {
                mensajeError = "La cantidad de articulos debe ser un número mayor a cero.";
                respuesta = false;
            }
            //verifico stock    //proveedor no valida stock
            else if (controlador.tipoPedido == Constantes.CodigosTiposPedidos.Persona
                && this.glb_mod_articuloSeleccionadoBusqueda.stockActual < Convert.ToInt32(this.nmrcUpDownCantidad.Value)
                && !this.chckBoxPermitirStockNegativo.Checked)
            {
                mensajeError = "No hay suficientes articulos en inventario actual para cubrir el pedido";
                respuesta = false;
            }
            //verifico que no exista ya en entre las lineas de pedido
            else if (controlador.exists(glb_mod_articuloSeleccionadoBusqueda))
            {
                ModeloLineaPedido lpExistente = controlador.pedidoActual.getLineaPedido(glb_mod_articuloSeleccionadoBusqueda);
                if (!this.chckBoxPermitirStockNegativo.Checked)
                {
                    int cantidadTotal = lpExistente.cantidadArticulos + Convert.ToInt32(this.nmrcUpDownCantidad.Value);
                    if (cantidadTotal > glb_mod_articuloSeleccionadoBusqueda.stockActual)
                    {
                        mensajeError = "No hay suficientes articulos en inventario actual para cubrir el pedido";
                        respuesta = false;
                    }
                }
            }

            if (!respuesta)
            {
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return respuesta;
        }

        private bool validarBusqueda()
        {
            //me aseguro que se haya seleccionado una categoria de búsqueda
            if (object.Equals((string)this.cbxCategoriaBusqueda.SelectedValue, null))
            {
                MessageBox.Show("Por favor seleccione una categoría de búsqueda");
                return false;
            }
            return true;
        }
        #endregion

        #region Modelo -> Controles
        /// <summary>
        /// Carga lista de artículos proveedores en datagridview de resultados
        /// </summary>
        /// <param name="p_lst_mod_articulosProveedores"></param>
        private void cargarArticulosProveedoresEncontradosEnControles(List<ModeloArticuloProveedores> p_lst_mod_articulosProveedores)
        {
            DataTable articulosProveedores = new DataTable();
            articulosProveedores.Columns.Add("indice");
            articulosProveedores.Columns.Add("codigoOriginal");
            articulosProveedores.Columns.Add("codigoArticuloProveedor");
            articulosProveedores.Columns.Add("razonSocialProveedor");
            articulosProveedores.Columns.Add("descripcion");
            int i = 0;
            foreach (ModeloArticuloProveedores ap in p_lst_mod_articulosProveedores)
            {
                var row = articulosProveedores.NewRow();
                row["indice"] = i.ToString();
                i++;
                row["codigoOriginal"] = ap.codigoOriginal;
                row["codigoArticuloProveedor"] = ap.codigoArticuloProveedor;
                row["razonSocialProveedor"] = ap.razonSocialProveedor;
                row["descripcion"] = ap.descripcionArticuloProveedor;

                articulosProveedores.Rows.Add(row);
            }

            this.dgvArticulosResultadoBusqueda.DataSource = articulosProveedores;
            this.dgvArticulosResultadoBusqueda.ClearSelection();
            this.glb_mod_articuloSeleccionadoBusqueda = null;
            this.cleanLbls();
        }
        /// <summary>
        /// Carga artículo proveedor en labels que muestran vista previa del artículo
        /// </summary>
        /// <param name="p_mod_articuloProveedor"></param>
        private void cargarArticuloProveedorDetallesEnControles(ModeloArticuloProveedores p_mod_articuloProveedor)
        {
            //actualizo lost lbl para mostrar el articulo seleccionado
            this.lblCodigoOriginalVar.Text = p_mod_articuloProveedor.codigoOriginal;
            this.lblCodigoProveedorVar.Text = p_mod_articuloProveedor.codigoArticuloProveedor;
            this.lblProveedorVar.Text = p_mod_articuloProveedor.razonSocialProveedor;
            this.lblDescripcionVar.Text = p_mod_articuloProveedor.descripcionArticuloProveedor;
            //
            //TODO modificadores de precio segun metodo de pago
            if (controlador.tipoPedido == Constantes.CodigosTiposPedidos.Persona)
            {
                this.lblPrecioVar.Text = Convert.ToString(p_mod_articuloProveedor.valorVenta.valorArticulo);
            }
            else if (controlador.tipoPedido == Constantes.CodigosTiposPedidos.Proveedor)
            {
                this.lblPrecioVar.Text = Convert.ToString(p_mod_articuloProveedor.valorCompra.valorArticulo);
            }
            
            this.lblUbicacionVar.Text = p_mod_articuloProveedor.ubicacion;
            this.lblExistenciaVar.Text = Convert.ToString(p_mod_articuloProveedor.stockActual);
            this.lblFechaActualizacionVar.Text = Convert.ToString(p_mod_articuloProveedor.fechaActualizacion);
            this.lblObservacionesVar.Text = p_mod_articuloProveedor.observacionesArticuloProveedor;
        }
        /// <summary>
        /// Carga artículo proveedor en datagrid de pedido actual
        /// </summary>
        /// <param name="p_mod_articuloProveedor"></param>
        private void cargarLineasPedidosEnControles()
        {
            this.lblTotalVar.Text = "$ "+String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}", controlador.getTotal());

            this.cargarLineasPedidosEnControles(controlador.pedidoActual.lineasPedido);
        }
        private void cargarLineasPedidosEnControles(List<ModeloLineaPedido> p_lst_lineas)
        {
            DataTable lineas = new DataTable();
            lineas.Columns.Add("indice");
            lineas.Columns.Add("codigoOriginal");
            lineas.Columns.Add("codigoArticuloProveedor");
            lineas.Columns.Add("descripcion");
            lineas.Columns.Add("cantidad");
            lineas.Columns.Add("valorUnitario");
            lineas.Columns.Add("descuento");
            lineas.Columns.Add("valorParcialSinDescuento");
            lineas.Columns.Add("valorParcialConDescuento");
            int i = 0;
            foreach (ModeloLineaPedido l in p_lst_lineas)
            {
                var row = lineas.NewRow();
                row["indice"] = i.ToString();
                i++;
                row["codigoOriginal"] = l.articulo.codigoOriginal;
                row["codigoArticuloProveedor"] = l.articulo.codigoArticuloProveedor;
                row["descripcion"] = l.articulo.descripcion;
                row["cantidad"] = l.cantidadArticulos;
                row["valorUnitario"] = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}", l.valorUnitario);
                row["descuento"] = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}", l.getDescuento());
                //row["descuento"] = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}", l.descuentoLinea.PorcentajeDescuento);
                row["valorParcialSinDescuento"] = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}", l.getValorParcialSinDescuentos());
                //row["valorParcialConDescuento"] = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}", l.getValorParcial());
                row["valorParcialConDescuento"] = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}", l.getValorParcialConDescuento());

                lineas.Rows.Add(row);
            }

            this.dgvArticulosEnPedido.DataSource = lineas;
        }
        #endregion

        private void cleanLbls()
        {
            this.lblCodigoOriginalVar.Text = this.lblCodigoProveedorVar.Text = this.lblProveedorVar.Text =
            this.lblDescripcionVar.Text = this.lblPrecioVar.Text = this.lblExistenciaVar.Text =
            this.lblFechaActualizacionVar.Text = this.lblObservacionesVar.Text =
            this.lblUbicacionVar.Text = "Seleccione Artículo";
        }
        /// <summary>
        /// Agrega artículo(s) proveedor al pedido actual
        /// </summary>
        private void agregarArticuloProveedorAPedido()
        {
            this.agregarArticuloProveedorAPedido(glb_mod_articuloSeleccionadoBusqueda, Convert.ToInt32(this.nmrcUpDownCantidad.Value), this.chckBoxPermitirStockNegativo.Checked);
        }
        /// <summary>
        /// Agrega artículo(s) proveedor al pedido actual
        /// </summary>
        /// <param name="p_mod_articuloProveedor"></param>
        /// <param name="p_cantidad"></param>
        /// <param name="p_permitirStockNegativo"></param>
        private void agregarArticuloProveedorAPedido(ModeloArticuloProveedores p_mod_articuloProveedor, int p_cantidad, bool p_permitirStockNegativo)
        {
            this.nmrcUpDownCantidad.Value = p_cantidad;
            if (this.validarAgregarArticulo())
            {
                //Agrego línea y especifico si permite stock negativo
                controlador.addArticulo(p_mod_articuloProveedor, p_cantidad);
                controlador.pedidoActual.lineasPedido[controlador.pedidoActual.lineasPedido.Count - 1].permitirStockNegativo = p_permitirStockNegativo;
                this.cargarLineasPedidosEnControles();
            }
        }
        /// <summary>
        /// Elimina artículos seleccionados en datagridview del pedido actual
        /// </summary>
        private void eliminarArticuloProveedorDePedido()
        {
            List<ModeloLineaPedido> lcl_lst_lineasPedidosEliminar = new List<ModeloLineaPedido>();
            int i;
            string detallesArticulos = "";
            foreach (DataGridViewRow row in dgvArticulosEnPedido.SelectedRows)
            {
                //i = Convert.ToInt32(row.Index);
                lcl_lst_lineasPedidosEliminar.Add(controlador.pedidoActual.lineasPedido[row.Index]);

                i = lcl_lst_lineasPedidosEliminar.Count - 1;
                detallesArticulos += Environment.NewLine + "- " + lcl_lst_lineasPedidosEliminar[i].articulo.descripcionArticuloProveedor + " (" + lcl_lst_lineasPedidosEliminar[i].articulo.codigoArticuloProveedor + ")";
            }

            if (lcl_lst_lineasPedidosEliminar.Count < 1)
            {
                MessageBox.Show("No hay artículo seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (lcl_lst_lineasPedidosEliminar.Count == this.dgvArticulosEnPedido.RowCount)
            {
                this.eliminarArticuloProveedorDePedidoTodos();
                return;
            }

            string mensaje = lcl_lst_lineasPedidosEliminar.Count > 1 ?
                    "¿Está seguro que desea eliminar los artículos: " :
                    "¿Está seguro que desea eliminar el artículo: ";

            DialogResult dialogResult = MessageBox.Show(mensaje +
                detallesArticulos + " ?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                foreach (ModeloLineaPedido lp in lcl_lst_lineasPedidosEliminar)
                {
                    controlador.pedidoActual.removeLineaPedido(lp);
                }
                this.cargarLineasPedidosEnControles();
            }
        }
        /// <summary>
        /// Elimina todos los artículos ingresados al pedido actual
        /// </summary>
        private void eliminarArticuloProveedorDePedidoTodos()
        {
            DialogResult lcl_dialogResult = MessageBox.Show("¿Realmente desea borrar el detalle actual?", "Confirmación", MessageBoxButtons.YesNo);
            if (lcl_dialogResult == DialogResult.Yes)
            {
                controlador.removeLineasPedidos();
                this.dgvArticulosEnPedido.DataSource = null;
                //cleanLbls();
            }
        }

        /// <summary>
        /// Busca artículos proveedores y retorna resultados
        /// </summary>
        /// <returns>null si parámetros de búsqueda inválidos</returns>
        private List<ModeloArticuloProveedores> buscarArticuloProveedor()
        {
            if (!this.validarBusqueda())
            {
                return null;
            }

            BackgroundWorker bw = new BackgroundWorker();
            frmLoading lcl_frm_loading = new frmLoading("Espere por favor. Realizando búsqueda.");
            List<ModeloArticuloProveedores> lcl_lst_articulosProveedores = new List<ModeloArticuloProveedores>();

            string categoriaBusqueda = (string)this.cbxCategoriaBusqueda.SelectedValue;
            string descripcionBusqueda = this.txtDescripcionParcial.Text;

            bw.DoWork += (s, e) =>
            {
                if (controlador.buscarArticulos(categoriaBusqueda, descripcionBusqueda) < 1)
                {
                    lcl_lst_articulosProveedores = new List<ModeloArticuloProveedores>();
                }
                else
                {
                    lcl_lst_articulosProveedores = controlador.resultadoBusquedaArticulosProveedores;
                }
            };
            bw.RunWorkerCompleted += (s, e) =>
            {
                lcl_frm_loading.Hide();
            };

            bw.RunWorkerAsync();
            lcl_frm_loading.ShowDialog();

            return lcl_lst_articulosProveedores;
        }
        /// <summary>
        /// Muestra ventana para editar cantidad ingresada de un artículo seleccionado en datagridview del pedido actual
        /// </summary>
        private void editarCantidadArticulosEnLineaPedido()
        {
            int i = this.dgvArticulosEnPedido.SelectedRows[0].Index;
            frmPedidoNuevo_editarCantidad lcl_frm_editarCantidad = new frmPedidoNuevo_editarCantidad(controlador.pedidoActual.lineasPedido[i],controlador.pedidoActual.codigoTipoPedido);
            lcl_frm_editarCantidad.ShowDialog();
            controlador.pedidoActual.updateLineaPedido(controlador.pedidoActual.lineasPedido[i]);
            this.cargarLineasPedidosEnControles();
        }
        #endregion

        #region Eventos
        #region Botones
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            //compruebo que existan articulos para generar pedido
            if (controlador.getCantidadLineas() > 0)
            {
                this.continuarPedido = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("No se han seleccionado artículos para el pedido actual");
            }
        }
        #endregion

        #region DataGridViews

        #region Resultados de búsqueda
        
        private void dgvArticulosResultadoBusqueda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                //No hay fila seleccionada
                return;
            }
            int i = Convert.ToInt32(this.dgvArticulosResultadoBusqueda.Rows[e.RowIndex].Cells["indice"].Value);
            //asigno el articulo a la variable articuloSeleccionadoBusqueda en caso de que se decida agregarlo al pedido
            this.glb_mod_articuloSeleccionadoBusqueda = controlador.getArticuloBusqueda(i);

            cargarArticuloProveedorDetallesEnControles(this.glb_mod_articuloSeleccionadoBusqueda);
            this.nmrcUpDownCantidad.Focus();
            this.nmrcUpDownCantidad.Select(0,this.nmrcUpDownCantidad.Text.Length);
        }
        
        private void dgvArticulosResultadoBusqueda_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                int currentMouseOverRow = this.dgvArticulosResultadoBusqueda.HitTest(e.X, e.Y).RowIndex;
                if (currentMouseOverRow >= 0)
                {
                    if ((ModifierKeys & Keys.Control) != Keys.Control
                        && this.dgvArticulosResultadoBusqueda.Rows[currentMouseOverRow].Selected != true)
                    {//si selected == true significa que puede haber más elementos seleccionados anteriormente y no hay que perder selección
                        this.dgvArticulosResultadoBusqueda.ClearSelection();
                    }
                    this.dgvArticulosResultadoBusqueda.Rows[currentMouseOverRow].Selected = true;
                    int i = Convert.ToInt32(this.dgvArticulosResultadoBusqueda.Rows[currentMouseOverRow].Cells["indice"].Value);
                    //asigno el articulo a la variable articuloSeleccionadoBusqueda en caso de que se decida agregarlo al pedido
                    this.glb_mod_articuloSeleccionadoBusqueda = controlador.getArticuloBusqueda(i);

                    cargarArticuloProveedorDetallesEnControles(this.glb_mod_articuloSeleccionadoBusqueda);
                    this.inicializarContextMenuResultadoBusqueda();
                    this.cntxMenuResultadoBusqueda.Show(dgvArticulosResultadoBusqueda, new Point(e.X, e.Y));
                }
            }
        }
        #endregion
        #region Artículos agregados a pedido
        private void dgvArticulosEnPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                //No hay fila seleccionada
                return;
            }
            int i = e.RowIndex ;
            //asigno el articulo a la variable articuloSeleccionadoBusqueda en caso de que se decida agregarlo al pedido
            this.glb_mod_articuloSeleccionadoBusqueda = controlador.pedidoActual.lineasPedido[i].articulo;

            cargarArticuloProveedorDetallesEnControles(this.glb_mod_articuloSeleccionadoBusqueda);
            this.nmrcUpDownCantidad.Focus();
            this.nmrcUpDownCantidad.Select(0, this.nmrcUpDownCantidad.Text.Length);
        }
        private void dgvArticulosEnPedido_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                int currentMouseOverRow = this.dgvArticulosEnPedido.HitTest(e.X, e.Y).RowIndex;
                if (currentMouseOverRow >= 0)
                {
                    if ((ModifierKeys & Keys.Control) != Keys.Control
                        && this.dgvArticulosEnPedido.Rows[currentMouseOverRow].Selected != true)
                    {//si selected == true significa que puede haber más elementos seleccionados anteriormente y no hay que perder selección
                        this.dgvArticulosEnPedido.ClearSelection();
                    }
                    this.dgvArticulosEnPedido.Rows[currentMouseOverRow].Selected = true;
                    //int i = Convert.ToInt32(this.dgvArticulosEnPedido.Rows[currentMouseOverRow].Cells["indice"].Value);
                    //asigno el articulo a la variable articuloSeleccionadoBusqueda en caso de que se decida agregarlo al pedido
                    int i = this.dgvArticulosEnPedido.SelectedRows[0].Index;
                    this.dgvArticulosEnPedido.CurrentCell = this.dgvArticulosEnPedido[1, i];
                    this.glb_mod_articuloSeleccionadoBusqueda = controlador.pedidoActual.lineasPedido[i].articulo;
                    
                    cargarArticuloProveedorDetallesEnControles(this.glb_mod_articuloSeleccionadoBusqueda);
                    this.inicializarContextMenuLineasPedido();
                    this.cntxMenuLineasPedidos.Show(dgvArticulosEnPedido, new Point(e.X, e.Y));
                }
            }
        }
        /// <summary>
        /// Muestra ventana con todos los detalles del artículo proveedor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void evento_verDetalleArticulo(object sender, EventArgs e)
        {
            if (this.dgvArticulosEnPedido.CurrentRow == null)
            {
                MessageBox.Show("No hay artículo seleccionada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int i = Convert.ToInt32(this.dgvArticulosEnPedido.CurrentRow.Cells["indiceDGV"].Value);

            frmABMArticulo lcl_frm_articuloProveedor = new frmABMArticulo(controlador.pedidoActual.lineasPedido[i].articulo, frmABMArticulo.ModoFormularioVisualizarEntidad);
            MostrarDetallesArticulo(lcl_frm_articuloProveedor, e);
        }
        private void verDetallesArticulo(ModeloArticuloProveedores p_articuloProveedor)
        {
            if (p_articuloProveedor == null)
            {
                if (this.dgvArticulosEnPedido.CurrentRow == null)
                {
                    MessageBox.Show("No hay artículo seleccionada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int i = Convert.ToInt32(this.dgvArticulosEnPedido.CurrentRow.Cells["indiceDGV"].Value);
                p_articuloProveedor = controlador.pedidoActual.lineasPedido[i].articulo;
            }
            
            MostrarDetallesArticulo(new frmABMArticulo(p_articuloProveedor, frmABMArticulo.ModoFormularioVisualizarEntidad), new EventArgs());
        }
        #endregion

        #endregion

        #region Labels, txtBox y numericUpDown
        private void lblLupa_Click(object sender, EventArgs e)
        {
            if(txtDescripcionParcial_Leave())
            {
                List<ModeloArticuloProveedores> lcl_lst_articulosProveedoresEncontrados = this.buscarArticuloProveedor();
                if (lcl_lst_articulosProveedoresEncontrados != null)
                {
                    if (lcl_lst_articulosProveedoresEncontrados.Count > 0)
                    {
                        this.cargarArticulosProveedoresEncontradosEnControles(lcl_lst_articulosProveedoresEncontrados);
                    }
                    else
                    {
                        MessageBox.Show("No se encontraron coincidencias.", "Resultado Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
        }
        private void txtDescripcionParcial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.lblLupa_Click(sender, e);
            }
        }
        private void nmrcUpDownCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.agregarArticuloProveedorAPedido();
            }

            // solo 0-9 y borrar 
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8))
            {
                e.Handled = true;
                return;
            }
        }
        #endregion 

        private void frmPedidoNuevo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (continuarPedido)
            {
                e.Cancel = false;
                return;
            }
            DialogResult lcl_dialogResult = MessageBox.Show("¿Desea cerrar la ventana actual?", "Confirmación", MessageBoxButtons.YesNo);
            if (lcl_dialogResult == DialogResult.Yes)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Ignore;
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        #endregion                   

        private bool txtDescripcionParcial_Leave()
        {
            bool respuesta = Validar.validarInputNoNumerico(txtDescripcionParcial.Text.ToString(), Constantes.ParametrosBusqueda.Articulos.Descripcion);
            if (!respuesta)
            {
                epDescripcionParcial.Icon = Properties.Resources.error;
                epDescripcionParcial.SetError(txtDescripcionParcial, "Descripción parcial no válida");
            }
            else
            {
                epDescripcionParcial.Icon = Properties.Resources.success;
                epDescripcionParcial.SetError(txtDescripcionParcial, "OK");
            }
            return respuesta;
        }
    }
}
