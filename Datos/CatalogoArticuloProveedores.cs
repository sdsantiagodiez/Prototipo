using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
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

        public bool existeEntidad(string codArticuloProveedor)
        {
            // Se crea la variable a retornar
            bool respuesta = false;
            //Creamos la lista de todos los Articulos
            List<ModeloArticuloProveedores> listArtProv = this.getAll();
            
            foreach (ModeloArticuloProveedores modArtProv in listArtProv)
            {
                if (codArticuloProveedor== modArtProv.codigoArProveedor)// Se busca si el articulo ya existe comparando el codigo original
                {
                    respuesta = true;
                    break;
                }
                else { respuesta = false; }

            }

            return respuesta;
        }

        public List<ModeloArticuloProveedores> getAll()
        { 
            List<ModeloArticuloProveedores>allArtProvs = new List<ModeloArticuloProveedores>();
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();
            
            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType= CommandType.Text;

            comando.CommandText = "SELECT [codigoOriginalArt],[codigoArProveedor],[stockMinimoArPro],[stockActualArPro],[obsArPro],[descripArPro],[fechaUltimaActualizacionArPro],[razonSocialProv]FROM [proyecto].[dbo].[art_prov]";

            comando.Connection.Open();

            SqlDataReader drArtProveedores = comando.ExecuteReader();
            while (drArtProveedores.Read())
            {
                ModeloArticuloProveedores modArtProv = new ModeloArticuloProveedores();
                modArtProv.codigoOriginalArt = (string)drArtProveedores["codigoOriginalArt"];
                modArtProv.codigoArProveedor = (string)drArtProveedores["codigoArProveedor"];
                modArtProv.stockMinimoArPro = (int)drArtProveedores["stockMinimoArPro"];
                modArtProv.stockActualArPro= (int)drArtProveedores["stockActualArPro"];
                modArtProv.obsArPro= (string)drArtProveedores["obsArPro"];
                modArtProv.descripArPro = (string)drArtProveedores["descripArPro"];
                modArtProv.fechaUltimaActualizacionArPro = (DateTime)drArtProveedores["fechaUltimaActualizacionArPro"];
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

            comando.CommandText = "INSERT INTO [proyecto].[dbo].[art_prov]([codigoOriginalArt],[codigoArProveedor],[stockMinimoArPro],[stockActualArPro],[obsArPro],[descripArPro],[fechaUltimaActualizacionArPro],[razonSocialProv])VALUES (@codigoOriginalArt, @codigoArProveedor, @stockMinimoArPro, @stockActualArPro, @obsArPro, @descripArPro, @fechaUltimaActualizacionArPro,@razonSocialProv)";
            //Indica los parametros
            comando.Parameters.Add(new SqlParameter("@codigoOriginalArt", SqlDbType.NVarChar));
            comando.Parameters["@codigoOriginalArt"].Value = pModArtProv.codigoOriginalArt;
            comando.Parameters.Add(new SqlParameter("@codigoArProveedor", SqlDbType.NVarChar));
            comando.Parameters["@codigoArProveedor"].Value = pModArtProv.codigoArProveedor;
            comando.Parameters.Add(new SqlParameter("@stockMinimoArPro", SqlDbType.Int));
            comando.Parameters["@stockMinimoArPro"].Value = pModArtProv.stockMinimoArPro;
            comando.Parameters.Add(new SqlParameter("@stockActualArPro", SqlDbType.NVarChar));
            comando.Parameters["@stockActualArPro"].Value = pModArtProv.stockActualArPro;
            comando.Parameters.Add(new SqlParameter("@obsArPro", SqlDbType.NVarChar));
            comando.Parameters["@obsArPro"].Value = pModArtProv.obsArPro;
            comando.Parameters.Add(new SqlParameter("@descripArPro", SqlDbType.NVarChar));
            comando.Parameters["@descripArPro"].Value = pModArtProv.descripArPro;
            comando.Parameters.Add(new SqlParameter("@fechaUltimaActualizacionArPro", SqlDbType.DateTime));
            comando.Parameters["@fechaUltimaActualizacionArPro"].Value = pModArtProv.fechaUltimaActualizacionArPro;
            comando.Parameters.Add(new SqlParameter("@razonSocialProv", SqlDbType.NVarChar));
            comando.Parameters["@razonSocialProv"].Value = pModArtProv.razonSocialProv;

            comando.Connection.Open();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        //Insertar un nuevo Articulo
        }

        public ModeloArticuloProveedores getOne(string pCodArtPro, string pCodOrigArt)
        { 
                   
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();
            
            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType= CommandType.Text;

            comando.CommandText = "SELECT [codigoOriginalArt],[codigoArProveedor],[stockMinimoArPro],[stockActualArPro],[obsArPro],[descripArPro],[fechaUltimaActualizacionArPro],[razonSocialProv] FROM [proyecto].[dbo].[art_prov] WHERE (codigoOriginalArt = @CodigoOrgArt AND codigoArProveedor=@codigoArPro";
            
            comando.Parameters.Add( new SqlParameter("@CodigoOrgArt", SqlDbType.NVarChar));
            comando.Parameters["@CodigoOrgArt"].Value = pCodOrigArt;

            comando.Parameters.Add( new SqlParameter("@codigoArPro", SqlDbType.NVarChar));
            comando.Parameters["@CodigoArPro"].Value = pCodArtPro;

            comando.Connection.Open();

            SqlDataReader drArtProveedores = comando.ExecuteReader();
            
            ModeloArticuloProveedores modArtProv = new ModeloArticuloProveedores();
            
            while (drArtProveedores.Read())
            {
                
                
                modArtProv.codigoOriginalArt = (string)drArtProveedores["codigoOriginalArt"];
                modArtProv.codigoArProveedor = (string)drArtProveedores["codigoArProveedor"];
                modArtProv.stockMinimoArPro = (int)drArtProveedores["stockMinimoArPro"];
                modArtProv.stockActualArPro= (int)drArtProveedores["stockActualArPro"];
                modArtProv.obsArPro= (string)drArtProveedores["obsArPro"];
                modArtProv.descripArPro = (string)drArtProveedores["descripArPro"];
                modArtProv.fechaUltimaActualizacionArPro = (DateTime)drArtProveedores["fechaUltimaActualizacionArPro"];
                modArtProv.razonSocialProv = (string)drArtProveedores["razonSocialProv"];
                 }
            drArtProveedores.Close();

            comando.Connection.Close();

            return modArtProv;
        }

        public List<ModeloArticuloProveedores> getxDesripcion(string pDescrip)
        {
            List<ModeloArticuloProveedores> ArtProvxDesc = new List<ModeloArticuloProveedores>();
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText = "SELECT [codigoOriginalArt],[codigoArProveedor],[stockMinimoArPro],[stockActualArPro],[obsArPro],[descripArPro],[fechaUltimaActualizacionArPro],[razonSocialProv]FROM [proyecto].[dbo].[art_prov] WHERE descripArPro like @descrip + '%'";

            comando.Parameters.Add(new SqlParameter("@descrip", SqlDbType.NVarChar));
            comando.Parameters["@descrip"].Value = pDescrip;

            comando.Connection.Open();

            SqlDataReader drArtProveedores = comando.ExecuteReader();
            while (drArtProveedores.Read())
            {
                ModeloArticuloProveedores modArtProv = new ModeloArticuloProveedores();
                modArtProv.codigoOriginalArt = (string)drArtProveedores["codigoOriginalArt"];
                modArtProv.codigoArProveedor = (string)drArtProveedores["codigoArProveedor"];
                modArtProv.stockMinimoArPro = (int)drArtProveedores["stockMinimoArPro"];
                modArtProv.stockActualArPro = (int)drArtProveedores["stockActualArPro"];
                modArtProv.obsArPro = (string)drArtProveedores["obsArPro"];
                modArtProv.descripArPro = (string)drArtProveedores["descripArPro"];
                modArtProv.fechaUltimaActualizacionArPro = (DateTime)drArtProveedores["fechaUltimaActualizacionArPro"];
                modArtProv.razonSocialProv = (string)drArtProveedores["razonSocialProv"];
                ArtProvxDesc.Add(modArtProv);
            }
            drArtProveedores.Close();

            comando.Connection.Close();

            return ArtProvxDesc;

        }

        public List<ModeloArticuloProveedores> getxCodOrig(string pCodigoOriginal)
        {
            List<ModeloArticuloProveedores> ArtProvxCodOrg = new List<ModeloArticuloProveedores>();
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText = "SELECT [codigoOriginalArt],[codigoArProveedor],[stockMinimoArPro],[stockActualArPro],[obsArPro],[descripArPro],[fechaUltimaActualizacionArPro],[razonSocialProv]FROM [proyecto].[dbo].[art_prov] WHERE codigoOriginalArt like @codOriginal + '%'";

            comando.Parameters.Add(new SqlParameter("@codOriginal", SqlDbType.NVarChar));
            comando.Parameters["@codOriginal"].Value = pCodigoOriginal;

            comando.Connection.Open();

            SqlDataReader drArtProveedores = comando.ExecuteReader();
            while (drArtProveedores.Read())
            {
                ModeloArticuloProveedores modArtProv = new ModeloArticuloProveedores();
                modArtProv.codigoOriginalArt = (string)drArtProveedores["codigoOriginalArt"];
                modArtProv.codigoArProveedor = (string)drArtProveedores["codigoArProveedor"];
                modArtProv.stockMinimoArPro = (int)drArtProveedores["stockMinimoArPro"];
                modArtProv.stockActualArPro = (int)drArtProveedores["stockActualArPro"];
                modArtProv.obsArPro = (string)drArtProveedores["obsArPro"];
                modArtProv.descripArPro = (string)drArtProveedores["descripArPro"];
                modArtProv.fechaUltimaActualizacionArPro = (DateTime)drArtProveedores["fechaUltimaActualizacionArPro"];
                modArtProv.razonSocialProv = (string)drArtProveedores["razonSocialProv"];
                ArtProvxCodOrg.Add(modArtProv);
            }
            drArtProveedores.Close();

            comando.Connection.Close();

            return ArtProvxCodOrg;

        }

        public string actualizarArticulo(ModeloArticuloProveedores modArtProv, string[] pModificar)//el parametro pModificar solo contiene el codigoOriginalArt[0] y codigoArProveedor[1] si es que fueron cambiados.
        {
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Datos.Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText = "UPDATE [proyecto].[dbo].[art_prov] SET [codigoOriginalArt]=@codigoOriginalArtNew,[codigoArProveedor]=@codigoArProveedorNew,[stockMinimoArPro]=@stockMinimoArPro,[stockActualArPro]=@stockActualArPro,[obsArPro]=@obsArPro,[descripArPro]=@descripArPro,[fechaUltimaActualizacionArPro]=@fechaUltimaActualizacionArPro,[razonSocialProv]=@razonSocialProv WHERE ([art_prov].codigoOriginalArt=@codigoOriginalArtAnt AND [art_prov].codigoArProveedor=@codigoArProveedorAnt)";

            comando.Parameters.Add(new SqlParameter("@codigoOriginalAnt", SqlDbType.NVarChar));
            comando.Parameters["@codigoOriginalAnt"].Value = modArtProv.codigoOriginalArt;

            comando.Parameters.Add(new SqlParameter("@codigoOriginalNew", SqlDbType.NVarChar));
            comando.Parameters["@codigoOriginalAnt"].Value = pModificar[0];

            comando.Parameters.Add(new SqlParameter("@codigoArProveedorAnt", SqlDbType.NVarChar));
            comando.Parameters["@codigoArProveedorAnt"].Value = modArtProv.codigoArProveedor;

            comando.Parameters.Add(new SqlParameter("@codigoArProveedorNew", SqlDbType.NVarChar));
            comando.Parameters["@codigoArProveedorNew"].Value = pModificar[1];

            comando.Parameters.Add(new SqlParameter("@stockMinimoArPro", SqlDbType.Int));
            comando.Parameters["@stockMinimoArPro"].Value = modArtProv.stockMinimoArPro;

            comando.Parameters.Add(new SqlParameter("@stockActualArPro", SqlDbType.Int));
            comando.Parameters["@stockActualArPro"].Value = modArtProv.stockActualArPro;

            comando.Parameters.Add(new SqlParameter("@obsArPro", SqlDbType.NVarChar));
            comando.Parameters["@obsArPro"].Value = modArtProv.obsArPro;

            comando.Parameters.Add(new SqlParameter("@descripArPro", SqlDbType.NVarChar));
            comando.Parameters["@descripArPro"].Value = modArtProv.descripArPro;

            comando.Parameters.Add(new SqlParameter("@fechaUltimaActualizacionArPro", SqlDbType.NVarChar));
            comando.Parameters["@fechaUltimaActualizacionArPro"].Value = modArtProv.fechaUltimaActualizacionArPro;

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
    
    }
       


    }

