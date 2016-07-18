using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Modelos
{
    [Serializable]
    public class Modelo
    {
        /// <summary>
        /// Quita espacios
        /// </summary>
        /// <param name="p_string"></param>
        /// <returns></returns>
        public string convertirString(string p_string)
        {
            if (p_string != null)
            {
                string string_convertida = LibreriaClasesCompartidas.Transformar.limpiarString(p_string);
                if (string_convertida.Length > 0)
                    return string_convertida;
            }

            return null;
        }

        public static string convertString(string p_string)
        {
            if (p_string != null)
            {
                string string_convertida = LibreriaClasesCompartidas.Transformar.limpiarString(p_string);
                if (string_convertida.Length > 0)
                    return string_convertida;
            }
            return null;
        }

        private bool Equals_Lists(IEnumerable<object> p_lista_original, IEnumerable<object> p_lista_nueva)
        {
            int count_original = 0;
            foreach (var a in p_lista_original)
                {count_original++;}
            
            int count_nuevo = 0;
            foreach (var a in p_lista_nueva)
                {count_nuevo++;}
            
            if (count_original != count_nuevo)
                return false;
            else
            {
                bool respuesta;
                foreach (object o_original in p_lista_original)
                { 
                    respuesta = false;
                    foreach (object o_nuevo in p_lista_nueva)
                    {
                        if (o_original.Equals(o_nuevo))
                        {
                            respuesta = true;
                        }
                    }
                    if (!respuesta)
                    {
                        return false;
                    }
                }
                return true;
            }

        }

        protected new bool Equals(object o_original, object o_nuevo)
        {
            //ambos no nulos
            if (o_original != null && o_nuevo != null)
            {
                if (o_original is System.Collections.IList)
                    return this.Equals_Lists((IEnumerable<object>)o_original, (IEnumerable<object>)o_nuevo);
                else
                    return o_original.Equals(o_nuevo);
            }
            //Si alguno es nulo y el otro no, no son iguales
            return o_original == null && o_nuevo == null;
        }
    }
}
