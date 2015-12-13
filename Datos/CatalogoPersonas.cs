using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using System.Data;
using System.Data.SqlClient;



namespace Datos
{
    public class CatalogoPersonas : CatalogoEntidades
    {
        /// <summary>
        /// permite inicializar substring para consulta sql donde el valor del atributo 
        /// </summary>
        /// <param name="nombreParametro">Valor que luego es comparado con una celda de la tabla de datos</param>
        /// <param name="nombreParametroTabla">nombre de la columna en tabla de datos</param>
        /// <returns></returns>
        private string parametroBusqueda(string nombreParametro, string nombreParametroTabla,string comparador)
        {
            string querySQL =
                @" (" + nombreParametro + " IS NULL OR " + nombreParametro + " " + comparador + " " + "LOWER(" + nombreParametroTabla + ") ) ";
            return querySQL;
        }

        public bool validarDatos(ModeloPersonas persona)
        {
            // Validar si los datos son correctos?
            return true;
        }

        public bool existeEntidad(int codigoEntidad)
        {
            bool respuesta = false;
            if (getOne(codigoEntidad) != null)
            {
                respuesta = true;
            }
            return respuesta;
        }     

        private ModeloPersonas leerDatosPersonas(SqlDataReader drPersonas)
        {
            ModeloPersonas modPer = new ModeloPersonas();

            modPer.codigo = (int)drPersonas["codigo"];
            //Si algún valor esta null en Base de datos, se asigna null en el objeto
            //Caso contrario hay una string, y se asigna string
            modPer.dni = (drPersonas["dni"] != DBNull.Value) ? (string)drPersonas["dni"] : null;
            modPer.nombre = (drPersonas["nombre"] != DBNull.Value) ? (string)drPersonas["nombre"] : null;
            modPer.apellido = (drPersonas["apellido"] != DBNull.Value) ? (string)drPersonas["apellido"] : null;
            modPer.usuario = (drPersonas["usuario"] != DBNull.Value) ? (string)drPersonas["usuario"] : null;
            modPer.contrasenia = (drPersonas["contrasenia"] != DBNull.Value) ? (string)drPersonas["contrasenia"] : null;
            modPer.tipoPersona = (drPersonas["tipo_persona"] != DBNull.Value) ? (string)drPersonas["tipo_persona"] : null;

            modPer.cuit = (drPersonas["cuit"] != DBNull.Value) ? (string)drPersonas["cuit"] : null;
            modPer.tipoEntidad = (drPersonas["tipo_entidad"] != DBNull.Value) ? (string)drPersonas["tipo_entidad"] : null;
            modPer.observaciones = (drPersonas["observaciones"] != DBNull.Value) ? (string)drPersonas["observaciones"] : null;
            
            return modPer;
        }
        //Si se usa para un login, se debe validar en el logIn que usuario y contraseña no sean Nulls porque sino da valores
        /// <summary>
        /// Busca persona en base a todas sus variables
        /// </summary>
        /// <param name="pmPersona"></param>
        /// <returns></returns>
        public List<ModeloPersonas> buscarPersona(ModeloPersonas pmPersona)
        {
            List<ModeloPersonas> lmPersonas = new List<ModeloPersonas>();

            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            int? codigoEntidad = pmPersona.codigo == 0? null : (int?)pmPersona.codigo;
            comando.Parameters.Add(this.instanciarParametro(codigoEntidad, "@codigo_entidad"));
            string codigoEntidadQuery = @" (@codigo_entidad IS NULL OR @codigo_entidad = codigo_entidad) ";
            comando.Parameters.Add(this.instanciarParametro(pmPersona.cuit, "@cuit"));
            string cuitQuery = this.parametroBusqueda("@cuit", "cuit","=");
            comando.Parameters.Add(this.instanciarParametro(pmPersona.dni, "@dni"));
            string dniQuery = this.parametroBusqueda("@dni", "dni","=");
            //No se puede hacer .ToLower a null
            string nombre = (pmPersona.nombre == null) ? null : pmPersona.nombre.ToLower();
            comando.Parameters.Add(this.instanciarParametro(nombre, "@nombre"));
            string nombreQuery = this.parametroBusqueda("@nombre", "nombre","LIKE");
            //No se puede hacer .ToLower a null
            string apellido = (pmPersona.apellido == null) ? null : pmPersona.apellido.ToLower();
            comando.Parameters.Add(this.instanciarParametro(apellido, "@apellido"));
            string apellidoQuery = this.parametroBusqueda("@apellido", "apellido", "LIKE");
            comando.Parameters.Add(this.instanciarParametro(pmPersona.usuario, "@usuario"));
            string usuarioQuery = @" (@usuario IS NULL OR @usuario = usuario) ";
            comando.Parameters.Add(this.instanciarParametro(pmPersona.contrasenia, "@contrasenia"));
            string contraseniaQuery = @" (@contrasenia IS NULL OR @contrasenia = contrasenia) ";
            comando.Parameters.Add(this.instanciarParametro(pmPersona.tipoPersona, "@tipo_persona"));
            string tipoPersonaQuery = @" (@tipo_persona IS NULL OR @tipo_persona = tipo_persona) "; 

            string querySQL = codigoEntidadQuery +" AND " + cuitQuery + " AND " + dniQuery + " AND " + nombreQuery + " AND " + apellidoQuery + " AND " + usuarioQuery + " AND " + contraseniaQuery + " AND " + tipoPersonaQuery;

            comando.CommandText =
                "SELECT [entidades].codigo,[entidades].tipo_entidad,[entidades].cuit,[entidades].observaciones,[personas].dni," +
                "[personas].nombre,[personas].apellido,[personas].tipo_persona,[personas].usuario, [personas].contrasenia " +
                    "FROM [personas] " +
                    "INNER JOIN [entidades] on [entidades].codigo = [personas].codigo_entidad " +
                    "WHERE "+querySQL ;

            comando.Connection.Open();

            SqlDataReader drPersonas = comando.ExecuteReader();

            ModeloPersonas modPer = new ModeloPersonas();
            
            while (drPersonas.Read())
            {
                modPer = new ModeloPersonas();
                modPer = this.leerDatosPersonas(drPersonas);

                modPer.mails = this.getMails(modPer.codigo);
                modPer.telefonos = this.getTelefonos(modPer.codigo);
                modPer.domicilios = this.getDomicilios(modPer.codigo);

                lmPersonas.Add(modPer);
            }
            drPersonas.Close();
            comando.Connection.Close();

            return lmPersonas;
        }

        /// <summary>
        /// Busca personas en base al parámetro ingresado
        /// </summary>
        /// <param name="pmPersona"></param>
        /// <param name="paramentroBusqueda">cuit,dni,nombre,apellido,usuario,tipoPersona</param>
        /// <returns></returns>
        public List<ModeloPersonas> buscarPersona(ModeloPersonas pmPersona, string paramentroBusqueda)
        {
            List<ModeloPersonas> lmPersonas = new List<ModeloPersonas>();

            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            string querySQL = "";

            #region switch parametroBusqueda
            switch (paramentroBusqueda.ToLower())
            {
                case "cuit":
                    comando.Parameters.Add(this.instanciarParametro(pmPersona.cuit, "@cuit"));
                    querySQL = " cuit = @cuit ";
                    break;
                case "dni":
                    comando.Parameters.Add(this.instanciarParametro(pmPersona.dni, "@dni"));
                    querySQL = " dni = @dni ";
                    break;
                case "nombre":
                    comando.Parameters.Add(this.instanciarParametro(pmPersona.nombre, "@nombre"));
                    querySQL = " nombre = @nombre ";
                    break;
                case "apellido":
                    comando.Parameters.Add(this.instanciarParametro(pmPersona.apellido, "@apellido"));
                    querySQL = " apellido = @apellido ";
                    break;
                case "usuario":
                    comando.Parameters.Add(this.instanciarParametro(pmPersona.usuario, "@usuario"));
                    querySQL = " usuario = @usuario ";
                    break;
                case "tipoPersona":
                    comando.Parameters.Add(this.instanciarParametro(pmPersona.tipoPersona, "@tipo_persona"));
                    querySQL = " tipo_persona = @tipo_persona ";
                    break;
                default:
                    //hace que sql no retorne filas
                    querySQL = "1 = 2";
                    break;
            }
            #endregion
            
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
                pmPersona = new ModeloPersonas();
                pmPersona = this.leerDatosPersonas(drPersonas);

                pmPersona.mails = this.getMails(pmPersona.codigo);
                pmPersona.telefonos = this.getTelefonos(pmPersona.codigo);
                pmPersona.domicilios = this.getDomicilios(pmPersona.codigo);

                lmPersonas.Add(pmPersona);
            }
            drPersonas.Close();
            comando.Connection.Close();

            return lmPersonas;
        }

        //eliminarlos y reemplazarlos por los anteriores cuando se puedan probar
        #region metodos de búsqueda obsoletos
        /// <summary>
        /// NO USAR!! usar método buscarPersona
        /// </summary>
        /// <param name="tipoPersona">"cliente" o "usuario"</param>
        /// <param name="tipoParametro">"dni", "nombre","apellido","nombreYapellido"(Considera ambos),"usuario"(Solo para tipo usuario)</param>
        /// <param name="descripcionParametro"></param>
        /// <returns>lista de personas o lista vacía si no hay coincidencias</returns>
        public List<ModeloPersonas> buscarPersona(string tipoPersona, string tipoParametro, string descripcionParametro)
        {
            //Se sacan espacios en extremos, se pasa a minúscula 
            //y se separa descripcionParametro de acuerdo a los espacios(' ') 
            //que hayan sido ingresados.
            string[] descripcion = descripcionParametro.Trim().ToLower().Split(' ');
            tipoParametro.Trim().ToLower();
            tipoPersona.Trim().ToLower();

            List<ModeloPersonas> pEncontradas = new List<ModeloPersonas>();
            ModeloPersonas mp = new ModeloPersonas();
            switch (tipoParametro)
            {
                case "dni":
                    mp = getOnePorDNI(descripcionParametro);
                    pEncontradas.Add(mp);
                    break;
                case "usuario":
                    if (object.Equals(tipoPersona, "usuario"))
                    {
                        mp = getOnePorUsuario(descripcionParametro);
                        pEncontradas.Add(mp);
                    };
                    break;
                case "nombre":
                    foreach (string nombre in descripcion)
                    {
                        pEncontradas.AddRange(buscarPorNombre(tipoPersona,nombre));
                    }
                    break;
                case "apellido":
                    foreach(string apellido in descripcion)
                    {
                        pEncontradas.AddRange(buscarPorApellido(tipoPersona,apellido));
                    }
                    break;
                case "nombreYapellido":
                    List<ModeloPersonas> pEncontradasTemp = new List<ModeloPersonas>();
                    foreach(string nombreOapellido in descripcion)
                    {
                        pEncontradasTemp.AddRange(buscarPorNombre(tipoPersona, nombreOapellido));
                        pEncontradasTemp.AddRange(buscarPorApellido(tipoPersona, nombreOapellido));
                    }
                    //remueve duplicados generados por la busqueda anterior (Verificar que funcione correctamente)
                    pEncontradas = pEncontradasTemp.Distinct().ToList();
                    break;
            }

            return pEncontradas;
        }
        /// <summary>
        /// NO USAR!! usar método buscarPersona
        /// </summary>
        /// <param name="tipoPersona"></param>
        /// <param name="nombre"></param>
        /// <returns></returns>
        private List<ModeloPersonas> buscarPorNombre(string tipoPersona,string nombre)
        {
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //devuelve linea de sql que determina si persona es cliente o usuario
            string tipoPersonaSQL = getStringSQL(tipoPersona);
            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText =
                "SELECT [entidades].codigo,[entidades].tipo_entidad,[entidades].cuit,[entidades].observaciones,[personas].dni," +
                "[personas].nombre,[personas].apellido,[personas].tipo_persona,[personas].usuario, [personas].contrasenia " +
                    "FROM [personas] "+
                    "INNER JOIN [entidades] on [entidades].codigo = [personas].codigo_entidad" +
                    "WHERE (nombre LIKE @nombre " + tipoPersonaSQL + ")";

            comando.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar));
            comando.Parameters["@nombre"].Value = "%" + nombre + "%";

            comando.Connection.Open();

            SqlDataReader drPersonas = comando.ExecuteReader();

            ModeloPersonas modPer = new ModeloPersonas();
            List<ModeloPersonas> pEncontradas = new List<ModeloPersonas>();
            while (drPersonas.Read())
            {
                modPer = new ModeloPersonas();
                modPer = this.leerDatosPersonas(drPersonas);

                modPer.mails = this.getMails(modPer.codigo);
                modPer.telefonos = this.getTelefonos(modPer.codigo);
                modPer.domicilios = this.getDomicilios(modPer.codigo);

                pEncontradas.Add(modPer);
            }
            drPersonas.Close();
            comando.Connection.Close();

            return pEncontradas;
        }
        /// <summary>
        /// NO USAR!! usar método buscarPersona
        /// </summary>
        /// <param name="tipoPersona"></param>
        /// <param name="apellido"></param>
        /// <returns></returns>
        private List<ModeloPersonas> buscarPorApellido(string tipoPersona, string apellido)
        {
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //devuelve linea de sql que determina si persona es cliente o usuario
            string tipoPersonaSQL = getStringSQL(tipoPersona);
            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText =
                "SELECT [entidades].codigo,[entidades].tipo_entidad,[entidades].cuit,[entidades].observaciones,[personas].dni," +
                "[personas].nombre,[personas].apellido,[personas].tipo_persona,[personas].usuario, [personas].contrasenia " +
                    "FROM [personas] "+
                    "INNER JOIN [entidades] on [entidades].codigo = [personas].codigo_entidad" +
                    "WHERE (apellido LIKE @apellido "+tipoPersonaSQL+")";

            comando.Parameters.Add(new SqlParameter("@apellido", SqlDbType.VarChar));
            comando.Parameters["@apellido"].Value = "%" + apellido + "%";

            comando.Connection.Open();

            SqlDataReader drPersonas = comando.ExecuteReader();

            ModeloPersonas modPer = new ModeloPersonas();
            List<ModeloPersonas> pEncontradas = new List<ModeloPersonas>();
            while (drPersonas.Read())
            {
                modPer = new ModeloPersonas();
                modPer = this.leerDatosPersonas(drPersonas);

                modPer.mails = this.getMails(modPer.codigo);
                modPer.telefonos = this.getTelefonos(modPer.codigo);
                modPer.domicilios = this.getDomicilios(modPer.codigo);

                pEncontradas.Add(modPer);
            }
            drPersonas.Close();
            comando.Connection.Close();

            return pEncontradas;
        }
        /// <summary>
        /// NO USAR!! usar método buscarPersona
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public ModeloPersonas getOnePorUsuario(string usuario)
        {
            ModeloPersonas modPer = null;
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText =
                "SELECT [entidades].codigo,[entidades].tipo_entidad,[entidades].cuit,[entidades].observaciones,[personas].dni," +
                "[personas].nombre,[personas].apellido,[personas].tipo_persona,[personas].usuario, [personas].contrasenia " +
                    "FROM [personas] " +
                    "INNER JOIN [entidades] on [entidades].codigo = [personas].codigo_entidad" +
                    "WHERE ([usuario] = @usuario)";

            comando.Parameters.Add(new SqlParameter("@usuario", SqlDbType.VarChar));
            comando.Parameters["@usuario"].Value = usuario;

            comando.Connection.Open();

            SqlDataReader drPersonas = comando.ExecuteReader();

            while (drPersonas.Read())
            {
                modPer = new ModeloPersonas();
                modPer = this.leerDatosPersonas(drPersonas);

                modPer.mails = this.getMails(modPer.codigo);
                modPer.telefonos = this.getTelefonos(modPer.codigo);
                modPer.domicilios = this.getDomicilios(modPer.codigo);
            }
            drPersonas.Close();

            comando.Connection.Close();

            return modPer;
        }
        /// <summary>
        /// NO USAR!! usar método buscarPersona
        /// </summary>
        /// <param name="dni"></param>
        /// <returns></returns>
        public ModeloPersonas getOnePorDNI(string dni)
        {

            ModeloPersonas modPer = null;
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText =
                "SELECT [entidades].codigo,[entidades].tipo_entidad,[entidades].cuit,[entidades].observaciones,[personas].dni," +
                "[personas].nombre,[personas].apellido,[personas].tipo_persona,[personas].usuario, [personas].contrasenia " +
                    "FROM [personas] " +
                    "INNER JOIN [entidades] on [entidades].codigo=[personas].codigo_entidad" +
                    "WHERE ( dni = @DNI )";

            comando.Parameters.Add(new SqlParameter("@DNI", SqlDbType.VarChar));
            comando.Parameters["@DNI"].Value = dni;

            comando.Connection.Open();

            SqlDataReader drPersonas = comando.ExecuteReader();
            
            while (drPersonas.Read())
            {
                modPer = new ModeloPersonas();
                modPer = this.leerDatosPersonas(drPersonas);
                
                modPer.mails = this.getMails(modPer.codigo);
                modPer.telefonos = this.getTelefonos(modPer.codigo);
                modPer.domicilios = this.getDomicilios(modPer.codigo);
            }
            drPersonas.Close();
            comando.Connection.Close();
           
            return modPer;
        }
        #endregion

        new public ModeloPersonas getOne(int codigoEntidad)
        {
            ModeloPersonas modPersona = null;
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText =
               "SELECT [entidades].codigo,[entidades].tipo_entidad,[entidades].cuit,[entidades].observaciones,[personas].dni," +
                "[personas].nombre,[personas].apellido,[personas].tipo_persona,[personas].usuario, [personas].contrasenia " +
                    "FROM [personas] " +
                    "INNER JOIN [entidades] on [entidades].codigo = [personas].codigo_entidad " +
                    "WHERE [entidades].codigo = @codigo";
            comando.Parameters.Add(new SqlParameter("@codigo", SqlDbType.Int));
            comando.Parameters["@codigo"].Value = codigoEntidad;
            comando.Connection.Open();

            SqlDataReader drEntidades = comando.ExecuteReader();

            while (drEntidades.Read())
            {
                modPersona = new ModeloPersonas();
                modPersona = this.leerDatosPersonas(drEntidades);
                modPersona.mails = this.getMails(modPersona.codigo);
                modPersona.telefonos = this.getTelefonos(modPersona.codigo);
                modPersona.domicilios = this.getDomicilios(modPersona.codigo);
            }
            drEntidades.Close();
            comando.Connection.Close();

            return modPersona;
        }

        public new List<ModeloPersonas> getAll()
        { 
            List<ModeloPersonas> personas = new List<ModeloPersonas>();
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText =
                "SELECT [entidades].codigo,[entidades].tipo_entidad,[entidades].cuit,[entidades].observaciones,[personas].dni," +
                "[personas].nombre,[personas].apellido,[personas].tipo_persona,[personas].usuario, [personas].contrasenia " +
                    "FROM [personas] " +
                    "INNER JOIN [entidades] on [entidades].codigo = [personas].codigo_entidad";

            comando.Connection.Open();
            ModeloPersonas modPer;
            SqlDataReader drPersonas = comando.ExecuteReader();
            while (drPersonas.Read())
            {
                modPer = new ModeloPersonas();
                modPer = this.leerDatosPersonas(drPersonas);

                modPer.mails = this.getMails(modPer.codigo);
                modPer.telefonos = this.getTelefonos(modPer.codigo);
                modPer.domicilios = this.getDomicilios(modPer.codigo);

                personas.Add(modPer);
            }
            drPersonas.Close();

            comando.Connection.Close();

            return personas;

        }

        #region Alta/Baja/Modificación
        /*
         * True si se realizó correctamente
         * False si ocurrió algún error
         */

        public override bool agregarNuevaEntidad(ModeloPersonas pModPer)
        {
            //Se debería chequear antes para notificar al usuario la razón por la que no se podrá realizar la operación
            //y continua si se creó exitosamente la entidad
            if (!this.existeEntidad(pModPer.codigo) && base.agregarNuevaEntidad(pModPer))
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
                comando.Parameters.Add(this.instanciarParametro(pModPer.dni, "@dni"));
                comando.Parameters.Add(this.instanciarParametro(pModPer.nombre, "@nombre"));
                comando.Parameters.Add(this.instanciarParametro(pModPer.apellido, "@apellido"));
                comando.Parameters.Add(this.instanciarParametro(pModPer.usuario, "@usuario"));
                comando.Parameters.Add(this.instanciarParametro(pModPer.contrasenia, "@contrasenia"));
                comando.Parameters.Add(this.instanciarParametro(pModPer.tipoPersona, "@tipo_persona"));
                
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

        /*No va a haber opción de cambiar DNI. Usuario tendrá
         * que eliminar usuario anterior y crearlo de nuevo
         */
        override public bool actualizarEntidad(ModeloPersonas pModPer)
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

            comando.Parameters.Add(this.instanciarParametro(pModPer.codigo, "@codigo_entidad"));
            comando.Parameters.Add(this.instanciarParametro(pModPer.dni, "@dni"));
            comando.Parameters.Add(this.instanciarParametro(pModPer.nombre, "@nombre"));
            comando.Parameters.Add(this.instanciarParametro(pModPer.apellido, "@apellido"));
            comando.Parameters.Add(this.instanciarParametro(pModPer.usuario, "@usuario"));
            comando.Parameters.Add(this.instanciarParametro(pModPer.contrasenia, "@contrasenia"));
            comando.Parameters.Add(this.instanciarParametro(pModPer.tipoPersona, "@tipo_persona"));

            comando.Connection.Open();
            int rowaffected = comando.ExecuteNonQuery();           
            comando.Connection.Close();

            if (rowaffected != 0 && base.actualizarEntidad(pModPer))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool bajaEntidad(ModeloPersonas pModPer)
        {
            //INCOMPLETO
            return base.bajaEntidad(pModPer.codigo);
        }
        #endregion
        
        /// <summary>
        /// Devuelve línea de sql de acuerdo a si persona es cliente o usuario
        /// </summary>
        /// <param name="tipoPersona"></param>
        /// <returns></returns>
        private string getStringSQL(string tipoPersona)
        {
            string respuesta;
            tipoPersona.ToLower().Trim();

            if (!object.Equals(tipoPersona, "usuario"))
            {
                respuesta = " AND [tipo_persona]<>'USR' ";
            }
            else
            {
                respuesta = " AND [tipo_persona]='USR' ";
            }
            
            return respuesta;
        }

        public List<ModeloRoles> getRoles(int codigoEntidad)
        {
            List<ModeloRoles> roles = new List<ModeloRoles>();
            
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
            comando.Parameters["@codigo_entidad"].Value = codigoEntidad;

            comando.Connection.Open();

            SqlDataReader drRoles = comando.ExecuteReader();

           ModeloRoles modRol = new ModeloRoles();

            while (drRoles.Read())
            {
                modRol.codigo =(int)drRoles["codigo"];
                modRol.descripcion =(string)drRoles["descripcion"];
                roles.Add(modRol);
            }
            drRoles.Close();

            comando.Connection.Close();

            return roles;
        }
        
     }
}

