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
                "SELECT [domicilios_entidad.calle],[domicilios_entidad.numero],[domicilios_entidad.piso],[domicilios_entidad.departamento], " +
                "[domicilios_entidad.ciudad],[domicilios_entidad.codigo_postal],[provincias.provincia],[paises.pais]" +
                    "FROM [domicilios_entidad] " +
                    "INNER JOIN [provincias] on [provincias.codigo_provincia] = [domicilios_entidad.codigo_provincia]" +
                    "INNER JOIN [paises] on [paises.codigo] = [provincias.codigo_pais]" +
                    "WHERE ([domicilios_entidad.codigo_entidad] = @codigo_entidad)";

            comando.Parameters.Add(new SqlParameter("@codigo_entidad", SqlDbType.Int));
            comando.Parameters["@codigo_entidad"].Value = codigoEntidad;

            comando.Connection.Open();

            SqlDataReader drDomicilios = comando.ExecuteReader();

            ModeloDomicilio modDomicilio = new ModeloDomicilio();

            while (drDomicilios.Read())
            {
                modDomicilio.calle = (string)drDomicilios["calle"];
                modDomicilio.numero = (string)drDomicilios["numero"];
                modDomicilio.piso = (string)drDomicilios["piso"];
                modDomicilio.departamento = (string)drDomicilios["departamento"];
                modDomicilio.ciudad = (string)drDomicilios["ciudad"];
                modDomicilio.codigoPostal = (string)drDomicilios["codigo_postal"];
                modDomicilio.provincia = (string)drDomicilios["provincia"];
                modDomicilio.pais = (string)drDomicilios["pais"];
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
        public bool agregarDomicilios(ModeloDomicilio pmDomicilio, int pCodigoEntidad)
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
        #endregion
    }
}
