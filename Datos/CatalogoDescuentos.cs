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
    public class CatalogoDescuentos : Catalogo
    {
        private ModeloDescuentoArticuloProveedor leerDatosDescuento(SqlDataReader p_drDescuentos)
        {
            ModeloDescuentoArticuloProveedor lcl_mod_descuento = new ModeloDescuentoArticuloProveedor();

            lcl_mod_descuento.codigoDescuento = (int)p_drDescuentos["numero_descuento"];
            lcl_mod_descuento.codigoOriginalArticulo = (string)p_drDescuentos["codigo_original"];
            lcl_mod_descuento.codigoArticuloProveedor = (string)p_drDescuentos["codigo_articulo_proveedor"];
            lcl_mod_descuento.descripcion = (string)p_drDescuentos["descripcion"];
            lcl_mod_descuento.porcentaje = (decimal)p_drDescuentos["porcentaje_descuento"];
            lcl_mod_descuento.fechaVigenciaDesde = (DateTime)p_drDescuentos["fecha_desde"];
            lcl_mod_descuento.fechaVigenciaHasta = (DateTime)p_drDescuentos["fecha_hasta"];
            
            
            return lcl_mod_descuento;
        }


        public List<ModeloDescuentoArticuloProveedor> buscarDescuentos(string p_codigoOriginal, string p_codigoArticuloProveedor)
        {
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();
            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;

            //string querySQL = this.getCondicionBusqueda(p_mod_pedido, p_parametroBusqueda, ref comando);

            comando.CommandText =
                "SELECT  [codigo_articulo_proveedor],[codigo_original],[fecha_desde],[fecha_hasta],[porcentaje_descuento],[numero_descuento] " +
                "FROM  Descuentos_articulos "+
                "WHERE codigo_original like @codigo_original AND codigo_articulo_proveedor like @codigo_articulo_proveedor "+
                "ORDER BY codigo_original desc";

            comando.Parameters.Add(this.instanciarParametro(p_codigoOriginal, "@codigo_original"));
            comando.Parameters.Add(this.instanciarParametro(p_codigoArticuloProveedor, "@codigo_articulo_proveedor"));

            comando.Connection.Open();

            SqlDataReader drDescuentos = comando.ExecuteReader();

            List<ModeloDescuentoArticuloProveedor> lcl_lst_mod_descuento = new List<ModeloDescuentoArticuloProveedor>();
            ModeloDescuentoArticuloProveedor lcl_mod_descuento = new ModeloDescuentoArticuloProveedor();

            while (drDescuentos.Read())
            {

                lcl_mod_descuento = new ModeloDescuentoArticuloProveedor();
                lcl_mod_descuento = this.leerDatosDescuento(drDescuentos);

               lcl_lst_mod_descuento.Add(lcl_mod_descuento);
            }
            drDescuentos.Close();
            comando.Connection.Close();

            return lcl_lst_mod_descuento;
        }

        public List<ModeloDescuentoArticuloProveedor> buscarDescuentosVigentes(DateTime p_fecha)
        {
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();
            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;

            //string querySQL = this.getCondicionBusqueda(p_mod_pedido, p_parametroBusqueda, ref comando);

            comando.CommandText =
                "SELECT  [codigo_articulo_proveedor],[codigo_original],[fecha_desde],[fecha_hasta],[porcentaje_descuento],[numero_descuento] " +
                "FROM  Descuentos_articulos " +
                "WHERE @fecha_hoy between fecha_desde AND fecha_hasta " +
                "ORDER BY codigo_original desc";

            comando.Parameters.Add(this.instanciarParametro(p_fecha, "@fecha_hoy"));
            

            comando.Connection.Open();

            SqlDataReader drDescuentos = comando.ExecuteReader();

            List<ModeloDescuentoArticuloProveedor> lcl_lst_mod_descuento = new List<ModeloDescuentoArticuloProveedor>();
            ModeloDescuentoArticuloProveedor lcl_mod_descuento = new ModeloDescuentoArticuloProveedor();

            while (drDescuentos.Read())
            {

                lcl_mod_descuento = new ModeloDescuentoArticuloProveedor();
                lcl_mod_descuento = this.leerDatosDescuento(drDescuentos);

                lcl_lst_mod_descuento.Add(lcl_mod_descuento);
            }
            drDescuentos.Close();
            comando.Connection.Close();

            return lcl_lst_mod_descuento;
        }


        public bool descuentosSuperpuestos(ModeloDescuentoArticuloProveedor p_mod_descuentoAP)
        {
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();
            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;

            //string querySQL = this.getCondicionBusqueda(p_mod_pedido, p_parametroBusqueda, ref comando);

            comando.CommandText =
                "SELECT  [codigo_articulo_proveedor],[codigo_original],[fecha_desde],[fecha_hasta],[porcentaje_descuento],[numero_descuento]" +
                "FROM  Descuentos_articulos " +
                "WHERE codigo_original like @codigo_original AND codigo_articulo_proveedor like @codigo_articulo_proveedor " +
                "AND ((fecha_desde between @fecha_desde AND @fecha_hasta) OR (fecha_hasta between @fecha_desde AND @fecha_hasta))";
                

            comando.Parameters.Add(this.instanciarParametro(p_mod_descuentoAP.codigoOriginalArticulo, "@codigo_original"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_descuentoAP.codigoArticuloProveedor, "@codigo_articulo_proveedor"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_descuentoAP.fechaVigenciaDesde, "@fecha_desde"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_descuentoAP.fechaVigenciaHasta, "@fecha_hasta"));

            comando.Connection.Open();

            SqlDataReader drDescuentos = comando.ExecuteReader();
            
            bool rta = drDescuentos.HasRows;
            drDescuentos.Close();
            comando.Connection.Close();

            return rta;
        
        }

        public ModeloDescuentoArticuloProveedor getOne (string p_numero_descuento)
        {
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();
            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;

            comando.CommandText =
                "SELECT  [codigo_articulo_proveedor],[codigo_original],[fecha_desde],[fecha_hasta],[porcentaje_descuento],[numero_descuento]" +
                "FROM  Descuentos_articulos "+
                "WHERE numero_descuento like @numero_descuento "+
                "ORDER BY codigo_original desc";

            comando.Parameters.Add(this.instanciarParametro(p_numero_descuento, "@numero_descuento"));

            comando.Connection.Open();

            SqlDataReader drDescuentos = comando.ExecuteReader();

            ModeloDescuentoArticuloProveedor lcl_mod_descuento = new ModeloDescuentoArticuloProveedor();

            lcl_mod_descuento = this.leerDatosDescuento(drDescuentos);
                      
            drDescuentos.Close();
            comando.Connection.Close();

            return lcl_mod_descuento;
        }
        public int getUltimoNumero()
        {
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();
            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;

            comando.CommandText =
                "SELECT  MAX([numero_descuento]) as Ultimo " +
                "FROM  Descuentos_articulos " ;

                        comando.Connection.Open();

            SqlDataReader drDescuentos = comando.ExecuteReader();
            int ultimo_descuento = 0;
            drDescuentos.Read();
            if (!drDescuentos.IsDBNull(0))
            {
                
                ultimo_descuento = (int)drDescuentos["Ultimo"]; }
                      

            drDescuentos.Close();
            comando.Connection.Close();

            return ultimo_descuento+1;
        }

        public bool add(ModeloDescuentoArticuloProveedor p_mod_descuento)
        {
            if (this.descuentosSuperpuestos(p_mod_descuento))
            { throw new Exception("Existe otro descuento entre las fechas."); }

            SqlConnection ConexionSQL = Conexion.crearConexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText =
                "INSERT INTO [Descuentos_articulos]([codigo_original],[codigo_articulo_proveedor],[fecha_desde],[fecha_hasta]," +
                "   [porcentaje_descuento],[numero_descuento]) " +
                "   VALUES (@codigo_original, @codigo_articulo_proveedor, @fecha_desde, @fecha_hasta, @porcentaje_descuento, " +
                "   @numero_descuento); ";
                
            comando.Parameters.Add(this.instanciarParametro(p_mod_descuento.codigoArticuloProveedor, "@codigo_articulo_proveedor"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_descuento.codigoOriginalArticulo, "@codigo_original"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_descuento.fechaVigenciaDesde, "@fecha_desde"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_descuento.fechaVigenciaHasta, "@fecha_hasta"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_descuento.codigoDescuento, "@numero_descuento"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_descuento.porcentaje, "@porcentaje_descuento"));
                       

            comando.Connection.Open();
            int rowaffected = comando.ExecuteNonQuery();
            comando.Connection.Close();
            
            if (rowaffected < 1)
            {
                throw new Exception("Ha ocurrido un error en la base de datos. No se ha podido registrar Descuento.");
            }

            return true;
        }

        public bool update(ModeloDescuentoArticuloProveedor p_mod_descuento)
        {
            SqlConnection ConexionSQL = Datos.Conexion.crearConexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText =
                "UPDATE [Descuentos_articulos] SET " +
                "[fecha_desde]=@fecha_desde,[fecha_hasta]=@fecha_hasta, [porcentaje_descuento]=@porcentaje_descuento " +
                "WHERE ([codigo_original]=@codigo_original AND [codigo_articulo_proveedor]=@codigo_articulo_proveedor " +
                "AND [numero_descuento]=@numero_descuento)";

            comando.Parameters.Add(this.instanciarParametro(p_mod_descuento.codigoArticuloProveedor, "@codigo_articulo_proveedor"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_descuento.codigoOriginalArticulo, "@codigo_original"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_descuento.fechaVigenciaDesde, "@fecha_desde"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_descuento.fechaVigenciaHasta, "@fecha_hasta"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_descuento.codigoDescuento, "@numero_descuento"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_descuento.porcentaje, "@porcentaje_descuento"));
            

            comando.Connection.Open();
            int rowaffected = comando.ExecuteNonQuery();
            comando.Connection.Close();

            if (rowaffected != 0)
            { return true; }
            else
            { return false; }
        }

        public bool remove(ModeloDescuentoArticuloProveedor p_mod_descuento)
        {
            SqlConnection ConexionSQL = Datos.Conexion.crearConexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText =
                "DELETE FROM [Descuentos_articulos] " +
                "   WHERE (codigo_articulo_proveedor=@codigo_articulo_proveedor AND codigo_original=@codigo_original AND numero_descuento=@numero_descuento) ";

            comando.Parameters.Add(this.instanciarParametro(p_mod_descuento.codigoArticuloProveedor, "@codigo_articulo_proveedor"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_descuento.codigoOriginalArticulo, "@codigo_original"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_descuento.fechaVigenciaDesde, "@fecha_desde"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_descuento.fechaVigenciaHasta, "@fecha_hasta"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_descuento.codigoDescuento, "@numero_descuento"));

            comando.Connection.Open();
            int rowaffected = comando.ExecuteNonQuery();
            comando.Connection.Close();

            if (rowaffected != 0)
            { return true; }
            else
            { return false; }
        }


    }
}
