using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Controladores
{
    public class ControladorDescuento
    {
        public int getUltimoDescuento()
        {
            CatalogoDescuentos lcl_cat_descuentos = new CatalogoDescuentos();
            return lcl_cat_descuentos.getUltimoNumero();
        }

    }
}
