using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Modelos;

namespace Controladores
{
    public class ControladorProcesarVenta
    {
        //funciones a programar
        //buscarReserva

        private ModeloPedido glb_mod_PedidoVenta;

        public void crearPedido()
        {
            this.glb_mod_PedidoVenta = new ModeloPedido();
        }
        
        public List<ModeloLineaPedido> getVentaActual()
        {
            return this.glb_mod_PedidoVenta.lineasPedido;
        }


        //busqueda de articulos por codigo original o por descripcion
        public List<ModeloArticuloProveedores> buscarArticulos(string p_categoriaBusquedaSeleccionada, string p_descripcionParcialArticulo)
        {
            var lcl_cat_ArticuloProveedor = new CatalogoArticuloProveedores();
            List<ModeloArticuloProveedores> articulos = lcl_cat_ArticuloProveedor.buscarArticuloProveedor(p_categoriaBusquedaSeleccionada, p_descripcionParcialArticulo);
            return articulos;
        }

        public void cerrarPedido(List<ModeloLineaPedido> p_ventaActual)
        {
            var lcl_con_modificacion = new ControladorModificacion();
            var lcl_cat_articulosProveedores = new CatalogoArticuloProveedores();
            var lcl_mod_articuloProveedores = new ModeloArticuloProveedores();

            foreach (ModeloLineaPedido lcl_mod_linea in p_ventaActual)
            {
                lcl_mod_articuloProveedores = lcl_cat_articulosProveedores.getOne(lcl_mod_linea.codigoOriginalArt, lcl_mod_linea.codigoArtProveedor);
                lcl_mod_articuloProveedores.stockActual = lcl_mod_articuloProveedores.stockActual - lcl_mod_linea.cantidadArticulos;
                lcl_con_modificacion.modificarArticuloProveedor(lcl_mod_articuloProveedores);
            }
        }

        public void deleteCurrentDetails()
        {
            this.glb_mod_PedidoVenta.restartOrderDetails();
        }

        public void eliminarLineaPedido(ModeloLineaPedido p_lineaPedido)
        {
            this.glb_mod_PedidoVenta.bajarLinea(p_lineaPedido);
        }

        public string getTotal()
        {
            return this.glb_mod_PedidoVenta.getCurrentTotal().ToString("0.##");
        }

        public bool exists(ModeloArticuloProveedores p_articulo)
        {
            return this.glb_mod_PedidoVenta.existeLineaPedido(p_articulo);
        }

        public void addToVenta(ModeloArticuloProveedores p_articulo, Int32 p_cantidad)
        {
            //le cambio el formato  y lo agrego a la lista de articulos ya seleccionados
            ModeloLineaPedido lcl_mod_nuevaLinea = new ModeloLineaPedido(p_articulo, p_cantidad);
            this.glb_mod_PedidoVenta.addDetail(lcl_mod_nuevaLinea);
        }

        public ModeloPersonas getCliente(string p_dni)
        {
            var lcl_con_busqueda = new ControladorBusqueda();
            ModeloPersonas lcl_mod_persona = new ModeloPersonas();
            lcl_mod_persona.dni = p_dni;
            return lcl_con_busqueda.buscarPersonas(lcl_mod_persona,"dni")[0];
        }

        public void addClient(ModeloPersonas p_nuevoCliente)
        {
            CatalogoPersonas lcl_cat_personas = new CatalogoPersonas();
            lcl_cat_personas.agregarNuevaEntidad(p_nuevoCliente);
        }

        public List<ModeloPais> getPaises()
        {
            var contBusq = new ControladorBusqueda();
            return contBusq.buscarPaises();
        }

        public List<ModeloProvincia> getProvincias()
        {
            var contBusq = new ControladorBusqueda();
            return contBusq.buscarProvincias();
        }
    }
}
