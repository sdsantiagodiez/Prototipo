using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Modelos;
using Controladores;
using LibreriaClasesCompartidas;

namespace Vista
{
    public partial class frmABMArticulo : Vista.frmABMBase
    {
        #region Atributos
        ModeloArticulos glb_mod_articulo;
        ModeloArticuloProveedores glb_mod_articuloProveedor;
        List<ModeloArticuloProveedores> glb_lst_mod_articulosProveedores;
        List<bool> glb_lst_respuestasValidaciones;
        bool glb_banderaCodigoOriginal=false;
        /// <summary>
        /// indica si hay un artículo seleccionado desde una búsqueda de artículos
        /// </summary>
        bool articuloSeleccionado;
        /// <summary>
        /// Indica si un artículo proveedor esta seleccionado para edición
        /// </summary>
        bool articuloProveedorSeleccionado;
        #endregion

        #region Constructores
        public  frmABMArticulo()
        {
            InitializeComponent();
            this.inicializarModoFormularioInicio();
            this.Text = "Gestión de Artículos";
            this.pathimagen.Text = "";

            this.inicializarControles();

            glb_lst_respuestasValidaciones = new List<bool>();
            for (int i = 0; i < 7; i++)
            {
                glb_lst_respuestasValidaciones.Add(false);
            }
        }
        /// <summary>
        /// Uso externo para visualizar artículo
        /// </summary>
        /// <param name="p_mod_articuloProveedor"></param>
        /// <param name="p_modoFormulario"></param>
        public frmABMArticulo(ModeloArticuloProveedores p_mod_articuloProveedor, string p_modoFormulario) : this()
        {
            glb_mod_articuloProveedor = p_mod_articuloProveedor;
            this.modoFormulario = p_modoFormulario;
        }
        #endregion

        #region Métodos

        #region Inicialización
        public override void inicializarForm(int ventanaAncho, int ventanaAlto)
        {
            this.tblLayoutPanelPrincipal.Width = ventanaAncho - 20; //un margen derecho de 20 para que se vea scrollbar
            this.pnlBase.Width = ventanaAncho - 3;  //un márgen derecho de 3
            this.pnlBase.Height = ventanaAlto - 60; //un márgen arriba para que se vea título

            if (Height < 500)
            {
                this.tblLayoutPanelPrincipal.Height = 500;  //Mínimo
                this.pnlBase.AutoScroll = true;
                ScrollBar vScrollBar = new VScrollBar();
                vScrollBar.Dock = DockStyle.Right;
                vScrollBar.Scroll += (sender, e) => { pnlBase.VerticalScroll.Value = vScrollBar.Value; };
                pnlBase.Controls.Add(vScrollBar);
            }
            else
            {
                this.tblLayoutPanelPrincipal.Height = Height - 66; // 60 pixeles para que se vea título de ventana principal
            }

            int x = Convert.ToInt16(Math.Round(Convert.ToDouble((Width - this.tblLayoutPanelPrincipal.Width) / 2)));
            this.tblLayoutPanelPrincipal.Location = new Point(10, 0);
            this.pnlBase.Location = new Point(0, 65);
        }

        override public void inicializarModoFormularioInicio()
        {
            glb_mod_articulo = new ModeloArticulos();

            base.inicializarModoFormularioInicio();

            txtBoxCodigoOriginal.Enabled = true;
            this.articuloSeleccionado = false;
        }

        override public void inicializarModoFormularioNuevo()
        {
            glb_mod_articulo = new ModeloArticulos();
            glb_mod_articuloProveedor = new ModeloArticuloProveedores();
            glb_lst_mod_articulosProveedores = new List<ModeloArticuloProveedores>();

            base.inicializarModoFormularioNuevo();

            txtBoxCodigoOriginal.Enabled = true;
            this.articuloSeleccionado = false;
        }

        override public void inicializarModoFormularioSeleccionado()
        {
            base.inicializarModoFormularioSeleccionado();
            
            txtBoxCodigoOriginal.Enabled = false;
            this.articuloSeleccionado = true;
        }
        public override void inicializarModoFormularioVisualizarEntidad()
        {
            foreach (Control c in this.Controls)
            {
                c.Enabled = false;
            }
            this.menuStrip.Enabled = true;
            base.inicializarModoFormularioVisualizarEntidad();

            this.cargarArticuloProveedorEnControles(glb_mod_articuloProveedor);
        }
       
        private void inicializarControles()
        {
            txtBoxPrecioCompra.KeyPress += this.valorDecimal;
            txtBoxPrecioVenta.KeyPress += this.valorDecimal;
            this.dgvArticulosProveedores.MouseDown += this.dgvArticulosProveedores_MouseDown;

            this.inicializarCmbBoxProveedores();
        }
        private void inicializarCmbBoxProveedores()
        {
            List<ModeloProveedor> lcl_lst_mod_proveedores = ControladorBusqueda.getProveedores().OrderBy(x => x.razonSocial).ToList();
            var dataSource = new List<ComboBoxItem>();

            for (int i = 0; i < lcl_lst_mod_proveedores.Count; i++)
            {
                dataSource.Add(new ComboBoxItem()
                {
                    Name = lcl_lst_mod_proveedores[i].razonSocial,
                    Value = lcl_lst_mod_proveedores[i]
                });
            }
            if (dataSource.Count < 1)
            {
                dataSource.Add(new ComboBoxItem() { Name = "--No existen proveedores--", Value = null });
                this.cmbBoxProveedores.Enabled = false;
            }
            else
            {
                dataSource.Insert(0, new ComboBoxItem() { Name = "--Seleccionar--", Value = null });
            }
            this.cmbBoxProveedores.DataSource = dataSource;
            InicializarCmbBox(this.cmbBoxProveedores);
        }
        #endregion

        #region ABM
      
        #region ABM Artículo
        /// <summary>
        /// Inicia proceso de alta y muestra mensaje de acuerdo si la operación ha sido exitosa o fallida
        /// </summary>
        private void alta()
        {
            glb_mod_articulo = this.cargarDatosEnModeloArticulo();
            if (!this.validarABM(glb_mod_articulo))
            {
                return;
            }

            if (!this.glb_banderaCodigoOriginal)
            { return; }

            ControladorAlta lcl_con_alta = new ControladorAlta();
            if (lcl_con_alta.agregar(glb_mod_articulo))
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
            if (!this.validarABM(glb_mod_articulo))
            {
                return;
            }
            if(lcl_con_baja.eliminar(glb_mod_articulo))
            {
                MessageBox.Show("Eliminación exitosa", "Éxito", MessageBoxButtons.OK);
                this.inicializarModoFormularioInicio();
                QuitarTextoEnControles(this);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show(lcl_con_baja.errorActual, "Error", MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
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
            glb_mod_articulo = this.cargarDatosEnModeloArticulo();
            if (!this.validarABM(glb_mod_articulo))
            {
                return;
            }
            
           // if (!glb_banderaCodigoOriginal)
           // { return; }

            ControladorModificacion lcl_con_modificacion = new ControladorModificacion();
            if (lcl_con_modificacion.modificar(glb_mod_articulo))
            {
                MessageBox.Show("Modificación exitosa", "Éxito", MessageBoxButtons.OK);
                this.inicializarModoFormularioSeleccionado();
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

        #region ABM Artículo Proveedor
        /// <summary>
        /// Inicia proceso de alta y muestra mensaje de acuerdo si la operación ha sido exitosa o fallida
        /// </summary>
        private void alta_ArticuloProveedor()
        {
            glb_mod_articuloProveedor = this.cargarDatosEnModeloArticuloProveedor();
            if (!this.validarABM(glb_mod_articuloProveedor))
            {
                return;
            }

            ControladorAlta lcl_con_alta = new ControladorAlta();
            if (lcl_con_alta.agregar(glb_mod_articuloProveedor))
            {
                glb_lst_mod_articulosProveedores.Add(glb_mod_articuloProveedor);
                this.actualizarDataGridView();
                MessageBox.Show("Alta exitosa", "Éxito", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show(lcl_con_alta.errorActual, "Error", MessageBoxButtons.RetryCancel);
                if (dialogResult == DialogResult.Retry)
                {
                    this.alta_ArticuloProveedor();
                }
            }
        }

        /// <summary>
        /// Inicia proceso de baja y muestra mensaje de acuerdo si la operación ha sido exitosa o fallida
        /// </summary>
        private void baja_ArticuloProveedor()
        {
            if (!this.validarABM(glb_mod_articuloProveedor))
            {
                return;
            }

            ControladorBaja lcl_con_baja = new ControladorBaja();
            if (lcl_con_baja.eliminar(glb_mod_articuloProveedor))
            {
                QuitarTextoEnControles(this.tblLayoutPanelArticulosProveedores);
                this.glb_lst_mod_articulosProveedores.Remove(glb_mod_articuloProveedor);
                this.actualizarDataGridView();
                MessageBox.Show("Eliminación exitosa", "Éxito", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show(lcl_con_baja.errorActual, "Error", MessageBoxButtons.RetryCancel);
                if (dialogResult == DialogResult.Retry)
                {
                    this.baja_ArticuloProveedor();
                }
            }
        }

        /// <summary>
        /// Inicia proceso de actualización y muestra mensaje de acuerdo si la operación ha sido exitosa o fallida
        /// </summary>
        private void actualizar_ArticuloProveedor()
        {
            glb_mod_articuloProveedor = this.cargarDatosEnModeloArticuloProveedor();
            if (!this.validarABM(glb_mod_articuloProveedor))
            {
                return;
            }
            
            ControladorModificacion lcl_con_modificacion = new ControladorModificacion();
            if (lcl_con_modificacion.modificar(glb_mod_articuloProveedor))
            {
                this.actualizarDataGridView();
                MessageBox.Show("Modificación exitosa", "Éxito", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show(lcl_con_modificacion.errorActual, "Error", MessageBoxButtons.RetryCancel);
                if (dialogResult == DialogResult.Retry)
                {
                    this.actualizar_ArticuloProveedor();
                }
            }
        }
        #endregion
        
        #endregion

        #region Búsqueda
        /// <summary>
        /// Muestra cuadro de resultado de búsqueda de la clase buscada o mensaje de error en caso de que no se haya podido mostrar
        /// </summary>
        private void buscar(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBoxCodigoOriginal.Text.ToString()))
            {
                this.txtBoxCodigoOriginal_Leave(sender, e);
            }
            if (!string.IsNullOrWhiteSpace(txtBoxDescripcion.Text.ToString()))
            {
                this.txtBoxDescripcion_Leave(sender, e);
            }
            if (!string.IsNullOrWhiteSpace(txtBoxModelo.Text.ToString()))
            {
                this.txtBoxModelo_Leave(sender, e);
            }
            if (glb_lst_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Articulos.CodigoOriginal)]
                || glb_lst_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Articulos.Descripcion)]
                || glb_lst_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.ArticulosProveedores.Modelo)])
            {
                this.articuloProveedorSeleccionado = false;//para habilitar ingresar datos en codigo articulo proveedor para nueva entidad
                //if algo buscar articulo proveedor
                this.buscarArticulo();
                this.glb_mod_articuloProveedor = new ModeloArticuloProveedores(glb_mod_articulo);
                this.buscarArticulosProveedores();
            }
            if (string.IsNullOrWhiteSpace(txtBoxCodigoOriginal.Text.ToString())
                & string.IsNullOrWhiteSpace(txtBoxDescripcion.Text.ToString())
                & string.IsNullOrWhiteSpace(txtBoxModelo.Text.ToString()))
            {
                MessageBox.Show("Por favor ingrese al menos uno de los campos antes de realizar una búsqueda");
            }
        }
        private void buscarArticulo()
        {
            frmResultadoBusqueda lcl_frm_resultadoBusqueda = new frmResultadoBusqueda();
            glb_mod_articulo = this.cargarDatosEnModeloArticulo();
            lcl_frm_resultadoBusqueda.mostrarBusqueda(glb_mod_articulo);
            if (lcl_frm_resultadoBusqueda.modeloSeleccionado != null)
            {
                this.modoFormulario = ModoFormularioSeleccionado;

                glb_mod_articulo = lcl_frm_resultadoBusqueda.modeloSeleccionado as ModeloArticulos;
                this.cargarArticuloEnControles(glb_mod_articulo);
            }
        }
        /// <summary>
        /// Busca artículo proveedor de acuerdo al artículo encontrado en busqueda anterior
        /// </summary>
        private void buscarArticulosProveedores()
        {
            if (!this.articuloSeleccionado)
            {
                return;
            }

            this.actualizarDataGridView();
        }
        
        /// <summary>
        /// Busca artículo proveedor de acuerdo a parámetros de artículo proveedor
        /// </summary>
        /// <param name="p_mod_articuloProveedor"></param>
        private void buscarArticulosProveedores(ModeloArticuloProveedores p_mod_articuloProveedor)
        {
            frmResultadoBusqueda lcl_frm_resultadoBusqueda = new frmResultadoBusqueda();
            lcl_frm_resultadoBusqueda.mostrarBusqueda(p_mod_articuloProveedor);
            if (lcl_frm_resultadoBusqueda.modeloSeleccionado != null)
            {
                this.modoFormulario = ModoFormularioSeleccionado;

                glb_mod_articuloProveedor = lcl_frm_resultadoBusqueda.modeloSeleccionado as ModeloArticuloProveedores;
                this.cargarArticuloProveedorEnControles(glb_mod_articuloProveedor);
            }
        }
        #endregion
        
        #region Controles -> Modelo
        private ModeloArticulos cargarDatosEnModeloArticulo()
        {
            ModeloArticulos lcl_mod_articulo = new ModeloArticulos();
            lcl_mod_articulo.codigoOriginal = txtBoxCodigoOriginal.Text;
            lcl_mod_articulo.descripcion = txtBoxDescripcion.Text;
            lcl_mod_articulo.modelos = txtBoxModelo.Text;
            lcl_mod_articulo.observaciones = rchTextBoxObservaciones.Text;
            lcl_mod_articulo.imagen = this.pathimagen.Text;
            return lcl_mod_articulo;
        }

        private ModeloArticuloProveedores cargarDatosEnModeloArticuloProveedor()
        {
            ModeloArticuloProveedores lcl_mod_articuloProveedores 
                = new ModeloArticuloProveedores(this.cargarDatosEnModeloArticulo());

            ModeloProveedor lcl_mod_proveedor = this.cmbBoxProveedores.SelectedValue as ModeloProveedor;
            if (lcl_mod_proveedor == null)
            {
                return null;
            }
            lcl_mod_articuloProveedores.codigoEntidad = lcl_mod_proveedor.codigo;
            lcl_mod_articuloProveedores.razonSocialProveedor = lcl_mod_proveedor.razonSocial;

            lcl_mod_articuloProveedores.codigoArticuloProveedor = txtBoxCodigoArticulo.Text;
            lcl_mod_articuloProveedores.ubicacion = txtBoxUbicacion.Text;
            lcl_mod_articuloProveedores.stockActual = Convert.ToInt32(nmrcUpDownStockActual.Value);
            lcl_mod_articuloProveedores.stockMinimo = Convert.ToInt32(nmrcUpDownStockMinimo.Value);
            lcl_mod_articuloProveedores.descripcionArticuloProveedor = txtBoxDescripcionArticuloProveedor.Text;
            if (LibreriaClasesCompartidas.Validar.validarInputNumerico(txtBoxPrecioCompra.Text.ToString(), LibreriaClasesCompartidas.Constantes.Numericos.Decimal))
            {
                lcl_mod_articuloProveedores.valorCompra.valorArticulo = Convert.ToDecimal(txtBoxPrecioCompra.Text);
            }
            else
            {
                lcl_mod_articuloProveedores.valorCompra.valorArticulo = null;
            }
            //lcl_mod_articuloProveedores.valorCompra.valorArticulo = Convert.ToDecimal(txtBoxPrecioCompra.Text);
            if (LibreriaClasesCompartidas.Validar.validarInputNumerico(txtBoxPrecioVenta.Text.ToString(), LibreriaClasesCompartidas.Constantes.Numericos.Decimal))
            {
                lcl_mod_articuloProveedores.valorVenta.valorArticulo = Convert.ToDecimal(txtBoxPrecioVenta.Text);
            }
            else
            {
                lcl_mod_articuloProveedores.valorVenta.valorArticulo = null;
            }
            //lcl_mod_articuloProveedores.valorVenta.valorArticulo = Convert.ToDecimal(txtBoxPrecioVenta.Text);
            lcl_mod_articuloProveedores.observacionesArticuloProveedor = rchTextBoxObservaciones.Text;

            return lcl_mod_articuloProveedores;
        }

        #endregion

        #region Modelo -> Controles
        private void cargarArticuloEnControles(ModeloArticulos p_mod_articulo)
        {
            this.glb_mod_articulo = p_mod_articulo;

            txtBoxCodigoOriginal.Text = p_mod_articulo.codigoOriginal;
            txtBoxDescripcion.Text = p_mod_articulo.descripcion;
            txtBoxModelo.Text = p_mod_articulo.modelos;
            rchTextBoxObservaciones.Text = p_mod_articulo.observaciones;
            if (p_mod_articulo.imagen != null)
            { picBoxImagen.Image = Image.FromFile(p_mod_articulo.imagen);
            this.pathimagen.Text = p_mod_articulo.imagen;
            }
        }
        private void cargarArticuloProveedorEnControles(ModeloArticuloProveedores p_mod_articuloProveedor)
        {
            this.articuloProveedorSeleccionado = true;
            glb_mod_articuloProveedor = p_mod_articuloProveedor;

            this.cargarArticuloEnControles(p_mod_articuloProveedor as ModeloArticulos);

            this.cmbBoxProveedores.SelectedValue = ControladorBusqueda.getOne(new ModeloProveedor() { codigo = p_mod_articuloProveedor.codigoEntidad }, Constantes.ParametrosBusqueda.Entidades.CodigoEntidad) as ModeloProveedor;
            txtBoxCodigoArticulo.Text = p_mod_articuloProveedor.codigoArticuloProveedor;
            txtBoxUbicacion.Text = p_mod_articuloProveedor.ubicacion;
            txtBoxDescripcionArticuloProveedor.Text = p_mod_articuloProveedor.descripcionArticuloProveedor;
            nmrcUpDownStockActual.Value = Convert.ToInt32(p_mod_articuloProveedor.stockActual);
            nmrcUpDownStockActual.Text = nmrcUpDownStockActual.Value.ToString();
            nmrcUpDownStockMinimo.Value = Convert.ToInt32(p_mod_articuloProveedor.stockMinimo);
            nmrcUpDownStockMinimo.Text = nmrcUpDownStockMinimo.Value.ToString();
            txtBoxPrecioCompra.Text = p_mod_articuloProveedor.valorCompra.valorArticulo.ToString();
            txtBoxPrecioVenta.Text = p_mod_articuloProveedor.valorVenta.valorArticulo.ToString();
            rchTextBoxObservaciones_ArticuloProveedor.Text = p_mod_articuloProveedor.observacionesArticuloProveedor;
            rchTextBoxObservaciones.Text = p_mod_articuloProveedor.observaciones;
        }
        private void actualizarDataGridView()
        {
            //se lo inicializa así para solo pasar la parte de ModeloArticulo (codigoOriginal, descripcion, modelo)
            ModeloArticuloProveedores lcl_mod_articuloProveedor = new ModeloArticuloProveedores(glb_mod_articuloProveedor as ModeloArticulos);

            frmResultadoBusqueda lcl_frm_resultadoBusqueda = new frmResultadoBusqueda(lcl_mod_articuloProveedor);
            this.tblLayoutPanelArticulosProveedores_Base.Controls.Remove(this.dgvArticulosProveedores);
            this.dgvArticulosProveedores = new DataGridView();
            this.dgvArticulosProveedores = lcl_frm_resultadoBusqueda.dataGridViewResultadoBusqueda;
            this.dgvArticulosProveedores.MouseDown += this.dgvArticulosProveedores_MouseDown;
            this.glb_lst_mod_articulosProveedores = lcl_frm_resultadoBusqueda.glb_lst_objetos.Cast<ModeloArticuloProveedores>().ToList();
            this.tblLayoutPanelArticulosProveedores_Base.Controls.Add(this.dgvArticulosProveedores, 0, 2);
            
            this.dgvArticulosProveedores.ClearSelection();
            this.dgvArticulosProveedores.CurrentCell = null;
        }
       
        #endregion

        #region Validación

        private int getIndex(string p_inputName)
        {
            int index;
            switch (p_inputName)
            {
                case Constantes.ParametrosBusqueda.Articulos.CodigoOriginal:
                    index = 0;
                    break;
                case Constantes.ParametrosBusqueda.Articulos.Descripcion:
                    index = 1;
                    break;
                case Constantes.ParametrosBusqueda.ArticulosProveedores.Modelo:
                    index = 2;
                    break;
                case Constantes.ParametrosBusqueda.ArticulosProveedores.CodigoArticuloProveedor:
                    index = 3;
                    break;
                case Constantes.ParametrosBusqueda.ArticulosProveedores.Ubicacion:
                    index = 4;
                    break;
                case Constantes.TipoValorArticulo.Compra:
                    index = 5;
                    break;
                case Constantes.TipoValorArticulo.Venta:
                    index = 6;
                    break;
                default:
                    index = 0;
                    break;
            }
            return index;
        }

        private bool validarInputs(object sender, EventArgs e)
        {
            txtBoxCodigoArticulo_Leave(sender, e);
            txtBoxCodigoOriginal_Leave(sender, e);
            txtBoxDescripcion_Leave(sender, e);
            txtBoxModelo_Leave(sender, e);
            txtBoxPrecioCompra_Leave(sender, e);
            txtBoxPrecioVenta_Leave(sender, e);
            //txtBoxUbicacion_Leave(sender, e);//Comentareo por no ser un campo NECESARIO
            return (glb_lst_respuestasValidaciones[0] & glb_lst_respuestasValidaciones[1] & glb_lst_respuestasValidaciones[2]
                 & glb_lst_respuestasValidaciones[3] & //glb_lst_respuestasValidaciones[4] & 
                 glb_lst_respuestasValidaciones[5]
                  & glb_lst_respuestasValidaciones[6]);
        }
        private bool validarABM(ModeloArticulos p_mod_articulo)
        {
            if (p_mod_articulo == null)
            {//se da cuando se inicia baja de artículo proveedor sin que haya un artículo seleccionado
                MessageBox.Show("Revisar campos");
                return false;
            }
            //if (String.IsNullOrWhiteSpace(p_mod_articulo.codigoOriginal))
            //{
            //    MessageBox.Show("revisar código original");
            //    return false;
            //}
            //if (String.IsNullOrWhiteSpace(p_mod_articulo.descripcion))
            //{
            //    MessageBox.Show("revisar descripción artículo");
            //    return false;
            //}
            return true;
        }
        private bool validarABM(ModeloArticuloProveedores p_mod_articuloProveedor)
        {
            if (!this.validarABM(p_mod_articuloProveedor as ModeloArticulos))
            {
                return false;
            }

            //if (String.IsNullOrWhiteSpace(p_mod_articuloProveedor.codigoArticuloProveedor))
            //{
            //    MessageBox.Show("revisar código artículo proveedor");
            //    return false;
            //}
            if (this.cmbBoxProveedores.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un proveedor");
                return false;
            }

            return true;
        }
        #endregion

        #endregion

        #region Eventos

        #region toolStripMenuItem

        override public void toolStripMenuItemLimpiarCampos_Click(object sender, EventArgs e)
        {
            this.modoFormulario = ModoFormularioInicio;
            QuitarTextoEnControles(this);
            this.clearErrorProviders();
        }

        override public void toolStripMenuItemEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea eliminar el artículo seleccionado?", "Atención", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.baja();
            }
        }

        override public void toolStripMenuItemGuardarNuevo_Click(object sender, EventArgs e)
        {
            this.alta();
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
            modoFormulario = ModoFormularioNuevo;
        }

        override public void toolStripMenuItemBuscar_Click(object sender, EventArgs e)
        {
            this.buscar(sender,e);
        }
        #endregion
        
        #region TextBoxes
        private void txtBoxCodigoOriginal_Leave(object sender, EventArgs e)
        {
            string lcl_mensaje;
            if (!Validar.validarLongitud(txtBoxCodigoOriginal.Text, Constantes.ParametrosBusqueda.Articulos.CodigoOriginal, out lcl_mensaje))
            {
                this.setErrorProvider(txtBoxCodigoOriginal, false, lcl_mensaje);
            }
            else
            {
                bool respuesta = Validar.validarInputNoNumerico(txtBoxCodigoOriginal.Text.ToString(), Constantes.ParametrosBusqueda.Articulos.CodigoOriginal);
                glb_lst_respuestasValidaciones[this.getIndex(Constantes.ParametrosBusqueda.Articulos.CodigoOriginal)] = respuesta;
                lcl_mensaje = respuesta ? "OK" : "Código Orignal no válido";
                this.setErrorProvider(txtBoxCodigoOriginal, respuesta, lcl_mensaje);
                if (respuesta) { glb_banderaCodigoOriginal = true; }
            }
        }

        private void txtBoxDescripcion_Leave(object sender, EventArgs e)
        {
            string lcl_mensaje;
            if (!Validar.validarLongitud(txtBoxDescripcion.Text, Constantes.ParametrosBusqueda.Articulos.Descripcion, out lcl_mensaje))
            {
                this.setErrorProvider(txtBoxDescripcion, false, lcl_mensaje);
            }
            else
            {
                bool respuesta = Validar.validarInputNoNumerico(txtBoxDescripcion.Text.ToString(), Constantes.ParametrosBusqueda.Articulos.Descripcion);
                glb_lst_respuestasValidaciones[this.getIndex(Constantes.ParametrosBusqueda.Articulos.Descripcion)] = respuesta;
                lcl_mensaje = respuesta ? "OK" : "Descripción no válida";
                this.setErrorProvider(txtBoxDescripcion, respuesta, lcl_mensaje);
            }
        }

        private void txtBoxModelo_Leave(object sender, EventArgs e)
        {
            string lcl_mensaje;
            if (!Validar.validarLongitud(txtBoxModelo.Text, Constantes.ParametrosBusqueda.ArticulosProveedores.Modelo, out lcl_mensaje))
            {
                this.setErrorProvider(txtBoxModelo, false, lcl_mensaje);
            }
            else
            {
                bool respuesta = Validar.validarInputNoNumerico(txtBoxModelo.Text.ToString(), Constantes.ParametrosBusqueda.ArticulosProveedores.Modelo);
                glb_lst_respuestasValidaciones[this.getIndex(Constantes.ParametrosBusqueda.ArticulosProveedores.Modelo)] = respuesta;
                lcl_mensaje = respuesta ? "OK" : "Modelo no válido";
                this.setErrorProvider(txtBoxModelo, respuesta, lcl_mensaje);
            }
        }
        private void txtBoxCodigoArticulo_Leave(object sender, EventArgs e)
        {
            string lcl_mensaje;
            if (!Validar.validarLongitud(txtBoxCodigoArticulo.Text, Constantes.ParametrosBusqueda.ArticulosProveedores.CodigoArticuloProveedor, out lcl_mensaje))
            {
                this.setErrorProvider(txtBoxCodigoArticulo, false, lcl_mensaje);
            }
            else
            {
                bool respuesta = Validar.validarInputNoNumerico(txtBoxCodigoArticulo.Text.ToString(), Constantes.ParametrosBusqueda.ArticulosProveedores.CodigoArticuloProveedor);
                glb_lst_respuestasValidaciones[this.getIndex(Constantes.ParametrosBusqueda.ArticulosProveedores.CodigoArticuloProveedor)] = respuesta;
                lcl_mensaje = respuesta ? "OK" : "Código Artículo Proveedor no válido";
                this.setErrorProvider(txtBoxCodigoArticulo, respuesta, lcl_mensaje);
            }
        }
        private void txtBoxPrecioCompra_Leave(object sender, EventArgs e)
        {
            bool respuesta = Validar.validarInputNumerico(txtBoxPrecioCompra.Text.ToString(), Constantes.Numericos.DecimalPositivo);
            glb_lst_respuestasValidaciones[this.getIndex(Constantes.TipoValorArticulo.Compra)] = respuesta;
            string lcl_mensaje = respuesta ? "OK" : "Precio no válido";
            this.setErrorProvider(txtBoxPrecioCompra, respuesta, lcl_mensaje);
        }

        private void txtBoxPrecioVenta_Leave(object sender, EventArgs e)
        {
            bool respuesta = Validar.validarInputNumerico(txtBoxPrecioVenta.Text.ToString(), Constantes.Numericos.DecimalPositivo);
            glb_lst_respuestasValidaciones[this.getIndex(Constantes.TipoValorArticulo.Venta)] = respuesta;
            string lcl_mensaje = respuesta ? "OK" : "Precio no válido";
            this.setErrorProvider(txtBoxPrecioVenta, respuesta, lcl_mensaje);
        }

        private void txtBoxUbicacion_Leave(object sender, EventArgs e)
        {
            string lcl_mensaje;
            if (!Validar.validarLongitud(txtBoxUbicacion.Text, Constantes.ParametrosBusqueda.ArticulosProveedores.Ubicacion, out lcl_mensaje))
            {
                this.setErrorProvider(txtBoxUbicacion, false, lcl_mensaje);
            }
            else
            {
                bool respuesta = Validar.validarInputNoNumerico(txtBoxUbicacion.Text.ToString(), Constantes.ParametrosBusqueda.ArticulosProveedores.Ubicacion);
                glb_lst_respuestasValidaciones[this.getIndex(Constantes.ParametrosBusqueda.ArticulosProveedores.Ubicacion)] = respuesta;
                lcl_mensaje = respuesta ? "OK" : "Ubicación no válido";
                this.setErrorProvider(txtBoxUbicacion, respuesta, lcl_mensaje);
            }
        }
        #endregion
       
        #region DataGridView
        private void dgvArticulosProveedores_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                int currentMouseOverRow = this.dgvArticulosProveedores.HitTest(e.X, e.Y).RowIndex;
                if (currentMouseOverRow >= 0)
                {
                    if ((ModifierKeys & Keys.Control) != Keys.Control
                        && this.dgvArticulosProveedores.Rows[currentMouseOverRow].Selected != true)
                    {//si selected == true significa que puede haber más elementos seleccionados anteriormente y no hay que perder selección
                        this.dgvArticulosProveedores.ClearSelection();
                    }
                    this.dgvArticulosProveedores.Rows[currentMouseOverRow].Selected = true;

                    //this.cntxMenuResultadoBusqueda.Show(this.dgvResultadoBusqueda, new Point(e.X, e.Y));
                }
            }
            else if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                int currentMouseOverRow = this.dgvArticulosProveedores.HitTest(e.X, e.Y).RowIndex;
                if (currentMouseOverRow >= 0)
                {
                    this.dgvArticulosProveedores.ClearSelection();
                    
                    this.dgvArticulosProveedores.Rows[currentMouseOverRow].Selected = true;
                    int indice = Convert.ToInt32(this.dgvArticulosProveedores.SelectedRows[0].Cells["dgvKey"].Value);
                    this.cargarArticuloProveedorEnControles(this.glb_lst_mod_articulosProveedores[indice]);
                }
            }

        }
        #endregion

        #region Buttons
        private void btnAgregarArticuloProveedor_Click(object sender, EventArgs e)
        {
            if (this.validarInputs(sender, e))
            {
                this.alta_ArticuloProveedor();
            }
            else
            {
                MessageBox.Show("Existen compos erroneamente ingresados, por favor corríjalos");
            }
        }

        private void btnEditarArticuloProveedor_Click(object sender, EventArgs e)
        {
            if (this.validarInputs(sender, e))
            {
                this.actualizar_ArticuloProveedor();
            }
            else
            {
                MessageBox.Show("Existen campos erroneamente ingresados, por favor corríjalos");
            }
        }

        private void btnEliminarArticuloProveedor_Click(object sender, EventArgs e)
        {
             DialogResult dialog = MessageBox.Show("Esta seguro que desea eliminar el articulo de proveedor "+ this.glb_mod_articuloProveedor.codigoArticuloProveedor +"?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
             if (dialog == DialogResult.Yes)
             { this.baja_ArticuloProveedor(); }

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

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if(this.glb_mod_articulo == null || String.IsNullOrEmpty(this.txtBoxCodigoOriginal.Text) )
            {return;}

            if (System.IO.File.Exists(this.glb_mod_articulo.imagen))
            {
                DialogResult dialog = MessageBox.Show("Esta seguro que desea quitar la imagen?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                   
                    this.picBoxImagen.Image = null;
                    this.pathimagen.Text = null;
                    this.glb_mod_articulo.imagen = null;
                }
            }
        }

        private void btnAgregaImagen_Click(object sender, EventArgs e)
        {
            if (this.glb_mod_articulo == null || String.IsNullOrEmpty(this.txtBoxCodigoOriginal.Text))
            { return; }

            OpenFileDialog image_dialog = new OpenFileDialog();
            string imagePath = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\Vista\Resources\";
            image_dialog.Filter = "*.jpg|*.png";
            
            DialogResult result = image_dialog.ShowDialog();
            
            if (result == DialogResult.OK)
            {
                imagePath = imagePath + glb_mod_articulo.codigoOriginal + ".jpg";
                string imagePath_aux = imagePath + glb_mod_articulo.codigoOriginal ;
                for (int i = 0; System.IO.File.Exists(imagePath); i++)
                {
                    imagePath = imagePath_aux + "(" + i.ToString() + ")" + ".jpg";
                }
                
                System.IO.File.Copy(image_dialog.FileName, imagePath);
                picBoxImagen.Image = Image.FromFile(imagePath);
                this.glb_mod_articulo.imagen = imagePath;
                this.pathimagen.Text = imagePath;
            }

        }


    }
}
