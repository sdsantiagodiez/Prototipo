using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using System.Data;
using System.Data.SqlClient;
using LibreriaClasesCompartidas;

namespace Datos
{
    public class CatalogoArticuloProveedores : Catalogo
    {
        public bool validarDatos(ModeloArticuloProveedores p_mod_articuloProveedor)
        {
            // Validar si los datos son correctos?
            return true;
        }

        /// <summary>
        /// Determina existencia de articuloProveedor de acuerdo a codigoArticuloProveedor ingresado
        /// </summary>
        /// <param name="codigoArticuloProveedor">código articulo proveedor de artículo proveedor</param>
        /// <returns>true si existe, false si no existe</returns>
        public bool existeEntidad(ModeloArticuloProveedores p_mod_articuloProveedor)
        {
            bool respuesta = false;
            if(getOne(p_mod_articuloProveedor.codigoOriginal, p_mod_articuloProveedor.codigoArticuloProveedor) != null)
            {
                respuesta = true;
            }
            return respuesta;
        }

        private ModeloArticuloProveedores leerDatosArticuloProveedorConPrecio(SqlDataReader p_drArticulosProveedor)
        {
            ModeloArticuloProveedores lcl_mod_articuloProveedor = new ModeloArticuloProveedores();

            var lcl_mod_valorArticuloCompra = new ModeloValorArticulo();
            lcl_mod_valorArticuloCompra.fechaUltimaActualizacion = (DateTime)p_drArticulosProveedor["fecha_valor_compra"];
            lcl_mod_valorArticuloCompra.valorArticulo = (p_drArticulosProveedor["valor_compra"] != DBNull.Value) ? (decimal?)p_drArticulosProveedor["valor_compra"] : null; ;
            //lcl_mod_valorArticuloCompra.valorArticulo = (decimal)p_drArticulosProveedor["valor_compra"];
            lcl_mod_articuloProveedor.valorCompra = lcl_mod_valorArticuloCompra;

            var lcl_mod_valorArticuloVenta = new ModeloValorArticulo();
            lcl_mod_valorArticuloVenta.fechaUltimaActualizacion = (DateTime)p_drArticulosProveedor["fecha_valor_venta"];
            lcl_mod_valorArticuloVenta.valorArticulo = (p_drArticulosProveedor["valor_venta"] != DBNull.Value) ? (decimal?)p_drArticulosProveedor["valor_venta"] : null; ;
            //lcl_mod_articuloProveedor.valorVenta = lcl_mod_valorArticuloVenta;

            lcl_mod_articuloProveedor.codigoOriginal = (string)p_drArticulosProveedor["codigo_original"];
            lcl_mod_articuloProveedor.codigoArticuloProveedor = (string)p_drArticulosProveedor["codigo_articulo_proveedor"];
            lcl_mod_articuloProveedor.codigoEntidad = (int)p_drArticulosProveedor["codigo_entidad"];
            lcl_mod_articuloProveedor.razonSocialProveedor = (string)p_drArticulosProveedor["razon_social_proveedor"];
            //Si algún valor esta null en Base de datos, se asigna null en el objeto
            //Caso contrario hay una string, y se asigna string
            lcl_mod_articuloProveedor.descripcionArticuloProveedor = (p_drArticulosProveedor["descripcion"] != DBNull.Value) ? (string)p_drArticulosProveedor["descripcion"] : null;
            lcl_mod_articuloProveedor.observacionesArticuloProveedor = (p_drArticulosProveedor["observaciones"] != DBNull.Value) ? (string)p_drArticulosProveedor["observaciones"] : null;
            lcl_mod_articuloProveedor.stockActual = (p_drArticulosProveedor["stock_actual"] != DBNull.Value) ? (int)p_drArticulosProveedor["stock_actual"] : (int?)null;
            lcl_mod_articuloProveedor.stockMinimo = (p_drArticulosProveedor["stock_minimo"] != DBNull.Value) ? (int)p_drArticulosProveedor["stock_minimo"] : (int?)null;
            lcl_mod_articuloProveedor.fechaActualizacion = (p_drArticulosProveedor["fecha_actualizacion"] != DBNull.Value) ? (DateTime)p_drArticulosProveedor["fecha_actualizacion"] : (DateTime?)null;
            lcl_mod_articuloProveedor.ubicacion = (p_drArticulosProveedor["ubicacion"] != DBNull.Value) ? (string)p_drArticulosProveedor["ubicacion"] : null;

            return lcl_mod_articuloProveedor;
        }

        private ModeloArticuloProveedores leerDatosArticuloProveedorSinPrecio(SqlDataReader p_drArticulosProveedor)
        {
            ModeloArticuloProveedores lcl_mod_articuloProveedor = new ModeloArticuloProveedores();

            lcl_mod_articuloProveedor.codigoOriginal = (string)p_drArticulosProveedor["codigo_original"];
            lcl_mod_articuloProveedor.codigoArticuloProveedor = (string)p_drArticulosProveedor["codigo_articulo_proveedor"];
            lcl_mod_articuloProveedor.codigoEntidad = (int)p_drArticulosProveedor["codigo_entidad"];
            lcl_mod_articuloProveedor.razonSocialProveedor = (string)p_drArticulosProveedor["razon_social_proveedor"];
            //Si algún valor esta null en Base de datos, se asigna null en el objeto
            //Caso contrario hay una string, y se asigna string
            lcl_mod_articuloProveedor.descripcionArticuloProveedor = (p_drArticulosProveedor["descripcion"] != DBNull.Value) ? (string)p_drArticulosProveedor["descripcion"] : null;
            lcl_mod_articuloProveedor.observacionesArticuloProveedor = (p_drArticulosProveedor["observaciones"] != DBNull.Value) ? (string)p_drArticulosProveedor["observaciones"] : null;
            lcl_mod_articuloProveedor.stockActual = (p_drArticulosProveedor["stock_actual"] != DBNull.Value) ? (int)p_drArticulosProveedor["stock_actual"] : (int?)null;
            lcl_mod_articuloProveedor.stockMinimo = (p_drArticulosProveedor["stock_minimo"] != DBNull.Value) ? (int)p_drArticulosProveedor["stock_minimo"] : (int?)null;
            lcl_mod_articuloProveedor.fechaActualizacion = (p_drArticulosProveedor["fecha_actualizacion"] != DBNull.Value) ? (DateTime)p_drArticulosProveedor["fecha_actualizacion"] : (DateTime?)null;
            lcl_mod_articuloProveedor.ubicacion = (p_drArticulosProveedor["ubicacion"] != DBNull.Value) ? (string)p_drArticulosProveedor["ubicacion"] : null;

            return lcl_mod_articuloProveedor;
        }

        /// <summary>
        /// Genera string a insertar en clausula WHERE de sql de acuerdo a los parámetros de búsqueda
        /// </summary>
        /// <param name="p_mod_articuloProveedor">modeloArticuloProveedor con variables posiblemente inicializadas</param>
        /// <param name="p_parametroBusqueda">constante encontrada en LibreriaClasesCompartidas.Constantes.ParametrosBusqueda.ArticulosProveedores</param>
        /// <param name="p_comando">comando sql que será modificado para incluir parámetros</param>
        /// <returns></returns>
        private string getCondicionBusqueda(ModeloArticuloProveedores p_mod_articuloProveedor, string p_parametroBusqueda, ref SqlCommand p_comando)
        {
            switch (p_parametroBusqueda)
            {
                case Constantes.ParametrosBusqueda.ArticulosProveedores.CodigoOriginal:
                    p_comando.Parameters.Add(this.instanciarParametro(this.agregarComodinBusquedaLIKE(p_mod_articuloProveedor.codigoOriginal), "@codigo_original"));
                    return " ap.codigo_original LIKE @codigo_original ";
                case Constantes.ParametrosBusqueda.ArticulosProveedores.CodigoArticuloProveedor:
                    p_comando.Parameters.Add(this.instanciarParametro(this.agregarComodinBusquedaLIKE(p_mod_articuloProveedor.codigoArticuloProveedor), "@codigo_articulo_proveedor"));
                    return " ap.codigo_articulo_proveedor LIKE @codigo_articulo_proveedor ";
                //Ver cuando haya que hacer con Articulo como parent
                case Constantes.ParametrosBusqueda.ArticulosProveedores.Descripcion:
                    //No devuelve resultados
                    return " 1 = 2 ";
                case Constantes.ParametrosBusqueda.ArticulosProveedores.DescripcionArticuloProveedor:
                    p_comando.Parameters.Add(this.instanciarParametro(this.agregarComodinBusquedaLIKE(p_mod_articuloProveedor.descripcionArticuloProveedor), "@descripcion_articulo_proveedor"));
                    return " ap.descripcion LIKE @descripcion_articulo_proveedor ";
                case Constantes.ParametrosBusqueda.ArticulosProveedores.codigoEntidadProveedor:
                    p_comando.Parameters.Add(this.instanciarParametro(p_mod_articuloProveedor.codigoEntidad, "@codigo_entidad"));
                    return " ap.codigo_entidad = @codigo_entidad ";
                case Constantes.ParametrosBusqueda.ArticulosProveedores.razonSocialProveedor:
                    p_comando.Parameters.Add(this.instanciarParametro(this.agregarComodinBusquedaLIKE(p_mod_articuloProveedor.razonSocialProveedor), "@razon_social"));
                    return " prov.razon_social LIKE @razon_social ";
                
                case Constantes.ParametrosBusqueda.ArticulosProveedores.One:
                    p_comando.Parameters.Add(this.instanciarParametro(p_mod_articuloProveedor.codigoOriginal, "@codigo_original"));
                    p_comando.Parameters.Add(this.instanciarParametro(p_mod_articuloProveedor.codigoArticuloProveedor, "@codigo_articulo_proveedor"));
                    return " (@codigo_original = ap.codigo_original) AND (@codigo_articulo_proveedor) = ap.codigo_articulo_proveedor " ;
                case Constantes.ParametrosBusqueda.ArticulosProveedores.Any:
                    string codigoOriginal = p_mod_articuloProveedor.codigoOriginal == "" ? null : p_mod_articuloProveedor.codigoOriginal;
                    p_comando.Parameters.Add(this.instanciarParametro(this.agregarComodinBusquedaLIKE(p_mod_articuloProveedor.codigoOriginal), "@codigo_original"));
                    string codigoOriginalQuery = this.parametroBusqueda("@codigo_original", "ap.codigo_original", "LIKE");

                    string codigoArticuloProveedor = p_mod_articuloProveedor.codigoArticuloProveedor == "" ? null : p_mod_articuloProveedor.codigoArticuloProveedor;
                    p_comando.Parameters.Add(this.instanciarParametro(this.agregarComodinBusquedaLIKE(p_mod_articuloProveedor.codigoArticuloProveedor), "@codigo_articulo_proveedor"));
                    string codigoArticuloProveedorQuery = this.parametroBusqueda("@codigo_articulo_proveedor", "ap.codigo_articulo_proveedor", "LIKE");

                    string descripcionArticuloProveedor = p_mod_articuloProveedor.descripcionArticuloProveedor == "" ? null : p_mod_articuloProveedor.descripcionArticuloProveedor;
                    p_comando.Parameters.Add(this.instanciarParametro(this.agregarComodinBusquedaLIKE(descripcionArticuloProveedor), "@descripcion_articulo_proveedor"));
                    string descripcionArticuloProveedorQuery = this.parametroBusqueda("@descripcion_articulo_proveedor", "ap.descripcion", "LIKE");

                    int? codigoEntidad = p_mod_articuloProveedor.codigoEntidad == 0 ? null : (int?)p_mod_articuloProveedor.codigoEntidad;
                    p_comando.Parameters.Add(this.instanciarParametro(codigoEntidad, "@codigo_entidad"));
                    string codigoEntidadQuery = @" (@codigo_entidad IS NULL OR @codigo_entidad = ap.codigo_entidad) ";

                    string razonSocialProveedor = p_mod_articuloProveedor.razonSocialProveedor == "" ? null : p_mod_articuloProveedor.razonSocialProveedor;
                    p_comando.Parameters.Add(this.instanciarParametro(this.agregarComodinBusquedaLIKE(razonSocialProveedor), "@razon_social"));
                    string razonSocialProveedorQuery = this.parametroBusqueda("@razon_social", "prov.razon_social", "LIKE");

                    return codigoOriginalQuery + " AND " + codigoArticuloProveedorQuery + " AND " + descripcionArticuloProveedorQuery + " AND " + codigoEntidadQuery + " AND " + razonSocialProveedorQuery;

                case Constantes.ParametrosBusqueda.Entidades.Proveedores.All:
                    //retorna true y devuelve todas las filas
                    return " 1 = 1 ";
                default:
                    //hace que sql no retorne filas
                    return " 1 = 2 ";
            }
        }

        public List<ModeloArticuloProveedores> buscarArticuloProveedor(ModeloArticuloProveedores p_mod_articuloProveedor, string p_parametroBusqueda)
        {
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            string querySQL = this.getCondicionBusqueda(p_mod_articuloProveedor, p_parametroBusqueda, ref comando);

            comando.CommandText =
                "SELECT " +
                "    ap.[codigo_original],ap.[codigo_articulo_proveedor],ap.[stock_minimo],ap.[stock_actual],ap.[observaciones],ap.[ubicacion], " +
                "    ap.[descripcion],ap.[fecha_actualizacion],ap.[codigo_entidad],vv.[valor] AS [valor_venta], vv.[fecha_valor] AS [fecha_valor_venta], " +
                "    vc.[valor] AS [valor_compra], vc.[fecha_valor] AS [fecha_valor_compra] , [prov].razon_social as razon_social_proveedor " +
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
                "    WHERE " + querySQL;

            comando.Connection.Open();

            SqlDataReader drArtProveedores = comando.ExecuteReader();

            List<ModeloArticuloProveedores> lcl_lst_mod_articulosProveedores = new List<ModeloArticuloProveedores>();
            ModeloArticuloProveedores lcl_mod_articuloProveedor = null;
            while (drArtProveedores.Read())
            {
                lcl_mod_articuloProveedor = new ModeloArticuloProveedores();
                lcl_mod_articuloProveedor = this.leerDatosArticuloProveedorConPrecio(drArtProveedores);
                lcl_lst_mod_articulosProveedores.Add(lcl_mod_articuloProveedor);
            }

            drArtProveedores.Close();
            comando.Connection.Close();

            return lcl_lst_mod_articulosProveedores;
        }
        
        public ModeloArticuloProveedores getOne(string p_codigoOriginal, string p_codigoArticuloProveedor)
        {
            ModeloArticuloProveedores lcl_mod_articuloProveedor = new ModeloArticuloProveedores();
            List<ModeloArticuloProveedores> lcl_lst_mod_articuloProveedor = new List<ModeloArticuloProveedores>();
            lcl_mod_articuloProveedor.codigoOriginal = p_codigoOriginal;
            lcl_mod_articuloProveedor.codigoArticuloProveedor = p_codigoArticuloProveedor;
            lcl_lst_mod_articuloProveedor = this.buscarArticuloProveedor(lcl_mod_articuloProveedor, Constantes.ParametrosBusqueda.ArticulosProveedores.One);

            if (lcl_lst_mod_articuloProveedor.Count > 0)
            {
                return lcl_lst_mod_articuloProveedor[0];
            }
            else
            {
                return null;
            }
        }

        public List<ModeloArticuloProveedores> getAll()
        {
            //Reemplazar parametro lcl_mod_articuloProveedor por null cuando se haya eliminado buscarArticuloProveedor(string,string) que devuelve ambiguedad
            ModeloArticuloProveedores lcl_mod_articuloProveedor = null;
            return this.buscarArticuloProveedor(lcl_mod_articuloProveedor, Constantes.ParametrosBusqueda.ArticulosProveedores.All);
        }

        #region Alta/Baja/Modificación
        /*
         * True si se realizó correctamente
         * False si ocurrió algún error
         */
        public bool add(ModeloArticuloProveedores p_mod_articuloProveedor)
        { 
            if(!this.existeEntidad(p_mod_articuloProveedor))
            {
                SqlConnection ConexionSQL = Conexion.crearConexion();
                SqlCommand comando = new SqlCommand();

                comando.Connection = ConexionSQL;
                comando.CommandType= CommandType.Text;
                comando.CommandText = 
                    "INSERT INTO [Articulos_Proveedores]([codigo_original],[codigo_articulo_proveedor],[stock_minimo],[stock_actual],"+
                    "[observaciones],[descripcion],[fecha_actualizacion],[codigo_entidad]) "+
                    "VALUES (@codigo_original, @codigo_articulo_proveedor, @stock_minimo, @stock_actual, @observaciones, "+
                    "@descripcion, @fecha_actualizacion, @codigo_entidad ); "+
                    "INSERT INTO [Valores_Compra]([codigo_articulo_proveedor],[codigo_original],[fecha_valor],[valor]) "+
                    "VALUES (@codigo_articulo_proveedor, @codigo_original, @fecha_actualizacion, @valor_compra ); "+
                    "INSERT INTO [Valores_Venta]([codigo_articulo_proveedor],[codigo_original],[fecha_valor],[valor]) "+
                    "VALUES (@codigo_articulo_proveedor, @codigo_original, @fecha_actualizacion, @valor_venta ); ";
                //Indica los parametros
                comando.Parameters.Add(this.instanciarParametro(p_mod_articuloProveedor.codigoArticuloProveedor,"@codigo_articulo_proveedor"));
                comando.Parameters.Add(this.instanciarParametro(p_mod_articuloProveedor.codigoOriginal, "@codigo_original"));
                comando.Parameters.Add(this.instanciarParametro(p_mod_articuloProveedor.codigoEntidad , "@codigo_entidad"));
                comando.Parameters.Add(this.instanciarParametro(p_mod_articuloProveedor.descripcionArticuloProveedor, "@descripcion"));
                comando.Parameters.Add(this.instanciarParametro(p_mod_articuloProveedor.observacionesArticuloProveedor, "@observaciones"));
                comando.Parameters.Add(this.instanciarParametro(p_mod_articuloProveedor.stockMinimo, "@stock_minimo"));
                comando.Parameters.Add(this.instanciarParametro(p_mod_articuloProveedor.stockActual, "@stock_actual"));
                comando.Parameters.Add(this.instanciarParametro(p_mod_articuloProveedor.valorCompra.valorArticulo, "@valor_compra"));
                comando.Parameters.Add(this.instanciarParametro(p_mod_articuloProveedor.valorVenta.valorArticulo,"@valor_venta"));
                
                comando.Parameters.Add(this.instanciarParametro(p_mod_articuloProveedor.fechaActualizacion, "@fecha_actualizacion"));

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

        public bool update(ModeloArticuloProveedores p_mod_articuloProveedor)
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

            comando.Parameters.Add(this.instanciarParametro(p_mod_articuloProveedor.codigoArticuloProveedor, "@codigo_articulo_proveedor"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_articuloProveedor.codigoOriginal, "@codigo_original"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_articuloProveedor.descripcionArticuloProveedor, "@descripcion"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_articuloProveedor.observacionesArticuloProveedor, "@observaciones"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_articuloProveedor.stockMinimo, "@stock_minimo"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_articuloProveedor.stockActual, "@stock_actual"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_articuloProveedor.fechaActualizacion, "@fecha_actualizacion"));

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

        public bool remove(ModeloArticuloProveedores p_mod_articuloProveedor)
        { 
         
            SqlConnection ConexionSQL = Datos.Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText = 
                "DELETE FROM [Articulos_Proveedores] WHERE ([Articulos_Proveedores].codigo_articulo_proveedor=@codigo_articulo_proveedor "+
                "AND [Articulos_Proveedores].codigo_original=@codigo_original )";

            comando.Parameters.Add(this.instanciarParametro(p_mod_articuloProveedor.codigoArticuloProveedor, "@codigo_articulo_proveedor"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_articuloProveedor.codigoOriginal, "@codigo_original"));

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
