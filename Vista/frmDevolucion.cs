using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladores;
using Modelos;
using LibreriaClasesCompartidas;

namespace Vista
{
    public partial class frmDevolucion : Form
    {

        ModeloArticuloProveedores glb_mod_articuloDevolucion;


        public frmDevolucion()
        {
            InitializeComponent();
        }

        #region Botones

        private void btnValidar_Click(object sender, EventArgs e)
        {
            //[insertar proceso de validación aquí]

            ////lleno las labels con características del artículo
            //this.lblCodigoOriginalVar.Text = glb_mod_articuloDevolucion.codigoOriginal;
            //this.lblCodigoProveedorVar.Text = glb_mod_articuloDevolucion.codigoArticuloProveedor;
            //this.lblProveedorVar.Text = glb_mod_articuloDevolucion.razonSocialProveedor;
            //this.lblDescripcionVar.Text = glb_mod_articuloDevolucion.descripcionArticuloProveedor;

            //this.lblPrecioVar.Text = Convert.ToString(glb_mod_articuloDevolucion.valorVenta.valorArticulo);
            //this.lblUbicacionVar.Text = glb_mod_articuloDevolucion.ubicacion;

            //this.lblExistenciaVar.Text = Convert.ToString(glb_mod_articuloDevolucion.stockActual);
            //this.lblFechaActualizacionVar.Text = Convert.ToString(glb_mod_articuloDevolucion.fechaActualizacion);
            //this.lblObservacionesVar.Text = glb_mod_articuloDevolucion.observacionesArticuloProveedor;

            //doy visibilidad a botones y groupbox para manipulación del usuario
            this.gbxDetalleArticuloSeleccionado.Visible = true;
            this.gbxDatosDevolucion.Visible = true;
            this.btnAceptar.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //solicito confirmación
            DialogResult lcl_dialogResult = MessageBox.Show("¿Realmente desea cancelar la devolución?", "Confirmación", MessageBoxButtons.YesNo);
            if (lcl_dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.rbtError.Checked)
            {
                // tomar cantidad, cod articulo y actualizar inventario
            }

            //emitir nota de crédito
            frmEnConstruccion frmEnConstruccion = new frmEnConstruccion();
            frmEnConstruccion.ShowDialog();
        }

        #endregion

        private void rbtError_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbtError.Checked)
            {
                lblCantidadDevuelta.Visible = true;
                txtCantidadDevuelta.Visible = true;
            }
            else
            {
                lblCantidadDevuelta.Visible = false;
                txtCantidadDevuelta.Text = null;
                txtCantidadDevuelta.Visible = false;
            }
        }

    }
}
