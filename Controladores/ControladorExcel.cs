using System;
using System.Collections.Generic;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using Modelos;
using System.Data;
using LibreriaClasesCompartidas;
//using System.Transactions;
//using System.Reflection;


namespace Controladores
{
    public class ControladorExcel:Controlador
   { 
        #region Exportar
        public bool Exportar(Type p_type, string p_direccionDeCarpetaDestino)
        {
            Datos.ConexionOpenXML lcl_conXML = new Datos.ConexionOpenXML();

            string direccionDeArchivo = p_direccionDeCarpetaDestino + "\\" + this.getNombreArchivo(p_type) +".xlsx";
            
            DataTable dt_datosExportar = this.getDatos(p_type);
            if (dt_datosExportar == null)
            {
                errorActual = "Ha surgido un error inesperado al exportar.";
                return false;   
            }
            if (dt_datosExportar.Rows.Count < 1)
            {
                errorActual = "No existen datos para exportar.";
                return false;   
            }

            if (lcl_conXML.escribirExcel(dt_datosExportar, direccionDeArchivo))
            {
                errorActual = "Exportación de datos exitosa.";
                return true;
            }
            else
            {
                errorActual = lcl_conXML.errorActual;
                return false;
            }
        }
        private DataTable getDatos(Type p_type)
        {
            List<Object> lcl_lst_objetosExportar = new List<object>();
            
            if (p_type == typeof(ModeloArticuloProveedores))
            {
                lcl_lst_objetosExportar = ControladorBusqueda.getArticulosProveedores().Cast<object>().ToList();
            }
            else if (p_type == typeof(ModeloArticulos))
            {
                lcl_lst_objetosExportar = ControladorBusqueda.getArticulos().Cast<object>().ToList();
            }
            else if (p_type == typeof(ModeloCliente))
            {
                lcl_lst_objetosExportar = ControladorBusqueda.getClientes().Cast<object>().ToList();
            }
            else if (p_type == typeof(ModeloProveedor))
            {
                lcl_lst_objetosExportar = ControladorBusqueda.getProveedores().Cast<object>().ToList();
            }
            else
            {
                return null;
            }

            return this.insertarDatosEnDataTable(lcl_lst_objetosExportar);
        }
        private DataTable insertarDatosEnDataTable(List<object> lcl_lst_datos)
        {
            DataTable lcl_dataTableDatosExportar = new DataTable();
            if (lcl_lst_datos.Count < 1)
            {
                return lcl_dataTableDatosExportar;//retorna dataTable sin rows para mostrar que no hay datos
            }
            
            lcl_dataTableDatosExportar = this.exportar_getDataTable(lcl_lst_datos[0].GetType());

            DataRow row;
            foreach (object o in lcl_lst_datos)
            {
                row = lcl_dataTableDatosExportar.NewRow();
                this.insertarDatosEnDataTableRow(row,o);
                lcl_dataTableDatosExportar.Rows.Add(row);
            }

            return lcl_dataTableDatosExportar;
        }

        private void insertarDatosEnDataTableRow(DataRow row, object p_object)
        {
            Type T = p_object.GetType();
            if (T == typeof(ModeloArticuloProveedores))
            {
                insertarDatosEnDataTableRow(row, p_object as ModeloArticuloProveedores);
            }
            else if (T == typeof(ModeloArticulos))
            {
                insertarDatosEnDataTableRow(row, p_object as ModeloArticulos);
            }
            else if (T == typeof(ModeloCliente))
            {
                insertarDatosEnDataTableRow(row, p_object as ModeloCliente);
            }
            else if (T == typeof(ModeloProveedor))
            {
                insertarDatosEnDataTableRow(row, p_object as ModeloProveedor);
            }
            else
            {
                return ;
            }
        }
        private void insertarDatosEnDataTableRow(DataRow row, ModeloCliente p_cliente)
        {
            row["Código Entidad"] = p_cliente.codigo.ToString();
            row["Nombre"] = p_cliente.nombre;
            row["Apellido"] = p_cliente.apellido;
            row["DNI"] = p_cliente.dni;
            row["CUIT"] = p_cliente.cuit;
            row["Observaciones"] = p_cliente.observaciones;
        }
        private void insertarDatosEnDataTableRow(DataRow row, ModeloProveedor p_proveedor)
        {
            row["Código Entidad"] = p_proveedor.codigo.ToString();
            row["Razón Social"] = p_proveedor.razonSocial;
            row["CUIT"] = p_proveedor.cuit;
            row["Observaciones"] = p_proveedor.observaciones;
        }
        private void insertarDatosEnDataTableRow(DataRow row, ModeloArticulos p_articulo)
        {
            row["Código Original"] = p_articulo.codigoOriginal.ToString();
            row["Descripción"] = p_articulo.descripcion;
            row["Modelos"] = p_articulo.modelos;
            row["Observaciones"] = p_articulo.observaciones;
        }
        private void insertarDatosEnDataTableRow(DataRow row, ModeloArticuloProveedores p_articuloProveedor)
        {
            row["Código Original"] = p_articuloProveedor.codigoOriginal;
            row["Código Artículo Proveedor"] = p_articuloProveedor.codigoArticuloProveedor;
            row["Código Entidad"] = p_articuloProveedor.codigoEntidad.ToString();
            row["Descripción"] = p_articuloProveedor.descripcionArticuloProveedor;
            row["Precio Compra"] = p_articuloProveedor.valorCompra.valorArticulo != null ? p_articuloProveedor.valorCompra.valorArticulo.ToString() : null;
            row["Precio Venta"] = p_articuloProveedor.valorVenta.valorArticulo != null?p_articuloProveedor.valorVenta.valorArticulo.ToString() : null;
            row["Stock Mínimo"] = p_articuloProveedor.stockMinimo != null?p_articuloProveedor.stockMinimo.ToString():null;
            row["Stock Actual"] = p_articuloProveedor.stockActual != null ? p_articuloProveedor.stockActual.ToString() : null;
            row["Ubicación"] = p_articuloProveedor.ubicacion;
            row["Observaciones"] = p_articuloProveedor.observacionesArticuloProveedor;
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
     
        #region Atributos
        public bool esValorVenta;
        #endregion

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
            Datos.ConexionOpenXML lcl_con_excel = new Datos.ConexionOpenXML();
            return lcl_con_excel.leerExcel_preview(p_path, cantidadAtributos);
        }

        public bool importarDatos(string p_path, Type T, List<int?> p_indiceAtributo, bool p_primeraRowHeaders, out string p_respuesta)
        {
            p_respuesta = null;

            DataTable lcl_dataTable = this.getDataTable(T);

            if (lcl_dataTable == null)
            {
                p_respuesta = "Ha surgido un error inesperado. No se ha reconocido el tipo de datos que se desea importar.";
                return false;
            }
            Datos.ConexionOpenXML ExcelReader = new Datos.ConexionOpenXML();
            if (!ExcelReader.leerExcel(p_path, p_indiceAtributo, ref lcl_dataTable, p_primeraRowHeaders))
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

        #region DataTable -> Modelos
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

                lcl_mod_articulo.codigoOriginal = row["Código Original"].ToString();
                lcl_mod_articulo.descripcion = row["Descripción"].ToString();
                lcl_mod_articulo.modelos = string.IsNullOrWhiteSpace(row["Modelos"].ToString()) ? null : row["Modelos"].ToString();
                lcl_mod_articulo.observaciones = string.IsNullOrWhiteSpace(row["Observaciones"].ToString()) ? null : row["Observaciones"].ToString();

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

                lcl_mod_articuloProveedor.codigoOriginal = row["Código Original"].ToString();
                lcl_mod_articuloProveedor.codigoArticuloProveedor = row["Código Artículo Proveedor"].ToString();
                if (Int32.TryParse(row["Código Entidad"].ToString(), out int_aux))
                { lcl_mod_articuloProveedor.codigoEntidad = int_aux; }
                else
                { lcl_mod_articuloProveedor.codigoEntidad = 0; }
                lcl_mod_articuloProveedor.descripcionArticuloProveedor = string.IsNullOrWhiteSpace(row["Descripción"].ToString()) ? null : row["Descripción"].ToString();

                if (Transformar.ToDecimal(row["Precio Compra"].ToString(), out dec_aux))
                { lcl_mod_articuloProveedor.valorCompra.valorArticulo = dec_aux; }
                else
                { lcl_mod_articuloProveedor.valorCompra.valorArticulo = null; }
                
                if (Transformar.ToDecimal(row["Precio Venta"].ToString(), out dec_aux))
                { lcl_mod_articuloProveedor.valorVenta.valorArticulo = dec_aux; }
                else
                { lcl_mod_articuloProveedor.valorVenta.valorArticulo = null; }

                if (Int32.TryParse(row["Stock Mínimo"].ToString(), out int_aux))
                { lcl_mod_articuloProveedor.stockMinimo = int_aux; }
                else
                { lcl_mod_articuloProveedor.stockMinimo = null; }
                if (Int32.TryParse(row["Stock Actual"].ToString(), out int_aux))
                { lcl_mod_articuloProveedor.stockActual = int_aux; }
                else
                { lcl_mod_articuloProveedor.stockActual = null; }
                
                lcl_mod_articuloProveedor.ubicacion = string.IsNullOrWhiteSpace(row["Ubicación"].ToString()) ? null : row["Ubicación"].ToString();
                lcl_mod_articuloProveedor.observaciones = string.IsNullOrWhiteSpace(row["Observaciones"].ToString()) ? null : row["Observaciones"].ToString();

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

                lcl_mod_cliente.dni = row["DNI"].ToString();
                lcl_mod_cliente.nombre = row["Nombre"].ToString();
                lcl_mod_cliente.apellido = row["Apellido"].ToString();
                lcl_mod_cliente.cuit = string.IsNullOrWhiteSpace(row["CUIT"].ToString()) ? null : row["CUIT"].ToString();
                lcl_mod_cliente.observaciones = string.IsNullOrWhiteSpace(row["Observaciones"].ToString()) ? null : row["Observaciones"].ToString();

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

                lcl_mod_proveedor.cuit = row["CUIT"].ToString();
                lcl_mod_proveedor.razonSocial = row["Razón Social"].ToString();
                lcl_mod_proveedor.observaciones = string.IsNullOrWhiteSpace(row["Observaciones"].ToString()) ? null : row["Observaciones"].ToString();

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

                lcl_mod_articuloProveedore.codigoOriginal  = row["Código Original"].ToString();
                lcl_mod_articuloProveedore.codigoArticuloProveedor = row["Código Artículo Proveedor"].ToString();

                if (Transformar.ToDecimal(row["valor"].ToString(), out dec_aux))
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

        #endregion

        #region Compartido
        private DataTable getDataTable(Type T)
        {
            if (T == typeof(ModeloArticuloProveedores))
            {
                return this.getDataTable_ArticuloProveedor();
            }
            else if (T == typeof(ModeloArticulos))
            {
                return this.getDataTable_Articulo();
            }
            else if (T == typeof(ModeloCliente))
            {
                return this.getDataTable_Cliente();
            }
            else if (T == typeof(ModeloProveedor))
            {
                return this.getDataTable_Proveedor();
            }
            else if (T == typeof(ModeloValorArticulo))
            {
                return this.getDataTable_ValorArticuloProveedor();
            }

            return null;
        }
        private DataTable exportar_getDataTable(Type T)
        {
            if (T == typeof(ModeloCliente))
            {
                return getDataTable_Cliente_Exportar();
            }
            else if (T == typeof(ModeloProveedor))
            {
                return getDataTable_Proveedor_Exportar();
            }
            else
            {
                return this.getDataTable(T);
            }

            return null;
        }
        private DataTable getDataTable_Articulo()
        {
            DataTable lcl_dataTable = new DataTable();

            lcl_dataTable.Columns.Add("Código Original");
            lcl_dataTable.Columns.Add("Descripción");
            lcl_dataTable.Columns.Add("Modelos");
            lcl_dataTable.Columns.Add("Observaciones");

            return lcl_dataTable;
        }
        private DataTable getDataTable_ArticuloProveedor()
        {
            DataTable lcl_dataTable = new DataTable();

            lcl_dataTable.Columns.Add("Código Original");
            lcl_dataTable.Columns.Add("Código Artículo Proveedor");
            lcl_dataTable.Columns.Add("Código Entidad");
            lcl_dataTable.Columns.Add("Descripción");
            lcl_dataTable.Columns.Add("Precio Compra");
            lcl_dataTable.Columns.Add("Precio Venta");
            lcl_dataTable.Columns.Add("Stock Mínimo");
            lcl_dataTable.Columns.Add("Stock Actual");
            lcl_dataTable.Columns.Add("Ubicación");
            lcl_dataTable.Columns.Add("Observaciones");

            return lcl_dataTable;
        }
        private DataTable getDataTable_Cliente_Exportar()
        {
            DataTable lcl_dataTable = new DataTable();
            lcl_dataTable = this.getDataTable_Cliente();
            lcl_dataTable.Columns.Add("Código Entidad");
            //lcl_dataTable.Columns["Código Entidad"].SetOrdinal(0);
            return lcl_dataTable;
        }
        private DataTable getDataTable_Cliente()
        {
            DataTable lcl_dataTable = new DataTable();

            lcl_dataTable.Columns.Add("DNI");
            lcl_dataTable.Columns.Add("Nombre");
            lcl_dataTable.Columns.Add("Apellido");
            lcl_dataTable.Columns.Add("CUIT");
            lcl_dataTable.Columns.Add("Observaciones");

            return lcl_dataTable;
        }
        private DataTable getDataTable_Proveedor_Exportar()
        {
            DataTable lcl_dataTable = new DataTable();
            lcl_dataTable = this.getDataTable_Proveedor();
            lcl_dataTable.Columns.Add("Código Entidad");
            //lo dejamos al final para que cuando importe datos no moleste estando primero. Nos consume una columna
            //lcl_dataTable.Columns["Código Entidad"].SetOrdinal(0);
            return lcl_dataTable;
        }
        private DataTable getDataTable_Proveedor()
        {
            DataTable lcl_dataTable = new DataTable();

            lcl_dataTable.Columns.Add("CUIT");
            lcl_dataTable.Columns.Add("Razón Social");
            lcl_dataTable.Columns.Add("Observaciones");

            return lcl_dataTable;
        }
        private DataTable getDataTable_ValorArticuloProveedor()
        {
            DataTable lcl_dataTable = new DataTable();

            lcl_dataTable.Columns.Add("Código Original");
            lcl_dataTable.Columns.Add("Código Artículo Proveedor");
            lcl_dataTable.Columns.Add("valor");

            return lcl_dataTable;
        }
        #endregion
    }
}