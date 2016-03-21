using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloValorArticulo : Modelo
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

        public override bool Equals(object p_objeto)
        {
            if (p_objeto is ModeloValorArticulo == false)
                return false;
            return Equals((ModeloValorArticulo)p_objeto);
        }

        public virtual bool Equals(ModeloValorArticulo p_mod_valorArticulo)
        {
            return this.Equals(this.fechaUltimaActualizacion,p_mod_valorArticulo.fechaUltimaActualizacion)
                && this.Equals(this.valorArticulo,p_mod_valorArticulo.valorArticulo);
        }
    }
}
