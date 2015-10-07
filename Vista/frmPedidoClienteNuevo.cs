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
        private List<ModeloArticuloProveedores> artVentaActual = new List<ModeloArticuloProveedores>();
        private decimal contado = 1;
        private decimal tarjeta = 1;
        private ModeloArticuloProveedores artSeleccionado;
        public frmPedidoClienteNuevo()
        {
            InitializeComponent();
            //Creo lista categorias

            var dataSource = new List<Categ>();
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

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            frmPedidoClienteCierre frmCierre = new frmPedidoClienteCierre();
            frmCierre.ShowDialog();
        }

        private void lblLupa_Click(object sender, EventArgs e)
        {
            //FALTA VALIDAR LA DESCRIPCION
            
            //capturo descripcion parcial
            string busqArt = this.txtBusqArticulo.Text;

            //busco el/los articulos correspondientes
            var ctrlProcVenta = new ControladorProcesarVenta();
            artEncontrados = ctrlProcVenta.buscarArticulos(categBusq, busqArt);
            
            //lo transformo a un modelo que solo muestre algunas columnas (se podra hacer de otra forma sin modelo extra?)
            List<ModeloVistaNuevoPedido> artEncVista = ctrlProcVenta.adaptarArt(artEncontrados);

            //bindeo el datagrid con los articulos encontrados
            if (!object.Equals(artEncontrados, null))
            {
                var bindingList = new BindingList<ModeloVistaNuevoPedido>(artEncVista);
                var source = new BindingSource(bindingList, null);
                this.dgvArtAgregar.DataSource = source;
            }
            else
            {
                MessageBox.Show("No se encontraron coincidencias");
            }

        }

        private void txtDescArticulo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void dgvArtAgregar_SelectionChanged(object sender, EventArgs e)
        {
            //busco el indice de la fila seleccionada que coincide con la lista que contiene mayor cantidad de información
            int articuloSelec = dgvArtAgregar.CurrentCell.RowIndex;

            //asigno el articulo a la variable artSeleccionado en caso de que se decida agregarlo a la venta
            this.artSeleccionado = artEncontrados[articuloSelec];

            //actualizo lost lbl para mostrar el articulo seleccionado
            this.lblCodOrigVar.Text = artEncontrados[articuloSelec].codigoOriginal;
            this.lblCodProvVar.Text = artEncontrados[articuloSelec].codigoArticuloProveedor;
            this.lblProvVar.Text = artEncontrados[articuloSelec].razonSocialProveedor;
            this.lblDescVar.Text = artEncontrados[articuloSelec].descripcion;
            //
            //TODO modificadores de precio segun metodo de pago
            this.lblContadoVar.Text = Convert.ToString(artEncontrados[articuloSelec].valorVenta.valorArticulo * contado);
            this.lblTarjetaVar.Text = Convert.ToString(artEncontrados[articuloSelec].valorVenta.valorArticulo * tarjeta);
            //
            /* TODO modificar base de datos y modelo para registrar ubicación del articulo en cuestion en el local
             * this.lblTarjetaVar.Text = artEncontrados[articuloSelec].ubicacion
             */
            this.lblExistenciaVar.Text = Convert.ToString(artEncontrados[articuloSelec].stockActual);
            this.lblFechaActualizVar.Text = Convert.ToString(artEncontrados[articuloSelec].fechaActualizacion);
            this.lblObsVar.Text = artEncontrados[articuloSelec].observaciones;

        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
           //checkeo que haya un articulo seleccionado
            if (!object.Equals(this.artSeleccionado, null))
            {
                //lo agrego a la lista de articulos ya seleccionados
                this.artVentaActual.Add(this.artSeleccionado);

                //rebindeo los articulos seleccionados a la grid

                //
                //TODO La grilla original mostraba Codigo de proveedor, Descripción, Precio Unitario, Precio parcial (?que es esto?) Cantidad
                //Falta solicitar cantidad y mostrar información adecuada

                var bindingList = new BindingList<ModeloArticuloProveedores>(this.artVentaActual);
                var source = new BindingSource(bindingList, null);
                this.dgvDetalleAgregados.DataSource = source;

                //
                //
            }
            else
            {
                MessageBox.Show("Por favor seleccione un articulo");
            }
        }

        private void txtBusqArticulo_Enter(object sender, EventArgs e)
        {
            //se limpian los lbls para no generar errores ya que no hay ninguno seleccionado
            this.lblCodOrigVar.Text = "Seleccione Articulo";
            this.lblCodProvVar.Text = "Seleccione Articulo";
            this.lblProvVar.Text = "Seleccione Articulo";
            this.lblDescVar.Text = "Seleccione Articulo";
            this.lblContadoVar.Text = "Seleccione Articulo";
            this.lblTarjetaVar.Text = "Seleccione Articulo";
            this.lblExistenciaVar.Text = "Seleccione Articulo";
            this.lblFechaActualizVar.Text = "Seleccione Articulo";
            this.lblObsVar.Text = "Seleccione Articulo";
        }
    }

    //clase para llenar combo box categoria a buscar
    public class Categ
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
