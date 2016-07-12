using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Animations;

namespace Vista
{
    public partial class frmMaterialSkinBase : MaterialForm
    {
        public event EventHandler CerrarForm;

        public frmMaterialSkinBase()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            this.MinimizeBox = false;
            this.MaximizeBox = false;
        }

        public virtual void inicializarForm()
        {
 
        }
        public virtual void inicializarForm(int x, int y)
        {
            //Si form no tiene método inicializarForm(x,y), se corre inicializarForm()
            this.inicializarForm();
        }
        /// <summary>
        /// Deshabilita posibilidad de usuario de mover la ventana
        /// </summary>
        /// <param name="message"></param>
        protected override void WndProc(ref Message message)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            switch (message.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }

            base.WndProc(ref message);
        }
        private void frmMaterialSkinBase_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (CerrarForm != null)
            {
                this.CerrarForm(sender, e);
            }
        }
    }
}
