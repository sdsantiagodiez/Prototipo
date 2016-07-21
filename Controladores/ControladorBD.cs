using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Transactions;

namespace Controladores
{
    public class ControladorBD:Controlador
    {
        public bool backUpDatabase(string p_direccionCarpeta)
        {
            bool resp = false;
            try
            {
                using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Suppress))
                {

                    resp = Conexion.backUpDatabase(p_direccionCarpeta);
                    scope.Complete();
                }
            }
            catch (TransactionAbortedException ex)
            {
                errorActual = "TransactionAbortedException Message: " + ex.Message;
            }
            catch (ApplicationException ex)
            {
                errorActual = "ApplicationException Message: " + ex.Message;
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                errorActual = "SQLexception Message: " + ex.Message;
            }
            catch (Exception ex)
            {
                errorActual = ex.Message;
            }
            return resp;
        }

    }
}
