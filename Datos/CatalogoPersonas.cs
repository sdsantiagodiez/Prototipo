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
    public class CatalogoPersonas : Catalogo
    {
        //Se considera cliente a aquellos con usuario y contraseña = "" 
        //y como usuario a aquellos que tengan completado el campo usuario y contraseña

        public bool validarDatos(string[] pDatos)
        {
            // Validar si los datos son correctos?
            return true;
        }

        public bool existeEntidad(string dni)
        {
            bool respuesta = false;
            if (getOnePorDNI(dni) != null)
            {
                respuesta = true;
            }
            return respuesta;
        }     

        private ModeloPersonas leerDatosPersonas(SqlDataReader drPersonas)
        {
            ModeloPersonas modPer = new ModeloPersonas();

            modPer.dni = (string)drPersonas["dni"];
            //Si algún valor esta null en Base de datos, se asigna null en el objeto
            //Caso contrario hay una string, y se asigna string
            modPer.cuit = (drPersonas["cuit"] != DBNull.Value) ? (string)drPersonas["cuit"] : null;
            modPer.nombre = (drPersonas["nombre"] != DBNull.Value) ? (string)drPersonas["nombre"] : null;
            modPer.apellido = (drPersonas["apellido"] != DBNull.Value) ? (string)drPersonas["apellido"] : null;
            modPer.direccion = (drPersonas["direccion"] != DBNull.Value) ? (string)drPersonas["direccion"] : null;
            modPer.ciudad = (drPersonas["ciudad"] != DBNull.Value) ? (string)drPersonas["ciudad"] : null;
            modPer.provincia = (drPersonas["provincia"] != DBNull.Value) ? (string)drPersonas["provincia"] : null;
            modPer.codigoPostal = (drPersonas["codigoPostal"] != DBNull.Value) ? (string)drPersonas["codigoPostal"] : null;
            modPer.observaciones = (drPersonas["observaciones"] != DBNull.Value) ? (string)drPersonas["observaciones"] : null;
            modPer.razonSocialProv = (drPersonas["razonSocialProveedor"] != DBNull.Value) ? (string)drPersonas["razonSocialProveedor"] : null;
            modPer.usuario = (drPersonas["usuario"] != DBNull.Value) ? (string)drPersonas["usuario"] : null;
            modPer.contrasenia = (drPersonas["contrasenia"] != DBNull.Value) ? (string)drPersonas["contrasenia"] : null;

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
                "SELECT [dni],[cuit],[nombre],[apellido],[direccion],[ciudad],[provincia]," +
                "[codigoPostal],[observaciones],[razonSocialProveedor], [usuario], [contrasenia] " +
                " FROM [personas] WHERE (nombre=@nombre " + tipoPersonaSQL + ")";

            comando.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar));
            comando.Parameters["@nombre"].Value = nombre;

            comando.Connection.Open();

            SqlDataReader drPersonas = comando.ExecuteReader();

            ModeloPersonas modPer = new ModeloPersonas();
            List<ModeloPersonas> pEncontradas = new List<ModeloPersonas>();
            while (drPersonas.Read())
            {
                modPer = this.leerDatosPersonas(drPersonas);

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
                "SELECT [dni],[cuit],[nombre],[apellido],[direccion],[ciudad],[provincia]," +
                "[codigoPostal],[observaciones],[razonSocialProveedor], [usuario], [contrasenia] " +
                " FROM [personas] WHERE (apellido=@apellido "+tipoPersonaSQL+")";

            comando.Parameters.Add(new SqlParameter("@apellido", SqlDbType.VarChar));
            comando.Parameters["@apellido"].Value = apellido;

            comando.Connection.Open();

            SqlDataReader drPersonas = comando.ExecuteReader();

            ModeloPersonas modPer;
            List<ModeloPersonas> pEncontradas = new List<ModeloPersonas>();
            while (drPersonas.Read())
            {
                modPer = new ModeloPersonas();
                modPer = this.leerDatosPersonas(drPersonas);

                pEncontradas.Add(modPer);
            }
            drPersonas.Close();
            comando.Connection.Close();

            return pEncontradas;
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
                "SELECT [dni],[cuit],[nombre],[apellido],[direccion],[ciudad],[provincia]," +
                "[codigoPostal],[observaciones],[razonSocialProveedor], [usuario], [contrasenia] " +
                "FROM [personas] WHERE ([usuario] = @usuario)";

            comando.Parameters.Add(new SqlParameter("@usuario", SqlDbType.VarChar));
            comando.Parameters["@usuario"].Value = usuario;

            comando.Connection.Open();

            SqlDataReader drPersonas = comando.ExecuteReader();

            while (drPersonas.Read())
            {
                modPer = new ModeloPersonas();
                modPer = this.leerDatosPersonas(drPersonas);
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
                "SELECT [dni],[cuit],[nombre],[apellido],[direccion],[ciudad],[provincia]," +
                "[codigoPostal],[observaciones],[razonSocialProveedor], [usuario], [contrasenia] " +
                "FROM [Personas] WHERE ([usuario] IS NULL AND dni=@DNI)";

            comando.Parameters.Add(new SqlParameter("@DNI", SqlDbType.VarChar));
            comando.Parameters["@DNI"].Value = dni;

            comando.Connection.Open();

            SqlDataReader drPersonas = comando.ExecuteReader();
            
            while (drPersonas.Read())
            {
                modPer = new ModeloPersonas();
                modPer = this.leerDatosPersonas(drPersonas);

            }
            drPersonas.Close();
            comando.Connection.Close();
           
            return modPer;
        }

        public List<ModeloPersonas> getAll()
        { 
            List<ModeloPersonas> allCli = new List<ModeloPersonas>();
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText = 
                "SELECT [dni],[cuit],[nombre],[apellido],[direccion],[ciudad],[provincia],"+
                "[codigoPostal],[observaciones],[razonSocialProveedor], [usuario], [contrasenia] "+
                "FROM [personas] WHERE [usuario] IS NULL";

            comando.Connection.Open();
            ModeloPersonas modPer;
            SqlDataReader drPersonas = comando.ExecuteReader();
            while (drPersonas.Read())
            {
                modPer = new ModeloPersonas();
                modPer = this.leerDatosPersonas(drPersonas);
                allCli.Add(modPer);
            }
            drPersonas.Close();

            comando.Connection.Close();

            return allCli;

        }

        #region Alta/Baja/Modificación
        /*
         * True si se realizó correctamente
         * False si ocurrió algún error
         */

        public bool agregarNuevaEntidad(ModeloPersonas modPer)
        {
            //Se debería chequear antes para notificar al usuario la razón por la que no se podrá realizar la operación
            if (!this.existeEntidad(modPer.dni))
            {
                //Creo la conexion y la abro
                SqlConnection ConexionSQL = Conexion.crearConexion();

                //crea SQL command
                SqlCommand comando = new SqlCommand();

                comando.Connection = ConexionSQL;

                comando.CommandType = CommandType.Text;

                comando.CommandText = 
                    "INSERT INTO [Personas]([dni],[cuit],[nombre],[apellido],[direccion],"+
                    "[ciudad],[provincia],[codigoPostal],[observaciones],[razonSocialProveedor],"+
                    " [usuario], [contrasenia]) "+ 
                    "VALUES (@dni, @cuit, @nombre, @apellido, @direccion, @ciudad, @provincia, "+
                    "@codigoPostal, @observaciones, @razonSocialProveedor, @usuario, @contrasenia)";
                //Indica los parametros
                comando.Parameters.Add(this.instanciarParametro(modPer.dni, "@dni"));
                comando.Parameters.Add(this.instanciarParametro(modPer.cuit, "@cuit"));
                comando.Parameters.Add(this.instanciarParametro(modPer.nombre, "@nombre"));
                comando.Parameters.Add(this.instanciarParametro(modPer.apellido, "@apellido"));
                comando.Parameters.Add(this.instanciarParametro(modPer.direccion, "@direccion"));
                comando.Parameters.Add(this.instanciarParametro(modPer.ciudad, "@ciudad"));
                comando.Parameters.Add(this.instanciarParametro(modPer.provincia, "@provincia"));
                comando.Parameters.Add(this.instanciarParametro(modPer.codigoPostal, "@codigoPostal"));
                comando.Parameters.Add(this.instanciarParametro(modPer.observaciones, "@observaciones"));
                comando.Parameters.Add(this.instanciarParametro(modPer.razonSocialProv, "@razonSocialProveedor"));
                comando.Parameters.Add(this.instanciarParametro(modPer.usuario, "@usuario"));
                comando.Parameters.Add(this.instanciarParametro(modPer.contrasenia, "@contrasenia"));

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
        public bool actualizarPersona(ModeloPersonas modPer)
        { 
         //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText = 
                "UPDATE [Personas] SET [cuit]=@cuit,[nombre]=@nombre, [apellido]=@apellido,"+
                "[direccion]=@direccion,[ciudad]=@ciudad, [provincia]=@provincia, [codigoPostal]=@codigoPostal,"+
                "[observaciones]=@observaciones,[razonSocialProveedor]=@razonSocialProveedor,[usuario]=@usuario, [contrasenia]=@contrasenia "+
                "WHERE [Personas].dni=@dni";

            comando.Parameters.Add(this.instanciarParametro(modPer.dni, "@dni"));
            comando.Parameters.Add(this.instanciarParametro(modPer.cuit, "@cuit"));
            comando.Parameters.Add(this.instanciarParametro(modPer.nombre, "@nombre"));
            comando.Parameters.Add(this.instanciarParametro(modPer.apellido, "@apellido"));
            comando.Parameters.Add(this.instanciarParametro(modPer.direccion, "@direccion"));
            comando.Parameters.Add(this.instanciarParametro(modPer.ciudad, "@ciudad"));
            comando.Parameters.Add(this.instanciarParametro(modPer.provincia, "@provincia"));
            comando.Parameters.Add(this.instanciarParametro(modPer.codigoPostal, "@codigoPostal"));
            comando.Parameters.Add(this.instanciarParametro(modPer.observaciones, "@observaciones"));
            comando.Parameters.Add(this.instanciarParametro(modPer.razonSocialProv, "@razonSocialProveedor"));
            comando.Parameters.Add(this.instanciarParametro(modPer.usuario, "@usuario"));
            comando.Parameters.Add(this.instanciarParametro(modPer.contrasenia, "@contrasenia"));
            
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

        public bool bajaPersona(string pDni)
        {
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText = 
                "DELETE FROM [Personas] WHERE [Personas].dni=@dni";

            comando.Parameters.Add(new SqlParameter("@dni", SqlDbType.VarChar));
            comando.Parameters["@dni"].Value = pDni;

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
                respuesta = " AND [usuario]=''";
            }
            else
            {
                respuesta = "";
            }
            
            return respuesta;
        }

        public List<ModeloRoles> getRoles(string dniUsuario)
        {
            List<ModeloRoles> roles = new List<ModeloRoles>();
            
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText = "SELECT [rol.codigo],[rol.descripcion] FROM [rol] JOIN" +
                " [rol_personas] ON [rol.codigo] = [rol_personas.codigo] "+
                "WHERE ([rol_personas.dniPersona] = @DNI)";

            comando.Parameters.Add(new SqlParameter("@DNI", SqlDbType.VarChar));
            comando.Parameters["@DNI"].Value = dniUsuario;

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

