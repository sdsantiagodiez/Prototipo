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
        private ModeloDescuento leerDatosDescuento(SqlDataReader p_drDescuentos)
        {
            ModeloDescuento lcl_mod_descuento = new ModeloDescuento();

            lcl_mod_descuento.CodigoOriginal = (string)p_drDescuentos["codigo_original"];
            lcl_mod_descuento.CodigoArticuloProveedor = (string)p_drDescuentos["codigo_articulo_proveedor"];
            lcl_mod_descuento.numeroDescuento = (int)p_drDescuentos["numero_descuento"];
            lcl_mod_descuento.PorcentajeDescuento = (decimal)p_drDescuentos["porcentaje_descuento"];
            lcl_mod_descuento.FechaDesde = (DateTime)p_drDescuentos["fecha_desde"];
            lcl_mod_descuento.FechaHasta = (DateTime)p_drDescuentos["fecha_hasta"];
            
            return lcl_mod_descuento;
        }

        public List<ModeloDescuento> buscarDescuento()
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
                "FROM  Descuentos_articulos" +
                "WHERE ";

            comando.Connection.Open();

            SqlDataReader drDescuentos = comando.ExecuteReader();

            List<ModeloDescuento> lcl_lst_mod_descuento = new List<ModeloDescuento>();
            ModeloDescuento lcl_mod_descuento = new ModeloDescuento();

            while (drDescuentos.Read())
            {

                lcl_mod_descuento = new ModeloDescuento();
                lcl_mod_descuento = this.leerDatosDescuento(drDescuentos);

               lcl_lst_mod_descuento.Add(lcl_mod_descuento);
            }
            drDescuentos.Close();
            comando.Connection.Close();

            return lcl_lst_mod_descuento;
        }


    }
}
