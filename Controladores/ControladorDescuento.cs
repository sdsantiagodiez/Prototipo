using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Modelos;

namespace Controladores
{
    public class ControladorDescuento
    {
        public static List<ModeloDescuentoArticulo> resultadoBusquedaDescuentos;

        public int getUltimoDescuento()
        {
            CatalogoDescuentos lcl_cat_descuentos = new CatalogoDescuentos();
            return lcl_cat_descuentos.getUltimoNumero();
        }

        public int buscarDescuentos(string p_codigo_original, string p_codigo_articulo_proveedor)
        {
            ModeloDescuentoArticulo lcl_mod_descuento = new ModeloDescuentoArticulo();

            resultadoBusquedaDescuentos = ControladorBusqueda.getDescuentos(lcl_mod_descuento);
            return resultadoBusquedaDescuentos.Count;
        }
        public ModeloDescuentoArticulo getDescuentoBusqueda(int p_indice)
        {
            return resultadoBusquedaDescuentos[p_indice];
        }
        public List<ModeloDescuentoArticulo> getDescuentosBusqueda()
        {
            return resultadoBusquedaDescuentos;
        }

    }
}
