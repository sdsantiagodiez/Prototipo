using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ModeloRoles
    {
        int codRol;
        string descripcionRol;

        /*Constructor default*/
        public ModeloRoles()
        { 
        }
       
        //geters setters
        #region
        public int getCodRol()
        {
        return codRol;
        }
        
        public void setCodRol(int pcod)
        {
            this.codRol = pcod;
        }

        public string getdescripcion()
        {
            return descripcionRol;
        }

        public void setDescripcion(string pDescri)
        {
            this.descripcionRol = pDescri;
        }
        #endregion
    }


    }

    
