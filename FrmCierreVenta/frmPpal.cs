using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmCierreVenta
{
    public partial class frmPpal : Form
    {
        public frmPpal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDevolucion frm1 = new frmDevolucion();
            frm1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmNewVenta frm2 = new frmNewVenta();
            frm2.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmNuevoPedido frm3 = new frmNuevoPedido();
            frm3.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmReserva frm4 = new frmReserva();
            frm4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
