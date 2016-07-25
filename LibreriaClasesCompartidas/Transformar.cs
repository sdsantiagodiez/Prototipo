using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace LibreriaClasesCompartidas
{
    public class Transformar
    {
        /// <summary>
        /// Remueve dobles o más espacios, espacios al inicio y final, y vocales no permitidas
        /// </summary>
        /// <param name="p_string"></param>
        /// <returns></returns>
        public static string limpiarString(string p_string)
        {
            string lcl_stringTransformada = p_string;
            
            lcl_stringTransformada = Transformar.quitarEspaciosEnBlanco(lcl_stringTransformada);
            lcl_stringTransformada = Transformar.transformarVocalesInvalidas(lcl_stringTransformada);
            
            return lcl_stringTransformada;
        }

        public static string quitarEspaciosEnBlanco(string p_string)
        {
            Regex r_espaciosMultiples = new Regex(@"(\s{2,})");
            Regex r_espaciosInicioFin = new Regex(@"(^\s{1,}|\s{1,}$)");
            return r_espaciosInicioFin.Replace(r_espaciosMultiples.Replace(p_string, " "), "");
        }
        public static string transformarVocalesInvalidas(string p_string)
        {
            string lcl_stringTransformada = p_string;

            Regex r_vocalA = new Regex("(Á|À|Ä)");
            Regex r_vocalE = new Regex("(É|È|Ë)");
            Regex r_vocalI = new Regex("(Í|Ì)");
            Regex r_vocalO = new Regex("(Ó|Ò)");
            Regex r_vocalU = new Regex("(Ú|Ù|Ü)");

            lcl_stringTransformada = r_vocalA.Replace(lcl_stringTransformada, "A");
            lcl_stringTransformada = r_vocalE.Replace(lcl_stringTransformada, "E");
            lcl_stringTransformada = r_vocalI.Replace(lcl_stringTransformada, "I");
            lcl_stringTransformada = r_vocalO.Replace(lcl_stringTransformada, "O");
            lcl_stringTransformada = r_vocalU.Replace(lcl_stringTransformada, "U");

            return lcl_stringTransformada;
        }
        /// <summary>
        /// Elimina todas las comas y puntos que puedan sobrar y sólo considera la más próxima a los decimales
        /// Por ejempo: 123.256.456,2-> 123256456,2 || 12,653,32,31,8 -> 126533231,8
        /// </summary>
        /// <param name="p_string"></param>
        /// <param name="p_decimal"></param>
        /// <returns></returns>
        public static bool ToDecimal(string p_string, out decimal p_decimal)
        {
            if (string.IsNullOrWhiteSpace(p_string))
            {
                p_decimal = 0;
                return false;
            }
            //Regex r_puntoPorComa = new Regex(@"\.");
            //r_puntoPorComa.Replace(p_string, "");
            p_string = p_string.Replace('.', ',');

            p_string = Transformar.ToDecimal_quitarComasSobrantes(p_string);

            return Decimal.TryParse(p_string, out p_decimal);
        }
        private static string ToDecimal_quitarComasSobrantes(string p_string)
        {
            string result = p_string;
            Regex r_separadorDecimal = new Regex(@",.*,");
            if (r_separadorDecimal.IsMatch(p_string))
            {
                //quiere decir que hay más de una coma en el número. Se eliminan las comas hasta que sólo haya una 
                Regex rgx = new Regex(@",");
                result = Transformar.ToDecimal_quitarComasSobrantes(rgx.Replace(p_string, "", 1));
            }
            return result;
        }
    }
}
