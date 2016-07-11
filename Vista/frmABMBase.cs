using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmABMBase : frmMaterialSkinBase
    {
        #region Atributos
        protected string errorActual;

        protected ErrorProvider errorProviderActual;

        public const string ModoFormularioInicio = "Inicia formulario solo con opcion busqueda";
        public const string ModoFormularioNuevo = "Nueva clase";
        public const string ModoFormularioSeleccionado = "Clase seleccionada de resultado de busqueda";
        public const string ModoFormularioBusqueda = "Búsqueda de entidad";
        public const string ModoFormularioVisualizarEntidad = "Ver detalles de entidad ReadOnly";
        public const string ModoFormularioClientePedido = "Búsqueda y alta de clientes para pedido actual";

        private string _modoFormulario;
        public string modoFormulario
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
                    case ModoFormularioNuevo:
                        this.inicializarModoFormularioNuevo();
                        break;
                    case ModoFormularioSeleccionado:
                        this.inicializarModoFormularioSeleccionado();
                        break;
                    case ModoFormularioBusqueda:
                        this.inicializarModoFormularioBusqueda();
                        break;
                    case ModoFormularioVisualizarEntidad:
                        this.inicializarModoFormularioVisualizarEntidad();
                        break;
                    case ModoFormularioClientePedido:
                        this.inicializarModoFormularioClientePedido();
                        break;
                    default:
                        break;
                }
            }
        }

        #endregion
      
        #region Constructores
        public frmABMBase()
        {
            InitializeComponent();
            
            this.StartPosition = FormStartPosition.CenterScreen;
            errorProviderActual = new ErrorProvider();
            //this.inicializarModoFormularioInicio();
        }
        #endregion

        #region Métodos
        /// <summary>
        /// Limpia todos los controles que se encuentren dentro del control enviado como parámetro
        /// </summary>
        /// <param name="p_ctr_control"></param>
        public void quitarTextoEnControles(Control p_ctr_control)
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

        virtual public void inicializarModoFormularioInicio()
        {
            toolStripMenuItemBuscar.Enabled = 
                toolStripMenuItemNuevo.Enabled = 
                toolStripMenuItemLimpiarCampos.Enabled = 
                toolStripMenuItemCancelar.Enabled = 
                true;
            toolStripMenuItemGuardar.Enabled = 
                toolStripMenuItemGuardarCambios.Enabled = 
                toolStripMenuItemGuardarNuevo.Enabled = 
                toolStripMenuItemEliminar.Enabled = 
                false;
            
        }

        virtual public void inicializarModoFormularioNuevo()
        {
            toolStripMenuItemBuscar.Enabled = 
                toolStripMenuItemNuevo.Enabled = 
                toolStripMenuItemGuardarCambios.Enabled = 
                toolStripMenuItemEliminar.Enabled = 
                false;
            toolStripMenuItemGuardar.Enabled = 
                toolStripMenuItemGuardarNuevo.Enabled = 
                toolStripMenuItemLimpiarCampos.Enabled = 
                toolStripMenuItemCancelar.Enabled = 
                true;
        }

        virtual public void inicializarModoFormularioSeleccionado()
        {
            toolStripMenuItemBuscar.Enabled = 
                toolStripMenuItemNuevo.Enabled =
                toolStripMenuItemGuardarNuevo.Enabled = 
                false;
            toolStripMenuItemGuardar.Enabled = 
                toolStripMenuItemGuardarCambios.Enabled = 
                toolStripMenuItemEliminar.Enabled = 
                toolStripMenuItemLimpiarCampos.Enabled = 
                toolStripMenuItemCancelar.Enabled = 
                true;
        }

        virtual public void inicializarModoFormularioBusqueda()
        {
            this.toolStripMenuItemEliminar.Enabled =
                this.toolStripMenuItemGuardar.Enabled =
                this.toolStripMenuItemGuardarCambios.Enabled = 
                this.toolStripMenuItemNuevo.Enabled =
                false;
            this.toolStripMenuItemBuscar.Enabled =
                this.toolStripMenuItemLimpiarCampos.Enabled =
                this.toolStripMenuItemCancelar.Enabled = 
                true;
        }
        
        virtual public void inicializarModoFormularioVisualizarEntidad()
        {
            this.toolStripMenuItemEliminar.Enabled =
                this.toolStripMenuItemGuardar.Enabled =
                this.toolStripMenuItemGuardarCambios.Enabled =
                this.toolStripMenuItemNuevo.Enabled =
                false;
            this.toolStripMenuItemBuscar.Enabled =
                this.toolStripMenuItemLimpiarCampos.Enabled =
                this.toolStripMenuItemCancelar.Enabled =
                false;
        }

        virtual public void inicializarModoFormularioClientePedido()
        {
            this.toolStripMenuItemEliminar.Enabled =
                this.toolStripMenuItemGuardarCambios.Enabled =
                
                false;
            this.toolStripMenuItemBuscar.Enabled =
                this.toolStripMenuItemLimpiarCampos.Enabled =
                this.toolStripMenuItemCancelar.Enabled =
                this.toolStripMenuItemNuevo.Enabled =
                this.toolStripMenuItemGuardar.Enabled =
                this.toolStripMenuItemGuardarNuevo.Enabled =
                true;
        }

        /// <summary>
        /// Elimina icono de error al lado del control
        /// </summary>
        /// <param name="c">Control que contiene los textboxes con errorProviders asignados</param>
        protected void inicializarErrorProvider(Control c)
        {
            foreach (TextBox t in c.Controls.OfType<TextBox>())
            {
                errorProviderActual.SetError(t, "");
            }
        }

        #endregion

        #region Eventos
        virtual public void toolStripMenuItemCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        virtual public void toolStripMenuItemLimpiarCampos_Click(object sender, EventArgs e)
        {

        }

        virtual public void toolStripMenuItemEliminar_Click(object sender, EventArgs e)
        {

        }

        virtual public void toolStripMenuItemGuardar_Click(object sender, EventArgs e)
        {

        }

        virtual public void toolStripMenuItemGuardarNuevo_Click(object sender, EventArgs e)
        {

        }

        virtual public void toolStripMenuItemGuardarCambios_Click(object sender, EventArgs e)
        {

        }

        virtual public void toolStripMenuItemNuevo_Click(object sender, EventArgs e)
        {

        }

        virtual public void toolStripMenuItemBuscar_Click(object sender, EventArgs e)
        {

        }
        #endregion      

    }
}
