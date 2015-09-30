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
       
        public List<ModeloArticulos> buscarArticulos(string categBusq, string busqArt)
        {
            CatalogoArticulos ctlgArticulos = new CatalogoArticulos();
            List<ModeloArticulos> articulos = ctlgArticulos.buscarArticulo(categBusq,busqArt);
            return articulos;               
        }
    }
}
