﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloProvincia
    {
        string _codigo;
        public string codigo
        {
            get { return _codigo; }
            set { this._codigo = value; }
        }
        string _provincia;
        public string provincia
        {
            get { return _provincia; }
            set { this._provincia = value; }
        }
    }
}
