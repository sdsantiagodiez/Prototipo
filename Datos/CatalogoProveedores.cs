using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class CatalogoProveedores : Catalogo
    {
        public bool validarDatos(ModeloProveedores proveedor)
        {
            //Valida que los parametros sean Validos en el dominio
            return true;
        }    

        /// <summary>
        /// determina existencia de proveedor de acuerdo a cuit y razonSocial ingresados
        /// </summary>
        /// <param name="cuit">cuit de proveedor</param>
        /// <param name="razonSocial">razón social de proveedor</param>
        /// <returns>true si existe, false si no existe</returns>
        public bool existeEntidad(string razonSocial)
        {
            bool respuesta = false;
            if (getOne(razonSocial) != null)
            {
                respuesta = true;
            }
            return respuesta;
        }

        private ModeloProveedores leerDatosProveedor(SqlDataReader drProveedores)
        {
            ModeloProveedores modProv = new ModeloProveedores();

            modProv.razonSocial = (string)drProveedores["razonSocial"];
            //Si algún valor esta null en Base de datos, se asigna null en el objeto
            //Caso contrario hay una string, y se asigna string
            modProv.cuit = (drProveedores["cuit"] != DBNull.Value) ? (string)drProveedores["cuit"] : null;
            modProv.direccion = (drProveedores["direccion"] != DBNull.Value) ? (string)drProveedores["direccion"] : null;
            modProv.ciudad = (drProveedores["ciudad"] != DBNull.Value) ? (string)drProveedores["ciudad"] : null;
            modProv.provincia = (drProveedores["provincia"] != DBNull.Value) ? (string)drProveedores["provincia"] : null;
            modProv.codigoPostal = (drProveedores["codigoPostal"] != DBNull.Value) ? (string)drProveedores["codigoPostal"] : null;
            modProv.observaciones = (drProveedores["observaciones"] != DBNull.Value) ? (string)drProveedores["observaciones"] : null;

            return modProv;
        }

        #region BuscarPorX
        /// <summary>
        /// busca proveedores de acuerdo a descripcionParametro ingresada
        /// </summary>
        /// <param name="tipoParametro">"razonSocial" o "cuit"</param>
        /// <param name="descripcionParametro">string por el que se buscará proveedores</param>
        /// <returns>lista de proveedores</returns>
        public List<ModeloProveedores> buscarProveedores(string tipoParametro, string descripcionParametro)
        {
            List<ModeloProveedores> listaProveedores = new List<ModeloProveedores>();

            switch(tipoParametro.ToLower())
            {
                case "razonsocial":
                    listaProveedores = buscarPorRazonSocial(descripcionParametro.ToLower());
                    break;
                case "cuit":
                    listaProveedores = buscaPorCuit(descripcionParametro);
                    break;
                default:
                    break;
            }
            return listaProveedores;
        }

        private List<ModeloProveedores> buscarPorRazonSocial(string razonSocial)
        {
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText = 
                "SELECT [razonSocial],[cuit],[direccion],[ciudad],[provincia],[codigoPostal],[observaciones]" +
                "FROM [proveedores]  " +
                "WHERE LOWER([proveedores].razonSocial) LIKE @razonSocial";
            comando.Parameters.Add(new SqlParameter("@razonSocial", SqlDbType.VarChar));
            comando.Parameters["@razonSocial"].Value = "%" + razonSocial.ToLower() + "%";
            comando.Connection.Open();

            SqlDataReader drProveedores = comando.ExecuteReader();

            ModeloProveedores modPro = new ModeloProveedores();
            List<ModeloProveedores> listaProveedores = new List<ModeloProveedores>();
            while (drProveedores.Read())
            {
                modPro = new ModeloProveedores();
                modPro = this.leerDatosProveedor(drProveedores);
                listaProveedores.Add(modPro);
            }
            drProveedores.Close();

            comando.Connection.Close();

            return listaProveedores;
        }

        private List<ModeloProveedores> buscaPorCuit(string cuit)
        {
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText = 
                "SELECT [razonSocial],[cuit],[direccion],[ciudad],[provincia],[codigoPostal],[observaciones]"+
                "FROM [proveedores] WHERE cuit LIKE @cuit";
            comando.Parameters.Add(new SqlParameter("@cuit", SqlDbType.VarChar));
            comando.Parameters["@cuit"].Value = "%" + cuit + "%";
            comando.Connection.Open();

            SqlDataReader drProveedores = comando.ExecuteReader();
            List<ModeloProveedores> listaProveedores = new List<ModeloProveedores>();

            while (drProveedores.Read())
            {
                ModeloProveedores modPro = new ModeloProveedores();
                modPro = this.leerDatosProveedor(drProveedores);
                listaProveedores.Add(modPro);
            }

            drProveedores.Close();
            comando.Connection.Close();

            return listaProveedores;
        }
        #endregion

        public ModeloProveedores getOne(string razonSocial)
        {
            ModeloProveedores modPro = null;
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText = 
                "SELECT [razonSocial],[cuit],[direccion],[ciudad],[provincia],[codigoPostal],[observaciones] "+
                "FROM [proveedores]  "+
                "WHERE LOWER([proveedores].razonSocial)=@razonSocial";
            comando.Parameters.Add(new SqlParameter("@razonSocial", SqlDbType.VarChar));
            comando.Parameters["@razonSocial"].Value = razonSocial.ToLower();
            comando.Connection.Open();

            SqlDataReader drProveedores = comando.ExecuteReader();

            while (drProveedores.Read())
            {
                modPro = new ModeloProveedores();
                modPro = this.leerDatosProveedor(drProveedores);

            }
            drProveedores.Close();
            comando.Connection.Close();

            return modPro;

        }
       
        public List<ModeloProveedores> getAll()
        {
            List<ModeloProveedores> allProvs = new List<ModeloProveedores>();
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText = 
                "SELECT [razonSocial],[cuit],[direccion],[ciudad],[provincia],[codigoPostal],[observaciones] "+
                "FROM [proveedores]";

            comando.Connection.Open();

            SqlDataReader drProveedores = comando.ExecuteReader();
            while (drProveedores.Read())
            {
                ModeloProveedores modPro = new ModeloProveedores();
                modPro = this.leerDatosProveedor(drProveedores);
                allProvs.Add(modPro);
            }
            drProveedores.Close();

            comando.Connection.Close();

            return allProvs;
        }
       
        #region Alta/Baja/Modificación
        /*
         * True si se realizó correctamente
         * False si ocurrió algún error
         */
        public bool agregarNuevaEntidad(ModeloProveedores pModProv)
        {
            if (!this.existeEntidad(pModProv.razonSocial))
            {
                //Creo la conexion y la abro
                SqlConnection ConexionSQL = Conexion.crearConexion();

                //crea SQL command
                SqlCommand comando = new SqlCommand();

                comando.Connection = ConexionSQL;

                comando.CommandType = CommandType.Text;

                comando.CommandText =
                    "INSERT INTO [Proveedores] ([razonSocial],[cuit],[direccion],[ciudad],[provincia],[codigoPostal],[observaciones]) " +
                    "VALUES (@razonSocial, @cuit, @direccion, @ciudad, @provincia, @codigoPostal,@observaciones)";
                //Indica los parametros

                comando.Parameters.Add(this.instanciarParametro(pModProv.razonSocial, "@razonSocial"));
                comando.Parameters.Add(this.instanciarParametro(pModProv.cuit, "@cuit"));
                comando.Parameters.Add(this.instanciarParametro(pModProv.direccion, "@direccion"));
                comando.Parameters.Add(this.instanciarParametro(pModProv.ciudad, "@ciudad"));
                comando.Parameters.Add(this.instanciarParametro(pModProv.codigoPostal, "@codigoPostal"));
                comando.Parameters.Add(this.instanciarParametro(pModProv.provincia, "@provincia"));
                comando.Parameters.Add(this.instanciarParametro(pModProv.observaciones, "@observaciones"));

                //Insertar un nuevo Proveedor
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

        //No se podrá modificar razonSocial
        public bool actualizarEntidad(ModeloProveedores pModProv)
        {
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText = 
                "UPDATE [proveedores] SET [cuit] = @cuit, [direccion]=@direccion, "+
                "[ciudad]=@ciudad, [provincia]=@provincia, [codigoPostal] = @codigoPostal, [observaciones] = @observaciones "+
                "WHERE [proveedores].razonSocial=@razonSocial";

            comando.Parameters.Add(this.instanciarParametro(pModProv.razonSocial, "@razonSocial"));
            comando.Parameters.Add(this.instanciarParametro(pModProv.cuit, "@cuit"));
            comando.Parameters.Add(this.instanciarParametro(pModProv.direccion, "@direccion"));
            comando.Parameters.Add(this.instanciarParametro(pModProv.ciudad, "@ciudad"));
            comando.Parameters.Add(this.instanciarParametro(pModProv.provincia, "@provincia"));
            comando.Parameters.Add(this.instanciarParametro(pModProv.codigoPostal, "@codigoPostal"));
            comando.Parameters.Add(this.instanciarParametro(pModProv.observaciones, "@observaciones"));

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

        public bool bajaEntidad(ModeloProveedores pModProv)
        {
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText = 
                "DELETE FROM [proveedores] WHERE [proveedores].razonSocial=@razonSocial";

            comando.Parameters.Add(this.instanciarParametro(pModProv.razonSocial, "@razonSocial"));

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

