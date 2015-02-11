using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class CatalogoProveedores
    {
        public bool validarDatos(string[] pDatos)
        {
            //Valida que los parametros sean Validos en el dominio
            bool rta = false;
            return rta;
        }    

        /// <summary>
        /// determina existencia de proveedor de acuerdo a cuit y razonSocial ingresados
        /// </summary>
        /// <param name="cuit">cuit de proveedor</param>
        /// <param name="razonSocial">razón social de proveedor</param>
        /// <returns>true si existe, false si no existe</returns>
        public bool existeEntidad(string cuit, string razonSocial)
        {
            bool respuesta = new bool();
            ModeloProveedores mp = new ModeloProveedores();
            mp = getOne(razonSocial);
            //Vuelve a comparar razonSocial porque no se como ver si getOne devuelve un objeto nulo 
            if (object.Equals(mp.razonSocialProv.ToLower(), razonSocial.ToLower()))
            {
                respuesta = true;
            }
            else
            {
                // Convierte respuesta en false si Count=0 y en true si es cualquier otro número
                respuesta = Convert.ToBoolean(buscarProveedores("cuit", cuit).Count);
            }
            
            return respuesta;
        }
        
        /// <summary>
        /// busca proveedores de acuerdo a descripcionParametro ingresada
        /// </summary>
        /// <param name="tipoParametro">"razonSocial" o "cuit"</param>
        /// <param name="descripcionParametro">string por el que se buscará proveedores</param>
        /// <returns>lista de proveedores</returns>
        public List<ModeloProveedores> buscarProveedores(string tipoParametro, string descripcionParametro)
        {
            List<ModeloProveedores> listaProveedores = new List<ModeloProveedores>();

            switch(tipoParametro.ToLower())
            {
                case "razonsocial":
                    listaProveedores = buscarPorRazonSocial(descripcionParametro.ToLower());
                    break;
                case "cuit":
                    listaProveedores = buscaPorCuit(descripcionParametro);
                    break;
                default:
                    break;
            }
            return listaProveedores;
        }

        private List<ModeloProveedores> buscarPorRazonSocial(string razonSocial)
        {
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT [razonSocialProv],[cuitProv],[direccionProv],[ciudadProv],[provinciaProv],[codigoPostalProv],[obsProv],[mail_prov] " +
                    "FROM [proyecto].[dbo].[proveedores] INNER JOIN [proyecto].[dbo].[mail_prov] ON [proveedores].razonSocialProv = [mail_prov].razonSocialProv " +
                    "WHERE LOWER([proveedores].razonSocialProv)=@razonSocialProv";
            comando.Parameters.Add(new SqlParameter("@razonSocialProv", SqlDbType.NVarChar));
            comando.Parameters["@razonSocialProv"].Value = razonSocial.ToLower();
            comando.Connection.Open();

            SqlDataReader drProveedores = comando.ExecuteReader();

            ModeloProveedores modPro = new ModeloProveedores();
            List<ModeloProveedores> listaProveedores = new List<ModeloProveedores>();
            while (drProveedores.Read())
            {

                modPro.razonSocialProv = (string)drProveedores["razonSocialProv"];
                modPro.cuitProv = (string)drProveedores["cuitProv"];
                modPro.direccionProv = (string)drProveedores["direccionProv"];
                modPro.ciudadProv = (string)drProveedores["ciudadProv"];
                modPro.provinciaProv = (string)drProveedores["provinciaProv"];
                modPro.codigoPostalProv = (string)drProveedores["codigoPostalProv"];
                modPro.obsProv = (string)drProveedores["obsProv"];
                listaProveedores.Add(modPro);
            }
            drProveedores.Close();

            comando.Connection.Close();

            return listaProveedores;
        }

        private List<ModeloProveedores> buscaPorCuit(string cuit)
        {
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText = 
                "SELECT [razonSocialProv],[cuitProv],[direccionProv],[ciudadProv],[provinciaProv],[codigoPostalProv],[obsProv]"+
                "FROM [proyecto].[dbo].[proveedores] WHERE cuitProv = @cuit";
            comando.Parameters.Add(new SqlParameter("@cuit", SqlDbType.NVarChar));
            comando.Parameters["@cuit"].Value = cuit;
            comando.Connection.Open();

            SqlDataReader drProveedores = comando.ExecuteReader();
            List<ModeloProveedores> listaProveedores = new List<ModeloProveedores>();

            while (drProveedores.Read())
            {
                ModeloProveedores modPro = new ModeloProveedores();
                modPro.razonSocialProv = (string)drProveedores["razonSocialProv"];
                modPro.cuitProv = (string)drProveedores["cuitProv"];
                modPro.direccionProv = (string)drProveedores["direccionProv"];
                modPro.ciudadProv = (string)drProveedores["ciudadProv"];
                modPro.provinciaProv = (string)drProveedores["provinciaProv"];
                modPro.codigoPostalProv = (string)drProveedores["codigoPostalProv"];
                modPro.obsProv = (string)drProveedores["obsProv"];
                listaProveedores.Add(modPro);
            }

            drProveedores.Close();
            comando.Connection.Close();

            return listaProveedores;
        }
        
        public ModeloProveedores getOne(string razonSocial)
        {
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText = 
                "SELECT [razonSocialProv],[cuitProv],[direccionProv],[ciudadProv],[provinciaProv],[codigoPostalProv],[obsProv],[mail_prov] "+
                "FROM [proyecto].[dbo].[proveedores] INNER JOIN [proyecto].[dbo].[mail_prov] ON [proveedores].razonSocialProv = [mail_prov].razonSocialProv "+
                "WHERE LOWER([proveedores].razonSocialProv)=@razonSocialProv";
            comando.Parameters.Add(new SqlParameter("@razonSocialProv", SqlDbType.NVarChar));
            comando.Parameters["@razonSocialProv"].Value = razonSocial.ToLower();
            comando.Connection.Open();

            SqlDataReader drProveedores = comando.ExecuteReader();

            ModeloProveedores modPro = new ModeloProveedores();

            while (drProveedores.Read())
            {

                modPro.razonSocialProv = (string)drProveedores["razonSocialProv"];
                modPro.cuitProv = (string)drProveedores["cuitProv"];
                modPro.direccionProv = (string)drProveedores["direccionProv"];
                modPro.ciudadProv = (string)drProveedores["ciudadProv"];
                modPro.provinciaProv = (string)drProveedores["provinciaProv"];
                modPro.codigoPostalProv = (string)drProveedores["codigoPostalProv"];
                modPro.obsProv = (string)drProveedores["obsProv"];

            }
            drProveedores.Close();

            comando.Connection.Close();

            return modPro;

        }
       
        public List<ModeloProveedores> getAll()
        {
            List<ModeloProveedores> allProvs = new List<ModeloProveedores>();
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText = "SELECT [razonSocialProv],[cuitProv],[direccionProv],[ciudadProv],[provinciaProv],[codigoPostalProv],[obsProv] FROM [proyecto].[dbo].[proveedores]";

            comando.Connection.Open();

            SqlDataReader drProveedores = comando.ExecuteReader();
            while (drProveedores.Read())
            {
                ModeloProveedores modPro = new ModeloProveedores();
                modPro.razonSocialProv = (string)drProveedores["razonSocialProv"];
                modPro.cuitProv = (string)drProveedores["cuitProv"];
                modPro.direccionProv = (string)drProveedores["direccionProv"];
                modPro.ciudadProv = (string)drProveedores["ciudadProv"];
                modPro.provinciaProv = (string)drProveedores["provinciaProv"];
                modPro.codigoPostalProv = (string)drProveedores["codigoPostalProv"];
                modPro.obsProv = (string)drProveedores["obsProv"];
                allProvs.Add(modPro);
            }
            drProveedores.Close();

            comando.Connection.Close();

            return allProvs;
        }

        public void agregarNuevaEntidad(ModeloProveedores pModProv)
        {
              //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();
            
            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType= CommandType.Text;

            comando.CommandText = "INSERT INTO [proyecto].[dbo].[proveedores]([razonSocialProv],[cuitProv],[direccionProv],[ciudadProv],[provinciaProv],[codigoPostalProv],[obsProv])VALUES (@razonSocialProv, @cuitProv, @obsArt, @direccionProv, @ciudadProv, @provinciaProv, @codigoPostalProv,@obsProv)";
            //Indica los parametros
            comando.Parameters.Add(new SqlParameter("@razonSocialProv", SqlDbType.NVarChar));
            comando.Parameters["@razonSocialProv"].Value = pModProv.razonSocialProv;
            comando.Parameters.Add(new SqlParameter("@cuitProv", SqlDbType.NVarChar));
            comando.Parameters["@cuitProv"].Value = pModProv.cuitProv;
            comando.Parameters.Add(new SqlParameter("@direccionProv", SqlDbType.NVarChar));
            comando.Parameters["@direccionProv"].Value = pModProv.direccionProv;
            comando.Parameters.Add(new SqlParameter("@ciudadProv", SqlDbType.NVarChar));
            comando.Parameters["@ciudadProv"].Value = pModProv.ciudadProv;
            comando.Parameters.Add(new SqlParameter("@provinciaProv", SqlDbType.NVarChar));
            comando.Parameters["@provinciaProv"].Value = pModProv.provinciaProv;
            comando.Parameters.Add(new SqlParameter("@codigoPostalProv", SqlDbType.NVarChar));
            comando.Parameters["@codigoPostalProv"].Value = pModProv.codigoPostalProv;
            comando.Parameters.Add(new SqlParameter("@obsProv", SqlDbType.NVarChar));
            comando.Parameters["@obsProv"].Value = pModProv.obsProv;

            comando.Connection.Open();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        //Insertar un nuevo Proveedor
        }     

        public string actualizarProveedor(ModeloProveedores modProv, string[] pModificar)
        {
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText = "UPDATE [proyecto].[dbo].[proveedores] SET [razonSocialProv] = @razonSocialNueva, [cuitProv] = @cuitProv, [direccionProv]=@direccionProv, [ciudadProv]=@ciudadProv, [provinciaProv]=@provinciaProv, [codigoPostalProv] = @codigoPostalProv, [obsProv] = @obsProv WHERE [proveedores].razonSocialProv=@razonSocialProv";

            comando.Parameters.Add(new SqlParameter("@razonSocialProv", SqlDbType.NVarChar));
            comando.Parameters["@razonSocialProv"].Value = modProv.razonSocialProv;

            comando.Parameters.Add(new SqlParameter("@razonSocialNueva", SqlDbType.NVarChar));
            comando.Parameters["@razonSocialNueva"].Value = pModificar[0];

            comando.Parameters.Add(new SqlParameter("@cuitProv", SqlDbType.NVarChar));
            comando.Parameters["@cuitProv"].Value = modProv.cuitProv;

            comando.Parameters.Add(new SqlParameter("@direccionProv", SqlDbType.NVarChar));
            comando.Parameters["@direccionProv"].Value = modProv.direccionProv;

            comando.Parameters.Add(new SqlParameter("@ciudadProv", SqlDbType.NVarChar));
            comando.Parameters["@ciudadProv"].Value = modProv.ciudadProv;

            comando.Parameters.Add(new SqlParameter("@provinciaProv", SqlDbType.NVarChar));
            comando.Parameters["@provinciaProv"].Value = modProv.provinciaProv;

            comando.Parameters.Add(new SqlParameter("@codigoPostalProv", SqlDbType.NVarChar));
            comando.Parameters["@codigoPostalProv"].Value = modProv.codigoPostalProv;

            comando.Parameters.Add(new SqlParameter("@obsProv", SqlDbType.NVarChar));
            comando.Parameters["@obsProv"].Value = modProv.obsProv;


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

        public string bajaProveedor(string pRazonSocial)
        {
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText = "DELETE FROM [proyecto].[dbo].[proveedores] WHERE [proveedores].razonSocialProv=@razonSocialProv";

            comando.Parameters.Add(new SqlParameter("@razonSocialProv", SqlDbType.NVarChar));
            comando.Parameters["@razonSocialProv"].Value = pRazonSocial;

            comando.Connection.Open();
            int rowaffected = comando.ExecuteNonQuery();
            comando.Connection.Close();

            if (rowaffected == 0)
            {
                return "Operacion Cancelada";
            }
            else
            {
                return "Proveedor de baja";
            }
        }

    }

}

