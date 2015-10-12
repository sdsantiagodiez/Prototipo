using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloMail
    {
        #region Getters/Setters
        string _mail;
        public string mail 
        {
            get { return _mail; }
            set { this._mail = value; }
        }
        #endregion
        //Validación básica (xxx@xxx.xxx)
        //No detecta signos como #, ?, etc.
        public bool validarMail(string mail)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(mail);
                return addr.Address == mail;
            }
            catch
            {
                return false;
            }
        }
    }
}
