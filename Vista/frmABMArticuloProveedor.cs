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
    public partial class frmABMArticuloProveedor : Vista.frmABMBase
    {
        #region Atributos
        //Seleccionado es el que resulta de un objeto que se encuentra en la base de datos
        //Actual puede ser un objeto nuevo o resultado de la base de datos con posibles modificaciones
        ModeloArticuloProveedores glb_mod_articuloProveedorActual;
        ModeloArticuloProveedores glb_mod_articuloProveedorSeleccionado;
        #endregion
        public frmABMArticuloProveedor()
        {
            InitializeComponent();
            this.inicializarModoFormularioInicio();
            this.Text = "Artículo Proveedor";
        }

        #region Métodos

        #region Inicialización
        override public void inicializarModoFormularioInicio()
        {
            base.inicializarModoFormularioInicio();
            
            grpBoxArticulo.Enabled = true;
            btnBuscarArticulo.Enabled = btnModificarArticulo.Enabled = false;
            txtBoxCodigoOriginal.Enabled = txtBoxDescripcion.Enabled = true;

            grpBoxProveedor.Enabled = true;
            btnBuscarProveedor.Enabled = btnModificarProveedor.Enabled = false;
            txtBoxCodigoProveedor.Enabled = txtBoxRazonSocial.Enabled = true;

            txtBoxCodigoArticulo.Enabled = true;
            txtBoxPrecioCompra.Enabled = txtBoxPrecioVenta.Enabled = txtBoxUbicacion.Enabled = nmrcUpDownStockActual.Enabled = nmrcUpDownStockMinimo.Enabled = false;

            grpBoxObservaciones.Enabled = false;
        }

        override public void inicializarModoFormularioNuevo()
        {
            base.inicializarModoFormularioNuevo();

            grpBoxArticulo.Enabled = true;
            btnBuscarArticulo.Enabled = true;
            btnModificarArticulo.Enabled = false;
            txtBoxCodigoOriginal.Enabled = txtBoxDescripcion.Enabled = true;

            grpBoxProveedor.Enabled = true;
            btnBuscarProveedor.Enabled = true;
            btnModificarProveedor.Enabled = false;
            txtBoxCodigoProveedor.Enabled = txtBoxRazonSocial.Enabled = true;

            txtBoxCodigoArticulo.Enabled = true;
            txtBoxPrecioCompra.Enabled = txtBoxPrecioVenta.Enabled = txtBoxUbicacion.Enabled = nmrcUpDownStockActual.Enabled = nmrcUpDownStockMinimo.Enabled = true;

            grpBoxObservaciones.Enabled = true;
        }

        override public void inicializarModoFormularioSeleccionado()
        {
            base.inicializarModoFormularioSeleccionado();

            grpBoxArticulo.Enabled = false;

            grpBoxProveedor.Enabled = false;

            txtBoxCodigoArticulo.Enabled = false;
            txtBoxPrecioCompra.Enabled = txtBoxPrecioVenta.Enabled = txtBoxUbicacion.Enabled = nmrcUpDownStockActual.Enabled = nmrcUpDownStockMinimo.Enabled = true;

            grpBoxObservaciones.Enabled = true;
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
            glb_mod_articuloProveedorActual = glb_mod_articuloProveedorSeleccionado = this.cargarDatosEnModeloArticuloProveedor();

            return lcl_con_alta.agregar(glb_mod_articuloProveedorActual);
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
                    this.quitarTextoEnControles(this);
                    MessageBox.Show("Eliminación exitosa", "Éxito", MessageBoxButtons.OK);
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
            bool exito = lcl_con_baja.eliminar(glb_mod_articuloProveedorSeleccionado);
            if (exito)
            {
                glb_mod_articuloProveedorSeleccionado = glb_mod_articuloProveedorActual = null;
            }
            return exito;
        }

        /// <summary>
        /// Inicia proceso de actualización y muestra mensaje de acuerdo si la operación ha sido exitosa o fallida
        /// </summary>
        private void actualizar()
        {
            if (true)
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
            glb_mod_articuloProveedorActual = this.cargarDatosEnModeloArticuloProveedor();
            exito = lcl_con_modificacion.modificar(glb_mod_articuloProveedorActual);
            if (exito)
            {
                glb_mod_articuloProveedorSeleccionado = glb_mod_articuloProveedorActual;
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
            glb_mod_articuloProveedorActual = this.cargarDatosEnModeloArticuloProveedor();
            glb_frm_resultadoBusqueda.mostrarBusqueda(glb_mod_articuloProveedorActual);
            if (glb_frm_resultadoBusqueda.glb_mod_articuloProveedor != null)
            {
                this.modoFormulario = ModoFormularioSeleccionado;

                glb_mod_articuloProveedorSeleccionado = glb_frm_resultadoBusqueda.glb_mod_articuloProveedor;
                this.cargarArticuloProveedorEnControles(glb_mod_articuloProveedorSeleccionado);
            }
        }
        #endregion

        private ModeloArticuloProveedores cargarDatosEnModeloArticuloProveedor()
        {
            ModeloArticuloProveedores lcl_mod_articuloProveedores = new ModeloArticuloProveedores();
            if (validarContenidoControladores())
            {
                lcl_mod_articuloProveedores.codigoOriginal = txtBoxCodigoOriginal.Text; ;
                lcl_mod_articuloProveedores.descripcion = txtBoxDescripcion.Text;
                if (LibreriaClasesCompartidas.Validar.validarValorNumerico(txtBoxCodigoProveedor.Text))
                {
                    lcl_mod_articuloProveedores.codigoEntidad = Convert.ToInt32(txtBoxCodigoProveedor.Text);
                }
                else
                {
                    lcl_mod_articuloProveedores.codigoEntidad = 0;
                }
                //lcl_mod_articuloProveedores.codigoEntidad = Convert.ToInt32(txtBoxCodigoProveedor.Text);
                lcl_mod_articuloProveedores.razonSocialProveedor = txtBoxRazonSocial.Text;
                lcl_mod_articuloProveedores.codigoArticuloProveedor = txtBoxCodigoArticulo.Text;
                lcl_mod_articuloProveedores.ubicacion = txtBoxUbicacion.Text;
                lcl_mod_articuloProveedores.stockActual = Convert.ToInt32(nmrcUpDownStockActual.Value);
                lcl_mod_articuloProveedores.stockMinimo = Convert.ToInt32(nmrcUpDownStockMinimo.Value);
                if (LibreriaClasesCompartidas.Validar.validarValorDecimal(txtBoxPrecioCompra.Text))
                {
                    lcl_mod_articuloProveedores.valorCompra.valorArticulo = Convert.ToDecimal(txtBoxPrecioCompra.Text);
                }
                else
                {
                    lcl_mod_articuloProveedores.valorCompra.valorArticulo = 0;
                }
                //lcl_mod_articuloProveedores.valorCompra.valorArticulo = Convert.ToDecimal(txtBoxPrecioCompra.Text);
                if (LibreriaClasesCompartidas.Validar.validarValorDecimal(txtBoxPrecioVenta.Text))
                {
                    lcl_mod_articuloProveedores.valorCompra.valorArticulo = Convert.ToDecimal(txtBoxPrecioVenta.Text);
                }
                else
                {
                    lcl_mod_articuloProveedores.valorCompra.valorArticulo = 0;
                }
                //lcl_mod_articuloProveedores.valorVenta.valorArticulo = Convert.ToDecimal(txtBoxPrecioVenta.Text);
            }
            return lcl_mod_articuloProveedores;
        }

        /// <summary>
        /// Valida que los controladores que se hayan completados tengan el formato correcto y además que los campos obligatorios hayas sido rellenados
        /// </summary>
        /// <returns>true si todos los controladores válidos, false caso contrario</returns>
        private bool validarContenidoControladores()
        {
            return true;
        }

        private void cargarArticuloProveedorEnControles(ModeloArticuloProveedores p_mod_articuloProveedor)
        {
            glb_mod_articuloProveedorSeleccionado = p_mod_articuloProveedor;

            txtBoxCodigoOriginal.Text = p_mod_articuloProveedor.codigoOriginal;
            txtBoxDescripcion.Text = p_mod_articuloProveedor.descripcion;
            txtBoxCodigoProveedor.Text = p_mod_articuloProveedor.codigoEntidad.ToString();
            txtBoxRazonSocial.Text = p_mod_articuloProveedor.razonSocialProveedor;
            txtBoxCodigoArticulo.Text = p_mod_articuloProveedor.codigoArticuloProveedor;
            txtBoxUbicacion.Text = p_mod_articuloProveedor.ubicacion;
            nmrcUpDownStockActual.Value = Convert.ToInt32(p_mod_articuloProveedor.stockActual);
            nmrcUpDownStockMinimo.Value = Convert.ToInt32(p_mod_articuloProveedor.stockMinimo);
            txtBoxPrecioCompra.Text = p_mod_articuloProveedor.valorCompra.valorArticulo.ToString();
            txtBoxPrecioVenta.Text = p_mod_articuloProveedor.valorVenta.valorArticulo.ToString();
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
            DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea eliminar el artículo proveedor seleccionado?", "Atención", MessageBoxButtons.YesNo);
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