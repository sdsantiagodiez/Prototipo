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
        /*LA INTENCION ES GENERAR DOS O TRES MÉTODOS QUE MANEJEN TODAS LAS VALIDACIONES                  */
        /*UTILIZANDO LOS PARÁMETROS PARA SABER QUE EXPRESIÓN REGULAR APLICAR AL VALIDAR                  */
        /*ACTUALMENTE NO ESTÁ ESTRUCTURADO DE TAL MANERA, SE HARA UNA VEZ SE TENGAN TODAS LAS EXPRESIONES*/
        /*REGULARES REQUERIDAS.                                                                          */
        /*************************************************************************************************/
        /* Los caracteres especiales como / y + están en codigo hexadecimal, recordar al testearlos que  */
        /* puede sea necesario pasarlos a unicode, octal, u otros                                        */
        /*************************************************************************************************/
        
        public static bool validarValorDecimal(string p_stringDecimal)
        {
            decimal numero;
            return Decimal.TryParse(p_stringDecimal, out numero);
        }

        public static bool validarValorNumerico(string p_stringNumero)
        {
            int numero;
            return Int32.TryParse(p_stringNumero, out numero);
        }

        public static bool validarEnteroPositivoSinCero(string p_numero)
        {
            if (Validar.validarValorNumerico(p_numero))
            {
                if (Int32.Parse(p_numero) > 0)
                {
                    return true;
                }
                else return false;
            }
            else return false;
        }

        public static bool validarAlfanumericoConEspaciosSinCaracteresEspeciales(string p_string)
        {
            //Regex(@"^[\w\s-_/0-9]*$") para incluir algunos caracteres especiales necesarios. Quizas en otro método 
            //Admite Alfanumericos con espacios
            //Aplicar sobre : Modelo, Ubicación, Calle
            Regex lcl_patron = new Regex(@"^[\w\s]*$");
            return lcl_patron.IsMatch(p_string);
        }

        public static bool validarBusquedaArticulos(string p_string, string p_opcion)
        {
            Regex lcl_patron;

            switch (p_opcion)
            {
                case Constantes.ParametrosBusqueda.ArticulosProveedores.CodigoOriginal:
                    //Admite un patrón especifico: 2 nros + "-" + 3letras + "-" + 3 + letras + "-" + 2 nros
                    //EJ_ "00-ART-REN-00"
                    lcl_patron = new Regex(@"\d{2}-[a-zA-Z]{3}-[a-zA-Z]{3}-\d{2}");
                    break;
                case Constantes.ParametrosBusqueda.ArticulosProveedores.CodigoArticuloProveedor:
                    //Admite un patrón especifico: 4 letras + "-" + 2 nros + "/" + 2 nros + "-" + 3letras + "-" + 3 + letras + "-" + 2 nros + "/" + 2 nros
                    //EJ: "PROV-01/00-ART-REN-00/01"
                    lcl_patron = new Regex(@"[a-zA-Z]{4}-\d{2}\x2F\d{2}-[a-zA-Z]{3}-[a-zA-Z]{3}-\d{2}\x2F\d{2}");
                    break;
                case Constantes.ParametrosBusqueda.ArticulosProveedores.Descripcion:
                    //Admite cualquier caracter, sin restricción de repeticiones de los mismos
                    //Aplicar sobre: Descripción, Observaciones, Razón Social, Contraseñas
                    lcl_patron = new Regex(@".*");
                    break;
                default:
                    lcl_patron = new Regex(@".*");
                    break;
            }

            return lcl_patron.IsMatch(p_string);
        }

        public static bool validaciones(string p_string, string p_opcion)
        {
            Regex lcl_patron;
            // Admite sólo letras, minusculas o mayúsculas, exigiendo al menos 1 caracter en la cadena.
            // Aplicar sobre: Nombres, Apellidos
            lcl_patron = new Regex(@"[a-zA-Z]+");
            // Admite patrón especifico: 2 nros + "-" + 8 nros + "-" + 1 nro
            // Aplicar sobre: CUIT-CUIL
            lcl_patron = new Regex(@"\d{2}-\d{8}-\d{1}");
            // Admite exactamente 8 dígitos
            // Aplicar sobre: DNI
            lcl_patron = new Regex(@"\d{8}");
            // Admite entre 1 y 2 dígitos
            // APlicar sobre: Piso de depto
            lcl_patron = new Regex(@"\d{1,2}");
            // Admite alfanuméricos minimo 1, máximo 3
            // Aplicar sobre: Departamento
            lcl_patron = new Regex(@"\w{1,3}");
            // Admite el siguiente patron: "+" opcional  + 10 a 13 dígitos
            // Aplicar sobre: teléfono
            lcl_patron = new Regex(@"\x2B?\d{10,13}");
            // Admite el siguiente patrón: 0 o 1 letra + 4 nros + zero o 3 letras
            //Aplicar sobre : Código postal argentino
            lcl_patron = new Regex(@"[a-zA-Z]?\d{4}([a-zA-Z]{3})?");
            // Admite alfanuméricos, al menos uno en la cadena
            //Aplicar sobre: Usuarios
            lcl_patron = new Regex(@"\w+");


            //para mails
            //try
            //{
            //    System.Net.Mail.MailAddress m = new System.Net.Mail.MailAddress(emailaddress);

            //    return true;
            //}
            //catch (FormatException)
            //{
            //    return false;
            //}
            
            return lcl_patron.IsMatch(p_string);
            
            //en caso de fechas
            //return DateTime.TryParse(string, parametroDeRetorno)
            //porcentaje
            //Decimal.TryParse(nro,output) AND nro <=1
        }
    }
}
