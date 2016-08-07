using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Modelos
{
    [Serializable]
    public class ModeloEntidad : Modelo
    {
        #region Atributos
        int _codigo;
        public int codigo
        {
            get { return _codigo; }
            set { this._codigo = value; }
        }

        private CUIT _cuit;
        public string cuit
        {
            get { return _cuit.numeroCUIT; }
            set { this._cuit.numeroCUIT = value; }
        }

        List<ModeloDomicilio> _domicilios;
        public List<ModeloDomicilio> domicilios
        {
            get { return _domicilios; }
            set { this._domicilios = value; }
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
            set { this._observaciones = !string.IsNullOrWhiteSpace(value) ? value : null; }
        }

        string _tipoEntidad;
        public string tipoEntidad
        {
            get { return _tipoEntidad; }
            set { _tipoEntidad = this.validarTipoEntidad(value) ? value : null; }
        }
        bool _activo;
        public bool activo
        {
            get { return _activo; }
            set { this._activo = value; }
        }
        #endregion

        #region Constructores
        public ModeloEntidad()
        {
            this.mails = new List<ModeloMail>();
            this.domicilios = new List<ModeloDomicilio>();
            this.telefonos = new List<ModeloTelefono>();
            _cuit = new CUIT();
        }

        public ModeloEntidad(ModeloEntidad p_mod_entidad) : this()
        {
            this.codigo = p_mod_entidad.codigo;
            this.cuit = p_mod_entidad.cuit;
            this.domicilios = p_mod_entidad.domicilios;
            this.mails = p_mod_entidad.mails;
            this.mails = p_mod_entidad.mails;
            this.observaciones = p_mod_entidad.observaciones;
            this.telefonos = p_mod_entidad.telefonos; 
        }
        #endregion 
        
        #region Validación
        public bool validar()
        {
            return this.validarCUIT() 
                && this.validarTelefonos()
                && this.validarDomicilios()
                && this.validarTipoEntidad(tipoEntidad);
        }

        /// <summary>
        /// Permite null. Pero si no es null, debe apegarse al formato de CUIT
        /// </summary>
        /// <returns></returns>
        public bool validarCUIT()
        {
            if (cuit != null)
            {
                return CUIT.ValidarCuit(cuit);
            }
            return true;
        }

        public bool validarTipoEntidad(string p_tipoEntidad)
        {
            return p_tipoEntidad == LibreriaClasesCompartidas.Constantes.TiposEntidad.Persona ||
                   p_tipoEntidad == LibreriaClasesCompartidas.Constantes.TiposEntidad.Proveedor;
        }

        public bool validarTelefonos()
        {
            foreach (ModeloTelefono t in telefonos)
            {
                if (!t.validar())
                {
                    return false;
                }
            }
            return true;

        }
        public bool validarDomicilios()
        {
            foreach(ModeloDomicilio d in domicilios)
            {
                if(!d.validar())
                {
                    return false;
                }
            }

            return true;
        }
        
        #endregion

        #region Equals
        public override bool Equals(object p_objeto)
        {
            if (p_objeto is ModeloEntidad == false)
                return false;
            return Equals((ModeloEntidad)p_objeto);
        }

        public virtual bool Equals(ModeloEntidad p_mod_entidad)
        {
            return this.Equals(this.codigo, p_mod_entidad.codigo) 
                && this.Equals(this.cuit, p_mod_entidad.cuit) 
                && this.Equals(this.observaciones, p_mod_entidad.observaciones)
                && this.Equals(this.tipoEntidad, p_mod_entidad.tipoEntidad)
                && this.Equals(this.mails, p_mod_entidad.mails)
                && this.Equals(this.telefonos, p_mod_entidad.telefonos)
                && this.Equals(this.domicilios, p_mod_entidad.domicilios)
                && this.Equals(this.activo,p_mod_entidad.activo);
        }
        #endregion
 
        [Serializable]
        public class CUIT
        {
            #region Getters/Setters
            string _numeroCUIT;
            public string numeroCUIT
            {
                get { return _numeroCUIT; }
                set { _numeroCUIT = this.normalizarCUIT(value); }
            }

            static public int longitud
            {
                get { return 13; }
            }
            #endregion
            
            private string normalizarCUIT(string p_cuit)
            {
                if (ValidarCuit(p_cuit))
                {
                    string cuitNormalizado = p_cuit.Replace(" ", string.Empty).Replace("-", string.Empty);
                    cuitNormalizado = cuitNormalizado.Insert(2, "-");
                    cuitNormalizado = cuitNormalizado.Insert(cuitNormalizado.Length - 1, "-");
                    return cuitNormalizado;
                }
                return null;
            }

            /// <summary>
            /// Calcula el dígito verificador dado un CUIT completo o sin él.
            /// </summary>
            /// <param name="cuit">El CUIT como String sin guiones</param>
            /// <returns>El valor del dígito verificador calculado.</returns>
            public static int CalcularDigitoCuit(string cuit)
            {
                int[] mult = new[] { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };
                char[] nums = cuit.ToCharArray();
                int total = 0;
                for (int i = 0; i < mult.Length; i++)
                {
                    total += int.Parse(nums[i].ToString()) * mult[i];
                }
                var resto = total % 11;
                return resto == 0 ? 0 : resto == 1 ? 9 : 11 - resto;
            }

            /// <summary>
            /// Valida el CUIT ingresado.
            /// </summary>
            /// <param name="cuit" />Número de CUIT como string con o sin guiones
            /// <returns>True si el CUIT es válido y False si no.</returns>
            public static bool ValidarCuit(string cuit)
            {
                if (cuit != null && LibreriaClasesCompartidas.Validar.validarInputNoNumerico(cuit,LibreriaClasesCompartidas.Constantes.ParametrosBusqueda.Entidades.Cuit))
                {
                    //Quito los guiones, el cuit resultante debe tener 11 caracteres.
                    cuit = cuit.Replace("-", string.Empty);
                    if (cuit.Length != 11)
                    {
                        return false;
                    }
                    else
                    {
                        int calculado = CalcularDigitoCuit(cuit);
                        int digito = int.Parse(cuit.Substring(10));
                        return calculado == digito;
                    }
                }
                return false;
            }
            /// <summary>
            /// elimina caracteres no numéricos de cuit.EJ 20-37594224-1 -> 20375942241
            /// </summary>
            /// <param name="cuit"></param>
            /// <returns></returns>
            public static string GetCuitNumerico(string cuit)
            {
                if(!ValidarCuit(cuit))
                {
                    return null;
                }
                return cuit.Replace(" ", string.Empty).Replace("-", string.Empty);
            }
        }

        #region ToString()
        public override string ToString()
        {
            return null;
        }
        #endregion
    }
}
