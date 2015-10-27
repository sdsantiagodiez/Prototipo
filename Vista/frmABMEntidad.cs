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


namespace Vista
{
    public partial class frmABMEntidad : Form
    {
        //REVISAR ver si se puede mejorar esto de tantas constantes
        private const string TipoEntidadPersona = "PER";
        private const string TipoEntidadProveedor = "PRO";
        private const string TipoPersonaCliente = "CLI";
        private const string TipoPersonaContactoDeProveedor = "CON";
        private const string TipoPersonaUsuario = "USR";
        private Form frmResultadoBusqueda = new Form();
        DataGridView dataGridViewResultadoBusqueda = new DataGridView();

        public frmABMEntidad()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            btnAgregarMail.Text = char.ConvertFromUtf32(8595);
            btnQuitarMail.Text = char.ConvertFromUtf32(8593);

            toolStripMenuItemEliminar.Enabled = false;
            ToolStripMenuItemGuardarCambios.Enabled = false;

            this.inicializarListViews();

            this.inicializarComboBox();

            this.inicializarCheckedListBox();

            this.inicializarFrmResultadoBusqueda();
        }    

        #region Inicializar
       
        private void inicializarListViews()
        {
            lstViewMail.Columns.Add("Mail", -2, System.Windows.Forms.HorizontalAlignment.Center);
            lstViewMail.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            lstViewMail.View = View.Details;

        }

        private void inicializarComboBox()
        {
            //Populo combobox de paises
            ControladorBusqueda cBusqueda = new ControladorBusqueda();
            List<ModeloPais> paises = cBusqueda.buscarPaises();
            this.cmbBoxPais.DataSource = paises;
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

        private void inicializarCheckedListBox()
        {
            //REVISAR FALTAN roles en controladores y catalogo
            ControladorBusqueda cBusqueda = new ControladorBusqueda();
            List<ModeloRoles> roles = new List<ModeloRoles>();
            chckdListBoxRol.DataSource = roles;
            chckdListBoxRol.DisplayMember = "descripcion";
            chckdListBoxRol.ValueMember = "codigo";
        }

        private void inicializarFrmResultadoBusqueda()
        {
            frmResultadoBusqueda.Text = "Resultado de búsqueda";
            frmResultadoBusqueda.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
            frmResultadoBusqueda.AutoSize = true;

            frmResultadoBusqueda.FormClosing += frmResultadoBusqueda_FormClosing;                
        }

        
        #endregion

        #region Eventos

        //
        // radioButton
        //
        private void radioButtonUsuario_CheckedChanged(object sender, EventArgs e)
        {

            //tblLayoutPanelExtra = new System.Windows.Forms.TableLayoutPanel();
            //tbPageExtra.Controls.Clear();
            //tbPageExtra.Controls.Add(tblLayoutPanelExtra);
            //tblLayoutPanelExtra.Dock = DockStyle.Fill;
            //tblLayoutPanelExtra.Controls.Add(grpBoxDatosUsuario, 0, 0);
            ////
            //System.Windows.Forms.GroupBox grpBoxDatosUsuario = new GroupBox();


            //tblLayoutPanelExtra.Visible = radioButtonUsuario.Checked;

            //grpBoxDatosUsuario = new System.Windows.Forms.GroupBox();

            //panel1 = new System.Windows.Forms.Panel();
            //grpBoxDatosUsuario.Controls.Add(panel1);

            //panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quitarTextoEnControles(grpBoxDatosUsuario);

        }

        private void radioButtonProveedor_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxRazonSocial.Enabled = radioButtonProveedor.Checked;
            txtBoxDNI.Enabled = !radioButtonProveedor.Checked;
            txtBoxNombre.Enabled = !radioButtonProveedor.Checked;
            txtBoxApellido.Enabled = !radioButtonProveedor.Checked;
            
        }

        private void radioButtonCliente_CheckedChanged(object sender, EventArgs e)
        {
            btnMasDatos.Enabled = !radioButtonCliente.Checked;
            
        }
        //
        //Button
        //
        private void btnAgregarMail_Click(object sender, EventArgs e)
        {
            ModeloMail mMail = new ModeloMail();
            mMail.mail = txtBoxMail.Text;
            //Agregar validación por si el mail ya esta incluido
            if (mMail.validarMail() && this.validarMail())
            {
                DataGridViewRow row = (DataGridViewRow)dataGridViewMail.Rows[0].Clone();
                row.Cells[0].Value = 0;
                row.Cells[1].Value = txtBoxMail.Text;
                dataGridViewMail.Rows.Add(row);
            }
            else if (!this.validarMail())
            {
                frmMensajeCorto mensaje = new frmMensajeCorto("Faltan campos", "El campo número de teléfono esta vacío", "fallo");
                mensaje.ShowDialog();
            }
            else
            {
                frmMensajeCorto mensaje = new frmMensajeCorto("Error", "El formato de mail ingresado no es válido", "fallo");
                mensaje.ShowDialog();   
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
                frmMensajeCorto mensaje = new frmMensajeCorto("Faltan campos", "El campo número de teléfono esta vacío", "fallo");
                mensaje.ShowDialog();
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
                row.Cells[1].Value = 0;
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
                frmMensajeCorto mensaje = new frmMensajeCorto("Faltan campos", "Debe seleccionar un país y provincia para el domicilio", "fallo");
                mensaje.ShowDialog();
                
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
        //
        //cmbBox
        //
        private void cmbBoxPais_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ControladorBusqueda cBusqueda = new ControladorBusqueda();
            ModeloProvincia mProvinciaBusqueda = new ModeloProvincia();
            //Inserto codigoPais del país seleccionado en el comboBox
            mProvinciaBusqueda.codigoPais = this.cmbBoxPais.SelectedValue.ToString();
            //this.cmbBoxProvincia.DataSource = provincias;
            //REVISAR TEMPORAL HASTA QUE ESTE COMPLETO CONTROLADOrBUSQUEDA
            List<ModeloProvincia> lmProvincias = cBusqueda.buscarProvincias();
            List<ModeloProvincia> provincias = new List<ModeloProvincia>();
            foreach (ModeloProvincia p in lmProvincias)
            {
                if (p.codigoPais == mProvinciaBusqueda.codigoPais)
                {
                    provincias.Add(p);
                }
            }
            this.cargarDatosEnCmbBoxProvincia(provincias);
        }
        
        //
        // toolStrip
        //
                
        private void toolStripMenuItemBuscar_Click(object sender, EventArgs e)
        {
            string tipoEntidad = this.getTipoEntidad();
            if (tipoEntidad != null)
            {
                switch (tipoEntidad)
                {
                    case TipoEntidadPersona:
                        ModeloPersonas mPersona = this.cargarDatosEnModeloPersona();
                        List<ModeloPersonas> lmPersonas = this.buscarPersonas(mPersona);
                        dataGridViewResultadoBusqueda = this.popularDataGridViewResultadoBusqueda(this.inicializarDataGridViewResultadoBusqueda(TipoEntidadPersona),lmPersonas);
                        break;
                    case TipoEntidadProveedor:
                        ModeloProveedor mProveedor = this.cargarDatosEnModeloProveedor();
                        List<ModeloProveedor> lmProveedor = this.buscarProveedores(mProveedor);
                        dataGridViewResultadoBusqueda = this.popularDataGridViewResultadoBusqueda(this.inicializarDataGridViewResultadoBusqueda(TipoEntidadProveedor), lmProveedor);
                        break;
                    default:
                        break;
                }
                //frmResultadoBusqueda = new Form();
                frmResultadoBusqueda.Controls.Clear();
                frmResultadoBusqueda.BringToFront();
                frmResultadoBusqueda.Controls.Add(dataGridViewResultadoBusqueda);
                frmResultadoBusqueda.Show();
            }
            else
            {
                frmMensajeCorto seleccionarTipoEntidad = new frmMensajeCorto("Tipo Entidad", "Debe seleccionar un tipo de entidad para realizar la acción", "fallo");
                seleccionarTipoEntidad.ShowDialog();
            }

        }
        void frmResultadoBusqueda_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmResultadoBusqueda.Hide();
            e.Cancel = true; // this cancels the close event.
        }
        private DataGridView inicializarDataGridViewResultadoBusqueda(string tipoEntidad)
        {
            DataGridView dgv = new DataGridView();
            dgv.AutoGenerateColumns = false;
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.RowHeadersVisible = false;
            dgv.DoubleClick += dataGridViewResultadoBusqueda_DoubleClick;

            dgv.Width = 800;

            if (tipoEntidad == TipoEntidadProveedor || tipoEntidad == TipoEntidadPersona)
            {
                dgv.Columns.Add("tipo", "Tipo");
                dgv.Columns[0].FillWeight = 1;
                dgv.Columns.Add("codigoEntidad", "Código");
                dgv.Columns[1].FillWeight = 1;
                dgv.Columns.Add("cuit", "CUIT");
                dgv.Columns[2].FillWeight = 1;

                int indiceBase = 0;
                if (tipoEntidad == TipoEntidadProveedor)
                {
                    dgv.Columns.Add("razonSocial", "Razón Social");
                    dgv.Columns[3].FillWeight = 1;
                    indiceBase = 4;
                }
                else if (tipoEntidad == TipoEntidadPersona)
                {
                    dgv.Columns.Add("DNI", "DNI");
                    dgv.Columns[3].FillWeight = 1;
                    dgv.Columns.Add("apellido", "Apellido");
                    dgv.Columns[4].FillWeight = 1;
                    dgv.Columns.Add("Nombre", "Nombre");
                    dgv.Columns[5].FillWeight = 1;
                    indiceBase = 6;
                }
                dgv.Columns.Add("direccion", "Domicilio");
                dgv.Columns[indiceBase].FillWeight = 1;
                dgv.Columns.Add("ciudad", "Ciudad Domicilio");
                dgv.Columns[indiceBase + 1].FillWeight = 1;
                dgv.Columns.Add("provincia", "Provincia Domicilio");
                dgv.Columns[indiceBase + 2].FillWeight = 1;
            }
            return dgv;
        }
        void dataGridViewResultadoBusqueda_DoubleClick(object sender, EventArgs e)
        {
            string tipo = dataGridViewResultadoBusqueda.SelectedCells[0].Value.ToString();
            int codigoEntidadSeleccionada = Convert.ToInt32(dataGridViewResultadoBusqueda.SelectedCells[1].Value.ToString());
            frmResultadoBusqueda.Hide();

            toolStripMenuItemEliminar.Enabled = true;
            ToolStripMenuItemGuardarCambios.Enabled = true;
            EntidadToolStripMenuItemGuardarNueva.Enabled = false;

            this.cargarEntidadEnControles(codigoEntidadSeleccionada,tipo);
        }

        private void EntidadToolStripMenuItemGuardarNueva_Click(object sender, EventArgs e)
        {
            //Cambiar por un mensaje SI/NO
            DialogResult dialogResult = MessageBox.Show("¿Crear nueva entidad?", "Atención", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ControladorAlta cAlta = new ControladorAlta();
                string tipoEntidad = this.getTipoEntidad();
                string respuesta = "";
                bool exito = false;
                if (tipoEntidad != null)
                {
                    switch (tipoEntidad)
                    {
                        case TipoEntidadPersona:
                            ModeloPersonas mPersona = this.cargarDatosEnModeloPersona();
                            exito = cAlta.agregarPersona(mPersona);
                            break;
                        case TipoEntidadProveedor:
                            ModeloProveedor mProveedor = this.cargarDatosEnModeloProveedor();
                            exito = cAlta.agregarProveedor(mProveedor);
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
            }
            /* Por si se desea agregar algo en el futuro
            else if (dialogResult == DialogResult.No)
            {
                
            }
            */
            
        }

        private void ToolStripMenuItemGuardarCambios_Click(object sender, EventArgs e)
        {
            //Cambiar por un mensaje SI/NO
            DialogResult dialogResult = MessageBox.Show("¿Guardar los cambios realizados?", "Atención", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ControladorModificacion cModificacion = new ControladorModificacion();
                string tipoEntidad = this.getTipoEntidad();
                string respuesta = "";
                bool exito = false;
                if (tipoEntidad != null)
                {
                    switch (tipoEntidad)
                    {
                        case TipoEntidadPersona:
                            ModeloPersonas mPersona = this.cargarDatosEnModeloPersona();
                            exito = cModificacion.modificarPersona(mPersona);
                            break;
                        case TipoEntidadProveedor:
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
            }
            /* Por si se desea agregar algo en el futuro
            else if (dialogResult == DialogResult.No)
            {
                
            }
            */
            
        }

        private void toolStripMenuItemLimpiarCampos_Click(object sender, EventArgs e)
        {
            this.quitarTextoEnControles(this);
            txtBoxCodigoEntidad.Enabled = true;
            toolStripMenuItemEliminar.Enabled = false;
            ToolStripMenuItemGuardarCambios.Enabled = false;
            EntidadToolStripMenuItemGuardarNueva.Enabled = true;
        }
        
        private void toolStripMenuItemEliminar_Click(object sender, EventArgs e)
        {
            //Cambiar por un mensaje SI/NO
            DialogResult dialogResult = MessageBox.Show("¿Esta seguro que desea elimnar esta entidad?", "Atención", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ControladorBaja cBaja = new ControladorBaja();
                string tipoEntidad = this.getTipoEntidad();
                string respuesta = "";
                bool exito = false;
                if (tipoEntidad != null)
                {
                    switch (tipoEntidad)
                    {
                        case TipoEntidadPersona:
                            ModeloPersonas mPersona = this.cargarDatosEnModeloPersona();
                            exito = cBaja.eliminarPersona(mPersona);
                            break;
                        case TipoEntidadProveedor:
                            ModeloProveedor mProveedor = this.cargarDatosEnModeloProveedor();
                            exito = cBaja.eliminarProveedor(mProveedor);
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

        #region validar

        private bool validarValorNumerico(string pStringNumero)
        {
            int numero;
            return Int32.TryParse(pStringNumero, out numero);
        }

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

        #endregion
        
        #region Pasar datos de controles a Modelos
       
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

            mPersona.tipoPersona = this.getTipoPersona();
            mPersona.dni = txtBoxDNI.Text;
            mPersona.apellido = txtBoxApellido.Text;
            mPersona.nombre = txtBoxNombre.Text;
            if (this.getTipoPersona() == TipoPersonaUsuario)
            {
                mPersona.usuario = txtBoxUsuario.Text;
                mPersona.contrasenia = txtBoxContrasenia.Text;
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
        private ModeloEntidad cargarDatosEnModeloEntidad()
        {
            ModeloEntidad mEntidad = new ModeloEntidad();
            if (this.validarValorNumerico(txtBoxCodigoEntidad.Text))
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

                        if (this.validarValorNumerico(row.Cells["codigoDomicilio"].Value.ToString()))
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
                    if (this.validarValorNumerico(row.Cells["codigoTelefono"].Value.ToString()))
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
            foreach (object itemChecked in chckdListBoxRol.CheckedItems)
            {
                DataRowView rol = itemChecked as DataRowView;
                mRol.codigo = Convert.ToInt32(rol["codigo"].ToString());
                mRol.descripcion = rol["descripcion"].ToString();
            }
            return lModeloRol;
        }
       
        #endregion

        #region Pasar datos de Modelo a controles

        private void cargarEntidadEnControles(int codigoEntidad, string tipo)
        {
            this.quitarTextoEnControles(this);
            if (tipo == TipoEntidadProveedor)
            {
                this.cargarProveedorEnControles(codigoEntidad);
            }
            else
            {
                this.cargarPersonaEnControles(codigoEntidad);
            }
            this.cargarDatosEnRadioButtonTipoEntidad(tipo);

        }
        private void cargarPersonaEnControles(int codigoEntidad)
        {
            ControladorBusqueda cBusqueda = new ControladorBusqueda();
            ModeloPersonas mPersona = new ModeloPersonas();
            mPersona.codigo = codigoEntidad;
            mPersona = cBusqueda.buscarPersonas(mPersona, "codigoEntidad")[0];
            this.cargarDatosEnDatosPersonales(mPersona);
            
            this.cargarDatosEnDataGridViewDomicilio(mPersona.domicilios);
            this.cargarDatosEnDataGridViewTelefono(mPersona.telefonos);
            this.cargarDatosEnDataGridViewMail(mPersona.mails);

            if (mPersona.tipoPersona == TipoPersonaUsuario)
            {
                this.cargarDatosEnDatosUsuario(mPersona);
            }
            
        }
        private void cargarProveedorEnControles(int codigoEntidad)
        {
            ControladorBusqueda cBusqueda = new ControladorBusqueda();
            ModeloProveedor mProveedor = new ModeloProveedor();
            mProveedor.codigo = codigoEntidad;
            mProveedor = cBusqueda.buscarProveedores(mProveedor, "codigoEntidad")[0];
            this.cargarDatosEnDatosPersonales(mProveedor);
            
            this.cargarDatosEnDataGridViewDomicilio(mProveedor.domicilios);
            this.cargarDatosEnDataGridViewTelefono(mProveedor.telefonos);
            this.cargarDatosEnDataGridViewMail(mProveedor.mails);
        }
        private void cargarDatosEnDatosPersonales(ModeloPersonas pmPersona)
        {
            txtBoxCodigoEntidad.Text = pmPersona.codigo.ToString();
            txtBoxCodigoEntidad.Enabled = false;
            txtBoxDNI.Text = pmPersona.dni != null ? pmPersona.dni : "";
            txtBoxNombre.Text = pmPersona.nombre != null ? pmPersona.nombre : "";
            txtBoxApellido.Text = pmPersona.apellido != null ? pmPersona.apellido : "";
            txtBoxCUIT.Text = pmPersona.cuit != null ? pmPersona.cuit : "";
            rchTextBoxObservaciones.Text = pmPersona.observaciones != null ? pmPersona.observaciones : "";
        }
        private void cargarDatosEnDatosPersonales(ModeloProveedor pmProveedor)
        {
            txtBoxCodigoEntidad.Text = pmProveedor.codigo.ToString();
            txtBoxCodigoEntidad.Enabled = false;
            txtBoxCUIT.Text = pmProveedor.cuit != null ? pmProveedor.cuit : "";
            txtBoxRazonSocial.Text = pmProveedor.razonSocial != null ? pmProveedor.razonSocial : "";
            rchTextBoxObservaciones.Text = pmProveedor.observaciones != null ? pmProveedor.observaciones : "";
        }
        private void cargarDatosEnDataGridViewDomicilio(List<ModeloDomicilio> plmDomicilio)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridViewDomicilio.Rows[0].Clone();

            foreach (ModeloDomicilio mDomicilio in plmDomicilio)
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
        private void cargarDatosEnDataGridViewTelefono(List<ModeloTelefono> plmTelefono)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridViewTelefono.Rows[0].Clone();
            
            foreach (ModeloTelefono mTelefono in plmTelefono)
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
        private void cargarDatosEnDataGridViewMail(List<ModeloMail> plmMail)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridViewMail.Rows[0].Clone();
            foreach (ModeloMail mMail in plmMail)
            {
                row = (DataGridViewRow)dataGridViewMail.Rows[0].Clone();
                row.Cells[0].Value = mMail.codigoMail;
                row.Cells[1].Value = mMail.mail != null ? mMail.mail : "";
                
                dataGridViewMail.Rows.Add(row);
            }
        }
        private void cargarDatosEnRadioButtonTipoEntidad(string tipo)
        {
            switch (tipo)
            {
                case TipoEntidadProveedor:
                    radioButtonProveedor.Checked = true;
                    break;
                case TipoPersonaCliente:
                    radioButtonCliente.Checked = true;
                    break;
                case TipoPersonaContactoDeProveedor:
                    radioButtonContactoProveedor.Checked = true;
                    break;
                case TipoPersonaUsuario:
                    radioButtonUsuario.Checked = true;
                    break;
            }
        }
        private void cargarDatosEnDatosUsuario(ModeloPersonas pmUsuario)
        { }





        private void cargarDatosEnCmbBoxProvincia(List<ModeloProvincia> pLProvincias)
        {
            this.cmbBoxProvincia.DataSource = pLProvincias;
            this.cmbBoxProvincia.SelectedItem = null;
        }
        private void cargaDatosEnCmbBoxPais(List<ModeloPais> pLPais)
        {
            this.cmbBoxPais.DataSource = pLPais;
            this.cmbBoxPais.SelectedItem = null;
        }

        #endregion

        private void quitarTextoEnControles(Control con)
        {
            //se utiliza para que si el control no esta en ninguno de los if's,
            //entonces se mete en un control que puede contener una colección de controles
            bool bandera;
            foreach (Control c in con.Controls)
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
        
        private DataGridView popularDataGridViewResultadoBusqueda(DataGridView pdgv, List<ModeloPersonas> plmPersonas)
        {
            DataGridViewRow row = (DataGridViewRow)pdgv.Rows[0].Clone();
            foreach (ModeloPersonas p in plmPersonas)
            {
                row = (DataGridViewRow)pdgv.Rows[0].Clone();

                row.Cells[0].Value = p.tipoPersona;
                row.Cells[1].Value = p.codigo;
                row.Cells[2].Value = p.cuit;
                row.Cells[3].Value = p.dni;
                row.Cells[4].Value = p.apellido;
                row.Cells[5].Value = p.nombre;
                row.Cells[6].Value = p.domicilios.Count == 0 ? "Sin datos" : p.domicilios[0].calle + " " + p.domicilios[0].numero;
                row.Cells[7].Value = p.domicilios.Count == 0 ? "Sin datos" : p.domicilios[0].ciudad;
                row.Cells[8].Value = p.domicilios.Count == 0 ? "Sin datos" : p.domicilios[0].provincia.provincia;

                pdgv.Rows.Add(row);
            }
            return pdgv;
        }
        private DataGridView popularDataGridViewResultadoBusqueda(DataGridView pdgv, List<ModeloProveedor> plmProveedor)
        {
            DataGridViewRow row = (DataGridViewRow)pdgv.Rows[0].Clone();
            foreach (ModeloProveedor p in plmProveedor)
            {
                row = (DataGridViewRow)pdgv.Rows[0].Clone();

                row.Cells[0].Value = "PRO";
                row.Cells[1].Value = p.codigo;
                row.Cells[2].Value = p.cuit;
                row.Cells[3].Value = p.razonSocial;
                row.Cells[4].Value = p.domicilios.Count == 0 ? "Sin datos" : p.domicilios[0].calle + " " + p.domicilios[0].numero;
                row.Cells[5].Value = p.domicilios.Count == 0 ? "Sin datos" : p.domicilios[0].ciudad;
                row.Cells[6].Value = p.domicilios.Count == 0 ? "Sin datos" : p.domicilios[0].provincia.provincia;

                pdgv.Rows.Add(row);
            }
            return pdgv;
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
            switch (this.getTipoPersona())
            {
                case TipoPersonaCliente:
                case TipoPersonaContactoDeProveedor:
                case TipoPersonaUsuario:
                    tipoEntidad = TipoEntidadPersona;
                    break;
                case TipoEntidadProveedor:
                    tipoEntidad = TipoEntidadProveedor;
                    break;
                default:
                    break;
            }
            return tipoEntidad;
         
        }
        /// <summary>
        /// Retorna tipo persona seleccionada
        /// </summary>
        /// <returns>"CLI","CON","USR","PRO" ; null si no esta seleccionada o no se reconoce</returns>
        private string getTipoPersona()
        {
            
            RadioButton rbTipoEntidad = this.getRadioButtonTipoEntidad();
            if (rbTipoEntidad != null)
            {
                string tipoEntidad = null;
                switch (rbTipoEntidad.Text)
                {
                    case "Cliente":
                        tipoEntidad = TipoPersonaCliente;
                        break;
                    case "Proveedor":
                        tipoEntidad = TipoEntidadProveedor;
                        break;
                    case "Contacto de Proveedor":
                        tipoEntidad = TipoPersonaContactoDeProveedor;
                        break;
                    case "Usuario de Sistema":
                        tipoEntidad = TipoPersonaUsuario;
                        break;
                    default:
                        break;
                }
                return tipoEntidad;
            }
            else
            {
                return null;
            }
            
        }

        private List<ModeloProveedor> buscarProveedores(ModeloProveedor pmProveedor)
        {
            List<ModeloProveedor> lmProveedores = new List<ModeloProveedor>();
            ControladorBusqueda cBusqueda = new ControladorBusqueda();
            lmProveedores = cBusqueda.buscarProveedores(this.cargarDatosEnModeloProveedor());

            return lmProveedores;
        }
        private List<ModeloPersonas> buscarPersonas(ModeloPersonas pmPersona)
        {
            List<ModeloPersonas> lmPersonas = new List<ModeloPersonas>();
            ControladorBusqueda cBusqueda = new ControladorBusqueda();
            lmPersonas = cBusqueda.buscarPersonas(this.cargarDatosEnModeloPersona());

            return lmPersonas;
        }

        

        private void frmABMEntidad_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmResultadoBusqueda.Close();
        }

        
    }
}
