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
    public partial class frmOpciones : frmMaterialSkinBase
    {
        public EventHandler ActualizarColoresEvent;
        
        public frmOpciones()
        {
            InitializeComponent();
        }

        public override void inicializarForm(int ventanaAncho, int ventanaAlto)
        {
            this.tblLayoutPanelPrincipal.Width = ventanaAncho - 20; //un margen derecho de 20 para que se vea scrollbar
            this.pnlBase.Width = ventanaAncho - 3;  //un márgen derecho de 3
            this.pnlBase.Height = ventanaAlto - 60; //un márgen arriba para que se vea título

            if (Height < 500)
            {
                this.tblLayoutPanelPrincipal.Height = 500;  //Mínimo
                this.pnlBase.AutoScroll = true;
                ScrollBar vScrollBar = new VScrollBar();
                vScrollBar.Dock = DockStyle.Right;
                vScrollBar.Scroll += (sender, e) => { pnlBase.VerticalScroll.Value = vScrollBar.Value; };
                pnlBase.Controls.Add(vScrollBar);
            }
            else
            {
                this.tblLayoutPanelPrincipal.Height = Height - 66; // 60 pixeles para que se vea título de ventana principal
            }

            int x = Convert.ToInt16(Math.Round(Convert.ToDouble((Width - this.tblLayoutPanelPrincipal.Width) / 2)));
            this.tblLayoutPanelPrincipal.Location = new Point(10, 0);
            this.pnlBase.Location = new Point(0, 65);
        }

        private void btnCambiarColores_Click(object sender, EventArgs e)
        {
            //le damos toda la vuelta
            switch (Properties.Settings.Default.color_scheme)
            {
                case 0:
                    Properties.Settings.Default.color_scheme = 1;
                    break;
                case 1:
                    Properties.Settings.Default.color_scheme = 2;
                    break;
                case 2:
                    Properties.Settings.Default.color_scheme = 3;
                    break;
                case 3:
                    Properties.Settings.Default.color_scheme = 4;
                    break;
                case 4:
                    Properties.Settings.Default.color_scheme = 5;
                    break;
                case 5:
                    Properties.Settings.Default.color_scheme = 6;
                    break;
                case 6:
                    Properties.Settings.Default.color_scheme = 0;
                    break;
            }
            Properties.Settings.Default.Save();
            this.ActualizarColoresEvent(new object(), new EventArgs());
            this.actualizarColores();
        }
    }
}
