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
    public partial class frmMenuPrincipal : Form
    {
        #region Constructores
        public frmMenuPrincipal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
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
            this.inicializarControles(inicializar, pnlCompras);
        }
        private void inicializarModoVentas(bool inicializar)
        {
            this.inicializarControles(inicializar, pnlVentas);
        }
        private void inicializarModoReportes(bool inicializar)
        {
            this.inicializarControles(inicializar, pnlReportes);
        }
        private void inicializarModoABM(bool inicializar)
        {
            this.inicializarControles(inicializar, pnlABM);
        }
        
        private void inicializarControles(bool inicializar, Control controlContenedor)
        {
            foreach (Control c in controlContenedor.Controls)
            {
                c.Enabled = inicializar;
            }
        }
        #endregion
        
        #endregion

        #region Eventos

        #region Button
        private void btnEmitirReporte_Click(object sender, EventArgs e)
        {
            frmReporteSeleccion frmReporteSeleccion = new Vista.frmReporteSeleccion();
            frmReporteSeleccion.ShowDialog();
        }

        private void btnPedidoProveedor_Click(object sender, EventArgs e)
        {
            frmPedidoNuevo frmPedidoProv = new frmPedidoNuevo(Constantes.CodigosTiposPedidos.TipoPedidoProveedor);
            frmPedidoProv.ShowDialog();
            if (frmPedidoProv.DialogResult != System.Windows.Forms.DialogResult.Ignore)
            {
                frmPedidoCierre lcl_frm_cierre = new frmPedidoCierre(frmPedidoProv.controlador.pedidoActual);
                lcl_frm_cierre.ShowDialog();
            }
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            frmPedidoNuevo frmNuevaVenta = new frmPedidoNuevo(Constantes.CodigosTiposPedidos.TipoPedidoPersona);
            frmNuevaVenta.ShowDialog();
            if (frmNuevaVenta.DialogResult != System.Windows.Forms.DialogResult.Ignore)
            {
                frmPedidoCierre lcl_frm_cierre = new frmPedidoCierre(frmNuevaVenta.controlador.pedidoActual);
                lcl_frm_cierre.ShowDialog();
            }
        }

        private void btnDevolucion_Click(object sender, EventArgs e)
        {
            frmPedidoDevolucion frmDevolucion = new frmPedidoDevolucion(Controladores.ControladorBusqueda.buscar(new ModeloPedido() { numeroPedido = 141 }, Constantes.ParametrosBusqueda.Pedidos.NumeroPedido)[0]);
            //frmPedidoDevolucion frmDevolucion = new frmPedidoDevolucion();
            
            frmDevolucion.ShowDialog();
            if (frmDevolucion.DialogResult != System.Windows.Forms.DialogResult.Ignore)
            {
                frmPedidoCierre lcl_frm_cierre = new frmPedidoCierre(frmDevolucion.controlador.pedidoActual);
                lcl_frm_cierre.ShowDialog();
            }
        }

        private void btnABM_Click(object sender, EventArgs e)
        {
            //Calcula si muestra el menuStrip no tiene lugar hacia abajo, hace que aparezca por sobre el botón
            Point screenPoint = btnABM.PointToScreen(new Point(btnABM.Left, btnABM.Bottom));
            if (screenPoint.Y + cntxtMenuStripABM.Size.Height > Screen.PrimaryScreen.WorkingArea.Height)
            {
                cntxtMenuStripABM.Show(btnABM, new Point(0, -cntxtMenuStripABM.Size.Height));
            }
            else
            {
                cntxtMenuStripABM.Show(btnABM, new Point(0, btnABM.Height));
            }
        }

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
        private void entidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmABMEntidad lcl_frm_ABMEntidad = new frmABMEntidad();
            lcl_frm_ABMEntidad.ShowDialog();
        }

        private void artículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmABMArticulo lcl_frm_ABMArticulo = new frmABMArticulo();
            lcl_frm_ABMArticulo.ShowDialog();
        }

        private void artículosDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmABMArticuloProveedor lcl_frm_ABMArticuloProveedor = new frmABMArticuloProveedor();
            lcl_frm_ABMArticuloProveedor.ShowDialog();
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
