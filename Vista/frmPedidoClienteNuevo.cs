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
    public partial class frmPedidoClienteNuevo : Form
    {
        public frmPedidoClienteNuevo()
        {
            InitializeComponent();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            frmPedidoClienteCierre frmCierre = new frmPedidoClienteCierre();
            frmCierre.ShowDialog();
        }
    }
}
