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
        }

        public frmMenuPrincipal(List<ModeloRoles> roles, ModeloPersonas usuario)
        {
            InitializeComponent();
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

            //cargo los datos correspondiente al usuario, identificandolo
            lblNombreUsuario.Text = usuario.nombre;
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

        }

        private void btnDevolucion_Click(object sender, EventArgs e)
        {

        }

        private void btnAltBajMod_Click(object sender, EventArgs e)
        {

        }
    }
}
