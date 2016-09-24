using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Animations;

namespace Vista
{
    public partial class frmMaterialSkinBase : MaterialForm
    {
        ErrorProvider epGood = new ErrorProvider();
        ErrorProvider epBad = new ErrorProvider();

        public event EventHandler CerrarForm;

        MaterialSkinManager materialSkinManager;

        public frmMaterialSkinBase()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);

            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            this.actualizarColores();
            //this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            
            this.MinimizeBox = false;
            this.MaximizeBox = false;

            epGood.Icon = Properties.Resources.success;
            epBad.Icon = Properties.Resources.error;
        }

        public virtual void actualizarColores()
        {
            switch (Properties.Settings.Default.color_scheme)
            {
                case 0:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan500, Primary.Cyan700, Primary.Cyan200, Accent.Red200, TextShade.WHITE);
                    break;
                case 1:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.Blue700, Primary.Blue200, Accent.LightBlue200, TextShade.WHITE);
                    break;
                case 2:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
                    break;
                case 3:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Pink200, TextShade.WHITE);
                    break;
                case 4:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Red100, TextShade.WHITE);
                    break;
                case 5:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Amber500, Primary.Amber700, Primary.Amber200, Accent.Red100, TextShade.WHITE);
                    break;
                case 6:
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Brown500, Primary.Brown700, Primary.Brown200, Accent.Pink400, TextShade.WHITE);
                    break;
                default:
                    //en caso que no sea ninguno de los preestablecidos, lo seteamos en 0
                    materialSkinManager.ColorScheme = new ColorScheme(Primary.Cyan500, Primary.Cyan700, Primary.Cyan200, Accent.Red200, TextShade.WHITE);
                    Properties.Settings.Default.color_scheme = 0;
                    Properties.Settings.Default.Save();
                    break;

            }
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

        public void habilitarMovimiento(ref Message message)
        {
            base.WndProc(ref message);
        }
        private void frmMaterialSkinBase_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (CerrarForm != null)
            {
                this.CerrarForm(sender, e);
            }
        }

        public static int GetDropDownWidth(ComboBox p_comboBox)
        {
            int maxWidth = 1, temp = 0;
            foreach (var obj in p_comboBox.Items)
            {
                temp = TextRenderer.MeasureText(obj.ToString(), p_comboBox.Font).Width;
                if (temp > maxWidth)
                {
                    maxWidth = temp;
                }
            }
            return maxWidth;
        }
        protected void clearErrorProviders()
        {
            this.getErrorProvider(true).Clear();
            this.getErrorProvider(false).Clear();
        }
        
        protected void clearOneErrorProvider(Control p_control)
        {
            this.getErrorProvider(true).SetError(p_control,null);
            this.getErrorProvider(false).SetError(p_control, null);
        }

        protected void setErrorProvider(Control p_control, bool p_exito, string p_mensaje)
        {
            this.getErrorProvider(p_exito).SetError(p_control, p_mensaje);

            this.getErrorProvider(!p_exito).SetError(p_control, null);
        }
        protected ErrorProvider getErrorProvider(bool exito)
        {
            if (exito)
            {
                return epGood;
            }
            else
            {
                return epBad;
            }
        }
        

        public static void InicializarCmbBox(ComboBox p_comboBox)
        {
            p_comboBox.DropDownWidth = GetDropDownWidth(p_comboBox);
            p_comboBox.DisplayMember = "Name";
            p_comboBox.ValueMember = "Value";
            p_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        /// <summary>
        /// Limpia todos los controles que se encuentren dentro del control enviado como parámetro
        /// </summary>
        /// <param name="p_ctr_control"></param>
        public static void QuitarTextoEnControles(Control p_ctr_control)
        {
            foreach (Control c in p_ctr_control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                else if (c is ListView)
                {
                    ((ListView)c).Items.Clear();
                }
                else if (c is DataGridView)
                {
                    ((DataGridView)c).Rows.Clear();
                }
                else if (c is ComboBox)
                {
                    ((ComboBox)c).SelectedIndex = -1;
                }
                else if (c is RichTextBox)
                {
                    ((RichTextBox)c).Clear();
                }
                else if (c is RadioButton)
                {
                    ((RadioButton)c).Checked = false;
                }
                else if (c is PictureBox)
                {
                    ((PictureBox)c).Image = null;
                }
                else
                {
                    //control que puede contener una colección de controles (groupBox por ejemplo)
                    QuitarTextoEnControles(c);
                }
            }
        }

        protected void valorNumericoTeclado(object sender, KeyPressEventArgs e)
        {
            // solo 0-9 y borrar 
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
                return;
            }
        }
        static DateTime LastCloseTime;
        private void frmMaterialSkinBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            double delta =DateTime.Now.Subtract(LastCloseTime).TotalSeconds ;
            if (delta < 1)
            {
                e.Cancel = true;
                return;
            }
            LastCloseTime = DateTime.Now;
        }
        

    }
    
    //clase para llenar combo box categoria a buscar
    class ComboBoxItem
    {
        public string Name { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
