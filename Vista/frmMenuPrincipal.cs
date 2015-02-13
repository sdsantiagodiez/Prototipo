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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
            //muestro los paneles correspondientes
            //se toman los codigos como siguien:
            //1: Encargado de Reportes
            //2: Encargado de Compras
            //3: Encargado de Ventas
            //4: Encargado de Datos
            // se supone que cada usuario puede tener mas de un rol
            foreach (int rol in rolCollection)
	        {
		        switch (rol)
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
            lblNombreUsuario.Text = nombreUsuario;
            lblFechaLog.Text = DateTime.Today.ToString("dd/MM/yyyy");
            lblHoraLog.Text = DateTime.Now.ToString("HH:mm:ss tt");
            
        }


        private void button3_Click(object sender, EventArgs e)
        {
            frmPedidoClienteNuevo frm2 = new frmPedidoClienteNuevo();
            frm2.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnPedidoProv_Click(object sender, EventArgs e)
        {
            frmPedidoProveedorNuevo frm3 = new frmPedidoProveedorNuevo();
            frm3.ShowDialog();
        }

        private void btnEmitirReporte_Click(object sender, EventArgs e)
        {

        }
    }
}
