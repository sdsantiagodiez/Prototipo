using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
   public class ModeloArticulos
    {
       string _codigoOriginalArt;
       public string codigoOriginalArt 
       {
           get { return _codigoOriginalArt; }
           set { this._codigoOriginalArt = value; }
       }
       string _descripArt;
       public string descripArt
       {
           get { return _descripArt; }
           set { this._descripArt = value; }
       }
       string _modelosArt;
       public string modelosArt 
       {
           get { return _modelosArt; }
           set { this._modelosArt = value; }
       }
       string _obsArt;
       public string obsArt
       {
           get { return _obsArt; }
           set { this._obsArt = value; }
       }
    }
}
