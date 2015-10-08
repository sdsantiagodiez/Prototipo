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
        //crearPedido
        //buscarReserva
        //getDetalles
        //agregarArticulo
        //modificarCantidadArticulo
        //cerrarPedido

        
        //busqueda de articulos por codigo original o por descripcion
        public List<ModeloArticuloProveedores> buscarArticulos(string categBusq, string busqArt)
        {
            var ctlgArticuloProv = new CatalogoArticuloProveedores();
            List<ModeloArticuloProveedores> articulos = ctlgArticuloProv.buscarArticuloProveedor(categBusq,busqArt);
            return articulos;               
        }
    }
}
