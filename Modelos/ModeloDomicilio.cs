using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloDomicilio : Modelo
    {
        public ModeloDomicilio()
        {
            provincia = new ModeloProvincia();
            pais = new ModeloPais();
        }

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
            set { this._calle = value; }
        }
        string _numero;
        public string numero
        {
            get { return _numero; }
            set { this._numero = value; }
        }string _piso;
        public string piso
        {
            get { return _piso; }
            set { this._piso = value; }
        }
        string _departamento;
        public string departamento
        {
            get { return _departamento; }
            set { this._departamento = value; }
        }
        string _ciudad;
        public string ciudad
        {
            get { return _ciudad; }
            set { this._ciudad = value; }
        }
        string _codigoPostal;
        public string codigoPostal
        {
            get { return _codigoPostal; }
            set { this._codigoPostal = value; }
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
            return (this.validarCodigo() == true && this.validarCalle() == true && this.validarNumero() == true && this.validarPiso() == true &&
                    this.validarDepartamento() == true && this.validarCiudad() == true && this.validarCodigoPostal() == true &&
                    this.validarProvincia() == true && this.validarPais() == true);
        }
        public bool validarCodigo()
        {
            return true;
        }
        public bool validarCalle()
        {
            return true;
        }
        public bool validarNumero()
        {
            return true;
        }
        public bool validarPiso()
        {
            return true;
        }
        public bool validarDepartamento()
        {
            return true;
        }
        public bool validarCiudad()
        {
            return true;
        }
        public bool validarCodigoPostal()
        {
            return true;
        }
        public bool validarProvincia()
        {
            return provincia.validar();
        }
        public bool validarPais()
        {
            return pais.validar();
        }
        #endregion
        
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
    }
}
