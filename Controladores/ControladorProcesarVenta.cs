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


        /// <summary>
        /// Transforma los articulos proveedores a un formato apto para la carga de datagrid de nuevo pedido
        /// </summary>
        /// <param name="artEncontrados">Lista de articulos encontrados en busqueda</param>
        /// <returns>lista formateada a tipo ModeloVistaNuevoPedido</returns>
        public List<ModeloVistaNuevoPedido> adaptarArt(List<ModeloArticuloProveedores> artEncontrados)
        {
            List<ModeloVistaNuevoPedido> artAdapt = new List<ModeloVistaNuevoPedido>();
            foreach (ModeloArticuloProveedores map in artEncontrados)
            {
                var modVista = new ModeloVistaNuevoPedido();
                modVista.codigoArticuloProveedor = map.codigoArticuloProveedor;
                modVista.codigoOriginal = map.codigoOriginal;
                modVista.razonSocialProveedor = map.razonSocialProveedor;
                modVista.descripcion = map.descripcion;
                modVista.valorVenta = map.valorVenta.valorArticulo;
                artAdapt.Add(modVista);
            }
            return artAdapt;
        }
    }
}
