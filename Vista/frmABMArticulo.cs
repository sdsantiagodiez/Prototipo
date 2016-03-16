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
        //Seleccionado es el que resulta de un objeto que se encuentra en la base de datos
        //Actual puede ser un objeto nuevo o resultado de la base de datos con posibles modificaciones
        ModeloArticulos glb_mod_articuloActual;
        ModeloArticulos glb_mod_articuloSeleccionado;
        #endregion

        public  frmABMArticulo()
        {
            InitializeComponent();
            this.inicializarModoFormularioInicio();
            this.Text = "Artículo";
        }

        #region Métodos
       
        #region Inicialización
        override public void inicializarModoFormularioInicio()
        {
            glb_mod_articuloActual = new ModeloArticulos();
            glb_mod_articuloSeleccionado = new ModeloArticulos();

            base.inicializarModoFormularioInicio();

            txtBoxCodigoOriginal.Enabled = true;
        }

        override public void inicializarModoFormularioNuevo()
        {
            glb_mod_articuloActual = new ModeloArticulos();
            glb_mod_articuloSeleccionado = new ModeloArticulos();

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
        }

        /// <summary>
        /// Valida datos para el alta. En caso de algún campo no válido, muestra mensaje explicando 
        /// </summary>
        /// <returns>true si todos los campos son válidos, false caso contrario</returns>
        private bool validarAlta()
        {
            //Retornar bool y mostrar mensaje por la primera validación fallida encontrada. Si no se encuentra error, no se muestra mensaje y se devuelve true
            return true;
        }

        /// <summary>
        /// Se comunica con controlador para realizar alta
        /// </summary>
        /// <returns>true si se ha registrado en la base de datos, false caso contrario</returns>
        private bool guardarNuevo()
        {
            ControladorAlta lcl_con_alta = new ControladorAlta();
            glb_mod_articuloActual = glb_mod_articuloSeleccionado = this.cargarDatosEnModeloArticulo();

            return lcl_con_alta.agregar(glb_mod_articuloActual);   
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
            bool exito = lcl_con_baja.eliminar(glb_mod_articuloSeleccionado);
            if (exito)
            {
                glb_mod_articuloSeleccionado = glb_mod_articuloActual = null;
            }
            return exito;
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
            bool exito = false;
            glb_mod_articuloActual = this.cargarDatosEnModeloArticulo();
            exito = lcl_con_modificacion.modificar(glb_mod_articuloActual);
            if (exito)
            {
                glb_mod_articuloSeleccionado = glb_mod_articuloActual;
            }
            return exito;
        }
        #endregion
        
        /// <summary>
        /// Muestra cuadro de resultado de búsqueda de la clase buscada o mensaje de error en caso de que no se haya podido mostrar
        /// </summary>
        private void buscar()
        {
            if (this.validarBusqueda())
            {
                glb_frm_resultadoBusqueda = new frmResultadoBusqueda();
                this.buscarArticulo();
            }
        }
        /// <summary>
        /// Valida parámetros de búsqueda. Muestra mensaje de error en caso de parámetro no válido
        /// </summary>
        /// <returns>true si todos los parámetros son válidos, false caso contrario</returns>
        private bool validarBusqueda()
        {
            return true;
        }
        private void buscarArticulo()
        {
            glb_mod_articuloActual = this.cargarDatosEnModeloArticulo();
            glb_frm_resultadoBusqueda.mostrarBusqueda(glb_mod_articuloActual);
            if (glb_frm_resultadoBusqueda.articulo != null)
            {
                this.modoFormulario = ModoFormularioSeleccionado;

                glb_mod_articuloSeleccionado = glb_frm_resultadoBusqueda.articulo;
                this.cargarArticuloEnControles(glb_mod_articuloSeleccionado);
            }
        }
        #endregion

        private ModeloArticulos cargarDatosEnModeloArticulo()
        {
            ModeloArticulos lcl_mod_articulo = new ModeloArticulos();
            lcl_mod_articulo.codigoOriginal = txtBoxCodigoOriginal.Text;
            lcl_mod_articulo.descripcion = txtBoxDescripcion.Text;
            lcl_mod_articulo.modelos = txtBoxModelo.Text;
            lcl_mod_articulo.observaciones = rchTextBoxObservaciones.Text;
            return lcl_mod_articulo;
        }

        private void cargarArticuloEnControles(ModeloArticulos p_mod_articulo)
        {
            glb_mod_articuloSeleccionado = p_mod_articulo;
            
            txtBoxCodigoOriginal.Text = glb_mod_articuloSeleccionado.codigoOriginal;
            txtBoxDescripcion.Text = glb_mod_articuloSeleccionado.descripcion;
            txtBoxModelo.Text = glb_mod_articuloSeleccionado.modelos;
            rchTextBoxObservaciones.Text = glb_mod_articuloSeleccionado.observaciones;
        }

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
