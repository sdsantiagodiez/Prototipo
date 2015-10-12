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
using Controladores;

namespace Vista
{
    public partial class frmPedidoClienteCierre : Form
    {
        private List<ModeloLineaPedido> ventaActual;
        public bool emitido = false;
        private ControladorProcesarVenta ctrlVenta;
        
        public frmPedidoClienteCierre()
        {
            InitializeComponent();
            this.dgvArticulosVenta.AutoGenerateColumns = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEmitir_Click(object sender, EventArgs e)
        {
            //solicito confirmación
            DialogResult dialogResult = MessageBox.Show("¿Realmente desea emitir el comprobante?", "Confirmación", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var ctrlVenta = new ControladorProcesarVenta();
                //descuento stock
                //ctrlVenta.cerrarPedido(ventaActual);
                //TODO -> IMPRESION
                //ctrlVenta.print();
                //seteo emitido para terminar transacción y cierro
                emitido = true;
                this.Close();
            }
            
        }       
    
        internal void detalleVenta(ControladorProcesarVenta instanciaCtrl)
        {
            this.ctrlVenta = instanciaCtrl;
 	        this.ventaActual = ctrlVenta.getVentaActual();
            var bindingList = new BindingList<ModeloLineaPedido>(this.ventaActual);
            var source = new BindingSource(bindingList, null);
            this.dgvArticulosVenta.DataSource = source;
        }
    }
}
