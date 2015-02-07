using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Models;

namespace Controlador
{
    class ControladorModificacion
    {
        public string[] buscaProveedor(string pCuitOrS)// el parametro es el cuit o la razon social
        {
            string[] rtafin = new string[1] {"FIN"}; // se crea este string para indicar a la interfaz el final del ciclo 

            CatalogoProveedores cp = new CatalogoProveedores();

            List<ModeloProveedores> pActuales = new List<ModeloProveedores>();

            pActuales = cp.buscaProveedores(pCuitOrS);

            foreach (ModeloProveedores mp in pActuales)
                {
                    string[] rtaProv = new string[2] { mp.cuitProv, mp.razonSocialProv };
                   
                    return rtaProv;
                }
            return rtafin;
        }

        public string[] getDetalles(string pCuit)
        {
            string[] detallesproveedor = new string[9];

            CatalogoProveedores cp = new CatalogoProveedores();
            
            List<ModeloProveedores> pActuales = new List<ModeloProveedores>();

            pActuales = cp.buscaProveedores(pCuit);
            detallesproveedor[0] = pActuales[1].razonSocialProv;
            detallesproveedor[1] = pActuales[1].cuitProv;
            detallesproveedor[2]= pActuales[1].direccionProv;
            detallesproveedor[3] = pActuales[1].ciudadProv;
            detallesproveedor[4] = pActuales[1].provinciaProv;
            detallesproveedor[5] = pActuales[1].codigoPostalProv;
            // detallesproveedor[6] = pActuales[1]. faltaria email;
            // detallesproveedor[7] = pActuales[1]. faltaria telefonos;
            detallesproveedor[8] = pActuales[1].obsProv;
            return detallesproveedor;
        }

        
    
    }
}
