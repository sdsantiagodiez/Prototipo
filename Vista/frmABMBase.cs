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
        

        virtual public void inicializarModoFormularioInicio()
        {
            toolStripMenuItemBuscar.Enabled = 
                toolStripMenuItemNuevo.Enabled = 
                toolStripMenuItemLimpiarCampos.Enabled = 
                toolStripMenuItemCerrar.Enabled = 
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
                toolStripMenuItemCerrar.Enabled = 
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
                toolStripMenuItemCerrar.Enabled = 
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
                this.toolStripMenuItemCerrar.Enabled = 
                true;
        }
        
        virtual public void inicializarModoFormularioVisualizarEntidad()
        {
            this.toolStripMenuItemEliminar.Enabled =
                this.toolStripMenuItemGuardar.Enabled =
                this.toolStripMenuItemGuardarCambios.Enabled =
                this.toolStripMenuItemNuevo.Enabled =
                this.toolStripMenuItemBuscar.Enabled =
                this.toolStripMenuItemLimpiarCampos.Enabled =
                false;
            this.toolStripMenuItemCerrar.Enabled =
                true;
        }

        virtual public void inicializarModoFormularioClientePedido()
        {
            this.toolStripMenuItemEliminar.Enabled =
                this.toolStripMenuItemGuardarCambios.Enabled =
                
                false;
            this.toolStripMenuItemBuscar.Enabled =
                this.toolStripMenuItemLimpiarCampos.Enabled =
                this.toolStripMenuItemCerrar.Enabled =
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
        virtual public void toolStripMenuItemCerrar_Click(object sender, EventArgs e)
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
