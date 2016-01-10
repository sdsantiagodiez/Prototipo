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
        /// <summary>
        /// Cadenas de caracteres definidas para cada modelo del proyecto que se utilizarán para determinar cómo será realizada la búsqueda en los métodos de búsqueda
        /// </summary>
        public static class ParametrosBusqueda
        {
            /// <summary>
            /// Se utiliza para buscar un modelo por 2 o más parametros de búsqueda
            /// </summary>
            private const string All = "all";

            public static class Entidades
            {
                private const string CodigoEntidad = "codigoEntidad";
                private const string Cuit = "cuit";
                
                public static class Personas
                {
                    public const string All = ParametrosBusqueda.All;
                    
                    public const string CodigoEntidad = ParametrosBusqueda.Entidades.CodigoEntidad;
                    public const string Cuit = ParametrosBusqueda.Entidades.Cuit;

                    public const string Nombre = "nombre";
                    public const string Appelido = "apellido";
                    public const string Dni = "dni";
                }
                public static class Proveedores
                {
                    public const string All = ParametrosBusqueda.All;

                    public const string CodigoEntidad = ParametrosBusqueda.Entidades.CodigoEntidad;
                    public const string Cuit = ParametrosBusqueda.Entidades.Cuit;

                    public const string RazonSocial = "razonSocial";
                }
            }

            public static class Articulos
            {
                public const string All = ParametrosBusqueda.All;

                public const string CodigoOriginal = "codigoOriginal";
                public const string Descripcion = "descripcion";
            }

            public static class ArticulosProveedores
            {
                public const string All = ParametrosBusqueda.All;

                public const string CodigoOriginal = Articulos.CodigoOriginal;
                public const string CodigoArticuloProveedor = "codigoArticuloProveedor";
                public const string Descripcion = Articulos.Descripcion;
                public const string Proveedor = "proveedor";
            }
        }
    }
}
