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
    public class CatalogoPersonas : CatalogoEntidades
    {
        public bool validarDatos(ModeloPersonas p_mod_persona)
        {
            // Validar si los datos son correctos?
            return true;
        }

        public bool existeEntidad(int p_codigoEntidad)
        {
            bool respuesta = false;
            if (getOne(p_codigoEntidad) != null)
            {
                respuesta = true;
            }
            return respuesta;
        }     

        private ModeloPersonas leerDatosPersonas(SqlDataReader p_drPersonas)
        {
            ModeloPersonas lcl_mod_persona = new ModeloPersonas();

            lcl_mod_persona.codigo = (int)p_drPersonas["codigo"];
            //Si algún valor esta null en Base de datos, se asigna null en el objeto
            //Caso contrario hay una string, y se asigna string
            lcl_mod_persona.dni = (p_drPersonas["dni"] != DBNull.Value) ? (string)p_drPersonas["dni"] : null;
            lcl_mod_persona.nombre = (p_drPersonas["nombre"] != DBNull.Value) ? (string)p_drPersonas["nombre"] : null;
            lcl_mod_persona.apellido = (p_drPersonas["apellido"] != DBNull.Value) ? (string)p_drPersonas["apellido"] : null;
            lcl_mod_persona.usuario = (p_drPersonas["usuario"] != DBNull.Value) ? (string)p_drPersonas["usuario"] : null;
            lcl_mod_persona.contrasenia = (p_drPersonas["contrasenia"] != DBNull.Value) ? (string)p_drPersonas["contrasenia"] : null;
            lcl_mod_persona.tipoPersona = (p_drPersonas["tipo_persona"] != DBNull.Value) ? (string)p_drPersonas["tipo_persona"] : null;

            lcl_mod_persona.cuit = (p_drPersonas["cuit"] != DBNull.Value) ? (string)p_drPersonas["cuit"] : null;
            lcl_mod_persona.tipoEntidad = (p_drPersonas["tipo_entidad"] != DBNull.Value) ? (string)p_drPersonas["tipo_entidad"] : null;
            lcl_mod_persona.observaciones = (p_drPersonas["observaciones"] != DBNull.Value) ? (string)p_drPersonas["observaciones"] : null;
            
            return lcl_mod_persona;
        }

        //Si se usa para un login, se debe validar en el logIn que usuario y contraseña no sean Nulls porque sino da valores
        //Agregar validación de usuario y contraseña para login
        /// <summary>
        /// Genera string a insertar en clausula WHERE de sql de acuerdo a los parámetros de búsqueda
        /// </summary>
        /// <param name="p_mod_persona">modeloPersona con variables posiblemente inicializadas</param>
        /// <param name="p_parametroBusqueda">constante encontrada en LibreriaClasesCompartidas.Constantes.ParametrosBusqueda.Entidades.Proveedores</param>
        /// <param name="p_comando">comando sql que será modificado para incluir parámetros</param>
        /// <returns></returns>
        private string getCondicionBusqueda(ModeloPersonas p_mod_persona, string p_parametroBusqueda, ref SqlCommand p_comando)
        {
            switch (p_parametroBusqueda)
            {
                case Constantes.ParametrosBusqueda.Entidades.Personas.CodigoEntidad:
                    p_comando.Parameters.Add(this.instanciarParametro(p_mod_persona.codigo, "@codigo"));
                    return " codigo = @codigo ";
                case Constantes.ParametrosBusqueda.Entidades.Personas.Cuit:
                    p_comando.Parameters.Add(this.instanciarParametro(p_mod_persona.cuit, "@cuit"));
                    return " cuit = @cuit ";
                case Constantes.ParametrosBusqueda.Entidades.Personas.Dni:
                    p_comando.Parameters.Add(this.instanciarParametro(p_mod_persona.dni, "@dni"));
                    return " dni = @dni ";
                case Constantes.ParametrosBusqueda.Entidades.Personas.Nombre:
                    p_comando.Parameters.Add(this.instanciarParametro(this.agregarComodinBusquedaLIKE(p_mod_persona.nombre), "@nombre"));
                    return " nombre LIKE @nombre ";
                case Constantes.ParametrosBusqueda.Entidades.Personas.Apellido:
                    p_comando.Parameters.Add(this.instanciarParametro(this.agregarComodinBusquedaLIKE(p_mod_persona.apellido), "@apellido"));
                    return " apellido LIKE @apellido ";
                case Constantes.ParametrosBusqueda.Entidades.Personas.Usuario:
                    p_comando.Parameters.Add(this.instanciarParametro(p_mod_persona.usuario, "@usuario"));
                    return " usuario = @usuario ";
                case Constantes.ParametrosBusqueda.Entidades.Personas.TipoPersona:
                    p_comando.Parameters.Add(this.instanciarParametro(p_mod_persona.tipoPersona, "@tipo_persona"));
                    return " tipo_persona = @tipo_persona ";
                case Constantes.ParametrosBusqueda.Entidades.Personas.Any:
                    int? codigoEntidad = p_mod_persona.codigo == 0? null : (int?)p_mod_persona.codigo;
                    p_comando.Parameters.Add(this.instanciarParametro(codigoEntidad, "@codigo_entidad"));
                    string codigoEntidadQuery = @" (@codigo_entidad IS NULL OR @codigo_entidad = codigo_entidad) ";
                   
                    p_comando.Parameters.Add(this.instanciarParametro(p_mod_persona.cuit, "@cuit"));
                    string cuitQuery = this.parametroBusqueda("@cuit", "cuit","=");
                    
                    p_comando.Parameters.Add(this.instanciarParametro(p_mod_persona.dni, "@dni"));
                    string dniQuery = this.parametroBusqueda("@dni", "dni","=");
                    
                    string nombre = (p_mod_persona.nombre == "") ? null : p_mod_persona.nombre;
                    p_comando.Parameters.Add(this.instanciarParametro(this.agregarComodinBusquedaLIKE(nombre), "@nombre"));
                    string nombreQuery = this.parametroBusqueda("@nombre", "nombre","LIKE");
                    
                    string apellido = (p_mod_persona.apellido == "") ? null : p_mod_persona.apellido;
                    p_comando.Parameters.Add(this.instanciarParametro(this.agregarComodinBusquedaLIKE(apellido), "@apellido"));
                    string apellidoQuery = this.parametroBusqueda("@apellido", "apellido", "LIKE");
                    
                    p_comando.Parameters.Add(this.instanciarParametro(p_mod_persona.usuario, "@usuario"));
                    string usuarioQuery = @" (@usuario IS NULL OR @usuario = usuario) ";
                    
                    p_comando.Parameters.Add(this.instanciarParametro(p_mod_persona.contrasenia, "@contrasenia"));
                    string contraseniaQuery = @" (@contrasenia IS NULL OR @contrasenia = contrasenia) ";
                    
                    p_comando.Parameters.Add(this.instanciarParametro(p_mod_persona.tipoPersona, "@tipo_persona"));
                    string tipoPersonaQuery = @" (@tipo_persona IS NULL OR @tipo_persona = tipo_persona) "; 

                    return codigoEntidadQuery +" AND " + cuitQuery + " AND " + dniQuery + " AND " + nombreQuery + " AND " + apellidoQuery + " AND " + usuarioQuery + " AND " + contraseniaQuery + " AND " + tipoPersonaQuery;

                case Constantes.ParametrosBusqueda.Entidades.Personas.All:
                    //retorna true y devuelve todas las filas
                    return " 1 = 1 ";
                default:
                    //hace que sql no retorne filas
                    return " 1 = 2 ";
            }
        }

        /// <summary>
        /// Busca personas en base al parámetro ingresado
        /// </summary>
        /// <param name="p_mod_persona">modeloPersona con variables posiblemente inicializadas</param>
        /// <param name="p_paramentroBusqueda">string contenida en LibreriaClasesCompartidas.Constantes.ParametrosBusqueda.Entidades.Personas</param>
        /// <returns></returns>
        public List<ModeloPersonas> buscarPersona(ModeloPersonas p_mod_persona, string p_paramentroBusqueda)
        {
            List<ModeloPersonas> lcl_lst_mod_persona = new List<ModeloPersonas>();

            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            string querySQL = this.getCondicionBusqueda(p_mod_persona,p_paramentroBusqueda,ref comando);
            
            comando.CommandText =
                "SELECT [entidades].codigo,[entidades].tipo_entidad,[entidades].cuit,[entidades].observaciones,[personas].dni," +
                "[personas].nombre,[personas].apellido,[personas].tipo_persona,[personas].usuario, [personas].contrasenia " +
                    "FROM [personas] " +
                    "INNER JOIN [entidades] on [entidades].codigo = [personas].codigo_entidad " +
                    "WHERE " + querySQL;

            comando.Connection.Open();

            SqlDataReader drPersonas = comando.ExecuteReader();

            while (drPersonas.Read())
            {
                p_mod_persona = new ModeloPersonas();
                p_mod_persona = this.leerDatosPersonas(drPersonas);

                p_mod_persona.mails = this.getMails(p_mod_persona.codigo);
                p_mod_persona.telefonos = this.getTelefonos(p_mod_persona.codigo);
                p_mod_persona.domicilios = this.getDomicilios(p_mod_persona.codigo);

                lcl_lst_mod_persona.Add(p_mod_persona);
            }
            drPersonas.Close();
            comando.Connection.Close();

            return lcl_lst_mod_persona;
        }
        /// <summary>
        /// Busca persona de acuerdo a código de entidad
        /// </summary>
        /// <param name="p_codigoEntidad">codigo entidad de la persona a buscar</param>
        /// <returns>ModeloPersona si encuentra, null si no encuentra resultado</returns>
        
        new public ModeloPersonas getOne(int p_codigoEntidad)
        {
            ModeloPersonas lcl_mod_persona = new ModeloPersonas();
            List<ModeloPersonas> lcl_lst_mod_persona = new List<ModeloPersonas>();
            lcl_mod_persona.codigo = p_codigoEntidad;
            lcl_lst_mod_persona = this.buscarPersona(lcl_mod_persona, Constantes.ParametrosBusqueda.Entidades.Personas.CodigoEntidad);

            if (lcl_lst_mod_persona.Count > 0)
            {
                return lcl_lst_mod_persona[0];
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// Busca todas las personas que se encuentren en la base de datos
        /// </summary>
        /// <returns></returns>
        public new List<ModeloPersonas> getAll()
        {
            return this.buscarPersona(null, Constantes.ParametrosBusqueda.Entidades.Personas.All);
        }

        #region Alta/Baja/Modificación
        /*
         * True si se realizó correctamente
         * False si ocurrió algún error
         */

        public override bool agregarNuevaEntidad(ref ModeloPersonas p_mod_persona)
        {
            //Se debería chequear antes para notificar al usuario la razón por la que no se podrá realizar la operación
            //y continua si se creó exitosamente la entidad
            if (!this.existeEntidad(p_mod_persona.codigo) && base.agregarNuevaEntidad(ref p_mod_persona))
            {
                
                //Creo la conexion y la abro
                SqlConnection ConexionSQL = Conexion.crearConexion();

                //crea SQL command
                SqlCommand comando = new SqlCommand();

                comando.Connection = ConexionSQL;

                comando.CommandType = CommandType.Text;

                comando.CommandText = 
                    "INSERT INTO [Personas]([codigo_entidad],[dni],[nombre],[apellido],"+
                    "[usuario], [contrasenia],[tipo_persona]) "+
                    "VALUES (IDENT_CURRENT('entidades'), @dni, @nombre, @apellido," +
                    "@usuario, @contrasenia,@tipo_persona)";
                //Indica los parametros
                comando.Parameters.Add(this.instanciarParametro(p_mod_persona.dni, "@dni"));
                comando.Parameters.Add(this.instanciarParametro(p_mod_persona.nombre, "@nombre"));
                comando.Parameters.Add(this.instanciarParametro(p_mod_persona.apellido, "@apellido"));
                comando.Parameters.Add(this.instanciarParametro(p_mod_persona.usuario, "@usuario"));
                comando.Parameters.Add(this.instanciarParametro(p_mod_persona.contrasenia, "@contrasenia"));
                comando.Parameters.Add(this.instanciarParametro(p_mod_persona.tipoPersona, "@tipo_persona"));
                
                comando.Connection.Open();
                int rowaffected = comando.ExecuteNonQuery();
                comando.Connection.Close();

                if (rowaffected != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }


        override public bool actualizarEntidad(ModeloPersonas p_mod_persona)
        { 
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();
            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText = 
                "UPDATE [personas] SET [dni]=@dni,[nombre]=@nombre, [apellido]=@apellido,"+
                "[tipo_persona]=@tipo_persona,[usuario]=@usuario, [contrasenia]=@contrasenia " +
                "WHERE [Personas].codigo_entidad=@codigo_entidad";

            comando.Parameters.Add(this.instanciarParametro(p_mod_persona.codigo, "@codigo_entidad"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_persona.dni, "@dni"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_persona.nombre, "@nombre"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_persona.apellido, "@apellido"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_persona.usuario, "@usuario"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_persona.contrasenia, "@contrasenia"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_persona.tipoPersona, "@tipo_persona"));

            comando.Connection.Open();
            int rowaffected = comando.ExecuteNonQuery();           
            comando.Connection.Close();

            if (rowaffected != 0 && base.actualizarEntidad(p_mod_persona))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool bajaEntidad(ModeloPersonas p_mod_persona)
        {
            //INCOMPLETO
            return base.bajaEntidad(p_mod_persona.codigo);
        }
        #endregion
      
        public List<ModeloRoles> getRoles(int p_codigoEntidad)
        {
            List<ModeloRoles> lcl_lst_mod_roles = new List<ModeloRoles>();
            
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText = 
                "SELECT [rol.codigo],[rol.descripcion] "+
                    "FROM [rol] "+
                    "INNER JOIN [roles_persona] ON [rol.codigo] = [roles_persona.codigo_rol] "+
                    "WHERE ([roles_persona.codigo_entidad] = @codigo_entidad)";

            comando.Parameters.Add(new SqlParameter("@codigo_entidad", SqlDbType.Int));
            comando.Parameters["@codigo_entidad"].Value = p_codigoEntidad;

            comando.Connection.Open();

            SqlDataReader drRoles = comando.ExecuteReader();

           ModeloRoles lcl_mod_rol = new ModeloRoles();

            while (drRoles.Read())
            {
                lcl_mod_rol.codigo =(int)drRoles["codigo"];
                lcl_mod_rol.descripcion =(string)drRoles["descripcion"];
                lcl_lst_mod_roles.Add(lcl_mod_rol);
            }
            drRoles.Close();

            comando.Connection.Close();

            return lcl_lst_mod_roles;
        }
        
     }
}

