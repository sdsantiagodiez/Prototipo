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
    public partial class frmDevolucion : Form
    {
        public frmDevolucion()
        {
            InitializeComponent();
        }

        private void frmDevolucion_Load(object sender, EventArgs e)
        {
            
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            frmEnConstruccion frmCons = new frmEnConstruccion();
            frmCons.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        
    }
}
