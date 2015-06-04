using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloMailPersonas
    {
        #region Getters/Setters
        string _mailPers;
        public string mailPers 
        {
            get { return _mailPers; }
            set 
            { this._mailPers = value; }
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
