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
        //buscarReserva

        private List<ModeloLineaPedido> artVentaActual;
        public List<ModeloLineaPedido> getVentaActual()
        {
            return artVentaActual;
        }


        //busqueda de articulos por codigo original o por descripcion
        public List<ModeloArticuloProveedores> buscarArticulos(string categBusq, string busqArt)
        {
            var ctlgArticuloProv = new CatalogoArticuloProveedores();
            List<ModeloArticuloProveedores> articulos = ctlgArticuloProv.buscarArticuloProveedor(categBusq, busqArt);
            return articulos;
        }

        public void cerrarPedido(List<ModeloLineaPedido> ventaActual)
        {
            //descontar stock
            throw new NotImplementedException();
        }

        public void crearPedido()
        {
            this.artVentaActual = new List<ModeloLineaPedido>();
        }

        public void borrarActual()
        {
            this.artVentaActual = new List<ModeloLineaPedido>();
        }

        public void removeFromVenta(ModeloLineaPedido linea)
        {
            this.artVentaActual.Remove(linea);
        }

        public string getTotal()
        {
            decimal total = 0;
            foreach (ModeloLineaPedido linea in artVentaActual)
            {
                total = total + linea.valorParcial;
            }
            return total.ToString("0.##");
        }

        public bool exists(ModeloArticuloProveedores articulo)
        {
            //checkeo existencia de articulo en venta actual
            bool flag = false;
            foreach (ModeloLineaPedido linea in artVentaActual)
            {
                if (linea.codigoOriginalArt == articulo.codigoOriginal && linea.codigoArtProveedor == articulo.codigoArticuloProveedor)
                {
                    flag = true;
                }
            }
            return flag;
        }

        public void addToVenta(ModeloArticuloProveedores articulo, Int32 cantidad)
        {
            //le cambio el formato  y lo agrego a la lista de articulos ya seleccionados
            ModeloLineaPedido nuevaLinea = new ModeloLineaPedido(articulo, cantidad);
            this.artVentaActual.Add(nuevaLinea);
        }

        public ModeloPersonas getCliente(string dni)
        {
            var contBusq = new ControladorBusqueda();
            return contBusq.busqPersCompleta(dni);
        }

        public void addClient(ModeloPersonas newCli)
        {
            CatalogoPersonas catPer = new CatalogoPersonas();
            catPer.agregarNuevaEntidad(newCli);
        }

        public List<ModeloPais> getPaises()
        {
            var contBusq = new ControladorBusqueda();
            return contBusq.buscarPaises();
        }

        public List<ModeloProvincia> getProvincias()
        {
            var contBusq = new ControladorBusqueda();
            return contBusq.buscarProvincias();
        }
    }
}
