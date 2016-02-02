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
        public static CatalogoProveedores glb_con_proveedores = new CatalogoProveedores();
        public static CatalogoPedidos glb_con_pedidos = new CatalogoPedidos();
        public static List<ModeloPedido> glb_lst_mod_pedidos = new List<ModeloPedido>();
        float glb_var_MaxMontoTotal = 0;
        float glb_var_MontoTotalProveedor = 0;
        int glb_var_CantidadTotalArticulos = 0;
        public string crearReporte(String[] p_var_razonSocial, DateTime p_date_fechaInicio, DateTime p_date_fechaFin)
        {
            string lcl_var_respuesta="";
            
            if (String.Equals(p_var_razonSocial, "") == false && (p_date_fechaFin > p_date_fechaInicio || p_date_fechaFin <= DateTime.Today))
            {
                glb_lst_mod_pedidos = glb_con_pedidos.getPedidos("Pedido a proveedor");
                
                foreach (string RSocial in p_var_razonSocial)
                {
                    foreach (ModeloPedido lcl_mod_pedido in glb_lst_mod_pedidos) 
                    {
                        ModeloProveedor lcl_mod_proveedor = new ModeloProveedor();
                        lcl_mod_proveedor = glb_con_pedidos.getProveedorPedido(lcl_mod_pedido.nroPedido);
                        if (lcl_mod_proveedor.razonSocial == RSocial)
                        {
                            if (Convert.ToDateTime(lcl_mod_pedido.fecha) >= p_date_fechaInicio && Convert.ToDateTime(lcl_mod_pedido.fecha) <= p_date_fechaFin)
                            {
                                glb_var_MaxMontoTotal = (lcl_mod_pedido.monto_total>glb_var_MaxMontoTotal)? lcl_mod_pedido.monto_total : glb_var_MaxMontoTotal ;
                                glb_var_MontoTotalProveedor = glb_var_MontoTotalProveedor + lcl_mod_pedido.monto_total;
                                foreach (ModeloLineaPedido lcl_mod_lineapedido in lcl_mod_pedido.lineasPedido)
                                {
                                    glb_var_CantidadTotalArticulos = glb_var_CantidadTotalArticulos + lcl_mod_lineapedido.cantidadArticulos;
                                }
                            }

                        }

                    }

                }
                /*Hecho para un solo proveedor*/
                string detalleProveedores = p_var_razonSocial + Convert.ToString(glb_var_MontoTotalProveedor) + Convert.ToString(glb_var_MaxMontoTotal) + Convert.ToString(glb_var_CantidadTotalArticulos);
                lcl_var_respuesta = "Fecha Inicio:" + Convert.ToString(p_date_fechaInicio) + "Fecha Fin:" + Convert.ToString(p_date_fechaFin) + detalleProveedores;
            }
            else
            {
                if (String.Equals(p_var_razonSocial, ""))
                {
                    lcl_var_respuesta = "Debe seleccionar al menos 1 proveedor";
                }
                else
                {
                    lcl_var_respuesta = "Fechas no válidas";
                }
            }
        return lcl_var_respuesta;
        }

        public List<string> iniciarReporte()
        {
            List<string> lcl_var_respuesta = null;
            List<ModeloProveedor> lcl_mod_proveedor = glb_con_proveedores.getAll();

            foreach(ModeloProveedor prov in lcl_mod_proveedor)
            {
                string proveedor = prov.cuit + ", " + prov.razonSocial;
                lcl_var_respuesta.Add(proveedor);
            }

            return lcl_var_respuesta;
        }


    }
}
