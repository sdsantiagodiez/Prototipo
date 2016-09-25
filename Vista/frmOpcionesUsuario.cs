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
using LibreriaClasesCompartidas;

namespace Vista
{
    public partial class frmOpcionesUsuario : frmMaterialSkinBase
    {
        #region Atributos
        ContextMenu cntxtMenuDataGridViews;
        string errorActual;
        ControlDomicilios glb_con_domicilios;
        ModeloUsuario glb_usuarioActual;
        public EventHandler ActualizarColoresEvent;
        public EventHandler ActualizarUsuario;
        List<bool> glb_lst_respuestasValidaciones;
        #endregion
        
        #region Constructores
        private frmOpcionesUsuario()
        {
            InitializeComponent();
            this.inicializarControles();
            this.Text = "Opciones de Usuario";
            glb_lst_respuestasValidaciones = new List<bool>();
            for (int i = 0; i < 7; i++)
            {
                glb_lst_respuestasValidaciones.Add(false);
            }
        }
        public frmOpcionesUsuario(ModeloUsuario p_usuario) : this()
        {
            glb_usuarioActual = p_usuario;
            this.cargarUsuarioEnControles(p_usuario);

        }
        #endregion

        #region Métodos
        #region Inicialización
        public override void inicializarForm(int ventanaAncho, int ventanaAlto)
        {
            this.tblLayoutPanelPrincipal.Width = ventanaAncho - 20; //un margen derecho de 20 para que se vea scrollbar
            this.pnlBase.Width = ventanaAncho ;  //un márgen derecho de 3
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
            this.pnlBase.Location = new Point(0, 60);
            //this.inicializarControles_Size();
        }
   
        private void inicializarControles()
        {
            this.inicializarDomicilio();
            this.inicializarDataGridViews();
            this.inicializarContextMenu();
            this.inicializarBotones();
            this.inicializarCmbBoxTipoTelefonos();
            this.inicializarTextBoxes();
        }
        private void inicializarDomicilio()
        {
            glb_con_domicilios = new ControlDomicilios();
            this.grpBoxDomicilio.Controls.Add(glb_con_domicilios);
            glb_con_domicilios.Dock = DockStyle.Fill;
        }
        private void inicializarDataGridViews()
        {
            
            this.dataGridViewMail.MouseDown += this.dataGridView_MouseDown;
            this.dataGridViewTelefono.MouseDown += this.dataGridView_MouseDown;
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
            this.btnAgregarMail.Click += (s, e) =>
            {
                if (validarInputs(s, e, Constantes.ParametrosBusqueda.Mails.CodigoMail))
                {
                    this.agregarMailEntidad();
                }
                else
                {
                    MessageBox.Show("Por favor ingrese una dirección de correo válida");
                }
            };
            this.btnAgregarTelefono.Click += (s, e) =>
            {
                if (cmbBoxTipoTelefono.SelectedValue == null)
                {
                    MessageBox.Show("Debe seleccionar un tipo de teléfono para el número indicado");
                }
                else if (validarInputs(s, e, Constantes.ParametrosBusqueda.Telefonos.CodigoTelefono))
                {
                    this.agregarTelefonoEntidad();
                }
                else
                {
                    MessageBox.Show("Por favor ingrese un teléfono válido");
                }
            };
            #endregion

            #region btnQuitar
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
        private void inicializarCmbBoxTipoTelefonos()
        {
            //Creo lista Tipos de teléfono
            var dataSource = new List<ComboBoxItem>();
            dataSource.Add(new ComboBoxItem() { Name = "Fijo", Value = LibreriaClasesCompartidas.Constantes.TipoTelefono.Fijo });
            dataSource.Add(new ComboBoxItem() { Name = "Celular", Value = LibreriaClasesCompartidas.Constantes.TipoTelefono.Celular });
            dataSource.Add(new ComboBoxItem() { Name = "Fax", Value = LibreriaClasesCompartidas.Constantes.TipoTelefono.Fax });

            this.cmbBoxTipoTelefono.DataSource = dataSource;
            this.cmbBoxTipoTelefono.DisplayMember = "Name";
            this.cmbBoxTipoTelefono.ValueMember = "Value";

            //Lo hago read only
            this.cmbBoxTipoTelefono.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void inicializarTextBoxes()
        {
            this.txtBoxCUIT.KeyPress += this.valorCUIT;
            this.txtBoxDNI.KeyPress += this.valorDNI;

            txtBoxContraseñaNueva.KeyPress += this.permitirCambio;
            txtBoxContraseñaNuevaRepetir.KeyPress += this.permitirCambio;
        }
        #endregion
     
        #region Controles -> Modelos
        private ModeloUsuario cargarDatosControlEnUsuario()
        {
            string mensaje;
            if (this.validar_cargarDatosControlEnUsuario(out mensaje))
            {
                ModeloUsuario lcl_mod_usuario = new ModeloUsuario()
                {
                    codigo = glb_usuarioActual.codigo,
                    roles = glb_usuarioActual.roles,
                    usuario = glb_usuarioActual.usuario,
                    observaciones = glb_usuarioActual.observaciones
                };
                lcl_mod_usuario.setContraseñaEncriptada(glb_usuarioActual.contrasenia);

                this.cargarDatosControlPersonales(ref lcl_mod_usuario);
                this.cargarDatosControlContraseña(ref lcl_mod_usuario);
                this.cargarDatosControlDeContacto(ref lcl_mod_usuario);


                return lcl_mod_usuario;
            }
            else
            {
                MessageBox.Show(mensaje,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return null;
            }
            
        }
        private bool validar_cargarDatosControlEnUsuario(out string p_mensajeError)
        {
            p_mensajeError = null;
            if (this.validarHayCambioDeContraseña())
            {
                if (!this.validarNuevaContraseña(out p_mensajeError))
                {
                    return false;
                }
            }

            if (!this.validarDatosPersonales())
            {
                p_mensajeError = "Error al cargar datos personales";
                return false;
            }

            return true;
        }
        private void cargarDatosControlPersonales(ref ModeloUsuario p_mod_usuario)
        {
            p_mod_usuario.nombre = this.txtBoxNombre.Text;
            p_mod_usuario.apellido = this.txtBoxApellido.Text;
            p_mod_usuario.dni = this.txtBoxDNI.Text;
            p_mod_usuario.cuit = this.txtBoxCUIT.Text;

        }
        private bool validarDatosPersonales()
        {
            return true;
        }
        private void cargarDatosControlContraseña(ref ModeloUsuario p_mod_usuario)
        {
            if (!this.validarHayCambioDeContraseña())
            {
                return;
            }
            p_mod_usuario.asignarContraseña(this.txtBoxContraseñaNueva.Text);
        }
        private bool validarHayCambioDeContraseña()
        {
            return !String.IsNullOrWhiteSpace(this.txtBoxContraseñaActual.Text) ||
                    !String.IsNullOrWhiteSpace(this.txtBoxContraseñaNueva.Text) ||
                    !String.IsNullOrWhiteSpace(this.txtBoxContraseñaNuevaRepetir.Text);
        }
        private bool validarNuevaContraseña(out string p_mensajeError)
        {
            ModeloUsuario lcl_usuarioTemp = new ModeloUsuario();
            lcl_usuarioTemp.asignarContraseña(this.txtBoxContraseñaActual.Text);

            if (!glb_usuarioActual.contrasenia.Equals(lcl_usuarioTemp.contrasenia))
            {
                p_mensajeError = "La contraseña actual ingresada no es válida";
                return false;
            }

            if (!ModeloUsuario.validarContrasenia(this.txtBoxContraseñaNueva.Text))
            {
                p_mensajeError = "La contraseña nueva no es válida";
                return false;
            }

            if (!this.txtBoxContraseñaNueva.Text.Equals(this.txtBoxContraseñaNuevaRepetir.Text))
            {
                p_mensajeError = "La confirmación de contraseña no coincide con la nueva contraseña";
                return false;
            }

            p_mensajeError = null;
            return true;
        }
        private void cargarDatosControlDeContacto(ref ModeloUsuario p_mod_usuario)
        {
            p_mod_usuario.domicilios = this.glb_con_domicilios.getDomicilios();
            p_mod_usuario.telefonos = this.cargarDatosControlEnListTelefono();
            p_mod_usuario.mails = this.cargarDatosControlEnListMail();
        }
     
        /// <summary>
        /// Toma los datos de textBoxes y comboBoxes antes de agregar a DataGridView
        /// </summary>
        /// <returns></returns>
     
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
            //if (this.validarMail())
            //{
            ModeloMail lcl_mod_mail = new ModeloMail();
            lcl_mod_mail.mail = txtBoxMail.Text;
            return lcl_mod_mail;
            //}
            //else
            //{
            //    return null;
            //}
        }
        #endregion

        #region Modelos -> Controles
        private void cargarUsuarioEnControles(ModeloUsuario p_mod_usuario)
        {
            this.cargarDatosPersonalesEnControles(p_mod_usuario);

            this.glb_con_domicilios.setDomicilios(p_mod_usuario.domicilios);
            this.cargarDatosTelefonoEnDataGridViewTelefono(p_mod_usuario.telefonos);
            this.cargarDatosMailEnDataGridViewMail(p_mod_usuario.mails);
        }

        private void cargarDatosPersonalesEnControles(ModeloUsuario p_mod_usuario)
        {
            this.txtBoxNombre.Text = p_mod_usuario.nombre;
            this.txtBoxApellido.Text = p_mod_usuario.apellido;
            this.txtBoxDNI.Text = p_mod_usuario.dni;
            this.txtBoxCUIT.Text = p_mod_usuario.cuit;
        }

        #region DataGridViews
       
        
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

        #endregion

        #region Validación

        private int getIndex(string p_inputName)
        {
            int index;
            switch (p_inputName)
            {
                case Constantes.ParametrosBusqueda.Entidades.Cuit:
                    index = 0;
                    break;
                case Constantes.ParametrosBusqueda.Entidades.Personas.Dni:
                    index = 1;
                    break;
                case Constantes.ParametrosBusqueda.Entidades.Personas.Nombre:
                    index = 2;
                    break;
                case Constantes.ParametrosBusqueda.Entidades.Personas.Apellido:
                    index = 3;
                    break;
                case Constantes.ParametrosBusqueda.Entidades.Personas.Usuarios.Contrasenia:
                case Constantes.ParametrosBusqueda.Entidades.Personas.Usuarios.Contrasenia + "2":
                case Constantes.ParametrosBusqueda.Entidades.Personas.Usuarios.Contrasenia + "3":
                    index = 4;
                    break;
                case Constantes.ParametrosBusqueda.Mails.Mail:
                    index = 5;
                    break;
                case Constantes.ParametrosBusqueda.Telefonos.NumeroTelefono:
                    index = 6;
                    break;
                default:
                    index = 0;
                    break;
            }
            return index;
        }

        private bool validarInputs(object sender, EventArgs e, string sector)
        {
            bool lcl_respuesta = new bool();
            switch (sector)
            {
                case Constantes.ParametrosBusqueda.Entidades.Personas.CodigoEntidad:
                    txtBoxCUIT_Leave(sender, e);
                    txtBoxDNI_Leave(sender, e);
                    txtBoxNombre_Leave(sender, e);
                    txtBoxApellido_Leave(sender, e);
                    lcl_respuesta= (glb_lst_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Entidades.Personas.Cuit)]
                        && glb_lst_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Entidades.Personas.Dni)]
                        && glb_lst_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Entidades.Personas.Nombre)]
                        && glb_lst_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Entidades.Personas.Apellido)]);
                    break;
                case Constantes.ParametrosBusqueda.Entidades.Personas.Usuarios.Contrasenia:
                    txtBoxContraseñaActual_Leave(sender, e);
                    txtBoxContraseñaNueva_Leave(sender, e);
                    txtBoxContraseñaNuevaRepetir_Leave(sender, e);
                    if (string.IsNullOrWhiteSpace(txtBoxContraseñaActual.Text))
                    {
                        lcl_respuesta = true;
                    }
                    else
                    {
                        lcl_respuesta = (glb_lst_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Entidades.Personas.Usuarios.Contrasenia)]
                            && glb_lst_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Entidades.Personas.Usuarios.Contrasenia + "2")]
                            && glb_lst_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Entidades.Personas.Usuarios.Contrasenia + "3")]);
                    }
                    break;
                case Constantes.ParametrosBusqueda.Mails.CodigoMail:
                    txtBoxMail_Leave(sender, e);
                    lcl_respuesta = glb_lst_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Mails.Mail)];
                    break;
                case Constantes.ParametrosBusqueda.Telefonos.CodigoTelefono:
                    txtBoxTelefono_Leave(sender, e);
                    lcl_respuesta = glb_lst_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Telefonos.NumeroTelefono)];
                    break;
                default:
                    lcl_respuesta = false;
                    break;
            }
            return lcl_respuesta;
        }
      
        
        private bool validarTelefono()
        {
            //False si el capo esta vacio. Completar
            //if (!ModeloTelefono.validarNumero(txtBoxTelefono.Text))
            //{
            //    errorActual = "El número de teléfono ingresado no es válido";
            //    return false;
            //}
            //else 
            if (cmbBoxTipoTelefono.SelectedValue == null)
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
            //if (!ModeloMail.validarMail(txtBoxMail.Text))
            //{
            //    errorActual = "La dirección de correo electrónico ingresada no es válida.";
            //    return false;
            //}
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
        #endregion

        private void guardarCambios()
        {
            ModeloUsuario lcl_mod_usuario = this.cargarDatosControlEnUsuario();
            if (lcl_mod_usuario == null)
            {
                return;
            }
            

            if (validarInputs(new object(), new EventArgs(), Constantes.ParametrosBusqueda.Entidades.Personas.CodigoEntidad)
            && validarInputs(new object(), new EventArgs(), Constantes.ParametrosBusqueda.Entidades.Personas.Usuarios.Contrasenia))
            {
                Controladores.ControladorModificacion lcl_con_modificacion = new Controladores.ControladorModificacion();

                if (lcl_con_modificacion.modificar(lcl_mod_usuario))
                {
                    glb_usuarioActual = new ModeloUsuario(lcl_mod_usuario);
                    MessageBox.Show("Cambios guardados exitosamente", "Éxito", MessageBoxButtons.OK);
                    this.ActualizarUsuario(glb_usuarioActual, new EventArgs());
                    this.clearErrorProviders();
                    this.glb_con_domicilios.clearErrorProviders();
                }
                else
                {
                    MessageBox.Show(lcl_con_modificacion.errorActual, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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
     
        private void agregarMailEntidad()
        {
            ModeloMail lcl_mod_mailActual = this.cargarDatosControlEnMail();
            if (this.validarMailExiste() && lcl_mod_mailActual != null)
            {
                this.cargarDatosMailEnDataGridViewMail(lcl_mod_mailActual);

                QuitarTextoEnControles(tblLayoutPanelMail);
            }
            else
            {
                MessageBox.Show(this.errorActual, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void agregarTelefonoEntidad()
        {
            ModeloTelefono lcl_mod_telefonoActual = this.cargarDatosControlEnTelefono();
            if (this.validarTelefonoExiste() && lcl_mod_telefonoActual != null)
            {
                this.cargarDatosTelefonoEnDataGridViewTelefono(lcl_mod_telefonoActual);

                QuitarTextoEnControles(tblLayoutPanelTelefono);
            }
            else
            {
                MessageBox.Show(this.errorActual, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        #region DataGridView
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

        #region TextBoxs
        private void valorCUIT(object sender, KeyPressEventArgs e)
        {
            // solo 0-9 y borrar y - (char 45)
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 45))
            {
                e.Handled = true;
                return;
            }
            ////inserta guión luego del caracter 2 y 11
            //if ((sender as TextBox).Text.Length == 2 || (sender as TextBox).Text.Length == 11)
            //{
            //    if (e.KeyChar != 8)
            //    {
            //        (sender as TextBox).Text += "-" + e.KeyChar;
            //        e.Handled = true;
            //        (sender as TextBox).SelectionStart = (sender as TextBox).Text.Length;
            //    }

            //}
        }

        private void valorDNI(object sender, KeyPressEventArgs e)
        {
            this.valorNumericoTeclado(sender, e);
            if (!e.Handled)
            {
                return;//quiere decir que se ingreso un número en el evento anterior
            }
            else
            {
                e.Handled = false;//Volvemos a setear en caso que no haya sido un número el keyPress
            }

            //Admitimos además de numéricos también puntos según corresponda
            int keyCharSeparador = 46;//46: '.'

            if (e.KeyChar != keyCharSeparador)
            {
                e.Handled = true;
                return;
            }
        }
        private bool validarCUIT()
        {
            if (string.IsNullOrWhiteSpace(txtBoxCUIT.Text) || !ModeloEntidad.CUIT.ValidarCuit(txtBoxCUIT.Text))
            {
                this.setErrorProvider(this.txtBoxCUIT, false, "CUIT no válido");
                return false;
            }
            return true;
        }
        private void txtBoxCUIT_Leave(object sender, EventArgs e)
        {
            string lcl_mensaje;
            if (!Validar.validarLongitud(txtBoxCUIT.Text, Constantes.ParametrosBusqueda.Entidades.Cuit, out lcl_mensaje))
            {
                this.setErrorProvider(txtBoxCUIT, false, lcl_mensaje);
                glb_lst_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Entidades.Cuit)] = false;
            }
            else
            {
                bool respuesta = this.validarCUIT();//Validar.validarInputNoNumerico(txtBoxCUIT.Text.ToString(), Constantes.ParametrosBusqueda.Entidades.Cuit);
                glb_lst_respuestasValidaciones[this.getIndex(Constantes.ParametrosBusqueda.Entidades.Cuit)] = respuesta;
                if (respuesta)
                {
                    this.txtBoxCUIT.Text = ModeloEntidad.CUIT.NormalizarCUIT(this.txtBoxCUIT.Text);
                    if (!string.IsNullOrWhiteSpace(txtBoxDNI.Text))
                    {
                        if (string.Equals(txtBoxCUIT.Text.Substring(3, txtBoxDNI.Text.Replace(".", string.Empty).Length), txtBoxDNI.Text.Replace(".", string.Empty)))
                        {
                            lcl_mensaje = "OK";
                            this.setErrorProvider(this.txtBoxCUIT, respuesta, lcl_mensaje);

                            this.setErrorProvider(this.txtBoxDNI, respuesta, lcl_mensaje);
                            glb_lst_respuestasValidaciones[this.getIndex(Constantes.ParametrosBusqueda.Entidades.Personas.Dni)] = true;
                        }
                        else
                        {
                            lcl_mensaje = "CUIT no coincide con DNI";
                            respuesta = false;
                            glb_lst_respuestasValidaciones[this.getIndex(Constantes.ParametrosBusqueda.Entidades.Cuit)] = respuesta;
                            this.setErrorProvider(this.txtBoxCUIT, false, lcl_mensaje);
                        }
                    }
                    else
                    {
                        lcl_mensaje = "OK";
                        this.setErrorProvider(this.txtBoxCUIT, respuesta, lcl_mensaje);
                    }
                }
                else
                {
                    lcl_mensaje = "CUIT no válido";
                    if (String.IsNullOrWhiteSpace(this.txtBoxCUIT.Text))
                    {
                        lcl_mensaje = null;
                    }

                    this.setErrorProvider(this.txtBoxCUIT, respuesta, lcl_mensaje);
                }
            }
        }

        private void txtBoxDNI_Leave(object sender, EventArgs e)
        {
            string lcl_mensaje;
            if (!Validar.validarLongitud(txtBoxDNI.Text, Constantes.ParametrosBusqueda.Entidades.Personas.Dni, out lcl_mensaje))
            {
                this.setErrorProvider(txtBoxDNI, false, lcl_mensaje);
                glb_lst_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Entidades.Personas.Dni)] = false;
            }
            else
            {
                //realizo validación
                bool respuesta = Validar.validarInputNoNumerico(txtBoxDNI.Text.ToString(), Constantes.ParametrosBusqueda.Entidades.Personas.Dni);
                glb_lst_respuestasValidaciones[this.getIndex(Constantes.ParametrosBusqueda.Entidades.Personas.Dni)] = respuesta;
                if (respuesta)
                {
                    this.txtBoxDNI.Text = ModeloEntidad.DNI.NormalizarDNI(this.txtBoxDNI.Text);
                    if (!string.IsNullOrWhiteSpace(txtBoxCUIT.Text))
                    {
                        if (string.Equals(txtBoxCUIT.Text.Substring(3, txtBoxDNI.Text.Replace(".", string.Empty).Length), txtBoxDNI.Text.Replace(".", string.Empty)))
                        {
                            lcl_mensaje = "OK";
                            this.setErrorProvider(this.txtBoxDNI, respuesta, lcl_mensaje);
                            this.txtBoxCUIT_Leave(new object(), new EventArgs());
                        }
                        else
                        {
                            lcl_mensaje = "DNI no coincide con CUIT";
                            respuesta = false;
                            glb_lst_respuestasValidaciones[this.getIndex(Constantes.ParametrosBusqueda.Entidades.Personas.Dni)] = respuesta;
                            this.setErrorProvider(this.txtBoxDNI, false, lcl_mensaje);
                        }
                    }
                    else
                    {
                        lcl_mensaje = "OK";
                        this.setErrorProvider(this.txtBoxDNI, respuesta, lcl_mensaje);
                    }
                }
                else
                {
                    lcl_mensaje = "DNI no válido";
                    this.setErrorProvider(this.txtBoxDNI, respuesta, lcl_mensaje);
                }
            }
        }

        private void txtBoxNombre_Leave(object sender, EventArgs e)
        {
            string lcl_mensaje;
            if (!Validar.validarLongitud(txtBoxNombre.Text, Constantes.ParametrosBusqueda.Entidades.Personas.Nombre, out lcl_mensaje))
            {
                this.setErrorProvider(txtBoxNombre, false, lcl_mensaje);
                glb_lst_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Entidades.Personas.Nombre)] = false;
            }
            else
            {
                bool respuesta = Validar.validarInputNoNumerico(txtBoxNombre.Text.ToString(), Constantes.ParametrosBusqueda.Entidades.Personas.Nombre);
                glb_lst_respuestasValidaciones[this.getIndex(Constantes.ParametrosBusqueda.Entidades.Personas.Nombre)] = respuesta;
                lcl_mensaje = respuesta ? "OK" : "Nombre no válido";
                this.setErrorProvider(this.txtBoxNombre, respuesta, lcl_mensaje);
            }
        }

        private void txtBoxApellido_Leave(object sender, EventArgs e)
        {
            string lcl_mensaje;
            if (!Validar.validarLongitud(txtBoxApellido.Text, Constantes.ParametrosBusqueda.Entidades.Personas.Apellido, out lcl_mensaje))
            {
                this.setErrorProvider(txtBoxApellido, false, lcl_mensaje);
                glb_lst_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Entidades.Personas.Apellido)] = false;
            }
            else
            {
                bool respuesta = Validar.validarInputNoNumerico(txtBoxApellido.Text.ToString(), Constantes.ParametrosBusqueda.Entidades.Personas.Apellido);
                glb_lst_respuestasValidaciones[this.getIndex(Constantes.ParametrosBusqueda.Entidades.Personas.Apellido)] = respuesta;
                lcl_mensaje = respuesta ? "OK" : "Apellido no válido";
                this.setErrorProvider(this.txtBoxApellido, respuesta, lcl_mensaje);
            }
        }

        private void txtBoxContraseñaActual_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBoxContraseñaActual.Text))
            {
                string lcl_contrasenia = ModeloUsuario.encriptarContraseña(txtBoxContraseñaActual.Text);
                bool respuesta = string.Equals(lcl_contrasenia, glb_usuarioActual.contrasenia);
                glb_lst_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Entidades.Personas.Usuarios.Contrasenia)] = respuesta;
                string lcl_mensaje = respuesta ? "OK" : "Contraseña incorrecta";
                this.setErrorProvider(txtBoxContraseñaActual, respuesta, lcl_mensaje);
            }
            else
            { txtBoxContraseñaActual.Text = ""; }
        }

        private void txtBoxContraseñaNueva_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBoxContraseñaNueva.Text))
            {
                string lcl_mensaje;
                if (!Validar.validarLongitud(txtBoxContraseñaNueva.Text, Constantes.ParametrosBusqueda.Entidades.Personas.Usuarios.Contrasenia, out lcl_mensaje))
                {
                    this.setErrorProvider(txtBoxContraseñaNueva, false, lcl_mensaje);
                    glb_lst_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Entidades.Personas.Usuarios.Contrasenia)] = false;
                }
                else
                {
                    bool respuesta = Validar.validarInputNoNumerico(txtBoxContraseñaNueva.Text.ToString(), Constantes.ParametrosBusqueda.Entidades.Personas.Usuarios.Contrasenia);
                    glb_lst_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Entidades.Personas.Usuarios.Contrasenia + "2")] = respuesta;
                    lcl_mensaje = respuesta ? "OK" : "Contraseña no válida";
                    this.setErrorProvider(txtBoxContraseñaNueva, respuesta, lcl_mensaje);
                    if (respuesta && !String.IsNullOrEmpty(this.txtBoxContraseñaNuevaRepetir.Text))
                    {
                        this.txtBoxContraseñaNuevaRepetir_Leave(new object(), new EventArgs());
                    }
                }
            }
            else
            { txtBoxContraseñaNueva.Text = ""; }
        }

        private void txtBoxContraseñaNuevaRepetir_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtBoxContraseñaNuevaRepetir.Text))
            {
                string lcl_mensaje;
                if (!Validar.validarLongitud(txtBoxContraseñaNuevaRepetir.Text, Constantes.ParametrosBusqueda.Entidades.Personas.Usuarios.Contrasenia, out lcl_mensaje))
                {
                    this.setErrorProvider(txtBoxContraseñaNuevaRepetir, false, lcl_mensaje);
                    glb_lst_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Entidades.Personas.Usuarios.Contrasenia)] = false;
                }
                else
                {
                    bool respuesta = Validar.validarInputNoNumerico(txtBoxContraseñaNuevaRepetir.Text.ToString(), Constantes.ParametrosBusqueda.Entidades.Personas.Usuarios.Contrasenia);
                    glb_lst_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Entidades.Personas.Usuarios.Contrasenia + "3")] = respuesta;
                    if (!respuesta)
                    {
                        lcl_mensaje = "Contraseña no válida";
                        this.setErrorProvider(txtBoxContraseñaNuevaRepetir, false, lcl_mensaje);
                    }
                    else
                    {
                        if (string.Equals(txtBoxContraseñaNueva.Text.ToString(), txtBoxContraseñaNuevaRepetir.Text.ToString()))
                        {
                            lcl_mensaje = "OK";
                            this.setErrorProvider(txtBoxContraseñaNuevaRepetir, true, lcl_mensaje);
                        }
                        else
                        {
                            lcl_mensaje = "Las contraseñas no coinciden";
                            this.setErrorProvider(txtBoxContraseñaNuevaRepetir, false, lcl_mensaje);
                        }
                    }
                }
            }
            else
            { txtBoxContraseñaNuevaRepetir.Text = ""; }
        }

        private void txtBoxMail_Leave(object sender, EventArgs e)
        {
             string lcl_mensaje;
             if (!Validar.validarLongitud(txtBoxMail.Text, Constantes.ParametrosBusqueda.Mails.Mail, out lcl_mensaje))
             {
                 this.setErrorProvider(txtBoxMail, false, lcl_mensaje);
                 glb_lst_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Mails.Mail)] = false;
             }
             else
             {
                 bool respuesta = Validar.validarInputNoNumerico(txtBoxMail.Text.ToString(), Constantes.ParametrosBusqueda.Mails.Mail);
                 glb_lst_respuestasValidaciones[this.getIndex(Constantes.ParametrosBusqueda.Mails.Mail)] = respuesta;
                 lcl_mensaje = respuesta ? "OK" : "Mail no válido";
                 this.setErrorProvider(this.txtBoxMail, respuesta, lcl_mensaje);
             }
        }

        private void txtBoxTelefono_Leave(object sender, EventArgs e)
        {
            string lcl_mensaje;
            if (!Validar.validarLongitud(txtBoxTelefono.Text, Constantes.ParametrosBusqueda.Telefonos.NumeroTelefono, out lcl_mensaje))
            {
                this.setErrorProvider(txtBoxTelefono, false, lcl_mensaje);
                glb_lst_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Telefonos.NumeroTelefono)] = false;
            }
            else
            {
                bool respuesta = Validar.validarInputNoNumerico(txtBoxTelefono.Text.ToString(), Constantes.ParametrosBusqueda.Telefonos.NumeroTelefono);
                glb_lst_respuestasValidaciones[this.getIndex(Constantes.ParametrosBusqueda.Telefonos.NumeroTelefono)] = respuesta;
                lcl_mensaje = respuesta ? "OK" : "Numero de Teléfono no válido";
                this.setErrorProvider(this.txtBoxTelefono, respuesta, lcl_mensaje);
            }
        }

        private void permitirCambio(object sender, KeyPressEventArgs e)
        {
            if(!glb_lst_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Entidades.Personas.Usuarios.Contrasenia)])
            {
                e.Handled = true;
                return;
            }
        }
        #endregion

        #region Buttons
        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            this.guardarCambios();
        }
        

        private void btnCambiarColores_Click(object sender, EventArgs e)
        {
            //le damos toda la vuelta
            switch (Properties.Settings.Default.color_scheme)
            {
                case 0:
                    Properties.Settings.Default.color_scheme = 1;
                    break;
                case 1:
                    Properties.Settings.Default.color_scheme = 2;
                    break;
                case 2:
                    Properties.Settings.Default.color_scheme = 3;
                    break;
                case 3:
                    Properties.Settings.Default.color_scheme = 4;
                    break;
                case 4:
                    Properties.Settings.Default.color_scheme = 5;
                    break;
                case 5:
                    Properties.Settings.Default.color_scheme = 6;
                    break;
                case 6:
                    Properties.Settings.Default.color_scheme = 0;
                    break;
            }
            Properties.Settings.Default.Save();
            this.ActualizarColoresEvent(new object(), new EventArgs());
            this.actualizarColores();
        }
        #endregion

        #region Tabs
        private void tbControlPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tbControlPrincipal.SelectedTab == tbControlPrincipal.TabPages["tbEstiloVisual"])
            {
                btnGuardarCambios.Visible = false;
            }
            else
            {
                btnGuardarCambios.Visible = true;
            }
        }
        #endregion
        #endregion
    }
}
