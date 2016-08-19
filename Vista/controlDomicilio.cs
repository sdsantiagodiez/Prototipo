using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos;
using LibreriaClasesCompartidas;

namespace Vista
{
    public partial class ControlDomicilio : UserControl
    {
        ErrorProvider epGood = new ErrorProvider();
        ErrorProvider epBad = new ErrorProvider();

        List<bool> glb_lst_respuestasValidaciones;

        public ControlDomicilio()
        {
            InitializeComponent();
            this.inicializarControles();
            this.inicializarValidaciones();
        }

        private void inicializarControles()
        {
            this.inicializarCmbBoxPaises();
            this.inicializarCmbBoxProvincias();
            epGood.Icon = Properties.Resources.success;
            epBad.Icon = Properties.Resources.error;
        }
        private void inicializarCmbBoxPaises()
        {
            //Populo combobox de paises ordenados por nombre de país
            List<ModeloPais> lcl_lst_mod_paises = Controladores.ControladorBusqueda.getPaises();
            List<ComboBoxItem> lcl_lst_cmbBoxItems = new List<ComboBoxItem>();
            foreach (ModeloPais p in lcl_lst_mod_paises.OrderBy(i => i.pais).ToList())
            {
                lcl_lst_cmbBoxItems.Add(new ComboBoxItem() { Name = p.pais, Value = p });
            }

            this.cmbBoxPais.DataSource = lcl_lst_cmbBoxItems;
            frmMaterialSkinBase.InicializarCmbBox(this.cmbBoxPais);
            //this.cmbBoxPais.SelectedItem = ;
        }
        private void inicializarCmbBoxProvincias()
        {
            if (this.cmbBoxPais.SelectedIndex >= 0)
            {
                this.actualizarCmbBoxProvincias();
            }

            frmMaterialSkinBase.InicializarCmbBox(this.cmbBoxProvincia);
        }
        private void inicializarValidaciones()
        {
            glb_lst_respuestasValidaciones = new List<bool>();
            for (int i = 0; i < 6; i++)
            {
                glb_lst_respuestasValidaciones.Add(false);
            }
        }
        /// <summary>
        /// Toma los datos de textBoxes y comboBoxes antes de agregar a DataGridView
        /// </summary>
        /// <returns></returns>
        public ModeloDomicilio GetDomicilio()
        {
            if (!this.validar())
            {
                return null;
                
            }
            ModeloDomicilio lcl_mod_domicilio = new ModeloDomicilio();

            lcl_mod_domicilio.calle = txtBoxCalle.Text;
            lcl_mod_domicilio.numero = txtBoxNumeroDomicilio.Text;
            lcl_mod_domicilio.piso = txtBoxPiso.Text;
            lcl_mod_domicilio.departamento = txtBoxDepartamento.Text;
            lcl_mod_domicilio.codigoPostal = txtBoxCodigoPostal.Text;
            lcl_mod_domicilio.ciudad = txtBoxCiudad.Text;
            lcl_mod_domicilio.provincia = cmbBoxProvincia.SelectedValue as ModeloProvincia;
            lcl_mod_domicilio.pais = cmbBoxPais.SelectedValue as ModeloPais;

            return lcl_mod_domicilio;

        }
        public bool SetDomicilio(ModeloDomicilio p_mod_domicilio)
        {
            if (p_mod_domicilio == null)
            {
                this.txtBoxCalle.Text =
                this.txtBoxNumeroDomicilio.Text =
                this.txtBoxPiso.Text =
                this.txtBoxDepartamento.Text =
                this.txtBoxCiudad.Text =
                this.txtBoxCodigoPostal.Text = "";
                return false; 
            }

            this.txtBoxCalle.Text = p_mod_domicilio.calle;
            this.txtBoxNumeroDomicilio.Text = p_mod_domicilio.numero;
            this.txtBoxPiso.Text = p_mod_domicilio.piso;
            this.txtBoxDepartamento.Text = p_mod_domicilio.departamento;
            this.txtBoxCiudad.Text = p_mod_domicilio.ciudad;
            this.txtBoxCodigoPostal.Text = p_mod_domicilio.codigoPostal;
            this.cmbBoxPais.SelectedValue = p_mod_domicilio.pais;

            this.cmbBoxProvincia.SelectedValue = p_mod_domicilio.provincia;
            return true;
        }
        #region ErrorProviders
        public void clearErrorProviders()
        {
            this.getErrorProvider(true).Clear();
            this.getErrorProvider(false).Clear();
        }
        private void setErrorProvider(Control p_control, bool p_exito, string p_mensaje)
        {
            this.getErrorProvider(p_exito).SetError(p_control, p_mensaje);

            this.getErrorProvider(!p_exito).SetError(p_control, null);
        }
        private ErrorProvider getErrorProvider(bool exito)
        {
            if (exito)
            {
                return epGood;
            }
            else
            {
                return epBad;
            }
        }
        #endregion
        private void actualizarCmbBoxProvincias()
        {
            ModeloPais lcl_mod_paisActual = this.cmbBoxPais.SelectedValue as ModeloPais;
            List<ModeloProvincia> provincias = new List<ModeloProvincia>();
            foreach (ModeloProvincia p in Controladores.ControladorBusqueda.getProvincias())
            {
                if (p.codigoPais == lcl_mod_paisActual.codigo)
                {
                    provincias.Add(p);
                }
            }
            this.cargarDatosProvinciasEnCmbBoxProvincia(provincias);
        }
        #region ComboBox
        private void cargarDatosProvinciasEnCmbBoxProvincia(List<ModeloProvincia> p_lst_mod_provincias)
        {
            List<ComboBoxItem> lcl_lst_cmbBoxItems = new List<ComboBoxItem>();
            foreach (ModeloProvincia p in p_lst_mod_provincias.OrderBy(i => i.provincia).ToList())
            {
                lcl_lst_cmbBoxItems.Add(new ComboBoxItem() { Name = p.provincia,Value = p});
            }
            this.cmbBoxProvincia.DataSource = lcl_lst_cmbBoxItems;

            this.cmbBoxProvincia.DropDownWidth = frmMaterialSkinBase.GetDropDownWidth(this.cmbBoxProvincia);
            if (this.cmbBoxProvincia.Items.Count > 0)
            {
                this.cmbBoxProvincia.SelectedIndex = 0;
            }
            
        }
        #endregion
        #region Eventos
        #region ComboBox
        private void cmbBoxPais_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.actualizarCmbBoxProvincias();  
        }
        #endregion

        #region Leave
        private void txtBoxCalle_Leave(object sender, EventArgs e)
        {
            bool respuesta = Validar.validarInputNoNumerico(txtBoxCalle.Text.ToString(), Constantes.ParametrosBusqueda.Domicilios.Calle);
            glb_lst_respuestasValidaciones[this.getIndex(Constantes.ParametrosBusqueda.Domicilios.Calle)] = respuesta;

            string mensaje = respuesta ? "OK" : "Calle no válida";
            //if (String.IsNullOrWhiteSpace(this.txtBoxCalle.Text))
            //{
            //    mensaje = null;
            //}
            this.setErrorProvider(this.txtBoxCalle,respuesta, mensaje);
            
        }

        private void txtBoxNumeroDomicilio_Leave(object sender, EventArgs e)
        {
            bool respuesta = Validar.validarInputNumerico(txtBoxNumeroDomicilio.Text.ToString(), Constantes.Numericos.EnteroPositivoSinCero);
            glb_lst_respuestasValidaciones[this.getIndex(Constantes.ParametrosBusqueda.Domicilios.NumeroDomicilio)] = respuesta;

            string mensaje = respuesta ? "OK" : "Número de Domicilio no válido";
            //if (String.IsNullOrWhiteSpace(this.txtBoxNumeroDomicilio.Text))
            //{
            //    mensaje = null;
            //}
            this.setErrorProvider(this.txtBoxNumeroDomicilio, respuesta, mensaje);
            
        }

        private void txtBoxPiso_Leave(object sender, EventArgs e)
        {
            bool respuesta = Validar.validarInputNoNumerico(txtBoxPiso.Text.ToString(), Constantes.ParametrosBusqueda.Domicilios.Piso);
            glb_lst_respuestasValidaciones[this.getIndex(Constantes.ParametrosBusqueda.Domicilios.Piso)] = respuesta;
                
            string mensaje = respuesta ? "OK":"Piso no válido";
            if (String.IsNullOrWhiteSpace(this.txtBoxPiso.Text))
            {
                mensaje = null;
            }

            this.setErrorProvider(this.txtBoxPiso, respuesta, mensaje);
        }

        private void txtBoxDepartamento_Leave(object sender, EventArgs e)
        {
            bool respuesta = Validar.validarInputNoNumerico(txtBoxDepartamento.Text.ToString(), Constantes.ParametrosBusqueda.Domicilios.Departamento);
            glb_lst_respuestasValidaciones[this.getIndex(Constantes.ParametrosBusqueda.Domicilios.Departamento)] = respuesta;
            string mensaje = respuesta? "OK": "Departamento no válido";
            if(String.IsNullOrWhiteSpace(this.txtBoxDepartamento.Text))
            {
                mensaje = null;
            }

            this.setErrorProvider(this.txtBoxDepartamento, respuesta, mensaje);
        }

        private void txtBoxCodigoPostal_Leave(object sender, EventArgs e)
        {
            bool respuesta = Validar.validarInputNoNumerico(txtBoxCodigoPostal.Text.ToString(), Constantes.ParametrosBusqueda.Domicilios.CodigoPostal);
            glb_lst_respuestasValidaciones[this.getIndex(Constantes.ParametrosBusqueda.Domicilios.CodigoPostal)] = respuesta;
            string mensaje = respuesta ? "OK" : "Código Postal no válido";

            if (String.IsNullOrWhiteSpace(this.txtBoxCodigoPostal.Text))
            {
                mensaje = null;
            }

            this.setErrorProvider(this.txtBoxCodigoPostal, respuesta, mensaje);
        }

        private void txtBoxCiudad_Leave(object sender, EventArgs e)
        {
            bool respuesta = Validar.validarInputNoNumerico(txtBoxCiudad.Text.ToString(), Constantes.ParametrosBusqueda.Domicilios.Ciudad);
            glb_lst_respuestasValidaciones[this.getIndex(Constantes.ParametrosBusqueda.Domicilios.Ciudad)] = respuesta;
            string mensaje = respuesta?"OK":"Ciudad no válida";
            //if (String.IsNullOrWhiteSpace(this.txtBoxCiudad.Text))
            //{
            //    mensaje = null;
            //}

            this.setErrorProvider(this.txtBoxCiudad, respuesta, mensaje);
        }
        #endregion

        #endregion

        #region Validaciones
        private int getIndex(string p_inputName)
        {
            int index;
            switch (p_inputName)
            {
                case Constantes.ParametrosBusqueda.Domicilios.Calle:
                    index = 0;
                    break;
                case Constantes.ParametrosBusqueda.Domicilios.NumeroDomicilio:
                    index = 1;
                    break;
                case Constantes.ParametrosBusqueda.Domicilios.Piso:
                    index = 2;
                    break;
                case Constantes.ParametrosBusqueda.Domicilios.Departamento:
                    index = 3;
                    break;
                case Constantes.ParametrosBusqueda.Domicilios.CodigoPostal:
                    index = 4;
                    break;
                case Constantes.ParametrosBusqueda.Domicilios.Ciudad:
                    index = 5;
                    break;
                default:
                    index = 0;
                    break;
            }
            return index;
        }
        public bool validar()
        {
            return this.validarDomicilio();
        }
        public bool validarDomicilio()
        {
            if (this.cmbBoxPais.SelectedValue == null || this.cmbBoxProvincia.SelectedValue == null)
            {
                MessageBox.Show("Debe Seleccionar un País y una Provincia");
                return false;
            }

            if (!this.validarInputs())
            {
                return false;
            }

            return true;
        }
        public bool domicilioVacio()
        {
            string todosLosCampos = this.txtBoxCalle.Text + this.txtBoxNumeroDomicilio.Text + this.txtBoxPiso.Text + this.txtBoxDepartamento.Text +
                            this.txtBoxCiudad.Text + this.txtBoxCodigoPostal.Text;
            return String.IsNullOrWhiteSpace(todosLosCampos);
        }
        private bool validarInputs()
        {
            txtBoxCalle_Leave(new object(),new EventArgs());
            txtBoxNumeroDomicilio_Leave(new object(), new EventArgs());
            txtBoxCiudad_Leave(new object(), new EventArgs());
            return (glb_lst_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Domicilios.Calle)]
                & glb_lst_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Domicilios.NumeroDomicilio)]
                & glb_lst_respuestasValidaciones[getIndex(Constantes.ParametrosBusqueda.Domicilios.Ciudad)]);
        }
        #endregion

    }
}
