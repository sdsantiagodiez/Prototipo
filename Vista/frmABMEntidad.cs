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
using LibreriaClasesCompartidas;

namespace Vista
{
    public partial class frmABMEntidad : Vista.frmABMBase
    {
        #region Atributos
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
                        this.inicializarErrorProvider(this.tblLayoutPanelDatosPersonales);
                        glb_mod_entidadActual = new ModeloProveedor();
                        break;
                    case LibreriaClasesCompartidas.Constantes.TiposEntidad.TiposPersona.Cliente:
                        this.inicializarControlesTipoEntidadCliente();
                        this.inicializarErrorProvider(this.tblLayoutPanelDatosPersonales);
                        glb_mod_entidadActual = new ModeloCliente();
                        break;
                    case LibreriaClasesCompartidas.Constantes.TiposEntidad.TiposPersona.Usuario:
                        this.inicializarControlesTipoEntidadUsuario();
                        this.inicializarErrorProvider(this.tblLayoutPanelDatosPersonales);
                        glb_mod_entidadActual = new ModeloUsuario();
                        break;
                    case LibreriaClasesCompartidas.Constantes.TiposEntidad.TiposPersona.ContactoProveedor:
                        this.inicializarControlesTipoEntidadContactoProveedor();
                        this.inicializarErrorProvider(this.tblLayoutPanelDatosPersonales);
                        glb_mod_entidadActual = new ModeloContactoProveedor();
                        break;
                    default:
                        _tipoEntidadSeleccionada = null;
                        break;
                }
            }
        }
        
        public ModeloEntidad glb_mod_entidadActual;

        ContextMenu cntxtMenuDataGridViews;
        #endregion
        
        #region Constructores
        public frmABMEntidad()
        {
            InitializeComponent(); 
            dataGridViewTelefono.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dataGridViewTelefono.EnableHeadersVisualStyles = false;
            dataGridViewMail.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dataGridViewMail.EnableHeadersVisualStyles = false;
            dataGridViewDomicilio.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dataGridViewDomicilio.EnableHeadersVisualStyles = false;
            
            this.inicializarControles();
            modoFormulario = ModoFormularioInicio;
        }
        public frmABMEntidad(ModeloEntidad p_mod_entidad, string p_modoFormulario):this()
        {
            modoFormulario = p_modoFormulario;
            Type T = p_mod_entidad.GetType();
            if (T == typeof(ModeloCliente))
            {
                this.inicializarControlesTipoEntidadCliente();
            }
            else if (T == typeof(ModeloUsuario))
            {
                this.inicializarControlesTipoEntidadUsuario();
            }
            else if (T == typeof(ModeloContactoProveedor))
            {
                this.inicializarControlesTipoEntidadContactoProveedor();
            }
            else if (T == typeof(ModeloProveedor))
            {
                this.inicializarControlesTipoEntidadProveedor();
            }
            this.tblLayoutPanelTipoEntidad.Enabled = false;
        }
        #endregion

        #region Métodos

        #region Inicialización

        public override void inicializarForm(int ventanaAncho, int ventanaAlto)
        {
            this.tblLayoutPanelPrincipal.Width = ventanaAncho - 20; //un margen derecho de 20 para que se vea scrollbar
            this.pnlBase.Width = ventanaAncho - 3;  //un márgen derecho de 3
            this.pnlBase.Height = ventanaAlto - 60; //un márgen arriba para que se vea título
            if (pnlBase.Height < 700)
            {
                this.tblLayoutPanelPrincipal.Height = 700;  //Mínimo
                
                this.pnlBase.AutoScroll = true;
                ScrollBar vScrollBar = new VScrollBar();
                vScrollBar.Dock = DockStyle.Right;
                vScrollBar.Scroll += (sender, e) => { pnlBase.VerticalScroll.Value = vScrollBar.Value; };
                pnlBase.Controls.Add(vScrollBar);
            }
            else
            {
                this.tblLayoutPanelPrincipal.Height = pnlBase.Height; ; // 60 pixeles para que se vea título de ventana principal
            }

            int x = Convert.ToInt16(Math.Round(Convert.ToDouble((Width - this.tblLayoutPanelPrincipal.Width) / 2) ));
            this.tblLayoutPanelPrincipal.Location = new Point(10, 0);
            this.pnlBase.Location = new Point(0,65);
        }
        
        public override void inicializarModoFormularioInicio()
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

            this.tipoEntidadSeleccionada = Constantes.TiposEntidad.TiposPersona.Cliente;
        }
        public override void inicializarModoFormularioNuevo()
        {
            base.inicializarModoFormularioNuevo();
            
            grpBoxTipoEntidad.Enabled = true;
            txtBoxCodigoEntidad.Enabled = false;

            grpBoxDomicilio.Enabled = true;
            grpBoxContacto.Enabled = true;
            grpBoxObservaciones.Enabled = true;

            btnDatosAdicionales.Enabled = true;
            string lcl_tipoEntidad = this.tipoEntidadSeleccionada;
            base.quitarTextoEnControles(this);
            this.tipoEntidadSeleccionada = lcl_tipoEntidad;
        }
        public override void inicializarModoFormularioSeleccionado()
        {
            base.inicializarModoFormularioSeleccionado();

            grpBoxTipoEntidad.Enabled = false;
            txtBoxCodigoEntidad.Enabled = false;

            grpBoxDomicilio.Enabled = true;
            grpBoxContacto.Enabled = true;
            grpBoxObservaciones.Enabled = true;

            btnDatosAdicionales.Enabled = true;
        }
        public override void inicializarModoFormularioBusqueda()
        {
            base.inicializarModoFormularioBusqueda();
        }
        public override void inicializarModoFormularioClientePedido()
        {
            base.inicializarModoFormularioClientePedido();
        }

        private void inicializarControles()
        {
            this.Text = "Entidades";
           
            this.inicializarTextBoxes();
            this.inicializarComboBox();
            this.inicializarContextMenu();
            this.inicializarBotones();
            this.inicializarDataGridViews();
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
            List<ModeloPais> lcl_lst_mod_paises = ControladorBusqueda.getPaises();
            this.cmbBoxPais.DataSource = lcl_lst_mod_paises.OrderBy(i => i.pais).ToList();
            this.cmbBoxPais.DropDownWidth = this.getDropDownWidth(this.cmbBoxPais);
            this.cmbBoxPais.DisplayMember = "pais";
            this.cmbBoxPais.ValueMember = "codigo";
            this.cmbBoxPais.SelectedItem = null;

            //combobox de provincias
            this.cmbBoxProvincia.DisplayMember = "provincia";
            this.cmbBoxProvincia.ValueMember = "codigo";
            this.cmbBoxProvincia.SelectedItem = null;

            //Creo lista Tipos de teléfono
            var dataSource = new List<ComboBoxItem>();
            dataSource.Add(new ComboBoxItem() { Name = "Fijo", Value = Constantes.TipoTelefono.Fijo });
            dataSource.Add(new ComboBoxItem() { Name = "Celular", Value = Constantes.TipoTelefono.Celular });
            dataSource.Add(new ComboBoxItem() { Name = "Fax", Value = Constantes.TipoTelefono.Fax });

            //Binding de telefonos
            this.cmbBoxTipoTelefono.DataSource = dataSource;
            this.cmbBoxTipoTelefono.DisplayMember = "Name";
            this.cmbBoxTipoTelefono.ValueMember = "Value";

            //Lo hago read only
            this.cmbBoxPais.DropDownStyle =
                this.cmbBoxProvincia.DropDownStyle = 
                this.cmbBoxTipoTelefono.DropDownStyle = ComboBoxStyle.DropDownList;
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
        private void inicializarBotones()
        {
            #region btnAgregar
            this.btnAgregarDomicilio.Click += (s, e) =>
                {
                    this.agregarDomicilioEntidad();
                };
            this.btnAgregarMail.Click += (s, e) =>
            {
                this.agregarMailEntidad();
            };
            this.btnAgregarTelefono.Click += (s, e) =>
            {
                this.agregarTelefonoEntidad();
            };
            #endregion

            #region btnQuitar
            this.btnQuitarDomicilio.Click += (s, e) =>
                {
                    this.quitarObjetoDataGridViewSeleccionado(this.dataGridViewDomicilio);
                };
            this.btnQuitarMail.Click += (s, e) =>
                {
                    this.quitarObjetoDataGridViewSeleccionado(this.dataGridViewMail);
                };
            this.btnQuitarTelefono.Click += (s, e) =>
                {
                    this.quitarObjetoDataGridViewSeleccionado(this.dataGridViewTelefono);
                };
            #endregion
        }
        private void inicializarDataGridViews()
        {
            this.dataGridViewDomicilio.MouseDown += this.dataGridView_MouseDown;
            this.dataGridViewMail.MouseDown += this.dataGridView_MouseDown;
            this.dataGridViewTelefono.MouseDown += this.dataGridView_MouseDown;
        }
        private void inicializarTextBoxes()
        {
            txtBoxCUIT.KeyPress += this.valorCUIT;
            //txtBoxCUIT.MaxLength = ModeloEntidad.CUIT.longitud;
            txtBoxDNI.KeyPress += this.valorDNI;
            //txtBoxDNI.MaxLength = 10;
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

        int getDropDownWidth(ComboBox p_comboBox)
        {
            int maxWidth = 0, temp = 0;
            foreach (var obj in p_comboBox.Items)
            {
                temp = TextRenderer.MeasureText(obj.ToString(), p_comboBox.Font).Width;
                if (temp > maxWidth)
                {
                    maxWidth = temp;
                }
            }
            return maxWidth;
        }
        #endregion

        #region ABM
        /// <summary>
        /// Inicia proceso de alta y muestra mensaje de acuerdo si la operación ha sido exitosa o fallida
        /// </summary>
        private void alta()
        {
            if (!this.validarEntidad(glb_mod_entidadActual))
            {
                MessageBox.Show(errorActual,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            ControladorAlta lcl_con_alta = new ControladorAlta();
            cargarDatosControlEnEntidadActual(ref glb_mod_entidadActual);
            if (lcl_con_alta.agregar(ref glb_mod_entidadActual))
            {
                MessageBox.Show("Alta exitosa", "Éxito", MessageBoxButtons.OK);
                if (this.modoFormulario != ModoFormularioClientePedido)
                {
                    this.inicializarModoFormularioSeleccionado();    
                }
                else
                {
                    MessageBox.Show("El Cliente creado se utilizará en el pedido actual.", "Nuevo Cliente", MessageBoxButtons.OK);
                    this.Hide();
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show(lcl_con_alta.errorActual, "Error", MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
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
            if(lcl_con_baja.eliminar(glb_mod_entidadActual))
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
            if (!this.validarEntidad(glb_mod_entidadActual))
            {
                MessageBox.Show(errorActual, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                return;
            }

            ControladorModificacion lcl_con_modificacion = new ControladorModificacion();
            this.cargarDatosControlEnEntidadActual(ref glb_mod_entidadActual);
            if(lcl_con_modificacion.modificar(glb_mod_entidadActual))
            {
                MessageBox.Show("Modificación exitosa", "Éxito", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show(lcl_con_modificacion.errorActual, "Error", MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
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
            if (this.tipoEntidadSeleccionada == null)
            {
                MessageBox.Show("Debe seleccionar un tipo de entidad para realizar la acción", "Error", MessageBoxButtons.OK); 
                return false;
            }
            return true;
        }

        private void buscarEntidad()
        {
            BackgroundWorker bw = new BackgroundWorker();
            frmLoading lcl_frm_loading = new frmLoading("Espere por favor. Realizando búsqueda.");
            frmResultadoBusqueda lcl_frm_resultadoBusqueda = new frmResultadoBusqueda();
            bw.DoWork += (s, e) =>
            {
                lcl_frm_resultadoBusqueda.mostrarBusqueda(glb_mod_entidadActual);    
            };
            bw.RunWorkerCompleted += (s, e) =>
            {
                lcl_frm_loading.Hide();
                if (lcl_frm_resultadoBusqueda.modeloSeleccionado != null)
                {
                    if (this.modoFormulario != ModoFormularioClientePedido)
                    {
                        this.modoFormulario = ModoFormularioSeleccionado;
                        this.quitarTextoEnControles(this);
                        glb_mod_entidadActual = lcl_frm_resultadoBusqueda.modeloSeleccionado as ModeloEntidad;
                        this.cargarEntidadEnControles(glb_mod_entidadActual);
                    }
                    else
                    {
                        glb_mod_entidadActual = lcl_frm_resultadoBusqueda.modeloSeleccionado as ModeloEntidad;
                        this.Hide();
                    }
                }
            };
            
            
            this.cargarDatosControlEnEntidadActual(ref glb_mod_entidadActual);

            bw.RunWorkerAsync();
            lcl_frm_loading.ShowDialog(); 
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
                p_mod_entidad = lcl_mod_persona;
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
            p_mod_entidad.domicilios = this.cargarDatosControlEnListDomicilio();
            p_mod_entidad.telefonos = this.cargarDatosControlEnListTelefono();
            p_mod_entidad.mails = this.cargarDatosControlEnListMail();
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

                lcl_lst_mod_domicilios.Add(lcl_mod_domicilio);
            }

            return lcl_lst_mod_domicilios;
        }
        /// <summary>
        /// Toma los datos de textBoxes y comboBoxes antes de agregar a DataGridView
        /// </summary>
        /// <returns></returns>
        private ModeloDomicilio cargarDatosControlEnDomicilio()
        {
            if (this.validarDomicilio())
            {
                ModeloDomicilio lcl_mod_domicilio = new ModeloDomicilio();

                lcl_mod_domicilio.calle = txtBoxCalle.Text;
                lcl_mod_domicilio.numero = txtBoxNumeroDomicilio.Text;
                lcl_mod_domicilio.piso = txtBoxPiso.Text;
                lcl_mod_domicilio.departamento = txtBoxDepartamento.Text;
                lcl_mod_domicilio.codigoPostal = txtBoxCodigoPostal.Text;
                lcl_mod_domicilio.ciudad = txtBoxCiudad.Text;
                lcl_mod_domicilio.provincia.codigo = cmbBoxProvincia.SelectedValue.ToString();
                lcl_mod_domicilio.provincia.provincia = cmbBoxProvincia.Text;
                lcl_mod_domicilio.pais.codigo = cmbBoxPais.SelectedValue.ToString();
                lcl_mod_domicilio.pais.pais = cmbBoxPais.Text;

                return lcl_mod_domicilio;
            }
            else
            {
                return null;
            }
            
        }
        private List<ModeloTelefono> cargarDatosControlEnListTelefono()
        {
            List<ModeloTelefono> lcl_lst_mod_telefonos = new List<ModeloTelefono>();
            ModeloTelefono lcl_mod_telefono;
            foreach (DataGridViewRow row in this.dataGridViewTelefono.Rows)
            {
                lcl_mod_telefono = new ModeloTelefono();

                int codigoTelefono;
                Int32.TryParse(row.Cells["codigoTelefono"].Value.ToString(), out codigoTelefono);
                lcl_mod_telefono.codigoTelefono = codigoTelefono;

                lcl_mod_telefono.numero = row.Cells["numeroTelefono"].Value.ToString();
                lcl_mod_telefono.tipo = row.Cells["codigoTipo"].Value.ToString();

                lcl_lst_mod_telefonos.Add(lcl_mod_telefono);
            }
            return lcl_lst_mod_telefonos;
        }
        private ModeloTelefono cargarDatosControlEnTelefono()
        {
            if (this.validarTelefono())
            {
                ModeloTelefono lcl_mod_telefono = new ModeloTelefono();
                lcl_mod_telefono.numero = txtBoxTelefono.Text;
                lcl_mod_telefono.tipo = cmbBoxTipoTelefono.SelectedValue.ToString();
                return lcl_mod_telefono;
            }
            else
            {
                return null;
            }
        }
        private List<ModeloMail> cargarDatosControlEnListMail()
        {
            List<ModeloMail> lcl_lst_mod_mails = new List<ModeloMail>();
            ModeloMail lcl_mod_mail;
            foreach (DataGridViewRow row in this.dataGridViewMail.Rows)
            {
                lcl_mod_mail = new ModeloMail();

                int codigoMail;
                Int32.TryParse(row.Cells["codigoMail"].Value.ToString(), out codigoMail);
                lcl_mod_mail.codigoMail = codigoMail;
                
                lcl_mod_mail.mail = row.Cells["mail"].Value.ToString();

                lcl_lst_mod_mails.Add(lcl_mod_mail);
            }
            return lcl_lst_mod_mails;
        }
        private ModeloMail cargarDatosControlEnMail()
        {
            if (this.validarMail())
            {
                ModeloMail lcl_mod_mail = new ModeloMail();
                lcl_mod_mail.mail = txtBoxMail.Text;
                return lcl_mod_mail;
            }
            else
            {
                return null;
            }
        }

        private ModeloEntidad getDatosAdicionales(ModeloUsuario p_mod_usuario)
        {
            Form lcl_frm_datosAdicionales;
            if (p_mod_usuario.usuario == null)
            {
                lcl_frm_datosAdicionales = new frmABMEntidadDatosAdicionalesUsuario();
            }
            else
            {
                lcl_frm_datosAdicionales = new frmABMEntidadDatosAdicionalesUsuario(p_mod_usuario as ModeloUsuario);
            }
            lcl_frm_datosAdicionales.ShowDialog();
            return (lcl_frm_datosAdicionales as frmABMEntidadDatosAdicionalesUsuario).usuario;
        }

        private ModeloEntidad getDatosAdicionales(ModeloContactoProveedor p_mod_contactoProveedor)
        {
            Form lcl_frm_datosAdicionales;
            if (p_mod_contactoProveedor.proveedor == null)
            {
                lcl_frm_datosAdicionales = new frmABMEntidadDatosAdicionalesContactoProveedor();
            }
            else
            {
                lcl_frm_datosAdicionales = new frmABMEntidadDatosAdicionalesContactoProveedor(p_mod_contactoProveedor as ModeloContactoProveedor);
            }

            lcl_frm_datosAdicionales.ShowDialog();
            return (lcl_frm_datosAdicionales as frmABMEntidadDatosAdicionalesContactoProveedor).contactoProveedor;
        }
        /// <summary>
        /// ERROR a corregir: lcl_mod_contactoProveedor.proveedor no se asigna, queda en null y la busqueda retorna resultados cuando el proveedor es nuevo
        /// </summary>
        /// <param name="p_mod_proveedor"></param>
        /// <returns></returns>
        private ModeloEntidad getDatosAdicionales(ModeloProveedor p_mod_proveedor)
        {
            ModeloContactoProveedor lcl_mod_contactoProveedor = new ModeloContactoProveedor();
            lcl_mod_contactoProveedor.proveedor = p_mod_proveedor;
            frmResultadoBusqueda lcl_frm = new frmResultadoBusqueda(lcl_mod_contactoProveedor, "Contactos de Proveedor de proveedor: " + p_mod_proveedor.razonSocial);
            lcl_frm.mostrarBusqueda();
            if (lcl_frm.modeloSeleccionado != null)
            {
                this.quitarTextoEnControles(this);
                this.tipoEntidadSeleccionada = LibreriaClasesCompartidas.Constantes.TiposEntidad.TiposPersona.ContactoProveedor;
                this.cargarEntidadEnControles(lcl_frm.modeloSeleccionado as ModeloContactoProveedor);
                return lcl_frm.modeloSeleccionado as ModeloContactoProveedor;
            }
            return null;
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
        /// Agrega una lista de objetos telefono al dataGrid
        /// </summary>
        /// <param name="p_lst_mod_telefono"></param>
        private void cargarDatosTelefonoEnDataGridViewTelefono(List<ModeloTelefono> p_lst_mod_telefono)
        {
            int rowIndex;
            DataGridViewRow row;

            foreach (ModeloTelefono mTelefono in p_lst_mod_telefono)
            {
                rowIndex = this.dataGridViewTelefono.Rows.Add();
                row = this.dataGridViewTelefono.Rows[rowIndex];

                row.Cells["codigoTelefono"].Value = mTelefono.codigoTelefono;
                row.Cells["codigoTipo"].Value = mTelefono.tipo != null ? mTelefono.tipo : "";
                row.Cells["tipo"].Value = mTelefono.tipo != null ? mTelefono.tipo : "";
                row.Cells["numeroTelefono"].Value = mTelefono.numero != null ? mTelefono.numero : "";
            }
        }
        /// <summary>
        /// Agrega un objeto telefono al dataGrid
        /// </summary>
        /// <param name="p_mod_telefono"></param>
        private void cargarDatosTelefonoEnDataGridViewTelefono(ModeloTelefono p_mod_telefono)
        {
            List<ModeloTelefono> lcl_lst_mod_telefono = new List<ModeloTelefono>();
            lcl_lst_mod_telefono.Add(p_mod_telefono);
            this.cargarDatosTelefonoEnDataGridViewTelefono(lcl_lst_mod_telefono);
        }
        /// <summary>
        /// Agrega una lista de objetos mail al dataGrid
        /// </summary>
        /// <param name="p_lst_mod_mail"></param>
        private void cargarDatosMailEnDataGridViewMail(List<ModeloMail> p_lst_mod_mail)
        {
            int rowIndex;
            DataGridViewRow row;
            foreach (ModeloMail mMail in p_lst_mod_mail)
            {
                rowIndex = this.dataGridViewMail.Rows.Add();
                row = this.dataGridViewMail.Rows[rowIndex];

                row.Cells["codigoMail"].Value = mMail.codigoMail;
                row.Cells["mail"].Value = mMail.mail != null ? mMail.mail : "";
            }
        }
        /// <summary>
        /// Agrega un objeto mail al dataGrid
        /// </summary>
        /// <param name="p_mod_mail"></param>
        private void cargarDatosMailEnDataGridViewMail(ModeloMail p_mod_mail)
        {
            List<ModeloMail> lcl_lst_mod_mail = new List<ModeloMail>();
            lcl_lst_mod_mail.Add(p_mod_mail);
            this.cargarDatosMailEnDataGridViewMail(lcl_lst_mod_mail);
        }
        #endregion
        
        #region ComboBox
        private void cargarDatosProvinciasEnCmbBoxProvincia(List<ModeloProvincia> p_lst_mod_provincias)
        {
            this.cmbBoxProvincia.DataSource = p_lst_mod_provincias.OrderBy(i => i.provincia).ToList();
            this.cmbBoxProvincia.DropDownWidth = this.getDropDownWidth(this.cmbBoxProvincia);
            this.cmbBoxProvincia.SelectedItem = null;
        }
        private void cargaDatosPaisesEnCmbBoxPais(List<ModeloPais> p_lst_mod_paises)
        {
            this.cmbBoxPais.DataSource = p_lst_mod_paises;
            this.cmbBoxPais.SelectedItem = null;
        }
        #endregion
        
        #endregion

        #region Validación
        private bool validarDomicilio()
        {
            if (cmbBoxPais.SelectedValue == null)
            {
                errorActual = "Debe seleccionar un País.";
                return false;
            }
            else if (cmbBoxProvincia.SelectedValue == null)
            {
                errorActual = "Debe seleccionar una Provincia.";
                return false;
            }
            else if (!ModeloDomicilio.validarCalle(txtBoxCalle.Text))
            {
                errorActual = "Por favor, revise el campo calle.";
                return false;
            }

            return true;
        }
        private bool validarDomicilioExiste()
        {
            List<ModeloDomicilio> lcl_lst_mod_domiciliosActuales = this.cargarDatosControlEnListDomicilio();
            ModeloDomicilio lcl_mod_domicilioActual = this.cargarDatosControlEnDomicilio();
            if (lcl_mod_domicilioActual != null)
            {
                foreach (ModeloDomicilio d in lcl_lst_mod_domiciliosActuales)
                {
                    //se igualan los codigos en caso que el objeto de la lista tenga codigo (traido de base de datos), 
                    //y de true usando Equals en caso de que el resto de las variables sean iguales
                    lcl_mod_domicilioActual.codigoDomicilio = d.codigoDomicilio;
                    if (lcl_mod_domicilioActual.Equals(d))
                    {
                        errorActual = "El domicilio ya está ingresado.";
                        return false;
                    }
                }
            }
            return true;
        }
        private bool validarTelefono()
        {
            //False si el capo esta vacio. Completar
            if(!ModeloTelefono.validarNumero(txtBoxTelefono.Text))
            {
                errorActual = "El número de teléfono ingresado no es válido";
                return false;
            } else if(cmbBoxTipoTelefono.SelectedValue == null)
            {
                errorActual = "Debe seleccionar un tipo de teléfono para el número indicado";
                return false;
            }
            return true;
        }
        private bool validarTelefonoExiste()
        {
            List<ModeloTelefono> lcl_lst_mod_telefonosActuales = this.cargarDatosControlEnListTelefono();
            ModeloTelefono lcl_mod_telefonoActual = this.cargarDatosControlEnTelefono();
            if (lcl_mod_telefonoActual != null)
            {
                foreach (ModeloTelefono t in lcl_lst_mod_telefonosActuales)
                {
                    //se igualan los codigos en caso que el objeto de la lista tenga codigo (traido de base de datos), 
                    //y de true usando Equals en caso de que el resto de las variables sean iguales
                    lcl_mod_telefonoActual.codigoTelefono = t.codigoTelefono;
                    if (lcl_mod_telefonoActual.Equals(t))
                    {
                        errorActual = "El teléfono ya está ingresado.";
                        return false;
                    }
                }
            }
            return true;
        }
        private bool validarMail()
        {
            if (!ModeloMail.validarMail(txtBoxMail.Text))
            {
                errorActual = "La dirección de correo electrónico ingresada no es válida.";
                return false;
            }
            return true;
        }
        private bool validarMailExiste()
        {
            List<ModeloMail> lcl_lst_mod_mailsActuales = this.cargarDatosControlEnListMail();
            ModeloMail lcl_mod_mailActual = this.cargarDatosControlEnMail();
            if (lcl_mod_mailActual != null)
            {
                foreach (ModeloMail m in lcl_lst_mod_mailsActuales)
                {
                    //se igualan los codigos en caso que el objeto de la lista tenga codigo (traido de base de datos), 
                    //y de true usando Equals en caso de que el resto de las variables sean iguales
                    lcl_mod_mailActual.codigoMail = m.codigoMail;
                    if (lcl_mod_mailActual.Equals(m))
                    {
                        errorActual = "La dirección de correo electrónico ya está ingresada.";
                        return false;
                    }
                }
            }
            return true;
        }

        private bool validarCUIT()
        {
            if (!string.IsNullOrWhiteSpace(txtBoxCUIT.Text) && !ModeloEntidad.CUIT.ValidarCuit(txtBoxCUIT.Text))
            {
                errorProviderActual.SetError(txtBoxCUIT, "CUIT no válido.");
                return false;
            }
            errorProviderActual.SetError(txtBoxCUIT, "");
            return true;
        }
        private bool validarNombre()
        {
            if (!ModeloPersonas.validarNombre(txtBoxNombre.Text))
            {
                errorProviderActual.SetError(txtBoxNombre, "Este campo es obligatorio. No puede permanecer vacío.");
                return false;
            }
            errorProviderActual.SetError(txtBoxNombre,"");
            return true;
        }
        private bool validarApellido()
        {
            if (!ModeloPersonas.validarApellido(txtBoxApellido.Text))
            {
                errorProviderActual.SetError(txtBoxApellido, "Este campo es obligatorio. No puede permanecer vacío.");
                return false;
            }
            errorProviderActual.SetError(txtBoxApellido,"");
            return true;
        }
        private bool validarDNI()
        {
            if (!ModeloPersonas.validarDNI(txtBoxDNI.Text))
            {
                errorProviderActual.SetError(txtBoxDNI, "Este campo es obligatorio. No puede permanecer vacío o contener caracteres no numéricos.");
                return false;
            }
            errorProviderActual.SetError(txtBoxDNI,"");
            return true;
        }
        private bool validarEntidad(ModeloEntidad p_mod_entidad)
        {
            bool validez = true;
            if (!this.validarCUIT())
            {
                validez = false;
                errorActual = "Ha surgido un error. Por favor, revise los valores ingresados.";
            }

            if (p_mod_entidad.GetType() == typeof(ModeloProveedor))
            {
                return this.validarProveedor(p_mod_entidad as ModeloProveedor) && validez;
            }

            return this.validarPersona(p_mod_entidad as ModeloPersonas) && validez;
        }

        private bool validarPersona(ModeloPersonas p_mod_persona)
        {
            //Se hace por separado para que se etiqueten todos los errores del tipo errorProvider en el formulario
            bool validez = true;
            if (!this.validarNombre())
                validez = false;
            if (!this.validarApellido())
                validez = false;
            if (!this.validarDNI())
                validez = false;
            
            if (validez)
            {
                switch (p_mod_persona.tipoPersona)
                {
                    case LibreriaClasesCompartidas.Constantes.TiposEntidad.TiposPersona.Cliente:
                        return this.validarCliente(p_mod_persona);
                    case LibreriaClasesCompartidas.Constantes.TiposEntidad.TiposPersona.Usuario:
                        return this.validarUsuario(p_mod_persona);
                    case LibreriaClasesCompartidas.Constantes.TiposEntidad.TiposPersona.ContactoProveedor:
                        return this.validarContactoProveedor(p_mod_persona);
                    default:
                        return false;
                }
            }
            errorActual = "Ha surgido un error. Por favor, revise los valores ingresados.";
            return false;
        }
        private bool validarCliente(ModeloPersonas p_mod_cliente)
        {
            return true;
        }
        private bool validarUsuario(ModeloPersonas p_mod_usuario)
        {
            if ((p_mod_usuario as ModeloUsuario).usuario == null)
            {
                errorActual = "Seleccione 'Datos Adicionales' para asignar un nombre de usuario y contraseña para el Usuario actual.";
                return false;
            }
            return true;
        }
        private bool validarContactoProveedor(ModeloPersonas p_mod_contactoProveedor)
        {
            if ((p_mod_contactoProveedor as ModeloContactoProveedor).proveedor == null)
            {
                errorActual = "Seleccione 'Datos Adicionales' para asignar un Proveedor al Contacto de Proveedor actual.";
                return false;
            }
            return true;
        }

        private bool validarRazonSocial()
        {
            if (!ModeloProveedor.validarRazonSocial(txtBoxRazonSocial.Text))
            {
                errorProviderActual.SetError(txtBoxRazonSocial, "Este campo es obligatorio. No puede permanecer vacío.");
                return false;
            }
            errorProviderActual.SetError(txtBoxRazonSocial, "");
            return true;
        }
        private bool validarProveedor(ModeloProveedor p_mod_proveedor)
        {
            if (!this.validarRazonSocial())
            {
                errorActual = "Ha surgido un error. Por favor, revise los valores ingresados.";
                return false;
            }
            return true;
        }

        #endregion

        private void agregarDomicilioEntidad()
        {
            ModeloDomicilio lcl_mod_domicilioActual = this.cargarDatosControlEnDomicilio();
            if (this.validarDomicilioExiste() && lcl_mod_domicilioActual != null)
            {
                this.cargarDatosDomicilioEnDataGridViewDomicilio(lcl_mod_domicilioActual);

                this.quitarTextoEnControles(tblLayoutPanelDomicilio);
            }
            else
            {
                MessageBox.Show(errorActual, "Error", MessageBoxButtons.OK);
            }
        }
        private void agregarMailEntidad()
        {
            ModeloMail lcl_mod_mailActual = this.cargarDatosControlEnMail();
            if (this.validarMailExiste() && lcl_mod_mailActual != null)
            {
                this.cargarDatosMailEnDataGridViewMail(lcl_mod_mailActual);

                this.quitarTextoEnControles(tblLayoutPanelMail);
            }
            else
            {
                MessageBox.Show(this.errorActual, "Error", MessageBoxButtons.OK);
            }
        }
        private void agregarTelefonoEntidad()
        {
            ModeloTelefono lcl_mod_telefonoActual = this.cargarDatosControlEnTelefono();
            if (this.validarTelefonoExiste() && lcl_mod_telefonoActual != null)
            {
                this.cargarDatosTelefonoEnDataGridViewTelefono(lcl_mod_telefonoActual);

                this.quitarTextoEnControles(tblLayoutPanelTelefono);
            }
            else
            {
                MessageBox.Show(this.errorActual, "Error", MessageBoxButtons.OK);
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

        private void btnDatosAdicionales_Click(object sender, EventArgs e)
        {
            ModeloEntidad lcl_mod_entidad = null;
            //Se podría cambiar a un switch (glb_mod_entidadActual as ModeloPersona).tipoPersona
            if (glb_mod_entidadActual.GetType() == typeof(ModeloUsuario))
            {
                lcl_mod_entidad = this.getDatosAdicionales(glb_mod_entidadActual as ModeloUsuario);
            }
            else if (glb_mod_entidadActual.GetType() == typeof(ModeloContactoProveedor))
            {
                lcl_mod_entidad = this.getDatosAdicionales(glb_mod_entidadActual as ModeloContactoProveedor);
            }
            else if (glb_mod_entidadActual.GetType() == typeof(ModeloProveedor))
            {
                lcl_mod_entidad = this.getDatosAdicionales(glb_mod_entidadActual as ModeloProveedor);
            }
            else 
            {
                MessageBox.Show("No hay datos adicionales para mostrar", "Datos Adicionales", MessageBoxButtons.OK);
            }
            if (lcl_mod_entidad != null)
            {
                glb_mod_entidadActual = lcl_mod_entidad;
            }
        }

        #endregion

        #region ToolStripMenuItem

        override public void toolStripMenuItemLimpiarCampos_Click(object sender, EventArgs e)
        {
            base.quitarTextoEnControles(this);
            this.modoFormulario = ModoFormularioInicio;
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
            if (modoFormulario == ModoFormularioClientePedido)
            {
                modoFormulario = ModoFormularioNuevo;
                modoFormulario = ModoFormularioClientePedido;
            }
            else
            {
                modoFormulario = ModoFormularioNuevo;
            }
        }

        override public void toolStripMenuItemBuscar_Click(object sender, EventArgs e)
        {
            this.buscar();
        }

        private void frmABMEntidad_Move(object sender, EventArgs e)
        {
            this.Location = new Point(224, 124);
        }

        #endregion

        #region ComboBox
        private void cmbBoxPais_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ModeloProvincia lcl_mod_provincia = new ModeloProvincia();
            //Inserto codigoPais del país seleccionado en el comboBox
            lcl_mod_provincia.codigoPais = this.cmbBoxPais.SelectedValue.ToString();
            //this.cmbBoxProvincia.DataSource = provincias;
            List<ModeloProvincia> lcl_lst_mod_provincias = ControladorBusqueda.getProvincias();
            List<ModeloProvincia> provincias = new List<ModeloProvincia>();
            foreach (ModeloProvincia p in lcl_lst_mod_provincias)
            {
                if (p.codigoPais == lcl_mod_provincia.codigoPais)
                {
                    provincias.Add(p);
                }
            }
            this.cargarDatosProvinciasEnCmbBoxProvincia(provincias);
        }
        #endregion

        #region TextBox
        private void valorCUIT(object sender, KeyPressEventArgs e)
        {
            // solo 0-9 y borrar 
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8))
            {
                e.Handled = true;
                return;
            }
            //inserta guión luego del caracter 2 y 11
            if ((sender as TextBox).Text.Length == 2 || (sender as TextBox).Text.Length == 11)
            {
                if (e.KeyChar != 8)
                {
                    (sender as TextBox).Text += "-" + e.KeyChar;
                    e.Handled = true;
                    (sender as TextBox).SelectionStart = (sender as TextBox).Text.Length;
                }

            }
        }

        private void valorDNI(object sender, KeyPressEventArgs e)
        {
            // solo 0-9, borrar y '.' para cada mil
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != '.'))
            {
                e.Handled = true;
                return;
            }
        }
        #endregion

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

        #endregion

                
    }
}
