using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelLib = Microsoft.Office.Interop.Excel;
using Modelos;
using System.Data;


namespace Controladores
{
    public class ControladorExcel
    {
        ExcelLib._Worksheet glb_hojaTrabajo;
        System.Data.DataTable glb_dataTable;
        ControladorAlta glb_con_alta = new ControladorAlta();
            public bool ExportarAExcel(Type p_type)
            {
                // se inicia la aplicacion
                var ExcelApp = new ExcelLib.Application();
                //Se setea visible
                ExcelApp.Visible = true;
                //Se agrega una hoja de trabajo
                ExcelApp.Workbooks.Add();
                //Asociamos nuestra hoja a la hoja activa
                glb_hojaTrabajo = (ExcelLib._Worksheet)ExcelApp.ActiveSheet;
                //trabajamos la hoja creada
                this.aExcel(p_type);
                
                
                return true;
            }

            private void aExcel(Type p_type)
            {
                Type T = p_type;
                if (T == typeof(ModeloArticuloProveedores))
                {
                    this.completarColumnasArticuloProveedor();
                    ModeloArticuloProveedores lcl_mod_artP = new ModeloArticuloProveedores();
                    completaFilasArticuloProveedor(ControladorBusqueda.buscar(lcl_mod_artP));

                }
                else if (T == typeof(ModeloArticulos))
                {
                    completarColumnasArticulo();
                    ModeloArticulos lcl_mod_art = new ModeloArticulos();
                    completaFilasArticulo(ControladorBusqueda.buscar(lcl_mod_art));
                }
                else if (T == typeof(ModeloCliente))
                {
                    completarColumnasCliente();
                    ModeloEntidad lcl_mod_entidad = new ModeloCliente();
                    completaFilasCliente(ControladorBusqueda.buscar(lcl_mod_entidad as ModeloCliente));
                }
                else if (T == typeof(ModeloProveedor))
                {
                    completarColumnasProveedor();
                    ModeloEntidad lcl_mod_entidad = new ModeloProveedor();
                    completaFilasProveedor(ControladorBusqueda.buscar(lcl_mod_entidad as ModeloProveedor));
                }
                else if (T == typeof(ModeloDescuentoArticulo))
                {
                    completarColumnasDescuento();
                    //completaFilasDescuento(ControladorBusqueda.buscar(p_objeto as ModeloDescuentoArticulo));
                }
                ajustarColumnas();
            }

            private DataTable deExcel(string p_path)
            {
                ExcelLib.Application app = new ExcelLib.Application();
                Microsoft.Office.Interop.Excel.Workbook workBook = app.Workbooks.Open(p_path, 0, true, 5, "", "", true, ExcelLib.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);

                ExcelLib.Worksheet workSheet = (ExcelLib.Worksheet)workBook.ActiveSheet;

                int index = 0;
                object rowIndex = 2;

                DataTable dt = new DataTable();
                dt.Columns.Add("Col1");
                dt.Columns.Add("Col2");
                dt.Columns.Add("Col3");
                dt.Columns.Add("Col4");
                dt.Columns.Add("Col5");
                dt.Columns.Add("Col6");
                dt.Columns.Add("Col7");
                dt.Columns.Add("Col8");
                dt.Columns.Add("Col9");
                dt.Columns.Add("Col10");

                DataRow row;

                while (((Microsoft.Office.Interop.Excel.Range)workSheet.Cells[rowIndex, 1]).Value2 != null)
                {
                    rowIndex = 2 + index;
                    row = dt.NewRow();
                    row[0] = Convert.ToString(((Microsoft.Office.Interop.Excel.Range)workSheet.Cells[rowIndex, 1]).Value2);
                    row[1] = Convert.ToString(((Microsoft.Office.Interop.Excel.Range)workSheet.Cells[rowIndex, 2]).Value2);
                    row[2] = Convert.ToString(((Microsoft.Office.Interop.Excel.Range)workSheet.Cells[rowIndex, 3]).Value2);
                    row[3] = Convert.ToString(((Microsoft.Office.Interop.Excel.Range)workSheet.Cells[rowIndex, 4]).Value2);
                    row[4] = Convert.ToString(((Microsoft.Office.Interop.Excel.Range)workSheet.Cells[rowIndex, 5]).Value2);
                    row[5] = Convert.ToString(((Microsoft.Office.Interop.Excel.Range)workSheet.Cells[rowIndex, 6]).Value2);
                    row[6] = Convert.ToString(((Microsoft.Office.Interop.Excel.Range)workSheet.Cells[rowIndex, 7]).Value2);
                    row[7] = Convert.ToString(((Microsoft.Office.Interop.Excel.Range)workSheet.Cells[rowIndex, 8]).Value2);
                    row[8] = Convert.ToString(((Microsoft.Office.Interop.Excel.Range)workSheet.Cells[rowIndex, 9]).Value2);
                    row[9] = Convert.ToString(((Microsoft.Office.Interop.Excel.Range)workSheet.Cells[rowIndex, 10]).Value2);
                   //row[10] = Convert.ToString(((Microsoft.Office.Interop.Excel.Range)workSheet.Cells[rowIndex, 11]).Value2);
                    index++;
                    dt.Rows.Add(row);
                }
                app.Workbooks.Close();
                return dt;
            }
            public string ImportarDeExcel(string p_path, Type p_typeOf)
            {
                DataTable p_dataTable = this.deExcel(p_path);
                string message = "";

                if (p_typeOf == typeof(ModeloArticuloProveedores))
                {
                    message= (addArticuloProveedor(this.completaModeloArticuloProveedor(p_dataTable)));
                    
                }
                else if (p_typeOf == typeof(ModeloArticulos))
                {
                    message=(addArticulo(this.completaModeloArticulo(p_dataTable)));
                }
                else if (p_typeOf == typeof(ModeloCliente))
                {
                    //message=(addCliente(this.completaModeloCliente(p_dataTable)));
                }
                else if (p_typeOf == typeof(ModeloProveedor))
                {
                    //message=(addProveedor(this.completaModeloProveedor(p_dataTable)));
                }
                else if (p_typeOf == typeof(ModeloDescuentoArticulo))
                {
                    message=(addDescuento(this.completaModeloDescuento(p_dataTable)));
                }
                else { message = "Se ha producido un error en la importación."; };
                
                return message;
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
                glb_hojaTrabajo.Cells[1, "A"] = "Codigo Original";
                glb_hojaTrabajo.Cells[1, "B"] = "Descripcion";
                glb_hojaTrabajo.Cells[1, "C"] = "Modelos";
                glb_hojaTrabajo.Cells[1, "D"] = "Observaciones";
                
            }
            private void completarColumnasCliente()
            {
                glb_hojaTrabajo.Cells[1, "A"] = "Codigo Entidad";
                glb_hojaTrabajo.Cells[1, "B"] = "Tipo Entidad";
                glb_hojaTrabajo.Cells[1, "C"] = "Cuit";
                glb_hojaTrabajo.Cells[1, "D"] = "Observaciones";
                glb_hojaTrabajo.Cells[1, "E"] = "DNI";
                glb_hojaTrabajo.Cells[1, "F"] = "Nombre";
                glb_hojaTrabajo.Cells[1, "G"] = "Apellido";
                glb_hojaTrabajo.Cells[1, "H"] = "Tipo Persona";
                
            }
            private void completarColumnasProveedor()
            {
                glb_hojaTrabajo.Cells[1, "A"] = "Codigo Entidad";
                glb_hojaTrabajo.Cells[1, "B"] = "Tipo Entidad";
                glb_hojaTrabajo.Cells[1, "C"] = "Cuit";
                glb_hojaTrabajo.Cells[1, "D"] = "Observaciones";
                glb_hojaTrabajo.Cells[1, "E"] = "Razon Social";
                
            }
            private void completarColumnasDescuento()
            {
               glb_hojaTrabajo.Cells[1, "A"] = "Codigo Articulo Proveedor";
                glb_hojaTrabajo.Cells[1, "B"] = "Codigo Original";
                glb_hojaTrabajo.Cells[1, "C"] = "Fecha Desde";
                glb_hojaTrabajo.Cells[1, "D"] = "Fecha Hasta";
                glb_hojaTrabajo.Cells[1, "E"] = "Porcentaje Descuento";
                glb_hojaTrabajo.Cells[1, "F"] = "Numero Descuento";
                
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
                    glb_hojaTrabajo.Cells[row, "A"] = p_mod.codigo;
                    glb_hojaTrabajo.Cells[row, "B"] = p_mod.tipoEntidad;
                    glb_hojaTrabajo.Cells[row, "C"] = p_mod.cuit;
                    glb_hojaTrabajo.Cells[row, "D"] = (p_mod.observaciones != null) ? p_mod.observaciones : "";
                    glb_hojaTrabajo.Cells[row, "E"] = (p_mod as ModeloCliente).dni;
                    glb_hojaTrabajo.Cells[row, "F"] = (p_mod as ModeloCliente).nombre;
                    glb_hojaTrabajo.Cells[row, "G"] = (p_mod as ModeloCliente).apellido;
                    glb_hojaTrabajo.Cells[row, "H"] = (p_mod as ModeloCliente).tipoPersona;
                }

            }
            private void completaFilasProveedor(List<ModeloEntidad> p_lst_mod_prov)
            {
                var row = 1;
                foreach (ModeloEntidad p_mod in p_lst_mod_prov)
                {
                    row++;
                    glb_hojaTrabajo.Cells[row, "A"] = p_mod.codigo;
                    glb_hojaTrabajo.Cells[row, "B"] = p_mod.tipoEntidad;
                    glb_hojaTrabajo.Cells[row, "C"] = p_mod.cuit;
                    glb_hojaTrabajo.Cells[row, "D"] = p_mod.observaciones;
                    glb_hojaTrabajo.Cells[row, "E"] = (p_mod as ModeloProveedor).razonSocial;
                }

            }
            private void completaFilasDescuento(List<ModeloDescuentoArticulo> p_lst_mod_descArt)
            {
                var row = 1;
                foreach (ModeloDescuentoArticulo p_mod in p_lst_mod_descArt)
                {
                    row++;
                    glb_hojaTrabajo.Cells[row, "A"] = p_mod.CodigoArticuloProveedor;
                    glb_hojaTrabajo.Cells[row, "B"] = p_mod.CodigoOriginal;
                    glb_hojaTrabajo.Cells[row, "C"] = p_mod.FechaDesde;
                    glb_hojaTrabajo.Cells[row, "D"] = p_mod.FechaHasta;
                    glb_hojaTrabajo.Cells[row, "E"] = p_mod.PorcentajeDescuento;
                    glb_hojaTrabajo.Cells[row, "F"] = p_mod.numeroDescuento;
                }

            }

            private List<ModeloArticuloProveedores> completaModeloArticuloProveedor(DataTable p_dataTable)
            {
                List<ModeloArticuloProveedores> lcl_lst_mod_artPro = new List<ModeloArticuloProveedores>();

                foreach (DataRow row in p_dataTable.Rows)
                {
                    ModeloArticuloProveedores lcl_mod_artPro = new ModeloArticuloProveedores();
                    lcl_mod_artPro.codigoOriginal = row[0].ToString();
                    lcl_mod_artPro.codigoArticuloProveedor = row[1].ToString();
                    lcl_mod_artPro.codigoEntidad = Convert.ToInt32(row[2].ToString());
                    lcl_mod_artPro.descripcionArticuloProveedor = row[3].ToString();
                    lcl_mod_artPro.observacionesArticuloProveedor = row[4].ToString();
                    lcl_mod_artPro.stockMinimo = Convert.ToInt32(row[5].ToString());
                    lcl_mod_artPro.stockActual = Convert.ToInt32(row[6].ToString());
                    lcl_mod_artPro.ubicacion = row[7].ToString();
                    lcl_mod_artPro.valorCompra.valorArticulo = Convert.ToDecimal(row[8].ToString());
                    lcl_mod_artPro.valorVenta.valorArticulo = Convert.ToDecimal(row[9].ToString());

                    lcl_lst_mod_artPro.Add(lcl_mod_artPro);
                }

                return lcl_lst_mod_artPro;
            }
            private List<ModeloArticulos> completaModeloArticulo(DataTable p_dataTable)
            {
                List<ModeloArticulos> lcl_lst_mod_art = new List<ModeloArticulos>();

                foreach (DataRow row in p_dataTable.Rows)
                {
                    ModeloArticulos lcl_mod_art = new ModeloArticulos();
                    lcl_mod_art.codigoOriginal = row[0].ToString();
                    lcl_mod_art.descripcion = row[1].ToString();
                    lcl_mod_art.modelos = row[2].ToString();
                    lcl_mod_art.observaciones = row[3].ToString();
                    
                    lcl_lst_mod_art.Add(lcl_mod_art);
                }

                return lcl_lst_mod_art;
            }
            private List<ModeloCliente> completaModeloCliente(DataTable p_dataTable)
            {
                List<ModeloCliente> lcl_lst_mod_cli = new List<ModeloCliente>();

                foreach (DataRow row in p_dataTable.Rows)
                {
                    ModeloCliente lcl_mod_cli = new ModeloCliente();
                    lcl_mod_cli.codigo = Convert.ToInt32(row[0].ToString());
                    lcl_mod_cli.tipoEntidad = row[1].ToString();
                    lcl_mod_cli.cuit = row[2].ToString();
                    lcl_mod_cli.observaciones = row[3].ToString();
                    lcl_mod_cli.dni = row[4].ToString();
                    lcl_mod_cli.nombre = row[5].ToString();
                    lcl_mod_cli.apellido = row[6].ToString();
                    lcl_mod_cli.tipoPersona = row[7].ToString();

                    lcl_lst_mod_cli.Add(lcl_mod_cli);
                }

                return lcl_lst_mod_cli;
            }
            private List<ModeloProveedor> completaModeloProveedor(DataTable p_dataTable)
            {
                List<ModeloProveedor> lcl_lst_mod_pro = new List<ModeloProveedor>();

                foreach (DataRow row in p_dataTable.Rows)
                {
                    ModeloProveedor lcl_mod_pro = new ModeloProveedor();
                    lcl_mod_pro.codigo = Convert.ToInt32(row[0].ToString());
                    lcl_mod_pro.tipoEntidad = row[1].ToString();
                    lcl_mod_pro.cuit = row[2].ToString();
                    lcl_mod_pro.observaciones = row[3].ToString();
                    lcl_mod_pro.razonSocial = row[4].ToString();
                    

                    lcl_lst_mod_pro.Add(lcl_mod_pro);
                }

                return lcl_lst_mod_pro;
            }
            private List<ModeloDescuentoArticulo> completaModeloDescuento(DataTable p_dataTable)
            {
                List<ModeloDescuentoArticulo> lcl_lst_mod_desArt = new List<ModeloDescuentoArticulo>();

                foreach (DataRow row in p_dataTable.Rows)
                {
                    ModeloDescuentoArticulo lcl_mod_desArt = new ModeloDescuentoArticulo();
                    lcl_mod_desArt.CodigoArticuloProveedor = row[0].ToString();
                    lcl_mod_desArt.CodigoOriginal = row[1].ToString();
                    lcl_mod_desArt.FechaDesde = Convert.ToDateTime(row[2].ToString());
                    lcl_mod_desArt.FechaHasta = Convert.ToDateTime(row[3].ToString());
                    lcl_mod_desArt.PorcentajeDescuento = Convert.ToDecimal(row[4].ToString());
                    lcl_mod_desArt.numeroDescuento = Convert.ToInt32(row[5].ToString());

                    lcl_lst_mod_desArt.Add(lcl_mod_desArt);
                }

                return lcl_lst_mod_desArt;
            }

            private string addArticuloProveedor(List<ModeloArticuloProveedores> p_lst_mod_artPro)
            {

                int i = 0;
                foreach (ModeloArticuloProveedores modArt in p_lst_mod_artPro)
                {
                   i = (glb_con_alta.agregar(modArt)==true)? i++:i;
                }
                return "Se agregaron " + i + " ArtículoProveedor.";
            }
            private string addArticulo(List<ModeloArticulos> p_lst_mod_art)
            {

                int i = 0;
                foreach (ModeloArticulos modArt in p_lst_mod_art)
                {
                    i = (glb_con_alta.agregar(modArt) == true) ? i++ : i;
                }
                return "Se agregaron " + i + " Artículos.";
            }
            private string addCliente(List<ModeloEntidad> p_lst_mod_cli)
            {
                ModeloEntidad lcl_aux_cli = new ModeloCliente();
                int i = 0;
                foreach (ModeloCliente modCli in p_lst_mod_cli)
                {
                   // i = (glb_con_alta.agregar(ref modCli) == true) ? i++ : i;
                }
                return "Se agregaron " + i + " Clientes.";
            }
            private string addProveedor(List<ModeloEntidad> p_lst_mod_pro)
            {
                ModeloEntidad lcl_aux_pro = new ModeloProveedor();
                int i = 0;
                foreach (ModeloCliente modPro in p_lst_mod_pro)
                {
                    // i = (glb_con_alta.agregar(ref modPro) == true) ? i++ : i;
                }
                return "Se agregaron " + i + " Proveedores.";
            }
            private string addDescuento(List<ModeloDescuentoArticulo> p_lst_mod_desc)
            {
                int i = 0;
                foreach (ModeloDescuentoArticulo modDes in p_lst_mod_desc)
                {
                    // i = (glb_con_alta.agregar(ref modDes) == true) ? i++ : i;
                }
                return "Se agregaron " + i + " Descuentos.";
            }
            
            public void ajustarColumnas()
            {
                //Ajusta el ancho de las columnas
                for (int i = 1; i > 11; i++)
                {
                    glb_hojaTrabajo.Columns[i].AutoFit();
                }
                
            }


        }
    }

