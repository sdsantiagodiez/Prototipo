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
    public class CatalogoPersonas
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
            // Se crea la variable a retornar
            bool respuesta = false;
            ModeloPersonas mp = getOnePorDNI(dni);
            if (object.Equals(mp.dni, dni))
            {
                respuesta = true;
            }
            return respuesta;
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
                    "[codigoPostal],[observaciones],[usuario],[contrasenia],[razonSocialProv]" +
                    " FROM [proyecto].[dbo].[personas] WHERE (nombre=@nombre " + tipoPersonaSQL + ")";

            comando.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar));
            comando.Parameters["@nombre"].Value = nombre;

            comando.Connection.Open();

            SqlDataReader drPersonas = comando.ExecuteReader();

            ModeloPersonas modPer = new ModeloPersonas();
            List<ModeloPersonas> pEncontradas = new List<ModeloPersonas>();
            while (drPersonas.Read())
            {
                modPer.dni = (string)drPersonas["dni"];
                modPer.cuit = (string)drPersonas["cuit"];
                modPer.nombre = (string)drPersonas["nombre"];
                modPer.apellido = (string)drPersonas["apellido"];
                modPer.direccion = (string)drPersonas["direccion"];
                modPer.ciudad = (string)drPersonas["ciudad"];
                modPer.provincia = (string)drPersonas["provincia"];
                modPer.codigoPostal = (string)drPersonas["codigoPostal"];
                modPer.observaciones = (string)drPersonas["observaciones"];
                modPer.usuario = (string)drPersonas["usuario"];
                modPer.contrasenia = (string)drPersonas["contrasenia"];
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
                "SELECT [dni],[cuit],[nombre],[apellido],[direccion],[ciudad],[provincia],"+
                    "[codigoPostal],[observaciones],[usuario],[contrasenia],[razonSocialProv]"+
                    " FROM [proyecto].[dbo].[personas] WHERE (apellido=@apellido "+tipoPersonaSQL+")";

            comando.Parameters.Add(new SqlParameter("@apellido", SqlDbType.VarChar));
            comando.Parameters["@apellido"].Value = apellido;

            comando.Connection.Open();

            SqlDataReader drPersonas = comando.ExecuteReader();

            ModeloPersonas modPer = new ModeloPersonas();
            List<ModeloPersonas> pEncontradas = new List<ModeloPersonas>();
            while (drPersonas.Read())
            {
                modPer.dni = (string)drPersonas["dni"];
                modPer.cuit = (string)drPersonas["cuit"];
                modPer.nombre = (string)drPersonas["nombre"];
                modPer.apellido = (string)drPersonas["apellido"];
                modPer.direccion = (string)drPersonas["direccion"];
                modPer.ciudad = (string)drPersonas["ciudad"];
                modPer.provincia = (string)drPersonas["provincia"];
                modPer.codigoPostal = (string)drPersonas["codigoPostal"];
                modPer.observaciones = (string)drPersonas["observaciones"];
                modPer.usuario = (string)drPersonas["usuario"];
                modPer.contrasenia = (string)drPersonas["contrasenia"];
                pEncontradas.Add(modPer);
            }
            drPersonas.Close();
            comando.Connection.Close();

            return pEncontradas;
        }

        public ModeloPersonas getOnePorUsuario(string usuario)
        {
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText = 
                "SELECT [dni],[cuit],[nombre],[apellido],[direccion],[ciudad],[provincia],"+
                "[codigoPostal],[observaciones],[usuario],[contrasenia],[razonSocialProv] "+
                "FROM [proyecto].[dbo].[personas] WHERE ([usuario] = @usuario)";

            comando.Parameters.Add(new SqlParameter("@usuario", SqlDbType.VarChar));
            comando.Parameters["@usuario"].Value = usuario;

            comando.Connection.Open();

            SqlDataReader drPersonas = comando.ExecuteReader();

            ModeloPersonas modPer = new ModeloPersonas();

            while (drPersonas.Read())
            {
                modPer.dni = (string)drPersonas["dni"];
                modPer.cuit = (string)drPersonas["cuit"];
                modPer.nombre = (string)drPersonas["nombre"];
                modPer.apellido = (string)drPersonas["apellido"];
                modPer.direccion = (string)drPersonas["direccion"];
                modPer.ciudad = (string)drPersonas["ciudad"];
                modPer.provincia = (string)drPersonas["provincia"];
                modPer.codigoPostal = (string)drPersonas["codigoPostal"];
                modPer.observaciones = (string)drPersonas["observaciones"];
                modPer.usuario = (string)drPersonas["usuario"];
                modPer.contrasenia = (string)drPersonas["contrasenia"];
            }
            drPersonas.Close();

            comando.Connection.Close();

            return modPer;
        }
        
        public ModeloPersonas getOnePorDNI(string dni)
        {
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText = "SELECT [dni],[cuit],[nombre],[apellido],[direccion],[ciudad],[provincia],[codigoPostal],[observaciones],[usuario],[contrasenia],[razonSocialProv]FROM [proyecto].[dbo].[personas] WHERE ([usuario] IS NULL AND dni=@DNIper)";

            comando.Parameters.Add(new SqlParameter("@DNIper", SqlDbType.VarChar));
            comando.Parameters["@DNIper"].Value = dni;

            comando.Connection.Open();

            SqlDataReader drPersonas = comando.ExecuteReader();

            ModeloPersonas modPer = new ModeloPersonas();

            while (drPersonas.Read())
            {
                modPer.dni = (string)drPersonas["dni"];
                modPer.cuit = (string)drPersonas["cuit"];
                modPer.nombre = (string)drPersonas["nombre"];
                modPer.apellido = (string)drPersonas["apellido"];
                modPer.direccion = (string)drPersonas["direccion"];
                modPer.ciudad = (string)drPersonas["ciudad"];
                modPer.provincia = (string)drPersonas["provincia"];
                modPer.codigoPostal = (string)drPersonas["codigoPostal"];
                modPer.observaciones = (string)drPersonas["observaciones"];
                modPer.usuario = (string)drPersonas["usuario"];
                modPer.contrasenia = (string)drPersonas["contrasenia"];

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

            comando.CommandText = "SELECT [dni],[cuit],[nombre],[apellido],[direccion],[ciudad],[provincia],[codigoPostal],[observaciones] FROM [proyecto].[dbo].[personas] WHERE [usuario] IS NULL";

            comando.Connection.Open();

            SqlDataReader drPersonas = comando.ExecuteReader();
            while (drPersonas.Read())
            {
                ModeloPersonas modPer = new ModeloPersonas();
                modPer.dni= (string)drPersonas["dni"];
                modPer.cuit = (string)drPersonas["cuit"];
                modPer.nombre = (string)drPersonas["nombre"];
                modPer.apellido = (string)drPersonas["apellido"];
                modPer.direccion = (string)drPersonas["direccion"];
                modPer.ciudad = (string)drPersonas["ciudad"];
                modPer.provincia = (string)drPersonas["provincia"];
                modPer.codigoPostal = (string)drPersonas["codigoPostal"];
                modPer.observaciones = (string)drPersonas["observaciones"];
                allCli.Add(modPer);
            }
            drPersonas.Close();

            comando.Connection.Close();

            return allCli;

        }

        #region Alta/Baja/Modificación
        
        public void agregarNuevaEntidad(ModeloPersonas pModPer)
            {
                //Creo la conexion y la abro
                SqlConnection ConexionSQL = Conexion.crearConexion();

                //crea SQL command
                SqlCommand comando = new SqlCommand();

                comando.Connection = ConexionSQL;

                comando.CommandType = CommandType.Text;

                comando.CommandText = "INSERT INTO [Personas]([dni],[cuit],[nombre],[apellido],[direccion],[ciudad],[provincia],[codigoPostal],[observaciones]) VALUES (@dni, @cuit, @nombre, @apellido, @direccion, @ciudad, @provincia, @codigoPostal, @observaciones)";
                //Indica los parametros
                comando.Parameters.Add(new SqlParameter("@dni", SqlDbType.VarChar));
                comando.Parameters["@dni"].Value = pModPer.dni;
                comando.Parameters.Add(new SqlParameter("@cuit", SqlDbType.VarChar));
                comando.Parameters["@cuit"].Value = pModPer.cuit;
                comando.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar));
                comando.Parameters["@nombre"].Value = pModPer.nombre;
                comando.Parameters.Add(new SqlParameter("@apellido", SqlDbType.VarChar));
                comando.Parameters["@apellido"].Value = pModPer.apellido;
                comando.Parameters.Add(new SqlParameter("@direccion", SqlDbType.VarChar));
                comando.Parameters["@direccion"].Value = pModPer.direccion;
                comando.Parameters.Add(new SqlParameter("@ciudad", SqlDbType.VarChar));
                comando.Parameters["@ciudad"].Value = pModPer.ciudad;
                comando.Parameters.Add(new SqlParameter("@provincia", SqlDbType.VarChar));
                comando.Parameters["@provincia"].Value = pModPer.provincia;
                comando.Parameters.Add(new SqlParameter("@codigoPostal", SqlDbType.VarChar));
                comando.Parameters["@codigoPostal"].Value = pModPer.codigoPostal;
                comando.Parameters.Add(new SqlParameter("@observaciones", SqlDbType.VarChar));
                comando.Parameters["@observaciones"].Value = pModPer.observaciones;
              
                comando.Connection.Open();
                comando.ExecuteNonQuery();
                comando.Connection.Close();
            }

        public string actualizarPersona(ModeloPersonas modPer, string[] pModificar)//el parametro pModificar solo contiene el numero de documento si es que es cambiado.
        { 
         //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText = "UPDATE [proyecto].[dbo].[personas] SET [dni]=@dniNew,[cuit]=@cuit,[nombre]=@nombre, [apellido]=@apellido,[direccion]=@direccion,[ciudad]=@ciudad, [provincia]=@provincia, [codigoPostal]=@codigoPostal,[observaciones]=@observaciones,[razonSocialProv]=@razonSocialProv WHERE [proveedores].dni=@dniAnt";

            comando.Parameters.Add(new SqlParameter("@dniAnt", SqlDbType.VarChar));
            comando.Parameters["@dniAnt"].Value = modPer.dni;

            comando.Parameters.Add(new SqlParameter("@dniNew", SqlDbType.VarChar));
            comando.Parameters["@dniNew"].Value = pModificar[0];

            comando.Parameters.Add(new SqlParameter("@cuit", SqlDbType.VarChar));
            comando.Parameters["@cuit"].Value = modPer.cuit;

            comando.Parameters.Add(new SqlParameter("@nombre", SqlDbType.VarChar));
            comando.Parameters["@nombre"].Value = modPer.nombre;

            comando.Parameters.Add(new SqlParameter("@apellido", SqlDbType.VarChar));
            comando.Parameters["@apellido"].Value = modPer.apellido;

            comando.Parameters.Add(new SqlParameter("@direccion", SqlDbType.VarChar));
            comando.Parameters["@direccion"].Value = modPer.direccion;

            comando.Parameters.Add(new SqlParameter("@ciudad", SqlDbType.VarChar));
            comando.Parameters["@ciudad"].Value = modPer.ciudad;

            comando.Parameters.Add(new SqlParameter("@provincia", SqlDbType.VarChar));
            comando.Parameters["@provincia"].Value = modPer.provincia;

            comando.Parameters.Add(new SqlParameter("@codigoPostal", SqlDbType.VarChar));
            comando.Parameters["@codigoPostal"].Value = modPer.codigoPostal;

            comando.Parameters.Add(new SqlParameter("@observaciones", SqlDbType.VarChar));
            comando.Parameters["@observaciones"].Value = modPer.observaciones;

            comando.Connection.Open();
            int rowaffected = comando.ExecuteNonQuery();           
            comando.Connection.Close();

            if (rowaffected == 0)
            {
                return "Error en actualizar";
            }
            else
            {
                return "Actualizacion finalizada";
            }


        }

        public string bajaPersona(string pDni)
        {
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText = "DELETE FROM [proyecto].[dbo].[personas] WHERE [personas].dni=@dni";

            comando.Parameters.Add(new SqlParameter("@dni", SqlDbType.VarChar));
            comando.Parameters["@dni"].Value = pDni;

            comando.Connection.Open();
            int rowaffected = comando.ExecuteNonQuery();
            comando.Connection.Close();

            if (rowaffected == 0)
            {
                return "Operacion Cancelada";
            }
            else
            {
                return "Cliente dado de baja";
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

            comando.CommandText = "SELECT [rol.codRol],[rol.descripRol] FROM [proyecto].[dbo].[rol] JOIN" +
                " [proyecto].[dbo].[rol_pers] ON [rol.codRol] = [rol_pers] JOIN"+
                " [proyecto].[dbo].[personas] ON [personas.dni] = [rol_pers.dni]" +
                "WHERE ([personas.dni] =@DNIper)";

            comando.Parameters.Add(new SqlParameter("@DNIper", SqlDbType.VarChar));
            comando.Parameters["@DNIper"].Value = dniUsuario;

            comando.Connection.Open();

            SqlDataReader drRoles = comando.ExecuteReader();

           ModeloRoles modRol = new ModeloRoles();

            while (drRoles.Read())
            {
                modRol.codigo =(int)drRoles["codRol"];
                modRol.descripcion =(string)drRoles["descripRol"];
                roles.Add(modRol);
            }
            drRoles.Close();

            comando.Connection.Close();

            return roles;
        }

     }
}

