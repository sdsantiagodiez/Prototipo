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
            ModeloTelefono modTelefono = new ModeloTelefono();

            modTelefono.codigoTelefono = (int)drTelefonos["codigo_telefono"];
            //Si algún valor esta null en Base de datos, se asigna null en el objeto
            //Caso contrario hay una string, y se asigna string
            modTelefono.numero = (drTelefonos["numero"] != DBNull.Value) ? (string)drTelefonos["numero"] : null;
            modTelefono.tipo = (drTelefonos["tipo"] != DBNull.Value) ? (string)drTelefonos["tipo"] : null;

            return modTelefono;
        }
        public List<ModeloTelefono> getTelefonos(int codigoEntidad)
        {
            List<ModeloTelefono> telefonos = new List<ModeloTelefono>();

            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText =
                "SELECT [telefonos_entidad.codigo_telefono],[telefonos_entidad.tipo],[telefonos_entidad.numero] " +
                    "FROM [telefonos_entidad] " +
                    "WHERE ([telefonos_entidad.codigo_entidad] = @codigo_entidad)";

            comando.Parameters.Add(new SqlParameter("@codigo_entidad", SqlDbType.Int));
            comando.Parameters["@codigo_entidad"].Value = codigoEntidad;

            comando.Connection.Open();

            SqlDataReader drTelefonos = comando.ExecuteReader();

            ModeloTelefono modTelefono = new ModeloTelefono();

            while (drTelefonos.Read())
            {
                modTelefono = new ModeloTelefono();
                modTelefono = this.leerDatosTelefono(drTelefonos);

                telefonos.Add(modTelefono);
            }
            drTelefonos.Close();

            comando.Connection.Close();

            return telefonos;
        }
        #region ALTA/BAJA/MODIFICACIÓN telefonos
        /*
         * True si se realizó correctamente
         * False si ocurrió algún error
         */
        public bool agregarNuevaEntidad(ModeloTelefono pmTelefono, int pCodigoEntidad)
        {
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText =
                "INSERT INTO [telefonos_entidad] ([codigo_entidad],[numero],[tipo]) " +
                "VALUES (@codigo_entidad, @numero, @tipo)";
            //Indica los parametros
            comando.Parameters.Add(this.instanciarParametro(pCodigoEntidad, "@codigo_entidad"));
            comando.Parameters.Add(this.instanciarParametro(pmTelefono.numero, "@numero"));
            comando.Parameters.Add(this.instanciarParametro(pmTelefono.tipo, "@tipo"));


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

        public bool actualizarEntidad(ModeloTelefono pmTelefono)
        {
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText =
                "UPDATE [telefonos_entidad] SET [tipo]=@tipo,[numero]=@numero " +
                "WHERE [telefonos_entidad].codigo_telefono=@codigo_telefono";

            comando.Parameters.Add(this.instanciarParametro(pmTelefono.numero, "@numero"));
            comando.Parameters.Add(this.instanciarParametro(pmTelefono.tipo, "@tipo"));

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
        
        public bool bajaEntidad(ModeloTelefono pModTelefono)
        {
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText =
                "DELETE FROM [telefonos_entidad] " +
                    "WHERE [telefonos_entidad].codigo_telefono=@codigo_telefono";

            comando.Parameters.Add(this.instanciarParametro(pModTelefono.codigoTelefono, "@codigo_telefono"));
            comando.Parameters.Add(this.instanciarParametro(pModTelefono.tipo , "@tipo"));
            comando.Parameters.Add(this.instanciarParametro(pModTelefono.numero , "@numero"));

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