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
        
          public ModeloPersonas buscarUsuario(string usu, string con)
        {
            
            CatalogoPersonas ctlgPersonas = new CatalogoPersonas();
            ModeloPersonas modUsu = new ModeloPersonas();
            modUsu.usuario = usu;
            List<ModeloPersonas> ListaUsuarios = ctlgPersonas.buscarPersona(modUsu, "usuario");
            if (object.Equals(ListaUsuarios[0].contrasenia, con.Trim().ToLower()))
            {
                return ListaUsuarios[0];
            }
            else
            {
                ModeloPersonas nuevaPersona = new ModeloPersonas();
                return nuevaPersona;
            }
             
        }

        public List<ModeloRoles> getRoles(ModeloPersonas usuario)
        {
            CatalogoPersonas ctlgPersonas = new CatalogoPersonas();
            return ctlgPersonas.getRoles(usuario.codigo);
        }
    }
}
