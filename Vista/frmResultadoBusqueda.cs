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
    public partial class frmResultadoBusqueda : Form
    {
        const int AnchoVentana = 800;
        private DataGridView dataGridViewResultadoBusqueda;
        
        public frmResultadoBusqueda()
        {
            InitializeComponent();
            this.inicializarFormulario();
        }
        
        private void inicializarFormulario()
        {
            this.Width = AnchoVentana;
            this.FormClosing += frmResultadoBusqueda_FormClosing;
        }

        private void inicializarMostrarBusqueda(string p_tipo)
        {
            /*
             Se los nullifica ya que más adelante se utilizará la lista no null para devolver el resultado en método asignarResultado
             */
            this.Controls.Clear();
            this.BringToFront();
            this.inicializarDataGridViewResultadoBusqueda(p_tipo);
            this.Controls.Add(dataGridViewResultadoBusqueda);
            glb_lst_mod_personas = null;
            glb_lst_mod_proveedor = null;
            glb_lst_mod_articulos = null;
            glb_lst_mod_articuloProveedores = null;
        }

        private void mostrarMensajeResultadoVacio()
        {
            MessageBox.Show("No se han encontrado resultados", "Resultado de búsqueda", MessageBoxButtons.OK);
        }

        private void asignarResultado(int p_indice)
        {
            glb_mod_persona = null;
            glb_mod_proveedor = null;
            glb_mod_articulo = null;
            glb_mod_articuloProveedor = null;

            if (glb_lst_mod_proveedor != null)
            {
                glb_mod_proveedor = glb_lst_mod_proveedor[p_indice];
            }
            else
            {
                if (glb_lst_mod_personas != null)
                {
                    glb_mod_persona = glb_lst_mod_personas[p_indice];
                }
                else
                {
                    if (glb_lst_mod_articulos != null)
                    {
                        glb_mod_articulo = glb_lst_mod_articulos[p_indice];
                    }
                    else
                    {
                        if (glb_lst_mod_articuloProveedores != null)
                        {
                            glb_mod_articuloProveedor = glb_lst_mod_articuloProveedores[p_indice];
                        }
                    }
                }
            }
        }

        //Se podría ampliar para que este método también muestre artículos u otros resultados de búsqueda
        private DataGridView inicializarDataGridViewResultadoBusqueda(string p_tipoModelo)
        {
            dataGridViewResultadoBusqueda = new DataGridView();
            this.dataGridViewResultadoBusqueda.Dock = DockStyle.Fill;
            dataGridViewResultadoBusqueda.AutoGenerateColumns = false;
            dataGridViewResultadoBusqueda.ReadOnly = true;
            dataGridViewResultadoBusqueda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewResultadoBusqueda.RowHeadersVisible = false;
            dataGridViewResultadoBusqueda.CellContentDoubleClick += dataGridViewResultadoBusqueda_CellContentDoubleClick;

            dataGridViewResultadoBusqueda.Width = AnchoVentana;

            switch (p_tipoModelo)
            {
                case LibreriaClasesCompartidas.Constantes.TiposEntidad.Proveedor:
                    this.inicializarDataGridViewResultadoBusqueda_Entidades();
                    this.inicializarDataGridViewResultadoBusqueda_Proveedores();
                    break;
                case LibreriaClasesCompartidas.Constantes.TiposEntidad.Persona:
                    this.inicializarDataGridViewResultadoBusqueda_Entidades();
                    this.inicializarDataGridViewResultadoBusqueda_Personas();
                    break;
                case LibreriaClasesCompartidas.Constantes.TiposArticulo.ArticuloBase:
                    this.inicializarDataGridViewResultadoBusqueda_Articulos();
                    break;
                case LibreriaClasesCompartidas.Constantes.TiposArticulo.ArticuloProveedor:
                    this.inicializarDataGridViewResultadoBusqueda_ArticulosProveedores();
                    break;
                default:
                    break;
            }
            return dataGridViewResultadoBusqueda;
        }
        
        #region Eventos
        void frmResultadoBusqueda_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true; // this cancels the close event.
        }
        void dataGridViewResultadoBusqueda_CellContentDoubleClick(object sender, EventArgs e)
        {
            this.asignarResultado(dataGridViewResultadoBusqueda.CurrentCell.RowIndex);
            this.Hide();
        }
        #endregion

        #region Modelos utilizados en la búsqueda

        #region Entidades
        private void inicializarDataGridViewResultadoBusqueda_Entidades()
        {
            dataGridViewResultadoBusqueda.Columns.Add("tipo", "Tipo");
            dataGridViewResultadoBusqueda.Columns[0].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("codigoEntidad", "Código");
            dataGridViewResultadoBusqueda.Columns[1].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("cuit", "CUIT");
            dataGridViewResultadoBusqueda.Columns[2].FillWeight = 1;
        }
        
        #region Personas
        private List<ModeloPersonas> glb_lst_mod_personas;
        private ModeloPersonas glb_mod_persona;
        public ModeloPersonas persona
        {
            get { return glb_mod_persona; }
            set { this.glb_mod_persona = value; }
        }

        private void inicializarDataGridViewResultadoBusqueda_Personas()
        {
            dataGridViewResultadoBusqueda.Columns.Add("DNI", "DNI");
            dataGridViewResultadoBusqueda.Columns[3].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("apellido", "Apellido");
            dataGridViewResultadoBusqueda.Columns[4].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("Nombre", "Nombre");
            dataGridViewResultadoBusqueda.Columns[5].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("direccion", "Domicilio");
            dataGridViewResultadoBusqueda.Columns[6].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("ciudad", "Ciudad Domicilio");
            dataGridViewResultadoBusqueda.Columns[7].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("provincia", "Provincia Domicilio");
            dataGridViewResultadoBusqueda.Columns[8].FillWeight = 1;
        }
        private DataGridView popularDataGridViewResultadoBusqueda(List<ModeloPersonas> p_lst_mod_personas)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridViewResultadoBusqueda.Rows[0].Clone();
            foreach (ModeloPersonas p in p_lst_mod_personas)
            {
                row = (DataGridViewRow)dataGridViewResultadoBusqueda.Rows[0].Clone();

                row.Cells[0].Value = p.tipoPersona;
                row.Cells[1].Value = p.codigo;
                row.Cells[2].Value = p.cuit;
                row.Cells[3].Value = p.dni;
                row.Cells[4].Value = p.apellido;
                row.Cells[5].Value = p.nombre;
                row.Cells[6].Value = p.domicilios.Count == 0 ? "Sin datos" : p.domicilios[0].calle + " " + p.domicilios[0].numero;
                row.Cells[7].Value = p.domicilios.Count == 0 ? "Sin datos" : p.domicilios[0].ciudad;
                row.Cells[8].Value = p.domicilios.Count == 0 ? "Sin datos" : p.domicilios[0].provincia.provincia;

                dataGridViewResultadoBusqueda.Rows.Add(row);
            }
            return dataGridViewResultadoBusqueda;
        }
        public void mostrarBusqueda(ModeloPersonas p_mod_persona)
        {
            this.inicializarMostrarBusqueda(LibreriaClasesCompartidas.Constantes.TiposEntidad.Persona);
            glb_lst_mod_personas = new List<ModeloPersonas>();
            ControladorBusqueda lcl_con_busqueda = new ControladorBusqueda();
            glb_lst_mod_personas = lcl_con_busqueda.buscarPersonas(p_mod_persona);

            if (glb_lst_mod_personas.Count != 0)
            {
                this.popularDataGridViewResultadoBusqueda(glb_lst_mod_personas);
                this.ShowDialog();
            }
            else
            {
                this.mostrarMensajeResultadoVacio();
            }
        }
        #endregion
        
        #region Proveedores
        private List<ModeloProveedor> glb_lst_mod_proveedor;

        private ModeloProveedor glb_mod_proveedor;
        public ModeloProveedor proveedor
        {
            get { return glb_mod_proveedor; }
            set { this.glb_mod_proveedor = value; }
        }

        private void inicializarDataGridViewResultadoBusqueda_Proveedores()
        {
            dataGridViewResultadoBusqueda.Columns.Add("razonSocial", "Razón Social");
            dataGridViewResultadoBusqueda.Columns[3].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("direccion", "Domicilio");
            dataGridViewResultadoBusqueda.Columns[4].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("ciudad", "Ciudad Domicilio");
            dataGridViewResultadoBusqueda.Columns[5].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("provincia", "Provincia Domicilio");
            dataGridViewResultadoBusqueda.Columns[6].FillWeight = 1;
        }
        private DataGridView popularDataGridViewResultadoBusqueda(List<ModeloProveedor> p_lst_mod_proveedor)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridViewResultadoBusqueda.Rows[0].Clone();
            foreach (ModeloProveedor p in p_lst_mod_proveedor)
            {
                row = (DataGridViewRow)dataGridViewResultadoBusqueda.Rows[0].Clone();

                row.Cells[0].Value = Constantes.TiposEntidad.TiposProveedor.Proveedor;
                row.Cells[1].Value = p.codigo;
                row.Cells[2].Value = p.cuit;
                row.Cells[3].Value = p.razonSocial;
                row.Cells[4].Value = p.domicilios.Count == 0 ? "Sin datos" : p.domicilios[0].calle + " " + p.domicilios[0].numero;
                row.Cells[5].Value = p.domicilios.Count == 0 ? "Sin datos" : p.domicilios[0].ciudad;
                row.Cells[6].Value = p.domicilios.Count == 0 ? "Sin datos" : p.domicilios[0].provincia.provincia;

                dataGridViewResultadoBusqueda.Rows.Add(row);
            }
            return dataGridViewResultadoBusqueda;
        }       
        public void mostrarBusqueda(ModeloProveedor p_mod_proveedor)
        {
            this.inicializarMostrarBusqueda(LibreriaClasesCompartidas.Constantes.TiposEntidad.Proveedor);
            glb_lst_mod_proveedor = new List<ModeloProveedor>();
            ControladorBusqueda lcl_con_busqueda = new ControladorBusqueda();
            glb_lst_mod_proveedor = lcl_con_busqueda.buscarProveedores(p_mod_proveedor);

            if (glb_lst_mod_proveedor.Count != 0)
            {
                this.popularDataGridViewResultadoBusqueda(glb_lst_mod_proveedor);
                this.ShowDialog();
            }
            else
            {
                this.mostrarMensajeResultadoVacio();
            }
        }
        #endregion

        #endregion

        #region Articulos
        private List<ModeloArticulos> glb_lst_mod_articulos;
        public ModeloArticulos glb_mod_articulo;

        private void inicializarDataGridViewResultadoBusqueda_Articulos()
        {
            dataGridViewResultadoBusqueda.Columns.Add("codigoOriginal", "Código");
            dataGridViewResultadoBusqueda.Columns[0].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("descripcion", "Descripción");
            dataGridViewResultadoBusqueda.Columns[1].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("modelos", "Modelos");
            dataGridViewResultadoBusqueda.Columns[2].FillWeight = 1;
        }
        private DataGridView popularDataGridViewResultadoBusqueda(List<ModeloArticulos> p_lst_mod_articulo)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridViewResultadoBusqueda.Rows[0].Clone();
            foreach (ModeloArticulos a in p_lst_mod_articulo)
            {
                row = (DataGridViewRow)dataGridViewResultadoBusqueda.Rows[0].Clone();

                row.Cells[0].Value = a.codigoOriginal.ToString();
                row.Cells[1].Value = a.descripcion;
                row.Cells[2].Value = a.modelos;

                dataGridViewResultadoBusqueda.Rows.Add(row);
            }
            return dataGridViewResultadoBusqueda;
        }
        public void mostrarBusqueda(ModeloArticulos p_mod_articulo)
        {
            this.inicializarMostrarBusqueda(LibreriaClasesCompartidas.Constantes.TiposArticulo.ArticuloBase);
            glb_lst_mod_articulos = new List<ModeloArticulos>();
            ControladorBusqueda lcl_con_busqueda = new ControladorBusqueda();
            glb_lst_mod_articulos = lcl_con_busqueda.buscarArticulos(p_mod_articulo);

            if (glb_lst_mod_articulos.Count != 0)
            {
                this.popularDataGridViewResultadoBusqueda(glb_lst_mod_articulos);
                this.ShowDialog();
            }
            else
            {
                this.mostrarMensajeResultadoVacio();
            }
        }
        #endregion

        #region ArticulosProveedores
        private List<ModeloArticuloProveedores> glb_lst_mod_articuloProveedores;
        public ModeloArticuloProveedores glb_mod_articuloProveedor;

        private void inicializarDataGridViewResultadoBusqueda_ArticulosProveedores()
        {
            dataGridViewResultadoBusqueda.Columns.Add("codigoOriginal", "Código");
            dataGridViewResultadoBusqueda.Columns[0].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("descripcion", "Descripción");
            dataGridViewResultadoBusqueda.Columns[1].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("modelos", "Modelos");
            dataGridViewResultadoBusqueda.Columns[2].FillWeight = 1;
            
            dataGridViewResultadoBusqueda.Columns.Add("codigoArticuloProveedor", "Código Artículo");
            dataGridViewResultadoBusqueda.Columns[3].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("descripcionArticuloProveedor", "Descripción Articulo");
            dataGridViewResultadoBusqueda.Columns[4].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("codigoEntidad", "Código Proveedor");
            dataGridViewResultadoBusqueda.Columns[5].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("razonSocialProveedor", "Proveedor");
            dataGridViewResultadoBusqueda.Columns[6].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("valorVenta", "Valor Venta");
            dataGridViewResultadoBusqueda.Columns[7].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("valorCompra", "Valor Compra");
            dataGridViewResultadoBusqueda.Columns[8].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("stockMinimo", "Stock Mínimo");
            dataGridViewResultadoBusqueda.Columns[9].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("stockActual", "Stock Actual");
            
            dataGridViewResultadoBusqueda.Columns[10].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("ubicacion", "Ubicación");
            dataGridViewResultadoBusqueda.Columns[11].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("fechaActualizacion", "Fecha Última Actualización");
            dataGridViewResultadoBusqueda.Columns[12].FillWeight = 1;
        }
        private DataGridView popularDataGridViewResultadoBusqueda(List<ModeloArticuloProveedores> p_lst_mod_articuloProveedor)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridViewResultadoBusqueda.Rows[0].Clone();
            foreach (ModeloArticuloProveedores ap in p_lst_mod_articuloProveedor)
            {
                row = (DataGridViewRow)dataGridViewResultadoBusqueda.Rows[0].Clone();

                row.Cells[0].Value = ap.codigoOriginal.ToString();
                row.Cells[1].Value = ap.descripcion;
                row.Cells[2].Value = ap.modelos;

                row.Cells[3].Value = ap.codigoArticuloProveedor;
                row.Cells[4].Value = ap.descripcionArticuloProveedor;
                row.Cells[5].Value = ap.codigoEntidad;
                row.Cells[6].Value = ap.razonSocialProveedor;
                row.Cells[7].Value = ap.valorVenta.valorArticulo.ToString();
                row.Cells[8].Value = ap.valorCompra.valorArticulo.ToString();
                row.Cells[9].Value = ap.stockMinimo.ToString();
                
                row.Cells[10].Value = ap.stockActual.ToString();
                row.Cells[11].Value = ap.ubicacion;
                row.Cells[12].Value = ap.fechaActualizacion;

                dataGridViewResultadoBusqueda.Rows.Add(row);
            }
            return dataGridViewResultadoBusqueda;
        }
        public void mostrarBusqueda(ModeloArticuloProveedores p_mod_articuloProveedor)
        {
            this.inicializarMostrarBusqueda(LibreriaClasesCompartidas.Constantes.TiposArticulo.ArticuloProveedor);
            glb_lst_mod_articuloProveedores = new List<ModeloArticuloProveedores>();
            ControladorBusqueda lcl_con_busqueda = new ControladorBusqueda();
            glb_lst_mod_articuloProveedores = lcl_con_busqueda.buscarArticulosProveedores(p_mod_articuloProveedor);

            if (glb_lst_mod_articuloProveedores.Count != 0)
            {
                this.popularDataGridViewResultadoBusqueda(glb_lst_mod_articuloProveedores);
                this.ShowDialog();
            }
            else
            {
                this.mostrarMensajeResultadoVacio();
            }
        }


        #endregion

        #endregion

    }
}
