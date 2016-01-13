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
    public partial class frmABMArticulos : Form
    {
        public frmABMArticulos()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmResultadoBusqueda lcl_frm_resultadoBusqueda = new frmResultadoBusqueda();
            Modelos.ModeloArticulos lcl_mod_articulo = new Modelos.ModeloArticulos();
            lcl_mod_articulo.codigoOriginal = txtBoxCodigo.Text;
            lcl_mod_articulo.descripcion = txtBoxDescripcion.Text;

            lcl_frm_resultadoBusqueda.mostrarBusqueda(lcl_mod_articulo);
        }
    }
}
