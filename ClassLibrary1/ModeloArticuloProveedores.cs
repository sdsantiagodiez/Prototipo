using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ModeloArticuloProveedores
    {
        public string codigoOriginalArt { get; set; }
        public string codigoArProveedor { get; set; }
        public int stockMinimoArPro { get; set; }
        public int stockActualArPro { get; set; }
        public string obsArPro { get; set; }
        public DateTime fechaUltimaActualizacionArPro { get; set; }
        public string razonSocialProv { get; set; }

    }
}
