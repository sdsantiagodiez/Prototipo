using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloValorArticulo
    {
        #region Getters/Setters
        DateTime? _fechaUltimaActualizacion;
        public DateTime? fechaUltimaActualizacion
        {
            get { return _fechaUltimaActualizacion; }
            set { this._fechaUltimaActualizacion = value; }
        }
        decimal? _valorArticulo;
        public decimal? valorArticulo
        {
            get { return _valorArticulo; }
            set
            {
                _valorArticulo = value;
                //Cada vez que se muestre se modificaría la fecha
                //_fechaUltimaActualizacion = DateTime.Today;
            }
        }
        #endregion
    }
}
