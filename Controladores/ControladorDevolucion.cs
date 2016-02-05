using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Modelos;

namespace Controladores
{
    public class ControladorDevolucion
    {
        ModeloPedido glb_mod_pedido;
        //
        //ATENCION! 
        //
        //En este controlador se realiza un cambio a nivel funcion sobre el stock del artículo, que no se ve reflejado en esta variable global
        //si es necesario que impacte la variable global, cambiarlo.
        ModeloArticuloProveedores glb_mod_articuloDevolucion;


        public void actualizarStock()
        {
            //creo controladors y catalogos pertinentes
            var lcl_con_modificacion = new ControladorModificacion();
            var lcl_cat_articulosProveedores = new CatalogoArticuloProveedores();

            //creo linea y articulo de la línea
            var lcl_mod_lineaCorrespondiente = glb_mod_pedido.findDetail(glb_mod_articuloDevolucion.codigoOriginal, glb_mod_articuloDevolucion.codigoArticuloProveedor);
            //utilizo un articulo devolucion local para no crear cambios en el global, de esta forma puedo utilizar el global original en otras funciones
            var lcl_mod_articuloDevolucion = glb_mod_articuloDevolucion;

            //actualizo artículo
            lcl_mod_articuloDevolucion.stockActual = glb_mod_articuloDevolucion.stockActual + lcl_mod_lineaCorrespondiente.cantidadArticulos;
            lcl_con_modificacion.modificarArticuloProveedor(lcl_mod_articuloDevolucion);
        }

        public ModeloArticuloProveedores getArticuloPedido(string p_numeroPedido, string p_codigoOriginal, string p_codigoArticuloProveedor)
        {
            //lcl_mod_articuloProveedores = lcl_cat_articulosProveedores.getOne(p_articuloDevolucion.codigoOriginal, p_articuloDevolucion.codigoArticuloProveedor);
            throw new NotImplementedException();
        }
    }
}
