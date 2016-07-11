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
                    completaFilasArticuloProveedor(ControladorBusqueda.buscar(p_objeto as ModeloArticuloProveedores));

                }
                else if (T == typeof(ModeloArticulos))
                {
                    completarColumnasArticulo();
                    completaFilasArticulo(ControladorBusqueda.buscar(p_objeto as ModeloArticulos));
                }
                else if (T == typeof(ModeloCliente))
                {
                    completarColumnasCliente();
                    //completaFilasCliente(ControladorBusqueda.buscar(p_objeto as ModeloCliente));
                }
                else if (T == typeof(ModeloProveedor))
                {
                    completarColumnasProveedor();
                    //completaFilasProveedor(ControladorBusqueda.buscar(p_objeto as ModeloProveedor));
                }
                else if (T == typeof(ModeloDescuentoArticulo))
                {
                    completarColumnasDescuento();
                    //completaFilasDescuento(ControladorBusqueda.buscar(p_objeto as ModeloDescuentoArticulo));
                }
                ajustarColumnas();
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
                        glb_hojaTrabajo.Cells[row, "I"] = p_mod.valorCompra;
                        glb_hojaTrabajo.Cells[row, "J"] = p_mod.valorVenta;
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
            private void completaFilasCliente(List<ModeloCliente> p_lst_mod_cli)
            {
                var row = 1;
                foreach (ModeloCliente p_mod in p_lst_mod_cli)
                {
                    row++;
                    glb_hojaTrabajo.Cells[row, "A"] = p_mod.codigo;
                    glb_hojaTrabajo.Cells[row, "B"] = p_mod.tipoEntidad;
                    glb_hojaTrabajo.Cells[row, "C"] = p_mod.cuit;
                    glb_hojaTrabajo.Cells[row, "D"] = p_mod.observaciones;
                    glb_hojaTrabajo.Cells[row, "E"] = p_mod.dni;
                    glb_hojaTrabajo.Cells[row, "F"] = p_mod.nombre;
                    glb_hojaTrabajo.Cells[row, "G"] = p_mod.apellido;
                    glb_hojaTrabajo.Cells[row, "H"] = p_mod.tipoPersona;
                }

            }
            private void completaFilasProveedor(List<ModeloProveedor> p_lst_mod_prov)
            {
                var row = 1;
                foreach (ModeloProveedor p_mod in p_lst_mod_prov)
                {
                    row++;
                    glb_hojaTrabajo.Cells[row, "A"] = p_mod.codigo;
                    glb_hojaTrabajo.Cells[row, "B"] = p_mod.tipoEntidad;
                    glb_hojaTrabajo.Cells[row, "C"] = p_mod.cuit;
                    glb_hojaTrabajo.Cells[row, "D"] = p_mod.observaciones;
                    glb_hojaTrabajo.Cells[row, "E"] = p_mod.razonSocial;
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
}
