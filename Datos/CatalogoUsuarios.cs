using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using System.Data;
using System.Data.SqlClient;
using LibreriaClasesCompartidas;

namespace Datos
{
    public class CatalogoUsuarios : CatalogoPersonas
    {
        private new  ModeloUsuario leerDatosPersonas(SqlDataReader p_drUsuarios)
        {
            ModeloUsuario lcl_mod_usuario = new ModeloUsuario(base.leerDatosPersonas(p_drUsuarios));

            lcl_mod_usuario.usuario = (p_drUsuarios["usuario"] != DBNull.Value) ? (string)p_drUsuarios["usuario"] : null;
            lcl_mod_usuario.contrasenia = (p_drUsuarios["contrasenia"] != DBNull.Value) ? (string)p_drUsuarios["contrasenia"] : null;

            return lcl_mod_usuario;
        }

        #region Búsqueda
        /// <summary>
        /// Genera string a insertar en clausula WHERE de sql de acuerdo a los parámetros de búsqueda
        ///     Si se usa para un login, se debe validar en el logIn que usuario y contraseña no sean Nulls porque sino da valores
        ///     Agregar validación de usuario y contraseña para login
        /// </summary>
        /// <param name="p_mod_usuario">modeloUsuario con variables posiblemente inicializadas</param>
        /// <param name="p_parametroBusqueda">constante encontrada en LibreriaClasesCompartidas.Constantes.ParametrosBusqueda.Entidades.Proveedores</param>
        /// <param name="p_comando">comando sql que será modificado para incluir parámetros</param>
        /// <returns></returns>
        private string getCondicionBusqueda(ModeloUsuario p_mod_usuario, string p_parametroBusqueda, ref SqlCommand p_comando)
        {
            switch (p_parametroBusqueda)
            {              
                case Constantes.ParametrosBusqueda.Entidades.Personas.Usuarios.Usuario:
                    p_comando.Parameters.Add(this.instanciarParametro(p_mod_usuario.usuario, "@usuario"));
                    return " usuario = @usuario ";
                case Constantes.ParametrosBusqueda.Entidades.Personas.Usuarios.LogIn:
                    p_comando.Parameters.Add(this.instanciarParametro(p_mod_usuario.usuario, "@usuario"));
                    p_comando.Parameters.Add(this.instanciarParametro(p_mod_usuario.contrasenia, "@contrasenia"));
                    return " usuario = @usuario AND contrasenia = @contrasenia";
                case Constantes.ParametrosBusqueda.Entidades.Personas.Any:
                    string baseQuery = base.getCondicionBusqueda(p_mod_usuario, p_parametroBusqueda, ref p_comando);
                    p_comando.Parameters.Add(this.instanciarParametro(p_mod_usuario.usuario, "@usuario"));
                    string usuarioQuery = @" (@usuario IS NULL OR @usuario = usuario) ";
                    return baseQuery + " AND " + usuarioQuery ;
            
                default:
                    //Prueba condiciones de atributos propios de modeloPersona
                    return base.getCondicionBusqueda(p_mod_usuario, p_parametroBusqueda, ref p_comando);
            }
        }

        public override IEnumerable<ModeloPersonas> buscar(ModeloPersonas p_mod_persona, string p_parametroBusqueda)
        {
            IEnumerable<ModeloUsuario> lcl_lst_mod_usuarios = this.buscar(p_mod_persona as ModeloUsuario, p_parametroBusqueda);
            IEnumerable<ModeloPersonas> lcl_lst_mod_personas = lcl_lst_mod_usuarios;
            return lcl_lst_mod_personas;
        }

        public IEnumerable<ModeloUsuario> buscar(ModeloUsuario p_mod_usuario, string p_parametroBusqueda)
        {
            return this.buscarUsuario(p_mod_usuario, p_parametroBusqueda);
        }

        /// <summary>
        /// Busca personas en base al parámetro ingresado
        /// </summary>
        /// <param name="p_mod_usuario">modeloUsuario con variables posiblemente inicializadas</param>
        /// <param name="p_paramentroBusqueda">string contenida en LibreriaClasesCompartidas.Constantes.ParametrosBusqueda.Entidades.Personas</param>
        /// <returns></returns>
        private List<ModeloUsuario> buscarUsuario(ModeloUsuario p_mod_usuario, string p_paramentroBusqueda)
        {
            List<ModeloUsuario> lcl_lst_mod_usuarios = new List<ModeloUsuario>();

            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            string querySQL = this.getCondicionBusqueda(p_mod_usuario, p_paramentroBusqueda, ref comando);

            comando.CommandText =
                "SELECT [personas].codigo_entidad,[entidades].tipo_entidad,[entidades].cuit,[entidades].observaciones,[personas].dni," +
                "[personas].nombre,[personas].apellido,[personas].tipo_persona,[personas].usuario, [personas].contrasenia " +
                    "FROM [personas] " +
                    "INNER JOIN [entidades] on [entidades].codigo = [personas].codigo_entidad " +
                    "WHERE [personas].tipo_persona = '"+ Constantes.TiposEntidad.TiposPersona.Usuario +"' AND " + querySQL;

            comando.Connection.Open();

            SqlDataReader drUsuarios = comando.ExecuteReader();

            while (drUsuarios.Read())
            {
                p_mod_usuario = new ModeloUsuario();
                p_mod_usuario = this.leerDatosPersonas(drUsuarios);

                p_mod_usuario.mails = this.getMails(p_mod_usuario.codigo);
                p_mod_usuario.telefonos = this.getTelefonos(p_mod_usuario.codigo);
                p_mod_usuario.domicilios = this.getDomicilios(p_mod_usuario.codigo);

                this.getRoles(ref p_mod_usuario);

                lcl_lst_mod_usuarios.Add(p_mod_usuario);
            }
            drUsuarios.Close();
            comando.Connection.Close();

            return lcl_lst_mod_usuarios;
        }

        /// <summary>
        /// Busca los roles del usuario ingresado como parámetro
        /// </summary>
        /// <param name="p_mod_usuario">Usuario para el que queremos saber los roles</param>
        /// <returns>Lista de roles</returns>
        public void getRoles(ref ModeloUsuario p_mod_usuario)
        {
            string query =
                "SELECT [rol].codigo,[rol].descripcion " +
                "   FROM [rol] " +
                "   INNER JOIN [roles_persona] ON [rol].codigo = [roles_persona].codigo_rol " +
                "   WHERE ([roles_persona].codigo_entidad = @codigo_entidad)";

            SqlCommand comando = new SqlCommand(query,Conexion.crearConexion());

            comando.Parameters.Add(this.instanciarParametro(p_mod_usuario.codigo,"@codigo_entidad"));
            comando.Connection.Open();
            SqlDataReader drRoles = comando.ExecuteReader();

            ModeloRoles lcl_mod_rol;

            p_mod_usuario.roles = new List<ModeloRoles>();
            CatalogoRoles lcl_cat_roles = new CatalogoRoles();
            while (drRoles.Read())
            {
                lcl_mod_rol = new ModeloRoles();
                lcl_mod_rol = lcl_cat_roles.leerDatosRoles(drRoles);
                
                p_mod_usuario.roles.Add(lcl_mod_rol);
            }
            
            drRoles.Close();
            comando.Connection.Close();
        }

        /// <summary>
        /// Busca usuario de acuerdo a código de entidad
        /// </summary>
        /// <param name="p_codigoEntidad">codigo entidad del usuario a buscar</param>
        /// <returns>ModeloUsuario si encuentra, null si no encuentra resultado</returns>
        new public ModeloPersonas getOne(int p_codigoEntidad)
        {
            ModeloUsuario lcl_mod_usuario = new ModeloUsuario();
            List<ModeloUsuario> lcl_lst_mod_usuario = new List<ModeloUsuario>();
            lcl_mod_usuario.codigo = p_codigoEntidad;
            lcl_lst_mod_usuario = this.buscarUsuario(lcl_mod_usuario, Constantes.ParametrosBusqueda.Entidades.Personas.CodigoEntidad);

            if (lcl_lst_mod_usuario.Count > 0)
            {
                return lcl_lst_mod_usuario[0];
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// Busca todos los usuarios que se encuentren en la base de datos
        /// </summary>
        /// <returns></returns>
        public new List<ModeloUsuario> getAll()
        {
            return this.buscarUsuario(null, Constantes.ParametrosBusqueda.Entidades.Personas.All);
        }
        #endregion

        #region Alta/Baja/Modificación

        public override bool add(ModeloPersonas p_mod_persona)
        {
            return this.addUsuario(p_mod_persona as ModeloUsuario);
        }

        public bool add(ModeloUsuario p_mod_usuario)
        {
            string query =
                "INSERT INTO [Personas]([codigo_entidad],[dni],[nombre],[apellido],[usuario],[contrasenia],[tipo_persona]) " +
                "VALUES (@codigo_entidad, @dni, @nombre, @apellido,@usuario,@contrasenia, @tipo_persona)";
            SqlCommand comando = new SqlCommand(query, Conexion.crearConexion());

            //Indica los parametros
            comando.Parameters.Add(this.instanciarParametro(p_mod_usuario.codigo, "@codigo_entidad"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_usuario.dni, "@dni"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_usuario.nombre, "@nombre"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_usuario.apellido, "@apellido"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_usuario.tipoPersona, "@tipo_persona"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_usuario.usuario, "@usuario"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_usuario.contrasenia, "@contrasenia"));

            comando.Connection.Open();
            int rowaffected = comando.ExecuteNonQuery();
            comando.Connection.Close();

            if (rowaffected != 0)
                { return true; }
            else
                { return false; }
        }

        private bool addUsuario(ModeloUsuario p_mod_usuario)
        {
            if (this.add(p_mod_usuario))
            {
                return this.addRoles(p_mod_usuario);
            }
            return false;
        }

        public bool addRoles(ModeloUsuario p_mod_usuario)
        {
            string query =
                    "INSERT INTO [Roles_Persona]([codigo_entidad],[codigo_rol]) " +
                    "VALUES (@codigo_entidad, @codigo_rol)";
            SqlCommand comando = new SqlCommand(query, Conexion.crearConexion());
            
            int? codigoRol = null;
            comando.Parameters.Add(this.instanciarParametro(p_mod_usuario.codigo, "@codigo_entidad"));
            comando.Parameters.Add(this.instanciarParametro(codigoRol, "@codigo_rol"));
            comando.Connection.Open();
            foreach (ModeloRoles r in p_mod_usuario.roles)
            {
                comando.Parameters["@codigo_rol"].Value =r.codigo;
                int rowaffected = comando.ExecuteNonQuery();
                
                if (rowaffected == 0)
                { throw new System.InvalidOperationException("No se ha podido crear rol de usuario: "+r.descripcion); }
            }
            comando.Connection.Close();
            return true;
        }
        
        public override bool update(ModeloPersonas p_mod_persona)
        {
            return this.update(p_mod_persona as ModeloUsuario);
        }

        public  bool update(ModeloUsuario p_mod_usuario_nuevo)
        {
            ModeloUsuario lcl_mod_usuario_original = this.buscar(p_mod_usuario_nuevo, Constantes.ParametrosBusqueda.Entidades.Personas.CodigoEntidad).ToList()[0];
            if (lcl_mod_usuario_original != null)
                return update(lcl_mod_usuario_original, p_mod_usuario_nuevo);
            else
                return false;
        }

        private bool update(ModeloUsuario p_mod_usuario_original, ModeloUsuario p_mod_usuario_nuevo)
        {
            if (!p_mod_usuario_original.Equals(p_mod_usuario_nuevo))
            {
                if(!this.updateUsuario(p_mod_usuario_nuevo) || !this.updateUsuario_Roles(p_mod_usuario_original,p_mod_usuario_nuevo))
                {
                    return false;
                }
            }
            ModeloPersonas p_mod_persona_nueva = new ModeloPersonas(p_mod_usuario_nuevo as ModeloPersonas);
            ModeloPersonas p_mod_persona_original = new ModeloPersonas(p_mod_usuario_original as ModeloPersonas);
            return base.update(p_mod_persona_original, p_mod_persona_nueva);
        }

        private bool updateUsuario(ModeloUsuario p_mod_usuario)
        {
            string query =
                "UPDATE [personas] SET " +
                "[usuario]=@usuario, [contrasenia]=@contrasenia " +
                "WHERE [Personas].codigo_entidad=@codigo_entidad";
            SqlCommand comando = new SqlCommand(query, Conexion.crearConexion());

            comando.Parameters.Add(this.instanciarParametro(p_mod_usuario.codigo, "@codigo_entidad"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_usuario.usuario, "@usuario"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_usuario.contrasenia, "@contrasenia"));

            comando.Connection.Open();
            int rowaffected = comando.ExecuteNonQuery();
            comando.Connection.Close();

            if (rowaffected != 0)
                { return true; }
            else
                { return false; }
        }

        private bool updateUsuario_Roles(ModeloUsuario p_mod_usuario_original, ModeloUsuario p_mod_usuario_nuevo)
        {
            ModeloUsuario lcl_mod_usuarioAuxiliar; 
            lcl_mod_usuarioAuxiliar = new ModeloUsuario(p_mod_usuario_original);
            
            lcl_mod_usuarioAuxiliar.roles = new List<ModeloRoles>();
            foreach (ModeloRoles r in p_mod_usuario_original.roles)
            {
                if (!p_mod_usuario_nuevo.roles.Contains(r))
                {
                    lcl_mod_usuarioAuxiliar.roles.Add(r);
                }
            }
            if (!this.removeRoles(lcl_mod_usuarioAuxiliar))
            {
                return false;
            }
            lcl_mod_usuarioAuxiliar.roles = new List<ModeloRoles>();
            foreach (ModeloRoles r in p_mod_usuario_nuevo.roles)
            {
                if (!p_mod_usuario_original.roles.Contains(r))
                {
                    lcl_mod_usuarioAuxiliar.roles.Add(r);
                }
            }
            if (!this.addRoles(lcl_mod_usuarioAuxiliar))
            { 
                return false; 
            }
            return true;
        }
        
        public override bool remove(ModeloPersonas p_mod_persona)
        {
            return this.remove(p_mod_persona as ModeloUsuario);
        }

        public bool remove(ModeloUsuario p_mod_usuario)
        {
            if (this.removeUsuario(p_mod_usuario))
            {
                return base.remove(p_mod_usuario);
            }
            return false;
        }

        private bool removeUsuario(ModeloUsuario p_mod_usuario)
        {
            return this.removeRoles(p_mod_usuario);
        }
        
        private bool removeRoles(ModeloUsuario p_mod_usuario)
        {
            string query =
                 "DELETE FROM [Roles_Persona] " +
                 "WHERE codigo_entidad=@codigo_entidad AND codigo_rol=@codigo_rol";
            SqlCommand comando = new SqlCommand(query, Conexion.crearConexion());

            int? codigoRol = null;
            comando.Parameters.Add(this.instanciarParametro(p_mod_usuario.codigo, "@codigo_entidad"));
            comando.Parameters.Add(this.instanciarParametro(codigoRol, "@codigo_rol"));

            comando.Connection.Open();
            foreach (ModeloRoles r in p_mod_usuario.roles)
            {
                comando.Parameters["@codigo_rol"].Value = r.codigo;
                int rowaffected = comando.ExecuteNonQuery();

                if (rowaffected == 0)
                { throw new System.InvalidOperationException("No se ha podido eliminar rol de usuario: " + r.descripcion); }
            }
            comando.Connection.Close();
            return true;
        }
        #endregion
    }
}
