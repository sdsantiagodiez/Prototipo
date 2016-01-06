using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos;
using Controladores;

namespace Vista
{
    public partial class frmABMEntidadDatosAdicionalesUsuario : Form
    {
        public frmABMEntidadDatosAdicionalesUsuario()
        {
            InitializeComponent();
        }
        private void inicializarCheckedListBox()
        {
            //REVISAR FALTAN roles en controladores y catalogo
            ControladorBusqueda cBusqueda = new ControladorBusqueda();
            List<ModeloRoles> roles = new List<ModeloRoles>();
            chckdListBoxRol.DataSource = roles;
            chckdListBoxRol.DisplayMember = "descripcion";
            chckdListBoxRol.ValueMember = "codigo";
        }
        private List<ModeloRoles> cargarDatosEnModeloRol()
        {
            List<ModeloRoles> lModeloRol = new List<ModeloRoles>();
            ModeloRoles mRol = new ModeloRoles();
            foreach (object itemChecked in chckdListBoxRol.CheckedItems)
            {
                DataRowView rol = itemChecked as DataRowView;
                mRol.codigo = Convert.ToInt32(rol["codigo"].ToString());
                mRol.descripcion = rol["descripcion"].ToString();
            }
            return lModeloRol;
        }
    }
}
