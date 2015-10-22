using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Modelos;
using System.Text.RegularExpressions;


namespace Controladores
{
    public class ControladorAlta : Controlador
    {
        #region Entidades
        /// <summary>
        /// Genera nombre de usuario (REVISAR si es buena idea)
        /// </summary>
        /// <param name="pCodigoEntidad"></param>
        /// <returns></returns>
        public string generarNombreUsuario(string pNombre, string pApellido)
        {
            string nombreDeUsuario = null;
            
            nombreDeUsuario = "";
            //se elimina del nombre y apellido todos los caracteres no alfanuméricos
            Regex rgx = new Regex("[^a-zA-Z0-9 -]");
            string nombre = rgx.Replace(pNombre, "");
            string apellido = rgx.Replace(pApellido, "");
            nombreDeUsuario = (pNombre[0] + pApellido).ToLower();

            //Si nombreDeUsuario existe, se entra en la iteración para agregar un número al final
            //del usuario hasta que usuario no exista
            CatalogoPersonas cp = new CatalogoPersonas();
            ModeloPersonas mPersonaBusqueda = new ModeloPersonas();
            for (int i = 1; cp.buscarPersona(mPersonaBusqueda,"usuario").Count >=1 ; i++)
            {
                //se vuelve a instanciar para que sólo cambie el número al final
                nombreDeUsuario = "";
                nombreDeUsuario = (pNombre[0] + pApellido + i.ToString()).ToLower();
                mPersonaBusqueda.usuario = nombreDeUsuario;
            }
            
            return nombreDeUsuario;
        }

        public bool agregarPersona(ModeloPersonas pmPersona)
        {
            CatalogoPersonas cp = new CatalogoPersonas();
            if(pmPersona.validar() == true)
            {
                return cp.agregarNuevaEntidad(pmPersona);
            }
            else
            {
                return false;
            }
        }

        public bool agregarProveedor(ModeloProveedor pmProveedor)
        {
            CatalogoProveedores cp = new CatalogoProveedores();
            if (pmProveedor.validar() == true)
            {
                return cp.agregarNuevaEntidad(pmProveedor);
            }
            else
            {
                return false;
            }
        }

        #endregion
    }
}
