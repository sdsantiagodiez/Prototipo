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
        ControladorDevolucion glb_con_devolucion=new ControladorDevolucion();


        public frmDevolucion()
        {
            InitializeComponent();
        }

        #region Botones

        private void btnValidar_Click(object sender, EventArgs e)
        {
            //VER CODIGO VERIFICACION?
            //pido el artículo al controlador 
            if (LibreriaClasesCompartidas.Validar.validarEnteroPositivoSinCero(txtNumeroPedido.Text))
            {
                ModeloArticuloProveedores lcl_mod_articuloDevolucion= new ModeloArticuloProveedores();
                
                lcl_mod_articuloDevolucion=glb_con_devolucion.getArticuloPedido(txtNumeroPedido.Text,txtCodigoOriginal.Text,txtCodigoArticuloProveedor.Text);

                //controlo que haya devuelto un articulo y no vacío
                if(!object.Equals(lcl_mod_articuloDevolucion,null)){

                    //lleno las labels con características del artículo
                this.lblCodigoOriginalVar.Text = lcl_mod_articuloDevolucion.codigoOriginal;
                this.lblCodigoProveedorVar.Text = lcl_mod_articuloDevolucion.codigoArticuloProveedor;
                this.lblProveedorVar.Text = lcl_mod_articuloDevolucion.razonSocialProveedor;
                this.lblDescripcionVar.Text = lcl_mod_articuloDevolucion.descripcionArticuloProveedor;

                this.lblPrecioVar.Text = Convert.ToString(lcl_mod_articuloDevolucion.valorVenta.valorArticulo);
                this.lblUbicacionVar.Text = lcl_mod_articuloDevolucion.ubicacion;

                this.lblExistenciaVar.Text = Convert.ToString(lcl_mod_articuloDevolucion.stockActual);
                this.lblFechaActualizacionVar.Text = Convert.ToString(lcl_mod_articuloDevolucion.fechaActualizacion);
                this.lblObservacionesVar.Text = lcl_mod_articuloDevolucion.observacionesArticuloProveedor;

                //doy visibilidad a botones y groupbox para manipulación del usuario
                this.gbxDetalleArticuloSeleccionado.Visible = true;
                this.gbxDatosDevolucion.Visible = true;
                this.btnAceptar.Visible = true;
                }
                    //en caso de vacío informo que no existe o los datos se ingresaron mal.
                else {
                    MessageBox.Show("Al parecer no existe un pedido con ese artículo. Intente ingresar los datos nuevamente");
                }
            }
            else
            {
                MessageBox.Show("El número de pedido debe ser un entero mayor a cero");
            }
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
                glb_con_devolucion.actualizarStock();
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
