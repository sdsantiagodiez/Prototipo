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
        //Quizás se podrían concentrar en un sólo método para todos los tipos de datos
        public SqlParameter instanciarParametro(string atributo, string nombreAtributo)
        {
            SqlParameter parametro = new SqlParameter();
            if (atributo == null)
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

        public SqlParameter instanciarParametro(int atributo, string nombreAtributo)
        {
            SqlParameter parametro = new SqlParameter();
            
            parametro = new SqlParameter(nombreAtributo, SqlDbType.Int);
            parametro.Value = atributo;
            return parametro;
        }

        public SqlParameter instanciarParametro(decimal atributo, string nombreAtributo)
        {
            SqlParameter parametro = new SqlParameter(); 
            
            parametro = new SqlParameter(nombreAtributo, SqlDbType.Decimal);
            parametro.Value = atributo;
            return parametro;
        }

        public SqlParameter instanciarParametro(DateTime atributo, string nombreAtributo)
        {
            SqlParameter parametro = new SqlParameter();
            if (atributo == null)
            {
                parametro = new SqlParameter(nombreAtributo, DBNull.Value);
            }
            else
            {
                parametro = new SqlParameter(nombreAtributo, SqlDbType.Date);
                parametro.Value = atributo.Date;
            }
            return parametro;
        }
    }
}
