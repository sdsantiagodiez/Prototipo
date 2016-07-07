using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Controladores;
using Modelos;
using Reportes;


namespace Reportes
{
    public partial class frmImpresionLoteFacturas : Form
    {
        public frmImpresionLoteFacturas()
        {
            InitializeComponent();
        }

        public frmImpresionLoteFacturas(List<ModeloReporteEncabezadoFactura> p_lst_mod_EncFac, string p_tipoComprobante)
        {
                    
        }
    }
}
