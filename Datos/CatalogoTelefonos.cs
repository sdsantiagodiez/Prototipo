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
    public class CatalogoTelefonos : Catalogo
    {
        private ModeloTelefono leerDatosTelefono(SqlDataReader drTelefonos)
        {
            ModeloTelefono lcl_mod_telefono = new ModeloTelefono();

            lcl_mod_telefono.codigoTelefono = (int)drTelefonos["codigo_telefono"];
            //Si algún valor esta null en Base de datos, se asigna null en el objeto
            //Caso contrario hay una string, y se asigna string
            lcl_mod_telefono.numero = (drTelefonos["numero"] != DBNull.Value) ? (string)drTelefonos["numero"] : null;
            lcl_mod_telefono.tipo = (drTelefonos["tipo"] != DBNull.Value) ? (string)drTelefonos["tipo"] : null;

            return lcl_mod_telefono;
        }
        public List<ModeloTelefono> getTelefonos(int codigoEntidad)
        {
            List<ModeloTelefono> lcl_lst_mod_telefonos = new List<ModeloTelefono>();
            SqlConnection ConexionSQL = Conexion.crearConexion();
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            
            comando.CommandText =
                "SELECT [telefonos_entidad].codigo_telefono,[telefonos_entidad].tipo,[telefonos_entidad].numero " +
                "   FROM [telefonos_entidad] " +
                "   WHERE ([telefonos_entidad].codigo_entidad = @codigo_entidad)";

            comando.Parameters.Add(this.instanciarParametro(codigoEntidad,"@codigo_entidad"));

            comando.Connection.Open();
            SqlDataReader drTelefonos = comando.ExecuteReader();
            ModeloTelefono lcl_mod_telefono = new ModeloTelefono();
            while (drTelefonos.Read())
            {
                lcl_mod_telefono = new ModeloTelefono();
                lcl_mod_telefono = this.leerDatosTelefono(drTelefonos);

                lcl_lst_mod_telefonos.Add(lcl_mod_telefono);
            }
            drTelefonos.Close();
            comando.Connection.Close();
            
            return lcl_lst_mod_telefonos;
        }
        
        #region Alta/Baja/Modificación
        public bool add(ModeloTelefono p_mod_telefono, int p_codigoEntidad)
        {
            string query =
                "INSERT INTO [telefonos_entidad] ([codigo_entidad],[numero],[tipo]) " +
                "   VALUES (@codigo_entidad, @numero, @tipo)";

            SqlCommand comando = new SqlCommand(query, Conexion.crearConexion());
                
            //Indica los parametros
            comando.Parameters.Add(this.instanciarParametro(p_codigoEntidad, "@codigo_entidad"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_telefono.numero, "@numero"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_telefono.tipo, "@tipo"));

            comando.Connection.Open();
            int rowaffected = comando.ExecuteNonQuery();
            comando.Connection.Close();

            if (rowaffected != 0)
            { return true; }
            else
            { return false; }
        }

        public bool update(ModeloTelefono p_mod_telefono)
        {
            string query =
                "UPDATE [telefonos_entidad] SET [tipo]=@tipo,[numero]=@numero " +
                "   WHERE [telefonos_entidad].codigo_telefono=@codigo_telefono";

            SqlCommand comando = new SqlCommand(query, Conexion.crearConexion());

            comando.Parameters.Add(this.instanciarParametro(p_mod_telefono.numero, "@numero"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_telefono.tipo, "@tipo"));

            comando.Connection.Open();
            int rowaffected = comando.ExecuteNonQuery();
            comando.Connection.Close();

            if (rowaffected != 0)
            { return true; }
            else
            { return false; }
        }

        public bool remove(ModeloTelefono p_mod_telefono)
        {
            string query =
                "DELETE FROM [telefonos_entidad] " +
                "   WHERE [telefonos_entidad].codigo_telefono=@codigo_telefono";

            SqlCommand comando = new SqlCommand(query, Conexion.crearConexion());

            comando.Parameters.Add(this.instanciarParametro(p_mod_telefono.codigoTelefono, "@codigo_telefono"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_telefono.tipo, "@tipo"));
            comando.Parameters.Add(this.instanciarParametro(p_mod_telefono.numero, "@numero"));

            comando.Connection.Open();
            int rowaffected = comando.ExecuteNonQuery();
            comando.Connection.Close();

            if (rowaffected != 0)
            { return true; }
            else
            { return false; }
        }
        #endregion
    }
}