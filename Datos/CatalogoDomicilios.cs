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
    public class CatalogoDomicilios : Catalogo
    {
        //REVISAR VALIDAR EN ALGUN LADO QUE CALLE NO SEA NULL!!!!

        private ModeloDomicilio leerDatosDomicilio(SqlDataReader drDomicilios)
        {
            ModeloDomicilio modDomicilio = new ModeloDomicilio();

            modDomicilio.codigoDomicilio = (int)drDomicilios["codigo_domicilio"];
            //Si algún valor esta null en Base de datos, se asigna null en el objeto
            //Caso contrario hay una string, y se asigna string
            modDomicilio.calle = (drDomicilios["calle"] != DBNull.Value) ? (string)drDomicilios["calle"] : null;
            modDomicilio.numero = (drDomicilios["numero"] != DBNull.Value) ? (string)drDomicilios["numero"] : null;
            modDomicilio.departamento = (drDomicilios["departamento"] != DBNull.Value) ? (string)drDomicilios["departamento"] : null;
            modDomicilio.piso = (drDomicilios["piso"] != DBNull.Value) ? (string)drDomicilios["piso"] : null;
            modDomicilio.ciudad = (drDomicilios["ciudad"] != DBNull.Value) ? (string)drDomicilios["ciudad"] : null;
            modDomicilio.codigoPostal = (drDomicilios["codigo_postal"] != DBNull.Value) ? (string)drDomicilios["codigo_postal"] : null;
            modDomicilio.provincia = (drDomicilios["provincia"] != DBNull.Value) ? (string)drDomicilios["provincia"] : null;
            modDomicilio.pais = (drDomicilios["pais"] != DBNull.Value) ? (string)drDomicilios["pais"] : null;

            return modDomicilio;
        }
        public List<ModeloDomicilio> getDomicilios(int codigoEntidad)
        {
            List<ModeloDomicilio> domicilios = new List<ModeloDomicilio>();

            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText =
                "SELECT "+
                "[domicilios_entidad].codigo_domicilio,[domicilios_entidad].calle,[domicilios_entidad].numero,[domicilios_entidad].piso, "+
                "[domicilios_entidad].departamento, [domicilios_entidad].ciudad,[domicilios_entidad].codigo_postal,[provincias].provincia,[paises].pais " +
                    "FROM [domicilios_entidad] " +
                    "INNER JOIN [provincias] on [provincias].codigo_provincia = [domicilios_entidad].codigo_provincia " +
                    "INNER JOIN [paises] on [paises].codigo = [provincias].codigo_pais " +
                    "WHERE ([domicilios_entidad].codigo_entidad = @codigo_entidad)";

            comando.Parameters.Add(new SqlParameter("@codigo_entidad", SqlDbType.Int));
            comando.Parameters["@codigo_entidad"].Value = codigoEntidad;

            comando.Connection.Open();

            SqlDataReader drDomicilios = comando.ExecuteReader();

            ModeloDomicilio modDomicilio = new ModeloDomicilio();

            while (drDomicilios.Read())
            {
                modDomicilio = new ModeloDomicilio();
                modDomicilio = this.leerDatosDomicilio(drDomicilios);
                domicilios.Add(modDomicilio);
            }
            drDomicilios.Close();

            comando.Connection.Close();

            return domicilios;
        }
        
        #region ALTA/BAJA/MODIFICACIÓN domicilios
        /*
         * True si se realizó correctamente
         * False si ocurrió algún error
         */
        public bool agregarNuevaEntidad(ModeloDomicilio pmDomicilio, int pCodigoEntidad)
        {
            CatalogoProvincias cProv = new CatalogoProvincias();
            string codigoProvincia = cProv.getCodigoProvinciaPorNombre(pmDomicilio.provincia);
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText =
                "INSERT INTO [domicilios_entidad] ([codigo_entidad], [calle], [numero], [piso], [departamento], [ciudad], [codigo_postal], [codigo_provincia]) " +
                "VALUES (@codigo_entidad, @calle, @numero, @piso, @departamento, @ciudad, @codigo_postal, @codigo_provincia)";
            //Indica los parametros
            comando.Parameters.Add(this.instanciarParametro(pCodigoEntidad, "@codigo_entidad"));
            comando.Parameters.Add(this.instanciarParametro(pmDomicilio.calle, "@calle"));
            comando.Parameters.Add(this.instanciarParametro(pmDomicilio.numero , "@numero"));
            comando.Parameters.Add(this.instanciarParametro(pmDomicilio.piso, "@piso"));
            comando.Parameters.Add(this.instanciarParametro(pmDomicilio.departamento, "@departamento"));
            comando.Parameters.Add(this.instanciarParametro(pmDomicilio.ciudad, "@ciudad"));
            comando.Parameters.Add(this.instanciarParametro(pmDomicilio.codigoPostal, "@codigo_postal"));
            comando.Parameters.Add(this.instanciarParametro(codigoProvincia, "@codigo_provincia"));
            

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

        public bool actualizarEntidad(ModeloDomicilio pmDomicilio)
        {
            CatalogoProvincias cProv = new CatalogoProvincias();
            string codigoProvinciaActual = cProv.getCodigoProvinciaPorNombre(pmDomicilio.provincia);

            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText =
                "UPDATE [domicilios_entidad] SET [calle]=@calle,[numero]=@numero, [piso]=@piso," +
                "[departamento]=@departamento,[ciudad]=@ciudad, [codigo_postal]=@codigo_postal, [codigo_provincia]=@codigo_provincia " +
                "WHERE [codigo_domicilio]=@codigo_domicilio";

            comando.Parameters.Add(this.instanciarParametro(pmDomicilio.codigoDomicilio, "@codigo_domicilio"));
            comando.Parameters.Add(this.instanciarParametro(pmDomicilio.calle, "@calle"));
            comando.Parameters.Add(this.instanciarParametro(pmDomicilio.numero, "@numero"));
            comando.Parameters.Add(this.instanciarParametro(pmDomicilio.piso, "@piso"));
            comando.Parameters.Add(this.instanciarParametro(pmDomicilio.departamento, "@departamento"));
            comando.Parameters.Add(this.instanciarParametro(pmDomicilio.ciudad, "@ciudad"));
            comando.Parameters.Add(this.instanciarParametro(pmDomicilio.codigoPostal, "@codigo_postal"));
            comando.Parameters.Add(this.instanciarParametro(codigoProvinciaActual, "@codigo_provincia"));
            
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

        public bool bajaEntidad(ModeloDomicilio pmDomicilio)
        {
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText =
                "DELETE FROM [domicilios_entidad] " +
                    "WHERE [domicilios_entidad].codigo_domicilio = @codigo_domicilio ";

            comando.Parameters.Add(this.instanciarParametro(pmDomicilio.codigoDomicilio, "@codigo_domicilio"));

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
