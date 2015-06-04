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
            if (object.Equals(mp.dniPers, dni))
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
                "SELECT [dniPers],[cuitPers],[nombrePers],[apellidoPers],[direccPers],[ciudadPers],[provinciaPers]," +
                    "[codigoPostalPers],[obsPers],[usuarioPers],[contraseniaPers],[razonSocialProv]" +
                    " FROM [proyecto].[dbo].[personas] WHERE (nombre=@nombre " + tipoPersonaSQL + ")";

            comando.Parameters.Add(new SqlParameter("@nombre", SqlDbType.NVarChar));
            comando.Parameters["@nombre"].Value = nombre;

            comando.Connection.Open();

            SqlDataReader drPersonas = comando.ExecuteReader();

            ModeloPersonas modPer = new ModeloPersonas();
            List<ModeloPersonas> pEncontradas = new List<ModeloPersonas>();
            while (drPersonas.Read())
            {
                modPer.dniPers = (string)drPersonas["dniPers"];
                modPer.cuitPers = (string)drPersonas["cuitPers"];
                modPer.nombrePres = (string)drPersonas["nombrePers"];
                modPer.apellidoPers = (string)drPersonas["apellidoPers"];
                modPer.direccPers = (string)drPersonas["direccPers"];
                modPer.ciudadPers = (string)drPersonas["ciudadPers"];
                modPer.provinciaPers = (string)drPersonas["provinciaPers"];
                modPer.codigoPostalPers = (string)drPersonas["codigoPostalPers"];
                modPer.obsPers = (string)drPersonas["obsPers"];
                modPer.usuarioPers = (string)drPersonas["usuarioPers"];
                modPer.contraseniaPers = (string)drPersonas["contraseniaPers"];
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
                "SELECT [dniPers],[cuitPers],[nombrePers],[apellidoPers],[direccPers],[ciudadPers],[provinciaPers],"+
                    "[codigoPostalPers],[obsPers],[usuarioPers],[contraseniaPers],[razonSocialProv]"+
                    " FROM [proyecto].[dbo].[personas] WHERE (apellidoPers=@apellido "+tipoPersonaSQL+")";

            comando.Parameters.Add(new SqlParameter("@apellido", SqlDbType.NVarChar));
            comando.Parameters["@apellido"].Value = apellido;

            comando.Connection.Open();

            SqlDataReader drPersonas = comando.ExecuteReader();

            ModeloPersonas modPer = new ModeloPersonas();
            List<ModeloPersonas> pEncontradas = new List<ModeloPersonas>();
            while (drPersonas.Read())
            {
                modPer.dniPers = (string)drPersonas["dniPers"];
                modPer.cuitPers = (string)drPersonas["cuitPers"];
                modPer.nombrePres = (string)drPersonas["nombrePers"];
                modPer.apellidoPers = (string)drPersonas["apellidoPers"];
                modPer.direccPers = (string)drPersonas["direccPers"];
                modPer.ciudadPers = (string)drPersonas["ciudadPers"];
                modPer.provinciaPers = (string)drPersonas["provinciaPers"];
                modPer.codigoPostalPers = (string)drPersonas["codigoPostalPers"];
                modPer.obsPers = (string)drPersonas["obsPers"];
                modPer.usuarioPers = (string)drPersonas["usuarioPers"];
                modPer.contraseniaPers = (string)drPersonas["contraseniaPers"];
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
                "SELECT [dniPers],[cuitPers],[nombrePers],[apellidoPers],[direccPers],[ciudadPers],[provinciaPers],"+
                "[codigoPostalPers],[obsPers],[usuarioPers],[contraseniaPers],[razonSocialProv] "+
                "FROM [proyecto].[dbo].[personas] WHERE ([usuarioPers] = @usuario)";

            comando.Parameters.Add(new SqlParameter("@usuario", SqlDbType.NVarChar));
            comando.Parameters["@usuario"].Value = usuario;

            comando.Connection.Open();

            SqlDataReader drPersonas = comando.ExecuteReader();

            ModeloPersonas modPer = new ModeloPersonas();

            while (drPersonas.Read())
            {
                modPer.dniPers = (string)drPersonas["dniPers"];
                modPer.cuitPers = (string)drPersonas["cuitPers"];
                modPer.nombrePres = (string)drPersonas["nombrePers"];
                modPer.apellidoPers = (string)drPersonas["apellidoPers"];
                modPer.direccPers = (string)drPersonas["direccPers"];
                modPer.ciudadPers = (string)drPersonas["ciudadPers"];
                modPer.provinciaPers = (string)drPersonas["provinciaPers"];
                modPer.codigoPostalPers = (string)drPersonas["codigoPostalPers"];
                modPer.obsPers = (string)drPersonas["obsPers"];
                modPer.usuarioPers = (string)drPersonas["usuarioPers"];
                modPer.contraseniaPers = (string)drPersonas["contraseniaPers"];
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

            comando.CommandText = "SELECT [dniPers],[cuitPers],[nombrePers],[apellidoPers],[direccPers],[ciudadPers],[provinciaPers],[codigoPostalPers],[obsPers],[usuarioPers],[contraseniaPers],[razonSocialProv]FROM [proyecto].[dbo].[personas] WHERE ([usuarioPers] IS NULL AND dniPers=@DNIper)";

            comando.Parameters.Add(new SqlParameter("@DNIper", SqlDbType.NVarChar));
            comando.Parameters["@DNIper"].Value = dni;

            comando.Connection.Open();

            SqlDataReader drPersonas = comando.ExecuteReader();

            ModeloPersonas modPer = new ModeloPersonas();

            while (drPersonas.Read())
            {
                modPer.dniPers = (string)drPersonas["dniPers"];
                modPer.cuitPers = (string)drPersonas["cuitPers"];
                modPer.nombrePres = (string)drPersonas["nombrePers"];
                modPer.apellidoPers = (string)drPersonas["apellidoPers"];
                modPer.direccPers = (string)drPersonas["direccPers"];
                modPer.ciudadPers = (string)drPersonas["ciudadPers"];
                modPer.provinciaPers = (string)drPersonas["provinciaPers"];
                modPer.codigoPostalPers = (string)drPersonas["codigoPostalPers"];
                modPer.obsPers = (string)drPersonas["obsPers"];
                modPer.usuarioPers = (string)drPersonas["usuarioPers"];
                modPer.contraseniaPers = (string)drPersonas["contraseniaPers"];

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

            comando.CommandText = "SELECT [dniPers],[cuitPers],[nombrePers],[apellidoPers],[direccPers],[ciudadPers],[provinciaPers],[codigoPostalPers],[obsPers] FROM [proyecto].[dbo].[personas] WHERE [usuarioPers] IS NULL";

            comando.Connection.Open();

            SqlDataReader drPersonas = comando.ExecuteReader();
            while (drPersonas.Read())
            {
                ModeloPersonas modPer = new ModeloPersonas();
                modPer.dniPers= (string)drPersonas["dniPers"];
                modPer.cuitPers = (string)drPersonas["cuitPers"];
                modPer.nombrePres = (string)drPersonas["nombrePers"];
                modPer.apellidoPers = (string)drPersonas["apellidoPers"];
                modPer.direccPers = (string)drPersonas["direccPers"];
                modPer.ciudadPers = (string)drPersonas["ciudadPers"];
                modPer.provinciaPers = (string)drPersonas["provinciaPers"];
                modPer.codigoPostalPers = (string)drPersonas["codigoPostalPers"];
                modPer.obsPers = (string)drPersonas["obsPers"];
                allCli.Add(modPer);
            }
            drPersonas.Close();

            comando.Connection.Close();

            return allCli;

        }

        public void agregarNuevaEntidad(ModeloPersonas pModPer)
            {
                //Creo la conexion y la abro
                SqlConnection ConexionSQL = Conexion.crearConexion();

                //crea SQL command
                SqlCommand comando = new SqlCommand();

                comando.Connection = ConexionSQL;

                comando.CommandType = CommandType.Text;

                comando.CommandText = "INSERT INTO [proyecto].[dbo].[personas]([dniPers],[cuitPers],[nombrePers],[apellidoPers],[direccPers],[ciudadPers],[provinciaPers],[codigoPostalPers],[obsPers]) VALUES (@dniPers, @cuitPers, @nombrePers, @apellidoPers, @direccPers, @ciudadPers, @provinciaPers, @codigoPostalPers, @obsPers)";
                //Indica los parametros
                comando.Parameters.Add(new SqlParameter("@dniPers", SqlDbType.NVarChar));
                comando.Parameters["@dniPers"].Value = pModPer.dniPers;
                comando.Parameters.Add(new SqlParameter("@cuitPers", SqlDbType.NVarChar));
                comando.Parameters["@cuitPers"].Value = pModPer.cuitPers;
                comando.Parameters.Add(new SqlParameter("@nombrePers", SqlDbType.NVarChar));
                comando.Parameters["@nombrePers"].Value = pModPer.nombrePres;
                comando.Parameters.Add(new SqlParameter("@apellidoPers", SqlDbType.NVarChar));
                comando.Parameters["@apellidoPers"].Value = pModPer.apellidoPers;
                comando.Parameters.Add(new SqlParameter("@direccionPers", SqlDbType.NVarChar));
                comando.Parameters["@direccionPers"].Value = pModPer.direccPers;
                comando.Parameters.Add(new SqlParameter("@ciudadPers", SqlDbType.NVarChar));
                comando.Parameters["@ciudadPers"].Value = pModPer.ciudadPers;
                comando.Parameters.Add(new SqlParameter("@provinciaPers", SqlDbType.NVarChar));
                comando.Parameters["@provinciaPers"].Value = pModPer.provinciaPers;
                comando.Parameters.Add(new SqlParameter("@codigoPostalPers", SqlDbType.NVarChar));
                comando.Parameters["@codigoPostalPers"].Value = pModPer.codigoPostalPers;
                comando.Parameters.Add(new SqlParameter("@obsPers", SqlDbType.NVarChar));
                comando.Parameters["@obsPers"].Value = pModPer.obsPers;
              

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

            comando.CommandText = "UPDATE [proyecto].[dbo].[personas] SET [dniPers]=@dniPersNew,[cuitPers]=@cuitPers,[nombrePers]=@nombrePers, [apellidoPers]=@apellidoPers,[direccPers]=@direccPers,[ciudadPers]=@ciudadPers, [provinciaPers]=@provinciaPers, [codigoPostalPers]=@codigoPostalPers,[obsPers]=@obsPers,[razonSocialProv]=@razonSocialProv WHERE [proveedores].dniPers=@dniPersAnt";

            comando.Parameters.Add(new SqlParameter("@dniPersAnt", SqlDbType.NVarChar));
            comando.Parameters["@dniPersAnt"].Value = modPer.dniPers;

            comando.Parameters.Add(new SqlParameter("@dniPersNew", SqlDbType.NVarChar));
            comando.Parameters["@dniPersNew"].Value = pModificar[0];

            comando.Parameters.Add(new SqlParameter("@cuitPers", SqlDbType.NVarChar));
            comando.Parameters["@cuitPers"].Value = modPer.cuitPers;

            comando.Parameters.Add(new SqlParameter("@nombrePres", SqlDbType.NVarChar));
            comando.Parameters["@nombrePres"].Value = modPer.nombrePres;

            comando.Parameters.Add(new SqlParameter("@apellidoPers", SqlDbType.NVarChar));
            comando.Parameters["@apellidoPers"].Value = modPer.apellidoPers;

            comando.Parameters.Add(new SqlParameter("@direccPers", SqlDbType.NVarChar));
            comando.Parameters["@direccPers"].Value = modPer.direccPers;

            comando.Parameters.Add(new SqlParameter("@ciudadPers", SqlDbType.NVarChar));
            comando.Parameters["@ciudadPers"].Value = modPer.ciudadPers;

            comando.Parameters.Add(new SqlParameter("@provinciaPers", SqlDbType.NVarChar));
            comando.Parameters["@provinciaPers"].Value = modPer.provinciaPers;

            comando.Parameters.Add(new SqlParameter("@codigoPostalPers", SqlDbType.NVarChar));
            comando.Parameters["@codigoPostalPers"].Value = modPer.codigoPostalPers;

            comando.Parameters.Add(new SqlParameter("@obsPers", SqlDbType.NVarChar));
            comando.Parameters["@obsPers"].Value = modPer.obsPers;

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

            comando.CommandText = "DELETE FROM [proyecto].[dbo].[personas] WHERE [personas].dniPers=@dniPers";

            comando.Parameters.Add(new SqlParameter("@dniPers", SqlDbType.NVarChar));
            comando.Parameters["@dniPers"].Value = pDni;

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
                respuesta = " AND [usuarioPers]=''";
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
                " [proyecto].[dbo].[personas] ON [personas.dniPers] = [rol_pers.dniPers]" +
                "WHERE ([personas.dniPers] =@DNIper)";

            comando.Parameters.Add(new SqlParameter("@DNIper", SqlDbType.NVarChar));
            comando.Parameters["@DNIper"].Value = dniUsuario;

            comando.Connection.Open();

            SqlDataReader drRoles = comando.ExecuteReader();

           ModeloRoles modRol = new ModeloRoles();

            while (drRoles.Read())
            {
                modRol.setCodigo((int)drRoles["codRol"]);
                modRol.setDescripcion((string)drRoles["descripRol"]);
                roles.Add(modRol);
            }
            drRoles.Close();

            comando.Connection.Close();

            return roles;
        }

     }
}

