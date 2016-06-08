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
    public partial class frmFacturacionMasiva : Form
    {
        ControladorPedidoCliente controlador = new ControladorPedidoCliente();
        public frmFacturacionMasiva()
        {
            InitializeComponent();
        }

        private void parámetrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPreferenciasFacturacion frmPreferences = new frmPreferenciasFacturacion();
            frmPreferences.ShowDialog();
        }

        public void CargaEnGrid(List<ModeloPedido> p_lst_mod_ped)
        {
            DataTable pedidos = new DataTable();
            pedidos.Columns.Add("indice");
            pedidos.Columns.Add("colFecPedido");
            pedidos.Columns.Add("colCliente");
            pedidos.Columns.Add("colCuit");
            pedidos.Columns.Add("colNroPedido");
            pedidos.Columns.Add("colTipoComprobante");
            pedidos.Columns.Add("colMonto");
                       
            int i = 0;
            foreach (ModeloPedido mp in p_lst_mod_ped)
            {
                var row = pedidos.NewRow();
                row["indice"] = i.ToString();
                i++;
                row["colFecPedido"] = mp.fecha;
                row["colCliente"] = mp.entidad.ToString();
                row["colCuit"] = mp.entidad.cuit;
                row["colNroPedido"] = mp.numeroPedido.ToString() ;
                row["colTipoComprobante"] = mp.tipoComprobante.ToString();
                row["colMonto"] = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}", mp.montoTotal);
                
                pedidos.Rows.Add(row);
            }

            this.dgvComprSinFact.DataSource = pedidos;
        }

        private void buscarComprobantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Resta agregar los radio button como un grupo.
            string lcl_p_tipo = "";
            if (rbutFCA.Checked == true)
            { lcl_p_tipo = "1"; }
            else if (rbutFCB.Checked == true)
            { lcl_p_tipo = "6"; }
            else if (rbutNCA.Checked == true)
            { lcl_p_tipo = "3"; }
            else
            { lcl_p_tipo = "8"; }

            this.CargaEnGrid(controlador.getPedidosSFacturar(lcl_p_tipo));
        }

        private void dgvComprSinFact_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            int j =0;
            for (int i = 0; i < dgvComprSinFact.RowCount; i++)
            { 
            if(Object.Equals(dgvComprSinFact[7,i].Value,(object)true))
            {j++;}

            }
                this.tbxCantidadFact.Text = j.ToString();
        }

            
    }
}
