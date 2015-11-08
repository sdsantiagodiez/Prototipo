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
    public partial class frmPedidoProveedorCierre : Form
    {
        public frmPedidoProveedorCierre()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmEnConstruccion frmConstruccion = new frmEnConstruccion();
            frmConstruccion.ShowDialog();
        }

        internal void detalleVenta(Controladores.ControladorPedidoProveedor ctrlPedProv)
        {
            throw new NotImplementedException();
        }

        public bool emitido { get; set; }
    }
}
