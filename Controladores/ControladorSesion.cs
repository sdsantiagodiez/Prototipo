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
        public static ModeloUsuario LogIn(ModeloUsuario p_mod_usuario)
        {
            if (p_mod_usuario.usuario == null || p_mod_usuario.contrasenia == null)
            {
                ModeloUsuario lcl_mod_usuario = new Modelos.ModeloUsuario();
                ModeloRoles lcl_mod_rol_1 = new Modelos.ModeloRoles();

                lcl_mod_rol_1.codigo = 1;
                lcl_mod_rol_1.descripcion = LibreriaClasesCompartidas.Constantes.TipoRoles.Admin;

                lcl_mod_usuario.nombre = "Usuario";
                lcl_mod_usuario.apellido = "Test";
                lcl_mod_usuario.usuario = "test_username";
                lcl_mod_usuario.dni = "30.123.456";
                lcl_mod_usuario.asignarContraseña("contraseña");

                lcl_mod_usuario.domicilios.Add(new ModeloDomicilio()
                {
                    calle = "Calle",
                    numero = "1",
                    ciudad = "Rosario",
                    provincia = new ModeloProvincia() { provincia = "Buenos Aires", codigo = "AR-B", codigoPais = "AR", },
                    pais = new ModeloPais() { pais = "Argentina",codigo ="AR"}
                });

                lcl_mod_usuario.roles.Add(lcl_mod_rol_1);

                return lcl_mod_usuario;
            }

            //usamos _usuarioActual para no permitir set fuera del controlador
            List<object> lcl_lst_mod_usuarios = ControladorBusqueda.buscar(p_mod_usuario as object, LibreriaClasesCompartidas.Constantes.ParametrosBusqueda.Entidades.Personas.Usuarios.LogIn).ToList();

            if (lcl_lst_mod_usuarios.Count > 0)
            {
                return (ModeloUsuario)lcl_lst_mod_usuarios[0];
            }
            return null;
        }
        public static bool LogOut(ModeloUsuario p_mod_usuario)
        {
            //registrar momento de salida o algo por el estilo? 
            return true;
        }
    }
}
