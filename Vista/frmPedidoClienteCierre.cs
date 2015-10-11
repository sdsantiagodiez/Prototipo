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
    public partial class frmPedidoClienteCierre : Form
    {
        private List<ModeloLineaPedido> ventaActual;
        
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
            frmEnConstruccion frmConstruccion = new frmEnConstruccion();
            frmConstruccion.ShowDialog();
        }       
    
        internal void detalleVenta(List<ModeloLineaPedido> list)
        {
 	        this.ventaActual = list;
            var bindingList = new BindingList<ModeloLineaPedido>(this.ventaActual);
            var source = new BindingSource(bindingList, null);
            this.dgvArticulosVenta.DataSource = source;
        }
    }
}
