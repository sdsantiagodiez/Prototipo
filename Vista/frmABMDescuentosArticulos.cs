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
using Controladores;
using System.Globalization;


namespace Vista
{
    public partial class frmDescuentosArticulos : Vista.frmABMBase
    {
        #region Atributos
        ModeloDescuentoArticulo glb_mod_Descuento = new ModeloDescuentoArticulo();
        ModeloArticuloProveedores glb_mod_articuloProveedor;
        ControladorDescuento controlador = new ControladorDescuento();
        List<ModeloDescuentoArticulo> glb_lst_mod_descuentos = new List<ModeloDescuentoArticulo>();
        #endregion

        #region Constructores
        public frmDescuentosArticulos()
        {
            InitializeComponent();
            this.inicializarModoFormularioInicio();
            this.Text = "Descuento Artículo";
                        
        }
        public frmDescuentosArticulos(ModeloDescuentoArticulo p_mod_descuento,string p_modoFormulario): this()
        {   //revisar
            glb_mod_Descuento = p_mod_descuento;
            this.modoFormulario = p_modoFormulario;
        }
                
        
        #endregion
        
        #region Métodos

        #region Inicialización
        override public void inicializarModoFormularioInicio()
        {
            glb_mod_articuloProveedor = new ModeloArticuloProveedores();

            base.inicializarModoFormularioInicio();
            
            grpBoxArticulo.Enabled = true;
            
            btnModificarArticulo.Enabled = false;
            txtBoxCodigoOriginal.Enabled = true;
            txtBoxDescripcion.Enabled = true;
            txtBoxCodigoArticulo.Enabled = true;

            grpBoxDescuento.Enabled = true;

            
            tbxFechaDesde.Enabled = false;
            tbxFechaHasta.Enabled = false;
            tbxnumeroDescuento.Enabled = false;
            tbxPorcentajeDescuento.Enabled = false;
            dgvDescuentos.Enabled = true;
            
        }

        override public void inicializarModoFormularioNuevo()
        {
            //glb_mod_articuloProveedor = new ModeloArticuloProveedores();
            ControladorDescuento lcl_con_descuento = new ControladorDescuento();

            base.inicializarModoFormularioNuevo();

            grpBoxArticulo.Enabled = true;
            btnModificarArticulo.Enabled = txtBoxCodigoOriginal.Enabled = txtBoxDescripcion.Enabled = txtBoxCodigoArticulo.Enabled = false;
            

            tbxFechaDesde.Text = DateTime.Today.ToShortDateString();
            tbxFechaDesde.Enabled = true;
            tbxFechaHasta.Text = DateTime.Today.ToShortDateString();
            tbxFechaHasta.Enabled = true;
            tbxnumeroDescuento.Text = lcl_con_descuento.getUltimoDescuento().ToString();
            tbxnumeroDescuento.Enabled = false;
            tbxPorcentajeDescuento.Text = "0";
            tbxPorcentajeDescuento.Enabled = true;
            
            dgvDescuentos.Enabled = false;
        }

        override public void inicializarModoFormularioSeleccionado()
        {
            base.inicializarModoFormularioSeleccionado();

            grpBoxArticulo.Enabled = false;
            btnModificarArticulo.Enabled = true;

            grpBoxDescuento.Enabled = true;

            tbxnumeroDescuento.Enabled = false;
            tbxFechaDesde.Enabled = true;
            tbxFechaHasta.Enabled = true;
            tbxPorcentajeDescuento.Enabled = true;
            dgvDescuentos.Enabled = true;

        }

        public override void inicializarModoFormularioVisualizarEntidad()
        {
            base.inicializarModoFormularioVisualizarEntidad();

            foreach (Control c in this.Controls)
            {
                c.Enabled = false;
            }
            this.cargarArticuloProveedorEnControles(glb_mod_articuloProveedor);
            this.cargarDescuentosEnControles(glb_mod_Descuento);
            this.cargarListaDescuentosEnControles(glb_lst_mod_descuentos);
        }

        private void inicializarModoDescuentoModificado()
        {
            grpBoxArticulo.Enabled = false;

            txtBoxCodigoArticulo.Enabled = txtBoxCodigoOriginal.Enabled = txtBoxDescripcion.Enabled = false;

            tbxFechaDesde.Enabled = tbxFechaHasta.Enabled = tbxPorcentajeDescuento.Enabled = true;
            tbxnumeroDescuento.Enabled = false;

            grpBoxListaDescuentos.Enabled = false;

            dgvDescuentos.Enabled = false;

        }

       #endregion

        #region ABM
        /// <summary>
        /// Inicia proceso de alta y muestra mensaje de acuerdo si la operación ha sido exitosa o fallida
        /// </summary>
        private void alta()
        {
            if (!this.validar())
            {
                MessageBox.Show(errorActual,"Error",MessageBoxButtons.OK);
                return;
            }

            ControladorAlta lcl_con_alta = new ControladorAlta();
            this.cargarDatosDescuentoEnModeloDescuentoArticulo(); 

            if(lcl_con_alta.agregar(glb_mod_Descuento))
            {
                MessageBox.Show("Alta exitosa", "Éxito", MessageBoxButtons.OK);
                this.inicializarModoFormularioSeleccionado();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show(lcl_con_alta.errorActual, "Error", MessageBoxButtons.RetryCancel);
                if (dialogResult == DialogResult.Retry)
                {
                    this.alta();
                }
            }
        }

        /// <summary>
        /// Inicia proceso de baja y muestra mensaje de acuerdo si la operación ha sido exitosa o fallida
        /// </summary>
        private void baja()
        {
            ControladorBaja lcl_con_baja = new ControladorBaja();
            if (lcl_con_baja.eliminar(glb_mod_Descuento))
            {
                MessageBox.Show("Eliminación exitosa", "Éxito", MessageBoxButtons.OK);
                this.inicializarModoFormularioInicio();
                this.quitarTextoEnControles(this);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show(lcl_con_baja.errorActual, "Error", MessageBoxButtons.RetryCancel);
                if (dialogResult == DialogResult.Retry)
                {
                    this.baja();
                }
            }
        }

        /// <summary>
        /// Inicia proceso de actualización y muestra mensaje de acuerdo si la operación ha sido exitosa o fallida
        /// </summary>
        private void actualizar()
        {
            if (!this.validar())
            {
                MessageBox.Show(errorActual, "Error", MessageBoxButtons.OK);
                return;
            }

            ControladorModificacion lcl_con_modificacion = new ControladorModificacion();
            this.cargarDatosDescuentoEnModeloDescuentoArticulo();

            if (lcl_con_modificacion.modificar(glb_mod_Descuento))
            {
                MessageBox.Show("Modificación exitosa", "Éxito", MessageBoxButtons.OK);
                this.limpiarCamposDescuento();
                this.inicializarModoFormularioInicio();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show(lcl_con_modificacion.errorActual, "Error", MessageBoxButtons.RetryCancel);
                if (dialogResult == DialogResult.Retry)
                {
                    this.actualizar();
                }
            }
        }
        #endregion

        #region Búsqueda
        /// <summary>
        /// Muestra cuadro de resultado de búsqueda de la clase buscada o mensaje de error en caso de que no se haya podido mostrar
        /// </summary>
        private void buscar()
        {
            this.buscarArticuloProveedor();
        }
        private void buscarArticuloProveedor()
        {
            frmResultadoBusqueda lcl_frm_resultadoBusqueda = new frmResultadoBusqueda();
            glb_mod_articuloProveedor = this.cargarDatosEnModeloArticuloProveedor();
            lcl_frm_resultadoBusqueda.mostrarBusqueda(glb_mod_articuloProveedor);
            if (lcl_frm_resultadoBusqueda.modeloSeleccionado != null)
            {
                this.modoFormulario = ModoFormularioInicio;

                glb_mod_articuloProveedor = lcl_frm_resultadoBusqueda.modeloSeleccionado as ModeloArticuloProveedores;
                this.cargarArticuloProveedorEnControles(glb_mod_articuloProveedor);
            }
        }
        private void buscarDescuentos()
        {
            int rta = controlador.buscarDescuentos(glb_mod_articuloProveedor.codigoOriginal, glb_mod_articuloProveedor.codigoArticuloProveedor);
            if (rta != 0 )
            {
                //this.inicializarModoFormularioInicio();
                glb_lst_mod_descuentos = controlador.getDescuentosBusqueda();
                this.cargarListaDescuentosEnControles(glb_lst_mod_descuentos);
                this.cargarListaDatosDescuentoEnModeloDescuentoArticulo(ref glb_lst_mod_descuentos);
            }
        }
        
        #endregion
        
        #region Controles -> Modelo
        private ModeloArticuloProveedores cargarDatosEnModeloArticuloProveedor()
        {
            ModeloArticuloProveedores lcl_mod_articuloProveedores = new ModeloArticuloProveedores();

            this.cargarDatosArticuloEnModeloArticuloProveedor(ref lcl_mod_articuloProveedores);
                        

            return lcl_mod_articuloProveedores;
        }

        private void cargarDatosArticuloEnModeloArticuloProveedor(ref ModeloArticuloProveedores p_mod_articuloProveedor)
        {
            p_mod_articuloProveedor.codigoOriginal = txtBoxCodigoOriginal.Text; ;
            p_mod_articuloProveedor.descripcion = txtBoxDescripcion.Text;
            p_mod_articuloProveedor.codigoArticuloProveedor = txtBoxCodigoArticulo.Text;
        }
        
        private void cargarDatosEnModeloDescuentoArticulo()
        {
           this.cargarDatosDescuentoEnModeloDescuentoArticulo();

        }

        private void cargarDatosDescuentoEnModeloDescuentoArticulo()
        {
            glb_mod_Descuento = new ModeloDescuentoArticulo();
            glb_mod_Descuento.CodigoOriginal = txtBoxCodigoOriginal.Text; ;
            glb_mod_Descuento.CodigoArticuloProveedor = txtBoxCodigoArticulo.Text;
            glb_mod_Descuento.FechaDesde = DateTime.ParseExact(tbxFechaDesde.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            glb_mod_Descuento.FechaHasta = DateTime.ParseExact(tbxFechaHasta.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            glb_mod_Descuento.numeroDescuento = Convert.ToInt32(tbxnumeroDescuento.Text);
            glb_mod_Descuento.PorcentajeDescuento = Convert.ToDecimal(tbxPorcentajeDescuento.Text);
        }

        private List<ModeloDescuentoArticulo> cargarListaDatosEnModeloDescuentoArticulo()
        {
            List<ModeloDescuentoArticulo> lcl_lst_mod_descuento = new List<ModeloDescuentoArticulo>();

            this.cargarListaDatosDescuentoEnModeloDescuentoArticulo(ref lcl_lst_mod_descuento);


            return lcl_lst_mod_descuento;
        }

        private void cargarListaDatosDescuentoEnModeloDescuentoArticulo(ref List<ModeloDescuentoArticulo> p_lst_mod_descuento)
        {
            //ver si tiene utilidad
        }
        #endregion
        
        #region Modelo -> Controles
        private void cargarArticuloProveedorEnControles(ModeloArticuloProveedores p_mod_articuloProveedor)
        {   //agregar como parametro la lista de Descuentos
            glb_mod_articuloProveedor = p_mod_articuloProveedor;

            txtBoxCodigoOriginal.Text = p_mod_articuloProveedor.codigoOriginal;
            txtBoxDescripcion.Text = p_mod_articuloProveedor.descripcion;
            txtBoxCodigoArticulo.Text = p_mod_articuloProveedor.codigoArticuloProveedor.ToString();
            
            
        }
        private void cargarListaDescuentosEnControles(List<ModeloDescuentoArticulo> p_lst_mod_descuento)
        { 
            DataTable descuentos = new DataTable();
            descuentos.Columns.Add("indice");
            descuentos.Columns.Add("numeroDescuento");
            descuentos.Columns.Add("porcentajeDescuento");
            descuentos.Columns.Add("fechaDesde");
            descuentos.Columns.Add("fechaHasta");
            
            int i = 0;
            foreach (ModeloDescuentoArticulo de in p_lst_mod_descuento)
            {
                var row = descuentos.NewRow();
                 row["indice"] = i.ToString();
                i++;
                row["porcentajeDescuento"] = de.PorcentajeDescuento.ToString();
                row["numeroDescuento"] = de.numeroDescuento.ToString();
                row["fechaDesde"] = de.FechaDesde.ToShortDateString();
                row["fechaHasta"] = de.FechaHasta.ToShortDateString();

                descuentos.Rows.Add(row);
            }
            this.dgvDescuentos.DataSource = null;
            this.dgvDescuentos.DataSource = descuentos;
            this.dgvDescuentos.ClearSelection();
            //this.glb_mod_Descuento = null;
            
        
        }
        
        private void cargarDescuentosEnControles(ModeloDescuentoArticulo p_mod_descuento)
        {
            glb_mod_Descuento = p_mod_descuento;
            this.tbxnumeroDescuento.Text = p_mod_descuento.numeroDescuento.ToString();
            this.tbxPorcentajeDescuento.Text = p_mod_descuento.PorcentajeDescuento.ToString();
            this.tbxFechaDesde.Text = p_mod_descuento.FechaDesde.ToShortDateString();
            this.tbxFechaHasta.Text = p_mod_descuento.FechaHasta.ToShortDateString();
        }

        #endregion

        #region Validación
        /// <summary>
        /// Valida que los controladores que se hayan completados tengan el formato correcto y además que los campos obligatorios hayas sido rellenados
        /// </summary>
        /// <returns>true si todos los controladores válidos, false caso contrario</returns>
        private bool validar()
        {
            if (this.validarPorcentajeDescuento())
            {
                return this.validarArticulo();
            }
            errorActual = "Ha surgido un error. Por favor, revise los valores ingresados.";
            return false;
        }
        
        private bool validarArticulo()
        {
            if (glb_mod_articuloProveedor.codigoOriginal == null || glb_mod_articuloProveedor.codigoArticuloProveedor == null)
            {
                errorActual = "Debe seleccionar un Artículo.";
                return false;
            }
            return true;
        }
        private bool validarPorcentajeDescuento()
        {
            if (string.IsNullOrWhiteSpace(tbxPorcentajeDescuento.Text)|| Convert.ToDecimal(tbxPorcentajeDescuento.Text)>100)
            {
                this.errorProviderActual.SetError(tbxPorcentajeDescuento, "Este campo es obligatorio. No puede permanecer vacío o ser mayor a 100.");
                return false;
            }
            this.errorProviderActual.SetError(tbxPorcentajeDescuento, "");
            return true;
        }

        #endregion
        #endregion
       
        #region Eventos
        #region toolStripMenuItem

        //override public void toolStripMenuItemCancelar_Click(object sender, EventArgs e)
        //{
            
        //}

        override public void toolStripMenuItemLimpiarCampos_Click(object sender, EventArgs e)
        {
            this.modoFormulario = ModoFormularioInicio;
            this.dgvDescuentos.DataSource = null;
            base.quitarTextoEnControles(this);
        }

        override public void toolStripMenuItemEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea eliminar el descuento seleccionado?", "Atención", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.baja();
            }
        }

        override public void toolStripMenuItemGuardarNuevo_Click(object sender, EventArgs e)
        {
            this.alta();
            this.limpiarCamposDescuento();
            this.buscarDescuentos();
            modoFormulario = ModoFormularioNuevo;
        }

        override public void toolStripMenuItemGuardarCambios_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea guardar los cambios realizados?", "Atención", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.actualizar();
            }
        }

        override public void toolStripMenuItemNuevo_Click(object sender, EventArgs e)
        {
            if (this.glb_mod_articuloProveedor.codigoArticuloProveedor == null)
            { 
                this.buscar();
                this.buscarDescuentos();
            }
            modoFormulario = ModoFormularioNuevo;
        }

        override public void toolStripMenuItemBuscar_Click(object sender, EventArgs e)
        {
            this.buscar();
            this.buscarDescuentos();
        }
        #endregion

        #region Buttons
        
        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {
            this.inicializarModoDescuentoModificado();
            this.quitarTextoEnControles(grpBoxArticulo);
            
        }

        #endregion

        private void valorDecimal(object sender, KeyPressEventArgs e)
        {
            // solo 0-9, borrar y ',' para decimales
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != ','))
            {
                e.Handled = true;
                return;
            }

            // asegurar que la ',' aparece solo una vez
            if (e.KeyChar == ',')
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        #endregion

        private void frmDescuentosArticulos_Move(object sender, EventArgs e)
        {
            this.Location = new Point(224, 124);
        }

        private void tbxFechaDesde_Validating(object sender, CancelEventArgs e)
        {
            DateTime lcl_fecha;
                if (!DateTime.TryParse(tbxFechaDesde.Text, out lcl_fecha))
            {
                errorProviderActual.SetError(tbxFechaDesde, "La fecha ingresada no es válida");
                e.Cancel = true;
            }
            else
            {
                errorProviderActual.Clear();
            }
            
        }

        private void tbxFechaHasta_Validating(object sender, CancelEventArgs e)
        {
            DateTime lcl_fecha;
            if (!DateTime.TryParse(tbxFechaHasta.Text, out lcl_fecha))
            {
                errorProviderActual.SetError(tbxFechaHasta, "La fecha ingresada no es válida");
                e.Cancel = true;
            }
            else
            {
                errorProviderActual.Clear();
            }
        }

        private void dgvDescuentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                //No hay fila seleccionada
                return;
            }
            int i = Convert.ToInt32(this.dgvDescuentos.Rows[e.RowIndex].Cells["indice"].Value);
            //asigno el articulo a la variable articuloSeleccionadoBusqueda en caso de que se decida agregarlo al pedido
            this.glb_mod_Descuento = controlador.getDescuentoBusqueda(i);

            cargarDescuentosEnControles(glb_mod_Descuento);
            this.inicializarModoFormularioSeleccionado();
            
        }
        private void limpiarCamposDescuento()
        {
            tbxFechaDesde.Text = tbxFechaHasta.Text = tbxnumeroDescuento.Text = tbxPorcentajeDescuento.Text = "";
        }

              

    }
}
