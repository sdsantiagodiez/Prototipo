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
    public partial class frmLoading : frmMaterialSkinBase
    {
        #region remueve Closing button
        /*
         * No funciona con MaterialSkins
         */
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
        #endregion

        string titulo ="Procesando...";
        string mensaje = "Espere por favor.";

        //lblMensaje para centrar => AutoSize=false, Dock=Fill, TextAlign=MiddleCenter

        private frmLoading()
        {
            InitializeComponent();
            
            this.StartPosition = FormStartPosition.CenterScreen;
            
        }
        public frmLoading(string p_mensaje) : this()
        {
            this.lblMensaje.Text = p_mensaje;
            this.mensaje = p_mensaje;

            this.inicializarForm();
        }
        public frmLoading(string p_mensaje, string p_titulo):this()
        {
            this.Text = p_titulo;
            this.lblMensaje.Text = p_mensaje;
            this.titulo = p_titulo;
            this.mensaje = p_mensaje;

            this.inicializarForm();
        }
        
        private void inicializarForm()
        {
            //faltan mejoras para textos largos
            
            this.MinimumSize = new Size(315, 120);
            this.pnlBase.MinimumSize = new Size(315, 60);
            this.pnlBase.MaximumSize = this.MaximumSize = new Size(315, 900);
            this.pnlBase.AutoSize = true;
            this.pnlBase.Controls.Remove(this.lblMensaje);
            this.pnlBase.Controls.Add(this.lblMensaje);

            this.Size = new Size(this.pnlBase.Size.Width, this.pnlBase.Height + 60);
            this.pnlBase.Location = new Point(0, 60);
        }
        private void frmLoading_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }
    }
}
