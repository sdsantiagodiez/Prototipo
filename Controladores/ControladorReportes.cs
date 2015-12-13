using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Modelos;

namespace Controladores
{
    public class ControladorReportes
    {
        public static CatalogoProveedores cp = new CatalogoProveedores();
        public static CatalogoPedidos cped = new CatalogoPedidos();
        public static List<ModeloPedido> pedidos = new List<ModeloPedido>();
        float MaxMontoTotal = 0;
        float MontoTotalProveedor = 0;
        int CantidadTotalArticulos = 0;
        public string crearReporte(String[] razonSocial, DateTime fechaInicio, DateTime fechaFin)
        {
            string respuesta="";
            
            if (String.Equals(razonSocial, "") == false && (fechaFin > fechaInicio || fechaFin <= DateTime.Today))
            {
                pedidos = cped.getPedidos("Pedido a proveedor");
                
                foreach (string RSocial in razonSocial)
                {
                    foreach (ModeloPedido pedido in pedidos) 
                    {
                        ModeloProveedor prov = new ModeloProveedor();
                        prov = cped.getProveedorPedido(pedido.nroPedido);
                        if (prov.razonSocial == RSocial)
                        {
                            if (Convert.ToDateTime(pedido.fecha) >= fechaInicio && Convert.ToDateTime(pedido.fecha) <= fechaFin)
                            {
                                MaxMontoTotal = (pedido.monto_total>MaxMontoTotal)? pedido.monto_total : MaxMontoTotal ;
                                MontoTotalProveedor = MontoTotalProveedor + pedido.monto_total;
                                foreach (ModeloLineaPedido lineas in pedido.lineasPedido)
                                {
                                    CantidadTotalArticulos = CantidadTotalArticulos + lineas.cantidadArticulos;
                                }
                            }

                        }

                    }

                }
                /*Hecho para un solo proveedor*/
                string detalleProveedores = razonSocial + Convert.ToString(MontoTotalProveedor) + Convert.ToString(MaxMontoTotal) + Convert.ToString(CantidadTotalArticulos);
                respuesta = "Fecha Inicio:" + Convert.ToString(fechaInicio) + "Fecha Fin:" + Convert.ToString(fechaFin) + detalleProveedores;
            }
            else
            {
                if (String.Equals(razonSocial, ""))
                {
                    respuesta = "Debe seleccionar al menos 1 proveedor";
                }
                else
                {
                    respuesta = "Fechas no válidas";
                }
            }
        return respuesta;
        }

        public List<string> iniciarReporte()
        {
            List<string> respuesta = null;
            List<ModeloProveedor> p = cp.getAll();

            foreach(ModeloProveedor prov in p)
            {
                string proveedor = prov.cuit + ", " + prov.razonSocial;
                respuesta.Add(proveedor);
            }

            return respuesta;
        }


    }
}
