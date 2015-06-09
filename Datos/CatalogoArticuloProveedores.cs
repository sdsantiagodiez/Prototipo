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
    public class CatalogoArticuloProveedores : Catalogo
    {
        public bool validarDatos(ModeloArticuloProveedores articuloProveedor)
        {
            // Validar si los datos son correctos?
            return true;
        }

        /// <summary>
        /// Determina existencia de articuloProveedor de acuerdo a codigoArticuloProveedor ingresado
        /// </summary>
        /// <param name="codigoArticuloProveedor">código articulo proveedor de artículo proveedor</param>
        /// <returns>true si existe, false si no existe</returns>
        public bool existeEntidad(ModeloArticuloProveedores artProveedor)
        {
            bool respuesta = false;
            if(getOne(artProveedor.codigoOriginal, artProveedor.codigoArticuloProveedor) != null)
            {
                respuesta = true;
            }
            return respuesta;
        }

        private ModeloArticuloProveedores leerDatosArticuloProveedor(SqlDataReader drArticulosProveedor)
        {
            ModeloArticuloProveedores modArt = new ModeloArticuloProveedores();

            modArt.codigoOriginal = (string)drArticulosProveedor["codigoOriginal"];
            modArt.codigoArticuloProveedor = (string)drArticulosProveedor["codigoArticuloProveedor"];
            modArt.razonSocialProveedor = (string)drArticulosProveedor["razonSocialProveedor"];
            //Si algún valor esta null en Base de datos, se asigna null en el objeto
            //Caso contrario hay una string, y se asigna string
            modArt.descripcion = (drArticulosProveedor["descripcion"] != DBNull.Value) ? (string)drArticulosProveedor["descripcion"] : null;
            modArt.observaciones = (drArticulosProveedor["observaciones"] != DBNull.Value) ? (string)drArticulosProveedor["observaciones"] : null;
            modArt.stockActual = (drArticulosProveedor["stockActual"] != DBNull.Value) ? (int)drArticulosProveedor["stockActual"] : (int?)null;
            modArt.stockMinimo = (drArticulosProveedor["stockMinimo"] != DBNull.Value) ? (int)drArticulosProveedor["stockMinimo"] : (int?)null;
            modArt.fechaActualizacion = (drArticulosProveedor["fechaActualizacion"] != DBNull.Value) ? (DateTime)drArticulosProveedor["fechaActualizacion"] : (DateTime?)null;
            
            return modArt;
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

        private List<ModeloArticuloProveedores> buscarPorDescripcion(string pDescripcion)
        {
            List<ModeloArticuloProveedores> articulosProveedores = new List<ModeloArticuloProveedores>();
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText =
                "SELECT [codigoOriginal],[codigoArticuloProveedor],[stockMinimo],[stockActual],[observaciones],[descripcion]," +
                "[fechaActualizacion],[razonSocialProveedor] FROM [Articulos_Proveedores] " +
                 "WHERE descripcion LIKE @descripcion";

            comando.Parameters.Add(instanciarParametro(pDescripcion, "@descripcion"));

            comando.Connection.Open();

            SqlDataReader drArtProveedores = comando.ExecuteReader();
            while (drArtProveedores.Read())
            {
                ModeloArticuloProveedores modArtProv = new ModeloArticuloProveedores();
                modArtProv = this.leerDatosArticuloProveedor(drArtProveedores);
                articulosProveedores.Add(modArtProv);
            }
            drArtProveedores.Close();

            comando.Connection.Close();

            return articulosProveedores;
        }

        private List<ModeloArticuloProveedores> buscarPorCodigoOriginal(string pCodigoOriginal)
        {
            List<ModeloArticuloProveedores> articulosProveedores = new List<ModeloArticuloProveedores>();
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText =
                "SELECT [codigoOriginal],[codigoArticuloProveedor],[stockMinimo],[stockActual],[observaciones],[descripcion]," +
                "[fechaActualizacion],[razonSocialProveedor] FROM [Articulos_Proveedores] " +
                 "WHERE codigoOriginal LIKE @codigoOriginal";

            comando.Parameters.Add(instanciarParametro(pCodigoOriginal, "@codigoOriginal"));

            comando.Connection.Open();

            SqlDataReader drArtProveedores = comando.ExecuteReader();
            while (drArtProveedores.Read())
            {
                ModeloArticuloProveedores modArtProv = new ModeloArticuloProveedores();
                modArtProv = this.leerDatosArticuloProveedor(drArtProveedores);
                articulosProveedores.Add(modArtProv);
            }
            drArtProveedores.Close();

            comando.Connection.Close();

            return articulosProveedores;

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

            comando.CommandText = 
                "SELECT [codigoOriginal],[codigoArticuloProveedor],[stockMinimo],[stockActual],[observaciones],[descripcion],"+
                "[fechaActualizacion],[razonSocialProveedor] FROM [Articulos_Proveedores] "+
                 "WHERE codigoArticuloProveedor LIKE @codigoArticuloProveedor";

            comando.Parameters.Add(instanciarParametro(pCodigoArticuloProveedor, "@codigoArticuloProveedor"));

            comando.Connection.Open();

            SqlDataReader drArtProveedores = comando.ExecuteReader();
            while (drArtProveedores.Read())
            {
                ModeloArticuloProveedores modArtProv = new ModeloArticuloProveedores();
                modArtProv = this.leerDatosArticuloProveedor(drArtProveedores);
                articulosProveedores.Add(modArtProv);
            }
           
            drArtProveedores.Close();
            comando.Connection.Close();

            return articulosProveedores;
        }

        public ModeloArticuloProveedores getOne(string pCodigoOriginal, string pCodigoArticuloProveedor)
        {
            ModeloArticuloProveedores modArtProv = null;
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();
            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText =
                "SELECT [codigoOriginal],[codigoArticuloProveedor],[stockMinimo],[stockActual],[observaciones]," +
                "[descripcion],[fechaActualizacion],[razonSocialProveedor] FROM [Articulos_Proveedores] " +
                "WHERE codigoOriginal = @codigoOriginal AND codigoArticuloProveedor=@codigoArticuloProveedor";

            comando.Parameters.Add(instanciarParametro(pCodigoOriginal, "@codigoOriginal"));
            comando.Parameters.Add(instanciarParametro(pCodigoArticuloProveedor, "@codigoArticuloProveedor"));   
            comando.Connection.Open();

            SqlDataReader drArtProveedores = comando.ExecuteReader();

            while (drArtProveedores.Read())
            {
                modArtProv = new ModeloArticuloProveedores();
                modArtProv = this.leerDatosArticuloProveedor(drArtProveedores);
            }
            drArtProveedores.Close();
            comando.Connection.Close();

            return modArtProv;
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

            comando.CommandText = 
                "SELECT [codigoOriginal],[codigoArticuloProveedor],[stockMinimo],[stockActual],[observaciones],"+
                "[descripcion],[fechaActualizacion],[razonSocialProveedor] FROM [Articulos_Proveedores]";

            comando.Connection.Open();

            SqlDataReader drArtProveedores = comando.ExecuteReader();
            while (drArtProveedores.Read())
            {
                ModeloArticuloProveedores modArtProv = new ModeloArticuloProveedores();
                modArtProv = this.leerDatosArticuloProveedor(drArtProveedores);
                allArtProvs.Add(modArtProv);
            }
            drArtProveedores.Close();

            comando.Connection.Close();

            return allArtProvs;
        }

        #region Alta/Baja/Modificación
        /*
         * True si se realizó correctamente
         * False si ocurrió algún error
         */
        public bool agregarNuevaEntidad(ModeloArticuloProveedores pModArtProv)
        { 
            if(!this.existeEntidad(pModArtProv))
            {
                SqlConnection ConexionSQL = Conexion.crearConexion();
                SqlCommand comando = new SqlCommand();

                comando.Connection = ConexionSQL;
                comando.CommandType= CommandType.Text;
                comando.CommandText = 
                    "INSERT INTO [Articulos_Proveedores]([codigoOriginal],[codigoArticuloProveedor],[stockMinimo],[stockActual],"+
                    "[observaciones],[descripcion],[fechaActualizacion],[razonSocialProveedor]) "+
                    "VALUES (@codigoOriginal, @codigoArticuloProveedor, @stockMinimo, @stockActual, @observaciones, "+
                    "@descripcion, @fechaActualizacion,@razonSocialProveedor)";
                //Indica los parametros
                comando.Parameters.Add(this.instanciarParametro(pModArtProv.codigoArticuloProveedor,"@codigoArticuloProveedor"));
                comando.Parameters.Add(this.instanciarParametro(pModArtProv.codigoOriginal, "@codigoOriginal"));
                comando.Parameters.Add(this.instanciarParametro(pModArtProv.descripcion, "@descripcion"));
                comando.Parameters.Add(this.instanciarParametro(pModArtProv.observaciones, "@observaciones"));
                comando.Parameters.Add(this.instanciarParametro(pModArtProv.razonSocialProveedor, "@razonSocialProveedor"));
                comando.Parameters.Add(this.instanciarParametro(pModArtProv.stockMinimo, "@stockMinimo"));
                comando.Parameters.Add(this.instanciarParametro(pModArtProv.stockActual, "@stockActual"));
                comando.Parameters.Add(this.instanciarParametro(pModArtProv.fechaActualizacion, "@fechaActualizacion"));

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
        
        public bool actualizarEntidad(ModeloArticuloProveedores pModArtProv)
        {
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Datos.Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText = 
                "UPDATE [Articulos_Proveedores] SET [stockMinimo]=@stockMinimo,[stockActual]=@stockActual,[observaciones]=@observaciones,"+
                "[descripcion]=@descripcion,[fechaActualizacion]=@fechaActualizacion,[razonSocialProveedor]=@razonSocialProveedor "+
                "WHERE ([Articulos_Proveedores].codigoOriginal=@codigoOriginal AND [Articulos_Proveedores].codigoArticuloProveedor=@codigoArticuloProveedor)";

            comando.Parameters.Add(this.instanciarParametro(pModArtProv.codigoArticuloProveedor, "@codigoArticuloProveedor"));
            comando.Parameters.Add(this.instanciarParametro(pModArtProv.codigoOriginal, "@codigoOriginal"));
            comando.Parameters.Add(this.instanciarParametro(pModArtProv.descripcion, "@descripcion"));
            comando.Parameters.Add(this.instanciarParametro(pModArtProv.observaciones, "@observaciones"));
            comando.Parameters.Add(this.instanciarParametro(pModArtProv.razonSocialProveedor, "@razonSocialProveedor"));
            comando.Parameters.Add(this.instanciarParametro(pModArtProv.stockMinimo, "@stockMinimo"));
            comando.Parameters.Add(this.instanciarParametro(pModArtProv.stockActual, "@stockActual"));
            comando.Parameters.Add(this.instanciarParametro(pModArtProv.fechaActualizacion, "@fechaActualizacion"));

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

        public bool bajaEntidad(ModeloArticuloProveedores pModArtProv)
        { 
         
            SqlConnection ConexionSQL = Datos.Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText = 
                "DELETE FROM [Articulos_Proveedores] WHERE ([Articulos_Proveedores].codigoArticuloProveedor=@codigoArticuloProveedor "+
                "AND [Articulos_Proveedores].codigoOriginal=@codigoOriginal )";

            comando.Parameters.Add(this.instanciarParametro(pModArtProv.codigoArticuloProveedor, "@codigoArticuloProveedor"));
            comando.Parameters.Add(this.instanciarParametro(pModArtProv.codigoOriginal, "@codigoOriginal"));

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
    }

}
