using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaClasesCompartidas
{
    public class Validar
    {
        public static bool validarValorNumerico(string pStringNumero)
        {
            int numero;
            return Int32.TryParse(pStringNumero, out numero);
        }
    }
}
