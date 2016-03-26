using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Modelos;
using LibreriaClasesCompartidas;

namespace Controladores
{
    public class ControladorProcesarVenta
    {
        //funciones a programar
        //buscarReserva

        private ModeloPedido glb_mod_PedidoVenta;
        private List<ModeloArticuloProveedores> glb_lst_mod_resultadoBusqueda;
        private List<ModeloPais> glb_lst_mod_paises;
        private List<ModeloProvincia> glb_lst_mod_provincias;
        private ModeloPersonas glb_mod_cliente;

        public void crearPedido()
        {
            this.glb_mod_PedidoVenta = new ModeloPedido();
        }

        public List<ModeloLineaPedido> getVentaActual()
        {
            return this.glb_mod_PedidoVenta.lineasPedido;
        }


        //busqueda de articulos por codigo original o por descripcion
        public int buscarArticulos(string p_categoriaBusquedaSeleccionada, string p_descripcionParcialArticulo)
        {
            var lcl_cat_ArticuloProveedor = new CatalogoArticuloProveedores();
            var lcl_mod_ArticuloProveedor = new ModeloArticuloProveedores();
            switch (p_categoriaBusquedaSeleccionada)
            {
                case Constantes.ParametrosBusqueda.ArticulosProveedores.CodigoOriginal:
                    lcl_mod_ArticuloProveedor.codigoOriginal=p_descripcionParcialArticulo; break;

                case Constantes.ParametrosBusqueda.ArticulosProveedores.DescripcionArticuloProveedor:
                    lcl_mod_ArticuloProveedor.descripcionArticuloProveedor = p_descripcionParcialArticulo; break;

                case Constantes.ParametrosBusqueda.ArticulosProveedores.CodigoArticuloProveedor:
                    lcl_mod_ArticuloProveedor.codigoArticuloProveedor = p_descripcionParcialArticulo; break;
            }

            glb_lst_mod_resultadoBusqueda = lcl_cat_ArticuloProveedor.buscar(lcl_mod_ArticuloProveedor, p_categoriaBusquedaSeleccionada);
            return glb_lst_mod_resultadoBusqueda.Count;
        }

        public void cerrarPedido()
        {
            var lcl_con_modificacion = new ControladorModificacion();
            var lcl_cat_articulosProveedores = new CatalogoArticuloProveedores();
            var lcl_mod_articuloProveedores = new ModeloArticuloProveedores();
            var lcl_lst_mod_lineasPedido = glb_mod_PedidoVenta.lineasPedido;

            foreach (ModeloLineaPedido lcl_mod_linea in lcl_lst_mod_lineasPedido)
            {
                lcl_mod_articuloProveedores = lcl_cat_articulosProveedores.getOne(lcl_mod_linea.codigoOriginalArt, lcl_mod_linea.codigoArtProveedor);
                lcl_mod_articuloProveedores.stockActual = lcl_mod_articuloProveedores.stockActual - lcl_mod_linea.cantidadArticulos;
                lcl_con_modificacion.modificar(lcl_mod_articuloProveedores);
            }

            //calcular lo que falta calcular(como total)
            //guardar lineas
            //guardar pedido
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

        public ModeloPersonas getCliente()
        {
            return glb_mod_cliente;
        }

        public void buscarCliente(string p_dni)
        {
            var lcl_con_busqueda = new ControladorBusqueda();
            ModeloPersonas lcl_mod_persona = new ModeloPersonas();
            lcl_mod_persona.dni = p_dni;
            glb_mod_cliente = lcl_con_busqueda.buscar(lcl_mod_persona, Constantes.ParametrosBusqueda.Entidades.Personas.Dni)[0];
        }

        public void addClient(ModeloPersonas p_nuevoCliente)
        {
            CatalogoPersonas lcl_cat_personas = new CatalogoPersonas();
            //lcl_cat_personas.add(ref p_nuevoCliente);
            //CAMBIOS
        }

        public List<ModeloPais> getPaises()
        {
            return glb_lst_mod_paises;
        }

        public void buscarPaises()
        {
            var lcl_con_busqueda = new ControladorBusqueda();
            glb_lst_mod_paises= lcl_con_busqueda.getPaises();
        }

        public List<ModeloProvincia> getProvincias()
        {
            return glb_lst_mod_provincias;
        }

        public void buscarProvincias()
        {
            var lcl_con_busqueda = new ControladorBusqueda();
            glb_lst_mod_provincias= lcl_con_busqueda.getProvincias();
        }

        public List<ModeloArticuloProveedores> getBusqueda()
        {
            return glb_lst_mod_resultadoBusqueda;
        }

        public ModeloArticuloProveedores getArticuloBusqueda(int p_indice)
        {
            return glb_lst_mod_resultadoBusqueda[p_indice];
        }

        public ModeloLineaPedido getArticuloVenta(int p_indice)
        {
            return glb_mod_PedidoVenta.lineasPedido[p_indice];
        }

        public int getCantidadVentaActual()
        {
            return glb_mod_PedidoVenta.lineasPedido.Count;
        }
    }
}
