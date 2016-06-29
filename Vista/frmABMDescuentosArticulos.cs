﻿using System;
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


namespace Vista
{
    public partial class frmDescuentosArticulos : Vista.frmABMBase
    {
        #region Atributos
        ModeloDescuento glb_mod_Descuento;
        ModeloArticuloProveedores glb_mod_articuloProveedor;
        #endregion

        #region Constructores
        public frmDescuentosArticulos()
        {
            InitializeComponent();
            this.inicializarModoFormularioInicio();
            this.Text = "Descuento Artículo";
                        
        }
        public frmDescuentosArticulos(ModeloDescuento p_mod_descuento,string p_modoFormulario): this()
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
            
            btnBuscarArticulo.Enabled = true;
            btnModificarArticulo.Enabled = false;
            txtBoxCodigoOriginal.Enabled = true;
            txtBoxDescripcion.Enabled = true;

            grpBoxProveedor.Enabled = true;

            btnBuscarProveedor.Enabled = true;
            btnModificarProveedor.Enabled = false;
            txtBoxCodigoProveedor.Enabled = true;
            txtBoxRazonSocial.Enabled = true;

            tbxFechaDesde.Enabled = false;
            tbxFechaHasta.Enabled = false;
            tbxnumeroDescuento.Enabled = false;
            tbxPorcentajeDescuento.Enabled = false;
            dgvDescuentos.Enabled = false;
            
        }

        override public void inicializarModoFormularioNuevo()
        {
            glb_mod_articuloProveedor = new ModeloArticuloProveedores();
            ControladorDescuento lcl_con_descuento = new ControladorDescuento();

            base.inicializarModoFormularioNuevo();

            grpBoxArticulo.Enabled = true;
            btnBuscarArticulo.Enabled = true;
            btnModificarArticulo.Enabled = false;
            txtBoxCodigoOriginal.Enabled = txtBoxDescripcion.Enabled = true;

            grpBoxProveedor.Enabled = true;
            btnBuscarProveedor.Enabled = true;
            btnModificarProveedor.Enabled = false;
            txtBoxCodigoProveedor.Enabled = txtBoxRazonSocial.Enabled = true;

            tbxFechaDesde.Text = DateTime.Today.ToString();
            tbxFechaHasta.Text = DateTime.Today.ToString();
            tbxnumeroDescuento.Text = lcl_con_descuento.getUltimoDescuento().ToString();
            tbxPorcentajeDescuento.Text = "0";

            dgvDescuentos.Enabled = false;
        }

        override public void inicializarModoFormularioSeleccionado()
        {
            base.inicializarModoFormularioSeleccionado();

            grpBoxArticulo.Enabled = false;

            grpBoxProveedor.Enabled = false;

            tbxnumeroDescuento.Enabled = false;
            tbxFechaDesde.Enabled = true;
            tbxFechaHasta.Enabled = true;
            tbxPorcentajeDescuento.Enabled = true;

        }

        public override void inicializarModoFormularioVisualizarEntidad()
        {
            base.inicializarModoFormularioVisualizarEntidad();

            foreach (Control c in this.Controls)
            {
                c.Enabled = false;
            }
            this.cargarArticuloProveedorEnControles(glb_mod_articuloProveedor);
        }

        private void inicializarModoArticuloSeleccionado()
        {
            txtBoxCodigoOriginal.Enabled = false;
            txtBoxDescripcion.Enabled = false;
            btnBuscarArticulo.Enabled = false;
            btnModificarArticulo.Enabled = true;
        }

        private void inicializarModoArticuloModificado()
        {
            txtBoxCodigoOriginal.Enabled = true;
            txtBoxDescripcion.Enabled = true;
            btnBuscarArticulo.Enabled = true;
            btnModificarArticulo.Enabled = false;
        }

        private void inicializarModoProveedorSeleccionado()
        {
            txtBoxCodigoProveedor.Enabled = false;
            txtBoxRazonSocial.Enabled = false;
            btnBuscarProveedor.Enabled = false;
            btnModificarProveedor.Enabled = true;
        }

        private void inicializarModoProveedorModificado()
        {
            txtBoxCodigoProveedor.Enabled = true;
            txtBoxRazonSocial.Enabled = true;
            btnBuscarProveedor.Enabled = true;
            btnModificarProveedor.Enabled = false;
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
            glb_mod_articuloProveedor = this.cargarDatosEnModeloArticuloProveedor();

            if(lcl_con_alta.agregar(glb_mod_articuloProveedor))
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
            if (lcl_con_baja.eliminar(glb_mod_articuloProveedor))
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
            glb_mod_articuloProveedor = this.cargarDatosEnModeloArticuloProveedor();

            if (lcl_con_modificacion.modificar(glb_mod_articuloProveedor))
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
                this.modoFormulario = ModoFormularioSeleccionado;

                glb_mod_articuloProveedor = lcl_frm_resultadoBusqueda.modeloSeleccionado as ModeloArticuloProveedores;
                this.cargarArticuloProveedorEnControles(glb_mod_articuloProveedor);
            }
        }
        private void buscarArticulo()
        {
            frmResultadoBusqueda lcl_frm_resultadoBusqueda = new frmResultadoBusqueda();
            ModeloArticulos lcl_mod_articulo = new ModeloArticulos();
            
            lcl_mod_articulo.codigoOriginal = txtBoxCodigoOriginal.Text;
            lcl_mod_articulo.descripcion = txtBoxDescripcion.Text;
            
            lcl_frm_resultadoBusqueda.mostrarBusqueda(lcl_mod_articulo);
            if (lcl_frm_resultadoBusqueda.modeloSeleccionado != null)
            {
                this.inicializarModoArticuloSeleccionado();
                txtBoxCodigoOriginal.Text = (lcl_frm_resultadoBusqueda.modeloSeleccionado as ModeloArticulos).codigoOriginal;
                txtBoxDescripcion.Text = (lcl_frm_resultadoBusqueda.modeloSeleccionado as ModeloArticulos).descripcion;

                this.cargarDatosArticuloEnModeloArticuloProveedor(ref glb_mod_articuloProveedor);
            }
        }
        private void buscarProveedor()
        {
            //Se podría ver de mostrar solo proveedores que tengan ese articuloOriginal en articuloProveedor
            frmResultadoBusqueda lcl_frm_resultadoBusqueda = new frmResultadoBusqueda();
            ModeloProveedor lcl_mod_proveedor = new ModeloProveedor();
            
            ModeloArticuloProveedores lcl_mod_articuloProveedor = new ModeloArticuloProveedores();
            this.cargarDatosProveedorEnModeloArticuloProveedor(ref lcl_mod_articuloProveedor);
            
            lcl_mod_proveedor.codigo = lcl_mod_articuloProveedor.codigoEntidad;
            lcl_mod_proveedor.razonSocial = lcl_mod_articuloProveedor.razonSocialProveedor;

            lcl_frm_resultadoBusqueda.mostrarBusqueda(lcl_mod_proveedor);
            if (lcl_frm_resultadoBusqueda.modeloSeleccionado != null)
            {
                this.inicializarModoProveedorSeleccionado();
                txtBoxCodigoProveedor.Text = (lcl_frm_resultadoBusqueda.modeloSeleccionado as ModeloProveedor).codigo.ToString();
                txtBoxRazonSocial.Text = (lcl_frm_resultadoBusqueda.modeloSeleccionado as ModeloProveedor).razonSocial;

                this.cargarDatosProveedorEnModeloArticuloProveedor(ref glb_mod_articuloProveedor);
            }
        }
        #endregion
        
        #region Controles -> Modelo
        private ModeloArticuloProveedores cargarDatosEnModeloArticuloProveedor()
        {
            ModeloArticuloProveedores lcl_mod_articuloProveedores = new ModeloArticuloProveedores();

            this.cargarDatosArticuloEnModeloArticuloProveedor(ref lcl_mod_articuloProveedores);
            this.cargarDatosProveedorEnModeloArticuloProveedor(ref lcl_mod_articuloProveedores);
            

            return lcl_mod_articuloProveedores;
        }

        private void cargarDatosArticuloEnModeloArticuloProveedor(ref ModeloArticuloProveedores p_mod_articuloProveedor)
        {
            p_mod_articuloProveedor.codigoOriginal = txtBoxCodigoOriginal.Text; ;
            p_mod_articuloProveedor.descripcion = txtBoxDescripcion.Text;
        }

        private void cargarDatosProveedorEnModeloArticuloProveedor(ref ModeloArticuloProveedores p_mod_articuloProveedor)
        {
            if (LibreriaClasesCompartidas.Validar.validarValorNumerico(txtBoxCodigoProveedor.Text))
            {
                p_mod_articuloProveedor.codigoEntidad = Convert.ToInt32(txtBoxCodigoProveedor.Text);
            }
            else
            {
                p_mod_articuloProveedor.codigoEntidad = 0;
            }
            //lcl_mod_articuloProveedores.codigoEntidad = Convert.ToInt32(txtBoxCodigoProveedor.Text);
            p_mod_articuloProveedor.razonSocialProveedor = txtBoxRazonSocial.Text;
        }

        
        #endregion
        
        #region Modelo -> Controles
        private void cargarArticuloProveedorEnControles(ModeloArticuloProveedores p_mod_articuloProveedor)
        {   //agregar como parametro la lista de Descuentos
            glb_mod_articuloProveedor = p_mod_articuloProveedor;

            txtBoxCodigoOriginal.Text = p_mod_articuloProveedor.codigoOriginal;
            txtBoxDescripcion.Text = p_mod_articuloProveedor.descripcion;
            txtBoxCodigoProveedor.Text = p_mod_articuloProveedor.codigoEntidad.ToString();
            txtBoxRazonSocial.Text = p_mod_articuloProveedor.razonSocialProveedor;
            
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
                return this.validarArticulo() && this.validarProveedor();
            }
            errorActual = "Ha surgido un error. Por favor, revise los valores ingresados.";
            return false;
        }
        private bool validarProveedor()
        {
            if (glb_mod_articuloProveedor.codigoEntidad == 0)
            {
                errorActual = "Debe seleccionar un proveedor.";
                return false;
            }
            return true;
        }
        private bool validarArticulo()
        {
            if (glb_mod_articuloProveedor.codigoOriginal == null)
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
            this.buscar();
        }
        #endregion

        #region Buttons
        private void btnBuscarArticulo_Click(object sender, EventArgs e)
        {
            this.buscarArticulo();
        }
        private void btnModificarArticulo_Click(object sender, EventArgs e)
        {
            this.inicializarModoArticuloModificado();
            this.quitarTextoEnControles(grpBoxArticulo);
            glb_mod_articuloProveedor.codigoOriginal = null;
            glb_mod_articuloProveedor.descripcion = null;
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            this.buscarProveedor();
        }
        private void btnModificarProveedor_Click(object sender, EventArgs e)
        {
            this.inicializarModoProveedorModificado();
            this.quitarTextoEnControles(grpBoxProveedor);
            glb_mod_articuloProveedor.codigoEntidad = 0;
            glb_mod_articuloProveedor.razonSocialProveedor = null;
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

              

    }
}
