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
using MaterialSkin.Animations;
using MaterialSkin.Controls;

namespace Vista
{
    public partial class frmSeleccion : MaterialForm
    {
        public int selectedIndex;

        public frmSeleccion()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            dgvSeleccion.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dgvSeleccion.EnableHeadersVisualStyles = false; 
        }

        internal void bindList(List<Modelos.ModeloTelefono> list)
        {
            var bindingList = new BindingList<Modelos.ModeloTelefono>(list);
            var source = new BindingSource(bindingList, null);
            this.dgvSeleccion.DataSource = source;
        }

        internal void bindList(List<Modelos.ModeloMail> list)
        {
            var bindingList = new BindingList<Modelos.ModeloMail>(list);
            var source = new BindingSource(bindingList, null);
            this.dgvSeleccion.DataSource = source;
        }

        internal void bindList(List<Modelos.ModeloDomicilio> list)
        {
            var bindingList = new BindingList<Modelos.ModeloDomicilio>(list);
            var source = new BindingSource(bindingList, null);
            this.dgvSeleccion.DataSource = source;
        }
        
        private void dgvSeleccion_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedIndex = dgvSeleccion.CurrentCell.RowIndex;
            this.Close();
        }
    }
}
