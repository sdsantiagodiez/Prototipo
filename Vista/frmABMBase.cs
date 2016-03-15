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
    public partial class frmABMBase : Form
    {
        #region Atributos
        private frmResultadoBusqueda _glb_frm_resultadoBusqueda;
        public frmResultadoBusqueda glb_frm_resultadoBusqueda
        {
            get { return _glb_frm_resultadoBusqueda; }
            set { _glb_frm_resultadoBusqueda = value; }
        }


        protected const string ModoFormularioInicio = "Inicia formulario solo con opcion busqueda";
        protected const string ModoFormularioNuevo = "Nueva clase";
        protected const string ModoFormularioSeleccionado = "Clase seleccionada de resultado de busqueda";

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
                    default:
                        break;
                }
            }
        }

        #endregion

        public frmABMBase()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            //this.inicializarModoFormularioInicio();
        }

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
            toolStripMenuItemBuscar.Enabled = true;
            toolStripMenuItemNuevo.Enabled = true;
            toolStripMenuItemGuardar.Enabled = false;
            toolStripMenuItemGuardarCambios.Enabled = false;
            toolStripMenuItemGuardarNuevo.Enabled = false;
            toolStripMenuItemEliminar.Enabled = false;
            toolStripMenuItemLimpiarCampos.Enabled = true;
            toolStripMenuItemCancelar.Enabled = true;
        }

        virtual public void inicializarModoFormularioNuevo()
        {
            toolStripMenuItemBuscar.Enabled = false;
            toolStripMenuItemNuevo.Enabled = false;
            toolStripMenuItemGuardar.Enabled = true;
            toolStripMenuItemGuardarCambios.Enabled = false;
            toolStripMenuItemGuardarNuevo.Enabled = true;
            toolStripMenuItemEliminar.Enabled = false;
            toolStripMenuItemLimpiarCampos.Enabled = true;
            toolStripMenuItemCancelar.Enabled = true;
        }

        virtual public void inicializarModoFormularioSeleccionado()
        {
            toolStripMenuItemBuscar.Enabled = false;
            toolStripMenuItemNuevo.Enabled = false;
            toolStripMenuItemGuardar.Enabled = true;
            toolStripMenuItemGuardarCambios.Enabled = true;
            toolStripMenuItemGuardarNuevo.Enabled = false;
            toolStripMenuItemEliminar.Enabled = true;
            toolStripMenuItemLimpiarCampos.Enabled = true;
            toolStripMenuItemCancelar.Enabled = true;
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
