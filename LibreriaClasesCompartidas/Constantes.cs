using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

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
                public const string Observaciones = "observacionesEntidad";

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
                        public const string Contrasenia = "contrasenia";
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
                public const string Observaciones = "observacionesArticulo";
            }

            public static class ArticulosProveedores
            {
                public const string CodigoOriginal = Articulos.CodigoOriginal;
                public const string CodigoArticuloProveedor = "codigoArticuloProveedor";
                public const string Descripcion = Articulos.Descripcion;
                public const string DescripcionArticuloProveedor = "descripcionArticuloProveedor";
                public const string codigoEntidadProveedor = "codigoEntidadProveedor";
                public const string razonSocialProveedor = "razonSocialProveedor";
                public const string Observaciones = Constantes.ParametrosBusqueda.Articulos.Observaciones;
                public const string Modelo = "modeloArticuloProveedor";
                public const string Ubicacion = "ubicacionArticuloProveedor";
            }

            public static class Pedidos
            {
                public const string CAE = "CAE";
                public const string NumeroPedido = "numeroPedido";
                public const string Fecha = "fecha";
                public const string Tipo = "tipoPedido";
                public const string Observaciones = "observacionesPedido";
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
            public static class Domicilios
            {
                public const string CodigoDomicilio = "codigoDomicilio";
                public const string CodigoEntidad = ParametrosBusqueda.Entidades.CodigoEntidad;
                public const string Calle = "calle";
                public const string NumeroDomicilio = "numeroDomicilio";
                public const string Piso = "piso";
                public const string Departamento = "departamento";
                public const string Ciudad = "ciudad";
                public const string CodigoPostal = "codigoPostal";
                public const string CodigoProvincia = ParametrosBusqueda.Provincias.CodigoProvincia;
            }
            public static class Mails
            {
                public const string CodigoEntidad = ParametrosBusqueda.Entidades.CodigoEntidad;
                public const string CodigoMail = "codigoMail";
                public const string Mail = "mail";
            }
            public static class Telefonos
            {
                public const string CodigoEntidad = ParametrosBusqueda.Entidades.CodigoEntidad;
                public const string CodigoTelefono = "codigoTelefono";
                public const string NumeroTelefono = "numeroTelefono";
                public const string TipoTelefono = "tipoTelefono";
            }
            public static class Descuentos
            {
                public const string Descripcion = "descripcionDescuento";
                public const string Porcentaje = "porcentaje";
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

        public enum FormaDePago
        {
            Contado =1,
            [System.ComponentModel.Description("Crédito")]
            Credito=2,
            [System.ComponentModel.Description("Débito")]
            Debito=3,
            Cheque=4,
            Otro=5,
            [System.ComponentModel.Description("Múltiple")]
            Multiple=6
        }

        public enum TipoComprobanteVenta
        {
            Factura = 1,
            Recibo =2,
            [System.ComponentModel.Description("Nota de Venta al Contado")]
            NotaVentaAlContado = 3,
            Presupuesto = 4,
            Reserva=5,
            
            Otro = 30
        }

        public enum TipoComprobanteDevolucion
        {
            [System.ComponentModel.Description("Nota de Crédito")]
            NotaCredito = 1
            //[System.ComponentModel.Description("Nota de Débito")]
            //NotaDebito = 3,
        }
        public enum TipoComprobanteCompra
        {
            [System.ComponentModel.Description("Pedido a Proveedor")]
            Pedido_Proveedor = 1,
            
            Otro = 30
        }
        
        public static string GetDescription<T>(this T enumerationValue)
             where T : struct
        {
            Type type = enumerationValue.GetType();
            if (!type.IsEnum)
            {
                throw new ArgumentException("EnumerationValue must be of Enum type", "enumerationValue");
            }

            //Intenta encontrar si el enum tiene descripción
            System.Reflection.MemberInfo[] memberInfo = type.GetMember(enumerationValue.ToString());
            if (memberInfo != null && memberInfo.Length > 0)
            {
                object[] attrs = memberInfo[0].GetCustomAttributes(typeof(System.ComponentModel.DescriptionAttribute), false);

                if (attrs != null && attrs.Length > 0)
                {
                    //retorna descripción del enum
                    return ((System.ComponentModel.DescriptionAttribute)attrs[0]).Description;
                }
            }
            //Si no hay descripción, devuelve ToString()
            return enumerationValue.ToString();

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
            public const string Datos_ABM = "Encargado de Datos";
            public const string Datos_Reportes = "Encargado de Reportes";
            public const string Admin = "Admin";
        }

        public static class Numericos
        {
            public const string Decimal = "decimal";
            public const string DecimalPositivo = "decimalPositivo";
            public const string Porcentual = "porcentual";
            public const string Entero = "entero";
            public const string EnteroPositivoSinCero = "enteroPositivoSinCero";
            public const string EnteroPositivo = "enteroPositivo";
            public const string Descuento = "descuento";
        }
        public static class Estado
        {
            public const bool Activo = true;
            public const bool Inactivo = false;
        }
    }
    
}
