using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloMailPersonas
    {
        string _dniPers;
        public string dniPers 
        {
            get { return _dniPers; }
            set { this._dniPers = value; }
        }
        string _mailPers;
        public string mailPers 
        {
            get { return _mailPers; }
            set { this._mailPers = value; }
        }
    }
}
