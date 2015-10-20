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

            //tblLayoutPanelExtra
            this.inicializarListViews();   
        }

        void inicializarListViews()
        {

            lstViewMail.Columns.Add("Mail", -2, System.Windows.Forms.HorizontalAlignment.Center);
            lstViewMail.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            lstViewMail.View = View.Details;

            //ver de modificar la barra horizontal cuando hay más de dos items
            lstViewNumeroTelefono.Columns.Add("TIPO",-2, System.Windows.Forms.HorizontalAlignment.Center);
            lstViewNumeroTelefono.Columns.Add("N", -2, System.Windows.Forms.HorizontalAlignment.Right);
            lstViewNumeroTelefono.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            lstViewNumeroTelefono.View = View.Details;
        }
        
        void quitarTextoEnControles(Control con)
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
                    
                if(bandera)
                    quitarTextoEnControles(c);
                
            }
        }

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
            //#region Pestaña Extra
            //// 
            //// grpBoxDatosUsuario
            //// 
            //grpBoxDatosUsuario.Controls.Add(panel1);
            //grpBoxDatosUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //grpBoxDatosUsuario.Location = new System.Drawing.Point(3, 17);
            //grpBoxDatosUsuario.Name = "grpBoxDatosUsuario";
            //grpBoxDatosUsuario.Size = new System.Drawing.Size(612, 229);
            //grpBoxDatosUsuario.TabIndex = 10;
            //grpBoxDatosUsuario.TabStop = false;
            //grpBoxDatosUsuario.Text = "Datos Usuario";
            //// 
            //// pnlDatosUsuario
            //// 
            //pnlDatosUsuario.Controls.Add(lblRepetirContraseña);
            //pnlDatosUsuario.Controls.Add(checkedListBoxRol);
            //pnlDatosUsuario.Controls.Add(txtBoxUsuario);
            //pnlDatosUsuario.Controls.Add(lblUsuario);
            //pnlDatosUsuario.Controls.Add(txtBoxContraseña);
            //pnlDatosUsuario.Controls.Add(lblContraseña);
            //pnlDatosUsuario.Controls.Add(txtBoxConfirmarContraseña);
            //pnlDatosUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            //pnlDatosUsuario.Location = new System.Drawing.Point(3, 20);
            //pnlDatosUsuario.Name = "pnlDatosUsuario";
            //pnlDatosUsuario.Size = new System.Drawing.Size(606, 206);
            //pnlDatosUsuario.TabIndex = 0;
            //// 
            //// txtBoxUsuario
            //// 
            //txtBoxUsuario.Enabled = false;
            //txtBoxUsuario.Location = new System.Drawing.Point(319, 8);
            //txtBoxUsuario.Name = "txtBoxUsuario";
            //txtBoxUsuario.Size = new System.Drawing.Size(113, 24);
            //txtBoxUsuario.TabIndex = 8;
            //// 
            //// txtBoxContraseña
            //// 
            //txtBoxContraseña.Enabled = false;
            //txtBoxContraseña.Location = new System.Drawing.Point(319, 39);
            //txtBoxContraseña.Name = "txtBoxContraseña";
            //txtBoxContraseña.Size = new System.Drawing.Size(113, 24);
            //txtBoxContraseña.TabIndex = 7;
            //// 
            //// txtBoxConfirmarContraseña
            //// 
            //txtBoxConfirmarContraseña.Enabled = false;
            //txtBoxConfirmarContraseña.Location = new System.Drawing.Point(319, 69);
            //txtBoxConfirmarContraseña.Name = "txtBoxConfirmarContraseña";
            //txtBoxConfirmarContraseña.Size = new System.Drawing.Size(113, 24);
            //txtBoxConfirmarContraseña.TabIndex = 6;
            //// 
            //// lblUsuario
            //// 
            //lblUsuario.AutoSize = true;
            //lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //lblUsuario.Location = new System.Drawing.Point(160, 7);
            //lblUsuario.Name = "lblUsuario";
            //lblUsuario.Size = new System.Drawing.Size(60, 18);
            //lblUsuario.TabIndex = 3;
            //lblUsuario.Text = "Usuario";
            //// 
            //// lblContraseña
            //// 
            //lblContraseña.AutoSize = true;
            //lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //lblContraseña.Location = new System.Drawing.Point(160, 38);
            //lblContraseña.Name = "lblContraseña";
            //lblContraseña.Size = new System.Drawing.Size(85, 18);
            //lblContraseña.TabIndex = 4;
            //lblContraseña.Text = "Contraseña";
            //// 
            //// lblRepetirContraseña
            //// 
            //lblRepetirContraseña.AutoSize = true;
            //lblRepetirContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //lblRepetirContraseña.Location = new System.Drawing.Point(160, 68);
            //lblRepetirContraseña.Name = "lblRepetirContraseña";
            //lblRepetirContraseña.Size = new System.Drawing.Size(155, 18);
            //lblRepetirContraseña.TabIndex = 5;
            //lblRepetirContraseña.Text = "Confirmar Contraseña";
            //// 
            //// checkedListBoxRol
            //// 
            //checkedListBoxRol.BackColor = System.Drawing.SystemColors.Control;
            //checkedListBoxRol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            //checkedListBoxRol.CheckOnClick = true;
            //checkedListBoxRol.Enabled = false;
            //checkedListBoxRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //checkedListBoxRol.FormattingEnabled = true;
            //checkedListBoxRol.Items.AddRange(new object[] {
            //        "Encargado de Reportes",
            //        "Encargado de Compras",
            //        "Encargado de Ventas",
            //        "Encargado de Datos"});
            //checkedListBoxRol.Location = new System.Drawing.Point(187, 121);
            //checkedListBoxRol.Name = "checkedListBoxRol";
            //checkedListBoxRol.Size = new System.Drawing.Size(213, 114);
            //checkedListBoxRol.TabIndex = 0;
            //#endregion

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
        // button
        //
        private void btnMasDatos_Click(object sender, EventArgs e)
        {
            if (radioButtonProveedor.Checked)
            { 
            }

            if (radioButtonContactoProveedor.Checked)
            { 
            }

            if (radioButtonUsuario.Checked)
            { 
            }
        }     

        private void btnAgregarMail_Click(object sender, EventArgs e)
        {
            
            ModeloMail mMail = new ModeloMail();
            //Agregar validación por si el mail ya esta incluido
            if (mMail.validarMail(txtBoxMail.Text))
            {
                ListViewItem mail = new ListViewItem(txtBoxMail.Text);
                lstViewMail.Items.Add(mail);
            }
            else
            {
                frmMensajeCorto mensaje = new frmMensajeCorto("Error", "El formato de mail ingresado no es válido", "fallo");
                mensaje.ShowDialog();
            }
        }
        
        private void btnQuitarMail_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstViewMail.SelectedItems)
            {
                lstViewMail.Items.Remove(item);
            }
        }
 
        private void btnAgregarNumeroTelefono_Click(object sender, EventArgs e)
        {
            //Validar numero
            
            ListViewItem numero = new ListViewItem(new string[] {(string)cmbBoxTipoNumeroTelefono.Text, txtBoxNumeroTelefono.Text});
           
            lstViewNumeroTelefono.Items.Add(numero);
        }

        private void btnQuitarNumeroTelefono_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lstViewNumeroTelefono.SelectedItems)
            {
                lstViewNumeroTelefono.Items.Remove(item);
            }
        }

        private void btnAgregarDireccion_Click(object sender, EventArgs e)
        {
            //Validar datos
            DataGridViewRow row = (DataGridViewRow)dataGridViewDireccion.Rows[0].Clone();
            row.Cells[0].Value = txtBoxCalle.Text;
            row.Cells[1].Value = txtBoxNumeroDomicilio.Text;
            row.Cells[2].Value = txtBoxPiso.Text;
            row.Cells[3].Value = txtBoxDepartamento.Text;
            row.Cells[4].Value = txtBoxCodigoPostal.Text;
            row.Cells[5].Value = txtBoxCiudad.Text;
            row.Cells[6].Value = cmbBoxProvincia.Text;
            dataGridViewDireccion.Rows.Add(row);
        }

        private void btnQuitarDireccion_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridViewDireccion.SelectedRows)
            {
                if (!item.IsNewRow)
                {
                    dataGridViewDireccion.Rows.RemoveAt(item.Index);
                }
            }
        }
        //
        // toolStrip
        //
        private void toolStripMenuItemNuevo_Click(object sender, EventArgs e)
        {
            this.quitarTextoEnControles(this);
        }

        private void toolStripMenuItemCancelar_Click(object sender, EventArgs e)
        {
            frmMensajeCorto confirmarCancelar = new frmMensajeCorto("Confirmación", "¿Esta seguro que desea cancelar y salir de esta ventana?", "confirmacion");
            confirmarCancelar.ShowDialog();
        }

        private void toolStripMenuItemBuscar_Click(object sender, EventArgs e)
        {
            string tipoEntidad = this.getTipoEntidad();
            if (tipoEntidad != "")
            {
                switch (tipoEntidad)
                {
                    case TipoEntidadPersona:
                        ModeloPersonas mPersona = this.cargarDatosEnModeloPersona();
                        this.buscarEntidades(mPersona);
                        break;
                    case TipoEntidadProveedor:
                        ModeloProveedor mProveedor = this.cargarDatosEnModeloProveedor();
                        this.buscarEntidades(mProveedor);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                frmMensajeCorto seleccionarTipoEntidad = new frmMensajeCorto("Tipo Entidad", "Debe seleccionar un tipo de entidad para realizar la acción", "fallo");
                seleccionarTipoEntidad.ShowDialog();
            }
            
        }
        #endregion

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
                case TipoPersonaCliente: case TipoPersonaContactoDeProveedor: case TipoPersonaUsuario:
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
            return lmProveedores;
        }
        private List<ModeloPersonas> buscarPersonas(ModeloPersonas pmPersona)
        {
            List<ModeloPersonas> lmPersonas = new List<ModeloPersonas>();
            return lmPersonas;
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

            mPersona.tipoPersona = this.getTipoPersona();
            mPersona.dni = txtBoxDNI.Text;
            mPersona.apellido = txtBoxApellido.Text;
            mPersona.nombre = txtBoxNombre.Text;
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
            mEntidad.codigo = Convert.ToInt32(txtBoxCodigoEntidad.Text);
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
            if (dataGridViewDireccion.RowCount == 0)
            {
                mDomicilio.calle = txtBoxCalle.Text;
                mDomicilio.numero = txtBoxNumeroDomicilio.Text;
                mDomicilio.piso = txtBoxPiso.Text;
                mDomicilio.departamento = txtBoxDepartamento.Text;
                mDomicilio.ciudad = txtBoxCiudad.Text;
                mDomicilio.codigoPostal = txtBoxCodigoPostal.Text;
                
                //REVISAR VER CODIGO DE COMBOBOX
                mDomicilio.provincia.provincia = cmbBoxProvincia.SelectedValue.ToString();
                mDomicilio.pais.pais = cmbBoxPais.SelectedValue.ToString();


                lModeloDomicilio.Add(mDomicilio);
            }
            else
            {
                foreach (DataGridViewRow row in dataGridViewDireccion.Rows)
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
                    
                    mDomicilio.codigoDomicilio = Convert.ToInt32(row.Cells["codigoDomicilio"].Value.ToString());
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
            return lModeloTelefono;
        }
        private List<ModeloMail> cargarDatosEnModeloMail()
        {
            List<ModeloMail> lModeloMail = new List<ModeloMail>();
            return lModeloMail;
        }

        private void cargarDatosEnCmbBoxProvincia(List<ModeloProvincia> pLProvincias)
        {
            
        }
        private void cargaDatosEnCmbBoxPais(List<ModeloPais> pLPais)
        {
 
        }
    }
}
