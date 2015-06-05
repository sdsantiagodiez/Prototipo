using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;


namespace Datos
{
    class CatalogoUsuarios : CatalogoPersonas
    {
        public bool existeEntidad(string dni, string usuario)
        {
            // Se crea la variable a retornar
            bool respuesta = this.existeEntidad(dni);
            if (!respuesta)
            {
                ModeloPersonas mp = getOnePorUsuario(usuario);
                if(object.Equals(mp.usuario,usuario))
                {
                    respuesta = true;
                }
            }
            return respuesta;
        }

        public void generarNombreUsuario()//devuelve string
        {

        }
    }
}
