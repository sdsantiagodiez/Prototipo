using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Modelos;
using Controladores;

namespace Vista
{
    public partial class frmABMArticulo : Vista.frmABMBase
    {
        #region Atributos
        ModeloArticulos glb_mod_articulo;
        #endregion

        #region Constructores
        public  frmABMArticulo()
        {
            InitializeComponent();
            this.inicializarModoFormularioInicio();
            this.Text = "Artículo";
        }
        #endregion

        #region Métodos

        #region Inicialización
        public override void inicializarForm()
        {
            this.tblLayoutPanelPrincipal.Width = Width - 3; //un margen derecho de 3

            if (Height < 700)
            {
                this.tblLayoutPanelPrincipal.Height = 700;  //Mínimo
            }
            else
            {
                this.tblLayoutPanelPrincipal.Height = Height - 66; // 60 pixeles para que se vea título de ventana principal
            }

            int x = Convert.ToInt16(Math.Round(Convert.ToDouble((Width - this.tblLayoutPanelPrincipal.Width) / 2)));
            this.tblLayoutPanelPrincipal.Location = new Point(x, 65);
        }

        override public void inicializarModoFormularioInicio()
        {
            glb_mod_articulo = new ModeloArticulos();

            base.inicializarModoFormularioInicio();

            txtBoxCodigoOriginal.Enabled = true;
        }

        override public void inicializarModoFormularioNuevo()
        {
            glb_mod_articulo = new ModeloArticulos();

            base.inicializarModoFormularioNuevo();

            txtBoxCodigoOriginal.Enabled = true;
        }

        override public void inicializarModoFormularioSeleccionado()
        {
            base.inicializarModoFormularioSeleccionado();

            txtBoxCodigoOriginal.Enabled = false;
        }
        #endregion

        #region ABM
        /// <summary>
        /// Inicia proceso de alta y muestra mensaje de acuerdo si la operación ha sido exitosa o fallida
        /// </summary>
        private void alta()
        {
            if(!this.validar())
            { return; }

            ControladorAlta lcl_con_alta = new ControladorAlta();
            glb_mod_articulo = this.cargarDatosEnModeloArticulo();

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
            if(lcl_con_baja.eliminar(glb_mod_articulo))
            {
                MessageBox.Show("Eliminación exitosa", "Éxito", MessageBoxButtons.OK);
                this.inicializarModoFormularioInicio();
                this.quitarTextoEnControles(this);
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
            if (!this.validar())
            { return; }

            ControladorModificacion lcl_con_modificacion = new ControladorModificacion();
            glb_mod_articulo = this.cargarDatosEnModeloArticulo();

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

        #region Búsqueda
        /// <summary>
        /// Muestra cuadro de resultado de búsqueda de la clase buscada o mensaje de error en caso de que no se haya podido mostrar
        /// </summary>
        private void buscar()
        {
            this.buscarArticulo();
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
        #endregion
        
        #region Controles -> Modelo
        private ModeloArticulos cargarDatosEnModeloArticulo()
        {
            ModeloArticulos lcl_mod_articulo = new ModeloArticulos();
            lcl_mod_articulo.codigoOriginal = txtBoxCodigoOriginal.Text;
            lcl_mod_articulo.descripcion = txtBoxDescripcion.Text;
            lcl_mod_articulo.modelos = txtBoxModelo.Text;
            lcl_mod_articulo.observaciones = rchTextBoxObservaciones.Text;
            return lcl_mod_articulo;
        }
        #endregion

        #region Modelo -> Controles
        private void cargarArticuloEnControles(ModeloArticulos p_mod_articulo)
        {
            txtBoxCodigoOriginal.Text = p_mod_articulo.codigoOriginal;
            txtBoxDescripcion.Text = p_mod_articulo.descripcion;
            txtBoxModelo.Text = p_mod_articulo.modelos;
            rchTextBoxObservaciones.Text = p_mod_articulo.observaciones;
        }
        #endregion

        #region Validación
        private bool validar()
        {
            return this.validarCodigoOriginal();
        }

        private bool validarCodigoOriginal()
        {
            if (!ModeloArticulos.validarCodigoOriginal(txtBoxCodigoOriginal.Text))
            {
                errorProviderActual.SetError(txtBoxCodigoOriginal,"Este campo es obligatorio. No puede permanecer vacío.");
                return false;
            }
            errorProviderActual.SetError(txtBoxCodigoOriginal, "");
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
            this.buscar();
        }
        #endregion
        
        #endregion
    }
}
