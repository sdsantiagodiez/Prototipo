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

        public static string NumeroALetras(string num)
        {
            string res, dec = "";
            Int64 entero;
            int decimales;
            double nro;

            try
            {
                nro = Convert.ToDouble(num);
            }
            catch
            {
                return "";
            }

            entero = Convert.ToInt64(Math.Truncate(nro));
            decimales = Convert.ToInt32(Math.Round((nro - entero) * 100, 2));

            if (decimales > 0)
            {
                dec = " CON " + decimales.ToString() + "/100";
            }

            res = Transformar.NumeroALetras(Convert.ToDouble(entero)) + dec;
            return res;
        }

        private static string NumeroALetras(double value)
        {
            string Num2Text = "";
            value = Math.Truncate(value);

            if (value == 0) Num2Text = "CERO";
            else if (value == 1) Num2Text = "UNO";
            else if (value == 2) Num2Text = "DOS";
            else if (value == 3) Num2Text = "TRES";
            else if (value == 4) Num2Text = "CUATRO";
            else if (value == 5) Num2Text = "CINCO";
            else if (value == 6) Num2Text = "SEIS";
            else if (value == 7) Num2Text = "SIETE";
            else if (value == 8) Num2Text = "OCHO";
            else if (value == 9) Num2Text = "NUEVE";
            else if (value == 10) Num2Text = "DIEZ";
            else if (value == 11) Num2Text = "ONCE";
            else if (value == 12) Num2Text = "DOCE";
            else if (value == 13) Num2Text = "TRECE";
            else if (value == 14) Num2Text = "CATORCE";
            else if (value == 15) Num2Text = "QUINCE";
            else if (value < 20) Num2Text = "DIECI" + NumeroALetras(value - 10);
            else if (value == 20) Num2Text = "VEINTE";
            else if (value < 30) Num2Text = "VEINTI" + NumeroALetras(value - 20);
            else if (value == 30) Num2Text = "TREINTA";
            else if (value == 40) Num2Text = "CUARENTA";
            else if (value == 50) Num2Text = "CINCUENTA";
            else if (value == 60) Num2Text = "SESENTA";
            else if (value == 70) Num2Text = "SETENTA";
            else if (value == 80) Num2Text = "OCHENTA";
            else if (value == 90) Num2Text = "NOVENTA";

            else if (value < 100) Num2Text = NumeroALetras(Math.Truncate(value / 10) * 10) + " Y " + NumeroALetras(value % 10);
            else if (value == 100) Num2Text = "CIEN";
            else if (value < 200) Num2Text = "CIENTO " + NumeroALetras(value - 100);
            else if ((value == 200) || (value == 300) || (value == 400) || (value == 600) || (value == 800)) Num2Text = NumeroALetras(Math.Truncate(value / 100)) + "CIENTOS";

            else if (value == 500) Num2Text = "QUINIENTOS";
            else if (value == 700) Num2Text = "SETECIENTOS";
            else if (value == 900) Num2Text = "NOVECIENTOS";
            else if (value < 1000) Num2Text = NumeroALetras(Math.Truncate(value / 100) * 100) + " " + NumeroALetras(value % 100);
            else if (value == 1000) Num2Text = "MIL";
            else if (value < 2000) Num2Text = "MIL " + NumeroALetras(value % 1000);
            else if (value < 1000000)
            {
                Num2Text = NumeroALetras(Math.Truncate(value / 1000)) + " MIL";
                if ((value % 1000) > 0) Num2Text = Num2Text + " " + NumeroALetras(value % 1000);
            }

            else if (value == 1000000) Num2Text = "UN MILLON";
            else if (value < 2000000) Num2Text = "UN MILLON " + NumeroALetras(value % 1000000);
            else if (value < 1000000000000)
            {
                Num2Text = NumeroALetras(Math.Truncate(value / 1000000)) + " MILLONES ";
                if ((value - Math.Truncate(value / 1000000) * 1000000) > 0) Num2Text = Num2Text + " " + NumeroALetras(value - Math.Truncate(value / 1000000) * 1000000);
            }
            else if (value == 1000000000000) Num2Text = "UN BILLON";
            else if (value < 2000000000000) Num2Text = "UN BILLON " + NumeroALetras(value - Math.Truncate(value / 1000000000000) * 1000000000000);
            else
            {
                Num2Text = NumeroALetras(Math.Truncate(value / 1000000000000)) + " BILLONES";
                if ((value - Math.Truncate(value / 1000000000000) * 1000000000000) > 0) Num2Text = Num2Text + " " + NumeroALetras(value - Math.Truncate(value / 1000000000000) * 1000000000000);
            }

            return Num2Text;
        }
    }
}
