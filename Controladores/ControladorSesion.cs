using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace Controladores
{
    public class ControladorSesion
    {
        public static bool LogIn(ModeloUsuario p_mod_usuario)
        {
            return true;
        }
        public static bool LogOut(ModeloUsuario p_mod_usuario)
        {
            return true;
        }

        public static ModeloUsuario getUsuario(ModeloUsuario p_mod_usuario)
        {
            ModeloUsuario lcl_mod_usuario = new Modelos.ModeloUsuario();
            ModeloRoles lcl_mod_rol_1 = new Modelos.ModeloRoles();

            lcl_mod_rol_1.codigo = 1;
            lcl_mod_rol_1.descripcion = LibreriaClasesCompartidas.Constantes.TipoRoles.Admin;

            lcl_mod_usuario.nombre = "Usuario";
            lcl_mod_usuario.apellido = "Test";
            lcl_mod_usuario.usuario = "test_username";

            lcl_mod_usuario.roles.Add(lcl_mod_rol_1);

            return lcl_mod_usuario;
        }
    }
}
