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
    public partial class frmNuevoPedido : Form
    {
        public frmNuevoPedido()
        {
            InitializeComponent();
        }

        private void frmNuevoPedido_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            frmEnConstruccion frmCon = new frmEnConstruccion();
            frmCon.ShowDialog();
        }

      
       
      

      
    }
}
