using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaClasesCompartidas;
using Modelos;

namespace Vista
{
    public partial class frmABMEntidad_DatosAdicionalesProveedor : Vista.frmMaterialSkinBase
    {
        private frmABMEntidad_DatosAdicionalesProveedor()
        {
            InitializeComponent();
        }
        public frmABMEntidad_DatosAdicionalesProveedor(ModeloProveedor p_proveedor) : this()
        {
            this.Text = "Datos Adicionales de Proveedor";
            this.inicializarForm(this.Width, this.Height);
            this.StartPosition = FormStartPosition.CenterParent;
            this.inicializarComboBoxTipoResponsable();
            this.cargarProveedorEnControles(p_proveedor);
        }
        public override void inicializarForm(int ventanaAncho, int ventanaAlto)
        {
            this.tblLayoutPanelPrincipal.Width = ventanaAncho - 20; //un margen derecho de 20 para que se vea scrollbar
            this.pnlBase.Width = ventanaAncho;  //un márgen derecho de 3
            this.pnlBase.Height = ventanaAlto - 60; //un márgen arriba para que se vea título
            if (pnlBase.Height < 800)
            {
                this.tblLayoutPanelPrincipal.Height = 800;  //Mínimo
                this.tblLayoutPanelPrincipal.Width = ventanaAncho - 30; //un margen derecho de 30 para que se vea scrollbar
                this.pnlBase.AutoScroll = true;
            }
            else
            {
                this.tblLayoutPanelPrincipal.Height = pnlBase.Height; ; // 60 pixeles para que se vea título de ventana principal
            }

            int x = Convert.ToInt16(Math.Round(Convert.ToDouble((Width - this.tblLayoutPanelPrincipal.Width) / 2)));
            this.tblLayoutPanelPrincipal.Location = new Point(10, 0);
            this.pnlBase.Location = new Point(0, 60);
        }
        private void inicializarComboBoxTipoResponsable()
        {
            this.cmbBoxTipoResponsable.DataSource = Enum.GetValues(typeof(Constantes.SituacionIVA));
            this.cmbBoxTipoResponsable.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbBoxTipoResponsable.FormattingEnabled = true;
            this.cmbBoxTipoResponsable.Format += delegate(object sender, ListControlConvertEventArgs e)
            {
                e.Value = Constantes.GetDescription<Constantes.SituacionIVA>((Constantes.SituacionIVA)e.Value);
            };
            this.cmbBoxTipoResponsable.SelectedItem = Constantes.SituacionIVA.Responsable_Inscripto;
            this.cmbBoxTipoResponsable.Enabled = false;
        }

        private void cargarProveedorEnControles(ModeloProveedor p_proveedor)
        {
            this.cmbBoxTipoResponsable.SelectedItem = (Constantes.SituacionIVA)p_proveedor.codigoTipoResponsable;

            ModeloContactoProveedor lcl_mod_contactoProveedor = new ModeloContactoProveedor();
            lcl_mod_contactoProveedor.proveedor = new ModeloProveedor(p_proveedor);
            frmResultadoBusqueda lcl_frm = new frmResultadoBusqueda(lcl_mod_contactoProveedor);

            this.grpBoxContactosProveedor.Controls.Add(lcl_frm.dataGridViewResultadoBusqueda);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
