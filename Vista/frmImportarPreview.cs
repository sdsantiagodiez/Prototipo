using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos;
using System.Windows;
using Controladores;

namespace Vista
{
    public partial class frmImportarPreview : frmMaterialSkinBase
    {
        Type TypeModelo;
        DataGridView dgvPreview;
        List<ComboBoxItem> glb_lst_atributos;
        string filePath;
        
        #region Constructores
        private frmImportarPreview()
        {
            InitializeComponent();
        }
        public frmImportarPreview(Type T) : this()
        {
            TypeModelo = T;
            
            this.inicializarTituloForm(T);
            inicializarDgvReview();
            inicializarSeleccionDeColumnas(T);
            this.habilitarImportar(false);
        }
        #endregion

        #region Métodos
      
        #region Inicialización
        public override void inicializarForm(int ventanaAncho, int ventanaAlto)
        {
            this.tblLayoutPanelPrincipal.Width = ventanaAncho - 20; //un margen derecho de 20 para que se vea scrollbar
            this.pnlBase.Width = ventanaAncho - 3;  //un márgen derecho de 3
            this.pnlBase.Height = ventanaAlto - 60; //un márgen arriba para que se vea título

            int x = Convert.ToInt16(Math.Round(Convert.ToDouble((Width - this.tblLayoutPanelPrincipal.Width) / 2)));
            this.tblLayoutPanelPrincipal.Location = new Point(10, 0);
            this.pnlBase.Location = new Point(0, 65);
        }
        private void inicializarDgvReview()
        {
            this.dgvPreview = new DataGridView();
            this.dgvPreview.CellValueChanged += new DataGridViewCellEventHandler(dgvPreview_CellValueChanged);
            this.dgvPreview.CurrentCellDirtyStateChanged += new EventHandler(dgvPreview_CurrentCellDirtyStateChanged);
            this.dgvPreview.ColumnHeadersVisible = false;
            this.dgvPreview.Dock = DockStyle.Fill;
            this.dgvPreview.AutoGenerateColumns = false;
            this.dgvPreview.AllowUserToAddRows = false;
            this.dgvPreview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.tblLayoutPanelPrincipal.Controls.Add(this.dgvPreview, 0, 2);
        }
        private void inicializarSeleccionDeColumnas(Type T)
        {
            var dataSource = this.getAtributos(T);

            glb_lst_atributos = new List<ComboBoxItem>();
            glb_lst_atributos = this.getAtributos(T);

            List<DataGridViewComboBoxCell> lcl_lst_comboBoxCell = new List<DataGridViewComboBoxCell>();
            DataGridViewComboBoxCell lcl_c;

            for (int i = 0; i < dataSource.Count - 1; i++) //-1 por -seleccionar- al inicio
            {
                this.dgvPreview.Columns.Add(i.ToString(), "c " + i.ToString());

                lcl_c = new DataGridViewComboBoxCell();
                lcl_c.DisplayMember = "Name";
                lcl_c.ValueMember = "Value";
                lcl_c.DataSource = glb_lst_atributos;

                lcl_lst_comboBoxCell.Add(lcl_c);
            }

            this.dgvPreview.Rows.Add();
            //Adding combo box column in dataGridView
            foreach (DataGridViewColumn c in this.dgvPreview.Columns)
            {
                this.dgvPreview.Rows[0].Cells[c.Index] = lcl_lst_comboBoxCell[c.Index];
            }
        }
        private void inicializarTituloForm(Type T)
        {
            string titulo = "Importar ";
            if (T == typeof(ModeloArticuloProveedores))
            {
                titulo += "Artículos Proveedores";
            }
            else if (T == typeof(ModeloArticulos))
            {
                titulo += "Artículos";
            }
            else if (T == typeof(ModeloCliente))
            {
                titulo += "Clientes";
            }
            else if (T == typeof(ModeloProveedor))
            {
                titulo += "Proveedores";
            }
            else
            {
                titulo += "Archivo";
            }
            this.Text = titulo;
        }
        #endregion
       
        private void habilitarImportar(bool p_habilitar)
        {
            this.chckBoxPrimeraFilaHeaders.Enabled = p_habilitar;
            this.dgvPreview.Enabled = p_habilitar;
            this.btnImportar.Enabled = p_habilitar;
        }

        private void buscarArchivo()
        {
            filePath = null;
            OpenFileDialog lcl_ofd = new OpenFileDialog();
            lcl_ofd.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            lcl_ofd.FilterIndex = 1;
            lcl_ofd.Multiselect = false;
            if (lcl_ofd.ShowDialog() == DialogResult.OK)    
            {
                if (lcl_ofd.CheckPathExists && lcl_ofd.CheckFileExists)
                {
                    filePath = lcl_ofd.FileName;
                    this.txtBoxDireccionArchivo.Text = filePath;
                    this.habilitarImportar(true);
                }
                else
                {
                    this.habilitarImportar(false);
                }
            }
            if (!string.IsNullOrWhiteSpace(filePath))
            {
                this.cargarDatosPreview(Controladores.ControladorExcel.getPreviewDeArchivo(filePath, TypeModelo));
            }
        }

        private void cargarDatosPreview(DataTable p_dt_datos)
        {
            if (this.dgvPreview.Rows.Count > 1)
            {
                this.clearDgvPreview();
            }
            int rowCount = p_dt_datos.Rows.Count > 25? 25: p_dt_datos.Rows.Count;//Se setea un valor máximo de rows a mostrar
            for (int i = 1; i < rowCount+1; i++)  //empieza en 1 porque 0 lo tienen los comboBoxes
            {
                this.dgvPreview.Rows.Add();
                foreach (DataGridViewColumn c in this.dgvPreview.Columns)
                {
                    this.dgvPreview.Rows[i].Cells[c.Index].Value = p_dt_datos.Rows[i-1][c.Index];
                }
            }
        }
        private void clearDgvPreview()
        {
            while (this.dgvPreview.Rows.Count > 1)
            {
                this.dgvPreview.Rows.RemoveAt(this.dgvPreview.Rows.Count - 1);
            }
            
        }

        /// <summary>
        /// Retorna a través de una lista en que columna del arcivho excel se encuentra un determinado artículo
        /// </summary>
        /// <returns></returns>
        private List<int?> getIndicesDeAtributos()
        {
            /*
             * Ejemplo de resultado:
             * lcl_lst_indices -> list ->
             * list[0] = 3  //El atributo 0, por ejemlpo codigoOriginal, se encuentra en la columna indice 3 del archivo excel
             * list[1] = 1  //El atributo 1, por ejemplo descripcion, se encuentra en la columna indice 1 del archivo excel
             * list[2] = 2  //El atributo 2, por ejemplo modeloss, se encuentra en la columna indice 2 del archivo excel
             * list[3] = 0  //Ek atributo 3, por ejemplo observaciones, se encuentra en la columna indice 0 del archivo excel
             *  observaciones   |   descripcion |   modelos |   codigoOriginal  |
             */
            List<int?> lcl_lst_indices = new List<int?>();

            foreach (ComboBoxItem c_comboBox in glb_lst_atributos)
            {
                if (c_comboBox.Value == null)
                {
                    continue;
                }

                lcl_lst_indices.Add(null);
                foreach (DataGridViewComboBoxCell c_rowDgv in this.dgvPreview.Rows[0].Cells)
                {
                    if (c_comboBox.Value == c_rowDgv.Value) //Si el valor de un atributo de artículo es el mismo que el seleccionado del comboBox en una determinada columna, se agrega
                    {
                        lcl_lst_indices[lcl_lst_indices.Count -1] = c_rowDgv.ColumnIndex;
                        break;
                    }
                }
            }

            
            return lcl_lst_indices;
        }

        #region getAtributos
        /*
         * Se encargan de devolver en ComboBoxItem los atributos que contiene cada modelo
         */
        private List<ComboBoxItem> getAtributos(Type T)
        {
            List<ComboBoxItem> lcl_lst_atributos = new List<ComboBoxItem>();
            lcl_lst_atributos.Add(new ComboBoxItem() { Name = "--seleccionar--", Value = null });
            
            if (T == typeof(ModeloArticuloProveedores))
            {
                lcl_lst_atributos.AddRange(this.getAtributosArticuloProveedor());
            }
            else if (T == typeof(ModeloArticulos))
            {
                lcl_lst_atributos.AddRange(this.getAtributosArticulo());
            }
            else if (T == typeof(ModeloCliente))
            {
                lcl_lst_atributos.AddRange(this.getAtributosCliente());
            }
            else if (T == typeof(ModeloProveedor))
            {
                lcl_lst_atributos.AddRange(this.getAtributosProveedor());
            }

            return  lcl_lst_atributos;
        }
        private List<ComboBoxItem> getAtributosArticulo()
        {
            List<ComboBoxItem> lcl_lst_atributos = new List<ComboBoxItem>();
            lcl_lst_atributos.Add(new ComboBoxItem() { Name = "Código Original*", Value = 0 });
            lcl_lst_atributos.Add(new ComboBoxItem() { Name = "Descripción*", Value = 1 });
            lcl_lst_atributos.Add(new ComboBoxItem() { Name = "Modelos", Value = 2 });
            lcl_lst_atributos.Add(new ComboBoxItem() { Name = "Observaciones", Value = 3 });

            return lcl_lst_atributos;
        }
        private List<ComboBoxItem> getAtributosArticuloProveedor()
        {
            List<ComboBoxItem> lcl_lst_atributos = new List<ComboBoxItem>();
            lcl_lst_atributos.Add(new ComboBoxItem() { Name = "Código Original*", Value = 0 });
            lcl_lst_atributos.Add(new ComboBoxItem() { Name = "Código Articulo Proveedor*", Value = 1 });
            lcl_lst_atributos.Add(new ComboBoxItem() { Name = "Código Entidad*", Value = 2 });
            lcl_lst_atributos.Add(new ComboBoxItem() { Name = "Descripción*", Value = 3 });
            lcl_lst_atributos.Add(new ComboBoxItem() { Name = "Valor Compra*", Value = 4 });
            lcl_lst_atributos.Add(new ComboBoxItem() { Name = "Valor Venta*", Value = 5 });
            lcl_lst_atributos.Add(new ComboBoxItem() { Name = "Stock Mínimo*", Value = 6 });
            lcl_lst_atributos.Add(new ComboBoxItem() { Name = "Stock Actual*", Value = 7 });
            lcl_lst_atributos.Add(new ComboBoxItem() { Name = "Ubicación", Value = 8 });
            lcl_lst_atributos.Add(new ComboBoxItem() { Name = "Observaciones", Value = 9 });

            return lcl_lst_atributos;
        }
        private List<ComboBoxItem> getAtributosCliente()
        {
            List<ComboBoxItem> lcl_lst_atributos = new List<ComboBoxItem>();
            lcl_lst_atributos.Add(new ComboBoxItem() { Name = "DNI*", Value = 0 });
            lcl_lst_atributos.Add(new ComboBoxItem() { Name = "Nombre*", Value = 1 });
            lcl_lst_atributos.Add(new ComboBoxItem() { Name = "Apellido*", Value = 2 });
            lcl_lst_atributos.Add(new ComboBoxItem() { Name = "CUIT", Value = 3 });
            lcl_lst_atributos.Add(new ComboBoxItem() { Name = "Observaciones", Value = 4 });
            

            return lcl_lst_atributos;
        }
        private List<ComboBoxItem> getAtributosProveedor()
        {
            List<ComboBoxItem> lcl_lst_atributos = new List<ComboBoxItem>();
            lcl_lst_atributos.Add(new ComboBoxItem() { Name = "CUIT*", Value = 0 });
            lcl_lst_atributos.Add(new ComboBoxItem() { Name = "Razón Social*", Value = 1 });
            lcl_lst_atributos.Add(new ComboBoxItem() { Name = "Observaciones", Value = 2 });
            
            return lcl_lst_atributos;
        }
        #endregion

        #endregion

        #region Eventos

        #region DataGridView
        /// <summary>
        /// Se usa para llamar al evento cellValueChanged
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void dgvPreview_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (this.dgvPreview.IsCurrentCellDirty)
            {
                // Inicia el evento CellValueChanged
                dgvPreview.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        /// <summary>
        /// Se asegura que no haya dos comboBoxCells con el mismo value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvPreview_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != 0)
            {
                return;
            }
            DataGridViewComboBoxCell cb = (DataGridViewComboBoxCell)dgvPreview.Rows[e.RowIndex].Cells[e.ColumnIndex];
            if (cb.Value != null)
            {
                foreach (DataGridViewComboBoxCell c in dgvPreview.Rows[e.RowIndex].Cells)
                {
                    if (c.ColumnIndex != e.ColumnIndex && c.Value == cb.Value)
                    {
                        c.Value = null;
                    }
                }
                dgvPreview.Invalidate();
            }
        }
        #endregion
        
        #region Button
        private void btnImportar_Click(object sender, EventArgs e)
        {
            string respuesta;
            bool primeraFilaHeaders = this.chckBoxPrimeraFilaHeaders.Checked;
            ControladorExcel lcl_con_excel = new ControladorExcel();
            if (lcl_con_excel.importarDatos(filePath, TypeModelo, this.getIndicesDeAtributos(), primeraFilaHeaders, out respuesta))
            {
                MessageBox.Show(respuesta, "Éxito");
            }
            else
            {
                MessageBox.Show(respuesta, "Error");
            }
        }
        private void btnBuscarArchivo_Click(object sender, EventArgs e)
        {
            this.buscarArchivo();
        }
        #endregion

        #region CheckBox
        private void chckBoxPrimeraFilaHeaders_CheckedChanged(object sender, EventArgs e)
        {
            if (this.dgvPreview == null)
            {
                return;
            }
            if (this.chckBoxPrimeraFilaHeaders.Checked)
            {
                this.dgvPreview.Rows[1].Visible = false;
            }
            else
            {
                this.dgvPreview.Rows[1].Visible = true;
            }
        }
        #endregion

        #endregion
    }
}
