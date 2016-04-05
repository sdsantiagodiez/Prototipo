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
    public partial class frmPedidoNuevo : Form
    {
        #region Atributos
        private ModeloArticuloProveedores glb_mod_articuloSeleccionadoBusqueda;
        private ModeloLineaPedido glb_mod_articuloSeleccionadoDetalle;
        private ControladorPedido glb_con_pedido;
        #endregion

        #region Constructores
        public frmPedidoNuevo()
        {
            InitializeComponent();
            this.inicializarControles();
        }
        public frmPedidoNuevo(Constantes.CodigosTiposPedidos p_codigoTipoPedido) : this()
        {
            glb_con_pedido = new ControladorPedido(p_codigoTipoPedido);
        }
        #endregion
       
        #region Métodos
        #region Inicialización
        public void inicializarControles()
        {
            //seteo columnas de datagridviews
            this.dgvArtAgregar.AutoGenerateColumns = false;
            this.dgvDetalleAgregados.AutoGenerateColumns = false;

            //Creo lista categorias
            var dataSource = new List<ComboBoxItem>();
            dataSource.Add(new ComboBoxItem() { Name = "Seleccione...", Value = null });
            dataSource.Add(new ComboBoxItem() { Name = "Codigo Original", Value = Constantes.ParametrosBusqueda.ArticulosProveedores.CodigoOriginal });
            dataSource.Add(new ComboBoxItem() { Name = "Descripción", Value = Constantes.ParametrosBusqueda.ArticulosProveedores.DescripcionArticuloProveedor });
            dataSource.Add(new ComboBoxItem() { Name = "Codigo Proveedor", Value = Constantes.ParametrosBusqueda.ArticulosProveedores.CodigoArticuloProveedor });

            //Binding de categorias
            this.cbxCategoriaBusqueda.DataSource = dataSource;
            this.cbxCategoriaBusqueda.DisplayMember = "Name";
            this.cbxCategoriaBusqueda.ValueMember = "Value";

            //Lo hago read only
            this.cbxCategoriaBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        #endregion
        #region Validación
        private bool validarAgregarArticulo()
        {
            //checkeo que haya un articulo seleccionado
            if (object.Equals(this.glb_mod_articuloSeleccionadoBusqueda, null))
            {
                MessageBox.Show("Por favor seleccione un articulo a agregar de la grilla de busqueda");
                return false;
            }

            //Verifico la cantidad
            if (string.Equals(this.txtCantidad.Text, "")
                || !LibreriaClasesCompartidas.Validar.validarEnteroPositivoSinCero(this.txtCantidad.Text))
            {
                MessageBox.Show("La cantidad de articulos debe ser un número mayor a cero.");
                return false;
            }

            //verifico stock    //proveedor no valida stock
            if (glb_con_pedido.tipoPedido == Constantes.CodigosTiposPedidos.TipoPedidoPersona
                && this.glb_mod_articuloSeleccionadoBusqueda.stockActual < Int32.Parse(this.txtCantidad.Text))
            {
                MessageBox.Show("No hay suficientes articulos en inventario actual para cubrir el pedido");
                return false;
            }

            //verifico que no exista ya en entre las lineas de pedido
            if (glb_con_pedido.exists(glb_mod_articuloSeleccionadoBusqueda))
            {
                MessageBox.Show("Este artículo ya se encuentra en los detalles del pedido actual");
                //Limpio artselecbusq para manejar el uso del boton en momento equivocado
                this.glb_mod_articuloSeleccionadoBusqueda = null;
                //Limpio txtbox cantidad
                this.txtCantidad.Text = "";
                //Limpio lbls
                this.cleanLbls();
                return false;
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
            //capturo descripcion parcial y me aseguro que sea una entrada válda
            if (!LibreriaClasesCompartidas.Validar.validarAlfanumericoConEspaciosSinCaracteresEspeciales(this.txtDescripcionParcial.Text))
            {
                MessageBox.Show("No se permiten caracteres especiales en la descripción. Por favor ingrésela correctamente");
                return false;
            }
            return true;
        }
        #endregion
        private void cleanLbls()
        {
            this.lblCodigoOriginalVar.Text = this.lblCodigoProveedorVar.Text = this.lblProveedorVar.Text =
            this.lblDescripcionVar.Text = this.lblPrecioVar.Text = this.lblExistenciaVar.Text =
            this.lblFechaActualizacionVar.Text = this.lblObservacionesVar.Text =
            this.lblUbicacionVar.Text = "Seleccione Artículo";
        }
        #endregion

        #region Eventos
        #region Botones
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            //compruebo que existan articulos para generar pedido
            if (glb_con_pedido.getCantidadLineas() > 0)
            {
                //creo el formulario y lo muestro
                Form lcl_frm_cierre;
                if (glb_con_pedido.tipoPedido == Constantes.CodigosTiposPedidos.TipoPedidoPersona)
                {
                    lcl_frm_cierre = new frmPedidoCierre(glb_con_pedido.pedidoActual);
                }
                else if (glb_con_pedido.tipoPedido == Constantes.CodigosTiposPedidos.TipoPedidoProveedor)
                {
                    lcl_frm_cierre = new frmPedidoCierre(glb_con_pedido.pedidoActual);
                }
                else
                {
                    lcl_frm_cierre = new Form();
                }

                lcl_frm_cierre.ShowDialog();
                //checkeo si se cerró el pedido
                //if (lcl_frm_cierre.glb_emitido)
                //{
                //    this.Close();
                //}
            }
            else
            {
                MessageBox.Show("No se han seleccionado artículos para el pedido actual");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.validarAgregarArticulo())
            {
                //lo agrego al pedido actual
                glb_con_pedido.addArticulo(glb_mod_articuloSeleccionadoBusqueda, Int32.Parse(this.txtCantidad.Text));

                //Actualizo Total
                this.lblTotalVar.Text = glb_con_pedido.getTotal();

                //rebindeo lista
                var lcl_bindingList = new BindingList<ModeloLineaPedido>(glb_con_pedido.pedidoActual.lineasPedido);
                var lcl_source = new BindingSource(lcl_bindingList, null);
                this.dgvDetalleAgregados.DataSource = lcl_source;

                //Limpio artselecbusq para manejar el uso del boton en momento equivocado
                this.glb_mod_articuloSeleccionadoBusqueda = null;
                //Limpio txtbox cantidad
                this.txtCantidad.Text = "";
                //Limpio lbls
                this.cleanLbls();
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            //checkeo que haya un articulo seleccionado
            if (!object.Equals(this.glb_mod_articuloSeleccionadoDetalle, null))
            {
                //lo elimino de la lista de articulos ya seleccionados
                glb_con_pedido.removeLineaPedido(this.glb_mod_articuloSeleccionadoDetalle);

                //Actualizo Total
                this.lblTotalVar.Text = glb_con_pedido.getTotal();

                //rebindeo los articulos seleccionados a la grid
                var lcl_bindingList = new BindingList<ModeloLineaPedido>(glb_con_pedido.pedidoActual.lineasPedido);
                var lcl_source = new BindingSource(lcl_bindingList, null);
                this.dgvDetalleAgregados.DataSource = lcl_source;

                //Limpio artselecdetalle para evitar uso de boton en momento equivocado
                this.glb_mod_articuloSeleccionadoDetalle = null;
            }
            else
            {
                MessageBox.Show("Por favor seleccione un articulo a eliminar de la grilla de detalles");
            }
        }

        private void btnBorrarDetActual_Click(object sender, EventArgs e)
        {
            //solicito confirmación
            DialogResult lcl_dialogResult = MessageBox.Show("¿Realmente desea borrar el detalle actual?", "Confirmación", MessageBoxButtons.YesNo);
            if (lcl_dialogResult == DialogResult.Yes)
            {
                //borro la venta actual
                glb_con_pedido.deleteCurrentDetails();

                //rebindeo grilla detalles
                this.dgvDetalleAgregados.DataSource = null;

                //se limpian las lbls
                cleanLbls();
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
        private void dgvArtAgregar_Enter(object sender, EventArgs e)
        {
            //Limpio artselecdetalle para manejar el uso del boton en momento equivocado
            this.glb_mod_articuloSeleccionadoDetalle = null;
        }

        private void dgvDetalleAgregados_Enter(object sender, EventArgs e)
        {
            //Limpio artselecbusq para manejar el uso del boton en momento equivocado
            this.glb_mod_articuloSeleccionadoBusqueda = null;
        }

        private void dgvArtAgregar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //busco el articulo según el indice seleccionado
            var lcl_mod_articulo = glb_con_pedido.getArticuloBusqueda(dgvArtAgregar.CurrentCell.RowIndex);

            //asigno el articulo a la variable articuloSeleccionadoBusqueda en caso de que se decida agregarlo al pedido
            this.glb_mod_articuloSeleccionadoBusqueda = lcl_mod_articulo;

            //actualizo lost lbl para mostrar el articulo seleccionado
            this.lblCodigoOriginalVar.Text = lcl_mod_articulo.codigoOriginal;
            this.lblCodigoProveedorVar.Text = lcl_mod_articulo.codigoArticuloProveedor;
            this.lblProveedorVar.Text = lcl_mod_articulo.razonSocialProveedor;
            this.lblDescripcionVar.Text = lcl_mod_articulo.descripcionArticuloProveedor;
            //
            //TODO modificadores de precio segun metodo de pago
            if (glb_con_pedido.tipoPedido == Constantes.CodigosTiposPedidos.TipoPedidoPersona)
            {
                this.lblPrecioVar.Text = Convert.ToString(lcl_mod_articulo.valorVenta.valorArticulo);
            }
            else if (glb_con_pedido.tipoPedido == Constantes.CodigosTiposPedidos.TipoPedidoProveedor)
            {
                this.lblPrecioVar.Text = Convert.ToString(lcl_mod_articulo.valorCompra.valorArticulo);
            }
            this.lblUbicacionVar.Text = lcl_mod_articulo.ubicacion;

            this.lblExistenciaVar.Text = Convert.ToString(lcl_mod_articulo.stockActual);
            this.lblFechaActualizacionVar.Text = Convert.ToString(lcl_mod_articulo.fechaActualizacion);
            this.lblObservacionesVar.Text = lcl_mod_articulo.observacionesArticuloProveedor;
            
            this.nmrcUpDownCantidad.Maximum = lcl_mod_articulo.stockActual.Value;
        }

        private void dgvDetalleAgregados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //asigno el articulo a la variable articulosSeleccionadosDetalle en caso de que se decida removerlo del pedido
            this.glb_mod_articuloSeleccionadoDetalle = glb_con_pedido.getArticulo(this.dgvDetalleAgregados.CurrentCell.RowIndex);
        }
        #endregion

        #region Labels, txtBox y Combos
        private void lblLupa_Click(object sender, EventArgs e)
        {
            if (!this.validarBusqueda())
            {
                return ;
            }
            
            //busco el/los articulos correspondientes y me fijo que se hayan encontrado artículos
            if (glb_con_pedido.buscarArticulos((string)this.cbxCategoriaBusqueda.SelectedValue, this.txtDescripcionParcial.Text) > 0)
            {
                //bindeo el datagrid con los articulos encontrados
                var lcl_bindingList = new BindingList<ModeloArticuloProveedores>(glb_con_pedido.resultadoBusqueda);
                var lcl_source = new BindingSource(lcl_bindingList, null);
                this.dgvArtAgregar.DataSource = lcl_source;
            }
            else
            {
                MessageBox.Show("No se encontraron coincidencias");
            }
        }

        private void txtBusqArticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.lblLupa_Click(sender, e);
            }
        }

        private void txtBusqArticulo_Enter(object sender, EventArgs e)
        {
            //se limpian los lbls para no generar errores ya que no hay ninguno seleccionado
            cleanLbls();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.btnAgregar_Click(sender, e);
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
