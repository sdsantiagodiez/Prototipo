using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Datos
{
    public class Catalogo
    {
        #region Instanciar parametro SQL
        //Quizás se podrían concentrar en un sólo método para todos los tipos de datos
        protected SqlParameter instanciarParametro(string atributo, string nombreAtributo)
        {
            SqlParameter parametro = new SqlParameter();
            if (atributo == null || atributo.Trim()=="")
            {
                parametro = new SqlParameter(nombreAtributo, DBNull.Value);
            }
            else
            {
                parametro = new SqlParameter(nombreAtributo, SqlDbType.VarChar);
                parametro.Value = atributo;
            }
            return parametro;
        }

        protected SqlParameter instanciarParametro(int atributo, string nombreAtributo)
        {
            SqlParameter parametro = new SqlParameter();
            
            parametro = new SqlParameter(nombreAtributo, SqlDbType.Int);
            parametro.Value = atributo;
            return parametro;
        }
        protected SqlParameter instanciarParametro(int? atributo, string nombreAtributo)
        {
            SqlParameter parametro = new SqlParameter();

            if (atributo == null)
            {
                parametro = new SqlParameter(nombreAtributo, DBNull.Value);
            }
            else
            {
                parametro = new SqlParameter(nombreAtributo, SqlDbType.Int);
                parametro.Value = atributo.Value;
            }
            return parametro;
        }

        protected SqlParameter instanciarParametro(decimal atributo, string nombreAtributo)
        {
            SqlParameter parametro = new SqlParameter(); 
            
            parametro = new SqlParameter(nombreAtributo, SqlDbType.Decimal);
            parametro.Value = atributo;
            return parametro;
        }

        protected SqlParameter instanciarParametro(decimal? atributo, string nombreAtributo)
        {
            SqlParameter parametro = new SqlParameter();

            if (atributo == null)
            {
                parametro = new SqlParameter(nombreAtributo, DBNull.Value);
            }
            else
            {
                parametro = new SqlParameter(nombreAtributo, SqlDbType.Decimal);
                parametro.Value = atributo.Value;
            }
            return parametro;
        }

        protected SqlParameter instanciarParametro(DateTime atributo, string nombreAtributo)
        {
            SqlParameter parametro = new SqlParameter();
            if (atributo == null)
            {
                parametro = new SqlParameter(nombreAtributo, DBNull.Value);
            }
            else
            {
                parametro = new SqlParameter(nombreAtributo, SqlDbType.DateTime2);
                parametro.Value = atributo;
            }
            return parametro;
        }
        protected SqlParameter instanciarParametro(DateTime? atributo, string nombreAtributo)
        {
            SqlParameter parametro = new SqlParameter();
            if (atributo == null)
            {
                parametro = new SqlParameter(nombreAtributo, DBNull.Value);
            }
            else
            {
                parametro = new SqlParameter(nombreAtributo, SqlDbType.DateTime2);
                parametro.Value = atributo;
            }
            return parametro;
        }
        protected SqlParameter instanciarParametro(bool atributo, string nombreAtributo)
        {
            SqlParameter parametro = new SqlParameter();
            if (atributo == null)
            {
                parametro = new SqlParameter(nombreAtributo, DBNull.Value);
            }
            else
            {
                parametro = new SqlParameter(nombreAtributo, SqlDbType.Bit);
                parametro.Value = atributo;
            }
            return parametro;
        }
        #endregion

        /// <summary>
        /// permite inicializar substring para consulta sql 
        /// </summary>
        /// <param name="p_nombreParametro">Valor que luego es comparado con una celda de la tabla de datos</param>
        /// <param name="p_nombreParametroTabla">nombre de la columna en tabla de datos</param>
        /// <returns></returns>
        protected string parametroBusqueda(string p_nombreParametro, string p_nombreParametroTabla, string p_comparador)
        {
            return @" (" + p_nombreParametro + " IS NULL OR " + p_nombreParametroTabla + " " + p_comparador + " " + p_nombreParametro + " ) ";
        }

        protected string agregarComodinBusquedaLIKE(string p_valorBusqueda)
        {
            if (p_valorBusqueda == null)
            {
                return null;
            }
            else
            {
                return "%" + p_valorBusqueda + "%";
            }
        }

        /// <summary>
        /// Método base que devuelve todas las filas o ninguna de acuerdo a p_parametroBusqueda
        /// </summary>
        /// <param name="p_parametroBusqueda"></param>
        /// <returns></returns>
        protected string getCondicionBusqueda(string p_parametroBusqueda)
        {
            switch (p_parametroBusqueda)
            {
                case LibreriaClasesCompartidas.Constantes.ParametrosBusqueda.All:
                    //retorna true y devuelve todas las filas
                    return " 1 = 1 ";
                default:
                    //retorna false y no devuelve filas
                    return " 1 = 2 "; 
            }
        }
    }
}
