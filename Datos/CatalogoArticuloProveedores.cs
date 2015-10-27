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

        /// <summary>
        /// permite inicializar substring para consulta sql donde el valor del atributo 
        /// </summary>
        /// <param name="nombreParametro">Valor que luego es comparado con una celda de la tabla de datos</param>
        /// <param name="nombreParametroTabla">nombre de la columna en tabla de datos</param>
        /// <returns></returns>
        private string parametroBusqueda(string nombreParametro, string nombreParametroTabla, string comparador)
        {
            string querySQL =
                @" (" + nombreParametro + " IS NULL OR " + nombreParametro + " " + comparador + " " + "LOWER(" + nombreParametroTabla + ") ) ";
            return querySQL;
        }

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
            modValArtC.fechaUltimaActualizacion = (DateTime)drArticulosProveedor["fecha_valor_compra"];
            modValArtC.valorArticulo = (decimal)drArticulosProveedor["valor_compra"];
            modArt.valorCompraArticuloProveedor = modValArtC;

            var modValArtV = new ModeloValorArticulo();
            modValArtV.fechaUltimaActualizacion = (DateTime)drArticulosProveedor["fecha_valor_venta"];
            modValArtV.valorArticulo = (decimal)drArticulosProveedor["valor_venta"];
            modArt.valorVenta = modValArtV;

            modArt.codigoOriginal = (string)drArticulosProveedor["codigo_original"];
            modArt.codigoArticuloProveedor = (string)drArticulosProveedor["codigo_articulo_proveedor"];
            modArt.codigoEntidad = (int)drArticulosProveedor["codigo_entidad"];
            modArt.razonSocialProveedor = (string)drArticulosProveedor["razon_social_proveedor"];
            //Si algún valor esta null en Base de datos, se asigna null en el objeto
            //Caso contrario hay una string, y se asigna string
            modArt.descripcion = (drArticulosProveedor["descripcion"] != DBNull.Value) ? (string)drArticulosProveedor["descripcion"] : null;
            modArt.observaciones = (drArticulosProveedor["observaciones"] != DBNull.Value) ? (string)drArticulosProveedor["observaciones"] : null;
            modArt.stockActual = (drArticulosProveedor["stock_actual"] != DBNull.Value) ? (int)drArticulosProveedor["stock_actual"] : (int?)null;
            modArt.stockMinimo = (drArticulosProveedor["stock_minimo"] != DBNull.Value) ? (int)drArticulosProveedor["stock_minimo"] : (int?)null;
            modArt.fechaActualizacion = (drArticulosProveedor["fecha_actualizacion"] != DBNull.Value) ? (DateTime)drArticulosProveedor["fecha_actualizacion"] : (DateTime?)null;
            modArt.ubicacion = (drArticulosProveedor["ubicacion"] != DBNull.Value) ? (string)drArticulosProveedor["ubicacion"] : null;

            return modArt;
        }

        private ModeloArticuloProveedores leerDatosArticuloProveedorSinPrecio(SqlDataReader drArticulosProveedor)
        {
            ModeloArticuloProveedores modArt = new ModeloArticuloProveedores();

            modArt.codigoOriginal = (string)drArticulosProveedor["codigo_original"];
            modArt.codigoArticuloProveedor = (string)drArticulosProveedor["codigo_articulo_proveedor"];
            modArt.codigoEntidad = (int)drArticulosProveedor["codigo_entidad"];
            modArt.razonSocialProveedor = (string)drArticulosProveedor["razon_social_proveedor"];
            //Si algún valor esta null en Base de datos, se asigna null en el objeto
            //Caso contrario hay una string, y se asigna string
            modArt.descripcion = (drArticulosProveedor["descripcion"] != DBNull.Value) ? (string)drArticulosProveedor["descripcion"] : null;
            modArt.observaciones = (drArticulosProveedor["observaciones"] != DBNull.Value) ? (string)drArticulosProveedor["observaciones"] : null;
            modArt.stockActual = (drArticulosProveedor["stock_actual"] != DBNull.Value) ? (int)drArticulosProveedor["stock_actual"] : (int?)null;
            modArt.stockMinimo = (drArticulosProveedor["stock_minimo"] != DBNull.Value) ? (int)drArticulosProveedor["stock_minimo"] : (int?)null;
            modArt.fechaActualizacion = (drArticulosProveedor["fecha_actualizacion"] != DBNull.Value) ? (DateTime)drArticulosProveedor["fecha_actualizacion"] : (DateTime?)null;
            modArt.ubicacion = (drArticulosProveedor["ubicacion"] != DBNull.Value) ? (string)drArticulosProveedor["ubicacion"] : null;

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

        public List<ModeloArticuloProveedores> buscarArticuloProveedor(ModeloArticuloProveedores pmArticuloProveedores)
        {
            List<ModeloArticuloProveedores> lmArticuloProveedores = new List<ModeloArticuloProveedores>();

            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.Parameters.Add(this.instanciarParametro(pmArticuloProveedores.codigoOriginal, "@codigo_original"));
            string codigoEntidadQuery = @" (@codigo_original IS NULL OR @codigo_original = codigo_original) ";
            comando.Parameters.Add(this.instanciarParametro(pmArticuloProveedores.codigoArticuloProveedor, "@codigo_articulo_proveedor"));
            string codigoEntidadQuery2 = @" (@codigo_articulo_proveedor IS NULL OR @codigo_articulo_proveedor = codigo_articulo_proveedor) ";
            comando.Parameters.Add(this.instanciarParametro(pmArticuloProveedores.descripcion, "@descripcion"));
            string descripcionQuery = this.parametroBusqueda("@descripcion", "descripcion", "=");
            comando.Parameters.Add(this.instanciarParametro(pmArticuloProveedores.stockMinimo, "@stock_minimo"));
            string StockMinimoQuery = this.parametroBusqueda("@stock_minimo", "stock_minimo", "=");
            comando.Parameters.Add(this.instanciarParametro(pmArticuloProveedores.stockMinimo, "@stock_actual"));
            string StockActualQuery = this.parametroBusqueda("@stock_actual", "stock_actual", "=");
            comando.Parameters.Add(this.instanciarParametro(pmArticuloProveedores.observaciones.ToLower(), "@observaciones"));
            string observacionesQuery = this.parametroBusqueda("@observaciones", "observaciones", "LIKE");
            comando.Parameters.Add(this.instanciarParametro(pmArticuloProveedores.ubicacion.ToLower(), "@ubicacion"));
            string ubicacionQuery = this.parametroBusqueda("@ubicacion", "ubicacion", "LIKE");
            comando.Parameters.Add(this.instanciarParametro(pmArticuloProveedores.fechaActualizacion.ToString(), "@fecha_actualizacion"));// Pasamos la fecha a String?
            string fechaActualizacionQuery = this.parametroBusqueda("@fecha_actualizacion", "fecha_actualizacion", "=");
            
            string querySQL = codigoEntidadQuery + " AND " + codigoEntidadQuery2 + " AND " + descripcionQuery + " AND " + observacionesQuery +
            " AND " + StockMinimoQuery + " AND " + StockActualQuery + " AND " + ubicacionQuery + " AND " + fechaActualizacionQuery;  
            comando.CommandText =
                "SELECT [codigo_original],[codigo_articulo_proveedor],[stock_minimo],[stock_actual],[observaciones],[ubicacion]," +
                "   [descripcion],[fecha_actualizacion],ap.codigo_entidad, [prov].razon_social as razon_social_proveedor  " +
                "FROM [Articulos_Proveedores] INNER JOIN [proveedores] prov " +
                "   ON [prov].codigo_entidad = [ap].codigo_entidad " +
                "WHERE " + querySQL;

            comando.Connection.Open();

            SqlDataReader drArticuloProveedores = comando.ExecuteReader();

            ModeloArticuloProveedores modArtProv = new ModeloArticuloProveedores();

            while (drArticuloProveedores.Read())
            {
                modArtProv = new ModeloArticuloProveedores();
                modArtProv = this.leerDatosArticuloProveedorSinPrecio(drArticuloProveedores);
                
                lmArticuloProveedores.Add(modArtProv);
            }
            drArticuloProveedores.Close();
            comando.Connection.Close();

            return lmArticuloProveedores;
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
	            "    ap.[codigo_original],ap.[codigo_articulo_proveedor],ap.[stock_minimo],ap.[stock_actual],ap.[observaciones],ap.[ubicacion], "+
                "    ap.[descripcion],ap.[fecha_actualizacion],ap.[codigo_entidad],vv.[valor] AS [valor_venta], vv.[fecha_valor] AS [fecha_valor_venta], "+
                "    vc.[valor] AS [valor_compra], vc.[fecha_valor] AS [fecha_valor_compra] , [prov].razon_social as razon_social_proveedor " +
                "   FROM [Articulos_Proveedores] ap " +
                "   INNER JOIN [proveedores] prov " +
                "   ON [prov].codigo_entidad = [ap].codigo_entidad " +
	            "   INNER JOIN "+
                "    ( "+
                "    SELECT valC.codigo_articulo_proveedor, valC.codigo_original, valC.fecha_valor, valC.valor " +
	            "        FROM "+
	            "        ( "+
		        "            SELECT "+
			    "                vc1.codigo_articulo_proveedor, vc1.codigo_original, vc1.fecha_valor, vc1.valor,  "+
			    "                row_number() over(partition by vc1.codigo_articulo_proveedor, vc1.codigo_original order by vc1.fecha_valor desc) rn "+
			    "                FROM [Valores_Compra] vc1  "+
	            "        ) valC "+
		        "            WHERE valC.rn = 1 "+
                "       ) vc  "+
	            "    ON (ap.[codigo_original] = vc.[codigo_original] AND ap.[codigo_articulo_proveedor] = vc.[codigo_articulo_proveedor]) "+
                "    INNER JOIN "+
                "    (  "+
                "    SELECT valV.codigo_articulo_proveedor, valV.codigo_original, valV.fecha_valor, valV.valor  " +
	            "        FROM "+
	            "        ( "+
		        "            SELECT  "+
			    "                vv1.codigo_articulo_proveedor, vv1.codigo_original, vv1.fecha_valor, vv1.valor, "+
			    "                row_number() over(partition by vv1.codigo_articulo_proveedor, vv1.codigo_original order by vv1.fecha_valor desc) rn "+
			    "                FROM [Valores_Venta] vv1  "+
	            "        ) valV "+
		        "            WHERE valV.rn = 1 "+
                "        ) vv "+
	            "    ON (ap.[codigo_original] = vv.[codigo_original] AND ap.[codigo_articulo_proveedor] = vv.[codigo_articulo_proveedor]) "+
                "    WHERE ap.descripcion LIKE '%' + @descripcion + '%'"; 

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
                "SELECT " +
                "    ap.[codigo_original],ap.[codigo_articulo_proveedor],ap.[stock_minimo],ap.[stock_actual],ap.[observaciones],ap.[ubicacion], " +
                "    ap.[descripcion],ap.[fecha_actualizacion],ap.[codigo_entidad],vv.[valor] AS [valor_venta], vv.[fecha_valor] AS [fecha_valor_venta], " +
                "    vc.[valor] AS [valor_compra], vc.[fecha_valor] AS [fecha_valor_compra], [prov].razon_social as razon_social_proveedor " +
                "   FROM [Articulos_Proveedores] ap " +
                "   INNER JOIN [proveedores] prov " +
                "   ON [prov].codigo_entidad = [ap].codigo_entidad " +
                "   INNER JOIN " +
                "    ( " +
                "    SELECT valC.codigo_articulo_proveedor, valC.codigo_original, valC.fecha_valor, valC.valor " +
                "        FROM " +
                "        ( " +
                "            SELECT " +
                "                vc1.codigo_articulo_proveedor, vc1.codigo_original, vc1.fecha_valor, vc1.valor,  " +
                "                row_number() over(partition by vc1.codigo_articulo_proveedor, vc1.codigo_original order by vc1.fecha_valor desc) rn " +
                "                FROM [Valores_Compra] vc1  " +
                "        ) valC " +
                "            WHERE valC.rn = 1 " +
                "       ) vc  " +
                "    ON (ap.[codigo_original] = vc.[codigo_original] AND ap.[codigo_articulo_proveedor] = vc.[codigo_articulo_proveedor]) " +
                "    INNER JOIN " +
                "    (  " +
                "    SELECT valV.codigo_articulo_proveedor, valV.codigo_original, valV.fecha_valor, valV.valor  " +
                "        FROM " +
                "        ( " +
                "            SELECT  " +
                "                vv1.codigo_articulo_proveedor, vv1.codigo_original, vv1.fecha_valor, vv1.valor, " +
                "                row_number() over(partition by vv1.codigo_articulo_proveedor, vv1.codigo_original order by vv1.fecha_valor desc) rn " +
                "                FROM [Valores_Venta] vv1  " +
                "        ) valV " +
                "            WHERE valV.rn = 1 " +
                "        ) vv " +
                "    ON (ap.[codigo_original] = vv.[codigo_original] AND ap.[codigo_articulo_proveedor] = vv.[codigo_articulo_proveedor]) " +
                "    WHERE ap.codigo_original LIKE @codigo_original";

            comando.Parameters.Add(instanciarParametro(pCodigoOriginal, "@codigo_original"));

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
                "SELECT " +
                "    ap.[codigo_original],ap.[codigo_articulo_proveedor],ap.[stock_minimo],ap.[stock_actual],ap.[observaciones],ap.[ubicacion], " +
                "    ap.[descripcion],ap.[fecha_actualizacion],ap.[codigo_entidad],vv.[valor] AS [valor_venta], vv.[fecha_valor] AS [fecha_valor_venta], " +
                "    vc.[valor] AS [valor_compra], vc.[fecha_valor] AS [fecha_valor_compra] , [prov].razon_social as razon_social_proveedor " +
	            "   FROM [Articulos_Proveedores] ap "+
	            "   INNER JOIN [proveedores] prov "+
	            "   ON [prov].codigo_entidad = [ap].codigo_entidad "+
                "   INNER JOIN " +
                "    ( " +
                "    SELECT valC.codigo_articulo_proveedor, valC.codigo_original, valC.fecha_valor, valC.valor " +
                "        FROM " +
                "        ( " +
                "            SELECT " +
                "                vc1.codigo_articulo_proveedor, vc1.codigo_original, vc1.fecha_valor, vc1.valor,  " +
                "                row_number() over(partition by vc1.codigo_articulo_proveedor, vc1.codigo_original order by vc1.fecha_valor desc) rn " +
                "                FROM [Valores_Compra] vc1  " +
                "        ) valC " +
                "            WHERE valC.rn = 1 " +
                "       ) vc  " +
                "    ON (ap.[codigo_original] = vc.[codigo_original] AND ap.[codigo_articulo_proveedor] = vc.[codigo_articulo_proveedor]) " +
                "    INNER JOIN " +
                "    (  " +
                "    SELECT valV.codigo_articulo_proveedor, valV.codigo_original, valV.fecha_valor, valV.valor  " +
                "        FROM " +
                "        ( " +
                "            SELECT  " +
                "                vv1.codigo_articulo_proveedor, vv1.codigo_original, vv1.fecha_valor, vv1.valor, " +
                "                row_number() over(partition by vv1.codigo_articulo_proveedor, vv1.codigo_original order by vv1.fecha_valor desc) rn " +
                "                FROM [Valores_Venta] vv1  " +
                "        ) valV " +
                "            WHERE valV.rn = 1 " +
                "        ) vv " +
                "    ON (ap.[codigo_original] = vv.[codigo_original] AND ap.[codigo_articulo_proveedor] = vv.[codigo_articulo_proveedor]) " +
                "    WHERE ap.codigo_articulo_proveedor LIKE @codigo_articulo_proveedor";

            comando.Parameters.Add(instanciarParametro(pCodigoArticuloProveedor, "@codigo_articulo_proveedor"));

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
                "SELECT "+
                "   [codigo_original],[codigo_articulo_proveedor],[stock_minimo],[stock_actual],[observaciones],[ubicacion]," +
                "   [descripcion],[fecha_actualizacion],ap.codigo_entidad, [prov].razon_social as razon_social_proveedor  " +
                "   FROM [Articulos_Proveedores] ap " +
                "   INNER JOIN [proveedores] prov " +
                "   ON [prov].codigo_entidad = [ap].codigo_entidad " +
                "   WHERE codigo_original = @codigo_original AND codigo_articulo_proveedor=@codigo_articulo_proveedor";

            comando.Parameters.Add(instanciarParametro(pCodigoOriginal, "@codigo_original"));
            comando.Parameters.Add(instanciarParametro(pCodigoArticuloProveedor, "@codigo_articulo_proveedor"));   
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
                "SELECT "+
                "   [codigo_original],[codigo_articulo_proveedor],[stock_minimo],[stock_actual],[observaciones],[ubicacion],"+
                "   [descripcion],[fecha_actualizacion],ap.codigo_entidad, [prov].razon_social as razon_social_proveedor   " +
                "   FROM [Articulos_Proveedores] ap " +
                "   INNER JOIN [proveedores] prov " +
                "   ON [prov].codigo_entidad = [ap].codigo_entidad " ;

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
                    "INSERT INTO [Articulos_Proveedores]([codigo_original],[codigo_articulo_proveedor],[stock_minimo],[stock_actual],"+
                    "[observaciones],[descripcion],[fecha_actualizacion],[codigo_entidad]) "+
                    "VALUES (@codigo_original, @codigo_articulo_proveedor, @stock_minimo, @stock_actual, @observaciones, "+
                    "@descripcion, @fecha_actualizacion, @codigo_entidad )";
                //Indica los parametros
                comando.Parameters.Add(this.instanciarParametro(pModArtProv.codigoArticuloProveedor,"@codigo_articulo_proveedor"));
                comando.Parameters.Add(this.instanciarParametro(pModArtProv.codigoOriginal, "@codigo_original"));
                comando.Parameters.Add(this.instanciarParametro(pModArtProv.codigoEntidad , "@codigo_entidad"));
                comando.Parameters.Add(this.instanciarParametro(pModArtProv.descripcion, "@descripcion"));
                comando.Parameters.Add(this.instanciarParametro(pModArtProv.observaciones, "@observaciones"));
                comando.Parameters.Add(this.instanciarParametro(pModArtProv.stockMinimo, "@stock_minimo"));
                comando.Parameters.Add(this.instanciarParametro(pModArtProv.stockActual, "@stock_actual"));
                comando.Parameters.Add(this.instanciarParametro(pModArtProv.fechaActualizacion, "@fecha_actualizacion"));

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
                "UPDATE [Articulos_Proveedores] SET [stock_minimo]=@stock_minimo,[stock_actual]=@stock_actual,[observaciones]=@observaciones,"+
                "[descripcion]=@descripcion,[fecha_actualizacion]=@fecha_actualizacion  "+
                "WHERE ([Articulos_Proveedores].codigo_original=@codigo_original AND [Articulos_Proveedores].codigo_articulo_proveedor=@codigo_articulo_proveedor)";

            comando.Parameters.Add(this.instanciarParametro(pModArtProv.codigoArticuloProveedor, "@codigo_articulo_proveedor"));
            comando.Parameters.Add(this.instanciarParametro(pModArtProv.codigoOriginal, "@codigo_original"));
            comando.Parameters.Add(this.instanciarParametro(pModArtProv.descripcion, "@descripcion"));
            comando.Parameters.Add(this.instanciarParametro(pModArtProv.observaciones, "@observaciones"));
            comando.Parameters.Add(this.instanciarParametro(pModArtProv.stockMinimo, "@stock_minimo"));
            comando.Parameters.Add(this.instanciarParametro(pModArtProv.stockActual, "@stock_actual"));
            comando.Parameters.Add(this.instanciarParametro(pModArtProv.fechaActualizacion, "@fecha_actualizacion"));

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
                "DELETE FROM [Articulos_Proveedores] WHERE ([Articulos_Proveedores].codigo_articulo_proveedor=@codigo_articulo_proveedor "+
                "AND [Articulos_Proveedores].codigo_original=@codigo_original )";

            comando.Parameters.Add(this.instanciarParametro(pModArtProv.codigoArticuloProveedor, "@codigo_articulo_proveedor"));
            comando.Parameters.Add(this.instanciarParametro(pModArtProv.codigoOriginal, "@codigo_original"));

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
