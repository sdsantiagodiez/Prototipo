using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelLib = Microsoft.Office.Interop.Excel;


namespace LibreriaClasesCompartidas
{
    public class ExportImport
    {
        ExcelLib._Worksheet glb_hojaTrabajo;
        public string ExportarAExcel(object p_lst_obj, string path)
        {
            // se inicia la aplicacion
            var ExcelApp = new ExcelLib.Application();
            //Se setea visible
            ExcelApp.Visible = true;
            //Se agrega una hoja de trabajo
            ExcelApp.Workbooks.Add();
            //Creamos una hoja y le asociamos la que esta activa en el documento
            glb_hojaTrabajo = (ExcelLib._Worksheet)ExcelApp.ActiveSheet;

            return "OK";
        }

        public void nombrarColumnas(object p_lst_obj)
        { 
            
            glb_hojaTrabajo.Cells[1, "A"] = "Nombre Columna 1";
            glb_hojaTrabajo.Cells[1, "B"] = "Nombre Columna 2";
        }

        public void completaFilas(object p_lst_obj)
        {
            var row = 1;
          //  foreach (List<ModeloPedido> obj in p_lst_obj)
           // {
                glb_hojaTrabajo.Cells[row, "A"] = "dato fila 1 col A";
                glb_hojaTrabajo.Cells[row, "B"] = "dato fila 1 col B";
          //  }
        }
        public void ajustarColumnas()
        {
            //Ajusta el ancho de las columnas
            glb_hojaTrabajo.Columns[1].AutoFit();
            glb_hojaTrabajo.Columns[1].AutoFit();
        }

    }
}
