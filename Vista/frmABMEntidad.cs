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
    public partial class frmABMEntidad : Vista.frmABMBase
    {
        #region Atributos
        //Seleccionado es el que resulta de un objeto que se encuentra en la base de datos
        //Actual puede ser un objeto nuevo o resultado de la base de datos con posibles modificaciones
        ModeloEntidad glb_mod_entidadActual;
        ModeloEntidad glb_mod_entidadSeleccionada;

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
                        glb_mod_entidadActual = glb_mod_entidadSeleccionada = new ModeloProveedor();
                        break;
                    case LibreriaClasesCompartidas.Constantes.TiposEntidad.TiposPersona.Cliente:
                        this.inicializarControlesTipoEntidadCliente();
                        glb_mod_entidadActual = glb_mod_entidadSeleccionada = new ModeloCliente();
                        break;
                    case LibreriaClasesCompartidas.Constantes.TiposEntidad.TiposPersona.Usuario:
                        this.inicializarControlesTipoEntidadUsuario();
                        glb_mod_entidadActual = glb_mod_entidadSeleccionada = new ModeloUsuario();
                        break;
                    case LibreriaClasesCompartidas.Constantes.TiposEntidad.TiposPersona.ContactoProveedor:
                        this.inicializarControlesTipoEntidadContactoProveedor();
                        glb_mod_entidadActual = glb_mod_entidadSeleccionada = new ModeloContactoProveedor();
                        break;
                    default:
                        break;
                }
            }
        }
        
        #endregion

        public frmABMEntidad()
        {
            InitializeComponent();
            this.Text = "Entidades";
            btnAgregarMail.Text = char.ConvertFromUtf32(8595);
            btnQuitarMail.Text = char.ConvertFromUtf32(8593);

            this.inicializarVariablesGlobales();

            modoFormulario = ModoFormularioInicio;

            this.inicializarComboBox();
        }

        #region Métodos

        #region Inicialización

        private void inicializarVariablesGlobales()
        {
            glb_mod_entidadActual = new ModeloEntidad(); ;
            glb_mod_entidadSeleccionada = new ModeloEntidad();
        }

        override public void inicializarModoFormularioInicio()
        {
            base.inicializarModoFormularioInicio();

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

            btnDatosAdicionales.Enabled = false;

            base.quitarTextoEnControles(this);
        }
        override public void inicializarModoFormularioNuevo()
        {
            base.inicializarModoFormularioNuevo();

            grpBoxTipoEntidad.Enabled = true;
            txtBoxCodigoEntidad.Enabled = false;

            grpBoxDomicilio.Enabled = true;
            grpBoxContacto.Enabled = true;
            grpBoxObservaciones.Enabled = true;

            btnDatosAdicionales.Enabled = true;

            base.quitarTextoEnControles(this);
        }
        override public void inicializarModoFormularioSeleccionado()
        {
            base.inicializarModoFormularioSeleccionado();

            grpBoxTipoEntidad.Enabled = false;
            txtBoxCodigoEntidad.Enabled = false;

            grpBoxDomicilio.Enabled = true;
            grpBoxContacto.Enabled = true;
            grpBoxObservaciones.Enabled = true;

            btnDatosAdicionales.Enabled = true;

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
            cargarDatosControlEnEntidadActual(ref glb_mod_entidadActual);
            glb_mod_entidadSeleccionada = glb_mod_entidadActual;
            return lcl_con_alta.agregar(ref glb_mod_entidadSeleccionada);
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
            return lcl_con_baja.eliminar(glb_mod_entidadSeleccionada);
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
            //utilizar modelo global actual y seleccionado para ver si se cambio algo
            return true;
        }

        /// <summary>
        /// Se comunica con controlador para realizar modificación
        /// </summary>
        /// <returns>true si se ha registrado modificación, false caso contrario</returns>
        private bool guardarModificaciones()
        {
            ControladorModificacion lcl_con_modificacion = new ControladorModificacion();
            this.cargarDatosControlEnEntidadActual(ref glb_mod_entidadSeleccionada);
            glb_mod_entidadActual = glb_mod_entidadSeleccionada;
            return lcl_con_modificacion.modificar(glb_mod_entidadSeleccionada);
        }
        #endregion

        #region Búsqueda

        /// <summary>
        /// Muestra cuadro de resultado de búsqueda de la clase buscada o mensaje de error en caso de que no se haya podido mostrar
        /// </summary>
        private void buscar()
        {
            if (this.validarBusqueda())
            {
                this.buscarEntidad();
            }
        }
        /// <summary>
        /// Valida parámetros de búsqueda. Muestra mensaje de error en caso de parámetro no válido
        /// </summary>
        /// <returns>true si todos los parámetros son válidos, false caso contrario</returns>
        private bool validarBusqueda()
        {
            if (this.getTipoEntidad() == null)
            {
                frmMensajeCorto lcl_frm_mensajeCorto = new frmMensajeCorto("Tipo Entidad", "Debe seleccionar un tipo de entidad para realizar la acción", "fallo");
                lcl_frm_mensajeCorto.ShowDialog();
                return false;
            }
            return true;
        }

        private void buscarEntidad()
        {
            glb_frm_resultadoBusqueda = new frmResultadoBusqueda();
            this.cargarDatosControlEnEntidadActual(ref glb_mod_entidadActual);
            glb_frm_resultadoBusqueda.mostrarBusqueda(glb_mod_entidadActual);
            if (glb_frm_resultadoBusqueda.modeloSeleccionado != null)
            {
                this.modoFormulario = ModoFormularioSeleccionado;
                this.quitarTextoEnControles(this);
                glb_mod_entidadSeleccionada = glb_mod_entidadActual = glb_frm_resultadoBusqueda.modeloSeleccionado as ModeloEntidad;
                this.cargarEntidadEnControles(glb_mod_entidadSeleccionada);
            }
        }

        #endregion

        #region Controles -> Modelo

        private void cargarDatosControlEnEntidadActual(ref ModeloEntidad p_mod_entidad)
        {
            this.cargarDatosControlEnEntidad(ref p_mod_entidad);
            if (p_mod_entidad.GetType() == typeof(ModeloProveedor))
            {
                ModeloProveedor lcl_mod_proveedor = p_mod_entidad as ModeloProveedor;
                this.cargarDatosControlEnProveedor(ref lcl_mod_proveedor);
                p_mod_entidad = new ModeloProveedor(lcl_mod_proveedor);
            }
            else
            {
                ModeloPersonas lcl_mod_persona = p_mod_entidad as ModeloPersonas;
                this.cargarDatosControlEnPersona(ref lcl_mod_persona);
                if (p_mod_entidad.GetType() == typeof(ModeloUsuario))
                {
                    p_mod_entidad = new ModeloUsuario(lcl_mod_persona);
                }
                if (p_mod_entidad.GetType() == typeof(ModeloCliente))
                {
                    p_mod_entidad = new ModeloCliente(lcl_mod_persona);
                }
                if (p_mod_entidad.GetType() == typeof(ModeloContactoProveedor))
                {
                    p_mod_entidad = new ModeloContactoProveedor(lcl_mod_persona);
                }
            }
        }
        
        private void cargarDatosControlEnEntidad(ref ModeloEntidad p_mod_entidad)
        {
            if (LibreriaClasesCompartidas.Validar.validarValorNumerico(txtBoxCodigoEntidad.Text))
            {
                p_mod_entidad.codigo = Convert.ToInt32(txtBoxCodigoEntidad.Text);
            }
            else
            {
                p_mod_entidad.codigo = 0;
            }

            p_mod_entidad.cuit = txtBoxCUIT.Text;
            p_mod_entidad.domicilios = this.cargarDatosControlEnDomicilio();
            p_mod_entidad.telefonos = this.cargarDatosControlEnTelefono();
            p_mod_entidad.mails = this.cargarDatosControlEnMail();
            p_mod_entidad.observaciones = rchTextBoxObservaciones.Text;
            
        }
        private void cargarDatosControlEnProveedor(ref ModeloProveedor p_mod_proveedor)
        {
            p_mod_proveedor.razonSocial = txtBoxRazonSocial.Text;
        }
        private void cargarDatosControlEnPersona(ref ModeloPersonas p_mod_persona)
        {
            p_mod_persona.dni = txtBoxDNI.Text;
            p_mod_persona.apellido = txtBoxApellido.Text;
            p_mod_persona.nombre = txtBoxNombre.Text;
        }

        private List<ModeloDomicilio> cargarDatosControlEnDomicilio()
        {
            List<ModeloDomicilio> lcl_lst_mod_domicilios = new List<ModeloDomicilio>();
            ModeloDomicilio lcl_mod_domicilio = new ModeloDomicilio();
            if (dataGridViewDomicilio.Rows.Count > 1)
            {
                foreach (DataGridViewRow row in dataGridViewDomicilio.Rows)
                {
                    //!= para no considerar fila vacía en datagridview
                    if (row.Cells["codigoDomicilio"].Value != null)
                    {
                        lcl_mod_domicilio = new ModeloDomicilio();

                        lcl_mod_domicilio.calle = row.Cells["calle"].Value.ToString();
                        lcl_mod_domicilio.numero = row.Cells["numero"].Value.ToString();
                        lcl_mod_domicilio.piso = row.Cells["piso"].Value.ToString();
                        lcl_mod_domicilio.departamento = row.Cells["departamento"].Value.ToString();
                        lcl_mod_domicilio.codigoPostal = row.Cells["codigoPostal"].Value.ToString();
                        lcl_mod_domicilio.ciudad = row.Cells["ciudad"].Value.ToString();
                        lcl_mod_domicilio.provincia.provincia = row.Cells["provincia"].Value.ToString();
                        lcl_mod_domicilio.pais.pais = row.Cells["pais"].Value.ToString();

                        if (LibreriaClasesCompartidas.Validar.validarValorNumerico(row.Cells["codigoDomicilio"].Value.ToString()))
                        {
                            lcl_mod_domicilio.codigoDomicilio = Convert.ToInt32(row.Cells["codigoDomicilio"].Value.ToString());
                        }
                        else
                        {
                            lcl_mod_domicilio.codigoDomicilio = 0;
                        }

                        lcl_mod_domicilio.provincia.codigo = row.Cells["codigoProvincia"].Value.ToString();
                        lcl_mod_domicilio.pais.codigo = row.Cells["codigoPais"].Value.ToString();

                        lcl_lst_mod_domicilios.Add(lcl_mod_domicilio);
                    }
                }
            }

            return lcl_lst_mod_domicilios;
        }
        private List<ModeloTelefono> cargarDatosControlEnTelefono()
        {
            List<ModeloTelefono> lcl_lst_mod_telefonos = new List<ModeloTelefono>();
            ModeloTelefono lcl_mod_telefono = new ModeloTelefono();
            foreach (DataGridViewRow row in this.dataGridViewTelefono.Rows)
            {
                //!= para no considerar fila vacía en datagridview
                if (row.Cells["codigoTelefono"].Value != null)
                {
                    lcl_mod_telefono = new ModeloTelefono();
                    if (LibreriaClasesCompartidas.Validar.validarValorNumerico(row.Cells["codigoTelefono"].Value.ToString()))
                    {
                        lcl_mod_telefono.codigoTelefono = Convert.ToInt32(row.Cells["codigoTelefono"].Value.ToString());
                    }
                    else
                    {
                        lcl_mod_telefono.codigoTelefono = 0;
                    }

                    lcl_mod_telefono.numero = row.Cells["numeroTelefono"].Value.ToString();
                    lcl_mod_telefono.tipo = row.Cells["codigoTipo"].Value.ToString();

                    lcl_lst_mod_telefonos.Add(lcl_mod_telefono);
                }
            }
            return lcl_lst_mod_telefonos;
        }
        private List<ModeloMail> cargarDatosControlEnMail()
        {
            List<ModeloMail> lcl_lst_mod_mails = new List<ModeloMail>();
            ModeloMail lcl_mod_mail = new ModeloMail();
            foreach (DataGridViewRow row in this.dataGridViewMail.Rows)
            {
                //!= para no considerar fila vacía en datagridview
                if (row.Cells["codigoMail"].Value != null)
                {
                    lcl_mod_mail = new ModeloMail();
                    lcl_mod_mail.codigoMail = Convert.ToInt32(row.Cells["codigoMail"].Value.ToString());
                    lcl_mod_mail.mail = row.Cells["mail"].Value.ToString();

                    lcl_lst_mod_mails.Add(lcl_mod_mail);
                }
            }
            return lcl_lst_mod_mails;
        }
        
        #endregion

        #region Modelo -> Controles

        private void cargarEntidadEnControles(ModeloEntidad p_mod_entidad)
        {
            this.cargarDatosEntidadEnControles(p_mod_entidad);
            if (p_mod_entidad.GetType() == typeof(ModeloProveedor))
            {
                this.cargarDatosProveedorEnControles(p_mod_entidad as ModeloProveedor);
            }
            else
            {
                this.cargarDatosPersonaEnControles(p_mod_entidad as ModeloPersonas);
            }
        }

        private void cargarDatosEntidadEnControles(ModeloEntidad p_mod_entidad)
        {
            txtBoxCodigoEntidad.Text = p_mod_entidad.codigo.ToString();
            txtBoxCUIT.Text = p_mod_entidad.cuit != null ? p_mod_entidad.cuit : "";

            this.cargarDatosDomicilioEnDataGridViewDomicilio(p_mod_entidad.domicilios);
            this.cargarDatosTelefonoEnDataGridViewTelefono(p_mod_entidad.telefonos);
            this.cargarDatosMailEnDataGridViewMail(p_mod_entidad.mails);

            rchTextBoxObservaciones.Text = p_mod_entidad.observaciones != null ? p_mod_entidad.observaciones : "";
        }
        private void cargarDatosProveedorEnControles(ModeloProveedor p_mod_proveedor)
        {
            txtBoxRazonSocial.Text = p_mod_proveedor.razonSocial != null ? p_mod_proveedor.razonSocial : "";
        }
        private void cargarDatosPersonaEnControles(ModeloPersonas p_mod_persona)
        {
            txtBoxDNI.Text = p_mod_persona.dni != null ? p_mod_persona.dni : "";
            txtBoxNombre.Text = p_mod_persona.nombre != null ? p_mod_persona.nombre : "";
            txtBoxApellido.Text = p_mod_persona.apellido != null ? p_mod_persona.apellido : "";
        }

        #region DataGridViews
        private void cargarDatosDomicilioEnDataGridViewDomicilio(List<ModeloDomicilio> p_lst_mod_domicilio)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridViewDomicilio.Rows[0].Clone();

            foreach (ModeloDomicilio mDomicilio in p_lst_mod_domicilio)
            {
                row = (DataGridViewRow)dataGridViewDomicilio.Rows[0].Clone();
                row.Cells[0].Value = mDomicilio.codigoDomicilio;
                row.Cells[1].Value = mDomicilio.calle != null ? mDomicilio.calle : "";
                row.Cells[2].Value = mDomicilio.numero != null ? mDomicilio.numero : "";
                row.Cells[3].Value = mDomicilio.piso != null ? mDomicilio.piso : "";
                row.Cells[4].Value = mDomicilio.departamento != null ? mDomicilio.departamento : "";
                row.Cells[5].Value = mDomicilio.codigoPostal != null ? mDomicilio.codigoPostal : "";
                row.Cells[6].Value = mDomicilio.ciudad != null ? mDomicilio.ciudad : "";
                row.Cells[7].Value = mDomicilio.provincia.codigo != null ? mDomicilio.provincia.codigo : "";
                row.Cells[8].Value = mDomicilio.provincia.provincia != null ? mDomicilio.provincia.provincia : "";
                row.Cells[9].Value = mDomicilio.pais.codigo != null ? mDomicilio.pais.codigo : "";
                row.Cells[10].Value = mDomicilio.pais.pais != null ? mDomicilio.pais.pais : "";

                dataGridViewDomicilio.Rows.Add(row);
            }
        }
        private void cargarDatosTelefonoEnDataGridViewTelefono(List<ModeloTelefono> p_lst_mod_telefono)
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
        private void cargarDatosMailEnDataGridViewMail(List<ModeloMail> p_lst_mod_mail)
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
        #endregion
        #region ComboBox
        private void cargarDatosProvinciasEnCmbBoxProvincia(List<ModeloProvincia> p_lst_mod_provincias)
        {
            this.cmbBoxProvincia.DataSource = p_lst_mod_provincias;
            this.cmbBoxProvincia.SelectedItem = null;
        }
        private void cargaDatosPaisesEnCmbBoxPais(List<ModeloPais> p_lst_mod_paises)
        {
            this.cmbBoxPais.DataSource = p_lst_mod_paises;
            this.cmbBoxPais.SelectedItem = null;
        }
        #endregion
        
        #endregion

        #region Validar Controles
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

        private bool validarTipoEntidadSeleccionado()
        {
            //si no hay ningún botón cliqueado, ver default null?
            return (this.getRadioButtonTipoEntidad() != null);
        }
        private bool validarEntidad(ModeloEntidad p_mod_entidad)
        {
            return true;
        }

        private bool validarPersona(ModeloPersonas p_mod_persona)
        {
            bool validez = false;
            if (this.validarEntidad(p_mod_persona) == true)
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
                frmMensajeCorto lcl_frm_mensajeCorto = new frmMensajeCorto("Faltan campos", "El campo mail esta vacío", "fallo");
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
                frmMensajeCorto lcl_frm_mensajeCorto = new frmMensajeCorto("Faltan campos", "El campo mail esta vacío", "fallo");
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

        private void btnDatosAdicionales_Click(object sender, EventArgs e)
        {

            if (glb_mod_entidadActual.GetType() == typeof(ModeloUsuario))
            {
                frmABMEntidadDatosAdicionalesUsuario lcl_frm_DatosAdicionalesUsuario = new frmABMEntidadDatosAdicionalesUsuario(glb_mod_entidadActual as ModeloUsuario);
                lcl_frm_DatosAdicionalesUsuario.ShowDialog();
            }
            else if (glb_mod_entidadActual.GetType() == typeof(ModeloContactoProveedor))
            {
                frmABMEntidadDatosAdicionalesContactoProveedor lcl_frm_DatosAdicionalesContactoProveedor;
                if (this.modoFormulario == ModoFormularioNuevo)
                {
                    lcl_frm_DatosAdicionalesContactoProveedor = new frmABMEntidadDatosAdicionalesContactoProveedor();
                }
                else
                {
                    lcl_frm_DatosAdicionalesContactoProveedor = new frmABMEntidadDatosAdicionalesContactoProveedor(glb_mod_entidadActual as ModeloContactoProveedor);
                }
                
                lcl_frm_DatosAdicionalesContactoProveedor.ShowDialog();
            }
            else 
            {
                MessageBox.Show("No hay datos adicionales para mostrar", "Datos Adicionales", MessageBoxButtons.OK);
            }
        }

        #endregion

        #region ToolStripMenuItem

        //override public void toolStripMenuItemCancelar_Click(object sender, EventArgs e)
        //{
            //DialogResult dialogResult = MessageBox.Show("¿Esta seguro que desea salir de esta ventana?", "Atención", MessageBoxButtons.YesNo);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    this.Close();
            //}
        //}

        override public void toolStripMenuItemLimpiarCampos_Click(object sender, EventArgs e)
        {
            tipoEntidadSeleccionada = null;
            this.inicializarVariablesGlobales();
            this.modoFormulario = ModoFormularioInicio;
            base.quitarTextoEnControles(this);
        }

        override public void toolStripMenuItemEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está seguro que desea eliminar el "+tipoEntidadSeleccionada+" seleccionado?", "Atención", MessageBoxButtons.YesNo);
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

            tipoEntidadSeleccionada = null;
        }

        override public void toolStripMenuItemBuscar_Click(object sender, EventArgs e)
        {
            this.buscar();
        }
        #endregion

        #region ComboBox
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
            this.cargarDatosProvinciasEnCmbBoxProvincia(provincias);
        }
        #endregion

        #endregion

        

    }
}
