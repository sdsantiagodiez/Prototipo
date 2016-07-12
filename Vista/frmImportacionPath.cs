using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Vista
{
    public partial class frmImportacionPath : frmMaterialSkinBase
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

        ErrorProvider errorActual = new ErrorProvider();
        public frmImportacionPath()
        {
            InitializeComponent();
            
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnFileDialog_Click(object sender, EventArgs e)
        {
            this.openFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            this.txtPathImportacion.Text = this.openFileDialog.FileName;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            
        }

        private void txtPathImportacion_Leave(object sender, EventArgs e)
        {
            if (!File.Exists(this.txtPathImportacion.Text))
            {
                errorActual.SetError(txtPathImportacion, "El archivo no existe");
                this.btnImportar.Enabled = false;
            }
            else
            {
                errorActual.Clear();
                this.btnImportar.Enabled = true;
            }
        }

        private void txtPathImportacion_TextChanged(object sender, EventArgs e)
        {
            if (!File.Exists(this.txtPathImportacion.Text))
            {
                errorActual.SetError(txtPathImportacion, "El archivo no existe");
                this.btnImportar.Enabled = false;
            }
            else
            {
                errorActual.Clear();
                this.btnImportar.Enabled = true;
            }
        }
        
        
    }
}
