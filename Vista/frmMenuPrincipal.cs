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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            lblNombreUsuario.Text = "Usuario TEST";
            lblFechaLog.Text = DateTime.Today.ToString("dd/MM/yyyy");
            lblHoraLog.Text = DateTime.Now.ToString("HH:mm:ss tt");
            timerFechaHora.Enabled = true;
        }

        public frmMenuPrincipal(List<ModeloRoles> roles, ModeloPersonas usuario)
        {
            InitializeComponent();
            
            /*Procedimientos a seguir de acuerdo al rol
            //muestro los paneles correspondientes
            //se toman los codigos como siguien:
            //1: Encargado de Reportes
            //2: Encargado de Compras
            //3: Encargado de Ventas
            //4: Encargado de Datos
            // se supone que cada usuario puede tener mas de un rol
            foreach (ModeloRoles rol in roles)
            {
                int nroRol = rol.codigo;
                switch (nroRol)
                {
                    case 1: pnlER.Visible = true; break;
                    case 2: pnlEC.Visible = true; break;
                    case 3: pnlEV.Visible = true; break;
                    case 4: pnlED.Visible = true; break;
                    default:
                        break;
                }
            }
            *///Procedimientos a seguir de acuerdo al rol. Por ahora sin considerar rol
            
            
            //pnlEC.Visible = true; 
            //        case 3: pnlEV.Visible = true; break;
            //        case 4: pnlED.Visible = true; break;

            //cargo los datos correspondiente al usuario, identificandolo
            lblFechaLog.Text = DateTime.Today.ToString("dd/MM/yyyy");
            lblHoraLog.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }


        private void btnPedidoProv_Click(object sender, EventArgs e)
        {
            frmPedidoProveedorNuevo frmPedidoProv = new frmPedidoProveedorNuevo();
            frmPedidoProv.ShowDialog();
        }

        private void btnEmitirReporte_Click(object sender, EventArgs e)
        {
            frmReporteSeleccion frmReporteSeleccion = new Vista.frmReporteSeleccion();
            frmReporteSeleccion.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            frmPedidoClienteNuevo frmNuevaVenta = new frmPedidoClienteNuevo();
            frmNuevaVenta.ShowDialog();
        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            frmEnConstruccion frmEnConstruccion = new frmEnConstruccion();
            frmEnConstruccion.ShowDialog();
        }

        private void btnDevolucion_Click(object sender, EventArgs e)
        {
            frmDevolucion frmDevolucion = new frmDevolucion();
            frmDevolucion.ShowDialog();
        }

        private void timerFechaHora_Tick(object sender, EventArgs e)
        {
            lblFechaLog.Text = DateTime.Today.ToString("dd/MM/yyyy");
            lblHoraLog.Text = DateTime.Now.ToString("HH:mm:ss tt");
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
    }
}
