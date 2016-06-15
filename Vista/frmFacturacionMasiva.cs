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
using MaterialSkin;
using MaterialSkin.Animations;
using MaterialSkin.Controls;

namespace Vista
{
    public partial class frmFacturacionMasiva : MaterialForm
    {
        ControladorPedidoCliente controlador = new ControladorPedidoCliente();
        public frmFacturacionMasiva()
        {
            InitializeComponent();
            inicializarControles();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            dgvComprSinFact.EnableHeadersVisualStyles = false;
            dgvComprSinFact.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
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
            pedidos.Columns.Add("colFacturar");
                       
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
                row["colFacturar"] = false;
                
                pedidos.Rows.Add(row);
            }

            this.dgvComprSinFact.DataSource = pedidos;
            this.dgvComprSinFact.ClearSelection();
        }

        public void inicializarControles()
        {
            this.dgvComprSinFact.MultiSelect = false;
            this.dgvComprSinFact.AutoGenerateColumns = false;
           
        }
        public bool ValidaSeleccionComprobantes()
        {
            if (bool.Equals(chbxFCA.Checked, false) && bool.Equals(chbxFCB.Checked, false) && bool.Equals(chbxNCA.Checked, false) && bool.Equals(chbxNCB.Checked, false))
            {
                return false;
            }
            else
            { return true;}
        }

        private void buscarComprobantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!ValidaSeleccionComprobantes())
            {
                MessageBox.Show("Por favor seleccione un tipo de Comprobante","Facturacion",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                string[] lcl_p_tipo = new string[4];
                if (chbxFCA.Checked == true)
                { lcl_p_tipo[0] = "1"; }
                else { lcl_p_tipo[0] = "0"; }
                if (chbxFCB.Checked == true)
                { lcl_p_tipo[1] = "6"; }
                else { lcl_p_tipo[1] = "0"; }
                if (chbxNCA.Checked == true)
                { lcl_p_tipo[2] = "3"; }
                else { lcl_p_tipo[2] = "0"; }
                if (chbxNCB.Checked == true)
                { lcl_p_tipo[3] = "8"; }
                else { lcl_p_tipo[3] = "0"; }
                if (controlador.getPedidosSFacturar(lcl_p_tipo).Count == 0)
                {
                    MessageBox.Show("No hay comprobantes pendientes de facturación", "Facturación",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    this.CargaEnGrid(controlador.getPedidosSFacturar(lcl_p_tipo));
                }
            }
        }

       
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTodos.Checked == true)
            { for(int i=0;i<dgvComprSinFact.RowCount;i++)
                {
                    this.dgvComprSinFact["colFacturar",i].Value = true;
                }
                this.tbxCantidadFact.Text=this.dgvComprSinFact.RowCount.ToString();
            }
            else
            {
                for (int i = 0; i < dgvComprSinFact.RowCount; i++)
                {
                    this.dgvComprSinFact["colFacturar", i].Value = false;
                }
            }
        }

        
        private void dgvComprSinFact_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
                int j = 0;
            for (int i = 0; i < dgvComprSinFact.RowCount; i++)
            {
                if (Object.Equals(dgvComprSinFact["colFacturar", i].Value, "True"))
                { j++; }

            }
            this.tbxCantidadFact.Text = j.ToString();
        }

               
        private void dgvComprSinFact_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            this.dgvComprSinFact.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        }

            
    }

