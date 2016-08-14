using System;
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
    public partial class frmPedidoDevolucion : frmMaterialSkinBase
    {
        #region Atributos
        public EventHandler IniciarDevolucionPedido;
        public EventHandler ContinuarDevolucionPedido;
        public ModeloPedido glb_mod_pedidoOriginal;
        ModeloLineaPedido glb_mod_lineaPedidoActual;
        public ControladorPedido controlador;
        private bool glb_respuesta = false;
        ContextMenu cntxMenuResultadoBusqueda;
        ContextMenu cntxMenuLineasPedidos;
        //se usa para evitar mostrar mensaje de confirmación cuando se cierra la ventana y se selecciona continuar
        bool continuarDevolucion;
        #endregion
        
        #region Constructores
        /// <summary>
        /// Inicializa controles del formulario
        /// </summary>
        public frmPedidoDevolucion()
        {
            InitializeComponent();
            
            this.StartPosition = FormStartPosition.CenterScreen;
            dgvArticulosPedido.EnableHeadersVisualStyles = false;
            dgvArticulosPedido.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvArticulosDevolucion.EnableHeadersVisualStyles = false;
            dgvArticulosDevolucion.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            this.inicializarControles();
            this.controlador = new ControladorPedido(Constantes.CodigosTiposPedidos.Persona);
        }
        /// <summary>
        /// Inicializa pedido del que se extraerán artículos a devolución
        /// </summary>
        /// <param name="p_mod_pedido"></param>
        public frmPedidoDevolucion(ModeloPedido p_mod_pedido) :this()
        {
            this.inicializarPedidoOriginal(p_mod_pedido);
            this.continuarDevolucion = true;
        }
        /// <summary>
        /// Inicializa pedido del que se extraerán artículos a devolución y pedido con artículos a devolver
        /// </summary>
        /// <param name="p_mod_pedidoOriginal">Pedido del que se extraerán artículos a devolver</param>
        /// <param name="p_mod_pedidoDevolucion">Pedido con artículos que serán devueltos</param>
        public frmPedidoDevolucion(ModeloPedido p_mod_pedidoOriginal,ModeloPedido p_mod_pedidoDevolucion) : this(p_mod_pedidoOriginal)
        {
            controlador.pedidoActual = p_mod_pedidoDevolucion;
            this.cargarPedidoDevolucionEnControles(controlador.pedidoActual);
            this.tblLayoutPanelCuadroBusqueda.Enabled = false;
            this.btnSiguiente.Text = "Guardar Cambios";
        }
        #endregion
        
        #region Métodos
        #region Inicialización
        public override void inicializarForm(int ventanaAncho, int ventanaAlto)
        {
            this.tblLayoutPanelPrincipal.Width = ventanaAncho - 20; //un margen derecho de 20 para que se vea scrollbar
            this.pnlBase.Width = ventanaAncho - 3;  //un márgen derecho de 3
            this.pnlBase.Height = ventanaAlto - 60; //un márgen arriba para que se vea título
            if (pnlBase.Height < 600)
            {
                this.tblLayoutPanelPrincipal.Height = 600;  //Mínimo

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
            #region DataGridView
            //dgvArticulosPedido
            //Cambiar a multiSelect
            this.dgvArticulosPedido.MultiSelect = false;
            this.dgvArticulosPedido.AutoGenerateColumns = false;
            //dgvArticulosDevolucion
            this.dgvArticulosDevolucion.AutoGenerateColumns = false;
            #endregion

            #region ContextMenu
            cntxMenuResultadoBusqueda = new ContextMenu();
            cntxMenuResultadoBusqueda.MenuItems.Add("Agregar 1");
            cntxMenuResultadoBusqueda.MenuItems[0].Click += (s, e) =>
            {
                this.agregarLineaPedidoADevolucion(1);
            };
            cntxMenuResultadoBusqueda.MenuItems.Add("Agregar 2");
            cntxMenuResultadoBusqueda.MenuItems[1].Click += (s, e) =>
            {
                this.agregarLineaPedidoADevolucion(2);
            };
            cntxMenuResultadoBusqueda.MenuItems.Add("Agregar 5");
            cntxMenuResultadoBusqueda.MenuItems[2].Click += (s, e) =>
            {
                this.agregarLineaPedidoADevolucion(5);
            };
            cntxMenuResultadoBusqueda.MenuItems.Add("Agregar 10");
            cntxMenuResultadoBusqueda.MenuItems[3].Click += (s, e) =>
            {
                this.agregarLineaPedidoADevolucion(10);
            };
            cntxMenuResultadoBusqueda.MenuItems.Add("Agregar Línea Completa");
            cntxMenuResultadoBusqueda.MenuItems[4].Click += (s, e) =>
            {
                this.agregarLineaPedidoADevolucion(this.getMaxCantidadDevolucion());
            };
            cntxMenuResultadoBusqueda.MenuItems.Add("Agregar Pedido Completo");
            cntxMenuResultadoBusqueda.MenuItems[5].Click += (s, e) =>
            {
                this.agregarLineasPedidoTodasADevolucion();
            };

            cntxMenuLineasPedidos = new ContextMenu();
            cntxMenuLineasPedidos.MenuItems.Add("Quitar seleccionado");
            cntxMenuLineasPedidos.MenuItems[0].Click += (s, e) =>
            {
                this.eliminarLineaPedidoADevolucion();
            };
            cntxMenuLineasPedidos.MenuItems.Add("Quitar todos");
            cntxMenuLineasPedidos.MenuItems[1].Click += (s, e) =>
            {
                this.eliminarLineaPedidoADevolucionTodos();
            };
            #endregion

            #region Buttons
            this.btnAgregar.Click += (s,e) =>
                {
                    this.agregarLineaPedidoADevolucion();
                };
            this.btnQuitar.Click += (s,e) =>
                {
                    this.eliminarLineaPedidoADevolucion();
                };
            this.btnQuitarTodos.Click += (s, e) =>
                {
                    this.eliminarLineaPedidoADevolucionTodos();
                };

            #endregion
            
            #region Labels
            this.cleanLbls();
            #endregion
        }
        /// <summary>
        /// Inicializa labels que muestran valores del Artículo seleccionado
        /// </summary>
        private void cleanLbls()
        {
            this.lblCodigoOriginalVar.Text = this.lblCodigoProveedorVar.Text = this.lblProveedorVar.Text =
            this.lblDescripcionVar.Text = this.lblPrecioActualVar.Text = this.lblExistenciaVar.Text =
            this.lblFechaActualizacionVar.Text = this.lblObservacionesVar.Text =
            this.lblUbicacionVar.Text = "Seleccione Artículo";
        }
        private void inicializarLineaPedidoSeleccionada(ModeloLineaPedido p_mod_lineaPedido)
        {
            glb_mod_lineaPedidoActual = p_mod_lineaPedido;
            this.cargarLineaPedidoEnControles(glb_mod_lineaPedidoActual);
            this.nmrcUpDownCantidad.Focus();
            this.nmrcUpDownCantidad.Select(0, this.nmrcUpDownCantidad.Text.Length);
        }
        /// <summary>
        /// Determina que MenuItems mostrar y habilitar del cntxMenuResultadoBusqueda
        /// </summary>
        private void inicializarContextMenuPedidoOriginal()
        {
            int cantidadMaxima = this.getMaxCantidadDevolucion();
            if (cantidadMaxima < 10)
            {
                this.cntxMenuResultadoBusqueda.MenuItems[3].Visible = false;
                if (cantidadMaxima < 5)
                {
                    this.cntxMenuResultadoBusqueda.MenuItems[2].Visible = false;
                    if (cantidadMaxima < 2)
                    {
                        this.cntxMenuResultadoBusqueda.MenuItems[1].Visible = false;
                        if (cantidadMaxima < 1)
                        {
                            this.cntxMenuResultadoBusqueda.MenuItems[0].Visible = false;
                            this.cntxMenuResultadoBusqueda.MenuItems[4].Enabled = false;
                        }
                    }
                }
            }

            if (cantidadMaxima >= 1)
            {
                this.cntxMenuResultadoBusqueda.MenuItems[0].Visible = true;
                this.cntxMenuResultadoBusqueda.MenuItems[4].Enabled = true;
                if (cantidadMaxima >= 2)
                {
                    this.cntxMenuResultadoBusqueda.MenuItems[1].Visible = true;
                    if (cantidadMaxima >= 5)
                    {
                        this.cntxMenuResultadoBusqueda.MenuItems[2].Visible = true;
                        if (cantidadMaxima >= 10)
                        {
                            this.cntxMenuResultadoBusqueda.MenuItems[3].Visible = true;
                        }
                    }
                }
            }
            this.cntxMenuResultadoBusqueda.MenuItems[5].Enabled = !this.getPedidoCompletoIngresado();
        }
        private void inicializarContextMenuPedidoDevolucion()
        {
            if (this.dgvArticulosDevolucion.SelectedRows.Count > 1)
            {
                this.cntxMenuLineasPedidos.MenuItems[0].Text = "Quitar seleccionados";
                if (this.dgvArticulosDevolucion.SelectedRows.Count == this.controlador.pedidoActual.lineasPedido.Count)
                {
                    this.cntxMenuLineasPedidos.MenuItems[0].Visible = false;
                }
                else
                {
                    this.cntxMenuLineasPedidos.MenuItems[0].Visible = true;
                }
            }
            else
            {
                this.cntxMenuLineasPedidos.MenuItems[0].Visible = true;
                this.cntxMenuLineasPedidos.MenuItems[0].Text = "Quitar seleccionado";
            }
        }
        private void inicializarPedidoOriginal(ModeloPedido p_mod_pedido)
        {
            glb_mod_pedidoOriginal = p_mod_pedido;
            this.controlador.pedidoActual = new ModeloPedido(p_mod_pedido);
            this.cargarPedidoEnControles(p_mod_pedido);
        }
        #endregion
        
        #region Validación
        /// <summary>
        /// Valida línea a ser agregada para devolución y muestra mensaje si no es válida
        /// </summary>
        /// <returns></returns>
        private bool validarAgregarLineaPedido(int p_cantidad)
        {
            bool respuesta = true;
            string mensajeError="";
            if (glb_mod_lineaPedidoActual == null)
            {
                mensajeError = "No hay artículo seleccionado para agregar a devolución.";
                respuesta = false;
            }
            else if (p_cantidad > this.getMaxCantidadDevolucion())
            {
                mensajeError = "La cantidad ingresada a devolver no es válida.";
                respuesta = false;
            }
            
            if(!respuesta)
            {
                MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return respuesta;
        }
        #endregion
        
        #region Modelo -> Controles
        /// <summary>
        /// Carga lineas de pedido en datagridview
        /// </summary>
        /// <param name="p_mod_pedido"></param>
        private void cargarPedidoEnControles(ModeloPedido p_mod_pedido)
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
            foreach (ModeloLineaPedido l in p_mod_pedido.lineasPedido)
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
                row["valorParcialSinDescuento"] = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}", l.getValorParcialSinDescuentos());
                row["valorParcialConDescuento"] = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}", l.getValorParcialConDescuento());

                lineas.Rows.Add(row);
            }

            this.cleanLbls();
            this.dgvArticulosPedido.DataSource = lineas;

            this.dgvArticulosPedido.ClearSelection();
            this.glb_mod_lineaPedidoActual = null;

        }
        /// <summary>
        /// Carga artículo proveedor en labels que muestran vista previa del artículo
        /// </summary>
        /// <param name="p_mod_lineaPedido"></param>
        private void cargarArticuloProveedorEnControles(ModeloArticuloProveedores p_mod_articuloProveedor)
        {
            //actualizo lost lbl para mostrar el articulo seleccionado
            this.lblCodigoOriginalVar.Text = p_mod_articuloProveedor.codigoOriginal;
            this.lblCodigoProveedorVar.Text = p_mod_articuloProveedor.codigoArticuloProveedor;
            this.lblProveedorVar.Text = p_mod_articuloProveedor.razonSocialProveedor;
            this.lblDescripcionVar.Text = p_mod_articuloProveedor.descripcionArticuloProveedor;
            this.lblPrecioActualVar.Text = Convert.ToString(p_mod_articuloProveedor.valorVenta.valorArticulo);
            this.lblUbicacionVar.Text = p_mod_articuloProveedor.ubicacion;
            this.lblExistenciaVar.Text = Convert.ToString(p_mod_articuloProveedor.stockActual);
            this.lblFechaActualizacionVar.Text = Convert.ToString(p_mod_articuloProveedor.fechaActualizacion);
            this.lblObservacionesVar.Text = p_mod_articuloProveedor.observacionesArticuloProveedor;
        }
        /// <summary>
        /// Carga datos de la línea para ser visualizados
        /// </summary>
        /// <param name="p_mod_lineaPedido"></param>
        private void cargarLineaPedidoEnControles(ModeloLineaPedido p_mod_lineaPedido)
        {
            this.cargarArticuloProveedorEnControles(p_mod_lineaPedido.articulo);
            this.nmrcUpDownCantidad.Maximum = this.getMaxCantidadDevolucion();
        }
        private void cargarPedidoDevolucionEnControles(ModeloPedido p_mod_pedido)
        {
            this.lblTotalVar.Text = "$ " + String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}", controlador.getTotal());

            DataTable lineas = new DataTable();
            lineas.Columns.Add("indice");
            lineas.Columns.Add("codigoOriginal");
            lineas.Columns.Add("codigoArticuloProveedor");
            lineas.Columns.Add("descripcion");
            lineas.Columns.Add("cantidad");
            lineas.Columns.Add("valorUnitario");
            lineas.Columns.Add("valorParcial");
            int i = 0;
            foreach (ModeloLineaPedido l in p_mod_pedido.lineasPedido)
            {
                var row = lineas.NewRow();
                row["indice"] = i.ToString();
                i++;
                row["codigoOriginal"] = l.articulo.codigoOriginal;
                row["codigoArticuloProveedor"] = l.articulo.codigoArticuloProveedor;
                row["descripcion"] = l.articulo.descripcion;
                row["cantidad"] = l.cantidadArticulos;
                row["valorUnitario"] = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}", l.valorUnitario);
                row["valorParcial"] = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}", l.getValorParcialSinDescuentos());

                lineas.Rows.Add(row);
            }

            this.dgvArticulosDevolucion.DataSource = lineas;
        }
        #endregion
        
        
        /// <summary>
        /// Obtiene cantidad máxima permitida a agregar a devolución para artículo seleccionado
        /// </summary>
        /// <returns></returns>
        private int getMaxCantidadDevolucion()
        {
            ModeloLineaPedido lcl_mod_lineaPedido = controlador.pedidoActual.getLineaPedido(glb_mod_lineaPedidoActual.articulo);
            if (lcl_mod_lineaPedido != null)
            {
                //Si ya se agrego artículo a devolución, pero se vuelve a seleccionar, se setea como máxima la diferencia entre la cantidad del pedido
                //y la cantidad que ya se puso para devolver
                return glb_mod_lineaPedidoActual.cantidadArticulos - lcl_mod_lineaPedido.cantidadArticulos;
            }
            else
            {
                return glb_mod_lineaPedidoActual.cantidadArticulos;
            }
        }
        /// <summary>
        /// Informa si todos los artículos del pedido original han sido seleccionados para devolución
        /// </summary>
        /// <returns></returns>
        private bool getPedidoCompletoIngresado()
        {
            foreach (ModeloLineaPedido lp in glb_mod_pedidoOriginal.lineasPedido)
            {
                ModeloLineaPedido lp_devolucion = controlador.pedidoActual.getLineaPedido(lp.articulo);
                if (lp_devolucion != null)
                {
                    if (lp_devolucion.cantidadArticulos != lp.cantidadArticulos)
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Carga lineaPedido en datagrid y controlador para devolución de acuerdo a valor en nmrUpDownCantidad
        /// </summary>
        /// <param name="p_mod_lineaPedido"></param>
        private void agregarLineaPedidoADevolucion()
        {
            this.agregarLineaPedidoADevolucion(Convert.ToInt32(nmrcUpDownCantidad.Value));
        }
        /// <summary>
        /// Carga lineaPedido en datagrid y controlador para devolución de acuerdo a valor en parámetro
        /// </summary>
        /// <param name="p_cantidad">Cantidad de artículos a agregar</param>
        private void agregarLineaPedidoADevolucion(int p_cantidad)
        {
            ModeloLineaPedido lcl_mod_lineaPedido = ObjectCopier.Clone(glb_mod_lineaPedidoActual);
            if (this.validarAgregarLineaPedido(p_cantidad))
            {
                lcl_mod_lineaPedido.cantidadArticulos = p_cantidad;

                this.controlador.pedidoActual.addLineaPedido(lcl_mod_lineaPedido);
                this.cargarPedidoDevolucionEnControles(controlador.pedidoActual);
            }
        }
        /// <summary>
        /// Agrega todas las líneas del pedido a pedido devolución
        /// </summary>
        private void agregarLineasPedidoTodasADevolucion()
        {
            foreach (ModeloLineaPedido lp in glb_mod_pedidoOriginal.lineasPedido)
            {
                this.glb_mod_lineaPedidoActual = lp;
                this.agregarLineaPedidoADevolucion(this.getMaxCantidadDevolucion());
            }
        }
        /// <summary>
        /// Elimina todas las líneas seleccionadas en datagridview del pedido devolución actual
        /// </summary>
        private void eliminarLineaPedidoADevolucion()
        {
            List<ModeloLineaPedido> lcl_lst_lineasPedidosEliminar = new List<ModeloLineaPedido>();
            int i;
            string detallesArticulos = "";
            foreach (DataGridViewRow row in this.dgvArticulosDevolucion.SelectedRows)
            {
                //i = Convert.ToInt32(row.Index);
                lcl_lst_lineasPedidosEliminar.Add(controlador.pedidoActual.lineasPedido[row.Index]);

                i = lcl_lst_lineasPedidosEliminar.Count - 1;
                detallesArticulos += Environment.NewLine + "- " + lcl_lst_lineasPedidosEliminar[i].articulo.descripcionArticuloProveedor + " (" + lcl_lst_lineasPedidosEliminar[i].articulo.codigoArticuloProveedor + ")";
            }

            if (lcl_lst_lineasPedidosEliminar.Count < 1)
            {
                MessageBox.Show("No hay artículo seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (lcl_lst_lineasPedidosEliminar.Count == this.dgvArticulosDevolucion.RowCount)
            {
                this.eliminarLineaPedidoADevolucionTodos();
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
                this.cargarPedidoDevolucionEnControles(controlador.pedidoActual);
            }
        }
        /// <summary>
        /// Elimina todas las líneas del pedido devolución actual
        /// </summary>
        private void eliminarLineaPedidoADevolucionTodos()
        {
            DialogResult lcl_dialogResult = MessageBox.Show("¿Está seguro que desea eliminar todos los artículos agregados?", "Confirmación", MessageBoxButtons.YesNo);
            if (lcl_dialogResult == DialogResult.Yes)
            {
                controlador.removeLineasPedidos();
                this.dgvArticulosDevolucion.DataSource = null;
                //cleanLbls();
                this.cargarPedidoDevolucionEnControles(controlador.pedidoActual);
            }
        }
        #endregion

        #region Eventos
        private void lblLupa_Click(object sender, EventArgs e)
        {
            txtCAE_Leave(sender, e);
            if (glb_respuesta)
            {
                //Buscar Pedido por CAE
            ModeloPedido lcl_mod_pedido = ControladorBusqueda.getOne(new ModeloPedido() { CAE = this.txtCAE.Text}, Constantes.ParametrosBusqueda.Pedidos.CAE);

            if (lcl_mod_pedido != null)
            {
                this.inicializarPedidoOriginal(lcl_mod_pedido);
            }
            else
            {
                MessageBox.Show("No se encontraron coincidencias.","Resultado Búsqueda",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            }
            }
        }

        private void txtCAE_KeyPress(object sender, KeyPressEventArgs e)
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
                this.agregarLineaPedidoADevolucion();
            }

            // solo 0-9 y borrar 
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8))
            {
                e.Handled = true;
                return;
            }
        }

        private void dgvArticulosPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                //No hay fila seleccionada
                return;
            }
            int i = Convert.ToInt32(this.dgvArticulosPedido.Rows[e.RowIndex].Cells["indice"].Value);
            
            inicializarLineaPedidoSeleccionada(glb_mod_pedidoOriginal.lineasPedido[i]);
        }
        private void dgvArticulosPedido_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                int currentMouseOverRow = this.dgvArticulosPedido.HitTest(e.X, e.Y).RowIndex;
                if (currentMouseOverRow >= 0)
                {
                    if ((ModifierKeys & Keys.Control) != Keys.Control
                        && this.dgvArticulosPedido.Rows[currentMouseOverRow].Selected != true)
                    {//si selected == true significa que puede haber más elementos seleccionados anteriormente y no hay que perder selección
                        this.dgvArticulosPedido.ClearSelection();
                    }
                    this.dgvArticulosPedido.Rows[currentMouseOverRow].Selected = true;
                    int i = Convert.ToInt32(this.dgvArticulosPedido.Rows[currentMouseOverRow].Cells["indice"].Value);
                    //asigno el articulo a la variable articuloSeleccionadoBusqueda en caso de que se decida agregarlo al pedido
                    inicializarLineaPedidoSeleccionada(glb_mod_pedidoOriginal.lineasPedido[i]);
                    this.inicializarContextMenuPedidoOriginal();
                    this.cntxMenuResultadoBusqueda.Show(this.dgvArticulosPedido, new Point(e.X, e.Y));
                }
            }
        }

        private void dgvArticulosDevolucion_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                int currentMouseOverRow = this.dgvArticulosDevolucion.HitTest(e.X, e.Y).RowIndex;
                if (currentMouseOverRow >= 0)
                {
                    if ((ModifierKeys & Keys.Control) != Keys.Control
                        && this.dgvArticulosDevolucion.Rows[currentMouseOverRow].Selected != true)
                    {//si selected == true significa que puede haber más elementos seleccionados anteriormente y no hay que perder selección
                        this.dgvArticulosDevolucion.ClearSelection();
                    }
                    this.dgvArticulosDevolucion.Rows[currentMouseOverRow].Selected = true;
                    //int i = Convert.ToInt32(this.dgvArticulosEnPedido.Rows[currentMouseOverRow].Cells["indice"].Value);

                    int i = this.dgvArticulosDevolucion.SelectedRows[0].Index;
                    this.inicializarLineaPedidoSeleccionada(controlador.pedidoActual.lineasPedido[i]);
                    this.inicializarContextMenuPedidoDevolucion();
                    this.cntxMenuLineasPedidos.Show(this.dgvArticulosDevolucion, new Point(e.X, e.Y));
                }
            }
        }
        private void dgvArticulosDevolucion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                //No hay fila seleccionada
                return;
            }
            int i = Convert.ToInt32(this.dgvArticulosDevolucion.Rows[e.RowIndex].Cells["indice_dgvDevolucion"].Value);

            inicializarLineaPedidoSeleccionada(controlador.pedidoActual.lineasPedido[i]);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            //compruebo que existan articulos para generar pedido
            if (controlador.getCantidadLineas() > 0)
            {
                if (!continuarDevolucion)
                {
                    this.IniciarDevolucionPedido(this, e);
                }
                else
                {
                    this.ContinuarDevolucionPedido(this, e);
                }

            }
            else
            {
                MessageBox.Show("No se han seleccionado artículos para el pedido actual");
            }
        }

        private void frmPedidoDevolucion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (continuarDevolucion)
            {
                e.Cancel = false;
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                return;
            }
            DialogResult lcl_dialogResult = MessageBox.Show("¿Desea cerrar la ventana actual?", "Confirmación", MessageBoxButtons.YesNo);
            if (lcl_dialogResult == DialogResult.Yes)
            {
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                e.Cancel = false;
            }
            else
            {
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                e.Cancel = true;
            }
        }
        #endregion   

        private void txtCAE_Leave(object sender, EventArgs e)
        {
            glb_respuesta = Validar.validarInputNoNumerico(txtCAE.Text.ToString(), Constantes.ParametrosBusqueda.Pedidos.CAE);
            if (!glb_respuesta)
            {
                epCAE.Icon = Properties.Resources.error;
                epCAE.SetError(txtCAE, "CAE No Válido");
            }
            else
            {
                epCAE.Icon = Properties.Resources.success;
                epCAE.SetError(txtCAE, "OK");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.Close();
        }
    }
}
