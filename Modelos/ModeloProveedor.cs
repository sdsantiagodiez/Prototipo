﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
   public class ModeloProveedor : ModeloEntidad
   {
       #region Getters/Setters
       string _razonSocial;
        public string razonSocial
        {
            get { return _razonSocial; }
            set { this._razonSocial = value; }
        }
       #endregion
   }
}