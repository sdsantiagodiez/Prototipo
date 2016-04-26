using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    [Serializable]
    public class ModeloMail : Modelo
    {
        #region Getters/Setters
        int _codigoMail;
        public int codigoMail
        {
            get { return _codigoMail; }
            set { this._codigoMail = value; }
        }
        string _mail;
        public string mail 
        {
            get { return _mail; }
            set { this._mail = validarMail(value) ? value : null; }
        }
        #endregion

        #region Validación
        public bool validar()
        {
            return validarMail(this.mail);
        }
        
        //Validación básica (xxx@xxx.xxx)
        //No detecta signos como #, ?, etc.
        public static bool validarMail(string p_mail)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(p_mail);
                return addr.Address == p_mail;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region Equals
        public override bool Equals(object p_objeto)
        {
            if (p_objeto is ModeloMail == false)
                return false;
            return Equals((ModeloMail)p_objeto);
        }

        public bool Equals(ModeloMail p_mod_mail)
        {
            return this.Equals(this.codigoMail,p_mod_mail.codigoMail) 
                && this.mail.ToLower().Equals(p_mod_mail.mail.ToLower());
        }
        #endregion
    }
}
