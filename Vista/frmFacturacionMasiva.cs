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
    public partial class frmFacturacionMasiva : Form
    {
        public frmFacturacionMasiva()
        {
            InitializeComponent();
        }

        private void parámetrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPreferenciasFacturacion frmPreferences = new frmPreferenciasFacturacion();
            frmPreferences.ShowDialog();
        }

     
    }
}
