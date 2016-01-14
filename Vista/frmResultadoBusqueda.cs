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
            lmPersonas = null;
            lmProveedores = null;
        }

        private void mostrarMensajeResultadoVacio()
        {
            MessageBox.Show("No se han encontrado resultados", "Resultado de búsqueda", MessageBoxButtons.OK);
        }

        private void asignarResultado(int p_indice)
        {
            mPersona = null;
            mProveedor = null;

            if (lmProveedores != null)
            {
                mProveedor = lmProveedores[p_indice];
            }
            else
            {
                if (lmPersonas != null)
                {
                    mPersona = lmPersonas[p_indice];
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
        private List<ModeloPersonas> lmPersonas;
        public ModeloPersonas mPersona;

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
        private DataGridView popularDataGridViewResultadoBusqueda(List<ModeloPersonas> plmPersonas)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridViewResultadoBusqueda.Rows[0].Clone();
            foreach (ModeloPersonas p in plmPersonas)
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
        public void mostrarBusqueda(ModeloPersonas pmPersona)
        {
            this.inicializarMostrarBusqueda(LibreriaClasesCompartidas.Constantes.TiposEntidad.Persona);
            lmPersonas = new List<ModeloPersonas>();
            ControladorBusqueda cBusqueda = new ControladorBusqueda();
            lmPersonas = cBusqueda.buscarPersonas(pmPersona);

            if (lmPersonas.Count != 0)
            {
                this.popularDataGridViewResultadoBusqueda(lmPersonas);
                this.ShowDialog();
            }
            else
            {
                this.mostrarMensajeResultadoVacio();
            }
        }
        #endregion
        
        #region Proveedores
        private List<ModeloProveedor> lmProveedores;
        public ModeloProveedor mProveedor;

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
        private DataGridView popularDataGridViewResultadoBusqueda(List<ModeloProveedor> plmProveedor)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridViewResultadoBusqueda.Rows[0].Clone();
            foreach (ModeloProveedor p in plmProveedor)
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
        public void mostrarBusqueda(ModeloProveedor pmProveedor)
        {
            this.inicializarMostrarBusqueda(LibreriaClasesCompartidas.Constantes.TiposEntidad.Proveedor);
            lmProveedores = new List<ModeloProveedor>();
            ControladorBusqueda cBusqueda = new ControladorBusqueda();
            lmProveedores = cBusqueda.buscarProveedores(pmProveedor);

            if (lmProveedores.Count != 0)
            {
                this.popularDataGridViewResultadoBusqueda(lmProveedores);
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
        private List<ModeloArticulos> lmArticulos;
        public ModeloArticulos mArticulo;

        private void inicializarDataGridViewResultadoBusqueda_Articulos()
        {
            dataGridViewResultadoBusqueda.Columns.Add("codigoOriginal", "Código");
            dataGridViewResultadoBusqueda.Columns[0].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("descripcion", "Descripción");
            dataGridViewResultadoBusqueda.Columns[1].FillWeight = 1;
        }
        private DataGridView popularDataGridViewResultadoBusqueda(List<ModeloArticulos> plmArticulos)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridViewResultadoBusqueda.Rows[0].Clone();
            foreach (ModeloArticulos a in plmArticulos)
            {
                row = (DataGridViewRow)dataGridViewResultadoBusqueda.Rows[0].Clone();

                row.Cells[0].Value = a.codigoOriginal.ToString();
                row.Cells[1].Value = a.descripcion;

                dataGridViewResultadoBusqueda.Rows.Add(row);
            }
            return dataGridViewResultadoBusqueda;
        }
        public void mostrarBusqueda(ModeloArticulos pmArticulo)
        {
            this.inicializarMostrarBusqueda(LibreriaClasesCompartidas.Constantes.TiposArticulo.ArticuloBase);
            lmArticulos = new List<ModeloArticulos>();
            ControladorBusqueda cBusqueda = new ControladorBusqueda();
            lmArticulos = cBusqueda.buscarArticulos(pmArticulo);

            if (lmArticulos.Count != 0)
            {
                this.popularDataGridViewResultadoBusqueda(lmArticulos);
                this.ShowDialog();
            }
            else
            {
                this.mostrarMensajeResultadoVacio();
            }
        }
        #endregion

        #region ArticulosProveedores
        private List<ModeloArticuloProveedores> lmArticuloProveedores;
        public ModeloArticuloProveedores mArticuloProveedor;

        private void inicializarDataGridViewResultadoBusqueda_ArticulosProveedores()
        {
            dataGridViewResultadoBusqueda.Columns.Add("codigoOriginal", "Código");
            dataGridViewResultadoBusqueda.Columns[0].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("descripcion", "Descripción");
            dataGridViewResultadoBusqueda.Columns[1].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("codigoArticuloProveedor", "Código Artículo");
            dataGridViewResultadoBusqueda.Columns[2].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("codigoEntidad", "Código Proveedor");
            dataGridViewResultadoBusqueda.Columns[3].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("razonSocialProveedor", "Proveedor");
            dataGridViewResultadoBusqueda.Columns[4].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("valorVenta", "Valor Venta");
            dataGridViewResultadoBusqueda.Columns[5].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("valorCompra", "Valor Compra");
            dataGridViewResultadoBusqueda.Columns[6].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("stockMinimo", "Stock Mínimo");
            dataGridViewResultadoBusqueda.Columns[7].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("stockActual", "Stock Actual");
            dataGridViewResultadoBusqueda.Columns[8].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("ubicacion", "Ubicación");
            dataGridViewResultadoBusqueda.Columns[9].FillWeight = 1;
            dataGridViewResultadoBusqueda.Columns.Add("fechaActualizacion", "Fecha Última Actualización");
            dataGridViewResultadoBusqueda.Columns[10].FillWeight = 1;
        }
        #endregion

        #endregion

    }
}
