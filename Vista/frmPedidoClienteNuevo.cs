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
    public partial class frmPedidoClienteNuevo : Form
    {
        private string glb_categoriaBusquedaSeleccionada;
        private ModeloArticuloProveedores glb_mod_articuloSeleccionadoBusqueda;
        private ModeloLineaPedido glb_mod_articuloSeleccionadoDetalle;
        private ControladorProcesarVenta glb_con_ProcesarVenta;

        public frmPedidoClienteNuevo()
        {
            InitializeComponent();
            //creo la venta
            glb_con_ProcesarVenta = new ControladorProcesarVenta();
            glb_con_ProcesarVenta.crearPedido();

            //seteo columnas de datagridviews
            this.dgvArtAgregar.AutoGenerateColumns = false;
            this.dgvDetalleAgregados.AutoGenerateColumns = false;
            
            //Creo lista categorias
            var dataSource = new List<Categ>();
            dataSource.Add(new Categ() { Name = "Seleccione...", Value = null });
            dataSource.Add(new Categ() { Name = "Codigo Original", Value = Constantes.ParametrosBusqueda.ArticulosProveedores.CodigoOriginal });
            dataSource.Add(new Categ() { Name = "Descripción", Value = Constantes.ParametrosBusqueda.ArticulosProveedores.DescripcionArticuloProveedor });
            dataSource.Add(new Categ() { Name = "Codigo Proveedor", Value = Constantes.ParametrosBusqueda.ArticulosProveedores.CodigoArticuloProveedor });

            //Binding de categorias
            this.cbxCategoriaBusqueda.DataSource = dataSource;
            this.cbxCategoriaBusqueda.DisplayMember = "Name";
            this.cbxCategoriaBusqueda.ValueMember = "Value";

            //Lo hago read only
            this.cbxCategoriaBusqueda.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        #region Botones
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            //compruebo que existan articulos para generar venta
            if (glb_con_ProcesarVenta.getCantidadVentaActual() > 0)
            {
                //creo el formulario y lo muestro
                frmPedidoClienteCierre lcl_frm_Cierre = new frmPedidoClienteCierre();
                lcl_frm_Cierre.controladorEnUso(glb_con_ProcesarVenta);
                lcl_frm_Cierre.ShowDialog();
                //checkeo si se cerró la venta
                if (lcl_frm_Cierre.glb_emitido==true)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("No se han seleccionado artículos para la venta actual");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //checkeo que haya un articulo seleccionado
            if (object.Equals(this.glb_mod_articuloSeleccionadoBusqueda, null))
            {
                MessageBox.Show("Por favor seleccione un articulo a agregar de la grilla de busqueda");
                return;
            }

            //Verifico la cantidad
            if (string.Equals(this.txtCantidad.Text, "")  
                || !LibreriaClasesCompartidas.Validar.validarEnteroPositivoSinCero(this.txtCantidad.Text))
            {
                MessageBox.Show("La cantidad de articulos debe ser un número mayor a cero.");
                return;
            }

            //verifico stock
            if (this.glb_mod_articuloSeleccionadoBusqueda.stockActual < Int32.Parse(this.txtCantidad.Text))
            {
                MessageBox.Show("No hay suficientes articulos en inventario actual para cubrir el pedido");
                return;
            }  

            //verifico que no exista ya en entre las lineas de pedido
            if (glb_con_ProcesarVenta.exists(glb_mod_articuloSeleccionadoBusqueda))
            {
                MessageBox.Show("Este artículo ya se encuentra en los detalles de la venta actual");
                //
                //Limpio artselecbusq para manejar el uso del boton en momento equivocado
                this.glb_mod_articuloSeleccionadoBusqueda = null;
                //Limpio txtbox cantidad
                this.txtCantidad.Text = "";
                //Limpio lbls
                this.cleanLbls();
                return;
            }
            
            //lo agrego a la venta actual
            glb_con_ProcesarVenta.addToVenta(glb_mod_articuloSeleccionadoBusqueda, Int32.Parse(this.txtCantidad.Text));
                            
            //Actualizo Total
            this.lblTotalVar.Text = glb_con_ProcesarVenta.getTotal();

            //rebindeo lista
            var lcl_bindingList = new BindingList<ModeloLineaPedido>(glb_con_ProcesarVenta.getVentaActual());
            var lcl_source = new BindingSource(lcl_bindingList, null);
            this.dgvDetalleAgregados.DataSource = lcl_source;
                    
            //Limpio artselecbusq para manejar el uso del boton en momento equivocado
            this.glb_mod_articuloSeleccionadoBusqueda = null;
            //Limpio txtbox cantidad
            this.txtCantidad.Text = "";
            //Limpio lbls
            this.cleanLbls();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            //checkeo que haya un articulo seleccionado
            if (!object.Equals(this.glb_mod_articuloSeleccionadoDetalle, null))
            {
                //lo elimino de la lista de articulos ya seleccionados
                glb_con_ProcesarVenta.eliminarLineaPedido(this.glb_mod_articuloSeleccionadoDetalle);
                

                //Actualizo Total
                this.lblTotalVar.Text = glb_con_ProcesarVenta.getTotal();

                //rebindeo los articulos seleccionados a la grid
                var lcl_bindingList = new BindingList<ModeloLineaPedido>(glb_con_ProcesarVenta.getVentaActual());
                var lcl_source = new BindingSource(lcl_bindingList, null);
                this.dgvDetalleAgregados.DataSource = lcl_source;

                //
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
                glb_con_ProcesarVenta.deleteCurrentDetails();

                //rebindeo grilla detalles
                this.dgvDetalleAgregados.DataSource = null;

                //se limpian las lbls
                cleanLbls();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //solicito confirmación
            DialogResult lcl_dialogResult = MessageBox.Show("¿Realmente desea cancelar la venta?", "Confirmación", MessageBoxButtons.YesNo);
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
            var lcl_mod_articulo= glb_con_ProcesarVenta.getArticuloBusqueda(dgvArtAgregar.CurrentCell.RowIndex);

            //asigno el articulo a la variable articuloSeleccionadoBusqueda en caso de que se decida agregarlo a la venta
            this.glb_mod_articuloSeleccionadoBusqueda = lcl_mod_articulo;

            //actualizo lost lbl para mostrar el articulo seleccionado
            this.lblCodigoOriginalVar.Text = lcl_mod_articulo.codigoOriginal;
            this.lblCodigoProveedorVar.Text = lcl_mod_articulo.codigoArticuloProveedor;
            this.lblProveedorVar.Text = lcl_mod_articulo.razonSocialProveedor;
            this.lblDescripcionVar.Text = lcl_mod_articulo.descripcionArticuloProveedor;
            //
            //TODO modificadores de precio segun metodo de pago
            this.lblPrecioVar.Text = Convert.ToString(lcl_mod_articulo.valorVenta.valorArticulo);
            this.lblUbicacionVar.Text = lcl_mod_articulo.ubicacion;

            this.lblExistenciaVar.Text = Convert.ToString(lcl_mod_articulo.stockActual);
            this.lblFechaActualizacionVar.Text = Convert.ToString(lcl_mod_articulo.fechaActualizacion);
            this.lblObservacionesVar.Text = lcl_mod_articulo.observacionesArticuloProveedor;
        }

        private void dgvDetalleAgregados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //asigno el articulo a la variable articulosSeleccionadosDetalle en caso de que se decida removerlo de la venta
            this.glb_mod_articuloSeleccionadoDetalle = glb_con_ProcesarVenta.getArticuloVenta(this.dgvDetalleAgregados.CurrentCell.RowIndex);
        }
        #endregion

        #region Labels, txtBox y Combos
        private void lblLupa_Click(object sender, EventArgs e)
        {
            //me aseguro que se haya seleccionado una categoria de búsqueda
            if (object.Equals(this.glb_categoriaBusquedaSeleccionada, null))
            {
                 MessageBox.Show("Por favor seleccione una categoría de búsqueda");
                return;
            }
            //capturo descripcion parcial y me aseguro que sea una entrada válda
            string lcl_descripcionParcialArticulo = this.txtDescripcionParcial.Text;
            if (!LibreriaClasesCompartidas.Validar.validarAlfanumericoConEspaciosSinCaracteresEspeciales(lcl_descripcionParcialArticulo))
            {
                MessageBox.Show("No se permiten caracteres especiales en la descripción. Por favor ingrésela correctamente");
                return;
            }
            
            //busco el/los articulos correspondientes y me fijo que se hayan encontrado artículos
            if (glb_con_ProcesarVenta.buscarArticulos(glb_categoriaBusquedaSeleccionada, lcl_descripcionParcialArticulo)>0)
            {
                //bindeo el datagrid con los articulos encontrados
                var lcl_bindingList = new BindingList<ModeloArticuloProveedores>(glb_con_ProcesarVenta.getBusqueda());
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

        //guarda categoria seleccionada
        private void cmbxCategoriaBuscar_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.glb_categoriaBusquedaSeleccionada = (string)this.cbxCategoriaBusqueda.SelectedValue;
        }

        private void txtBusqArticulo_Enter(object sender, EventArgs e)
        {
            //se limpian los lbls para no generar errores ya que no hay ninguno seleccionado
            cleanLbls();
        }

        private void cleanLbls()
        {
            this.lblCodigoOriginalVar.Text = this.lblCodigoProveedorVar.Text = this.lblProveedorVar.Text = 
            this.lblDescripcionVar.Text = this.lblPrecioVar.Text = this.lblExistenciaVar.Text = 
            this.lblFechaActualizacionVar.Text = this.lblObservacionesVar.Text = 
            this.lblUbicacionVar.Text = "Seleccione Artículo";

            //this.lblCodigoOriginalVar.Text = "Seleccione Articulo";
            //this.lblCodigoProveedorVar.Text = "Seleccione Articulo";
            //this.lblProveedorVar.Text = "Seleccione Articulo";
            //this.lblDescripcionVar.Text = "Seleccione Articulo";
            //this.lblPrecioVar.Text = "Seleccione Articulo";
            //this.lblExistenciaVar.Text = "Seleccione Articulo";
            //this.lblFechaActualizacionVar.Text = "Seleccione Articulo";
            //this.lblObservacionesVar.Text = "Seleccione Articulo";
            //this.lblUbicacionVar.Text = "Seleccione Articulo";
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.btnAgregar_Click(sender, e);
            }
        }
        #endregion        
    }

    //clase para llenar combo box categoria a buscar
    class Categ
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
