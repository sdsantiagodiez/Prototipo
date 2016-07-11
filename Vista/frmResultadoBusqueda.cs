using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladores;
using Modelos;
using LibreriaClasesCompartidas;


namespace Vista
{
    /// <summary>
    /// Hay dos formas de usar el formulario.
    /// 1) Mostrar Form conteniendo datagridview de resultado de búsqueda
    /// 2) Obtener datagridview de resultado de búsqueda
    /// 
    /// Para el caso 1, se utiliza constructor sin parámetros y luego método mostrarResultados(objeto)
    /// Para el caso 2, se utiliza constructor con 1 o dos parámetros y luego métodos mostrarResultados() sin parámetros
    /// </summary>
    public partial class frmResultadoBusqueda : frmMaterialSkinBase
    {
        #region Atributos
        private Object _modeloSeleccionado;
        public Object modeloSeleccionado
        {
            get { return _modeloSeleccionado; }
            set { _modeloSeleccionado = value;}
        }
        List<Object> glb_lst_objectos;
        
        public DataGridView dataGridViewResultadoBusqueda;

        const int AnchoVentana = 800;
        #endregion

        #region Constructores
        public frmResultadoBusqueda()
        {
            InitializeComponent();
            
            this.inicializarFormulario();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        /// <summary>
        /// Hace búsqueda con el objeto y lanza resultados en atributo dataGridViewResultadoBusqueda de haberse encontrado algo
        /// </summary>
        /// <param name="p_objeto"></param>
        public frmResultadoBusqueda(Object p_objeto) : this()
        {
            this.hacerBusqueda(p_objeto);
        }
        /// <summary>
        /// Asigna título a formulario
        /// </summary>
        /// <param name="p_objeto"></param>
        /// <param name="p_titulo"></param>
        public frmResultadoBusqueda(Object p_objeto, string p_titulo)
            : this(p_objeto)
        {
            this.Text = p_titulo;
        }
        #endregion

        #region Métodos
        #region Inicialización

        #region InicializarDGV
        private void inicializarDataGridViewResultadoBusqueda_Entidades()
        {
            int i = dataGridViewResultadoBusqueda.Columns.Count;

            dataGridViewResultadoBusqueda.Columns.Add("tipo", "Tipo");
            dataGridViewResultadoBusqueda.Columns[i].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("codigoEntidad", "Código");
            dataGridViewResultadoBusqueda.Columns[i++].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("cuit", "CUIT");
            dataGridViewResultadoBusqueda.Columns[i++].FillWeight = 1;
        }
        private void inicializarDataGridViewResultadoBusqueda_Proveedores()
        {
            this.inicializarDataGridViewResultadoBusqueda_Entidades();
            int i = dataGridViewResultadoBusqueda.Columns.Count;

            dataGridViewResultadoBusqueda.Columns.Add("razonSocial", "Razón Social");
            dataGridViewResultadoBusqueda.Columns[i].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("direccion", "Domicilio");
            dataGridViewResultadoBusqueda.Columns[i++].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("ciudad", "Ciudad Domicilio");
            dataGridViewResultadoBusqueda.Columns[i++].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("provincia", "Provincia Domicilio");
            dataGridViewResultadoBusqueda.Columns[i++].FillWeight = 1;
        }
        private void inicializarDataGridViewResultadoBusqueda_Personas()
        {
            this.inicializarDataGridViewResultadoBusqueda_Entidades();
            int i = dataGridViewResultadoBusqueda.Columns.Count;

            dataGridViewResultadoBusqueda.Columns.Add("dni", "DNI");
            dataGridViewResultadoBusqueda.Columns[i].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("apellido", "Apellido");
            dataGridViewResultadoBusqueda.Columns[i++].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("nombre", "Nombre");
            dataGridViewResultadoBusqueda.Columns[i++].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("direccion", "Domicilio");
            dataGridViewResultadoBusqueda.Columns[i++].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("ciudad", "Ciudad Domicilio");
            dataGridViewResultadoBusqueda.Columns[i++].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("provincia", "Provincia Domicilio");
            dataGridViewResultadoBusqueda.Columns[i++].FillWeight = 1;
        }
        private void inicializarDataGridViewResultadoBusqueda_Usuario()
        {
            this.inicializarDataGridViewResultadoBusqueda_Personas();
            int i = dataGridViewResultadoBusqueda.Columns.Count;

            dataGridViewResultadoBusqueda.Columns.Add("Usuario", "usuario");
            dataGridViewResultadoBusqueda.Columns[i].FillWeight = 1;
        }
        private void inicializarDataGridViewResultadoBusqueda_ContactoProveedor()
        {
            this.inicializarDataGridViewResultadoBusqueda_Personas();
            int i = dataGridViewResultadoBusqueda.Columns.Count;

            dataGridViewResultadoBusqueda.Columns.Add("razon_social_proveedor", "Proveedor");
            dataGridViewResultadoBusqueda.Columns[i].FillWeight = 1;
        }
        private void inicializarDataGridViewResultadoBusqueda_Cliente()
        {
            this.inicializarDataGridViewResultadoBusqueda_Personas();
        }

        private void inicializarDataGridViewResultadoBusqueda_Articulos()
        {
            int i = dataGridViewResultadoBusqueda.Columns.Count;

            dataGridViewResultadoBusqueda.Columns.Add("codigoOriginal", "Código");
            dataGridViewResultadoBusqueda.Columns[i].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("descripcion", "Descripción");
            dataGridViewResultadoBusqueda.Columns[i++].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("modelos", "Modelos");
            dataGridViewResultadoBusqueda.Columns[i++].FillWeight = 1;
        }
        private void inicializarDataGridViewResultadoBusqueda_ArticulosProveedores()
        {
            this.inicializarDataGridViewResultadoBusqueda_Articulos();

            int i = dataGridViewResultadoBusqueda.Columns.Count;

            dataGridViewResultadoBusqueda.Columns.Add("codigoArticuloProveedor", "Código Artículo");
            dataGridViewResultadoBusqueda.Columns[i++].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("descripcionArticuloProveedor", "Descripción Articulo");
            dataGridViewResultadoBusqueda.Columns[i++].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("codigoEntidad", "Código Proveedor");
            dataGridViewResultadoBusqueda.Columns[i++].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("razonSocialProveedor", "Proveedor");
            dataGridViewResultadoBusqueda.Columns[i++].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("valorVenta", "Valor Venta");
            dataGridViewResultadoBusqueda.Columns[i++].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("valorCompra", "Valor Compra");
            dataGridViewResultadoBusqueda.Columns[i++].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("stockMinimo", "Stock Mínimo");
            dataGridViewResultadoBusqueda.Columns[i++].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("stockActual", "Stock Actual");
            dataGridViewResultadoBusqueda.Columns[i++].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("ubicacion", "Ubicación");
            dataGridViewResultadoBusqueda.Columns[i++].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("fechaActualizacion", "Fecha Última Actualización");
            dataGridViewResultadoBusqueda.Columns[i++].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns[i-1].DefaultCellStyle.Format = "dd/MM/yyyy";
        }
        private void inicializarDataGridViewResultadoBusqueda_Pedidos()
        {
            int i = dataGridViewResultadoBusqueda.Columns.Count;

            dataGridViewResultadoBusqueda.Columns.Add("numero_pedido", "Numero Pedido");
            dataGridViewResultadoBusqueda.Columns[i++].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("fecha", "Fecha Pedido");
            dataGridViewResultadoBusqueda.Columns[i++].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns[i - 1].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridViewResultadoBusqueda.Columns.Add("codigoEntidad", "Código Cliente");
            dataGridViewResultadoBusqueda.Columns[i++].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("nombre_entidad", "Nombre Cliente");
            dataGridViewResultadoBusqueda.Columns[i++].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("apellido_entidad", "Apellido Cliente");
            dataGridViewResultadoBusqueda.Columns[i++].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("monto_total", "Monto");
            dataGridViewResultadoBusqueda.Columns[i++].FillWeight = 1;
            
        }

        #endregion

        #region Inicialización Formulario
        private void inicializarFormulario()
        {
            this.Width = AnchoVentana;
            this.FormClosing += frmResultadoBusqueda_FormClosing;

            this.pnlBase.Location = new Point(0,60);
            this.pnlBase.Width = this.Width;
            this.pnlBase.Height = this.Height - 60;
        }

        private void inicializarMostrarBusqueda(object p_objeto)
        {
            /*
             Se los nullifica ya que más adelante se utilizará la lista no null para devolver el resultado en método asignarResultado
             */
            this.pnlBase.Controls.Clear();
            this.BringToFront();
            this.inicializarDataGridViewResultadoBusqueda(p_objeto);
            this.pnlBase.Controls.Add(dataGridViewResultadoBusqueda);
            modeloSeleccionado = null;
            glb_lst_objectos = null;
        }

        #endregion

        private DataGridView inicializarDataGridViewResultadoBusqueda(Object p_objeto)
        {
            dataGridViewResultadoBusqueda = new DataGridView();
            this.dataGridViewResultadoBusqueda.Dock = DockStyle.Fill;
            dataGridViewResultadoBusqueda.AutoGenerateColumns = false;
            dataGridViewResultadoBusqueda.ReadOnly = true;
            dataGridViewResultadoBusqueda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewResultadoBusqueda.RowHeadersVisible = false;
            //dataGridViewResultadoBusqueda.CellContentDoubleClick += dataGridViewResultadoBusqueda_CellContentDoubleClick;
            dataGridViewResultadoBusqueda.CellDoubleClick += dataGridViewResultadoBusqueda_CellContentDoubleClick;
            dataGridViewResultadoBusqueda.Columns.Add("dgbKey", "KEY");
            dataGridViewResultadoBusqueda.Columns[0].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns[0].Visible = false;
            dataGridViewResultadoBusqueda.AllowUserToAddRows = false;

            dataGridViewResultadoBusqueda.Width = AnchoVentana;
            this.Text = "Resultado de Búsqueda de ";

            Type T = p_objeto.GetType();
            if (T == typeof(ModeloArticuloProveedores))
            {
                this.inicializarDataGridViewResultadoBusqueda_ArticulosProveedores();
            } 
            else if(T == typeof(ModeloArticulos))
            {
                this.inicializarDataGridViewResultadoBusqueda_Articulos();
            } 
            else if(T == typeof(ModeloEntidad))
            {
                this.inicializarDataGridViewResultadoBusqueda_Entidades();;
            } 
            else if(T == typeof(ModeloPersonas))
            {
                this.inicializarDataGridViewResultadoBusqueda_Personas();
            } 
            else if(T == typeof(ModeloProveedor))
            {
                this.inicializarDataGridViewResultadoBusqueda_Proveedores();
            } 
            else if(T == typeof(ModeloUsuario))
            {
                this.inicializarDataGridViewResultadoBusqueda_Usuario();
            } 
            else if(T == typeof(ModeloContactoProveedor))
            {
                this.inicializarDataGridViewResultadoBusqueda_ContactoProveedor();
            } 
            else if(T == typeof(ModeloCliente))
            {
                this.inicializarDataGridViewResultadoBusqueda_Cliente();
            }
            else if (T == typeof(ModeloPedido))
            {
                this.inicializarDataGridViewResultadoBusqueda_Pedidos();
            }
            if(this.Text == "")
            {
                this.asignarTitulo(T);
            }

            return dataGridViewResultadoBusqueda;
        }
        
        private void insertarIndice()
        {
            for (int i = 1; i < dataGridViewResultadoBusqueda.Rows.Count; i++)
            {
                dataGridViewResultadoBusqueda.Rows[i].Cells[0].Value = i;
            }
        }

        private void asignarTitulo(Type T)
        {
            
            if (T == typeof(ModeloArticuloProveedores))
            {
                
            }
            else if (T == typeof(ModeloArticulos))
            {
                this.Text += "Artículos";
            }
            else if (T == typeof(ModeloEntidad))
            {
                this.Text += "Entidades";
            }
            else if (T == typeof(ModeloPersonas))
            {
                this.Text += "Personas";
            }
            else if (T == typeof(ModeloProveedor))
            {
                this.Text += "Proveedores";
            }
            else if (T == typeof(ModeloUsuario))
            {
                this.Text += "Usuarios";
            }
            else if (T == typeof(ModeloContactoProveedor))
            {
                this.Text += "Contactos de Proveedores";
            }
            else if (T == typeof(ModeloCliente))
            {
                this.Text += "Clientes";
            }
            else if (T == typeof(ModeloPedido))
            {
                this.Text += "Pedidos";
            }
        }

        

        #endregion
        
        #region Modelo -> Controles
        private DataGridView popularDataGridViewResultadoBusqueda(List<object> p_lst_objetos)
        {
            Type T = p_lst_objetos[0].GetType();
            if (T == typeof(ModeloArticulos))
            {
                return this.popularDataGridViewResultadoBusqueda(p_lst_objetos.Cast<ModeloArticulos>().ToList());
            }
            else if (T == typeof(ModeloArticuloProveedores))
            {
                return this.popularDataGridViewResultadoBusqueda(p_lst_objetos.Cast<ModeloArticuloProveedores>().ToList());
            }
            else if (T == typeof(ModeloPedido))
            {
                return this.popularDataGridViewResultadoBusqueda(p_lst_objetos.Cast<ModeloPedido>().ToList());
            }
            else
            {
                return this.popularDataGridViewResultadoBusqueda(p_lst_objetos.Cast<ModeloEntidad>().ToList());
            }
        }

        private DataGridView popularDataGridViewResultadoBusqueda(List<ModeloEntidad> p_lst_mod_entidad)
        {
            int rowIndex;
            DataGridViewRow row;
            foreach (ModeloEntidad lcl_mod_entidad in p_lst_mod_entidad)
            {
                rowIndex = this.dataGridViewResultadoBusqueda.Rows.Add();
                row = this.dataGridViewResultadoBusqueda.Rows[rowIndex];

                this.cargarDatosEntidadEnRow(lcl_mod_entidad, ref row);
            }
            return dataGridViewResultadoBusqueda;
        }
        private void cargarDatosEntidadEnRow(ModeloEntidad p_mod_entidad, ref DataGridViewRow row)
        {
            row.Cells["tipo"].Value = p_mod_entidad.tipoEntidad;
            row.Cells["codigoEntidad"].Value = p_mod_entidad.codigo;
            row.Cells["cuit"].Value = p_mod_entidad.cuit;
            row.Cells["direccion"].Value = p_mod_entidad.domicilios.Count == 0 ? "Sin datos" : p_mod_entidad.domicilios[0].calle + " " + p_mod_entidad.domicilios[0].numero;
            row.Cells["ciudad"].Value = p_mod_entidad.domicilios.Count == 0 ? "Sin datos" : p_mod_entidad.domicilios[0].ciudad;
            row.Cells["provincia"].Value = p_mod_entidad.domicilios.Count == 0 ? "Sin datos" : p_mod_entidad.domicilios[0].provincia.provincia;

            if (p_mod_entidad.GetType() == typeof(ModeloProveedor))
            {
                this.cargarDatosProveedorEnRow(p_mod_entidad as ModeloProveedor, ref row);
            }
            else
            {
                this.cargarDatosPersonaEnRow(p_mod_entidad as ModeloPersonas, ref row);
            }

        }
        private void cargarDatosProveedorEnRow(ModeloProveedor p_mod_proveedor, ref DataGridViewRow row)
        {
            row.Cells["razonSocial"].Value = p_mod_proveedor.razonSocial;
        }
        private void cargarDatosPersonaEnRow(ModeloPersonas p_mod_persona, ref DataGridViewRow row)
        {
            row.Cells["dni"].Value = p_mod_persona.dni;
            row.Cells["apellido"].Value = p_mod_persona.apellido;
            row.Cells["nombre"].Value = p_mod_persona.nombre;
            if (p_mod_persona.GetType() == typeof(ModeloUsuario))
            {
                this.cargarDatosUsuarioEnRow(p_mod_persona as ModeloUsuario, ref row);
            }
            else if (p_mod_persona.GetType() == typeof(ModeloContactoProveedor))
            {
                this.cargarDatosContactoProveedorEnRow(p_mod_persona as ModeloContactoProveedor, ref row);
            }
            else if (p_mod_persona.GetType() == typeof(ModeloCliente))
            {
                this.cargarDatosClienteEnRow(p_mod_persona as ModeloCliente, ref row);
            }
        }
        private void cargarDatosContactoProveedorEnRow(ModeloContactoProveedor p_mod_contactoProveedor, ref DataGridViewRow row)
        {
            row.Cells["tipo"].Value = p_mod_contactoProveedor.tipoPersona;

            row.Cells["razon_social_proveedor"].Value = p_mod_contactoProveedor.proveedor.razonSocial;
        }
        private void cargarDatosUsuarioEnRow(ModeloUsuario p_mod_usuario, ref DataGridViewRow row)
        {
            row.Cells["tipo"].Value = p_mod_usuario.tipoPersona;

            row.Cells["usuario"].Value = p_mod_usuario.usuario;
        }
        private void cargarDatosClienteEnRow(ModeloCliente p_mod_cliente, ref DataGridViewRow row)
        {
            row.Cells["tipo"].Value = p_mod_cliente.tipoPersona;
        }
        private void cargarDatosPedidoEnRow(ModeloPedido p_mod_pedido, ref DataGridViewRow row)
        {
            row.Cells["numero_pedido"].Value = p_mod_pedido.numeroPedido;
            row.Cells["codigoEntidad"].Value = p_mod_pedido.entidad.codigo;
            row.Cells["fecha"].Value = p_mod_pedido.fecha;
            //Aca pasa null cuando los clientes son genericos
            row.Cells["nombre_entidad"].Value = (p_mod_pedido.entidad as ModeloCliente).nombre ;
            row.Cells["apellido_entidad"].Value = (p_mod_pedido.entidad as ModeloCliente).apellido;
            row.Cells["monto_total"].Value = p_mod_pedido.montoTotal;
        }
        private DataGridView popularDataGridViewResultadoBusqueda(List<ModeloPedido> p_lst_mod_pedido)
        {
            int rowIndex;
            DataGridViewRow row;
            foreach (ModeloPedido a in p_lst_mod_pedido)
            {
                rowIndex = this.dataGridViewResultadoBusqueda.Rows.Add();
                row = this.dataGridViewResultadoBusqueda.Rows[rowIndex];

                this.cargarDatosPedidoEnRow(a, ref row);
            }
            return dataGridViewResultadoBusqueda;
        }
        private DataGridView popularDataGridViewResultadoBusqueda(List<ModeloArticulos> p_lst_mod_articulo)
        {
            int rowIndex;
            DataGridViewRow row;
            foreach (ModeloArticulos a in p_lst_mod_articulo)
            {
                rowIndex = this.dataGridViewResultadoBusqueda.Rows.Add();
                row = this.dataGridViewResultadoBusqueda.Rows[rowIndex];

                this.cargarDatosArticuloEnRow(a, ref row);
            }
            return dataGridViewResultadoBusqueda;
        }
        private void cargarDatosArticuloEnRow(ModeloArticulos p_mod_articulo, ref DataGridViewRow row)
        {
            row.Cells["codigoOriginal"].Value = p_mod_articulo.codigoOriginal.ToString();
            row.Cells["descripcion"].Value = p_mod_articulo.descripcion;
            row.Cells["modelos"].Value = p_mod_articulo.modelos;
        }

        private DataGridView popularDataGridViewResultadoBusqueda(List<ModeloArticuloProveedores> p_lst_mod_articuloProveedor)
        {
            int rowIndex;
            DataGridViewRow row;
            foreach (ModeloArticuloProveedores ap in p_lst_mod_articuloProveedor)
            {
                rowIndex = this.dataGridViewResultadoBusqueda.Rows.Add();
                row = this.dataGridViewResultadoBusqueda.Rows[rowIndex];

                this.cargarDatosArticuloEnRow(ap as ModeloArticulos, ref row);

                this.cargarDatosArticuloProveedorEnRow(ap, ref row);
            }

            return dataGridViewResultadoBusqueda;
        }
        private void cargarDatosArticuloProveedorEnRow(ModeloArticuloProveedores p_mod_articuloProveedor, ref DataGridViewRow row)
        {
            row.Cells["codigoArticuloProveedor"].Value = p_mod_articuloProveedor.codigoArticuloProveedor;
            row.Cells["descripcionArticuloProveedor"].Value = p_mod_articuloProveedor.descripcionArticuloProveedor;
            row.Cells["codigoEntidad"].Value = p_mod_articuloProveedor.codigoEntidad;
            row.Cells["razonSocialProveedor"].Value = p_mod_articuloProveedor.razonSocialProveedor;

            row.Cells["valorVenta"].Value = p_mod_articuloProveedor.valorVenta.valorArticulo.ToString();
            row.Cells["valorCompra"].Value = p_mod_articuloProveedor.valorCompra.valorArticulo.ToString();
            row.Cells["stockMinimo"].Value = p_mod_articuloProveedor.stockMinimo.ToString();
            row.Cells["stockActual"].Value = p_mod_articuloProveedor.stockActual.ToString();
            row.Cells["ubicacion"].Value = p_mod_articuloProveedor.ubicacion;
            row.Cells["fechaActualizacion"].Value = p_mod_articuloProveedor.fechaActualizacion;
        }
        #endregion
        
        #region Búsqueda
        /// <summary>
        /// muestra búsqueda cuando se ha utilizado constructor constructor(object p_objeto)
        /// </summary>
        public void mostrarBusqueda()
        {
            int cantidadResultados = glb_lst_objectos.Count;
            if (cantidadResultados > 0)
            {
                string s = "";
                if(cantidadResultados > 1)
                    s = "s";
                this.Text += " ("+cantidadResultados.ToString()+" resultado"+s+" encontrado"+s+")";
                this.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se han encontrado resultados", "Resultado de búsqueda", MessageBoxButtons.OK);
            }
        }

        public void mostrarBusqueda(Object p_objeto)
        {
            this.hacerBusqueda(p_objeto);

            this.mostrarBusqueda();
        }

        private void hacerBusqueda(Object p_objeto)
        {
            this.inicializarMostrarBusqueda(p_objeto);
            glb_lst_objectos = ControladorBusqueda.buscar(p_objeto);

            if (glb_lst_objectos.Count != 0)
            {
                this.popularDataGridViewResultadoBusqueda(glb_lst_objectos);
                this.insertarIndice();
            }
        }

        #endregion
        #endregion

        #region Eventos
        void frmResultadoBusqueda_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true; // this cancels the close event.
        }
        void dataGridViewResultadoBusqueda_CellContentDoubleClick(object sender, EventArgs e)
        {
            //toma el valor de la primera columna que no se muestra en la tabla. La misma funciona como índice y no se ve afectada por ordenamiento de tabla
            int indice = Convert.ToInt32(dataGridViewResultadoBusqueda.CurrentRow.Cells[0].Value);
            modeloSeleccionado = glb_lst_objectos[indice];

            this.Hide();
        }
        #endregion
    }
}
