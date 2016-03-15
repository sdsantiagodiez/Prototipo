using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos;

namespace Vista
{
    public partial class frmABMRaiz : Form
    {
        public frmABMRaiz(/*List<ModeloRoles> rolCollection*/)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            //si es encargado de datos muestro el panel
            //como en frmMenuPrincipal, el codigo del rol de ED es 4
           // la validacion se encuentra en el frmMenuPrincipal
            /* foreach (ModeloRoles rol in rolCollection)
            {
                int nroRol = rol.getCodRol();
                if (nroRol == 4)
	            {
                    pnlED.Visible = true;
	            }
            }*/
        }

        
        private void btnEntidades_Click(object sender, EventArgs e)
        {
            frmABMEntidad frmABMEntidad = new frmABMEntidad();
            frmABMEntidad.ShowDialog();
        }

        private void btnAltaArtic_Click(object sender, EventArgs e)
        {
            frmABMArticulo fa = new frmABMArticulo();
            fa.ShowDialog();
        }

        private void btnAltaArticProv_Click(object sender, EventArgs e)
        {
            frmABMArticuloProveedor lcl_frm_ABMArticuloProveedor = new frmABMArticuloProveedor();
            lcl_frm_ABMArticuloProveedor.ShowDialog();
        }
    }
}
