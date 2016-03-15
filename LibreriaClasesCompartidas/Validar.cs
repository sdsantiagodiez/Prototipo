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
            Regex lcl_patron = new Regex(@"^[\w\s0-9]*$");
            return lcl_patron.IsMatch(p_string);
        }

    }
}
