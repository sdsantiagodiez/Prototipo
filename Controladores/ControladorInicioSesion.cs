using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Modelos;

namespace Controladores
{
    public class ControladorInicioSesion 
    {
        /// <summary>
        /// Busca y retorna usuario que coincide con los parametros enviados
        /// </summary>
        /// <returns>ModeloPersonas con usuario, o un modelo vacío si no se encontró</returns>
        /*REVISAR
         * public ModeloUsuario buscarUsuario(string usu, string con)
        {
            
            CatalogoPersonas ctlgPersonas = new CatalogoPersonas();
            List<ModeloUsuario> usuarios = ctlgPersonas.buscarPersona("usuario", "usuario", usu);
            if (object.Equals(usuarios[0].contrasenia, con.Trim().ToLower()))
            {
                return usuarios[0];
            }
            else
            {
                ModeloUsuario nuevaPersona = new ModeloUsuario();
                return nuevaPersona;
            }
             
        }*/

        public List<ModeloRoles> getRoles(ModeloPersonas usuario)
        {
            CatalogoPersonas ctlgPersonas = new CatalogoPersonas();
            return ctlgPersonas.getRoles(usuario.dni);
        }
    }
}
