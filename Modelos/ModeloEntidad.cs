﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Modelos
{
    public class ModeloEntidad
    {
        public ModeloEntidad()
        {
            this.mails = new List<ModeloMail>();
            this.domicilios = new List<ModeloDomicilio>();
            this.telefonos = new List<ModeloTelefono>();
        }

        #region Getters/Setters
        int _codigo;
        public int codigo
        {
            get { return _codigo; }
            set { this._codigo = value; }
        }
        string _cuit;
        public string cuit
        {
            get { return _cuit; }
            set { this._cuit = value; }
        }
        List<ModeloDomicilio> _domicilios;
        public List<ModeloDomicilio> domicilios
        {
            get { return _domicilios; }
            set { this._domicilios = value;}
        }
        List<ModeloTelefono> _telefonos;
        public List<ModeloTelefono> telefonos
        {
            get { return _telefonos; }
            set { this._telefonos = value; }
        }
        List<ModeloMail> _mails;
        public List<ModeloMail> mails
        {
            get { return _mails; }
            set { this._mails = value; }
        }
        string _observaciones;
        public string observaciones
        {
            get { return _observaciones; }
            set { this._observaciones = value; }
        }
        /// <summary>
        /// PER: CLIENTE;
        /// PRO: PROVEEDOR;
        /// </summary>
        string _tipoEntidad;
        public string tipoEntidad
        {
            get { return _tipoEntidad; }
            set { this._tipoEntidad = value; }
        }
        #endregion

        public void convertirDatos()
        {
            cuit = this.convertirString(cuit);
        }

        /// <summary>
        /// Quita espacios
        /// </summary>
        /// <param name="pString"></param>
        /// <returns></returns>
        public string convertirString(string pString)
        {
            string stringConvertida = "";
            if (pString != null)
            {
                stringConvertida = pString.Trim();
                //Se remueven espacios dobles entre palabras
                RegexOptions options = RegexOptions.None;
                Regex regex = new Regex(@"[ ]{2,}", options);
                stringConvertida = regex.Replace(stringConvertida, @" ");
                if (stringConvertida == "")
                {
                    stringConvertida = null;
                }
            }
            return stringConvertida;
        }
    }
}
