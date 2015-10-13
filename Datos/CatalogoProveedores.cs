﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class CatalogoProveedores : CatalogoEntidades
    {
        public bool validarDatos(ModeloProveedor proveedor)
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
        public bool existeEntidad(int codigoEntidad)
        {
            bool respuesta = false;
            if (getOne(codigoEntidad) != null)
            {
                respuesta = true;
            }
            return respuesta;
        }

        private ModeloProveedor leerDatosProveedor(SqlDataReader drProveedores)
        {
            ModeloProveedor modProv = new ModeloProveedor();

            modProv.codigo = (int)drProveedores["codigo"];
            //Si algún valor esta null en Base de datos, se asigna null en el objeto
            //Caso contrario hay una string, y se asigna string
            modProv.razonSocial = (drProveedores["razon_social"] != DBNull.Value) ? (string)drProveedores["razon_social"] : null;

            modProv.cuit = (drProveedores["cuit"] != DBNull.Value) ? (string)drProveedores["cuit"] : null;
            modProv.tipoEntidad = (drProveedores["tipo_entidad"] != DBNull.Value) ? (string)drProveedores["tipo_entidad"] : null;
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
        public List<ModeloProveedor> buscarProveedores(string tipoParametro, string descripcionParametro)
        {
            List<ModeloProveedor> listaProveedores = new List<ModeloProveedor>();

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

        private List<ModeloProveedor> buscarPorRazonSocial(string razonSocial)
        {
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText =
                "SELECT [entidades.codigo],[entidades.tipo_entidad],[entidades.cuit],[entidades.observaciones],[proveedores.razon_social]" +
                    "FROM [proveedores] " +
                    "INNER JOIN [entidades] on [entidades.codigo] = [proveedores.codigo_entidad]" +
                "WHERE LOWER([proveedores].razon_social) LIKE @razonSocial";
            comando.Parameters.Add(new SqlParameter("@razonSocial", SqlDbType.VarChar));
            comando.Parameters["@razonSocial"].Value = "%" + razonSocial.ToLower() + "%";
            comando.Connection.Open();

            SqlDataReader drProveedores = comando.ExecuteReader();

            ModeloProveedor modProveedor = new ModeloProveedor();
            List<ModeloProveedor> listaProveedores = new List<ModeloProveedor>();
            while (drProveedores.Read())
            {
                modProveedor = new ModeloProveedor();
                modProveedor = this.leerDatosProveedor(drProveedores);

                modProveedor.mails = this.getMails(modProveedor.codigo);
                modProveedor.telefonos = this.getTelefonos(modProveedor.codigo);
                modProveedor.domicilios = this.getDomicilios(modProveedor.codigo);

                listaProveedores.Add(modProveedor);
            }
            drProveedores.Close();

            comando.Connection.Close();

            return listaProveedores;
        }

        private List<ModeloProveedor> buscaPorCuit(string cuit)
        {
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText = 
               "SELECT [entidades.codigo],[entidades.tipo_entidad],[entidades.cuit],[entidades.observaciones],[proveedores.razon_social]" +
                    "FROM [proveedores] " +
                    "INNER JOIN [entidades] on [entidades.codigo] = [proveedores.codigo_entidad] " +
                    "WHERE [entidades.cuit] LIKE @cuit";
            comando.Parameters.Add(new SqlParameter("@cuit", SqlDbType.VarChar));
            comando.Parameters["@cuit"].Value = "%" + cuit + "%";
            comando.Connection.Open();


            ModeloProveedor modProveedor;
            SqlDataReader drProveedores = comando.ExecuteReader();
            List<ModeloProveedor> listaProveedores = new List<ModeloProveedor>();

            while (drProveedores.Read())
            {
                modProveedor = new ModeloProveedor();
                modProveedor = this.leerDatosProveedor(drProveedores);

                modProveedor.mails = this.getMails(modProveedor.codigo);
                modProveedor.telefonos = this.getTelefonos(modProveedor.codigo);
                modProveedor.domicilios = this.getDomicilios(modProveedor.codigo);

                listaProveedores.Add(modProveedor);
            }

            drProveedores.Close();
            comando.Connection.Close();

            return listaProveedores;
        }
        #endregion

        public ModeloProveedor getOnePorCodigo(int codigoEntidad)
        {
            ModeloProveedor modProveedor = null;
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();
            comando.Connection = ConexionSQL;
            comando.CommandType = CommandType.Text;
            comando.CommandText =
               "SELECT [entidades.codigo],[entidades.tipo_entidad],[entidades.cuit],[entidades.observaciones],[proveedores.razon_social]" +
                    "FROM [proveedores] " +
                    "INNER JOIN [entidades] on [entidades.codigo] = [proveedores.codigo_entidad]" +
                    "WHERE [entidades].codigo = @codigo";
            comando.Parameters.Add(new SqlParameter("@codigo", SqlDbType.Int));
            comando.Parameters["@codigo"].Value = codigoEntidad;
            comando.Connection.Open();

            SqlDataReader drEntidades = comando.ExecuteReader();

            while (drEntidades.Read())
            {
                modProveedor = new ModeloProveedor();
                modProveedor = this.leerDatosProveedor(drEntidades);
            }
            drEntidades.Close();
            comando.Connection.Close();

            modProveedor.mails = this.getMails(modProveedor.codigo);
            modProveedor.telefonos = this.getTelefonos(modProveedor.codigo);
            modProveedor.domicilios = this.getDomicilios(modProveedor.codigo);

            return modProveedor;
        }
       
        public new List<ModeloProveedor> getAll()
        {
            List<ModeloProveedor> allProvs = new List<ModeloProveedor>();
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();

            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType = CommandType.Text;

            comando.CommandText =
                "SELECT [entidades.codigo],[entidades.tipo_entidad],[entidades.cuit],[entidades.observaciones],[proveedores.razon_social]" +
                    "FROM [proveedores] " +
                    "INNER JOIN [entidades] on [entidades.codigo] = [proveedores.codigo_entidad]";

            comando.Connection.Open();
            ModeloProveedor modProveedor;
            SqlDataReader drProveedores = comando.ExecuteReader();
            while (drProveedores.Read())
            {
                modProveedor = new ModeloProveedor();
                modProveedor = this.leerDatosProveedor(drProveedores);

                modProveedor.mails = this.getMails(modProveedor.codigo);
                modProveedor.telefonos = this.getTelefonos(modProveedor.codigo);
                modProveedor.domicilios = this.getDomicilios(modProveedor.codigo);

                allProvs.Add(modProveedor);
            }
            drProveedores.Close();

            comando.Connection.Close();

            return allProvs;
        }

        public new List<ModeloMail> getMails(int codigoEntidad)
        {
            return base.getMails(codigoEntidad);
        }

        public new List<ModeloDomicilio> getDomicilios(int codigoEntidad)
        {
            return base.getDomicilios(codigoEntidad);
        }

        public new List<ModeloTelefono> getTelefonos(int codigoEntidad)
        {
            return base.getTelefonos(codigoEntidad);
        }

        #region Alta/Baja/Modificación
        /*
         * True si se realizó correctamente
         * False si ocurrió algún error
         */
        public override bool agregarNuevaEntidad(ModeloProveedor pModProv)
        {
            //*REVISAR (validar existencia a traves de codigo de una entidad que puede no tener código?)
            if (!this.existeEntidad(pModProv.codigo))
            {

                base.agregarNuevaEntidad(pModProv);
                //Creo la conexion y la abro
                SqlConnection ConexionSQL = Conexion.crearConexion();

                //crea SQL command
                SqlCommand comando = new SqlCommand();

                comando.Connection = ConexionSQL;

                comando.CommandType = CommandType.Text;

                comando.CommandText =
                    "INSERT INTO [Proveedores] ([codigo_entidad], [razonSocial]) "+
                    "VALUES (IDENT_CURRENT('entidades'), @razonSocial)";
                //Indica los parametros
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
            else
            {
                return false;
            }
        }     

        //No se podrá modificar razonSocial
        public bool actualizarEntidad(ModeloProveedor pModProv)
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
            /*REVISAR
             * comando.Parameters.Add(this.instanciarParametro(pModProv.direccion, "@direccion"));
            comando.Parameters.Add(this.instanciarParametro(pModProv.ciudad, "@ciudad"));
            comando.Parameters.Add(this.instanciarParametro(pModProv.provincia, "@provincia"));
            comando.Parameters.Add(this.instanciarParametro(pModProv.codigoPostal, "@codigoPostal"));
            comando.Parameters.Add(this.instanciarParametro(pModProv.observaciones, "@observaciones"));
            */
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

        public bool bajaEntidad(ModeloProveedor pModProv)
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

