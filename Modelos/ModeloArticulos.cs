using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
   public class ModeloArticulos : Modelo
   {
       #region Getters/Setters
       string _codigoOriginal;
       public string codigoOriginal 
       {
           get { return _codigoOriginal; }
           set { this._codigoOriginal = value; }
       }
       
       string _descripcion;
       public string descripcion
       {
           get { return _descripcion; }
           set { this._descripcion = value; }
       }
       
       string _modelos;
       public string modelos 
       {
           get { return _modelos; }
           set { this._modelos = value; }
       }
       
       string _observaciones;
       public string observaciones
       {
           get { return _observaciones; }
           set { this._observaciones = value; }
       }
       #endregion

       #region Validación

       public bool validar()
       {
           return validarCodigoOriginal(this.codigoOriginal);
       }

       public static bool validarCodigoOriginal(string p_codigoOriginal)
       {
           return !string.IsNullOrWhiteSpace(p_codigoOriginal);
       }

       #endregion

       #region Equals
       public override bool Equals(object p_objeto)
       {
           if (p_objeto is ModeloArticulos == false)
               return false;
           return Equals((ModeloArticulos)p_objeto);
       }

       public virtual bool Equals(ModeloArticulos p_mod_articulo)
       {
           return this.Equals(this.codigoOriginal,p_mod_articulo.codigoOriginal)
               && this.Equals(this.descripcion,p_mod_articulo.descripcion)
               && this.Equals(this.modelos,p_mod_articulo.modelos)
               && this.Equals(this.observaciones,p_mod_articulo.observaciones);
       }
       #endregion
   }
}
