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
    public partial class frmABMEntidad_DatosAdicionalesCliente : Vista.frmMaterialSkinBase
    {
        public ModeloCliente ClienteActual;
        public frmABMEntidad_DatosAdicionalesCliente()
        {
            InitializeComponent();
        }

        public frmABMEntidad_DatosAdicionalesCliente(ModeloCliente p_cliente)
            : this()
        {
            this.StartPosition = FormStartPosition.CenterParent;
            this.inicializarForm(this.Width, this.Height);
            this.inicializarComboBoxTipoResponsable();
            this.cargarClienteEnControles(p_cliente);
            ClienteActual = ObjectCopier.Clone(p_cliente);
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
            this.cmbBoxTipoResponsable.SelectedIndex = 1;
        }

        private void cargarClienteEnControles(ModeloCliente p_cliente)
        {
            this.cmbBoxTipoResponsable.SelectedItem = (Constantes.SituacionIVA)p_cliente.codigoTipoResponsable;
        }
        private void cargarControlEnCliente()
        {
            ClienteActual.codigoTipoResponsable = (int)this.cmbBoxTipoResponsable.SelectedValue;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ClienteActual = null;
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.cargarControlEnCliente();
            this.Close();
        }
    }
}
