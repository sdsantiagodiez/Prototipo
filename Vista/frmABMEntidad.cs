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
using LibreriaClasesCompartidas;


namespace Vista
{
    public partial class frmABMEntidad : Form
    {
        #region Atributos
        ModeloPersonas glb_mod_personaSeleccionada;
        ModeloProveedor glb_mod_proveedorSeleccionado;

        private string _tipoEntidadSeleccionada;
        private string tipoEntidadSeleccionada
        {
            get { return _tipoEntidadSeleccionada; }
            set 
            {
                _tipoEntidadSeleccionada = value;
                switch (_tipoEntidadSeleccionada)
                {
                    case LibreriaClasesCompartidas.Constantes.TiposEntidad.TiposProveedor.Proveedor:
                        this.inicializarControlesTipoEntidadProveedor();
                        break;
                    case LibreriaClasesCompartidas.Constantes.TiposEntidad.TiposPersona.Cliente:
                        this.inicializarControlesTipoEntidadCliente();
                        break;
                    case LibreriaClasesCompartidas.Constantes.TiposEntidad.TiposPersona.Usuario:
                        this.inicializarControlesTipoEntidadUsuario();
                        break;
                    case LibreriaClasesCompartidas.Constantes.TiposEntidad.TiposPersona.ContactoProveedor:
                        this.inicializarControlesTipoEntidadContactoProveedor();
                        break;
                    default:
                        break;
                }
            }
        }

        private const string ModoFormularioInicio = "Inicia formulario solo con opcion busqueda";
        private const string ModoFormularioNuevaEntidad = "Nueva Entidad";
        private const string ModoFormularioEntidadSeleccionada = "Entidad seleccionada de resultado de busqueda";

        /// <summary>
        /// Indica el modo. Debe inicializarse antes de realizar cualquier acción. 
        /// </summary>
        private string _modoFormulario;        
        private string modoFormulario
        {
            get { return _modoFormulario; }
            set 
            {
                _modoFormulario = value;
                switch (_modoFormulario)
                {
                    case ModoFormularioInicio:
                        this.inicializarModoFormularioInicio();
                        break;
                    case ModoFormularioNuevaEntidad:
                        this.inicializarModoFormularioNuevaEntidad();
                        break;
                    case ModoFormularioEntidadSeleccionada:
                        this.inicializarModoFormularioEntidadSeleccionada();
                        break;
                    default:
                        break;
                }
            }
        }
        
        private frmResultadoBusqueda glb_frm_resultadoBusqueda;
        
        #endregion

        public frmABMEntidad()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            btnAgregarMail.Text = char.ConvertFromUtf32(8595);
            btnQuitarMail.Text = char.ConvertFromUtf32(8593);

            this.inicializarModeloSeleccion();

            modoFormulario = ModoFormularioInicio;

            this.inicializarComboBox();
        }


        #region Inicializar

        private void inicializarModeloSeleccion()
        {
            glb_mod_personaSeleccionada = new ModeloPersonas();
            glb_mod_proveedorSeleccionado = new ModeloProveedor();
        }

        private void inicializarModoFormularioInicio()
        {
            toolStripMenuItemBuscar.Enabled = true;
            toolStripMenuItemNuevo.Enabled = true;
            toolStripMenuItemGuardar.Enabled = false;
            toolStripMenuItemGuardarCambios.Enabled = false;
            toolStripMenuItemGuardarNuevaEntidad.Enabled = false;
            toolStripMenuItemEliminar.Enabled = false;
            toolStripMenuItemLimpiarCampos.Enabled = true;
            toolStripMenuItemCancelar.Enabled = true;

            grpBoxTipoEntidad.Enabled = true;
            txtBoxCodigoEntidad.Enabled = true;
            
            txtBoxApellido.Enabled = true;
            txtBoxNombre.Enabled = true;
            txtBoxCUIT.Enabled = true;
            txtBoxDNI.Enabled = true;
            txtBoxRazonSocial.Enabled = true;

            grpBoxDomicilio.Enabled = false;
            grpBoxContacto.Enabled = false;
            grpBoxObservaciones.Enabled = false;

            this.quitarTextoEnControles(this);
        }
        private void inicializarModoFormularioNuevaEntidad()
        {
            toolStripMenuItemBuscar.Enabled = false;
            toolStripMenuItemNuevo.Enabled = false;
            toolStripMenuItemGuardar.Enabled = true;
            toolStripMenuItemGuardarCambios.Enabled = false;
            toolStripMenuItemGuardarNuevaEntidad.Enabled = true;
            toolStripMenuItemEliminar.Enabled = false;
            toolStripMenuItemLimpiarCampos.Enabled = true;
            toolStripMenuItemCancelar.Enabled = true;

            grpBoxTipoEntidad.Enabled = true;
            txtBoxCodigoEntidad.Enabled = false;

            grpBoxDomicilio.Enabled = true;
            grpBoxContacto.Enabled = true;
            grpBoxObservaciones.Enabled = true;

            this.quitarTextoEnControles(this);
        }
        private void inicializarModoFormularioEntidadSeleccionada()
        {
            toolStripMenuItemBuscar.Enabled = false;
            toolStripMenuItemNuevo.Enabled = false;
            toolStripMenuItemGuardar.Enabled = true;
            toolStripMenuItemGuardarCambios.Enabled = true;
            toolStripMenuItemGuardarNuevaEntidad.Enabled = false;
            toolStripMenuItemEliminar.Enabled = true;
            toolStripMenuItemLimpiarCampos.Enabled = true;
            toolStripMenuItemCancelar.Enabled = true;

            grpBoxTipoEntidad.Enabled = false;
            txtBoxCodigoEntidad.Enabled = false;

            grpBoxDomicilio.Enabled = true;
            grpBoxContacto.Enabled = true;
            grpBoxObservaciones.Enabled = true;

            this.quitarTextoEnControles(this);
        }

        private void inicializarControlesTipoEntidadCliente()
        {
            radioButtonCliente.Checked = true;

            this.inicializarControlesTipoEntidadPersona();
        }
        private void inicializarControlesTipoEntidadUsuario()
        {
            radioButtonUsuario.Checked = true;

            this.inicializarControlesTipoEntidadPersona();
        }
        private void inicializarControlesTipoEntidadContactoProveedor()
        {
            radioButtonContactoProveedor.Checked = true;

            this.inicializarControlesTipoEntidadPersona();
        }
        private void inicializarControlesTipoEntidadPersona()
        {
            txtBoxRazonSocial.Enabled = false;
            txtBoxDNI.Enabled = txtBoxNombre.Enabled = txtBoxApellido.Enabled = true;

            txtBoxRazonSocial.Text = null;
        }
        private void inicializarControlesTipoEntidadProveedor()
        {
            radioButtonProveedor.Checked = true;

            txtBoxRazonSocial.Enabled = true;
            txtBoxDNI.Enabled = txtBoxNombre.Enabled = txtBoxApellido.Enabled = false;

            txtBoxDNI.Text = txtBoxApellido.Text = txtBoxNombre.Text = null;
        }

        private void inicializarComboBox()
        {
            //Populo combobox de paises
            ControladorBusqueda lcl_con_busqueda = new ControladorBusqueda();
            List<ModeloPais> lcl_lst_mod_paises = lcl_con_busqueda.buscarPaises();
            this.cmbBoxPais.DataSource = lcl_lst_mod_paises;
            this.cmbBoxPais.DisplayMember = "pais";
            this.cmbBoxPais.ValueMember = "codigo";
            this.cmbBoxPais.SelectedItem = null;

            //Lo hago read only
            this.cmbBoxPais.DropDownStyle = ComboBoxStyle.DropDownList;

            //combobox de provincias

            this.cmbBoxProvincia.DisplayMember = "provincia";
            this.cmbBoxProvincia.ValueMember = "codigo";
            this.cmbBoxProvincia.SelectedItem = null;

            //Lo hago read only
            this.cmbBoxProvincia.DropDownStyle = ComboBoxStyle.DropDownList;

            //Creo lista Tipos de teléfono
            var dataSource = new List<Tel>();
            dataSource.Add(new Tel() { Name = "TEL", Value = "TEL" });
            dataSource.Add(new Tel() { Name = "CEL", Value = "CEL" });
            dataSource.Add(new Tel() { Name = "FAX", Value = "FAX" });

            //Binding de telefonos
            this.cmbBoxTipoTelefono.DataSource = dataSource;
            this.cmbBoxTipoTelefono.DisplayMember = "Name";
            this.cmbBoxTipoTelefono.ValueMember = "Value";

            //Lo hago read only
            this.cmbBoxTipoTelefono.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        
        #endregion

        #region Eventos

        #region RadioButton
        private void radioButtonCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonCliente.Checked == true)
            {
                this.tipoEntidadSeleccionada = LibreriaClasesCompartidas.Constantes.TiposEntidad.TiposPersona.Cliente;
            }

        }
        private void radioButtonUsuario_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonUsuario.Checked == true)
            {
                tipoEntidadSeleccionada = LibreriaClasesCompartidas.Constantes.TiposEntidad.TiposPersona.Usuario;
            }
            else
            {
                
            }

        }
        private void radioButtonProveedor_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonProveedor.Checked == true)
            {
                this.tipoEntidadSeleccionada = LibreriaClasesCompartidas.Constantes.TiposEntidad.TiposProveedor.Proveedor;
            }
        }
        private void radioButtonContactoProveedor_CheckedChanged(object sender, EventArgs e)
        {    
            if (this.radioButtonContactoProveedor.Checked == true)
            {
                this.tipoEntidadSeleccionada = LibreriaClasesCompartidas.Constantes.TiposEntidad.TiposPersona.ContactoProveedor;
            }
            else
            {

            }
        }
        #endregion

        #region Button
        private void btnAgregarMail_Click(object sender, EventArgs e)
        {
            ModeloMail lcl_mod_mail = new ModeloMail();
            lcl_mod_mail.mail = txtBoxMail.Text;
            //Agregar validación por si el mail ya esta incluido
            if (lcl_mod_mail.validarMail() && this.validarMail())
            {
                DataGridViewRow row = (DataGridViewRow)dataGridViewMail.Rows[0].Clone();
                row.Cells[0].Value = 0;
                row.Cells[1].Value = txtBoxMail.Text;
                dataGridViewMail.Rows.Add(row);
            }
            else if (!this.validarMail())
            {
                frmMensajeCorto lcl_frm_mensajeCorto = new frmMensajeCorto("Faltan campos", "El campo número de teléfono esta vacío", "fallo");
                lcl_frm_mensajeCorto.ShowDialog();
            }
            else
            {
                frmMensajeCorto lcl_frm_mensajeCorto = new frmMensajeCorto("Error", "El formato de mail ingresado no es válido", "fallo");
                lcl_frm_mensajeCorto.ShowDialog();   
            }
        }

        private void btnQuitarMail_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridViewMail.SelectedRows)
            {
                if (!item.IsNewRow)
                {
                    dataGridViewMail.Rows.RemoveAt(item.Index);
                }
            }
        }

        private void btnAgregarNumeroTelefono_Click(object sender, EventArgs e)
        {
            //Validar numero
            if (this.validarTelefono())
            {
                DataGridViewRow row = (DataGridViewRow)dataGridViewTelefono.Rows[0].Clone();
                //codigoTelefono
                row.Cells[0].Value = 0;
                //codigoTipo
                row.Cells[1].Value = cmbBoxTipoTelefono.Text;
                //tipo
                row.Cells[2].Value = cmbBoxTipoTelefono.SelectedValue.ToString();
                //numero
                row.Cells[3].Value = txtBoxTelefono.Text;

                dataGridViewTelefono.Rows.Add(row);
            }
            else
            {
                frmMensajeCorto lcl_frm_mensajeCorto = new frmMensajeCorto("Faltan campos", "El campo número de teléfono esta vacío", "fallo");
                lcl_frm_mensajeCorto.ShowDialog();
            }
        }

        private void btnQuitarNumeroTelefono_Click(object sender, EventArgs e)
        {
            
            foreach (DataGridViewRow item in this.dataGridViewTelefono.SelectedRows)
            {
                if (!item.IsNewRow)
                {
                    dataGridViewTelefono.Rows.RemoveAt(item.Index);
                }
            }
            
        }

        private void btnAgregarDomicilio_Click(object sender, EventArgs e)
        {
            //Validar datos
            DataGridViewRow row = (DataGridViewRow)dataGridViewDomicilio.Rows[0].Clone();
            //cell[0] codigoDomicilio
            if (this.validarDomicilio())
            {
                row.Cells[0].Value = 0;
                row.Cells[1].Value = txtBoxCalle.Text;
                row.Cells[2].Value = txtBoxNumeroDomicilio.Text;
                row.Cells[3].Value = txtBoxPiso.Text;
                row.Cells[4].Value = txtBoxDepartamento.Text;
                row.Cells[5].Value = txtBoxCodigoPostal.Text;
                row.Cells[6].Value = txtBoxCiudad.Text;
                row.Cells[7].Value = cmbBoxProvincia.SelectedValue.ToString();
                row.Cells[8].Value = cmbBoxProvincia.Text;
                row.Cells[9].Value = cmbBoxPais.SelectedValue.ToString();
                row.Cells[10].Value = cmbBoxPais.Text;

                dataGridViewDomicilio.Rows.Add(row);
            }
            else
            {
                frmMensajeCorto lcl_frm_mensajeCorto = new frmMensajeCorto("Faltan campos", "Debe seleccionar un país y provincia para el domicilio", "fallo");
                lcl_frm_mensajeCorto.ShowDialog();
                
            }
        }

        private void btnQuitarDomicilio_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridViewDomicilio.SelectedRows)
            {
                if (!item.IsNewRow)
                {
                    dataGridViewDomicilio.Rows.RemoveAt(item.Index);
                }
            }
        }

        
        #endregion

        #region toolStripMenuItem
        private void toolStripMenuItemBuscar_Click(object sender, EventArgs e)
        {
            string tipoEntidad = this.getTipoEntidad();
            if (tipoEntidad != null)
            {
                glb_frm_resultadoBusqueda = new frmResultadoBusqueda();
                switch (tipoEntidad)
                {
                    case LibreriaClasesCompartidas.Constantes.TiposEntidad.Persona:
                        ModeloPersonas lcl_mod_persona = this.cargarDatosEnModeloPersona();
                        glb_frm_resultadoBusqueda.mostrarBusqueda(lcl_mod_persona);
                        if (glb_frm_resultadoBusqueda.persona != null)
                        {
                            glb_mod_personaSeleccionada = glb_frm_resultadoBusqueda.persona;
                            this.cargarPersonaEnControles(glb_mod_personaSeleccionada);
                        }
                        break;
                    case LibreriaClasesCompartidas.Constantes.TiposEntidad.TiposProveedor.Proveedor:
                        ModeloProveedor lcl_mod_proveedor = this.cargarDatosEnModeloProveedor();
                        glb_frm_resultadoBusqueda.mostrarBusqueda(lcl_mod_proveedor);
                        if (glb_frm_resultadoBusqueda.proveedor != null)
                        {
                            glb_mod_proveedorSeleccionado = glb_frm_resultadoBusqueda.proveedor;
                            this.cargarProveedorEnControles(glb_mod_proveedorSeleccionado);
                        }
                        break;
                    default:
                        break;
                }
                
            }
            else
            {
                frmMensajeCorto lcl_frm_mensajeCorto = new frmMensajeCorto("Tipo Entidad", "Debe seleccionar un tipo de entidad para realizar la acción", "fallo");
                lcl_frm_mensajeCorto.ShowDialog();
            }

        }
        private void toolStripMenuItemNuevo_Click(object sender, EventArgs e)
        {
            tipoEntidadSeleccionada = null;
            modoFormulario = ModoFormularioNuevaEntidad;
        }
        
        private void toolStripMenuItemGuardarNuevaEntidad_Click(object sender, EventArgs e)
        {
            //Cambiar por un mensaje SI/NO
            DialogResult dialogResult = MessageBox.Show("¿Crear nueva entidad?", "Atención", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.guardarNuevaEntidad();
            }
            /* Por si se desea agregar algo en el futuro
            else if (dialogResult == DialogResult.No)
            {   
            }
            */
        }
        private void ToolStripMenuItemGuardarCambios_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Guardar los cambios realizados?", "Atención", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.guardarModificacionesEntidad();
            }
            /* Por si se desea agregar algo en el futuro en caso de que responda NO
            else if (dialogResult == DialogResult.No)
            {
            }
            */  
        }

        private void toolStripMenuItemLimpiarCampos_Click(object sender, EventArgs e)
        {
            tipoEntidadSeleccionada = null;
            this.inicializarModeloSeleccion();

            modoFormulario = ModoFormularioInicio;
            //this.quitarTextoEnControles(this);

            //txtBoxCodigoEntidad.Enabled = true;
            //toolStripMenuItemEliminar.Enabled = false;
            //toolStripMenuItemGuardarCambios.Enabled = false;
            //toolStripMenuItemGuardarNuevaEntidad.Enabled = true;
        }
        
        private void toolStripMenuItemEliminar_Click(object sender, EventArgs e)
        {
            //Cambiar por un mensaje SI/NO
            DialogResult dialogResult = MessageBox.Show("¿Esta seguro que desea elimnar esta entidad?", "Atención", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.eliminarEntidad();
            }
            /* Por si se desea agregar algo en el futuro
            else if (dialogResult == DialogResult.No)
            {
            }
            */    
        }

        private void toolStripMenuItemCancelar_Click(object sender, EventArgs e)
        {
            //Cambiar por un mensaje SI/NO
            DialogResult dialogResult = MessageBox.Show("¿Esta seguro que desea salir de esta ventana?", "Atención", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
            /* Por si se desea agregar algo en el futuro
            else if (dialogResult == DialogResult.No)
            {
                
            }
            */
        }
        #endregion

        //cmbBox
        private void cmbBoxPais_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ControladorBusqueda lcl_con_busqueda = new ControladorBusqueda();
            ModeloProvincia lcl_mod_provincia = new ModeloProvincia();
            //Inserto codigoPais del país seleccionado en el comboBox
            lcl_mod_provincia.codigoPais = this.cmbBoxPais.SelectedValue.ToString();
            //this.cmbBoxProvincia.DataSource = provincias;
            //REVISAR TEMPORAL HASTA QUE ESTE COMPLETO CONTROLADOrBUSQUEDA
            List<ModeloProvincia> lmProvincias = lcl_con_busqueda.buscarProvincias();
            List<ModeloProvincia> provincias = new List<ModeloProvincia>();
            foreach (ModeloProvincia p in lmProvincias)
            {
                if (p.codigoPais == lcl_mod_provincia.codigoPais)
                {
                    provincias.Add(p);
                }
            }
            this.cargarDatosEnCmbBoxProvincia(provincias);
        }

        #endregion

        #region validar
        ///// <summary>
        ///// 
        ///// </summary>
        ///// <param name="valorEnControl"></param>
        ///// <returns>Entero o 0 si no es posible convertir a valor numerico</returns>
        //private int getNumeroFromControl(string textoEnControl)
        //{
        //    int numero;
        //    Int32.TryParse(textoEnControl, out numero);
            
        //    return numero;
        //}

        //private string getStringFromControl(string textoEnControl)
        //{
        //    return textoEnControl.Trim();
        //}

        //private void setStringEnControl()

        private bool validarDomicilio()
        {
            return !(cmbBoxProvincia.SelectedValue == null || cmbBoxProvincia.SelectedValue == null);
        }

        private bool validarTelefono()
        {
            //False si el capo esta vacio. Completar
            return !(txtBoxTelefono.Text.Trim() == "") && cmbBoxTipoTelefono.SelectedValue != null;
        }

        private bool validarMail()
        {
            return !(txtBoxMail.Text.Trim() == "");
        }

        private bool validarTipoEntidadSeleccion()
        {
            //si no hay ningún botón cliqueado, ver default null?
            if (this.getRadioButtonTipoEntidad() == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool validarEntidad(ModeloEntidad p_mod_entidad)
        {
            return true;
        }
        
        private bool validarPersona(ModeloPersonas p_mod_persona)
        {
            bool validez = false;
            if(this.validarEntidad(p_mod_persona) == true)
            {
                switch (p_mod_persona.tipoPersona)
                {
                    case LibreriaClasesCompartidas.Constantes.TiposEntidad.TiposPersona.Cliente:
                        validez = this.validarCliente(p_mod_persona);
                        break;
                    case LibreriaClasesCompartidas.Constantes.TiposEntidad.TiposPersona.Usuario:
                        validez = this.validarUsuario(p_mod_persona);
                        break;
                    case LibreriaClasesCompartidas.Constantes.TiposEntidad.TiposPersona.ContactoProveedor:
                        validez = this.validarContactoProveedor(p_mod_persona);
                        break;
                    default:
                        validez = false;
                        break;
                }
            }
            return validez;
        }
        private bool validarCliente(ModeloPersonas p_mod_cliente)
        {
            return true;
        }
        private bool validarUsuario(ModeloPersonas p_mod_usuario)
        {
            return true;
        }
        private bool validarContactoProveedor(ModeloPersonas p_mod_contactoProveedor)
        {
            return true;
        }
        private bool validarProveedor(ModeloProveedor p_mod_proveedor)
        {
            bool validez = false;
            if (this.validarEntidad(p_mod_proveedor) == true)
            {
                //validar razon social y algo más?
            }
            return validez;
        }

        #endregion
        
        #region Pasar datos de controles a Modelos

        private ModeloEntidad cargarDatosEnModeloEntidad()
        {
            ModeloEntidad mEntidad = new ModeloEntidad();
            if (LibreriaClasesCompartidas.Validar.validarValorNumerico(txtBoxCodigoEntidad.Text))
            {
                mEntidad.codigo = Convert.ToInt32(txtBoxCodigoEntidad.Text);
            }
            else
            {
                mEntidad.codigo = 0;
            }

            mEntidad.cuit = txtBoxCUIT.Text;
            mEntidad.domicilios = this.cargarDatosEnModeloDomicilio();
            mEntidad.telefonos = this.cargarDatosEnModeloTelefono();
            mEntidad.mails = this.cargarDatosEnModeloMail();
            mEntidad.tipoEntidad = this.getTipoEntidad();
            mEntidad.observaciones = rchTextBoxObservaciones.Text;
            return mEntidad;
        }
        private ModeloPersonas cargarDatosEnModeloPersona()
        {
            ModeloPersonas mPersona = new ModeloPersonas();
            ModeloEntidad mEntidad = this.cargarDatosEnModeloEntidad();
            mPersona.codigo = mEntidad.codigo;
            mPersona.cuit = mEntidad.cuit;
            mPersona.domicilios = mEntidad.domicilios;
            mPersona.telefonos = mEntidad.telefonos;
            mPersona.mails = mEntidad.mails;
            mPersona.tipoEntidad = mEntidad.tipoEntidad;
            mPersona.observaciones = mEntidad.observaciones;

            mPersona.tipoPersona = this.tipoEntidadSeleccionada;
            mPersona.dni = txtBoxDNI.Text;
            mPersona.apellido = txtBoxApellido.Text;
            mPersona.nombre = txtBoxNombre.Text;
            if (this.tipoEntidadSeleccionada == LibreriaClasesCompartidas.Constantes.TiposEntidad.TiposPersona.Usuario)
            {
                //cargar Usuario y Contraseña de DatosADicionales
                mPersona.roles = this.cargarDatosEnModeloRol();
            }
            return mPersona;
        }
        private ModeloProveedor cargarDatosEnModeloProveedor()
        {
            ModeloProveedor mProveedor = new ModeloProveedor();
            ModeloEntidad mEntidad = this.cargarDatosEnModeloEntidad();
            mProveedor.codigo = mEntidad.codigo;
            mProveedor.cuit = mEntidad.cuit;
            mProveedor.domicilios = mEntidad.domicilios;
            mProveedor.telefonos = mEntidad.telefonos;
            mProveedor.mails = mEntidad.mails;
            mProveedor.tipoEntidad = mEntidad.tipoEntidad;
            mProveedor.observaciones = mEntidad.observaciones;

            mProveedor.razonSocial = txtBoxRazonSocial.Text;
            return mProveedor;
        }
        
        private List<ModeloDomicilio> cargarDatosEnModeloDomicilio()
        {
            List<ModeloDomicilio> lModeloDomicilio = new List<ModeloDomicilio>();
            ModeloDomicilio mDomicilio = new ModeloDomicilio();
            if (dataGridViewDomicilio.Rows.Count > 1)
            {
                foreach (DataGridViewRow row in dataGridViewDomicilio.Rows)
                {
                    //!= para no considerar fila vacía en datagridview
                    if (row.Cells["codigoDomicilio"].Value != null)
                    {
                        mDomicilio = new ModeloDomicilio();

                        mDomicilio.calle = row.Cells["calle"].Value.ToString();
                        mDomicilio.numero = row.Cells["numero"].Value.ToString();
                        mDomicilio.piso = row.Cells["piso"].Value.ToString();
                        mDomicilio.departamento = row.Cells["departamento"].Value.ToString();
                        mDomicilio.codigoPostal = row.Cells["codigoPostal"].Value.ToString();
                        mDomicilio.ciudad = row.Cells["ciudad"].Value.ToString();
                        mDomicilio.provincia.provincia = row.Cells["provincia"].Value.ToString();
                        mDomicilio.pais.pais = row.Cells["pais"].Value.ToString();

                        if (LibreriaClasesCompartidas.Validar.validarValorNumerico(row.Cells["codigoDomicilio"].Value.ToString()))
                        {
                            mDomicilio.codigoDomicilio = Convert.ToInt32(row.Cells["codigoDomicilio"].Value.ToString());
                        }
                        else
                        {
                            mDomicilio.codigoDomicilio = 0;
                        }

                        mDomicilio.provincia.codigo = row.Cells["codigoProvincia"].Value.ToString();
                        mDomicilio.pais.codigo = row.Cells["codigoPais"].Value.ToString();

                        lModeloDomicilio.Add(mDomicilio);
                    }
                }
            }

            return lModeloDomicilio;
        }
        private List<ModeloTelefono> cargarDatosEnModeloTelefono()
        {
            List<ModeloTelefono> lModeloTelefono = new List<ModeloTelefono>();
            ModeloTelefono mTelefono = new ModeloTelefono();
            foreach (DataGridViewRow row in this.dataGridViewTelefono.Rows)
            {
                //!= para no considerar fila vacía en datagridview
                if (row.Cells["codigoTelefono"].Value != null)
                {
                    mTelefono = new ModeloTelefono();
                    if (LibreriaClasesCompartidas.Validar.validarValorNumerico(row.Cells["codigoTelefono"].Value.ToString()))
                    {
                        mTelefono.codigoTelefono = Convert.ToInt32(row.Cells["codigoTelefono"].Value.ToString());
                    }
                    else
                    {
                        mTelefono.codigoTelefono = 0;
                    }

                    mTelefono.numero = row.Cells["numeroTelefono"].Value.ToString();
                    mTelefono.tipo = row.Cells["codigoTipo"].Value.ToString();

                    lModeloTelefono.Add(mTelefono);
                }
            }
            return lModeloTelefono;
        }
        private List<ModeloMail> cargarDatosEnModeloMail()
        {
            List<ModeloMail> lModeloMail = new List<ModeloMail>();
            ModeloMail mMail = new ModeloMail();
            foreach (DataGridViewRow row in this.dataGridViewMail.Rows)
            {
                //!= para no considerar fila vacía en datagridview
                if (row.Cells["codigoMail"].Value != null)
                {
                    mMail = new ModeloMail();
                    mMail.codigoMail = Convert.ToInt32(row.Cells["codigoMail"].Value.ToString());
                    mMail.mail = row.Cells["mail"].Value.ToString();

                    lModeloMail.Add(mMail);
                }
            }
            return lModeloMail;
        }
        
        private List<ModeloRoles> cargarDatosEnModeloRol()
        {
            List<ModeloRoles> lModeloRol = new List<ModeloRoles>();
            ModeloRoles mRol = new ModeloRoles();
            
            return lModeloRol;
        }
       
        #endregion

        #region Pasar datos de Modelo a controles

        private void cargarEntidadEnControles(ModeloPersonas p_mod_persona)
        {
            this.cargarPersonaEnControles(p_mod_persona);
        }
        private void cargarEntidadEnControles(ModeloProveedor pmProveedor)
        {
            this.cargarProveedorEnControles(pmProveedor);
        }
        private void cargarPersonaEnControles(ModeloPersonas p_mod_persona)
        {
            glb_mod_personaSeleccionada = p_mod_persona;
            tipoEntidadSeleccionada = glb_mod_personaSeleccionada.tipoPersona;

            this.cargarDatosEnDatosPersonales(glb_mod_personaSeleccionada);

            this.cargarDatosEnDataGridViewDomicilio(glb_mod_personaSeleccionada.domicilios);
            this.cargarDatosEnDataGridViewTelefono(glb_mod_personaSeleccionada.telefonos);
            this.cargarDatosEnDataGridViewMail(glb_mod_personaSeleccionada.mails);

            if (glb_mod_personaSeleccionada.tipoPersona == LibreriaClasesCompartidas.Constantes.TiposEntidad.TiposPersona.Usuario)
            {
                //carga de datos de usuario
            }
            if (glb_mod_personaSeleccionada.tipoPersona == LibreriaClasesCompartidas.Constantes.TiposEntidad.TiposPersona.ContactoProveedor)
            {
                //carga de proveedor al que pertenece
            }
            
        }
        private void cargarProveedorEnControles(ModeloProveedor p_mod_proveedor)
        {            
            glb_mod_proveedorSeleccionado = p_mod_proveedor;
            tipoEntidadSeleccionada = glb_mod_proveedorSeleccionado.tipoEntidad;

            this.cargarDatosEnDatosPersonales(glb_mod_proveedorSeleccionado);

            this.cargarDatosEnDataGridViewDomicilio(glb_mod_proveedorSeleccionado.domicilios);
            this.cargarDatosEnDataGridViewTelefono(glb_mod_proveedorSeleccionado.telefonos);
            this.cargarDatosEnDataGridViewMail(glb_mod_proveedorSeleccionado.mails);
        }

        private void cargarDatosEnDatosPersonales(ModeloPersonas p_mod_persona)
        {
            this.cargarDatosEnDatosPersonalesBase(p_mod_persona);

            txtBoxDNI.Text = p_mod_persona.dni != null ? p_mod_persona.dni : "";
            txtBoxNombre.Text = p_mod_persona.nombre != null ? p_mod_persona.nombre : "";
            txtBoxApellido.Text = p_mod_persona.apellido != null ? p_mod_persona.apellido : "";
        }
        private void cargarDatosEnDatosPersonales(ModeloProveedor p_mod_proveedor)
        {
            this.cargarDatosEnDatosPersonalesBase(p_mod_proveedor);

            txtBoxRazonSocial.Text = p_mod_proveedor.razonSocial != null ? p_mod_proveedor.razonSocial : "";
        }
        private void cargarDatosEnDatosPersonalesBase(ModeloEntidad p_mod_entidad)
        {
            txtBoxCodigoEntidad.Text = p_mod_entidad.codigo.ToString();
            txtBoxCUIT.Text = p_mod_entidad.cuit != null ? p_mod_entidad.cuit : "";
            rchTextBoxObservaciones.Text = p_mod_entidad.observaciones != null ? p_mod_entidad.observaciones : "";
        }
        
        private void cargarDatosEnDataGridViewDomicilio(List<ModeloDomicilio> p_lst_mod_domicilio)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridViewDomicilio.Rows[0].Clone();

            foreach (ModeloDomicilio mDomicilio in p_lst_mod_domicilio)
            {
                row = (DataGridViewRow)dataGridViewDomicilio.Rows[0].Clone();
                row.Cells[0].Value = mDomicilio.codigoDomicilio;
                row.Cells[1].Value = mDomicilio.calle != null? mDomicilio.calle: "";
                row.Cells[2].Value = mDomicilio.numero != null? mDomicilio.numero: "";
                row.Cells[3].Value = mDomicilio.piso != null? mDomicilio.piso: "";
                row.Cells[4].Value = mDomicilio.departamento != null? mDomicilio.departamento: "";
                row.Cells[5].Value = mDomicilio.codigoPostal != null? mDomicilio.codigoPostal: "";
                row.Cells[6].Value = mDomicilio.ciudad != null? mDomicilio.ciudad: "";
                row.Cells[7].Value = mDomicilio.provincia.codigo != null? mDomicilio.provincia.codigo: "";
                row.Cells[8].Value = mDomicilio.provincia.provincia != null? mDomicilio.provincia.provincia: "";
                row.Cells[9].Value = mDomicilio.pais.codigo != null? mDomicilio.pais.codigo: "";
                row.Cells[10].Value = mDomicilio.pais.pais != null ? mDomicilio.pais.pais : "";

                dataGridViewDomicilio.Rows.Add(row);
            }
        }
        private void cargarDatosEnDataGridViewTelefono(List<ModeloTelefono> p_lst_mod_telefono)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridViewTelefono.Rows[0].Clone();
            
            foreach (ModeloTelefono mTelefono in p_lst_mod_telefono)
            {
                row = (DataGridViewRow)dataGridViewTelefono.Rows[0].Clone();
                //codigoTelefono
                row.Cells[0].Value = mTelefono.codigoTelefono;
                //codigoTipo
                row.Cells[1].Value = mTelefono.tipo != null ? mTelefono.tipo : "";
                //tipo
                row.Cells[2].Value = mTelefono.tipo != null ? mTelefono.tipo : "";
                //numero
                row.Cells[3].Value = mTelefono.numero != null ? mTelefono.numero : "";

                dataGridViewTelefono.Rows.Add(row);
            }
        }
        private void cargarDatosEnDataGridViewMail(List<ModeloMail> p_lst_mod_mail)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridViewMail.Rows[0].Clone();
            foreach (ModeloMail mMail in p_lst_mod_mail)
            {
                row = (DataGridViewRow)dataGridViewMail.Rows[0].Clone();
                row.Cells[0].Value = mMail.codigoMail;
                row.Cells[1].Value = mMail.mail != null ? mMail.mail : "";
                
                dataGridViewMail.Rows.Add(row);
            }
        }

        private void cargarDatosEnCmbBoxProvincia(List<ModeloProvincia> p_lst_mod_provincias)
        {
            this.cmbBoxProvincia.DataSource = p_lst_mod_provincias;
            this.cmbBoxProvincia.SelectedItem = null;
        }
        private void cargaDatosEnCmbBoxPais(List<ModeloPais> p_lst_mod_paises)
        {
            this.cmbBoxPais.DataSource = p_lst_mod_paises;
            this.cmbBoxPais.SelectedItem = null;
        }

       #endregion

        #region Alta Baja y Modificación
        private bool guardarNuevaEntidad()
        {
            ControladorAlta lcl_con_alta = new ControladorAlta();
            
            string respuesta = "";
            bool exito = false;
            if (this.tipoEntidadSeleccionada != null)
            {
                switch (this.getTipoEntidad())
                {
                    case LibreriaClasesCompartidas.Constantes.TiposEntidad.Persona:
                        ModeloPersonas lcl_mod_persona = this.cargarDatosEnModeloPersona();
                        exito = lcl_con_alta.agregar(lcl_mod_persona);
                        break;
                    case LibreriaClasesCompartidas.Constantes.TiposEntidad.Proveedor:
                        ModeloProveedor lcl_mod_proveedor = this.cargarDatosEnModeloProveedor();
                        exito = lcl_con_alta.agregar(lcl_mod_proveedor);
                        break;
                    default:
                        break;
                }
                if (exito == true)
                {
                    respuesta = "La operación ha sido exitosa";
                }
                else
                {
                    respuesta = "La operación ha fallado.";
                }
            }
            else
            {
                respuesta = "Debe seleccionar un tipo de entidad para realizar la acción";
            }
            MessageBox.Show(respuesta);
            
            return exito;
        }

        private bool guardarModificacionesEntidad()
        {
            ControladorModificacion cModificacion = new ControladorModificacion();
            
            string respuesta = "";
            bool exito = false;
            if (tipoEntidadSeleccionada != null)
            {
                switch (this.getTipoEntidad())
                {
                    case LibreriaClasesCompartidas.Constantes.TiposEntidad.Persona:
                        ModeloPersonas mPersona = this.cargarDatosEnModeloPersona();
                        exito = cModificacion.modificarPersona(mPersona);
                        break;
                    case LibreriaClasesCompartidas.Constantes.TiposEntidad.Proveedor:
                        ModeloProveedor mProveedor = this.cargarDatosEnModeloProveedor();
                        exito = cModificacion.modificarProveedor(mProveedor);
                        break;
                    default:
                        break;
                }
                if (exito == true)
                {
                    respuesta = "La operación ha sido exitosa";
                }
                else
                {
                    respuesta = "La operación ha fallado.";
                }
            }
            else
            {
                respuesta = "Debe seleccionar un tipo de entidad para realizar la acción";
            }
            MessageBox.Show(respuesta);
            
            return exito;
        }

        private bool eliminarEntidad()
        {
            ControladorBaja cBaja = new ControladorBaja();

            string respuesta = "";
            bool exito = false;
            if (tipoEntidadSeleccionada != null)
            {
                switch (this.getTipoEntidad())
                {
                    case LibreriaClasesCompartidas.Constantes.TiposEntidad.Persona:
                        exito = cBaja.eliminarPersona(glb_mod_personaSeleccionada);
                        break;
                    case LibreriaClasesCompartidas.Constantes.TiposEntidad.Proveedor:
                        exito = cBaja.eliminarProveedor(glb_mod_proveedorSeleccionado);
                        break;
                    default:
                        break;
                }
                if (exito == true)
                {
                    respuesta = "La operación ha sido exitosa";
                }
                else
                {
                    respuesta = "La operación ha fallado.";
                }
            }
            else
            {
                respuesta = "Debe seleccionar un tipo de entidad para realizar la acción";
            }
            MessageBox.Show(respuesta);
            return exito;
        }
        #endregion

        private void quitarTextoEnControles(Control p_ctr_control)
        {
            //se utiliza para que si el control no esta en ninguno de los if's,
            //entonces se mete en un control que puede contener una colección de controles
            bool bandera;
            foreach (Control c in p_ctr_control.Controls)
            {
                bandera = true;
                if (c is TextBox)
                {
                    ((TextBox)c).Clear(); bandera = false;
                }

                if (c is ListView)
                {

                    ((ListView)c).Items.Clear(); bandera = false;
                }

                if (c is DataGridView)
                {
                    ((DataGridView)c).Rows.Clear(); bandera = false;
                }

                if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = -1; bandera = false;
                }

                if (c is RichTextBox)
                {
                    ((RichTextBox)c).Clear(); bandera = false;
                }

                if (c is RadioButton)
                {
                    ((RadioButton)c).Checked = false; bandera = false;
                }

                if (bandera)
                    quitarTextoEnControles(c);
            }
        }

        private RadioButton getRadioButtonTipoEntidad()
        {
            RadioButton checkedButton = pnlTipoEntidad.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            return checkedButton;
        }

        /// <summary>
        /// Retorna tipo entidad seleccionada 
        /// </summary>
        /// <returns>"PRO","PER" ; null si no esta seleccionada o no se reconoce</returns>
        private string getTipoEntidad()
        {
            string tipoEntidad = null;
            switch (this.tipoEntidadSeleccionada)
            {
                case LibreriaClasesCompartidas.Constantes.TiposEntidad.TiposPersona.Cliente:
                case LibreriaClasesCompartidas.Constantes.TiposEntidad.TiposPersona.ContactoProveedor:
                case LibreriaClasesCompartidas.Constantes.TiposEntidad.TiposPersona.Usuario:
                    tipoEntidad = LibreriaClasesCompartidas.Constantes.TiposEntidad.Persona;
                    break;
                case LibreriaClasesCompartidas.Constantes.TiposEntidad.TiposProveedor.Proveedor:
                    tipoEntidad = LibreriaClasesCompartidas.Constantes.TiposEntidad.TiposProveedor.Proveedor;
                    break;
                default:
                    break;
            }
            return tipoEntidad;
         
        }

        private void btnDatosAdicionales_Click(object sender, EventArgs e)
        {
            switch (this.tipoEntidadSeleccionada)
            {
                case LibreriaClasesCompartidas.Constantes.TiposEntidad.TiposPersona.ContactoProveedor:
                    frmABMEntidadDatosAdicionalesContactoProveedor frmDatosAdicionalesContactoProveedor = new frmABMEntidadDatosAdicionalesContactoProveedor();
                    frmDatosAdicionalesContactoProveedor.ShowDialog();
                    break;
                case LibreriaClasesCompartidas.Constantes.TiposEntidad.TiposPersona.Usuario:
                    frmABMEntidadDatosAdicionalesUsuario frmDatosAdicionalesUsuario = new frmABMEntidadDatosAdicionalesUsuario();
                    frmDatosAdicionalesUsuario.ShowDialog();
                    break;
                default:
                    MessageBox.Show("No hay datos adicionales para mostrar","Datos Adicionales",MessageBoxButtons.OK);
                    break;
            }
        }

    }
}
