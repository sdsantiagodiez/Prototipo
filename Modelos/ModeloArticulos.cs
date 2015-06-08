using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
   public class ModeloArticulos
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
   }
}
