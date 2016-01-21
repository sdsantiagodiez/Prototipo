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
    public class ControladorPedidoProveedor: Controlador
    {

        CatalogoArticuloProveedores cap = new CatalogoArticuloProveedores();

        private ModeloPedido glb_mod_currentOrder;
       

        public void InstanciarPedido()
        {
            glb_mod_currentOrder = new ModeloPedido();
        }

        #region En Deshuso
        //public string agregarArticulo(string ptipoCodigo, string pcodArtProv, int pcantidad)
        //{


        //    ModeloArticuloProveedores ap = new ModeloArticuloProveedores();

        //    ap = cap.buscarArticuloProveedor(ptipoCodigo, pcodArtProv)[0];

        //    ModeloLineaPedido lp = new ModeloLineaPedido(ap, pcantidad);

        //    pActual.agregarLinea(lp);

        //    return "El se ha agregado un articulo al pedido actual";
        //}

        //public List<string[]> buscarArticulosProveedor(string ptipoCodigo, string pRazonSocial)
        //{
        //    List<ModeloArticuloProveedores> apActuales = new List<ModeloArticuloProveedores>();

        //    List<string[]> respuesta = new List<string[]>();

        //    apActuales = cap.buscarArticuloProveedor(ptipoCodigo, pRazonSocial);

        //    foreach (ModeloArticuloProveedores ModArtProv in apActuales)
        //    {
        //        string[] artipro = { ModArtProv.codigoOriginal, ModArtProv.codigoArticuloProveedor,ModArtProv.descripcion, ModArtProv.stockActual.ToString(), ModArtProv.stockMinimo.ToString(), Convert.ToDateTime(ModArtProv.fechaActualizacion).ToShortDateString()};

        //        respuesta.Add(artipro);
        //    }

        //    return respuesta;
        //}

        //public void modificarCantidadArticulo(string pCodArtProv, int pCant)
        //{ 
        //    if(pCant>0)
        //    {
        //        ModeloLineaPedido linea = pActual.buscarLinea(pCodArtProv);
                
        //        int Cantidad = linea.cantidadArticulos;

        //        if (pCant >= Cantidad)
        //        {
        //            pActual.bajarLinea(linea);
        //        }
        //        else
        //        {
        //            linea.cantidadArticulos = (Cantidad-pCant);
        //            pActual.actualizarLinea(linea);
                    
        //        }


        //    }

        //}
        #endregion


        public bool exists(ModeloArticuloProveedores p_article)
        {
            return glb_mod_currentOrder.existeLineaPedido(p_article);
        }

        public void addToOrder(ModeloArticuloProveedores p_article, int p_quantity)
        {
            ModeloLineaPedido lcl_mod_detail= new ModeloLineaPedido(p_article,p_quantity);
            glb_mod_currentOrder.addDetail(lcl_mod_detail);
        }

        public string getTotal()
        {
            return glb_mod_currentOrder.getCurrentTotal().ToString("0.##");
        }

        public List<ModeloLineaPedido> getCurrentDetails()
        {
            return glb_mod_currentOrder.lineasPedido;
        }

        public void deleteCurrentDetails()
        {
            glb_mod_currentOrder.restartOrderDetails();
        }

        public void removeFromOrder(ModeloLineaPedido p_mod_orderDetail)
        {
            glb_mod_currentOrder.bajarLinea(p_mod_orderDetail);
        }

        public List<ModeloArticuloProveedores> searchArticles(string p_searchCategory, string p_userInput)
        {
            var lcl_cat_articuloProveedores = new CatalogoArticuloProveedores();
            var lcl_mod_ArticuloProveedor = new ModeloArticuloProveedores();
            switch (p_searchCategory)
            {
                case Constantes.ParametrosBusqueda.ArticulosProveedores.CodigoOriginal:
                    lcl_mod_ArticuloProveedor.codigoOriginal = p_userInput; break;

                case Constantes.ParametrosBusqueda.ArticulosProveedores.DescripcionArticuloProveedor:
                    lcl_mod_ArticuloProveedor.descripcionArticuloProveedor = p_userInput; break;

                case Constantes.ParametrosBusqueda.ArticulosProveedores.CodigoArticuloProveedor:
                    lcl_mod_ArticuloProveedor.codigoArticuloProveedor = p_userInput; break;
            }
            List<ModeloArticuloProveedores> lcl_lst_mod_articles = lcl_cat_articuloProveedores.buscarArticuloProveedor(lcl_mod_ArticuloProveedor, p_searchCategory);
            return lcl_lst_mod_articles;
        }
    }
}
