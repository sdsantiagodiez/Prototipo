using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using System.Text.RegularExpressions;


namespace Datos
{
    public class CatalogoUsuarios : CatalogoPersonas
    {
        /*REVISAR
        public bool existeEntidad(string dni, string usuario)
        {
            bool respuesta = this.existeEntidad(dni);
            if (!respuesta)
            {
                if (getOnePorUsuario(usuario) != null)
                {
                    respuesta = true;
                }
            }
            return respuesta;
        }
       */
        /// <summary>
        /// Genera nombre de usuario en base al nombre y la primera letra del apellido de la persona (y un número según conrresponda)
        /// </summary>
        /// <param name="dni"></param>
        /// <returns>nombre de usuario o null si dni no existe</returns>
        public string generarNombreUsuario(string dni)
        {
            string nombreDeUsuario =null;
            ModeloPersonas usuario = this.getOnePorDNI(dni);
            
            if (usuario != null)
            {
                nombreDeUsuario = "";
                //se elimina del nombre y apellido todos los caracteres no alfanuméricos
                Regex rgx = new Regex("[^a-zA-Z0-9 -]");
                string nombre = rgx.Replace(usuario.nombre, "");
                string apellido = rgx.Replace(usuario.apellido, "");
                nombreDeUsuario = (nombre + apellido[0]).ToLower();
                
                //Si nombreDeUsuario existe, se entra en la iteración para agregar un número al final
                //del usuario hasta que usuario no exista
                for (int i = 0; this.getOnePorUsuario(nombreDeUsuario) != null; i++ )
                {
                    nombreDeUsuario = "";
                    nombreDeUsuario = (usuario.nombre + usuario.apellido[0] + i.ToString()).ToLower();
                }
            }
            return nombreDeUsuario;
        }
    }
}
