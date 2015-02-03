﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data.SqlClient;
using System.Data;

namespace Datos
{
    public class CatalogoArticulos
    {

        public bool validarDatos(string[] pDatos)
        {
            // Validar si los datos son correctos?
            return true;
        }

        public bool existeEntidad(string[] pDatos)
        {
            // Se crea la variable a retornar
            bool respuesta = false;
            //Creamos la lista de todos los Articulos
            List<ModeloArticulos> listArt = this.getAll();
            
            foreach (ModeloArticulos modArt in listArt)
            {
                if (pDatos[1] == modArt.codigoOriginalArt)// Se busca si el articulo ya existe comparando el codigo original
                {
                    respuesta = true;
                    break;
                }
                else { respuesta = false; }

            }

            return respuesta;
        }

        public List<ModeloArticulos> getAll()
        { 
            List<ModeloArticulos>allArts = new List<ModeloArticulos>();
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();
            
            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType= CommandType.Text;

            comando.CommandText = "SELECT [codigoOriginalArt],[descripArt],[modelosArt],[obsArt] FROM [proyecto].[dbo].[articulos]";

            comando.Connection.Open();

            SqlDataReader drArticulos = comando.ExecuteReader();
            while (drArticulos.Read())
            {
                ModeloArticulos modArt = new ModeloArticulos();
                modArt.codigoOriginalArt = (string)drArticulos["codigoOriginalArt"];
                modArt.descripArt = (string)drArticulos["descripArt"];
                modArt.modelosArt = (string)drArticulos["modelosArt"];
                modArt.obsArt = (string)drArticulos["obsArt"];
                allArts.Add(modArt);
            }
            drArticulos.Close();

            comando.Connection.Close();

            return allArts;
        }

        public void agregarNuevaEntidad(ModeloArticulos pModArt)
        { 
            //Creo la conexion y la abro
            SqlConnection ConexionSQL = Conexion.crearConexion();
            
            //crea SQL command
            SqlCommand comando = new SqlCommand();

            comando.Connection = ConexionSQL;

            comando.CommandType= CommandType.Text;

            comando.CommandText = "INSERT INTO [proyecto].[dbo].[articulos]([descripArt],[modelosArt],[obsArt])VALUES (@descripArt, @modelosArt, @obsArt)";
            //Indica los parametros
            comando.Parameters.Add(new SqlParameter("@descripArt", SqlDbType.NVarChar));
            comando.Parameters["@descripArt"].Value = pModArt.descripArt;
            comando.Parameters.Add(new SqlParameter("@modelosArt", SqlDbType.NVarChar));
            comando.Parameters["@modelosArt"].Value = pModArt.modelosArt;
            comando.Parameters.Add(new SqlParameter("@obsArt", SqlDbType.NVarChar));
            comando.Parameters["@obsArt"].Value = pModArt.obsArt;

            comando.Connection.Open();
            comando.ExecuteNonQuery();
            comando.Connection.Close();
        //Insertar un nuevo Articulo
        }
    }
}
