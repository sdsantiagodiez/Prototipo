using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LibreriaClasesCompartidas
{
    public class Validar
    {
        /*************************************************************************************************/
        /* Los caracteres especiales como / y + están en codigo hexadecimal, recordar al testearlos que  */
        /* puede sea necesario pasarlos a unicode, octal, u otros                                        */
        /*************************************************************************************************/

        public static bool validarNumerico(string p_numero, string p_opcion)
        {
            bool resultado;
            decimal numeroDecimal;
            int numeroEntero;
            switch (p_opcion)
            {
                case Constantes.Numericos.Porcentual:
                    try
                    {
                        resultado=Decimal.TryParse(p_numero,out numeroDecimal) ;
                        if (numeroDecimal <= 1)
                        {
                            resultado = true;
                        }
                        else
                        {
                            resultado = false;
                        }
                    }
                    catch(FormatException)
                    {
                        resultado = false;
                    }
                    break;                    
                case Constantes.Numericos.EnteroPositivoSinCero:
                    try
                    {
                        resultado = int.TryParse(p_numero, out numeroEntero);
                        if (numeroEntero > 0)
                        {
                            resultado = true;
                        }
                        else
                        {
                            resultado = false;
                        }
                    }
                    catch(FormatException)
                    {
                        resultado = false;
                    }
                    break;
                case Constantes.Numericos.Entero:
                    try
                    {
                        resultado = int.TryParse(p_numero, out numeroEntero);
                    }
                    catch (FormatException)
                    {
                        resultado = false;
                    }
                    break;
                case Constantes.Numericos.Decimal:
                    try
                    {
                        resultado = Decimal.TryParse(p_numero, out numeroDecimal);
                    }
                    catch(FormatException)
                    {
                        resultado = false;
                    }
                    break;
                case Constantes.Numericos.EnteroPositivo:
                    try
                    {
                        resultado = int.TryParse(p_numero, out numeroEntero);
                        if(numeroEntero>=0)
                        {
                            resultado = true;
                        }
                        else
                        {
                            resultado = false;
                        }
                    }
                    catch (FormatException)
                    {
                        resultado = false;
                    }
                    break;
                case Constantes.Numericos.DecimalPositivo:
                    try
                    {
                        resultado = Decimal.TryParse(p_numero, out numeroDecimal);
                        if(numeroDecimal>0)
                        {
                            resultado = true;
                        }
                        else
                        {
                            resultado = false;
                        }
                    }
                    catch(FormatException)
                    {
                        resultado = false;
                    }
                    break;
                default:
                    resultado=false;
                    break;
            }
            return resultado;
        }

        public static bool validarInput(string p_string, string p_opcion)
        {
            string especial = "";
            Regex lcl_patron = new Regex(@"^.*$");
            DateTime fecha;
            switch (p_opcion)
            {
                case Constantes.ParametrosBusqueda.Pedidos.CAE:
                    lcl_patron = new Regex(@"^\d{14}$");
                    break;
                case Constantes.ParametrosBusqueda.Articulos.CodigoOriginal:
                    //Admite un patrón especifico: 2 nros + "-" + 3letras + "-" + 3 + letras + "-" + 2 nros
                    //EJ_ "00-ART-REN-00"
                    lcl_patron = new Regex(@"^\d{2}-[a-zA-Z]{3}-[a-zA-Z]{3}-\d{2}$");
                    break;
                case Constantes.ParametrosBusqueda.ArticulosProveedores.CodigoArticuloProveedor:
                    //Admite un patrón especifico: 4 letras + "-" + 2 nros + "/" + 2 nros + "-" + 3letras + "-" + 3 + letras + "-" + 2 nros + "/" + 2 nros
                    //EJ: "PROV-01/00-ART-REN-00/01"
                    lcl_patron = new Regex(@"^[a-zA-Z]{4}-\d{2}\x2F\d{2}-[a-zA-Z]{3}-[a-zA-Z]{3}-\d{2}\x2F\d{2}$");
                    break;
                case Constantes.ParametrosBusqueda.Articulos.Descripcion:
                case Constantes.ParametrosBusqueda.ArticulosProveedores.DescripcionArticuloProveedor:
                case Constantes.ParametrosBusqueda.ArticulosProveedores.razonSocialProveedor:
                case Constantes.ParametrosBusqueda.Entidades.Proveedores.RazonSocial:
                case Constantes.ParametrosBusqueda.Entidades.Personas.ContactoProveedor.RazonSocial_Proveedor:
                case Constantes.ParametrosBusqueda.Entidades.Personas.Usuarios.Contrasenia:
                case Constantes.ParametrosBusqueda.Articulos.Observaciones:
                case Constantes.ParametrosBusqueda.Pedidos.Observaciones:
                case Constantes.ParametrosBusqueda.Entidades.Observaciones:
                //Admite cualquier caracter, sin restricción de repeticiones de los mismos
                    lcl_patron = new Regex(@"^.*$");
                    break;
                case Constantes.ParametrosBusqueda.Entidades.Personas.Usuarios.Usuario:
                    // Admite alfanuméricos, al menos uno en la cadena
                    lcl_patron = new Regex(@"^\w+$");
                    break;
                case Constantes.ParametrosBusqueda.Entidades.Personas.Nombre:
                case Constantes.ParametrosBusqueda.Entidades.Personas.Apellido:
                    // Admite sólo letras, minusculas o mayúsculas, exigiendo al menos 1 caracter en la cadena.
                    lcl_patron = new Regex(@"^[a-zA-Z]+$");
                    break;
                case Constantes.ParametrosBusqueda.Entidades.Cuit:
                case Constantes.ParametrosBusqueda.Entidades.Personas.ContactoProveedor.Cuit_Proveedor:
                    // Admite patrón especifico: 2 nros + "-" + 8 nros + "-" + 1 nro
                    lcl_patron = new Regex(@"^\d{2}-\d{8}-\d{1}$");
                    break;
                case Constantes.ParametrosBusqueda.Entidades.Personas.Dni:
                    // Admite exactamente 8 dígitos
                    lcl_patron = new Regex(@"^\d{8}$");
                    break;
                case Constantes.ParametrosBusqueda.Pedidos.Fecha:
                    especial = Constantes.ParametrosBusqueda.Pedidos.Fecha;
                    break;
                case Constantes.ParametrosBusqueda.Domicilios.Piso:
                    // Admite entre 1 y 2 dígitos
                    lcl_patron = new Regex(@"^\d{1,2}$");
                    break;
                case Constantes.ParametrosBusqueda.Domicilios.Departamento:
                    // Admite alfanuméricos minimo 1, máximo 3
                    lcl_patron = new Regex(@"^\w{1,3}$");
                    break;
                case Constantes.ParametrosBusqueda.Telefonos.NumeroTelefono:
                    // Admite el siguiente patron: "+" opcional  + 10 a 13 dígitos
                    lcl_patron = new Regex(@"^\x2B?\d{10,13}$");
                    break;
                case Constantes.ParametrosBusqueda.Domicilios.CodigoPostal:
                    // Admite el siguiente patrón: 0 o 1 letra + 4 nros + zero o 3 letras
                    lcl_patron = new Regex(@"^[a-zA-Z]?\d{4}([a-zA-Z]{3})?$");
                    break;
                case Constantes.ParametrosBusqueda.ArticulosProveedores.Modelo:
                case Constantes.ParametrosBusqueda.ArticulosProveedores.Ubicacion:
                case Constantes.ParametrosBusqueda.Domicilios.Calle:
                    //Admite Alfanumericos con espacios
                    lcl_patron = new Regex(@"^[\w\s]*$");
                    break;
                default:
                    break;
            }

            if (String.Equals(especial, Constantes.ParametrosBusqueda.Pedidos.Fecha))
            {
                return DateTime.TryParse(p_string, out fecha);
            }
            else if (String.Equals(especial, Constantes.ParametrosBusqueda.Mails.Mail))
            {
                try
                {
                    System.Net.Mail.MailAddress m = new System.Net.Mail.MailAddress(p_string);

                    return true;
                }
                catch (FormatException)
                {
                    return false;
                }
            }
            {
                return lcl_patron.IsMatch(p_string);
            }
            
        }
    }
}
