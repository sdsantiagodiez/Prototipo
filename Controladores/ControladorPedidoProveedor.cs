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
        //-
        public bool exists(ModeloArticuloProveedores p_article)
        {
            return glb_mod_currentOrder.existeLineaPedido(p_article);
        }
        //-
        public void addToOrder(ModeloArticuloProveedores p_article, int p_quantity)
        {
            ModeloLineaPedido lcl_mod_detail= new ModeloLineaPedido(p_article,p_quantity);
            glb_mod_currentOrder.addDetail(lcl_mod_detail);
        }
        //-
        public string getTotal()
        {
            return glb_mod_currentOrder.getCurrentTotal().ToString("0.##");
        }
        //-
        public List<ModeloLineaPedido> getCurrentDetails()
        {
            return glb_mod_currentOrder.lineasPedido;
        }
        //-
        public void deleteCurrentDetails()
        {
            glb_mod_currentOrder.restartOrderDetails();
        }
        //-
        public void removeFromOrder(ModeloLineaPedido p_mod_orderDetail)
        {
            glb_mod_currentOrder.bajarLinea(p_mod_orderDetail);
        }
        //-buscarArticulo
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
            List<ModeloArticuloProveedores> lcl_lst_mod_articles = lcl_cat_articuloProveedores.buscar(lcl_mod_ArticuloProveedor, p_searchCategory);
            return lcl_lst_mod_articles;
        }
    }
}
