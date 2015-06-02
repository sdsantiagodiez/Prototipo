using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    class ModeloValorArticulo
    {
        DateTime _fechaUltimaActualizacion;
        public DateTime fechaUltimaActualizacion
        {
            get { return _fechaUltimaActualizacion; }
            set { this._fechaUltimaActualizacion = value; }
        }
        decimal _valorArticulo;
        public decimal valorArticulo
        {
            get { return _valorArticulo; }
            set
            {
                _valorArticulo = value;
                _fechaUltimaActualizacion = DateTime.Today;
            }
        }

    }
}
