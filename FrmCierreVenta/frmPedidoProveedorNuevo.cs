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
    public partial class frmPedidoProveedorNuevo : Form
    {
        public frmPedidoProveedorNuevo()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            frmPedidoProveedorCierre frmContinuar = new frmPedidoProveedorCierre();
            frmContinuar.ShowDialog();
        }
    }
}
