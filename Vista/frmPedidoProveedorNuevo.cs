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
    public partial class frmPedidoProveedorNuevo : Form
    {

        //TODO -> carga y selección de razon social
        // ver method stubs de controladorpedidoproveedor y fmrpedidoproveedorcierre

        private string glb_searchCategory;
        private List<ModeloArticuloProveedores> glb_lst_mod_foundArticles;
        private List<ModeloLineaPedido> glb_lst_mod_currentOrder;
        private ModeloArticuloProveedores glb_mod_selectedArticleFromSearch;
        private ModeloLineaPedido glb_mod_selectedArticleFromDetails;
        private ControladorPedidoProveedor glb_con_pedidoProveedor;
        
        public frmPedidoProveedorNuevo()
        {
            InitializeComponent();

            //instancio controlador
            glb_con_pedidoProveedor = new ControladorPedidoProveedor();
            glb_con_pedidoProveedor.InstanciarPedido();

            //seteo columnas de datagridviews
            this.dgvArticulosAgregar.AutoGenerateColumns = false;
            this.dgvDetalleAgregados.AutoGenerateColumns = false;

            //Creo lista categorias
            var dataSource = new List<Categ>();
            dataSource.Add(new Categ() { Name = "Seleccione...", Value = null });
            dataSource.Add(new Categ() { Name = "Codigo Original", Value = Constantes.ParametrosBusqueda.ArticulosProveedores.CodigoOriginal });
            dataSource.Add(new Categ() { Name = "Descripción", Value = Constantes.ParametrosBusqueda.ArticulosProveedores.DescripcionArticuloProveedor });
            dataSource.Add(new Categ() { Name = "Codigo Proveedor", Value = Constantes.ParametrosBusqueda.ArticulosProveedores.CodigoArticuloProveedor });

            //Binding de categorias
            this.cmbxCategoriaBuscar.DataSource = dataSource;
            this.cmbxCategoriaBuscar.DisplayMember = "Name";
            this.cmbxCategoriaBuscar.ValueMember = "Value";

            //Lo hago read only
            this.cmbxCategoriaBuscar.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        #region Botones

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            //compruebo que existan articulos para generar venta
            if (this.glb_lst_mod_currentOrder.Count > 0)
            {
                //Se planea eliminar el frmPedidoProveedorCierre y que en este sector se auto impriman pedidos para cada
                //uno de los proveedores paralos que se ingresaron articulos al detalle


                ////creo el formulario y lo muestro
                //frmPedidoProveedorCierre frmCierre = new frmPedidoProveedorCierre();
                //frmCierre.detalleVenta(glb_con_pedidoProveedor);
                //frmCierre.ShowDialog();
                ////checkeo si se cerró la venta
                //if (frmCierre.emitido == true)
                //{
                //    this.Close();
                //}
            }
            else
            {
                MessageBox.Show("No se han seleccionado artículos para la venta actual");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //checkeo que haya un articulo seleccionado
            if (!object.Equals(this.glb_mod_selectedArticleFromSearch, null))
            {
                //TODO -> verificación de nro entero positivo bla bla bla
                //Verifico la cantidad no se encuentre vacía
                if (!string.Equals(this.txtCantidad.Text, ""))
                {
                    //verifico que no exista ya en entre las lineas de pedido
                    if (!glb_con_pedidoProveedor.exists(glb_mod_selectedArticleFromSearch))
                    {
                        //lo agrego al pedido actual
                        glb_con_pedidoProveedor.addToOrder(glb_mod_selectedArticleFromSearch, Int32.Parse(this.txtCantidad.Text));


                        //Actualizo Total
                        this.lblTotalVar.Text = glb_con_pedidoProveedor.getTotal();

                        //rebindeo lista
                        this.glb_lst_mod_currentOrder = glb_con_pedidoProveedor.getCurrentDetails();
                        var bindingList = new BindingList<ModeloLineaPedido>(this.glb_lst_mod_currentOrder);
                        var source = new BindingSource(bindingList, null);
                        this.dgvDetalleAgregados.DataSource = source;

                        //Limpio artselecbusq para manejar el uso del boton en momento equivocado
                        this.glb_mod_selectedArticleFromSearch = null;
                        //Limpio txtbox cantidad
                        this.txtCantidad.Text = "";
                        //Limpio lbls
                        this.cleanLbls();
                    }
                    else
                    {
                        MessageBox.Show("Este artículo ya se encuentra en los detalles del pedido actual");
                        //
                        //Limpio artselecbusq para manejar el uso del boton en momento equivocado
                        this.glb_mod_selectedArticleFromSearch = null;
                        //Limpio txtbox cantidad
                        this.txtCantidad.Text = "";
                        //Limpio lbls
                        this.cleanLbls();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor ingrese cantidad de artículo");
                }

            }
            else
            {
                MessageBox.Show("Por favor seleccione un articulo a agregar de la grilla de busqueda");
            }
        }

        private void btnBorrarPedActual_Click(object sender, EventArgs e)
        {
            //solicito confirmación
            DialogResult dialogResult = MessageBox.Show("¿Realmente desea borrar el detalle actual?", "Confirmación", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //borro la venta actual
                glb_con_pedidoProveedor.deleteCurrentDetails();
                this.glb_lst_mod_currentOrder = glb_con_pedidoProveedor.getCurrentDetails();

                //rebindeo grilla detalles
                this.dgvDetalleAgregados.DataSource = null;

                //se limpian las lbls
                cleanLbls();
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            //checkeo que haya un articulo seleccionado
            if (!object.Equals(this.glb_mod_selectedArticleFromDetails, null))
            {
                //lo elimino de la lista de articulos ya seleccionados
                glb_con_pedidoProveedor.removeFromOrder(this.glb_mod_selectedArticleFromDetails);
                this.glb_lst_mod_currentOrder = glb_con_pedidoProveedor.getCurrentDetails();

                //Actualizo Total
                this.lblTotalVar.Text = glb_con_pedidoProveedor.getTotal();

                //rebindeo los articulos seleccionados a la grid
                var bindingList = new BindingList<ModeloLineaPedido>(this.glb_lst_mod_currentOrder);
                var source = new BindingSource(bindingList, null);
                this.dgvDetalleAgregados.DataSource = source;

                //
                //Limpio artselecdetalle para evitar uso de boton en momento equivocado
                this.glb_mod_selectedArticleFromDetails = null;
            }
            else
            {
                MessageBox.Show("Por favor seleccione un articulo a eliminar de la grilla de detalles");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //solicito confirmación
            DialogResult dialogResult = MessageBox.Show("¿Realmente desea cancelar el Pedido?", "Confirmación", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        #endregion

        #region DataGridViews
        private void dgvArtAgregar_Enter(object sender, EventArgs e)
        {
            //Limpio artselecdetalle para manejar el uso del boton en momento equivocado
            this.glb_mod_selectedArticleFromDetails = null;
        }

        private void dgvArtAgregar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //busco el indice de la fila seleccionada que coincide con la lista que contiene mayor cantidad de información
            int indiceSelecc = dgvArticulosAgregar.CurrentCell.RowIndex;

            //asigno el articulo a la variable artSelecBusq en caso de que se decida agregarlo al pedido
            this.glb_mod_selectedArticleFromSearch = glb_lst_mod_foundArticles[indiceSelecc];

            //actualizo lost lbl para mostrar el articulo seleccionado
            this.lblCodOrigVar.Text = glb_lst_mod_foundArticles[indiceSelecc].codigoOriginal;
            this.lblCodProvVar.Text = glb_lst_mod_foundArticles[indiceSelecc].codigoArticuloProveedor;
            this.lblProvVar.Text = glb_lst_mod_foundArticles[indiceSelecc].razonSocialProveedor;
            this.lblDescVar.Text = glb_lst_mod_foundArticles[indiceSelecc].descripcionArticuloProveedor;

            this.lblPrecioVar.Text = Convert.ToString(glb_lst_mod_foundArticles[indiceSelecc].valorVenta.valorArticulo);
            this.lblUbicacionVar.Text = glb_lst_mod_foundArticles[indiceSelecc].ubicacion;

            this.lblExistenciaVar.Text = Convert.ToString(glb_lst_mod_foundArticles[indiceSelecc].stockActual);
            this.lblFechaActualizVar.Text = Convert.ToString(glb_lst_mod_foundArticles[indiceSelecc].fechaActualizacion);
            this.lblObsVar.Text = glb_lst_mod_foundArticles[indiceSelecc].observacionesArticuloProveedor;
        }

        private void dgvDetalleAgregados_Enter(object sender, EventArgs e)
        {
            //Limpio artselecbusq para manejar el uso del boton en momento equivocado
            this.glb_mod_selectedArticleFromSearch = null;
        }

        private void dgvDetalleAgregados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //busco el indice de la fila seleccionada
            int indiceSelecc = this.dgvDetalleAgregados.CurrentCell.RowIndex;

            //asigno el articulo a la variable artSelecDetalle en caso de que se decida removerlo del pedido
            this.glb_mod_selectedArticleFromDetails = this.glb_lst_mod_currentOrder[indiceSelecc];
        }
        #endregion

        #region Labels, txtBod, combos
        private void lblLupa_Click(object sender, EventArgs e)
        {
            //TODO --> VALIDAR EL INPUT
            //
            //capturo descripcion parcial
            string busqArt = this.txtBusqArticulo.Text;

            //me aseguro que se haya seleccionado una categoria de búsqueda
            if (!object.Equals(this.glb_searchCategory, null))
            {
                //busco el/los articulos correspondientes
                glb_lst_mod_foundArticles = glb_con_pedidoProveedor.searchArticles(glb_searchCategory, busqArt);

                //bindeo el datagrid con los articulos encontrados
                if (!object.Equals(glb_lst_mod_foundArticles, null))
                {
                    var bindingList = new BindingList<ModeloArticuloProveedores>(glb_lst_mod_foundArticles);
                    var source = new BindingSource(bindingList, null);
                    this.dgvArticulosAgregar.DataSource = source;
                }
                else
                {
                    MessageBox.Show("No se encontraron coincidencias");
                }
            }
            else
            {
                MessageBox.Show("Por favor seleccione una categoría de búsqueda");
            }
        }

        private void txtBusqArticulo_Enter(object sender, EventArgs e)
        {
            //se limpian los lbls para no generar errores ya que no hay ninguno seleccionado
            cleanLbls();
        }

        private void txtBusqArticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.lblLupa_Click(sender, e);
            }
        }

        private void cmbxCategoriaBuscar_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.glb_searchCategory = (string)this.cmbxCategoriaBuscar.SelectedValue;
        }

        private void cleanLbls()
        {
            this.lblCodOrigVar.Text = "Seleccione Articulo";
            this.lblCodProvVar.Text = "Seleccione Articulo";
            this.lblProvVar.Text = "Seleccione Articulo";
            this.lblDescVar.Text = "Seleccione Articulo";
            this.lblPrecioVar.Text = "Seleccione Articulo";
            this.lblExistenciaVar.Text = "Seleccione Articulo";
            this.lblFechaActualizVar.Text = "Seleccione Articulo";
            this.lblObsVar.Text = "Seleccione Articulo";
            this.lblUbicacionVar.Text = "Seleccione Articulo";
        }
        #endregion
    }
}
