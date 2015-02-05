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
        }


        private void button3_Click(object sender, EventArgs e)
        {
            frmPedidoClienteNuevo frm2 = new frmPedidoClienteNuevo();
            frm2.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPedidoProveedorNuevo frm3 = new frmPedidoProveedorNuevo();
            frm3.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
