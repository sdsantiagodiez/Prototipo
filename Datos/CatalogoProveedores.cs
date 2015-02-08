using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data.SqlClient;
using System.Data;

namespace Controlador
{
    public class CatalogoProveedores
    {
        public bool existeEntidad(string[] pDatos)
        {
            // Se crea la variable a retornar
            bool respuesta = false;
            //Creamos la lista de todos los Articulos
            List<ModeloProveedores> listProv = this.getAll();

            foreach (ModeloProveedores modPro in listProv)
            {
                if (pDatos[1] == modPro.cuitProv) /*|| (pDatos[2] = modPro.razonSocialProv)*/// Se busca si el proveedor ya existe comparando el codigo original
                {// ver como pasar los parametros
                    respuesta = true;
                    break;
                }
                else { respuesta = false; }

            }

            return respuesta;
        }


        public bool validarDatos(string[] pDatos)
        {
            //Valida que los parametros sean Validos en el dominio
            bool rta = false;
            return rta;
        }
        public List<ModeloProveedores> getAll()
        {
            List<ModeloProveedores> allProvs = new List<ModeloProveedores>();
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Datos.Conexion.crearConexion();

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
            SqlConnection ConexionSQL = Datos.Conexion.crearConexion();
            
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
            

        public ModeloProveedores getOne(string pRSocialProvedoor)
        {
            
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Datos.Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText = "SELECT [razonSocialProv],[cuitProv],[direccionProv],[ciudadProv],[provinciaProv],[codigoPostalProv],[obsProv], [mail_prov] FROM [proyecto].[dbo].[proveedores] INNER JOIN [proyecto].[dbo].[mail_prov] ON [proveedores].razonSocialProv = [mail_prov].razonSocialProv WHERE [proveedores].razonSocialProv=@razonSocialProv";

            comando.Parameters.Add(new SqlParameter("@razonSocialProv", SqlDbType.NVarChar));

            comando.Parameters["@razonSocialProv"].Value = pRSocialProvedoor;

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

        public List<ModeloProveedores> buscaProvxRSoCuit(string pCuitORS)
        {
            List<ModeloProveedores> allProvs = new List<ModeloProveedores>();
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Datos.Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText = "SELECT [razonSocialProv],[cuitProv],[direccionProv],[ciudadProv],[provinciaProv],[codigoPostalProv],[obsProv] FROM [proyecto].[dbo].[proveedores] WHERE (([razonSocialProv] like @RazonSocOCuit + '%') OR cuitProv like @RazonSocOCuit + '%')";

            comando.Parameters.Add(new SqlParameter("@RazonSocOCuit", SqlDbType.NVarChar));

            comando.Parameters["@RazonSocOCuit"].Value = pCuitORS;

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
        public List<ModeloProveedores> buscaProveedores(string pCuitOrS)
        {
            List<ModeloProveedores> pActuales = new List<ModeloProveedores>();

            pActuales = buscaProvxRSoCuit(pCuitOrS);

            return pActuales;
            
        }

        public string actualizarProveedor(ModeloProveedores modProv, string[] pModificar)
        {
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Datos.Conexion.crearConexion();

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

    }

    }

