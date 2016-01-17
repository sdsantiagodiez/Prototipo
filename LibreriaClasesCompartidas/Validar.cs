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
        public static bool validarValorNumerico(string p_stringNumero)
        {
            int numero;
            return Int32.TryParse(p_stringNumero, out numero);
        }

        public static bool validarEnteroPositivoSinCero(int p_numero)
        {
            if (p_numero > 0)
            {
                return true;
            }
            else return false;
        }

        public static bool validarAlfanumericoConEspaciosSinCaracteresEspeciales(string p_string)
        {
            Regex lcl_patron = new Regex(@"^[a-zA-Z0-9\s]*$");
            return lcl_patron.IsMatch(p_string);
        }

    }
}
