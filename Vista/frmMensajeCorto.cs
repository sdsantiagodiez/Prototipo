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
    public partial class frmMensajeCorto : Form
    {
        public frmMensajeCorto()
        {
            InitializeComponent();
        }
        
        /// <summary>
        /// Inicializa mensaje de acuerdo a tipo de evento ocurrido
        /// </summary>
        /// <param name="titulo">Texto a mostrar en título de ventana</param>
        /// <param name="cuerpo">Texto explicando evento</param>
        /// <param name="tipoMensaje">exito,fallo,confirmacion</param>
        public frmMensajeCorto(string titulo, string cuerpo, string tipoMensaje)
        {
            InitializeComponent();
            this.Text = titulo;
            this.lblCuerpo.Text = cuerpo;
            this.StartPosition = FormStartPosition.CenterScreen;
            //se debería instanciar un icono adecuado al tipo de mensaje
            switch(tipoMensaje.ToLower())
            {
                case "exito": break;
                case "fallo": break;
                    //agregar botón de Sí No para confirmación
                case "confirmacion": break;
                default: break;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
