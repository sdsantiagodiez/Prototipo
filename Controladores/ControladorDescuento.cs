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
        public static List<ModeloDescuento> getDescuentosBase()
        {
            List<int> lst_porcentajes = new List<int>() { 5, 10, 15, 20, 25, 30, 40, 50, 60, 70, 80 };
            List<ModeloDescuento> lcl_lst_DescuentosBase = new List<ModeloDescuento>();
            int codigo = 1;
            foreach (int i in lst_porcentajes)
            {
                lcl_lst_DescuentosBase.Add(new ModeloDescuento()
                {
                    codigoDescuento = codigo,
                    porcentaje = Convert.ToDecimal(i) / 100,
                    descripcion = i.ToString() + " %"
                });
                codigo++;
            }
            return lcl_lst_DescuentosBase;
        }

        public static List<ModeloDescuentoArticulo> resultadoBusquedaDescuentos;

        public int getUltimoDescuento()
        {
            CatalogoDescuentos lcl_cat_descuentos = new CatalogoDescuentos();
            return lcl_cat_descuentos.getUltimoNumero();
        }

        public int buscarDescuentos(string p_codigo_original, string p_codigo_articulo_proveedor)
        {
            resultadoBusquedaDescuentos = ControladorBusqueda.getDescuentos(p_codigo_original,p_codigo_articulo_proveedor);
            return resultadoBusquedaDescuentos.Count;
        }
        public List<ModeloDescuentoArticulo> buscarDescuentosVigentes(DateTime p_fecha)
        {
            resultadoBusquedaDescuentos = ControladorBusqueda.getDescuentosVigentes(p_fecha);
            return resultadoBusquedaDescuentos;
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
