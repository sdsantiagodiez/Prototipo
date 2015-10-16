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
        //Se considera cliente a aquellos con usuario y contraseña = "" 
        //y como usuario a aquellos que tengan completado el campo usuario y contraseña

        public bool validarDatos(ModeloPersonas persona)
        {
            // Validar si los datos son correctos?
            return true;
        }

        public bool existeEntidad(int codigoEntidad)
        {
            bool respuesta = false;
            if (getOnePorCodigo(codigoEntidad) != null)
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

        //Verificar que funcione metodo en switch
        /// <summary>
        /// Busca por dni, usuario(sólo usuarios), nombre, apellido o nombre y apellido y devuelve lista de Personas
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
                "SELECT [entidades.codigo],[entidades.tipo_entidad],[entidades.cuit],[entidades.observaciones],[personas.dni],"+
                "[personas.nombre],[personas.apellido],[personas.tipo_persona],[personas.usuario], [personas.contrasenia] " +
                    "FROM [personas] "+
                    "INNER JOIN [entidades] on [entidades.codigo] = [personas.codigo_entidad]" +
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
                "SELECT [entidades.codigo],[entidades.tipo_entidad],[entidades.cuit],[entidades.observaciones],[personas.dni],"+
                "[personas.nombre],[personas.apellido],[personas.tipo_persona],[personas.usuario], [personas.contrasenia] " +
                    "FROM [personas] "+
                    "INNER JOIN [entidades] on [entidades.codigo] = [personas.codigo_entidad]" +
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

        public ModeloPersonas getOnePorCodigo(int codigoEntidad)
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
                "SELECT [entidades.codigo],[entidades.tipo_entidad],[entidades.cuit],[entidades.observaciones],[personas.dni]," +
                "[personas.nombre],[personas.apellido],[personas.tipo_persona],[personas.usuario], [personas.contrasenia] " +
                    "FROM [personas] " +
                    "INNER JOIN [entidades] on [entidades.codigo] = [personas.codigo_entidad]" +
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
                "SELECT [entidades.codigo],[entidades.tipo_entidad],[entidades.cuit],[entidades.observaciones],[personas.dni]," +
                "[personas.nombre],[personas.apellido],[personas.tipo_persona],[personas.usuario], [personas.contrasenia] " +
                    "FROM [personas] " +
                    "INNER JOIN [entidades] on [entidades.codigo] = [personas.codigo_entidad]" +
                    "WHERE (dni=@DNI)";

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

