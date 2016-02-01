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
            /// All: no tiene en cuenta los parametros de búsqueda. Retorna todas las filas encontradas en la base de datos
            /// </summary>
            private const string All = "all";
            /// <summary>
            /// Any: busca de acuerdo a los parámetros que se hayan inicializado. Pueden ser 0, 1, 2 o más
            /// </summary>
            private const string Any = "any";
            public static class Entidades
            {
                private const string CodigoEntidad = "codigoEntidad";
                private const string Cuit = "cuit";

                public static class Personas
                {
                    public const string All = ParametrosBusqueda.All;
                    public const string Any = ParametrosBusqueda.Any;

                    public const string CodigoEntidad = ParametrosBusqueda.Entidades.CodigoEntidad;
                    public const string Cuit = ParametrosBusqueda.Entidades.Cuit;

                    public const string Nombre = "nombre";
                    public const string Apellido = "apellido";
                    public const string Dni = "dni";

                    public const string Usuario = "usuario";
                    public const string TipoPersona = "tipoPersona";
                }
                public static class Proveedores
                {
                    public const string All = ParametrosBusqueda.All;
                    public const string Any = ParametrosBusqueda.Any;

                    public const string CodigoEntidad = ParametrosBusqueda.Entidades.CodigoEntidad;
                    public const string Cuit = ParametrosBusqueda.Entidades.Cuit;

                    public const string RazonSocial = "razonSocial";
                }
            }

            public static class Articulos
            {
                public const string All = ParametrosBusqueda.All;
                public const string Any = ParametrosBusqueda.Any;

                public const string CodigoOriginal = "codigoOriginal";
                public const string Descripcion = "descripcion";
            }

            public static class ArticulosProveedores
            {
                public const string All = ParametrosBusqueda.All;
                public const string Any = ParametrosBusqueda.Any;

                public const string CodigoOriginal = Articulos.CodigoOriginal;
                public const string CodigoArticuloProveedor = "codigoArticuloProveedor";
                public const string Descripcion = Articulos.Descripcion;
                public const string DescripcionArticuloProveedor = "descripcionArticuloProveedor";
                public const string codigoEntidadProveedor = "codigoEntidadProveedor";
                public const string razonSocialProveedor = "razonSocialProveedor";
            }


            public static class Paises
            {
                public const string All = ParametrosBusqueda.All;
                public const string Any = ParametrosBusqueda.Any;

                public const string Codigo = "codigoPais";
                public const string Pais = "nombrePais";
            }
            public static class Provincias
            {
                public const string All = ParametrosBusqueda.All;
                public const string Any = ParametrosBusqueda.Any;

                public const string CodigoPais = ParametrosBusqueda.Paises.Codigo;
                public const string CodigoProvincia = "codigoProvincia";
                public const string Provincia = "nombreProvincia";

            }
        }
        public static class TiposArticulo
        {
            public const string ArticuloBase = "ART";
            public const string ArticuloProveedor = "ART_PROV";

        }
    }
    
}
