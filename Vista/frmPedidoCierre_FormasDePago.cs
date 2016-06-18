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
using LibreriaClasesCompartidas;
using MaterialSkin;
using MaterialSkin.Animations;
using MaterialSkin.Controls;

namespace Vista
{
    public partial class frmPedidoCierre_FormasDePago : MaterialForm
    {
        private ModeloPedido pedidoActual;
        #region Constructores
        public frmPedidoCierre_FormasDePago()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            dgvFormasPago.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvFormasPago.EnableHeadersVisualStyles = false; 
            this.inicializarDataGridView();
            this.inicializarComboBox();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Selección de Formas de Pago";
            
            this.pedidoActual = new ModeloPedido();
        }
        public frmPedidoCierre_FormasDePago(ModeloPedido p_mod_pedido) : this()
        {
            this.pedidoActual = p_mod_pedido;
            this.cargarPedidoEnControles(this.pedidoActual);
        }
        #endregion
        #region Métodos

        #region Inicialización
        private void inicializarComboBox()
        {
            this.cmbBoxFormaPago.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbBoxFormaPagoRestante.DropDownStyle = ComboBoxStyle.DropDownList;

            this.cmbBoxFormaPago.FormattingEnabled = this.cmbBoxFormaPagoRestante.FormattingEnabled = true;
            this.cmbBoxFormaPago.Format += delegate(object sender, ListControlConvertEventArgs e)
            {
                e.Value = Constantes.GetDescription<Constantes.FormaDePago>((Constantes.FormaDePago)e.Value);
            };

            this.cmbBoxFormaPagoRestante.Format += delegate(object sender, ListControlConvertEventArgs e)
            {
                e.Value = Constantes.GetDescription<Constantes.FormaDePago>((Constantes.FormaDePago)e.Value);
            };
            var query = Enum.GetValues(typeof(Constantes.FormaDePago)).Cast<Constantes.FormaDePago>().Except(new Constantes.FormaDePago[] { Constantes.FormaDePago.Multiple });
            //this.cmbBoxFormaPago.DataSource = query.ToList();
            this.cmbBoxFormaPagoRestante.DataSource = query.ToList();
        }

        private void inicializarDataGridView()
        {
            this.dgvFormasPago.Columns.Add("formaPago", "Forma");
            this.dgvFormasPago.Columns[0].FillWeight = 1;
            this.dgvFormasPago.Columns.Add("monto", "Monto");
            this.dgvFormasPago.Columns[1].FillWeight = 1;
        }
        #endregion
        
        #region Modelo -> Controles
        private void cargarPedidoEnControles(ModeloPedido p_mod_pedido)
        {
            this.dgvFormasPago.Rows.Clear();
            DataGridViewRow row;
            int rowIndex;

            foreach (FormaPago fp in p_mod_pedido.formasDePago)
            {
                rowIndex = dgvFormasPago.Rows.Add();
                row = dgvFormasPago.Rows[rowIndex];

                if (fp.restante)
                {
                    this.cmbBoxFormaPagoRestante.SelectedItem = fp.forma;
                    this.cargarComboBox(p_mod_pedido);
                }

                row.Cells["formaPago"].Value = Constantes.GetDescription<Constantes.FormaDePago>(fp.forma);
                row.Cells["monto"].Value = String.Format(System.Globalization.CultureInfo.GetCultureInfo("es-AR"), "{0:C}", fp.monto);
            }
        }
       
        private void cargarComboBox(ModeloPedido p_mod_pedido)
        { 
            var forma = Constantes.FormaDePago.Contado;
            foreach(FormaPago fp in p_mod_pedido.formasDePago)
            {
                if(fp.restante)
                {
                    forma = fp.forma;
                    break;
                }
            }
            this.cmbBoxFormaPagoRestante.SelectedItem = forma;

            var query = Enum.GetValues(typeof(Constantes.FormaDePago)).Cast<Constantes.FormaDePago>().Except(new Constantes.FormaDePago[] { Constantes.FormaDePago.Multiple, forma });
            this.cmbBoxFormaPago.DataSource = query.ToList();
        }
        #endregion

        public List<FormaPago> getFormasDePago()
        {
            return pedidoActual.formasDePago;
        }
        #endregion
        
        #region Eventos
      
        #region Button
        private void btnAgrearFormaPago_Click(object sender, EventArgs e)
        {
            FormaPago lcl_formaPago = new FormaPago();
            lcl_formaPago.forma = (Constantes.FormaDePago)this.cmbBoxFormaPago.SelectedItem;
            lcl_formaPago.monto = Convert.ToDecimal(this.txtBoxMonto.Text);
            pedidoActual.addFormaPago(lcl_formaPago);
            if (pedidoActual.addFormaPago(lcl_formaPago))
            {
                this.cargarPedidoEnControles(pedidoActual);
            }
            else
            {
                MessageBox.Show("El ingreso del monto actual supera el monto total del pedido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnQuitarFormaPago_Click(object sender, EventArgs e)
        {
            string a = (string)this.dgvFormasPago.CurrentRow.Cells["formaPago"].Value;
            var formas = Enum.GetValues(typeof(Constantes.FormaDePago));
            foreach (Constantes.FormaDePago fp in formas)
            {
                if (a == Constantes.GetDescription<Constantes.FormaDePago>(fp))
                {
                    this.pedidoActual.removeFormaPago(new FormaPago() { forma = fp });
                }
            }

            this.cargarPedidoEnControles(pedidoActual);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        #endregion
       
        #region ComboBox
        private void cmbBoxFormaPagoRestante_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FormaPago lcl_formaPago = new FormaPago();
            lcl_formaPago.forma = (Constantes.FormaDePago)this.cmbBoxFormaPagoRestante.SelectedItem;
            lcl_formaPago.restante = true;
            pedidoActual.addFormaPago(lcl_formaPago);
            this.cargarPedidoEnControles(pedidoActual);
        }
        #endregion
        #endregion
    }
}
