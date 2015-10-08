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
    public partial class frmABMPersona : Form
    {
        public frmABMPersona()
        {
            InitializeComponent();
            tbPageDatos.Text = "Datos";
            tbPagePermisos.Text = "Permisos";
            btnAgregarMail.Text = char.ConvertFromUtf32(8595);
            btnQuitarMail.Text = char.ConvertFromUtf32(8593);
        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
