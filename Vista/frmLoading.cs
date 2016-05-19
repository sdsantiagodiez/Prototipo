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
    public partial class frmLoading : Form
    {
        #region remueve Closing button
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

        string titulo ="Procesando";
        string mensaje = "Espere por favor.";

        //lblMensaje para centrar => AutoSize=false, Dock=Fill, TextAlign=MiddleCenter

        public frmLoading()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        public frmLoading(string p_mensaje) : this()
        {
            this.lblMensaje.Text = p_mensaje;
            this.mensaje = p_mensaje;
        }
        public frmLoading(string p_mensaje, string p_titulo):this()
        {
            this.Text = p_titulo;
            this.lblMensaje.Text = p_mensaje;
            this.titulo = p_titulo;
            this.mensaje = p_mensaje;
        }
    }
}
