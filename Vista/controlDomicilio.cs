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
    public partial class controlDomicilio : UserControl
    {
        public controlDomicilio()
        {
            InitializeComponent();
            this.inicializarControles();
        }

        private void inicializarControles()
        {
            this.inicializarCmbBoxPaises();
            this.inicializarCmbBoxProvincias();
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
            frmMaterialSkinBase.inicializarCmbBox(this.cmbBoxPais);
            //this.cmbBoxPais.SelectedItem = ;
        }
        private void inicializarCmbBoxProvincias()
        {
            if (this.cmbBoxPais.SelectedIndex >= 0)
            {
                this.actualizarCmbBoxProvincias();
            }

            frmMaterialSkinBase.inicializarCmbBox(this.cmbBoxProvincia);
        }
        /// <summary>
        /// Toma los datos de textBoxes y comboBoxes antes de agregar a DataGridView
        /// </summary>
        /// <returns></returns>
        public ModeloDomicilio GetDomicilio()
        {
            if (!this.validarDomicilio())
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
        private bool validarDomicilio()
        {
            if (this.cmbBoxPais.SelectedValue == null || this.cmbBoxProvincia.SelectedValue == null)
            {
                return false;
            }

            if (!Validar.validarInputNoNumerico(this.txtBoxCalle.Text, Constantes.ParametrosBusqueda.Domicilios.Calle))
            {
                return false;
            }

            return true;
        }
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

            this.cmbBoxProvincia.DropDownWidth = frmMaterialSkinBase.getDropDownWidth(this.cmbBoxProvincia);
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

        #endregion
    }
}
