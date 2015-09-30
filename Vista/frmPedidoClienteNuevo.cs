using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controladores;
using Modelos;

namespace Vista
{
    public partial class frmPedidoClienteNuevo : Form
    {
        private string categBusq;
        public frmPedidoClienteNuevo()
        {
            InitializeComponent();
            //Creo lista categorias

            var dataSource = new List<Categ>();
            dataSource.Add(new Categ() { Name = "Codigo Original", Value = "codigoOriginal" });
            dataSource.Add(new Categ() { Name = "Descripción", Value = "descripcion" });

            //Binding de categorias
            this.cmbxCategoriaBuscar.DataSource = dataSource;
            this.cmbxCategoriaBuscar.DisplayMember = "Name";
            this.cmbxCategoriaBuscar.ValueMember = "Value";

            //Lo hago read only
            this.cmbxCategoriaBuscar.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            frmPedidoClienteCierre frmCierre = new frmPedidoClienteCierre();
            frmCierre.ShowDialog();
        }

        private void lblLupa_Click(object sender, EventArgs e)
        {
            //FALTA VALIDAR LA DESCRIPCION
            
            //capturo descripcion parcial
            string busqArt = this.txtBusqArticulo.Text;

            //busco el/los articulos correspondientes
            ControladorProcesarVenta ctrlProcVenta = new ControladorProcesarVenta();
            List<ModeloArticulos> artEncontrados = ctrlProcVenta.buscarArticulos(categBusq, busqArt); 
            if (!object.Equals(artEncontrados, null))
            {
                var bindingList = new BindingList<ModeloArticulos>(artEncontrados);
                var source = new BindingSource(bindingList, null);
                this.dgvArtAgregar.DataSource = source;
            }
            else
            {
                MessageBox.Show("No se encontraron coincidencias");
            }

        }

        private void txtDescArticulo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
               this.lblLupa_Click(sender, e);
            }
        }

        //guarda categoria seleccionada
        private void cmbxCategoriaBuscar_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.categBusq = (string)this.cmbxCategoriaBuscar.SelectedValue;
        }
    }

    //clase para llenar combo box categoria a buscar
    public class Categ
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
