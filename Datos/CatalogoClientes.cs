using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data;
using System.Data.SqlClient;


namespace Controlador
{
    public class CatalogoClientes
    {

        public bool validarDatos(string[] pDatos)
        {
            // Validar si los datos son correctos?
            return true;
        }

        public bool existeEntidad(string[] pDatos)
        {
            // Se crea la variable a retornar
            bool respuesta = false;
            //Creamos la lista de todos los Articulos
            List<ModeloPersonas> listPer = this.getAll();
            
            foreach (ModeloPersonas modPer in listPer)
            {
                if (pDatos[1] == modPer.dniPers)// Se busca si la persona ya existe comparando el dni
                {
                    respuesta = true;
                    break;
                }
                else { respuesta = false; }

            }

            return respuesta;
        }

        public List<ModeloPersonas> getAll()
        { 
            List<ModeloPersonas> allCli = new List<ModeloPersonas>();
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Datos.Conexion.crearConexion();

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
                SqlConnection ConexionSQL = Datos.Conexion.crearConexion();

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
                comando.Parameters["@direcc"].Value = pModPer.direccPers;
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

        public ModeloPersonas getOne(string pDNIPers)
        {
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Datos.Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText = "SELECT [dniPers],[cuitPers],[nombrePers],[apellidoPers],[direccPers],[ciudadPers],[provinciaPers],[codigoPostalPers],[obsPers],[usuarioPers],[contraseniaPers],[razonSocialProv]FROM [proyecto].[dbo].[personas] WHERE ([usuarioPers] IS NULL AND dniPers=@DNIper)";

            comando.Parameters.Add(new SqlParameter("@DNIper", SqlDbType.NVarChar));
            comando.Parameters["DNIper"].Value = pDNIPers;

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

        public string actualizarCliente(ModeloPersonas modPer, string[] pModificar)//el parametro pModificar solo contiene el numero de documento si es que es cambaido.
        { 
         //Creo la conexion y la abro
            SqlConnection ConexionSQL = Datos.Conexion.crearConexion();

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

        }
    
    
    }



    }

