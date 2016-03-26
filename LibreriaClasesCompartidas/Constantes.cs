using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClasesCompartidas
{
    public static class Constantes
    {
        /// <summary>
        /// Cadenas de caracteres definidas para cada modelo del proyecto que se utilizarán para determinar cómo será realizada la búsqueda en los métodos de búsqueda
        /// </summary>
        public static class ParametrosBusqueda
        {
            /// <summary>
            /// All: no tiene en cuenta los parametros de búsqueda. Retorna todas las filas encontradas en la base de datos
            /// </summary>
            public const string All = "all";
            /// <summary>
            /// Any: busca de acuerdo a los parámetros que se hayan inicializado. Pueden ser 0, 1, 2 o más
            /// </summary>
            public const string Any = "any";
            /// <summary>
            /// Busca por clave primaria
            /// </summary>
            public const string One = "one";
            public static class Entidades
            {
                public const string CodigoEntidad = "codigoEntidad";
                public const string Cuit = "cuit";

                public static class Personas
                {
                    public const string CodigoEntidad = ParametrosBusqueda.Entidades.CodigoEntidad;
                    public const string Cuit = ParametrosBusqueda.Entidades.Cuit;

                    public const string Nombre = "nombre";
                    public const string Apellido = "apellido";
                    public const string Dni = "dni";
                    public const string TipoPersona = "tipoPersona";

                    public static class Usuarios
                    {                        
                        public const string Usuario = "usuario";
                        public const string LogIn = "log In";
                    }

                    public static class ContactoProveedor
                    {
                        public const string CodigoEntidad = ParametrosBusqueda.Entidades.Personas.CodigoEntidad;
                        public const string Cuit = ParametrosBusqueda.Entidades.Personas.Cuit;

                        public const string CodigoEntidad_Proveedor = "codigoEntidad de proveedor";
                        public const string Cuit_Proveedor = "cuit proveedor";
                        public const string RazonSocial_Proveedor = "razonSocial proveedor";
                    }
                    
                }
                public static class Proveedores
                {
                    //Se cambia para que en CatalogoContactoProveedor no haya confusion entre codigoEntidad de contacto y de proveedor
                    public const string CodigoEntidad = ParametrosBusqueda.Entidades.CodigoEntidad;
                    public const string Cuit = ParametrosBusqueda.Entidades.Cuit;

                    public const string RazonSocial = "razonSocial";
                }
            }

            public static class Roles
            {
                public const string codigoRol = "codigoRol";
            }
            public static class Articulos
            {
                public const string CodigoOriginal = "codigoOriginal";
                public const string Descripcion = "descripcion";
            }

            public static class ArticulosProveedores
            {
                public const string CodigoOriginal = Articulos.CodigoOriginal;
                public const string CodigoArticuloProveedor = "codigoArticuloProveedor";
                public const string Descripcion = Articulos.Descripcion;
                public const string DescripcionArticuloProveedor = "descripcionArticuloProveedor";
                public const string codigoEntidadProveedor = "codigoEntidadProveedor";
                public const string razonSocialProveedor = "razonSocialProveedor";
            }

            public static class Pedidos
            {
                public const string NumeroPedido = "numeroPedido";
                public const string Fecha = "fecha";
                public const string Tipo = "tipoPedido";
            }

            public static class LineasPedidos
            {
                public const string NumeroPedido = Pedidos.NumeroPedido;
                public const string CodigoArticuloProveedor = ArticulosProveedores.CodigoArticuloProveedor;
                public const string CodigoOriginal = ArticulosProveedores.CodigoOriginal;
                public const string Descripcion = "descripcion";
                //public const string Cantidad = "cantidad";
                //public const string ValorUnitario = "valorUnitario";
                //public const string ValorParcial = "valorParcial";
            }

            public static class Paises
            {
                public const string Codigo = "codigoPais";
                public const string Pais = "nombrePais";
            }
            public static class Provincias
            {
                public const string CodigoPais = ParametrosBusqueda.Paises.Codigo;
                public const string CodigoProvincia = "codigoProvincia";
                public const string Provincia = "nombreProvincia";

            }
        }
        
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

        public enum CodigosTiposPedidos 
        {
            TipoPedidoPersona=1,
            TipoPedidoProveedor=2
        }
        
        public static class TiposArticulo
        {
            public const string ArticuloBase = "ART";
            public const string ArticuloProveedor = "ART_PROV";

        }

        public static class TipoTelefono
        {
            public const string Fijo = "TEL";
            public const string Celular = "CEL";
            public const string Fax = "FAX";
        }

        public static class TipoValorArticulo
        {
            public const string Compra = "Compra";
            public const string Venta = "Venta";
        }

        public static class TipoRoles
        {
            public const string Compras = "Encargado de Compras";
            public const string Ventas = "Encargado de Ventas";
            public const string Datos_ABM = "Encargado de Altas, Bajas y Modificación de datos";
            public const string Datos_Reportes = "Encargado de Reportes";
            public const string Admin = "Admin";
        }

    }
    
}
