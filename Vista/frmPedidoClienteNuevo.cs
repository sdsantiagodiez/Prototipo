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

namespace Vista
{
    public partial class frmPedidoClienteNuevo : Form
    {
        private string categBusq;
        private List<ModeloArticuloProveedores> artEncontrados;
        private List<ModeloLineaPedido> artVentaActual;
        private ModeloArticuloProveedores artSelecBusq;
        private ModeloLineaPedido artSelecDetalle;
        private ControladorProcesarVenta ctrlProcVenta;

        public frmPedidoClienteNuevo()
        {
            InitializeComponent();
            //creo la venta
            ctrlProcVenta = new ControladorProcesarVenta();
            ctrlProcVenta.crearPedido();

            //seteo columnas de datagridviews
            this.dgvArtAgregar.AutoGenerateColumns = false;
            this.dgvDetalleAgregados.AutoGenerateColumns = false;
            
            //Creo lista categorias
            var dataSource = new List<Categ>();
            dataSource.Add(new Categ() { Name = "Seleccione...", Value = null });
            dataSource.Add(new Categ() { Name = "Codigo Original", Value = "codigooriginal" });
            dataSource.Add(new Categ() { Name = "Descripción", Value = "descripcion" });
            dataSource.Add(new Categ() { Name = "Codigo Proveedor", Value = "codigoarticuloproveedor" });

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
            if (this.artVentaActual.Count > 0)
            {
                //creo el formulario y lo muestro
                frmPedidoClienteCierre frmCierre = new frmPedidoClienteCierre();
                frmCierre.detalleVenta(ctrlProcVenta);
                frmCierre.ShowDialog();
                //checkeo si se cerró la venta
                if (frmCierre.emitido==true)
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
            if (!object.Equals(this.artSelecBusq, null))
            {
                //Verifico la cantidad
                if (!string.Equals(this.txtCantidad.Text, ""))
                {
                    //verifico stock
                    if (this.artSelecBusq.stockActual >= Int32.Parse(this.txtCantidad.Text))
                    {                        
                        //verifico que no exista ya en entre las lineas de pedido
                        if (!ctrlProcVenta.exists(artSelecBusq))
                        {
                            //lo agrego a la venta actual
                            ctrlProcVenta.addToVenta(artSelecBusq, Int32.Parse(this.txtCantidad.Text));
                            

                            //Actualizo Total
                            this.lblTotalVar.Text = ctrlProcVenta.getTotal();

                            //rebindeo lista
                            this.artVentaActual = ctrlProcVenta.getVentaActual();
                            var bindingList = new BindingList<ModeloLineaPedido>(this.artVentaActual);
                            var source = new BindingSource(bindingList, null);
                            this.dgvDetalleAgregados.DataSource = source;
                    
                            //Limpio artselecbusq para manejar el uso del boton en momento equivocado
                            this.artSelecBusq = null;
                            //Limpio txtbox cantidad
                            this.txtCantidad.Text = "";
                            //Limpio lbls
                            this.cleanLbls();
                        }
                        else
                        {
                            MessageBox.Show("Este artículo ya se encuentra en los detalles de la venta actual");
                            //
                            //Limpio artselecbusq para manejar el uso del boton en momento equivocado
                            this.artSelecBusq = null;
                            //Limpio txtbox cantidad
                            this.txtCantidad.Text = "";
                            //Limpio lbls
                            this.cleanLbls();
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("No hay suficientes articulos en inventario actual para cubrir el pedido");
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

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            //checkeo que haya un articulo seleccionado
            if (!object.Equals(this.artSelecDetalle, null))
            {
                //lo elimino de la lista de articulos ya seleccionados
                ctrlProcVenta.removeFromVenta(this.artSelecDetalle);
                this.artVentaActual = ctrlProcVenta.getVentaActual();

                //Actualizo Total
                this.lblTotalVar.Text = ctrlProcVenta.getTotal();

                //rebindeo los articulos seleccionados a la grid
                this.artVentaActual = ctrlProcVenta.getVentaActual();
                var bindingList = new BindingList<ModeloLineaPedido>(this.artVentaActual);
                var source = new BindingSource(bindingList, null);
                this.dgvDetalleAgregados.DataSource = source;

                //
                //Limpio artselecdetalle para evitar uso de boton en momento equivocado
                this.artSelecDetalle = null;
            }
            else
            {
                MessageBox.Show("Por favor seleccione un articulo a eliminar de la grilla de detalles");
            }
        }

        private void btnBorrarDetActual_Click(object sender, EventArgs e)
        {
            //solicito confirmación
            DialogResult dialogResult = MessageBox.Show("¿Realmente desea borrar el detalle actual?", "Confirmación", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //borro la venta actual
                ctrlProcVenta.borrarActual();
                this.artVentaActual = ctrlProcVenta.getVentaActual();

                //rebindeo grilla detalles
                this.dgvDetalleAgregados.DataSource = null;

                //se limpian las lbls
                cleanLbls();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //solicito confirmación
            DialogResult dialogResult = MessageBox.Show("¿Realmente desea cancelar la venta?", "Confirmación", MessageBoxButtons.YesNo);
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
            this.artSelecDetalle = null;
        }

        private void dgvDetalleAgregados_Enter(object sender, EventArgs e)
        {
            //Limpio artselecbusq para manejar el uso del boton en momento equivocado
            this.artSelecBusq = null;
        }

        private void dgvArtAgregar_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            //busco el indice de la fila seleccionada que coincide con la lista que contiene mayor cantidad de información
            int indiceSelecc = dgvArtAgregar.CurrentCell.RowIndex;

            //asigno el articulo a la variable artSelecBusq en caso de que se decida agregarlo a la venta
            this.artSelecBusq = artEncontrados[indiceSelecc];

            //actualizo lost lbl para mostrar el articulo seleccionado
            this.lblCodOrigVar.Text = artEncontrados[indiceSelecc].codigoOriginal;
            this.lblCodProvVar.Text = artEncontrados[indiceSelecc].codigoArticuloProveedor;
            this.lblProvVar.Text =  artEncontrados[indiceSelecc].razonSocialProveedor;
            this.lblDescVar.Text = artEncontrados[indiceSelecc].descripcion;
            //
            //TODO modificadores de precio segun metodo de pago
            this.lblPrecioVar.Text = Convert.ToString(artEncontrados[indiceSelecc].valorVenta.valorArticulo);
            this.lblUbicacionVar.Text = artEncontrados[indiceSelecc].ubicacion;
            
            this.lblExistenciaVar.Text = Convert.ToString(artEncontrados[indiceSelecc].stockActual);
            this.lblFechaActualizVar.Text = Convert.ToString(artEncontrados[indiceSelecc].fechaActualizacion);
            this.lblObsVar.Text = artEncontrados[indiceSelecc].observaciones;
        }

        private void dgvDetalleAgregados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //busco el indice de la fila seleccionada
            int indiceSelecc = this.dgvDetalleAgregados.CurrentCell.RowIndex;

            //asigno el articulo a la variable artSelecDetalle en caso de que se decida removerlo de la venta
            this.artSelecDetalle = this.artVentaActual[indiceSelecc];
        }
        #endregion

        #region Labels, txtBox y Combos
        private void lblLupa_Click(object sender, EventArgs e)
        {
            //
            //TODO --> VALIDAR EL INPUT
            //

            
            //capturo descripcion parcial
            string busqArt = this.txtBusqArticulo.Text;

            //me aseguro que se haya seleccionado una categoria de búsqueda
            if (!object.Equals(this.categBusq, null))
            {
                //busco el/los articulos correspondientes
                artEncontrados = ctrlProcVenta.buscarArticulos(categBusq, busqArt);

                //bindeo el datagrid con los articulos encontrados
                if (!object.Equals(artEncontrados, null))
                {
                    var bindingList = new BindingList<ModeloArticuloProveedores>(artEncontrados);
                    var source = new BindingSource(bindingList, null);
                    this.dgvArtAgregar.DataSource = source;
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
            this.categBusq = (string)this.cmbxCategoriaBuscar.SelectedValue;
        }

        private void txtBusqArticulo_Enter(object sender, EventArgs e)
        {
            //se limpian los lbls para no generar errores ya que no hay ninguno seleccionado
            cleanLbls();
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

    //clase para llenar combo box categoria a buscar
    public class Categ
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
