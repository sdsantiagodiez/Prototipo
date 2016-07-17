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
            
            if(getOne(p_mod_articuloProveedor) != null)
            {
                respuesta = true;
            }
            return respuesta;
        }

        private ModeloArticuloProveedores leerDatosArticuloProveedor(SqlDataReader p_drArticulosProveedor)
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
            lcl_mod_articuloProveedor.valorVenta = lcl_mod_valorArticuloVenta;

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
        
        #region Búsqueda
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
                
                case Constantes.ParametrosBusqueda.One:
                    p_comando.Parameters.Add(this.instanciarParametro(p_mod_articuloProveedor.codigoOriginal, "@codigo_original"));
                    p_comando.Parameters.Add(this.instanciarParametro(p_mod_articuloProveedor.codigoArticuloProveedor, "@codigo_articulo_proveedor"));
                    return " (@codigo_original = ap.codigo_original) AND (@codigo_articulo_proveedor = ap.codigo_articulo_proveedor) ";

                case Constantes.ParametrosBusqueda.Any:
                    string codigoOriginal = p_mod_articuloProveedor.codigoOriginal == "" ? null : p_mod_articuloProveedor.codigoOriginal;
                    p_comando.Parameters.Add(this.instanciarParametro(this.agregarComodinBusquedaLIKE(p_mod_articuloProveedor.codigoOriginal), "@codigo_original"));
                    string codigoOriginalQuery = this.parametroBusqueda("@codigo_original", "ap.codigo_original", "LIKE");

                    string codigoArticuloProveedor = String.IsNullOrWhiteSpace(p_mod_articuloProveedor.codigoArticuloProveedor) ? null : p_mod_articuloProveedor.codigoArticuloProveedor;
                    p_comando.Parameters.Add(this.instanciarParametro(this.agregarComodinBusquedaLIKE(p_mod_articuloProveedor.codigoArticuloProveedor), "@codigo_articulo_proveedor"));
                    string codigoArticuloProveedorQuery = this.parametroBusqueda("@codigo_articulo_proveedor", "ap.codigo_articulo_proveedor", "LIKE");

                    string descripcionArticuloProveedor = String.IsNullOrWhiteSpace(p_mod_articuloProveedor.descripcionArticuloProveedor) ? null : p_mod_articuloProveedor.descripcionArticuloProveedor;
                    p_comando.Parameters.Add(this.instanciarParametro(this.agregarComodinBusquedaLIKE(descripcionArticuloProveedor), "@descripcion_articulo_proveedor"));
                    string descripcionArticuloProveedorQuery = this.parametroBusqueda("@descripcion_articulo_proveedor", "ap.descripcion", "LIKE");

                    int? codigoEntidad = p_mod_articuloProveedor.codigoEntidad == 0 ? null : (int?)p_mod_articuloProveedor.codigoEntidad;
                    p_comando.Parameters.Add(this.instanciarParametro(codigoEntidad, "@codigo_entidad"));
                    string codigoEntidadQuery = @" (@codigo_entidad IS NULL OR @codigo_entidad = ap.codigo_entidad) ";

                    string razonSocialProveedor = String.IsNullOrWhiteSpace(p_mod_articuloProveedor.razonSocialProveedor) ? null : p_mod_articuloProveedor.razonSocialProveedor;
                    p_comando.Parameters.Add(this.instanciarParametro(this.agregarComodinBusquedaLIKE(razonSocialProveedor), "@razon_social"));
                    string razonSocialProveedorQuery = this.parametroBusqueda("@razon_social", "prov.razon_social", "LIKE");

                    return codigoOriginalQuery + " AND " + codigoArticuloProveedorQuery + " AND " + descripcionArticuloProveedorQuery + " AND " + codigoEntidadQuery + " AND " + razonSocialProveedorQuery;

                default:
                    return base.getCondicionBusqueda(p_parametroBusqueda);
            }
        }

        public List<ModeloArticuloProveedores> buscar(ModeloArticuloProveedores p_mod_articuloProveedor, string p_parametroBusqueda)
        {
            SqlConnection ConexionSQL = Conexion.crearConexion();
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
                lcl_mod_articuloProveedor = this.leerDatosArticuloProveedor(drArtProveedores);
                
                lcl_lst_mod_articulosProveedores.Add(lcl_mod_articuloProveedor);
            }

            drArtProveedores.Close();
            comando.Connection.Dispose();

            CatalogoDescuentoArticuloProveedores lcl_cat_descuentosAP = new CatalogoDescuentoArticuloProveedores();
            foreach (ModeloArticuloProveedores ap in lcl_lst_mod_articulosProveedores)
            {
                lcl_cat_descuentosAP.getDescuentos(ap);
            }

            return lcl_lst_mod_articulosProveedores;
        }

        public ModeloArticuloProveedores getOne(ModeloArticuloProveedores p_mod_articuloProveedor)
        {
            List<ModeloArticuloProveedores> lcl_lst_mod_articuloProveedor = new List<ModeloArticuloProveedores>();

            lcl_lst_mod_articuloProveedor = this.buscar(p_mod_articuloProveedor, Constantes.ParametrosBusqueda.One);

            if (lcl_lst_mod_articuloProveedor.Count > 0)
            {
                return lcl_lst_mod_articuloProveedor[0];
            }
            else
            {
                return null;
            }
        }

        #endregion

        #region Alta/Baja/Modificación
        public bool add(ModeloArticuloProveedores p_mod_articuloProveedor)
        { 
            if(this.existeEntidad(p_mod_articuloProveedor))
            { throw new Exception("El Artículo de Proveedor ya existe."); }

            SqlConnection ConexionSQL = Conexion.crearConexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType= CommandType.Text;
            comando.CommandText = 
                "INSERT INTO [Articulos_Proveedores]([codigo_original],[codigo_articulo_proveedor],[stock_minimo],[stock_actual],"+
                "   [ubicacion],[observaciones],[descripcion],[fecha_actualizacion],[codigo_entidad]) "+
                "   VALUES (@codigo_original, @codigo_articulo_proveedor, @stock_minimo, @stock_actual, @ubicacion, "+
                "   @observaciones, @descripcion, @fecha_actualizacion, @codigo_entidad ); " +
                
                "INSERT INTO [Valores_Compra]([codigo_articulo_proveedor],[codigo_original],[fecha_valor],[valor]) "+
                "   VALUES (@codigo_articulo_proveedor, @codigo_original, @fecha_actualizacion, @valor_compra ); "+
                
                "INSERT INTO [Valores_Venta]([codigo_articulo_proveedor],[codigo_original],[fecha_valor],[valor]) "+
                "   VALUES (@codigo_articulo_proveedor, @codigo_original, @fecha_actualizacion, @valor_venta ); ";
            
            comando.Parameters.Add(this.instanciarParametro(p_mod_articuloProveedor.codigoArticuloProveedor,"@codigo_articulo_proveedor"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_articuloProveedor.codigoOriginal, "@codigo_original"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_articuloProveedor.codigoEntidad , "@codigo_entidad"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_articuloProveedor.descripcionArticuloProveedor, "@descripcion"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_articuloProveedor.observacionesArticuloProveedor, "@observaciones"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_articuloProveedor.stockMinimo, "@stock_minimo"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_articuloProveedor.stockActual, "@stock_actual"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_articuloProveedor.ubicacion,"@ubicacion"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_articuloProveedor.valorCompra.valorArticulo, "@valor_compra"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_articuloProveedor.valorVenta.valorArticulo,"@valor_venta"));

            comando.Parameters.Add(this.instanciarParametro(DateTime.Now, "@fecha_actualizacion"));

            comando.Connection.Open();
            int rowaffected = comando.ExecuteNonQuery();
            comando.Connection.Close();
            //Al ser <3 es porque no se ha insertado en todas las tablas
            if (rowaffected < 3)
            {
                throw new Exception("Ha ocurrido un error en la base de datos. No se ha podido registrar Artículo de Proveedor.");
            }

            return true;
        }

        public bool update(ModeloArticuloProveedores p_mod_articuloProveedor_nuevo)
        {
            ModeloArticuloProveedores p_mod_articuloProveedor_original = this.buscar(p_mod_articuloProveedor_nuevo, Constantes.ParametrosBusqueda.One).ToList()[0];
            if (p_mod_articuloProveedor_original != null)
                return update(p_mod_articuloProveedor_original, p_mod_articuloProveedor_nuevo);
            else
                return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p_mod_articuloProveedor_original"></param>
        /// <param name="p_mod_articuloProveedor_nuevo"></param>
        /// <returns>true si no se ha realizado modificación o no hubo fallos</returns>
        private bool update(ModeloArticuloProveedores p_mod_articuloProveedor_original, ModeloArticuloProveedores p_mod_articuloProveedor_nuevo)
        {
            if (!p_mod_articuloProveedor_original.Equals(p_mod_articuloProveedor_nuevo))
            {
                if (!this.updateArticuloProveedor(p_mod_articuloProveedor_nuevo))
                {
                    return false;
                }
                if (!p_mod_articuloProveedor_original.valorCompra.Equals(p_mod_articuloProveedor_nuevo.valorCompra))
                {
                    if (!this.updateValor(p_mod_articuloProveedor_nuevo, Constantes.TipoValorArticulo.Compra))
                    {
                        return false;
                    }
                }
                if (!p_mod_articuloProveedor_original.valorVenta.Equals(p_mod_articuloProveedor_nuevo.valorVenta))
                {
                    if (!this.updateValor(p_mod_articuloProveedor_nuevo, Constantes.TipoValorArticulo.Venta))
                    {
                        return false;
                    }
                }
                if (!p_mod_articuloProveedor_original.descuentos.Equals(p_mod_articuloProveedor_nuevo.descuentos))
                {
                    CatalogoDescuentoArticuloProveedores lcl_cat_descuentosAP = new CatalogoDescuentoArticuloProveedores();
                    if (!lcl_cat_descuentosAP.update(p_mod_articuloProveedor_original.descuentos, p_mod_articuloProveedor_nuevo.descuentos))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private bool updateArticuloProveedor(ModeloArticuloProveedores p_mod_articuloProveedor)
        {
            SqlConnection ConexionSQL = Datos.Conexion.crearConexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText = 
                "UPDATE [Articulos_Proveedores] SET [stock_minimo]=@stock_minimo,[stock_actual]=@stock_actual,[observaciones]=@observaciones,"+
                "[descripcion]=@descripcion,[fecha_actualizacion]=@fecha_actualizacion, [ubicacion]=@ubicacion  "+
                "WHERE ([Articulos_Proveedores].codigo_original=@codigo_original AND [Articulos_Proveedores].codigo_articulo_proveedor=@codigo_articulo_proveedor)";

            comando.Parameters.Add(this.instanciarParametro(p_mod_articuloProveedor.codigoArticuloProveedor, "@codigo_articulo_proveedor"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_articuloProveedor.codigoOriginal, "@codigo_original"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_articuloProveedor.descripcionArticuloProveedor, "@descripcion"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_articuloProveedor.observacionesArticuloProveedor, "@observaciones"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_articuloProveedor.stockMinimo, "@stock_minimo"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_articuloProveedor.stockActual, "@stock_actual"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_articuloProveedor.fechaActualizacion, "@fecha_actualizacion"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_articuloProveedor.ubicacion, "@ubicacion"));

            comando.Connection.Open();
            int rowaffected = comando.ExecuteNonQuery();
            comando.Connection.Close();

            if (rowaffected != 0)
            {return true;}
            else
            {return false;}
        }

        private bool estadoArticuloProveedor(ModeloArticuloProveedores p_mod_articuloProveedor, string p_activo)
        {
            SqlConnection ConexionSQL = Datos.Conexion.crearConexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText =
                "UPDATE [Articulos_Proveedores] SET [activo]=@activo  " +
                "WHERE ([Articulos_Proveedores].codigo_original=@codigo_original AND [Articulos_Proveedores].codigo_articulo_proveedor=@codigo_articulo_proveedor)";

            comando.Parameters.Add(this.instanciarParametro(p_mod_articuloProveedor.codigoArticuloProveedor, "@codigo_articulo_proveedor"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_articuloProveedor.codigoOriginal, "@codigo_original"));
            comando.Parameters.Add(this.instanciarParametro(p_activo, "@activo"));

            comando.Connection.Open();
            int rowaffected = comando.ExecuteNonQuery();
            comando.Connection.Close();

            if (rowaffected != 0)
            { return true; }
            else
            { return false; }
        }

        /// <summary>
        /// Genera insert en tabla valor_(Compra|Venta) con el nuevo valor
        /// </summary>
        /// <param name="p_mod_articuloProveedor"></param>
        /// <param name="p_tipoValorArticulo"></param>
        /// <returns></returns>
        public bool updateValor(ModeloArticuloProveedores p_mod_articuloProveedor,string p_tipoValorArticulo)
        {
            SqlConnection ConexionSQL = Datos.Conexion.crearConexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            string tablaValores ="";
            ModeloValorArticulo lcl_mod_valorArticulo = new ModeloValorArticulo();
            if (p_tipoValorArticulo == Constantes.TipoValorArticulo.Compra)
            {
                tablaValores = "Valores_Compra";
                lcl_mod_valorArticulo.valorArticulo = p_mod_articuloProveedor.valorCompra.valorArticulo;
            }
            else if (p_tipoValorArticulo == Constantes.TipoValorArticulo.Venta)
            {
                tablaValores = "Valores_Venta";
                lcl_mod_valorArticulo.valorArticulo = p_mod_articuloProveedor.valorVenta.valorArticulo;
            }
            
            comando.CommandText =
                "INSERT INTO [" + tablaValores + "]([codigo_articulo_proveedor],[codigo_original],[fecha_valor],[valor]) " +
                "VALUES (@codigo_articulo_proveedor, @codigo_original, @fecha_actualizacion, @valor)";

            comando.Parameters.Add(this.instanciarParametro(p_mod_articuloProveedor.codigoArticuloProveedor, "@codigo_articulo_proveedor"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_articuloProveedor.codigoOriginal, "@codigo_original"));
            comando.Parameters.Add(this.instanciarParametro(lcl_mod_valorArticulo.valorArticulo, "@valor"));
            comando.Parameters.Add(this.instanciarParametro(DateTime.Now, "@fecha_actualizacion"));

            comando.Connection.Open();
            int rowaffected = comando.ExecuteNonQuery();
            comando.Connection.Close();

            if (rowaffected != 0)
            {return true;}
            else
            {return false;}
        }

        public bool remove(ModeloArticuloProveedores p_mod_articuloProveedor)
        { 
            SqlConnection ConexionSQL = Datos.Conexion.crearConexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText = 
                "DELETE FROM [Articulos_Proveedores] "+
                "   WHERE (codigo_articulo_proveedor=@codigo_articulo_proveedor AND codigo_original=@codigo_original ) ";

            comando.Parameters.Add(this.instanciarParametro(p_mod_articuloProveedor.codigoArticuloProveedor, "@codigo_articulo_proveedor"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_articuloProveedor.codigoOriginal, "@codigo_original"));

            comando.Connection.Open();
            int rowaffected = comando.ExecuteNonQuery();
            comando.Connection.Close();

            if (rowaffected != 0)
            {
                CatalogoDescuentoArticuloProveedores lcl_cat_descuentosAP = new CatalogoDescuentoArticuloProveedores();
                return lcl_cat_descuentosAP.remove(p_mod_articuloProveedor.descuentos);
            }
            else
            { return false; }
        }
        #endregion
    }

    public class CatalogoDescuentoArticuloProveedores : Catalogo
    {
        #region leer datos
        private ModeloDescuento leerDatosDescuento(SqlDataReader p_drDescuento)
        {
            ModeloDescuento lcl_mod_descuento = new ModeloDescuento();

            lcl_mod_descuento.codigoDescuento = (int)p_drDescuento["codigo"];
            lcl_mod_descuento.descripcion = p_drDescuento["descripcion"] != DBNull.Value ?
                                                  (string)p_drDescuento["descripcion"] : null;
            lcl_mod_descuento.porcentaje = (decimal)p_drDescuento["porcentaje"];

            return lcl_mod_descuento;
        }
        private ModeloDescuentoArticuloProveedor leerDatosDescuentoArticuloProveedor(SqlDataReader p_drDescuentoAP)
        {
            ModeloDescuentoArticuloProveedor lcl_mod_descuentoAP = new ModeloDescuentoArticuloProveedor();

            lcl_mod_descuentoAP.codigoDescuento = (int)p_drDescuentoAP["codigo_descuento"];
            lcl_mod_descuentoAP.codigoOriginalArticulo = (string)p_drDescuentoAP["codigo_original"];
            lcl_mod_descuentoAP.codigoArticuloProveedor = (string)p_drDescuentoAP["codigo_articulo_proveedor"];
            lcl_mod_descuentoAP.fechaVigenciaDesde = (DateTime)p_drDescuentoAP["fecha_desde"];
            lcl_mod_descuentoAP.fechaVigenciaHasta = (DateTime)p_drDescuentoAP["fecha_hasta"];
            return lcl_mod_descuentoAP;
        }
        #endregion

        #region Alta/Baja/Modificación
        public bool add(List<ModeloDescuentoArticuloProveedor> p_lst_mod_descuentoAP)
        {
            foreach (ModeloDescuentoArticuloProveedor d_ap in p_lst_mod_descuentoAP)
            {
                if(!this.add(d_ap))
                {
                    return false;
                }
            }
            return true;
        }
        public bool add(ModeloDescuentoArticuloProveedor p_mod_descuentoAP)
        {
            //Si descuento no existe (codigo 0) se lo agrega
            if(p_mod_descuentoAP.codigoDescuento == 0 && !this.add(p_mod_descuentoAP as ModeloDescuento))
            {
                //No se pudo agregar descuento
                return false;
            }
            
            string query =
                "INSERT INTO [descuentos_articulos_proveedores] ([codigo_descuento], [codigo_original], [codigo_articulo_proveedor], [fecha_desde], [fecha_hasta]) " +
                "    VALUES (@codigo_descuento, @codigo_original, @codigo_articulo_proveedor, @fecha_desde, @fecha_hasta)";

            SqlCommand comando = new SqlCommand(query, Conexion.crearConexion());

            //Indica los parametros
            comando.Parameters.Add(this.instanciarParametro(p_mod_descuentoAP.codigoDescuento, "@codigo_descuento"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_descuentoAP.codigoOriginalArticulo, "@codigo_original"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_descuentoAP.codigoArticuloProveedor, "@codigo_articulo_Proveedor"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_descuentoAP.fechaVigenciaDesde, "@fecha_hasta"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_descuentoAP.fechaVigenciaHasta, "@fecha_desde"));

            comando.Connection.Open();
            int rowaffected = comando.ExecuteNonQuery();
            comando.Connection.Close();

            if (rowaffected != 0)
            { return true; }
            else
            {
                //Confirmar que pase por aca cuando descuento ya exista
                return false; 
            }
        }
        public bool add(ModeloDescuento p_mod_descuento)
        {

            string query =
             "INSERT INTO [descuentos_articulos] ([descripcion], [porcentaje]) " +
             "    VALUES ( @descripcion, @porcentaje)";

            SqlCommand comando = new SqlCommand(query, Conexion.crearConexion());

            //Indica los parametros
            comando.Parameters.Add(this.instanciarParametro(p_mod_descuento.descripcion, "@descripcion"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_descuento.porcentaje, "@porcentaje"));

            comando.Connection.Open();
            
            int? nuevoCodigoDescuento = (int?)comando.ExecuteScalar();
            comando.Connection.Close();

            if (nuevoCodigoDescuento != null)
            {
                p_mod_descuento.codigoDescuento = Convert.ToInt32(nuevoCodigoDescuento);
                return true; 
            }
            else
            { return false; }
        }

        public bool update(List<ModeloDescuentoArticuloProveedor> p_lst_descuentosAP_original, List<ModeloDescuentoArticuloProveedor> p_lst_descuentosAP_nueva)
        {
            #region get descuentos nuevos
            List<ModeloDescuentoArticuloProveedor> lcl_lst_descuentosAP_agregar = new List<ModeloDescuentoArticuloProveedor>();
            bool existe;
            foreach (ModeloDescuentoArticuloProveedor d_ap_nuevo in p_lst_descuentosAP_nueva)
            {
                existe = false;
                foreach (ModeloDescuentoArticuloProveedor d_ap_original in p_lst_descuentosAP_original)
                {
                    if (d_ap_nuevo.Equals(d_ap_original))
                    {
                        existe = true;
                        break;
                    }
                }

                if (!existe)
                {
                    lcl_lst_descuentosAP_agregar.Add(d_ap_nuevo);
                }
            }
            #endregion

            #region get descuentos eliminados
            List<ModeloDescuentoArticuloProveedor> lcl_lst_descuentosAP_eliminar = new List<ModeloDescuentoArticuloProveedor>();
            foreach (ModeloDescuentoArticuloProveedor d_ap_original in p_lst_descuentosAP_original)
            {
                existe = false;
                foreach (ModeloDescuentoArticuloProveedor d_ap_nuevo in p_lst_descuentosAP_nueva)
                {
                    if (d_ap_original.Equals(d_ap_nuevo))
                    {
                        existe = true;
                        break;
                    }
                }

                if (!existe)
                {
                    lcl_lst_descuentosAP_eliminar.Add(d_ap_original);
                }
            }
            #endregion

            return this.remove(lcl_lst_descuentosAP_eliminar) && this.add(lcl_lst_descuentosAP_agregar);
        }

        public bool remove(List<ModeloDescuentoArticuloProveedor> p_lst_mod_descuentoAP)
        {
            foreach (ModeloDescuentoArticuloProveedor d_ap in p_lst_mod_descuentoAP)
            {
                if (!this.remove(d_ap))
                {
                    return false;
                }
            }

            return true;
        }
        public bool remove(ModeloDescuentoArticuloProveedor p_mod_descuentoAP)
        {
            string query =
                "DELETE FROM [descuentos_articulos_proveedores] " +
                "   WHERE (@codigo_descuento=codigo_descuento AND @codigo_original = codigo_original AND "+
                " @codigo_articulo_proveedor = codigo_articulo_proveedor AND @fecha_desde = fecha_desde AND "+
                " @fecha_hasta = fecha_hasta) ";

            SqlCommand comando = new SqlCommand(query, Conexion.crearConexion());

            //Indica los parametros
            comando.Parameters.Add(this.instanciarParametro(p_mod_descuentoAP.codigoDescuento, "@codigo_descuento"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_descuentoAP.codigoOriginalArticulo, "@codigo_original"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_descuentoAP.codigoArticuloProveedor, "@codigo_articulo_Proveedor"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_descuentoAP.fechaVigenciaDesde, "@fecha_hasta"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_descuentoAP.fechaVigenciaHasta, "@fecha_desde"));

            comando.Connection.Open();
            int rowaffected = comando.ExecuteNonQuery();
            comando.Connection.Close();

            if (rowaffected != 0)
            { return true; }
            else
            { return false; }
        }
        #endregion

        #region Búsqueda
        /// <summary>
        /// Busca los descuentos asignados a un determinado artículo proveedor
        /// </summary>
        /// <param name="p_mod_articuloProveedor"></param>
        public void getDescuentos(ModeloArticuloProveedores p_mod_articuloProveedor)
        {
            string query =
             "SELECT " +
              "codigo_articulo_proveedor, codigo_original, codigo_descuento, fecha_desde,fecha_hasta " +
              "   FROM [descuentos_articulos_proveedores] " +
              "   WHERE (codigo_original = @codigo_original AND codigo_articulo_proveedor = @codigo_articulo_proveedor)";

            SqlCommand comando = new SqlCommand(query, Conexion.crearConexion());

            comando.Parameters.Add(this.instanciarParametro(p_mod_articuloProveedor.codigoOriginal, "@codigo_original"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_articuloProveedor.codigoArticuloProveedor, "@codigo_articulo_proveedor"));
           
            comando.Connection.Open();
            SqlDataReader drDescuentoArticuloProveedor = comando.ExecuteReader();
            ModeloDescuentoArticuloProveedor lcl_mod_descuentoAP;
            
            while (drDescuentoArticuloProveedor.Read())
            {
                lcl_mod_descuentoAP = new ModeloDescuentoArticuloProveedor();
                lcl_mod_descuentoAP = this.leerDatosDescuentoArticuloProveedor(drDescuentoArticuloProveedor);
                this.getDescuentoBase(lcl_mod_descuentoAP);
                p_mod_articuloProveedor.agregarDescuento(lcl_mod_descuentoAP);
            }
            drDescuentoArticuloProveedor.Close();
            comando.Connection.Close();
        }
        /// <summary>
        /// Busca el descuento base para un determinado descuentoArticuloProveedor
        /// </summary>
        /// <param name="p_mod_descuentoAP"></param>
        public void getDescuentoBase(ModeloDescuentoArticuloProveedor p_mod_descuentoAP)
        {
            string query =
             "SELECT " +
              "codigo, descripcion, porcentaje " +
              "   FROM [descuentos_articulos] " +
              "   WHERE (codigo = @codigo_descuento)";

            SqlCommand comando = new SqlCommand(query, Conexion.crearConexion());

            comando.Parameters.Add(this.instanciarParametro(p_mod_descuentoAP.codigoDescuento, "@codigo_descuento"));
           
            comando.Connection.Open();
            SqlDataReader drDescuento = comando.ExecuteReader();

            while (drDescuento.Read())
            {
                ModeloDescuento lcl_mod_descuento = this.leerDatosDescuento(drDescuento);
                p_mod_descuentoAP.descripcion = lcl_mod_descuento.descripcion;
                p_mod_descuentoAP.porcentaje = lcl_mod_descuento.porcentaje;
            }
            drDescuento.Close();
            comando.Connection.Close();
          }
        /// <summary>
        /// Retorna los descuentos preestablecidos por defecto en la base de datos
        /// </summary>
        /// <returns></returns>
        public List<ModeloDescuento> getDescuentoBase()
        {
            string query =
             "SELECT " +
              "codigo, descripcion, porcentaje " +
              "   FROM [descuentos_articulos] " +
              "   WHERE (codigo < 1000)";

            SqlCommand comando = new SqlCommand(query, Conexion.crearConexion());

            comando.Connection.Open();
            SqlDataReader drDescuento = comando.ExecuteReader();
            List<ModeloDescuento> lcl_lst_descuentosBase = new List<ModeloDescuento>();
            ModeloDescuento lcl_mod_descuento;
            while (drDescuento.Read())
            {
                lcl_mod_descuento = new ModeloDescuento();
                lcl_mod_descuento = this.leerDatosDescuento(drDescuento);
                lcl_lst_descuentosBase.Add(lcl_mod_descuento);
            }
            drDescuento.Close();
            comando.Connection.Close();

            return lcl_lst_descuentosBase;
        }
        
        #endregion
    }
}
