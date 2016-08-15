using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos;

namespace Vista
{
    public partial class ControlDomicilios : UserControl
    {

        #region Atributos
        ContextMenu cntxtMenuDataGridViews;
        ControlDomicilio cDomicilio;
        string errorActual;
        #endregion

        public ControlDomicilios()
        {
            InitializeComponent();
            this.inicializarControles();
        }

        private void inicializarControles()
        {
            this.dataGridViewDomicilio.MouseDown += this.dataGridView_MouseDown;
            
            this.inicializarControlDomicilio();
            this.inicializarBotones();
            this.inicializarContextMenu();
        }
        private void inicializarControlDomicilio()
        {
            cDomicilio = new ControlDomicilio();
            cDomicilio.Dock = DockStyle.Fill;
            this.tblLayoutPanelDomicilioDatos.Controls.Add(cDomicilio, 0, 0);
        }
        private void inicializarBotones()
        {
            this.btnAgregarDomicilio.Click += (s, e) =>
            {
                this.agregarDomicilioEntidad(s,e);
            };

            this.btnQuitarDomicilio.Click += (s, e) =>
            {
                this.quitarObjetoDataGridViewSeleccionado(this.dataGridViewDomicilio);
            };
        }
        private void inicializarContextMenu()
        {
            cntxtMenuDataGridViews = new ContextMenu();
            cntxtMenuDataGridViews.MenuItems.Add("Quitar seleccionado");
            cntxtMenuDataGridViews.MenuItems[0].Click += (s, e) =>
            {
                this.quitarObjetoDataGridViewSeleccionado(((s as MenuItem).Parent as ContextMenu).SourceControl as DataGridView);
            };
            cntxtMenuDataGridViews.MenuItems.Add("Quitar todos");
            cntxtMenuDataGridViews.MenuItems[1].Click += (s, e) =>
            {
                this.quitarObjetoDataGridViewTodos(((s as MenuItem).Parent as ContextMenu).SourceControl as DataGridView);
            };
        }
        public List<ModeloDomicilio> getDomicilios()
        {
            return this.cargarDatosControlEnListDomicilio();
        }
        public void setDomicilios(List<ModeloDomicilio> p_lst_domicilios)
        {
            this.cargarDatosDomicilioEnDataGridViewDomicilio(p_lst_domicilios);
        }
        /// <summary>
        /// Toma los datos del control DataGridView
        /// </summary>
        /// <returns></returns>
        private List<ModeloDomicilio> cargarDatosControlEnListDomicilio()
        {
            List<ModeloDomicilio> lcl_lst_mod_domicilios = new List<ModeloDomicilio>();
            ModeloDomicilio lcl_mod_domicilio;

            foreach (DataGridViewRow row in dataGridViewDomicilio.Rows)
            {
                lcl_mod_domicilio = new ModeloDomicilio();

                int codigoDomicilio;
                Int32.TryParse(row.Cells["codigoDomicilio"].Value.ToString(), out codigoDomicilio);
                lcl_mod_domicilio.codigoDomicilio = codigoDomicilio;

                lcl_mod_domicilio.calle = row.Cells["calle"].Value.ToString();
                lcl_mod_domicilio.numero = row.Cells["numero"].Value.ToString();
                lcl_mod_domicilio.piso = row.Cells["piso"].Value.ToString();
                lcl_mod_domicilio.departamento = row.Cells["departamento"].Value.ToString();
                lcl_mod_domicilio.codigoPostal = row.Cells["codigoPostal"].Value.ToString();
                lcl_mod_domicilio.ciudad = row.Cells["ciudad"].Value.ToString();
                lcl_mod_domicilio.provincia.provincia = row.Cells["provincia"].Value.ToString();
                lcl_mod_domicilio.pais.pais = row.Cells["pais"].Value.ToString();
                lcl_mod_domicilio.provincia.codigo = row.Cells["codigoProvincia"].Value.ToString();
                lcl_mod_domicilio.pais.codigo = row.Cells["codigoPais"].Value.ToString();
                lcl_mod_domicilio.provincia.codigoPais = lcl_mod_domicilio.pais.codigo;

                lcl_lst_mod_domicilios.Add(lcl_mod_domicilio);
            }

            return lcl_lst_mod_domicilios;
        }
        private bool validarDomicilioExiste(ModeloDomicilio p_domicilio)
        {
            List<ModeloDomicilio> lcl_lst_mod_domiciliosActuales = this.cargarDatosControlEnListDomicilio();

            if (p_domicilio != null)
            {
                foreach (ModeloDomicilio d in lcl_lst_mod_domiciliosActuales)
                {
                    //se igualan los codigos en caso que el objeto de la lista tenga codigo (traido de base de datos), 
                    //y de true usando Equals en caso de que el resto de las variables sean iguales
                    p_domicilio.codigoDomicilio = d.codigoDomicilio;
                    if (p_domicilio.Equals(d))
                    {
                        errorActual = "El domicilio ya está ingresado.";
                        return true;
                    }
                }
            }
            return false;
        }
        private void agregarDomicilioEntidad(object sender, EventArgs e)
        {
            ModeloDomicilio lcl_mod_domicilioActual = this.cDomicilio.GetDomicilio(sender,e);
            if (lcl_mod_domicilioActual == null)
            {
                //MessageBox.Show("Domicilio");
                return;
            }
            if (this.validarDomicilioExiste(lcl_mod_domicilioActual))
            {
                MessageBox.Show(errorActual, "Error", MessageBoxButtons.OK);
                return;
            }

            this.cargarDatosDomicilioEnDataGridViewDomicilio(lcl_mod_domicilioActual);
            frmMaterialSkinBase.quitarTextoEnControles(this.cDomicilio);
        }
        /// <summary>
        /// Agrega un objeto domicilio al dataGrid
        /// </summary>
        /// <param name="p_mod_domicilio"></param>
        private void cargarDatosDomicilioEnDataGridViewDomicilio(ModeloDomicilio p_mod_domicilio)
        {
            List<ModeloDomicilio> lcl_lst_mod_domicilio = new List<ModeloDomicilio>();
            lcl_lst_mod_domicilio.Add(p_mod_domicilio);
            this.cargarDatosDomicilioEnDataGridViewDomicilio(lcl_lst_mod_domicilio);
        }
        /// <summary>
        /// Agrega una lista de objetos domicilios al dataGrid
        /// </summary>
        /// <param name="p_lst_mod_domicilio"></param>
        private void cargarDatosDomicilioEnDataGridViewDomicilio(List<ModeloDomicilio> p_lst_mod_domicilio)
        {
            int rowIndex;
            DataGridViewRow row;

            foreach (ModeloDomicilio mDomicilio in p_lst_mod_domicilio)
            {
                rowIndex = this.dataGridViewDomicilio.Rows.Add();
                row = this.dataGridViewDomicilio.Rows[rowIndex];

                row.Cells["codigoDomicilio"].Value = mDomicilio.codigoDomicilio;
                row.Cells["calle"].Value = mDomicilio.calle != null ? mDomicilio.calle : "";
                row.Cells["numero"].Value = mDomicilio.numero != null ? mDomicilio.numero : "";
                row.Cells["piso"].Value = mDomicilio.piso != null ? mDomicilio.piso : "";
                row.Cells["departamento"].Value = mDomicilio.departamento != null ? mDomicilio.departamento : "";
                row.Cells["codigoPostal"].Value = mDomicilio.codigoPostal != null ? mDomicilio.codigoPostal : "";
                row.Cells["ciudad"].Value = mDomicilio.ciudad != null ? mDomicilio.ciudad : "";
                row.Cells["codigoProvincia"].Value = mDomicilio.provincia.codigo != null ? mDomicilio.provincia.codigo : "";
                row.Cells["provincia"].Value = mDomicilio.provincia.provincia != null ? mDomicilio.provincia.provincia : "";
                row.Cells["codigoPais"].Value = mDomicilio.pais.codigo != null ? mDomicilio.pais.codigo : "";
                row.Cells["pais"].Value = mDomicilio.pais.pais != null ? mDomicilio.pais.pais : "";
            }
        }
        private void quitarObjetoDataGridViewSeleccionado(DataGridView p_dgvSeleccionada)
        {
            foreach (DataGridViewRow item in p_dgvSeleccionada.SelectedRows)
            {
                if (!item.IsNewRow)
                {
                    p_dgvSeleccionada.Rows.RemoveAt(item.Index);
                }
            }
        }
        private void quitarObjetoDataGridViewTodos(DataGridView p_dgvSeleccionada)
        {
            p_dgvSeleccionada.Rows.Clear();
        }
        private void actualizarContextMenu(DataGridView p_dgvActual)
        {
            int cantidadSeleccionada = p_dgvActual.SelectedRows.Count;
            if (cantidadSeleccionada > 1)
            {
                this.cntxtMenuDataGridViews.MenuItems[0].Text = "Quitar seleccionados";
            }
            else if (cantidadSeleccionada == 1)
            {
                this.cntxtMenuDataGridViews.MenuItems[0].Text = "Quitar seleccionado";
            }
        }
        private void dataGridView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                int currentMouseOverRow = (sender as DataGridView).HitTest(e.X, e.Y).RowIndex;
                if (currentMouseOverRow >= 0)
                {
                    if ((ModifierKeys & Keys.Control) != Keys.Control
                        && (sender as DataGridView).Rows[currentMouseOverRow].Selected != true)
                    {//si selected == true significa que puede haber más elementos seleccionados anteriormente y no hay que perder selección
                        (sender as DataGridView).ClearSelection();
                    }
                    (sender as DataGridView).Rows[currentMouseOverRow].Selected = true;

                    this.actualizarContextMenu(sender as DataGridView);
                    this.cntxtMenuDataGridViews.Show(sender as DataGridView, new Point(e.X, e.Y));
                }
            }
        }
    }
}
