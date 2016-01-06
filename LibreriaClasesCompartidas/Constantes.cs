using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClasesCompartidas
{
    public static class Constantes
    {
        public static class TiposEntidad
        {
            public const string Persona = "PER"; 
            public const string Proveedor = "PRO";
 
            public static class TiposPersona
            {
                public const string Cliente = "CLI"; 
                public const string Usuario = "USR";
                public const string ContactoProveedor = "CPR";     
            }
            public static class TiposProveedor
            {
                //Se diferenciaría de TiposEntidad.Proveedor en que TiposEntidad.Proveedor es la clasificación que divide a las entidades entre proveedores y personas.
                //Mientras que TiposProveedor.Proveedor es una subclase de TiposEntidad.Proveedor al nivel de Cliente, Usuario y ContactoProveedor
                public const string Proveedor = "PRO";  
            }
        }
    }
}
