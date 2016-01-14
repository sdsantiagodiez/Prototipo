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

        private void btnBuscarArticuloProveedor_Click(object sender, EventArgs e)
        {
            frmResultadoBusqueda lcl_frm_resultadoBusqueda = new frmResultadoBusqueda();
            Modelos.ModeloArticuloProveedores lcl_mod_articuloProveedor = new Modelos.ModeloArticuloProveedores();

            lcl_mod_articuloProveedor.codigoOriginal = txtBoxCodigo.Text;
            lcl_mod_articuloProveedor.codigoArticuloProveedor = txtBoxCodigoArticuloProveedor.Text;
            lcl_mod_articuloProveedor.descripcionArticuloProveedor = txtBoxDescripcionArticuloProveedor.Text;
            lcl_mod_articuloProveedor.codigoEntidad = txtBoxCodigoEntidadProveedor.Text == "" ? 0 : Convert.ToInt32(txtBoxCodigoEntidadProveedor.Text);
            lcl_mod_articuloProveedor.razonSocialProveedor = txtBoxRazonSocialProveedor.Text;

            //lcl_frm_resultadoBusqueda.mostrarBusqueda(lcl_mod_articuloProveedor);
        }
    }
}
