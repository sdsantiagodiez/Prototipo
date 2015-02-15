using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Modelos;

namespace Controlador
{
    public class ControladorInicioSesion
    {
        /// <summary>
        /// Busca y retorna usuario que coincide con los parametros enviados
        /// </summary>
        /// <returns>ModeloPersonas con usuario, o un modelo vacío si no se encontró</returns>
        public ModeloPersonas buscarUsuario(string usu, string con){
            CatalogoPersonas ctlgPersonas = new CatalogoPersonas();
            List<ModeloPersonas> usuarios = ctlgPersonas.buscarPersona("usuario", "usuario", usu);
            if (object.Equals(usuarios[0].contraseniaPers, con.Trim().ToLower()))
            {
                return usuarios[0];
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
            return ctlgPersonas.getRoles(usuario.dniPers);
        }
    }
}
