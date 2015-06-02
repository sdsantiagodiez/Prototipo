using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class ModeloRoles
    {
        int codigo;
        string descripcion;

        /*Constructor default*/
        public ModeloRoles()
        { 
        }
       
        //geters setters
        #region
        public int getCodigo()
        {
        return codigo;
        }
        
        public void setCodigo(int pCodigo)
        {
            this.codigo = pCodigo;
        }

        public string getDescripcion()
        {
            return descripcion;
        }

        public void setDescripcion(string pDescripcion)
        {
            this.descripcion = pDescripcion;
        }
        #endregion
    }


    }

    
