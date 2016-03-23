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
            try
            {
                if (this.validarAlta())
                {
                    if (this.guardarNuevo())
                    {
                        MessageBox.Show("Alta exitosa", "Éxito", MessageBoxButtons.OK);
                        this.inicializarModoFormularioSeleccionado();
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Ha ocurrido un error durante la operación", "Error", MessageBoxButtons.RetryCancel);
                        if (dialogResult == DialogResult.Retry)
                        {
                            this.alta();
                        }
                    }
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
        }

        /// <summary>
        /// Valida datos para el alta. En caso de algún campo no válido, muestra mensaje explicando 
        /// </summary>
        /// <returns>true si todos los campos son válidos, false caso contrario</returns>
        private bool validarAlta()
        {
            return this.validar();
        }

        /// <summary>
        /// Se comunica con controlador para realizar alta
        /// </summary>
        /// <returns>true si se ha registrado en la base de datos, false caso contrario</returns>
        private bool guardarNuevo()
        {
            ControladorAlta lcl_con_alta = new ControladorAlta();
            glb_mod_articulo = this.cargarDatosEnModeloArticulo();

            return lcl_con_alta.agregar(glb_mod_articulo);   
        }

        /// <summary>
        /// Inicia proceso de baja y muestra mensaje de acuerdo si la operación ha sido exitosa o fallida
        /// </summary>
        private void baja()
        {
            if (this.validarBaja())
            {
                if (this.eliminar())
                {
                    MessageBox.Show("Eliminación exitosa", "Éxito", MessageBoxButtons.OK);
                    this.inicializarModoFormularioInicio();
                    this.quitarTextoEnControles(this);
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Ha ocurrido un error durante la operación", "Error", MessageBoxButtons.RetryCancel);
                    if (dialogResult == DialogResult.Retry)
                    {
                        this.baja();
                    }
                }
            }
        }

        /// <summary>
        /// Valida datos para la baja. En caso de algún campo no válido, muestra mensaje explicando 
        /// </summary>
        /// <returns>true si todos los campos son válidos, false caso contrario</returns>
        private bool validarBaja()
        {
            //Retornar bool y mostrar mensaje por la primera validación fallida encontrada. Si no se encuentra error, no se muestra mensaje y se devuelve true
            return true;
        }

        /// <summary>
        /// Se comunica con controlador para realizar baja
        /// </summary>
        /// <returns>true si se ha eliminado de la base de datos, falso caso contrario</returns>
        private bool eliminar()
        {
            ControladorBaja lcl_con_baja = new ControladorBaja();
            return  lcl_con_baja.eliminar(glb_mod_articulo);
        }

        /// <summary>
        /// Inicia proceso de actualización y muestra mensaje de acuerdo si la operación ha sido exitosa o fallida
        /// </summary>
        private void actualizar()
        {
            if (this.validarModificacion())
            {
                if (this.guardarModificaciones())
                {
                    MessageBox.Show("Modificación exitosa", "Éxito", MessageBoxButtons.OK);
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Ha ocurrido un error durante la operación", "Error", MessageBoxButtons.RetryCancel);
                    if (dialogResult == DialogResult.Retry)
                    {
                        this.actualizar();
                    }
                }
            }
        }

        /// <summary>
        /// Valida datos para la modificación. En caso de algún campo no válido, muestra mensaje explicando
        /// </summary>
        /// <returns>true si todos los campos son válidos, false caso contrario</returns>
        private bool validarModificacion()
        {
            //Retornar bool y mostrar mensaje por la primera validación fallida encontrada. Si no se encuentra error, no se muestra mensaje y se devuelve true
            return true;
        }

        /// <summary>
        /// Se comunica con controlador para realizar modificación
        /// </summary>
        /// <returns>true si se ha registrado modificación, false caso contrario</returns>
        private bool guardarModificaciones()
        {
            ControladorModificacion lcl_con_modificacion = new ControladorModificacion();
            glb_mod_articulo = this.cargarDatosEnModeloArticulo();
            return lcl_con_modificacion.modificar(glb_mod_articulo);
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
