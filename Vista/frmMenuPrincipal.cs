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
    public partial class frmMenuPrincipal : frmMaterialSkinBase
    {
        Point glb_localizacion = new System.Drawing.Point(224, 124);
        Form glb_form;
        #region Constructores
        public frmMenuPrincipal()
        {
            InitializeComponent();

            this.inicializarForm();
            this.MinimizeBox = true;
            this.MaximizeBox = true;
        }

        public frmMenuPrincipal(ModeloUsuario usuarioActual) : this()
        {
            if (this.inicializarModoFormulario(usuarioActual))
            {
                lblNombreUsuario.Text = usuarioActual.usuario ;
            }
            else 
            {
                MessageBox.Show("El usuario actual no posee roles asignados. Contacte al administrador.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Métodos

        #region Inicialización
        private Point ubicacionPrincipal;
        private void frmMenuPrincipal_Move(object sender, EventArgs e)
        {
            this.Location = ubicacionPrincipal;
        }
        private bool inicializarModoFormulario(ModeloUsuario p_mod_usuario)
        {
            this.inicializarModoAdmin(false);

            if(p_mod_usuario.roles.Count == 0)
            { return false; }
            
            foreach (ModeloRoles r in p_mod_usuario.roles)
            {
                switch (r.descripcion)
                {
                    case Constantes.TipoRoles.Admin:
                        this.inicializarModoAdmin(true);
                        return true;
                    case Constantes.TipoRoles.Compras:
                        this.inicializarModoCompras(true);
                        break;
                    case Constantes.TipoRoles.Ventas:
                        this.inicializarModoVentas(true);
                        break;
                    case Constantes.TipoRoles.Datos_Reportes:
                        this.inicializarModoReportes(true);
                        break;
                    case Constantes.TipoRoles.Datos_ABM:
                        this.inicializarModoABM(true);
                        break;
                    default:
                        break;
                }
            }
            return true;
        }

        private void inicializarModoAdmin(bool inicializar)
        {
            this.inicializarModoABM(inicializar);
            this.inicializarModoCompras(inicializar);
            this.inicializarModoVentas(inicializar);
            this.inicializarModoReportes(inicializar);
        }
        private void inicializarModoCompras(bool inicializar)
        {
          //  this.inicializarControles(inicializar, pnlCompras);
        }
        private void inicializarModoVentas(bool inicializar)
        {
           // this.inicializarControles(inicializar, pnlVentas);
        }
        private void inicializarModoReportes(bool inicializar)
        {
           // this.inicializarControles(inicializar, pnlReportes);
        }
        private void inicializarModoABM(bool inicializar)
        {
            // this.inicializarControles(inicializar, pnlABM);
        }
        
        private void inicializarControles(bool inicializar, Control controlContenedor)
        {
            foreach (Control c in controlContenedor.Controls)
            {
                c.Enabled = inicializar;
            }
        }

        private void inicializarForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
            //Width = 1280;
            //Height = 1280;
            
            this.ubicacionPrincipal = this.Location;
            this.tblLayoutPanelPrincipal.Location = new Point(3, 60);
            this.tblLayoutPanelPrincipal.Height = Height - 60; // 60 pixeles para que se vea título de ventana principal
            this.tblLayoutPanelPrincipal.Width = Width -3; //un margen derecho de 3
        }
        #endregion

        private void agregarFormulario(Form p_form)
        {
            Type T = p_form.GetType();
            
            foreach (Type t in T.Assembly.GetTypes())
            {//Chequea si hereda de frmMaterialSkinBase
                if (t == typeof(frmMaterialSkinBase))
                {
                    p_form.TopLevel = false;
                    p_form.Dock = DockStyle.Fill;
                    this.pnlContenedorForm.Controls.Add(p_form);
                    p_form.Show();
                    (p_form as frmMaterialSkinBase).inicializarForm(this.pnlContenedorForm.Width, this.pnlContenedorForm.Height);
                    return;
                }    
            }
        }

        private bool validarAgregarFormulario(Type T)
        {
            if(glb_form == null )
            {
                return true;
            }
            else if (glb_form.GetType() != T)
            {
                glb_form.Close();
                //Mensaje para confirmar que si cierre se pierde el progreso hecho en el form 
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Eventos

        #region Button
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Timer
        private void timerFechaHora_Tick(object sender, EventArgs e)
        {
            lblFechaLog.Text = DateTime.Today.ToString("dd/MM/yyyy");
            lblHoraLog.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }
        #endregion

        #region ToolStripMenuItem
        private void tsmi_ABMentidades_Click(object sender, EventArgs e)
        {
            if (!this.validarAgregarFormulario(typeof(frmABMEntidad)))
            {
                return;
            }
            
            glb_form = new frmABMEntidad();
            
            this.agregarFormulario(glb_form);
        }
        private void tsmi_ABMarticulos_Click(object sender, EventArgs e)
        {
            if (!this.validarAgregarFormulario(typeof(frmABMArticulo)))
            {
                return;
            }

            glb_form = new frmABMArticulo();
            this.agregarFormulario(glb_form);
        }

        private void tsmi_ABMarticulosProveedor_Click(object sender, EventArgs e)
        {
            if (!this.validarAgregarFormulario(typeof(frmABMArticuloProveedor)))
            {
                return;
            }

            glb_form = new frmABMArticuloProveedor();
            this.agregarFormulario(glb_form);
        }
        

        private void tsmi_ABMdescuentos_Click(object sender, EventArgs e)
        {
            if (!this.validarAgregarFormulario(typeof(frmDescuentosArticulos)))
            {
                return;
            }

            glb_form = new frmDescuentosArticulos();
            this.agregarFormulario(glb_form);
        }
        #endregion
   
        #region toolStripButton
        private void toolStripbtnPedidoCliente_Click(object sender, EventArgs e)
        {
            if (!this.validarAgregarFormulario(typeof(frmPedidoCierre)))
            {
                if ((glb_form as frmPedidoCierre).getCodigoTipoPedido() == Constantes.CodigosTiposPedidos.TipoPedidoPersona)
                {
                    return;
                }
            }

            if (glb_form != null && glb_form.GetType() == typeof(frmPedidoCierre) && (glb_form as frmPedidoCierre).getCodigoTipoPedido() == Constantes.CodigosTiposPedidos.TipoPedidoProveedor)
            {
                glb_form.Close();
            }

            glb_form = new frmPedidoCierre(new ModeloPedido() {codigoTipoPedido = Constantes.CodigosTiposPedidos.TipoPedidoPersona });
            this.agregarFormulario(glb_form);
        }

        private void toolStripbtnPedidoProveedor_Click(object sender, EventArgs e)
        {
            if (!this.validarAgregarFormulario(typeof(frmPedidoCierre)))
            {
                if ((glb_form as frmPedidoCierre).getCodigoTipoPedido() == Constantes.CodigosTiposPedidos.TipoPedidoProveedor)
                {
                    return;
                }
            }
            if (glb_form != null && glb_form.GetType() == typeof(frmPedidoCierre) && (glb_form as frmPedidoCierre).getCodigoTipoPedido() == Constantes.CodigosTiposPedidos.TipoPedidoPersona)
            {
                glb_form.Close();
            }
            
            glb_form = new frmPedidoCierre(new ModeloPedido() { codigoTipoPedido = Constantes.CodigosTiposPedidos.TipoPedidoProveedor });
            this.agregarFormulario(glb_form);
        }

        private void tlsbtnDevolucion_Click(object sender, EventArgs e)
        {
            if (!this.validarAgregarFormulario(typeof(frmPedidoDevolucion)))
            {
                return;
            }

            glb_form = new frmPedidoDevolucion();
            this.agregarFormulario(glb_form);
        }

        private void toolStripbtnFacturacion_Click(object sender, EventArgs e)
        {
            if (!this.validarAgregarFormulario(typeof(frmFacturacionMasiva)))
            {
                return;
            }

            glb_form = new frmFacturacionMasiva();
            this.agregarFormulario(glb_form);
        }

        private void toolStripbtnReportes_Click(object sender, EventArgs e)
        {
            if (!this.validarAgregarFormulario(typeof(frmReporteSeleccion)))
            {
                return;
            }

            glb_form = new frmReporteSeleccion();
            this.agregarFormulario(glb_form);
        }
        #endregion

        #endregion
    }

    //clase para llenar combo box categoria a buscar
    class ComboBoxItem
    {
        public string Name { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
