using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloDomicilio : Modelo
    {
        #region Constructores
        public ModeloDomicilio()
        {
            provincia = new ModeloProvincia();
            pais = new ModeloPais();
        }
        #endregion

        #region Getters/Setters
        int _codigoDomicilio;
        public int codigoDomicilio
        {
            get { return _codigoDomicilio; }
            set { this._codigoDomicilio = value; }
        }
        string _calle;
        public string calle
        {
            get { return _calle; }
            set { this._calle = this.convertirString(value); }
        }
        string _numero;
        public string numero
        {
            get { return _numero; }
            set { this._numero = this.convertirString(value); }
        }string _piso;
        public string piso
        {
            get { return _piso; }
            set { this._piso = this.convertirString(value); }
        }
        string _departamento;
        public string departamento
        {
            get { return _departamento; }
            set { this._departamento = this.convertirString(value); }
        }
        string _ciudad;
        public string ciudad
        {
            get { return _ciudad; }
            set { this._ciudad = this.convertirString(value); }
        }
        string _codigoPostal;
        public string codigoPostal
        {
            get { return _codigoPostal; }
            set { this._codigoPostal = this.convertirString(value); }
        }
        ModeloProvincia _provincia;
        public ModeloProvincia provincia
        {
            get { return _provincia; }
            set { this._provincia = value; }
        }
        ModeloPais _pais;
        public ModeloPais pais
        {
            get { return _pais; }
            set { this._pais = value; }
        }
        #endregion

        #region Validación
        public bool validar()
        {
            return validarCodigo(this.codigoDomicilio.ToString())
                && validarCalle(this.calle)
                && validarNumero(this.numero)
                && validarPiso(this.piso)
                && validarDepartamento(this.departamento)
                && validarCiudad(this.ciudad)
                && validarCodigoPostal(this.codigoPostal)
                && this.validarProvincia(this.provincia)
                && this.validarPais(this.pais);
        }
        public bool validarCodigo(string p_codigo)
        {
            int aux;
            return int.TryParse(p_codigo,out aux);
        }
        public static bool validarCalle(string p_calle)
        {
            return !string.IsNullOrWhiteSpace(p_calle);
        }
        public static bool validarNumero(string p_numero)
        {
            //se permite vacío para calles sin número (S/N)
            return true;
        }
        public static bool validarPiso(string p_piso)
        {
            return true;
        }
        public static bool validarDepartamento(string p_departamento)
        {
            return true;
        }
        public static bool validarCiudad(string p_ciudad)
        {
            return true;
        }
        public static bool validarCodigoPostal(string p_codigoPostal)
        {
            return true;
        }
        public bool validarProvincia(ModeloProvincia p_mod_provincia)
        {
            //Debería estar inicializada por el constructor
            if (p_mod_provincia != null)
                return p_mod_provincia.validar();
            else
                return false;
        }
        public bool validarPais(ModeloPais p_mod_pais)
        {
            //Debería estar inicializado por el constructor
            if (p_mod_pais != null)
                return p_mod_pais.validar();
            else
                return false;
        }
        #endregion

        #region Equals
        public override bool Equals(object p_objeto)
        {
            if (p_objeto is ModeloDomicilio == false)
                return false;
            return Equals((ModeloDomicilio)p_objeto);
        }

        public bool Equals(ModeloDomicilio p_mod_domicilio)
        {
            return this.Equals(this.calle,p_mod_domicilio.calle) 
                && this.Equals(this.ciudad,p_mod_domicilio.ciudad) 
                && this.Equals(this.codigoDomicilio,p_mod_domicilio.codigoDomicilio)
                && this.Equals(this.codigoPostal, p_mod_domicilio.codigoPostal) 
                && this.Equals(this.departamento, p_mod_domicilio.departamento) 
                && this.Equals(this.numero, p_mod_domicilio.numero)
                && this.Equals(this.pais,p_mod_domicilio.pais) 
                && this.Equals(this.piso,p_mod_domicilio.piso) 
                && this.Equals(this.provincia,p_mod_domicilio.provincia);
        }
        #endregion
    }
}
