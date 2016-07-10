using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelLib = Microsoft.Office.Interop.Excel;
using Modelos;


namespace Controladores
{
    public class ControladorExcel
    {
        public class CatalogoExcel
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

            public void aExcel(object p_objeto)
            {
                Type T = p_objeto.GetType();
                IEnumerable<object> lcl_ienum_objeto;
                if (T == typeof(ModeloArticuloProveedores))
                {
                    this.completarColumnasArticuloProveedor();
                    lcl_ienum_objeto = ControladorBusqueda.buscar(p_objeto as ModeloArticuloProveedores);

                }
                else if (T == typeof(ModeloArticulos))
                {
                    lcl_ienum_objeto = ControladorBusqueda.buscar(p_objeto as ModeloArticulos);
                }
                else if (T == typeof(ModeloCliente))
                {
                    lcl_ienum_objeto = ControladorBusqueda.buscar(p_objeto as ModeloCliente);
                }
                else if (T == typeof(ModeloProveedor))
                {
                    lcl_ienum_objeto = ControladorBusqueda.buscar(p_objeto as ModeloProveedor);
                }
                else if (T == typeof(ModeloDescuentoArticulo))
                {
                    lcl_ienum_objeto = ControladorBusqueda.buscar(p_objeto as ModeloDescuentoArticulo);
                }

            }

            private void completarColumnasArticuloProveedor()
            {
                glb_hojaTrabajo.Cells[1, "A"] = "Codigo Original";
                glb_hojaTrabajo.Cells[1, "B"] = "Codigo Articulo Proveedor";
                glb_hojaTrabajo.Cells[1, "C"] = "Codigo Entidad";
                glb_hojaTrabajo.Cells[1, "D"] = "Descripcion ArticuloProveedor";
                glb_hojaTrabajo.Cells[1, "E"] = "Observaciones";
                glb_hojaTrabajo.Cells[1, "F"] = "Stock Minimo";
                glb_hojaTrabajo.Cells[1, "G"] = "Stock Actual";
                glb_hojaTrabajo.Cells[1, "H"] = "Ubicacion";
                glb_hojaTrabajo.Cells[1, "I"] = "Valor Compra";
                glb_hojaTrabajo.Cells[1, "J"] = "Valor Venta";

            }
            private void completarColumnasArticulo()
            {
                

            }
            private void completarColumnasCliente()
            {
                

            }
            private void completarColumnasProveedor()
            {
                
            }
            private void completarColumnasDescuento()
            {
               

            }
            private void completaFilasArticuloProveedor(List<ModeloArticuloProveedores> p_lst_mod_artProv)
            {
                var row = 1;
                  foreach (ModeloArticuloProveedores p_mod in p_lst_mod_artProv)
                 {
                glb_hojaTrabajo.Cells[row, "A"] = "dato fila 1 col A";
                glb_hojaTrabajo.Cells[row, "B"] = "dato fila 1 col B";
                  }
            }
            public void ajustarColumnas()
            {
                //Ajusta el ancho de las columnas
                glb_hojaTrabajo.Columns[1].AutoFit();
                glb_hojaTrabajo.Columns[2].AutoFit();
            }


        }
    }
}
