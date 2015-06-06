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
    public class CatalogoArticuloProveedores
    {
        public bool validarDatos(string[] pDatos)
        {
            // Validar si los datos son correctos?
            return true;
        }

        /// <summary>
        /// Determina existencia de articuloProveedor de acuerdo a codigoArticuloProveedor ingresado
        /// </summary>
        /// <param name="codigoArticuloProveedor">código articulo proveedor de artículo proveedor</param>
        /// <returns>true si existe, false si no existe</returns>
        public bool existeEntidad(string codigoArticuloProveedor)
        {
            // Convierte respuesta en false si Count=0 y en true si es cualquier otro número
            bool respuesta = Convert.ToBoolean(buscarArticuloProveedor("codigoArticuloProveedor",codigoArticuloProveedor).Count);
            return respuesta;
        }    

        /// <summary>
        /// busca articulo proveedor de acuerdo a tipoParametro ingresado
        /// </summary>
        /// <param name="tipoParametro">"codigoOriginal" o "codigoArticuloProveedor" o "descripcion"</param>
        /// <param name="descripcionParametro">string por el que se buscará artículo</param>
        /// <returns></returns>
        public List<ModeloArticuloProveedores> buscarArticuloProveedor(string tipoParametro, string descripcionParametro)
        {
            List<ModeloArticuloProveedores> listaArticulosProveedores = new List<ModeloArticuloProveedores>();

            switch(tipoParametro.ToLower())
            {
                case "codigooriginal":
                    listaArticulosProveedores = buscarPorCodigoOriginal(descripcionParametro);
                    break;
                case "codigoarticuloproveedor":
                    listaArticulosProveedores = buscarPorCodigoArticuloProveedor(descripcionParametro);
                    break;
                case "descripcion":
                    listaArticulosProveedores = buscarPorDescripcion(descripcionParametro);
                    break;
                default:
                    break;
            }
            return listaArticulosProveedores;
        }

        private List<ModeloArticuloProveedores> buscarPorDescripcion(string pDescrip)
        {
            List<ModeloArticuloProveedores> ArtProvxDesc = new List<ModeloArticuloProveedores>();
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText = "SELECT [codigoOriginalArt],[codigoArtProveedor],[stockMinimoArtPro],[stockActualArtPro],[obsArtPro],[descripArtPro],[fechaUltimaActualizacionArtPro],[razonSocialProv]FROM [art_prov] WHERE descripArtPro like @descrip + '%'";

            comando.Parameters.Add(new SqlParameter("@descrip", SqlDbType.NVarChar));
            comando.Parameters["@descrip"].Value = pDescrip;

            comando.Connection.Open();

            SqlDataReader drArtProveedores = comando.ExecuteReader();
            while (drArtProveedores.Read())
            {
                ModeloArticuloProveedores modArtProv = new ModeloArticuloProveedores();
                modArtProv.codigoOriginalArt = (string)drArtProveedores["codigoOriginalArt"];
                modArtProv.codigoArtProveedor = (string)drArtProveedores["codigoArtProveedor"];
                modArtProv.stockMinimoArtPro = (int)drArtProveedores["stockMinimoArtPro"];
                modArtProv.stockActualArtPro = (int)drArtProveedores["stockActualArtPro"];
                modArtProv.obsArtPro = (string)drArtProveedores["obsArtPro"];
                modArtProv.descripArtPro = (string)drArtProveedores["descripArtPro"];
                modArtProv.fechaUltimaActualizacionArtPro = (DateTime)drArtProveedores["fechaUltimaActualizacionArtPro"];
                modArtProv.razonSocialProv = (string)drArtProveedores["razonSocialProv"];
                ArtProvxDesc.Add(modArtProv);
            }
            drArtProveedores.Close();

            comando.Connection.Close();

            return ArtProvxDesc;

        }

        private List<ModeloArticuloProveedores> buscarPorCodigoOriginal(string pCodigoOriginal)
        {
            List<ModeloArticuloProveedores> ArtProvxCodOrg = new List<ModeloArticuloProveedores>();
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText = "SELECT [codigoOriginalArt],[codigoArtProveedor],[stockMinimoArtPro],[stockActualArtPro],[obsArtPro],[descripArtPro],[fechaUltimaActualizacionArtPro],[razonSocialProv]FROM [art_prov] WHERE codigoOriginalArt = @codOriginal";

            comando.Parameters.Add(new SqlParameter("@codOriginal", SqlDbType.NVarChar));
            comando.Parameters["@codOriginal"].Value = pCodigoOriginal;

            comando.Connection.Open();

            SqlDataReader drArtProveedores = comando.ExecuteReader();
            while (drArtProveedores.Read())
            {
                ModeloArticuloProveedores modArtProv = new ModeloArticuloProveedores();
                modArtProv.codigoOriginalArt = (string)drArtProveedores["codigoOriginalArt"];
                modArtProv.codigoArtProveedor = (string)drArtProveedores["codigoArtProveedor"];
                modArtProv.stockMinimoArtPro = (int)drArtProveedores["stockMinimoArtPro"];
                modArtProv.stockActualArtPro = (int)drArtProveedores["stockActualArtPro"];
                modArtProv.obsArtPro = (string)drArtProveedores["obsArtPro"];
                modArtProv.descripArtPro = (string)drArtProveedores["descripArtPro"];
                modArtProv.fechaUltimaActualizacionArtPro = (DateTime)drArtProveedores["fechaUltimaActualizacionArtPro"];
                modArtProv.razonSocialProv = (string)drArtProveedores["razonSocialProv"];
                ArtProvxCodOrg.Add(modArtProv);
            }
            drArtProveedores.Close();

            comando.Connection.Close();

            return ArtProvxCodOrg;

        }

        private List<ModeloArticuloProveedores> buscarPorCodigoArticuloProveedor(string pCodigoArticuloProveedor)
        {
            List<ModeloArticuloProveedores> articulosProveedores = new List<ModeloArticuloProveedores>();
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText = "SELECT [codigoOriginalArt],[codigoArtProveedor],[stockMinimoArtPro],[stockActualArtPro],[obsArtPro],[descripArtPro],[fechaUltimaActualizacionArtPro],[razonSocialProv]FROM [art_prov] WHERE codigoArtProveedor = @codArticuloProveedor";

            comando.Parameters.Add(new SqlParameter("@codArticuloProveedor", SqlDbType.NVarChar));
            comando.Parameters["@codArticuloProveedor"].Value = pCodigoArticuloProveedor;

            comando.Connection.Open();

            SqlDataReader drArtProveedores = comando.ExecuteReader();
            while (drArtProveedores.Read())
            {
                ModeloArticuloProveedores modArtProv = new ModeloArticuloProveedores();
                modArtProv.codigoOriginalArt = (string)drArtProveedores["codigoOriginalArt"];
                modArtProv.codigoArtProveedor = (string)drArtProveedores["codigoArtProveedor"];
                modArtProv.stockMinimoArtPro = (int)drArtProveedores["stockMinimoArtPro"];
                modArtProv.stockActualArtPro = (int)drArtProveedores["stockActualArtPro"];
                modArtProv.obsArtPro = (string)drArtProveedores["obsArtPro"];
                modArtProv.descripArtPro = (string)drArtProveedores["descripArtPro"];
                modArtProv.fechaUltimaActualizacionArtPro = (DateTime)drArtProveedores["fechaUltimaActualizacionArtPro"];
                modArtProv.razonSocialProv = (string)drArtProveedores["razonSocialProv"];
                articulosProveedores.Add(modArtProv);
            }
           
            drArtProveedores.Close();
            comando.Connection.Close();

            return articulosProveedores;
        }

        public List<ModeloArticuloProveedores> getAll()
        {
            List<ModeloArticuloProveedores> allArtProvs = new List<ModeloArticuloProveedores>();
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText = "SELECT [codigoOriginalArt],[codigoArtProveedor],[stockMinimoArtPro],[stockActualArtPro],[obsArtPro],[descripArtPro],[fechaUltimaActualizacionArtPro],[razonSocialProv]FROM [art_prov]";

            comando.Connection.Open();

            SqlDataReader drArtProveedores = comando.ExecuteReader();
            while (drArtProveedores.Read())
            {
                ModeloArticuloProveedores modArtProv = new ModeloArticuloProveedores();
                modArtProv.codigoOriginalArt = (string)drArtProveedores["codigoOriginalArt"];
                modArtProv.codigoArtProveedor = (string)drArtProveedores["codigoArtProveedor"];
                modArtProv.stockMinimoArtPro = (int)drArtProveedores["stockMinimoArtPro"];
                modArtProv.stockActualArtPro = (int)drArtProveedores["stockActualArtPro"];
                modArtProv.obsArtPro = (string)drArtProveedores["obsArtPro"];
                modArtProv.descripArtPro = (string)drArtProveedores["descripArtPro"];
                modArtProv.fechaUltimaActualizacionArtPro = (DateTime)drArtProveedores["fechaUltimaActualizacionArtPro"];
                modArtProv.razonSocialProv = (string)drArtProveedores["razonSocialProv"];
                allArtProvs.Add(modArtProv);
            }
            drArtProveedores.Close();

            comando.Connection.Close();

            return allArtProvs;
        }

        public void agregarNuevaEntidad(ModeloArticuloProveedores pModArtProv)
        { 
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();
            
            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType= CommandType.Text;

            comando.CommandText = "INSERT INTO [art_prov]([codigoOriginalArt],[codigoArtProveedor],[stockMinimoArtPro],[stockActualArtPro],[obsArtPro],[descripArtPro],[fechaUltimaActualizacionArtPro],[razonSocialProv])VALUES (@codigoOriginalArt, @codigoArtProveedor, @stockMinimoArtPro, @stockActualArtPro, @obsArtPro, @descripArtPro, @fechaUltimaActualizacionArtPro,@razonSocialProv)";
            //Indica los parametros
            comando.Parameters.Add(new SqlParameter("@codigoOriginalArt", SqlDbType.NVarChar));
            comando.Parameters["@codigoOriginalArt"].Value = pModArtProv.codigoOriginalArt;
            comando.Parameters.Add(new SqlParameter("@codigoArtProveedor", SqlDbType.NVarChar));
            comando.Parameters["@codigoArtProveedor"].Value = pModArtProv.codigoArtProveedor;
            comando.Parameters.Add(new SqlParameter("@stockMinimoArtPro", SqlDbType.Int));
            comando.Parameters["@stockMinimoArtPro"].Value = pModArtProv.stockMinimoArtPro;
            comando.Parameters.Add(new SqlParameter("@stockActualArtPro", SqlDbType.NVarChar));
            comando.Parameters["@stockActualArtPro"].Value = pModArtProv.stockActualArtPro;
            comando.Parameters.Add(new SqlParameter("@obsArtPro", SqlDbType.NVarChar));
            comando.Parameters["@obsArtPro"].Value = pModArtProv.obsArtPro;
            comando.Parameters.Add(new SqlParameter("@descripArtPro", SqlDbType.NVarChar));
            comando.Parameters["@descripArtPro"].Value = pModArtProv.descripArtPro;
            comando.Parameters.Add(new SqlParameter("@fechaUltimaActualizacionArtPro", SqlDbType.DateTime));
            comando.Parameters["@fechaUltimaActualizacionArtPro"].Value = pModArtProv.fechaUltimaActualizacionArtPro;
            comando.Parameters.Add(new SqlParameter("@razonSocialProv", SqlDbType.NVarChar));
            comando.Parameters["@razonSocialProv"].Value = pModArtProv.razonSocialProv;

            comando.Connection.Open();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        //Insertar un nuevo Articulo
        }
        
        public string actualizarArticuloProveedor(ModeloArticuloProveedores modArtProv, string[] pModificar)//el parametro pModificar solo contiene el codigoOriginalArt[0] y codigoArtProveedor[1] si es que fueron cambiados.
        {
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Datos.Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText = "UPDATE [art_prov] SET [codigoOriginalArt]=@codigoOriginalArtNew,[codigoArtProveedor]=@codigoArtProveedorNew,[stockMinimoArtPro]=@stockMinimoArtPro,[stockActualArtPro]=@stockActualArtPro,[obsArtPro]=@obsArtPro,[descripArtPro]=@descripArtPro,[fechaUltimaActualizacionArtPro]=@fechaUltimaActualizacionArtPro,[razonSocialProv]=@razonSocialProv WHERE ([art_prov].codigoOriginalArt=@codigoOriginalArtAnt AND [art_prov].codigoArtProveedor=@codigoArtProveedorAnt)";

            comando.Parameters.Add(new SqlParameter("@codigoOriginalAnt", SqlDbType.NVarChar));
            comando.Parameters["@codigoOriginalAnt"].Value = modArtProv.codigoOriginalArt;

            comando.Parameters.Add(new SqlParameter("@codigoOriginalNew", SqlDbType.NVarChar));
            comando.Parameters["@codigoOriginalAnt"].Value = pModificar[0];

            comando.Parameters.Add(new SqlParameter("@codigoArtProveedorAnt", SqlDbType.NVarChar));
            comando.Parameters["@codigoArtProveedorAnt"].Value = modArtProv.codigoArtProveedor;

            comando.Parameters.Add(new SqlParameter("@codigoArtProveedorNew", SqlDbType.NVarChar));
            comando.Parameters["@codigoArtProveedorNew"].Value = pModificar[1];

            comando.Parameters.Add(new SqlParameter("@stockMinimoArtPro", SqlDbType.Int));
            comando.Parameters["@stockMinimoArtPro"].Value = modArtProv.stockMinimoArtPro;

            comando.Parameters.Add(new SqlParameter("@stockActualArtPro", SqlDbType.Int));
            comando.Parameters["@stockActualArtPro"].Value = modArtProv.stockActualArtPro;

            comando.Parameters.Add(new SqlParameter("@obsArtPro", SqlDbType.NVarChar));
            comando.Parameters["@obsArtPro"].Value = modArtProv.obsArtPro;

            comando.Parameters.Add(new SqlParameter("@descripArtPro", SqlDbType.NVarChar));
            comando.Parameters["@descripArtPro"].Value = modArtProv.descripArtPro;

            comando.Parameters.Add(new SqlParameter("@fechaUltimaActualizacionArtPro", SqlDbType.DateTime));
            comando.Parameters["@fechaUltimaActualizacionArtPro"].Value = modArtProv.fechaUltimaActualizacionArtPro;

            comando.Parameters.Add(new SqlParameter("@razonSocialProv", SqlDbType.NVarChar));
            comando.Parameters["@razonSocialProv"].Value = modArtProv.razonSocialProv;


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

        public string bajaArticuloProveedor(string pCodigoArtProv)
        { 
         
            SqlConnection ConexionSQL = Datos.Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText = "DELETE FROM [art_prov] WHERE ([art_prov].codigoArtProveedor=@codigoArtProveedor)";

            comando.Parameters.Add(new SqlParameter("@codigoArtProveedor", SqlDbType.NVarChar));
            comando.Parameters["@codigoArtProveedor"].Value = pCodigoArtProv;

            comando.Connection.Open();
            int rowaffected = comando.ExecuteNonQuery();
            comando.Connection.Close();

            if (rowaffected == 0)
            {
                return "Operacion Cancelada";
            }
            else
            {
                return "Articulo de Proveedor dado de baja";
            }


        } 
    }

}
