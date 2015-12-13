using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Controladores
{
    public class ControladorReportes
    {
        public static CatalogoPedidos cped = new CatalogoPedidos();

        public string crearReporte(String[] razonSocial, DateTime fechaInicio, DateTime fechaFin)
        {
            string respuesta="";
            if (String.Equals(razonSocial, "") == false && (fechaFin > fechaInicio || fechaFin <= DateTime.Today))
            {
            
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


    }
}
