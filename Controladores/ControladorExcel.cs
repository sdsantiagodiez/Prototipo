using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using Modelos;
using System.Data;
using LibreriaClasesCompartidas;
using System.Transactions;
using System.Reflection;

namespace Controladores
{
    public class ControladorExcel:Controlador
    {
        #region Atributos
        Excel._Worksheet glb_hojaTrabajo;
        System.Data.DataTable glb_dataTable;
        ControladorAlta glb_con_alta = new ControladorAlta();
        ControladorModificacion glb_con_modificacion = new ControladorModificacion();
        int i = 0;
        public static string filasNoGravadas = "Las siguientes filas no fueron gravadas: ";
        #endregion

        #region Exportar
        public bool ExportarAExcel(Type p_type, string p_direccionDeArchivo)
        {
            p_direccionDeArchivo += "\\" + this.getNombreArchivo(p_type);

            var ExcelApp = new Excel.Application(); // se inicia la aplicacion
            ExcelApp.Visible = false; //Se setea false para que no se abra MS Excel (quizas no lo tienen instalado)
            Excel.Workbook excelWorkbook = ExcelApp.Workbooks.Add(); //Se agrega una hoja de trabajo
            //Asociamos nuestra hoja a la hoja activa
            glb_hojaTrabajo = (Excel._Worksheet)ExcelApp.ActiveSheet;
            //trabajamos la hoja creada
            errorActual = "No se ha podido realizar la actualizacion.";
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    this.aExcel(p_type);
                    excelWorkbook.SaveAs(p_direccionDeArchivo, Excel.XlFileFormat.xlOpenXMLWorkbook, Missing.Value,
                            Missing.Value, false, false, Excel.XlSaveAsAccessMode.xlNoChange,
                            Excel.XlSaveConflictResolution.xlUserResolution, true,
                            Missing.Value, Missing.Value, Missing.Value);
                    scope.Complete();
                    return true;
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
            catch (Exception ex)
            {
                errorActual = ex.Message;
            }
            finally
            {
                excelWorkbook.Close();
            }

            return false;
        }

        private void aExcel(Type p_type)
        {
            Type T = p_type;
            if (T == typeof(ModeloArticuloProveedores))
            {
                this.completarColumnasArticuloProveedor();
                ModeloArticuloProveedores lcl_mod_artP = new ModeloArticuloProveedores();
                completaFilasArticuloProveedor(ControladorBusqueda.buscar(lcl_mod_artP));
                errorActual = "La Exportacion de Artículos de Proveedores se realizó Correctamente";
            }
            else if (T == typeof(ModeloArticulos))
            {
                completarColumnasArticulo();
                ModeloArticulos lcl_mod_art = new ModeloArticulos();
                completaFilasArticulo(ControladorBusqueda.buscar(lcl_mod_art));
                errorActual = "La Exportacion de Artículos se realizó Correctamente";
            }
            else if (T == typeof(ModeloCliente))
            {
                completarColumnasCliente();
                ModeloEntidad lcl_mod_entidad = new ModeloCliente();
                completaFilasCliente(ControladorBusqueda.buscar(lcl_mod_entidad as ModeloCliente));
                errorActual = "La Exportacion de Clientes se realizó Correctamente";
            }
            else if (T == typeof(ModeloProveedor))
            {
                completarColumnasProveedor();
                ModeloEntidad lcl_mod_entidad = new ModeloProveedor();
                completaFilasProveedor(ControladorBusqueda.buscar(lcl_mod_entidad as ModeloProveedor));
                errorActual = "La Exportacion de Proveedores se realizó Correctamente";
            }
            else if (T == typeof(ModeloDescuentoArticuloProveedor))
            {
                completarColumnasDescuento();
                completaFilasDescuento(ControladorBusqueda.getDescuentosArticulosProveedores());
                errorActual = "La Exportacion de Descuentos se realizó Correctamente";
            }
            ajustarColumnas();
        }

        private void completarColumnasArticuloProveedor()
        {
            glb_hojaTrabajo.Cells[1, "A"] = "Codigo Original";
            glb_hojaTrabajo.Range["A1"].AddComment("Campo Obligatorio");
            glb_hojaTrabajo.Cells[1, "B"] = "Codigo Articulo Proveedor";
            glb_hojaTrabajo.Range["B1"].AddComment("Campo Obligatorio");
            glb_hojaTrabajo.Cells[1, "C"] = "Codigo Entidad Proveedor";
            glb_hojaTrabajo.Range["C1"].AddComment("Campo Obligatorio");
            glb_hojaTrabajo.Cells[1, "D"] = "Descripcion ArticuloProveedor";
            glb_hojaTrabajo.Range["D1"].AddComment("Campo Obligatorio");
            glb_hojaTrabajo.Cells[1, "E"] = "Observaciones";
            glb_hojaTrabajo.Cells[1, "F"] = "Stock Minimo";
            glb_hojaTrabajo.Range["F1"].AddComment("Campo Obligatorio");
            glb_hojaTrabajo.Cells[1, "G"] = "Stock Actual";
            glb_hojaTrabajo.Range["G1"].AddComment("Campo Obligatorio");
            glb_hojaTrabajo.Cells[1, "H"] = "Ubicacion";
            glb_hojaTrabajo.Cells[1, "I"] = "Valor Compra";
            glb_hojaTrabajo.Range["I1"].AddComment("Campo Obligatorio");
            glb_hojaTrabajo.Cells[1, "J"] = "Valor Venta";
            glb_hojaTrabajo.Range["J1"].AddComment("Campo Obligatorio");

        }
        private void completarColumnasArticulo()
        {
            glb_hojaTrabajo.Cells[1, "A"] = "Codigo Original";
            glb_hojaTrabajo.Range["A1"].AddComment("Campo Obligatorio");
            glb_hojaTrabajo.Cells[1, "B"] = "Descripcion";
            glb_hojaTrabajo.Range["B1"].AddComment("Campo Obligatorio");
            glb_hojaTrabajo.Cells[1, "C"] = "Modelos";
            glb_hojaTrabajo.Cells[1, "D"] = "Observaciones";

        }
        private void completarColumnasCliente()
        {
            glb_hojaTrabajo.Cells[1, "A"] = "DNI";
            glb_hojaTrabajo.Range["A1"].AddComment("Campo Obligatorio");
            glb_hojaTrabajo.Cells[1, "B"] = "Nombre";
            glb_hojaTrabajo.Range["B1"].AddComment("Campo Obligatorio");
            glb_hojaTrabajo.Cells[1, "C"] = "Apellido";
            glb_hojaTrabajo.Range["C1"].AddComment("Campo Obligatorio");
            glb_hojaTrabajo.Cells[1, "D"] = "Cuit";
            glb_hojaTrabajo.Cells[1, "E"] = "Observaciones";

        }
        private void completarColumnasProveedor()
        {
            glb_hojaTrabajo.Cells[1, "A"] = "Cuit";
            glb_hojaTrabajo.Range["A1"].AddComment("Campo Obligatorio");
            glb_hojaTrabajo.Cells[1, "B"] = "Razon Social";
            glb_hojaTrabajo.Range["B1"].AddComment("Campo Obligatorio");
            glb_hojaTrabajo.Cells[1, "C"] = "Observaciones";

        }
        private void completarColumnasDescuento()
        {
            glb_hojaTrabajo.Cells[1, "A"] = "Codigo Articulo Proveedor";
            glb_hojaTrabajo.Range["A1"].AddComment("Campo Obligatorio");
            glb_hojaTrabajo.Cells[1, "B"] = "Codigo Original";
            glb_hojaTrabajo.Range["B1"].AddComment("Campo Obligatorio");
            glb_hojaTrabajo.Cells[1, "C"] = "Fecha Desde";
            glb_hojaTrabajo.Range["C1"].AddComment("Campo Obligatorio");
            glb_hojaTrabajo.Cells[1, "D"] = "Fecha Hasta";
            glb_hojaTrabajo.Range["D1"].AddComment("Campo Obligatorio");
            glb_hojaTrabajo.Cells[1, "E"] = "Porcentaje Descuento";
            glb_hojaTrabajo.Range["E1"].AddComment("Campo Obligatorio");
            glb_hojaTrabajo.Cells[1, "F"] = "Descripcion";


        }
        private void completarColumnasValoresCompra()
        {
            glb_hojaTrabajo.Cells[1, "A"] = "Codigo Articulo Proveedor";
            glb_hojaTrabajo.Range["A1"].AddComment("Campo Obligatorio");
            glb_hojaTrabajo.Cells[1, "B"] = "Codigo Original";
            glb_hojaTrabajo.Range["B1"].AddComment("Campo Obligatorio");
            glb_hojaTrabajo.Cells[1, "C"] = "Precio";
            glb_hojaTrabajo.Range["C1"].AddComment("Campo Obligatorio");
            glb_hojaTrabajo.Cells[1, "D"] = "Fecha Actualización";
            glb_hojaTrabajo.Range["D1"].AddComment("Campo Obligatorio");

        }
        private void completarColumnasValoresVenta()
        {
            glb_hojaTrabajo.Cells[1, "A"] = "Codigo Articulo Proveedor";
            glb_hojaTrabajo.Range["A1"].AddComment("Campo Obligatorio");
            glb_hojaTrabajo.Cells[1, "B"] = "Codigo Original";
            glb_hojaTrabajo.Range["B1"].AddComment("Campo Obligatorio");
            glb_hojaTrabajo.Cells[1, "C"] = "Precio";
            glb_hojaTrabajo.Range["C1"].AddComment("Campo Obligatorio");
            glb_hojaTrabajo.Cells[1, "D"] = "Fecha Actualización";
            glb_hojaTrabajo.Range["D1"].AddComment("Campo Obligatorio");

        }
        
        private void completaFilasArticuloProveedor(List<ModeloArticuloProveedores> p_lst_mod_artProv)
        {
            var row = 1;
            foreach (ModeloArticuloProveedores p_mod in p_lst_mod_artProv)
            {
                row++;
                glb_hojaTrabajo.Cells[row, "A"] = p_mod.codigoOriginal;
                glb_hojaTrabajo.Cells[row, "B"] = p_mod.codigoArticuloProveedor;
                glb_hojaTrabajo.Cells[row, "C"] = p_mod.codigoEntidad;
                glb_hojaTrabajo.Cells[row, "D"] = p_mod.descripcionArticuloProveedor;
                glb_hojaTrabajo.Cells[row, "E"] = p_mod.observaciones;
                glb_hojaTrabajo.Cells[row, "F"] = p_mod.stockMinimo;
                glb_hojaTrabajo.Cells[row, "G"] = p_mod.stockActual;
                glb_hojaTrabajo.Cells[row, "H"] = p_mod.ubicacion;
                glb_hojaTrabajo.Cells[row, "I"] = p_mod.valorCompra.valorArticulo;
                glb_hojaTrabajo.Cells[row, "J"] = p_mod.valorVenta.valorArticulo;
            }
        }
        private void completaFilasArticulo(List<ModeloArticulos> p_lst_mod_art)
        {
            var row = 1;
            foreach (ModeloArticulos p_mod in p_lst_mod_art)
            {
                row++;
                glb_hojaTrabajo.Cells[row, "A"] = p_mod.codigoOriginal;
                glb_hojaTrabajo.Cells[row, "B"] = p_mod.descripcion;
                glb_hojaTrabajo.Cells[row, "C"] = p_mod.modelos;
                glb_hojaTrabajo.Cells[row, "D"] = p_mod.observaciones;
            }

        }
        private void completaFilasCliente(List<ModeloEntidad> p_lst_mod_cli)
        {
            var row = 1;
            foreach (ModeloEntidad p_mod in p_lst_mod_cli)
            {
                row++;
                glb_hojaTrabajo.Cells[row, "A"] = (p_mod as ModeloCliente).dni;
                glb_hojaTrabajo.Cells[row, "B"] = (p_mod as ModeloCliente).nombre;
                glb_hojaTrabajo.Cells[row, "C"] = (p_mod as ModeloCliente).apellido;
                glb_hojaTrabajo.Cells[row, "D"] = p_mod.cuit;
                glb_hojaTrabajo.Cells[row, "E"] = (p_mod.observaciones != null) ? p_mod.observaciones : "";

            }
        }
        private void completaFilasProveedor(List<ModeloEntidad> p_lst_mod_prov)
        {
            var row = 1;
            foreach (ModeloEntidad p_mod in p_lst_mod_prov)
            {
                row++;
                glb_hojaTrabajo.Cells[row, "A"] = p_mod.cuit;
                glb_hojaTrabajo.Cells[row, "B"] = (p_mod as ModeloProveedor).razonSocial;
                glb_hojaTrabajo.Cells[row, "C"] = p_mod.observaciones;
            }

        }
        private void completaFilasDescuento(List<ModeloDescuentoArticuloProveedor> p_lst_mod_descArt)
        {
            var row = 1;
            foreach (ModeloDescuentoArticuloProveedor p_mod in p_lst_mod_descArt)
            {
                row++;

                glb_hojaTrabajo.Cells[row, "A"] = p_mod.codigoOriginalArticulo;
                glb_hojaTrabajo.Cells[row, "B"] = p_mod.codigoArticuloProveedor;
                glb_hojaTrabajo.Cells[row, "C"] = p_mod.fechaVigenciaDesde;
                glb_hojaTrabajo.Cells[row, "D"] = p_mod.fechaVigenciaHasta;
                glb_hojaTrabajo.Cells[row, "E"] = p_mod.porcentaje;
                glb_hojaTrabajo.Cells[row, "F"] = p_mod.descripcion;

            }

        }
        private void completaFilasValorArticulosCompra(List<ModeloArticuloProveedores> p_lst_mod_artPro)
        {
            var row = 1;
            foreach (ModeloArticuloProveedores p_mod in p_lst_mod_artPro)
            {
                row++;
                glb_hojaTrabajo.Cells[row, "A"] = p_mod.codigoArticuloProveedor;
                glb_hojaTrabajo.Cells[row, "B"] = p_mod.codigoOriginal;
                glb_hojaTrabajo.Cells[row, "C"] = p_mod.valorCompra.valorArticulo;
                glb_hojaTrabajo.Cells[row, "D"] = p_mod.valorCompra.fechaUltimaActualizacion;
            }

        }
        private void completaFilasValorArticulosVenta(List<ModeloArticuloProveedores> p_lst_mod_artPro)
        {
            var row = 1;
            foreach (ModeloArticuloProveedores p_mod in p_lst_mod_artPro)
            {
                row++;
                glb_hojaTrabajo.Cells[row, "A"] = p_mod.codigoArticuloProveedor;
                glb_hojaTrabajo.Cells[row, "B"] = p_mod.codigoOriginal;
                glb_hojaTrabajo.Cells[row, "C"] = p_mod.valorVenta.valorArticulo;
                glb_hojaTrabajo.Cells[row, "D"] = p_mod.valorVenta.fechaUltimaActualizacion;
            }

        }

        private void ajustarColumnas()
        {
            //Ajusta el ancho de las columnas
            for (int i = 1; i > 11; i++)
            {
                glb_hojaTrabajo.Columns[i].AutoFit();
            }

        }

        private string getNombreArchivo(Type T)
        {
            string nombreArchivo = "";
            if (T == typeof(ModeloArticuloProveedores))
            {
                nombreArchivo = "ArticulosProveedores";
            }
            else if (T == typeof(ModeloArticulos))
            {
                nombreArchivo = "Articulos";
            }
            else if (T == typeof(ModeloCliente))
            {
                nombreArchivo = "Clientes";
            }
            else if (T == typeof(ModeloProveedor))
            {
                nombreArchivo = "Proveedores";
            }
            else if (T == typeof(ModeloDescuentoArticuloProveedor))
            {
                nombreArchivo = "DescuentosArticulosProveedores";
            }

            nombreArchivo += "_" + DateTime.Now.Year + DateTime.Now.Month.ToString().PadLeft(2, '0') + DateTime.Now.Day.ToString().PadLeft(2, '0');
            return nombreArchivo;
        }
        #endregion

        #region Importar
        public bool esValorVenta;

        public static DataTable getPreviewDeArchivo(string p_path, Type T)
        {
            int cantidadAtributos = 0;

            if (T == typeof(ModeloArticuloProveedores))
            {
                cantidadAtributos = 10;
            }
            else if (T == typeof(ModeloArticulos))
            {
                cantidadAtributos = 4;
            }
            else if (T == typeof(ModeloCliente))
            {
                cantidadAtributos = 5;
            }
            else if (T == typeof(ModeloProveedor))
            {
                cantidadAtributos = 3;
            }
            else if (T == typeof(ModeloValorArticulo))
            {
                cantidadAtributos = 3;
            }

            return ControladorExcel.getPreviewDeArchivo(p_path, cantidadAtributos);
        }
        private static DataTable getPreviewDeArchivo(string p_path, int p_cantidadDeColumnas)
        {
            DataTable lcl_dt_dataPreview = new DataTable();
            for (int i = 0; i < p_cantidadDeColumnas; i++)
            {
                lcl_dt_dataPreview.Columns.Add();
            }
            try
            {
                Excel.Application app = new Excel.Application();
                Excel.Workbook workBook = app.Workbooks.Open(p_path, 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                Excel.Worksheet workSheet = (Excel.Worksheet)workBook.ActiveSheet;

                DataRow row;

                for (int rowIndex = 1; 
                        (
                            ((Excel.Range)workSheet.Cells[rowIndex, 1]).Value2 != null ||
                            ((Excel.Range)workSheet.Cells[rowIndex, 2]).Value2 != null ||
                            ((Excel.Range)workSheet.Cells[rowIndex, 3]).Value2 != null ||
                            ((Excel.Range)workSheet.Cells[rowIndex, 4]).Value2 != null 
                        )
                        && rowIndex < 50; rowIndex++)
                {
                    row = lcl_dt_dataPreview.NewRow();

                    foreach (DataColumn c in lcl_dt_dataPreview.Columns)
                    {
                        row[c.Ordinal] = Convert.ToString((workSheet.Cells[rowIndex, c.Ordinal + 1] as Excel.Range).Value);
                    }
                    lcl_dt_dataPreview.Rows.Add(row);
                }
                app.Workbooks.Close();
            }
            catch (Exception ex)
            {
                return null;
            }
            return lcl_dt_dataPreview;
        }

        public bool importarDatos(string p_path, Type T, List<int?> p_indiceAtributo, bool p_primeraRowHeaders, out string p_respuesta)
        {
            p_respuesta = null;

            DataTable lcl_dataTable = this.importarDatos_getDataTable(T);

            if (lcl_dataTable == null)
            {
                p_respuesta = "Ha surgido un error inesperado. No se ha reconocido el tipo de datos que se desea importar.";
                return false;
            }

            if (!this.importarDatos_getDatos(p_path, p_indiceAtributo, ref lcl_dataTable, p_primeraRowHeaders))
            {
                p_respuesta = "Ha surgido un problema al leer los datos del archivo.";
                return false;
            }

            if (!this.importarDatos_agregarABaseDeDatos(T, lcl_dataTable))
            {
                p_respuesta = "Ha surgido un problema al agregar datos a la base de datos.";
                return false;
            }

            p_respuesta = "Importación de datos exitosa.";
            return true;
        }
        
        private DataTable importarDatos_getDataTable(Type T)
        {
            if (T == typeof(ModeloArticuloProveedores))
            {
                return this.importarDatos_getDataTable_ArticuloProveedor();
            }
            else if (T == typeof(ModeloArticulos))
            {
                return this.importarDatos_getDataTable_Articulo();
            }
            else if (T == typeof(ModeloCliente))
            {
                return this.importarDatos_getDataTable_Cliente();
            }
            else if (T == typeof(ModeloProveedor))
            {
                return this.importarDatos_getDataTable_Proveedor();
            }
            else if (T == typeof(ModeloValorArticulo))
            {
                return this.importarDatos_getDataTable_ValorArticuloProveedor();
            }

            return null;
        }
        private DataTable importarDatos_getDataTable_Articulo()
        {
            DataTable lcl_dataTable = new DataTable();

            lcl_dataTable.Columns.Add("codigoOriginal");
            lcl_dataTable.Columns.Add("descripcion");
            lcl_dataTable.Columns.Add("modelos");
            lcl_dataTable.Columns.Add("observaciones");

            return lcl_dataTable;
        }
        private DataTable importarDatos_getDataTable_ArticuloProveedor()
        {
            DataTable lcl_dataTable = new DataTable();

            lcl_dataTable.Columns.Add("codigoOriginal");
            lcl_dataTable.Columns.Add("codigoArticuloProveedor");
            lcl_dataTable.Columns.Add("codigoEntidad");
            lcl_dataTable.Columns.Add("descripcion");
            lcl_dataTable.Columns.Add("precioCompra");
            lcl_dataTable.Columns.Add("precioVenta");
            lcl_dataTable.Columns.Add("stockMinimo");
            lcl_dataTable.Columns.Add("stockActual");
            lcl_dataTable.Columns.Add("ubicacion");
            lcl_dataTable.Columns.Add("observaciones");

            return lcl_dataTable;
        }
        private DataTable importarDatos_getDataTable_Cliente()
        {
            DataTable lcl_dataTable = new DataTable();

            lcl_dataTable.Columns.Add("dni");
            lcl_dataTable.Columns.Add("nombre");
            lcl_dataTable.Columns.Add("apellido");
            lcl_dataTable.Columns.Add("cuit");
            lcl_dataTable.Columns.Add("observaciones");

            return lcl_dataTable;
        }
        private DataTable importarDatos_getDataTable_Proveedor()
        {
            DataTable lcl_dataTable = new DataTable();

            lcl_dataTable.Columns.Add("cuit");
            lcl_dataTable.Columns.Add("razonSocial");
            lcl_dataTable.Columns.Add("observaciones");

            return lcl_dataTable;
        }
        private DataTable importarDatos_getDataTable_ValorArticuloProveedor()
        {
            DataTable lcl_dataTable = new DataTable();

            lcl_dataTable.Columns.Add("codigoOriginal");
            lcl_dataTable.Columns.Add("codigoArticuloProveedor");
            lcl_dataTable.Columns.Add("valor");

            return lcl_dataTable;
        }

        private bool importarDatos_getDatos(string p_path, List<int?> p_indiceAtributo, ref DataTable p_dataTable, bool p_primeraRowHeaders)
        {
            string aux;
            try
            {
                Excel.Application app = new Excel.Application();
                Excel.Workbook workBook = app.Workbooks.Open(p_path, 0, true, 5, "", "", true, Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                Excel.Worksheet workSheet = (Excel.Worksheet)workBook.ActiveSheet;

                DataRow row;
                
                for (int rowIndex = this.getFirstRowIndex(p_primeraRowHeaders); ((Excel.Range)workSheet.Cells[rowIndex, p_indiceAtributo[0] + 1]).Value2 != null; rowIndex++)
                {
                    row = p_dataTable.NewRow();

                    foreach (DataColumn c in p_dataTable.Columns)
                    {
                        if (p_indiceAtributo[c.Ordinal] == null)
                        { continue; }
                        aux = Convert.ToString((workSheet.Cells[rowIndex, p_indiceAtributo[c.Ordinal]+1] as Excel.Range).Value2);
                        row[c.Ordinal] = aux;
                    }
                    p_dataTable.Rows.Add(row);
                }
                app.Workbooks.Close();
            }
            catch (Exception ex)
            {
                p_dataTable = null;
                return false;
            }
            return true;
        }
        private int getFirstRowIndex(bool p_primeraRowHeaders)
        {
            if (p_primeraRowHeaders)
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }

        private bool importarDatos_agregarABaseDeDatos(Type T, DataTable p_dataTable)
        {
            List<object> lcl_lst_datos = this.importarDatos_getModelos(T, p_dataTable);
            if (lcl_lst_datos == null || lcl_lst_datos.Count < 1)
            {
                return false;
            }

            if (T == typeof(ModeloValorArticulo))
            {
                string aux;
                if (esValorVenta)
                { aux = LibreriaClasesCompartidas.Constantes.TipoValorArticulo.Venta; }
                else
                { aux = LibreriaClasesCompartidas.Constantes.TipoValorArticulo.Compra; }

                ControladorModificacion lcl_con_modificacion = new ControladorModificacion();
                return lcl_con_modificacion.modificarValoresArticulos(lcl_lst_datos, aux);
            }

            ControladorAlta lcl_con_alta = new ControladorAlta();

            return  lcl_con_alta.agregar(lcl_lst_datos);
        }

        private List<object> importarDatos_getModelos(Type T, DataTable p_dataTable)
        {
            IEnumerable<object> lcl_ienum_objeto;

            if (T == typeof(ModeloArticuloProveedores))
            {
                lcl_ienum_objeto = this.importarDatos_getModelosArticulosProveedores(p_dataTable);
            }
            else if (T == typeof(ModeloArticulos))
            {
                lcl_ienum_objeto = this.importarDatos_getModelosArticulos(p_dataTable);
            }
            else if (T == typeof(ModeloCliente))
            {
                lcl_ienum_objeto = this.importarDatos_getModelosClientes(p_dataTable);
            }
            else if (T == typeof(ModeloProveedor))
            {
                lcl_ienum_objeto = this.importarDatos_getModelosProveedores(p_dataTable);
            }
            else if (T == typeof(ModeloValorArticulo))
            {
                lcl_ienum_objeto = this.importarDatos_getModelosValoresArticulosProveedores(p_dataTable);
            }
            else
            {
                lcl_ienum_objeto = null;
            }

            return lcl_ienum_objeto.ToList();
        }
        private List<ModeloArticulos> importarDatos_getModelosArticulos(DataTable p_dataTable)
        {
            List<ModeloArticulos> lcl_lst_mod_articulos = new List<ModeloArticulos>();
            
            ModeloArticulos lcl_mod_articulo;
            foreach (DataRow row in p_dataTable.Rows)
            {
                lcl_mod_articulo = new ModeloArticulos();

                lcl_mod_articulo.codigoOriginal = row["codigoOriginal"].ToString();
                lcl_mod_articulo.descripcion = row["descripcion"].ToString();
                lcl_mod_articulo.modelos = string.IsNullOrWhiteSpace(row["modelos"].ToString()) ? null : row["modelos"].ToString();
                lcl_mod_articulo.observaciones = string.IsNullOrWhiteSpace(row["observaciones"].ToString()) ? null : row["observaciones"].ToString();

                lcl_lst_mod_articulos.Add(lcl_mod_articulo);
            }

            return lcl_lst_mod_articulos;
        }
        private List<ModeloArticuloProveedores> importarDatos_getModelosArticulosProveedores(DataTable p_dataTable)
        {
            List<ModeloArticuloProveedores> lcl_lst_mod_articulosProveedores = new List<ModeloArticuloProveedores>();

            ModeloArticuloProveedores lcl_mod_articuloProveedor;
            int int_aux;
            decimal dec_aux;
            foreach (DataRow row in p_dataTable.Rows)
            {
                lcl_mod_articuloProveedor = new ModeloArticuloProveedores();

                lcl_mod_articuloProveedor.codigoOriginal = row["codigoOriginal"].ToString();
                lcl_mod_articuloProveedor.codigoArticuloProveedor = row["codigoArticuloProveedor"].ToString();
                if (Int32.TryParse(row["codigoEntidad"].ToString(), out int_aux))
                { lcl_mod_articuloProveedor.codigoEntidad = int_aux; }
                else
                { lcl_mod_articuloProveedor.codigoEntidad = 0; }
                lcl_mod_articuloProveedor.descripcionArticuloProveedor = string.IsNullOrWhiteSpace(row["descripcion"].ToString()) ? null : row["descripcion"].ToString();

                if (Decimal.TryParse(row["precioCompra"].ToString(), out dec_aux))
                { lcl_mod_articuloProveedor.valorCompra.valorArticulo = dec_aux; }
                else
                { lcl_mod_articuloProveedor.valorCompra.valorArticulo = null; }
                if (Decimal.TryParse(row["precioVenta"].ToString(), out dec_aux))
                { lcl_mod_articuloProveedor.valorVenta.valorArticulo = dec_aux; }
                else
                { lcl_mod_articuloProveedor.valorVenta.valorArticulo = null; }

                if (Int32.TryParse(row["stockMinimo"].ToString(), out int_aux))
                { lcl_mod_articuloProveedor.stockMinimo = int_aux; }
                else
                { lcl_mod_articuloProveedor.stockMinimo = null; }
                if (Int32.TryParse(row["stockActual"].ToString(), out int_aux))
                { lcl_mod_articuloProveedor.stockActual = int_aux; }
                else
                { lcl_mod_articuloProveedor.stockActual = null; }
                
                lcl_mod_articuloProveedor.ubicacion = string.IsNullOrWhiteSpace(row["ubicacion"].ToString()) ? null : row["ubicacion"].ToString();
                lcl_mod_articuloProveedor.observaciones = string.IsNullOrWhiteSpace(row["observaciones"].ToString()) ? null : row["observaciones"].ToString();

                lcl_lst_mod_articulosProveedores.Add(lcl_mod_articuloProveedor);
            }

            return lcl_lst_mod_articulosProveedores;
        }
        private List<ModeloCliente> importarDatos_getModelosClientes(DataTable p_dataTable)
        {
            List<ModeloCliente> lcl_lst_mod_clientes = new List<ModeloCliente>();

            ModeloCliente lcl_mod_cliente;
            foreach (DataRow row in p_dataTable.Rows)
            {
                lcl_mod_cliente = new ModeloCliente();

                lcl_mod_cliente.dni = row["dni"].ToString();
                lcl_mod_cliente.nombre = row["nombre"].ToString();
                lcl_mod_cliente.apellido = row["apellido"].ToString();
                lcl_mod_cliente.cuit = string.IsNullOrWhiteSpace(row["cuit"].ToString()) ? null : row["cuit"].ToString();
                lcl_mod_cliente.observaciones = string.IsNullOrWhiteSpace(row["observaciones"].ToString()) ? null : row["observaciones"].ToString();

                lcl_lst_mod_clientes.Add(lcl_mod_cliente);
            }

            return lcl_lst_mod_clientes;
        }
        private List<ModeloProveedor> importarDatos_getModelosProveedores(DataTable p_dataTable)
        {
            List<ModeloProveedor> lcl_lst_mod_proveedores = new List<ModeloProveedor>();

            ModeloProveedor lcl_mod_proveedor;
            foreach (DataRow row in p_dataTable.Rows)
            {
                lcl_mod_proveedor = new ModeloProveedor();

                lcl_mod_proveedor.cuit = row["cuit"].ToString();
                lcl_mod_proveedor.razonSocial = row["razonSocial"].ToString();
                lcl_mod_proveedor.observaciones = string.IsNullOrWhiteSpace(row["observaciones"].ToString()) ? null : row["observaciones"].ToString();

                lcl_lst_mod_proveedores.Add(lcl_mod_proveedor);
            }

            return lcl_lst_mod_proveedores;
        }
        private List<ModeloArticuloProveedores> importarDatos_getModelosValoresArticulosProveedores(DataTable p_dataTable)
        {
            //ver si agregar a una lista diferente los que tienen precios null. Considerar la conexión a base de datos posterior
            List<ModeloArticuloProveedores> lcl_lst_mod_articulosProveedores = new List<ModeloArticuloProveedores>();
            List<ModeloArticuloProveedores> lcl_lst_mod_articulosProveedores_noAgregados = new List<ModeloArticuloProveedores>();
            ModeloArticuloProveedores lcl_mod_articuloProveedore;
            decimal dec_aux;
            decimal? dec_nullable_aux;
            foreach (DataRow row in p_dataTable.Rows)
            {
                lcl_mod_articuloProveedore = new ModeloArticuloProveedores();

                lcl_mod_articuloProveedore.codigoOriginal  = row["codigoOriginal"].ToString();
                lcl_mod_articuloProveedore.codigoArticuloProveedor = row["codigoArticuloProveedor"].ToString();
                
                if(Decimal.TryParse(string.IsNullOrWhiteSpace(row["valor"].ToString()) ? null : row["valor"].ToString(), out dec_aux))
                { dec_nullable_aux = dec_aux; }
                else
                { 
                    dec_nullable_aux = null;
                    lcl_lst_mod_articulosProveedores_noAgregados.Add(lcl_mod_articuloProveedore);
                    continue;
                }

                if (esValorVenta)
                {
                    lcl_mod_articuloProveedore.valorVenta.valorArticulo = dec_nullable_aux;
                }
                else
                {
                    lcl_mod_articuloProveedore.valorCompra.valorArticulo = dec_nullable_aux;
                }

                lcl_lst_mod_articulosProveedores.Add(lcl_mod_articuloProveedore);
            }

            return lcl_lst_mod_articulosProveedores;
        }
        #endregion
    }
}