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

        public frmABMEntidad()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            btnAgregarMail.Text = char.ConvertFromUtf32(8595);
            btnQuitarMail.Text = char.ConvertFromUtf32(8593);

            toolStripMenuItemEliminar.Enabled = false;
            toolStripMenuItemGuardar.Enabled = false;


            this.inicializarListViews();

            this.inicializarComboBox();

            this.inicializarCheckedListBox();
        }

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
                row.Cells[9].Value = cmbBoxProvincia.SelectedValue.ToString();
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
        // toolStrip
        //
        #region ToolStripMenuItems
        
        private void toolStripMenuItemBuscar_Click(object sender, EventArgs e)
        {
            string tipoEntidad = this.getTipoEntidad();
            if (tipoEntidad != "")
            {
                DataGridView dgv = new DataGridView();
                switch (tipoEntidad)
                {
                    case TipoEntidadPersona:
                        ModeloPersonas mPersona = this.cargarDatosEnModeloPersona();
                        //this.buscarEntidades(mPersona);
                        List<ModeloPersonas> lmPersonas = new List<ModeloPersonas>();
                        dgv = this.popularDataGridViewBusqueda(this.crearDataGridViewBusqueda(TipoEntidadPersona),lmPersonas);
                        break;
                    case TipoEntidadProveedor:
                        ModeloProveedor mProveedor = this.cargarDatosEnModeloProveedor();
                        //this.buscarEntidades(mProveedor);
                        List<ModeloProveedor> lmProveedor = new List<ModeloProveedor>();
                        dgv = this.popularDataGridViewBusqueda(this.crearDataGridViewBusqueda(TipoEntidadProveedor),lmProveedor);
                        break;
                    default:
                        break;
                }

                Form frmResultadoBusqueda = new Form();
                frmResultadoBusqueda.Text = "Resultado de búsqueda";
                frmResultadoBusqueda.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowOnly;
                frmResultadoBusqueda.AutoSize = true;
                frmResultadoBusqueda.Controls.Add(dgv);
                frmResultadoBusqueda.Show();
            }
            else
            {
                frmMensajeCorto seleccionarTipoEntidad = new frmMensajeCorto("Tipo Entidad", "Debe seleccionar un tipo de entidad para realizar la acción", "fallo");
                seleccionarTipoEntidad.ShowDialog();
            }

        }

        private void toolStripMenuItemNuevo_Click(object sender, EventArgs e)
        {
            this.quitarTextoEnControles(this);
        }
        
        private void toolStripMenuItemEliminar_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItemGuardar_Click(object sender, EventArgs e)
        {

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
            return !(txtBoxTelefono.Text.Trim() == "");
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

        private DataGridView crearDataGridViewBusqueda(string tipoEntidad)
        {
            DataGridView dgv = new DataGridView();
            dgv.AutoGenerateColumns = false;

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

                dgv.Width = 800;
                dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgv.RowHeadersVisible = false;
            }
            return dgv;
        }

        private DataGridView popularDataGridViewBusqueda(DataGridView pdgv, List<ModeloPersonas> plmPersonas)
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
                row.Cells[6].Value = p.domicilios[0].calle + " " + p.domicilios[0].numero;
                row.Cells[7].Value = p.domicilios[0].ciudad;
                row.Cells[8].Value = p.domicilios[0].provincia.provincia;

                pdgv.Rows.Add(row);
            }
            return pdgv;
        }
        private DataGridView popularDataGridViewBusqueda(DataGridView pdgv, List<ModeloProveedor> plmProveedor)
        {
            DataGridViewRow row = (DataGridViewRow)pdgv.Rows[0].Clone();
            foreach (ModeloProveedor p in plmProveedor)
            {
                row = (DataGridViewRow)pdgv.Rows[0].Clone();

                row.Cells[0].Value = "PRO";
                row.Cells[1].Value = p.codigo;
                row.Cells[2].Value = p.cuit;
                row.Cells[3].Value = p.razonSocial;
                row.Cells[4].Value = p.domicilios[0].calle + " " + p.domicilios[0].numero;
                row.Cells[5].Value = p.domicilios[0].ciudad;
                row.Cells[6].Value = p.domicilios[0].provincia.provincia;

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
        /// <returns>"PRO","PER" o "" si no hay entidad seleccionada</returns>
        private string getTipoEntidad()
        {
            string tipoEntidad = "";
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
        /// <returns>"CLI","CON","USR","PRO" o "" si no hay entidad seleccionada</returns>
        private string getTipoPersona()
        {
            string tipoEntidad = "";
            RadioButton rbTipoEntidad = this.getRadioButtonTipoEntidad();
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

        private List<ModeloProveedor> buscarEntidades(ModeloProveedor pmProveedor)
        {
            return this.buscarProveedores(pmProveedor);
        }
        private List<ModeloPersonas> buscarEntidades(ModeloPersonas pmPersona)
        {
            return this.buscarPersonas(pmPersona);
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

            return lModeloDomicilio;
        }
        private List<ModeloTelefono> cargarDatosEnModeloTelefono()
        {
            List<ModeloTelefono> lModeloTelefono = new List<ModeloTelefono>();
            ModeloTelefono mTelefono = new ModeloTelefono();
            foreach (DataGridViewRow row in this.dataGridViewMail.Rows)
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
                
                mTelefono.numero = row.Cells["numero"].Value.ToString();
                mTelefono.tipo = row.Cells["codigoTipo"].Value.ToString();

                lModeloTelefono.Add(mTelefono);
            }
            return lModeloTelefono;
        }
        private List<ModeloMail> cargarDatosEnModeloMail()
        {
            List<ModeloMail> lModeloMail = new List<ModeloMail>();
            ModeloMail mMail = new ModeloMail();
            foreach (DataGridViewRow row in this.dataGridViewMail.Rows)
            {
                mMail = new ModeloMail();
                mMail.codigoMail = Convert.ToInt32(row.Cells["codigoMail"].Value.ToString());
                mMail.mail = row.Cells["mail"].Value.ToString();

                lModeloMail.Add(mMail);
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



    }
}
