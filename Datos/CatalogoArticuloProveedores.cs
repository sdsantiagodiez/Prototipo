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

        private ModeloArticuloProveedores leerDatosArticuloProveedorConPrecio(SqlDataReader drArticulosProveedor)
        {
            ModeloArticuloProveedores modArt = new ModeloArticuloProveedores();

            var modValArtC = new ModeloValorArticulo();
            modValArtC.fechaUltimaActualizacion = (DateTime)drArticulosProveedor["fechaValorCompra"];
            modValArtC.valorArticulo = (decimal)drArticulosProveedor["valorCompra"];
            modArt.valorCompraArticuloProveedor = modValArtC;

            var modValArtV = new ModeloValorArticulo();
            modValArtV.fechaUltimaActualizacion = (DateTime)drArticulosProveedor["fechaValorVenta"];
            modValArtV.valorArticulo = (decimal)drArticulosProveedor["valorVenta"];
            modArt.valorVenta = modValArtV;

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

        private ModeloArticuloProveedores leerDatosArticuloProveedorSinPrecio(SqlDataReader drArticulosProveedor)
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
                "SELECT "+
	            "    ap.[codigoOriginal],ap.[codigoArticuloProveedor],ap.[stockMinimo],ap.[stockActual],ap.[observaciones], "+
                "    ap.[descripcion],ap.[fechaActualizacion],ap.[razonSocialProveedor],vv.[valor] AS [valorVenta], vv.[fechaValor] AS [fechaValorVenta], "+
                "    vc.[valor] AS [valorCompra], vc.[fechaValor] AS [fechaValorCompra] "+
                "    FROM [Articulos_Proveedores] ap "+
	            "   INNER JOIN "+
                "    ( "+
                "    SELECT valC.codigoArticuloProveedor, valC.codigoOriginal, valC.fechaValor, valC.valor " +
	            "        FROM "+
	            "        ( "+
		        "            SELECT "+
			    "                vc1.codigoArticuloProveedor, vc1.codigoOriginal, vc1.fechaValor, vc1.valor,  "+
			    "                row_number() over(partition by vc1.codigoArticuloProveedor, vc1.codigoOriginal order by vc1.fechaValor desc) rn "+
			    "                FROM [Valores_Compra] vc1  "+
	            "        ) valC "+
		        "            WHERE valC.rn = 1 "+
                "       ) vc  "+
	            "    ON (ap.[codigoOriginal] = vc.[codigoOriginal] AND ap.[codigoArticuloProveedor] = vc.[codigoArticuloProveedor]) "+
                "    INNER JOIN "+
                "    (  "+
                "    SELECT valV.codigoArticuloProveedor, valV.codigoOriginal, valV.fechaValor, valV.valor  " +
	            "        FROM "+
	            "        ( "+
		        "            SELECT  "+
			    "                vv1.codigoArticuloProveedor, vv1.codigoOriginal, vv1.fechaValor, vv1.valor, "+
			    "                row_number() over(partition by vv1.codigoArticuloProveedor, vv1.codigoOriginal order by vv1.fechaValor desc) rn "+
			    "                FROM [Valores_Venta] vv1  "+
	            "        ) valV "+
		        "            WHERE valV.rn = 1 "+
                "        ) vv "+
	            "    ON (ap.[codigoOriginal] = vv.[codigoOriginal] AND ap.[codigoArticuloProveedor] = vv.[codigoArticuloProveedor]) "+
                "    WHERE ap.descripcion LIKE CONCAT('%',@descripcion,'%') "; 

            comando.Parameters.Add(instanciarParametro(pDescripcion, "@descripcion"));

            comando.Connection.Open();

            SqlDataReader drArtProveedores = comando.ExecuteReader();
            while (drArtProveedores.Read())
            {
                ModeloArticuloProveedores modArtProv = new ModeloArticuloProveedores();
                modArtProv = this.leerDatosArticuloProveedorConPrecio(drArtProveedores);
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
                "SELECT ap.[codigoOriginal],ap.[codigoArticuloProveedor],ap.[stockMinimo],ap.[stockActual],ap.[observaciones], " +
                "ap.[descripcion],ap.[fechaActualizacion],ap.[razonSocialProveedor],vv.[valor] AS [valorVenta], vv.[fechaValor] AS [fechaValorVenta], " +
                "vc.[valor] AS [valorCompra], vc.[fechaValor] AS [fechaValorCompra] " +
                "FROM [Articulos_Proveedores] ap " +
                "JOIN " +
                "( " +
                "SELECT vc1.codigoArticuloProveedor, vc1.codigoOriginal, vc1.fechaValor, vc1.valor " +
                "FROM [Valores_Compra] vc1 " +
                "INNER JOIN " +
                "(SELECT [codigoArticuloProveedor],[codigoOriginal], MAX([fechaValor]) [fechaValor] " +
                "FROM [Valores_Compra] " +
                "GROUP BY [codigoOriginal],[codigoArticuloProveedor]) vc2 ON vc1.codigoOriginal=vc2.codigoOriginal " +
                "AND vc1.codigoArticuloProveedor= vc2.codigoArticuloProveedor AND vc1.fechaValor = vc2.fechaValor " +
                ") vc ON ap.[codigoOriginal] = vc.[codigoOriginal] AND ap.[codigoArticuloProveedor] = vc.[codigoArticuloProveedor] " +
                "JOIN " +
                "( " +
                "SELECT vv1.codigoArticuloProveedor, vv1.codigoOriginal, vv1.fechaValor, vv1.valor FROM [Valores_Venta] vv1 " +
                "INNER JOIN " +
                "(SELECT [codigoArticuloProveedor],[codigoOriginal], MAX([fechaValor]) [fechaValor] " +
                "FROM [Valores_Venta] " +
                "GROUP BY [codigoOriginal],[codigoArticuloProveedor]) vv2 ON vv1.codigoOriginal=vv2.codigoOriginal " +
                "AND vv1.codigoArticuloProveedor= vv2.codigoArticuloProveedor AND vv1.fechaValor = vv2.fechaValor " +
                ") vv ON ap.[codigoOriginal] = vv.[codigoOriginal] AND ap.[codigoArticuloProveedor] = vv.[codigoArticuloProveedor] " +
                "WHERE ap.codigoOriginal LIKE @codigoOriginal";

            comando.Parameters.Add(instanciarParametro(pCodigoOriginal, "@codigoOriginal"));

            comando.Connection.Open();

            SqlDataReader drArtProveedores = comando.ExecuteReader();
            while (drArtProveedores.Read())
            {
                ModeloArticuloProveedores modArtProv = new ModeloArticuloProveedores();
                modArtProv = this.leerDatosArticuloProveedorConPrecio(drArtProveedores);
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
                "SELECT ap.[codigoOriginal],ap.[codigoArticuloProveedor],ap.[stockMinimo],ap.[stockActual],ap.[observaciones], " +
                "ap.[descripcion],ap.[fechaActualizacion],ap.[razonSocialProveedor],vv.[valor] AS [valorVenta], vv.[fechaValor] AS [fechaValorVenta], " +
                "vc.[valor] AS [valorCompra], vc.[fechaValor] AS [fechaValorCompra] " +
                "FROM [Articulos_Proveedores] ap " +
                "JOIN " +
                "( " +
                "SELECT vc1.codigoArticuloProveedor, vc1.codigoOriginal, vc1.fechaValor, vc1.valor " +
                "FROM [Valores_Compra] vc1 " +
                "INNER JOIN " +
                "(SELECT [codigoArticuloProveedor],[codigoOriginal], MAX([fechaValor]) [fechaValor] " +
                "FROM [Valores_Compra] " +
                "GROUP BY [codigoOriginal],[codigoArticuloProveedor]) vc2 ON vc1.codigoOriginal=vc2.codigoOriginal " +
                "AND vc1.codigoArticuloProveedor= vc2.codigoArticuloProveedor AND vc1.fechaValor = vc2.fechaValor " +
                ") vc ON ap.[codigoOriginal] = vc.[codigoOriginal] AND ap.[codigoArticuloProveedor] = vc.[codigoArticuloProveedor] " +
                "JOIN " +
                "( " +
                "SELECT vv1.codigoArticuloProveedor, vv1.codigoOriginal, vv1.fechaValor, vv1.valor FROM [Valores_Venta] vv1 " +
                "INNER JOIN " +
                "(SELECT [codigoArticuloProveedor],[codigoOriginal], MAX([fechaValor]) [fechaValor] " +
                "FROM [Valores_Venta] " +
                "GROUP BY [codigoOriginal],[codigoArticuloProveedor]) vv2 ON vv1.codigoOriginal=vv2.codigoOriginal " +
                "AND vv1.codigoArticuloProveedor= vv2.codigoArticuloProveedor AND vv1.fechaValor = vv2.fechaValor " +
                ") vv ON ap.[codigoOriginal] = vv.[codigoOriginal] AND ap.[codigoArticuloProveedor] = vv.[codigoArticuloProveedor] " +
                "WHERE ap.codigoArticuloProveedor LIKE @codigoArticuloProveedor";

            comando.Parameters.Add(instanciarParametro(pCodigoArticuloProveedor, "@codigoArticuloProveedor"));

            comando.Connection.Open();

            SqlDataReader drArtProveedores = comando.ExecuteReader();
            while (drArtProveedores.Read())
            {
                ModeloArticuloProveedores modArtProv = new ModeloArticuloProveedores();
                modArtProv = this.leerDatosArticuloProveedorConPrecio(drArtProveedores);
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
                modArtProv = this.leerDatosArticuloProveedorSinPrecio(drArtProveedores);
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
                modArtProv = this.leerDatosArticuloProveedorSinPrecio(drArtProveedores);
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
