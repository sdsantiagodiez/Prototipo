using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Modelo
    {
        private bool Equals_Lists(IEnumerable<object> p_lista_original, IEnumerable<object> p_lista_nueva)
        {
            int count_original = 0;
            foreach (var a in p_lista_original)
                {count_original++;}
            
            int count_nuevo = 0;
            foreach (var a in p_lista_original)
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

        protected bool Equals(object o_original, object o_nuevo)
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
