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

        private ModeloDomicilio leerDatosDomicilio(SqlDataReader p_drDomicilios)
        {
            ModeloDomicilio lcl_mod_domicilio = new ModeloDomicilio();

            lcl_mod_domicilio.codigoDomicilio = (int)p_drDomicilios["codigo_domicilio"];
            //Si algún valor esta null en Base de datos, se asigna null en el objeto
            //Caso contrario hay una string, y se asigna string
            lcl_mod_domicilio.calle = (p_drDomicilios["calle"] != DBNull.Value) ? (string)p_drDomicilios["calle"] : null;
            lcl_mod_domicilio.numero = (p_drDomicilios["numero"] != DBNull.Value) ? (string)p_drDomicilios["numero"] : null;
            lcl_mod_domicilio.departamento = (p_drDomicilios["departamento"] != DBNull.Value) ? (string)p_drDomicilios["departamento"] : null;
            lcl_mod_domicilio.piso = (p_drDomicilios["piso"] != DBNull.Value) ? (string)p_drDomicilios["piso"] : null;
            lcl_mod_domicilio.ciudad = (p_drDomicilios["ciudad"] != DBNull.Value) ? (string)p_drDomicilios["ciudad"] : null;
            lcl_mod_domicilio.codigoPostal = (p_drDomicilios["codigo_postal"] != DBNull.Value) ? (string)p_drDomicilios["codigo_postal"] : null;
            lcl_mod_domicilio.provincia.codigo = (p_drDomicilios["codigo_provincia"] != DBNull.Value) ? (string)p_drDomicilios["codigo_provincia"] : null;
            lcl_mod_domicilio.provincia.provincia = (p_drDomicilios["provincia"] != DBNull.Value) ? (string)p_drDomicilios["provincia"] : null;
            lcl_mod_domicilio.pais.codigo = (p_drDomicilios["codigo_pais"] != DBNull.Value) ? (string)p_drDomicilios["codigo_pais"] : null;
            lcl_mod_domicilio.pais.pais = (p_drDomicilios["pais"] != DBNull.Value) ? (string)p_drDomicilios["pais"] : null;
            lcl_mod_domicilio.provincia.codigoPais = lcl_mod_domicilio.pais.codigo;

            return lcl_mod_domicilio;
        }
        public List<ModeloDomicilio> getDomicilios(int codigoEntidad)
        {
            List<ModeloDomicilio> lcl_lst_mod_domicilio = new List<ModeloDomicilio>();
            SqlConnection ConexionSQL = Conexion.crearConexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText =
                "SELECT "+
                "[domicilios_entidad].codigo_domicilio,[domicilios_entidad].calle,[domicilios_entidad].numero,[domicilios_entidad].piso, "+
                "[domicilios_entidad].departamento, [domicilios_entidad].ciudad,[domicilios_entidad].codigo_postal, "+
                "[provincias].provincia, [provincias].codigo_provincia,[paises].pais, [paises].codigo as codigo_pais " +
                "   FROM [domicilios_entidad] " +
                "   INNER JOIN [provincias] on [provincias].codigo_provincia = [domicilios_entidad].codigo_provincia " +
                "   INNER JOIN [paises] on [paises].codigo = [provincias].codigo_pais " +
                "   WHERE ([domicilios_entidad].codigo_entidad = @codigo_entidad)";

            comando.Parameters.Add(this.instanciarParametro(codigoEntidad,"@codigo_entidad"));
            comando.Connection.Open();
            SqlDataReader drDomicilios = comando.ExecuteReader();
            ModeloDomicilio lcl_mod_domicilio = new ModeloDomicilio();

            while (drDomicilios.Read())
            {
                lcl_mod_domicilio = new ModeloDomicilio();
                lcl_mod_domicilio = this.leerDatosDomicilio(drDomicilios);
                lcl_lst_mod_domicilio.Add(lcl_mod_domicilio);
            }
            drDomicilios.Close();
            comando.Connection.Close();

            return lcl_lst_mod_domicilio;
        }
        
        #region Alta/Baja/Modificación
        public bool add(ModeloDomicilio p_mod_domicilio, int p_codigoEntidad)
        {
            string query =
               "INSERT INTO [domicilios_entidad] ([codigo_entidad], [calle], [numero], [piso], [departamento], [ciudad], [codigo_postal], [codigo_provincia]) " +
               "    VALUES (@codigo_entidad, @calle, @numero, @piso, @departamento, @ciudad, @codigo_postal, @codigo_provincia)";

            SqlCommand comando = new SqlCommand(query, Conexion.crearConexion());
                
            //Indica los parametros
            comando.Parameters.Add(this.instanciarParametro(p_codigoEntidad, "@codigo_entidad"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_domicilio.calle, "@calle"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_domicilio.numero, "@numero"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_domicilio.piso, "@piso"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_domicilio.departamento, "@departamento"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_domicilio.ciudad, "@ciudad"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_domicilio.codigoPostal, "@codigo_postal"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_domicilio.provincia.codigo, "@codigo_provincia"));
            
            comando.Connection.Open();
            int rowaffected = comando.ExecuteNonQuery();
            comando.Connection.Close();

            if (rowaffected != 0)
            {return true;}
            else
            {return false;}
        }

        public bool update(ModeloDomicilio p_mod_domicilio)
        {
            string query =
               "UPDATE [domicilios_entidad] SET [calle]=@calle,[numero]=@numero, [piso]=@piso," +
               "    [departamento]=@departamento,[ciudad]=@ciudad, [codigo_postal]=@codigo_postal, [codigo_provincia]=@codigo_provincia " +
               "    WHERE [codigo_domicilio]=@codigo_domicilio";

            SqlCommand comando = new SqlCommand(query, Conexion.crearConexion());

            comando.Parameters.Add(this.instanciarParametro(p_mod_domicilio.codigoDomicilio, "@codigo_domicilio"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_domicilio.calle, "@calle"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_domicilio.numero, "@numero"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_domicilio.piso, "@piso"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_domicilio.departamento, "@departamento"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_domicilio.ciudad, "@ciudad"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_domicilio.codigoPostal, "@codigo_postal"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_domicilio.provincia.codigo, "@codigo_provincia"));
            
            comando.Connection.Open();
            int rowaffected = comando.ExecuteNonQuery();
            comando.Connection.Close();

            if (rowaffected != 0)
            { return true;}
            else
            {return false;}
        }

        public bool remove(ModeloDomicilio p_mod_domicilio)
        {
            string query =
                "DELETE FROM [domicilios_entidad] " +
                "   WHERE [domicilios_entidad].codigo_domicilio = @codigo_domicilio ";
            
            SqlCommand comando = new SqlCommand(query, Conexion.crearConexion());
    
            comando.Parameters.Add(this.instanciarParametro(p_mod_domicilio.codigoDomicilio, "@codigo_domicilio"));

            comando.Connection.Open();
            int rowaffected = comando.ExecuteNonQuery();
            comando.Connection.Close();

            if (rowaffected != 0)
            {return true;}
            else
            {return false;}
        }
            
        #endregion
    }
}
