﻿using System;
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
    public partial class frmPedidoNuevo : Form
    {
        #region Atributos
        ModeloArticuloProveedores glb_mod_articuloSeleccionadoBusqueda;
        ControladorPedido controlador;
        ContextMenu cntxMenuResultadoBusqueda;
        ContextMenu cntxMenuLineasPedidos;
        #endregion

        #region Constructores
        public frmPedidoNuevo()
        {
            InitializeComponent();
            this.inicializarControles();
        }
        public frmPedidoNuevo(Constantes.CodigosTiposPedidos p_codigoTipoPedido) : this()
        {
            controlador = new ControladorPedido(p_codigoTipoPedido);
        }
        #endregion
       
        #region Métodos
        #region Inicialización
        public void inicializarControles()
        {
            this.dgvArticulosResultadoBusqueda.MultiSelect = false;
            //seteo columnas de datagridviews
            this.dgvArticulosResultadoBusqueda.AutoGenerateColumns = false;
            this.dgvArticulosEnPedido.AutoGenerateColumns = false;
            
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
            cntxMenuResultadoBusqueda.MenuItems.Add("Agregar 1");
            cntxMenuResultadoBusqueda.MenuItems[0].Click += (s,e)=>
            {
                this.agregarLineaPedidoAPedido(glb_mod_articuloSeleccionadoBusqueda,1, this.chckBoxPermitirStockNegativo.Checked);
            };
            cntxMenuResultadoBusqueda.MenuItems.Add("Agregar 2");
            cntxMenuResultadoBusqueda.MenuItems[1].Click += (s,e)=>
            {
                this.agregarLineaPedidoAPedido(glb_mod_articuloSeleccionadoBusqueda,2, this.chckBoxPermitirStockNegativo.Checked);
            };
            cntxMenuResultadoBusqueda.MenuItems.Add("Agregar 5");
            cntxMenuResultadoBusqueda.MenuItems[2].Click += (s,e)=>
            {
                this.agregarLineaPedidoAPedido(glb_mod_articuloSeleccionadoBusqueda,5, this.chckBoxPermitirStockNegativo.Checked);
            };
            cntxMenuResultadoBusqueda.MenuItems.Add("Agregar 10");
            cntxMenuResultadoBusqueda.MenuItems[3].Click += (s, e) =>
            {
                this.agregarLineaPedidoAPedido(glb_mod_articuloSeleccionadoBusqueda, 10, this.chckBoxPermitirStockNegativo.Checked);
            };
            cntxMenuLineasPedidos = new ContextMenu();
            
            #endregion

            #region Eventos
            this.btnQuitar.Click += evento_eliminarArticuloProveedorDePedido;
            this.btnAgregar.Click += evento_agregarArticuloProveedorEnPedido;
            this.btnBorrarDetalleActual.Click += evento_eliminarArticuloProveedorDePedidoTodos;
            #endregion
        }
        #endregion
        #region Validación
        /// <summary>
        /// Informa de acuerdo a los parámetros del pedido si el artículo puede ser agregado
        /// </summary>
        /// <returns></returns>
        private bool validarAgregarArticulo()
        {
            //checkeo que haya un articulo seleccionado
            if (object.Equals(this.glb_mod_articuloSeleccionadoBusqueda, null))
            {
                MessageBox.Show("Por favor seleccione un articulo a agregar de la grilla de busqueda");
                return false;
            }

            //Verifico la cantidad
            if (!LibreriaClasesCompartidas.Validar.validarEnteroPositivoSinCero(this.nmrcUpDownCantidad.Value.ToString()))
            {
                MessageBox.Show("La cantidad de articulos debe ser un número mayor a cero.");
                return false;
            }

            //verifico stock    //proveedor no valida stock
            if (controlador.tipoPedido == Constantes.CodigosTiposPedidos.TipoPedidoPersona
                && this.glb_mod_articuloSeleccionadoBusqueda.stockActual < Convert.ToInt32(this.nmrcUpDownCantidad.Value)
                && !this.chckBoxPermitirStockNegativo.Checked)
            {
                MessageBox.Show("No hay suficientes articulos en inventario actual para cubrir el pedido");
                return false;
            }

            //verifico que no exista ya en entre las lineas de pedido
            if (controlador.exists(glb_mod_articuloSeleccionadoBusqueda))
            {
                ModeloLineaPedido lpExistente = controlador.pedidoActual.lineasPedido.SingleOrDefault
                                                                    (x => x.articulo.codigoOriginal == glb_mod_articuloSeleccionadoBusqueda.codigoOriginal
                                                                        && x.articulo.codigoArticuloProveedor == glb_mod_articuloSeleccionadoBusqueda.codigoArticuloProveedor);
                if (!this.chckBoxPermitirStockNegativo.Checked)
                {
                    int cantidadTotal = lpExistente.cantidadArticulos + Convert.ToInt32(this.nmrcUpDownCantidad.Value);
                    if (cantidadTotal > glb_mod_articuloSeleccionadoBusqueda.stockActual)
                    {
                        MessageBox.Show("No hay suficientes articulos en inventario actual para cubrir el pedido");
                        return false;
                    }
                }
            }
            
            return true;
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
            if (controlador.tipoPedido == Constantes.CodigosTiposPedidos.TipoPedidoPersona)
            {
                this.lblPrecioVar.Text = Convert.ToString(p_mod_articuloProveedor.valorVenta.valorArticulo);
            }
            else if (controlador.tipoPedido == Constantes.CodigosTiposPedidos.TipoPedidoProveedor)
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
            this.lblTotalVar.Text = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}", controlador.pedidoActual.montoTotal);

            this.dgvArticulosEnPedido.DataSource = null;
            this.dgvArticulosEnPedido.DataSource = controlador.pedidoActual.lineasPedido;

            //this.nmrcUpDownCantidad.Value = 0;
            //this.cleanLbls();
        }
        #endregion

        private void cleanLbls()
        {
            this.lblCodigoOriginalVar.Text = this.lblCodigoProveedorVar.Text = this.lblProveedorVar.Text =
            this.lblDescripcionVar.Text = this.lblPrecioVar.Text = this.lblExistenciaVar.Text =
            this.lblFechaActualizacionVar.Text = this.lblObservacionesVar.Text =
            this.lblUbicacionVar.Text = "Seleccione Artículo";
        }

        private void agregarLineaPedidoAPedido(ModeloArticuloProveedores p_mod_articuloProveedor, int p_cantidad, bool p_permitirStockNegativo)
        {
            this.nmrcUpDownCantidad.Value = p_cantidad;
            if (this.validarAgregarArticulo())
            {
                //verifico que no exista ya en entre las lineas de pedido
                if (controlador.exists(p_mod_articuloProveedor))
                {
                    ModeloLineaPedido lpExistente = controlador.pedidoActual.lineasPedido.SingleOrDefault
                                                                        (x => x.articulo.codigoOriginal == p_mod_articuloProveedor.codigoOriginal
                                                                            && x.articulo.codigoArticuloProveedor == p_mod_articuloProveedor.codigoArticuloProveedor);

                    lpExistente.cantidadArticulos += p_cantidad;
                }
                else
                {
                    //Agrego línea y especifico si permite stock negativo
                    controlador.addArticulo(p_mod_articuloProveedor, p_cantidad);
                    controlador.pedidoActual.lineasPedido[controlador.pedidoActual.lineasPedido.Count - 1].permitirStockNegativo = p_permitirStockNegativo;
                }
                this.cargarLineasPedidosEnControles();
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
        #endregion

        #region Eventos
        /// <summary>
        /// Agrega línea de pedido al pedido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void evento_agregarArticuloProveedorEnPedido(object sender, EventArgs e)
        {
            this.agregarLineaPedidoAPedido(glb_mod_articuloSeleccionadoBusqueda, Convert.ToInt32(this.nmrcUpDownCantidad.Value), this.chckBoxPermitirStockNegativo.Checked);
        }
        /// <summary>
        /// Elimina las líneas seleccionadas del pedido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void evento_eliminarArticuloProveedorDePedido(object sender, EventArgs e)
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
        /// Elimina todas las líneas del pedido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void evento_eliminarArticuloProveedorDePedidoTodos(object sender, EventArgs e)
        {
            DialogResult lcl_dialogResult = MessageBox.Show("¿Realmente desea borrar el detalle actual?", "Confirmación", MessageBoxButtons.YesNo);
            if (lcl_dialogResult == DialogResult.Yes)
            {
                controlador.removeLineasPedidos();
                this.dgvArticulosEnPedido.DataSource = null;
                //cleanLbls();
            }
        }
       
        #region Botones
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            //compruebo que existan articulos para generar pedido
            if (controlador.getCantidadLineas() > 0)
            {
                //creo el formulario y lo muestro
                Form lcl_frm_cierre;
                if (controlador.tipoPedido == Constantes.CodigosTiposPedidos.TipoPedidoPersona)
                {
                    lcl_frm_cierre = new frmPedidoCierre(controlador.pedidoActual);
                }
                else if (controlador.tipoPedido == Constantes.CodigosTiposPedidos.TipoPedidoProveedor)
                {
                    lcl_frm_cierre = new frmPedidoCierre(controlador.pedidoActual);
                }
                else
                {
                    lcl_frm_cierre = new Form();
                }

                lcl_frm_cierre.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se han seleccionado artículos para el pedido actual");
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //solicito confirmación
            DialogResult lcl_dialogResult = MessageBox.Show("¿Realmente desea cancelar el pedido?", "Confirmación", MessageBoxButtons.YesNo);
            if (lcl_dialogResult == DialogResult.Yes)
            {
                this.Close();
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
                    //this.actualizarContextMenuStrip();
                    this.cntxMenuResultadoBusqueda.Show(dgvArticulosResultadoBusqueda, new Point(e.X, e.Y));
                }
            }
        }
        #endregion
        #region Artículos agregados a pedido
        #endregion

        #endregion

        #region Labels, txtBox y numericUpDown
        private void lblLupa_Click(object sender, EventArgs e)
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
                    MessageBox.Show("No se encontraron coincidencias");
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
                this.evento_agregarArticuloProveedorEnPedido(sender, e);
            }

            // solo 0-9 y borrar 
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8))
            {
                e.Handled = true;
                return;
            }
        }
        #endregion 

        #endregion           
    }
}
