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
    public partial class frmABMEntidad : Form
    {
        TableLayoutPanel tblLayoutPanelExtra;
        public frmABMEntidad()
        {
            InitializeComponent();
            tbPageDatos.Text = "Datos";
            tbPageExtra.Text = "Extra";
            btnAgregarMail.Text = char.ConvertFromUtf32(8595);
            btnQuitarMail.Text = char.ConvertFromUtf32(8593);

            //tblLayoutPanelExtra
            

        }

        private void radioButtonUsuario_CheckedChanged(object sender, EventArgs e)
        {
            
            //tblLayoutPanelExtra = new System.Windows.Forms.TableLayoutPanel();
            //tbPageExtra.Controls.Clear();
            //tbPageExtra.Controls.Add(tblLayoutPanelExtra);
            //tblLayoutPanelExtra.Dock = DockStyle.Fill;
            //tblLayoutPanelExtra.Controls.Add(grpBoxDatosUsuario, 0, 0);
            ////
            //System.Windows.Forms.GroupBox grpBoxDatosUsuario = new GroupBox();
            

            //tblLayoutPanelExtra.Visible = radioButtonUsuario.Checked;
            //#region Pestaña Extra
            //// 
            //// grpBoxDatosUsuario
            //// 
            //grpBoxDatosUsuario.Controls.Add(panel1);
            //grpBoxDatosUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //grpBoxDatosUsuario.Location = new System.Drawing.Point(3, 17);
            //grpBoxDatosUsuario.Name = "grpBoxDatosUsuario";
            //grpBoxDatosUsuario.Size = new System.Drawing.Size(612, 229);
            //grpBoxDatosUsuario.TabIndex = 10;
            //grpBoxDatosUsuario.TabStop = false;
            //grpBoxDatosUsuario.Text = "Datos Usuario";
            //// 
            //// pnlDatosUsuario
            //// 
            //pnlDatosUsuario.Controls.Add(lblRepetirContraseña);
            //pnlDatosUsuario.Controls.Add(checkedListBoxRol);
            //pnlDatosUsuario.Controls.Add(txtBoxUsuario);
            //pnlDatosUsuario.Controls.Add(lblUsuario);
            //pnlDatosUsuario.Controls.Add(txtBoxContraseña);
            //pnlDatosUsuario.Controls.Add(lblContraseña);
            //pnlDatosUsuario.Controls.Add(txtBoxConfirmarContraseña);
            //pnlDatosUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            //pnlDatosUsuario.Location = new System.Drawing.Point(3, 20);
            //pnlDatosUsuario.Name = "pnlDatosUsuario";
            //pnlDatosUsuario.Size = new System.Drawing.Size(606, 206);
            //pnlDatosUsuario.TabIndex = 0;
            //// 
            //// txtBoxUsuario
            //// 
            //txtBoxUsuario.Enabled = false;
            //txtBoxUsuario.Location = new System.Drawing.Point(319, 8);
            //txtBoxUsuario.Name = "txtBoxUsuario";
            //txtBoxUsuario.Size = new System.Drawing.Size(113, 24);
            //txtBoxUsuario.TabIndex = 8;
            //// 
            //// txtBoxContraseña
            //// 
            //txtBoxContraseña.Enabled = false;
            //txtBoxContraseña.Location = new System.Drawing.Point(319, 39);
            //txtBoxContraseña.Name = "txtBoxContraseña";
            //txtBoxContraseña.Size = new System.Drawing.Size(113, 24);
            //txtBoxContraseña.TabIndex = 7;
            //// 
            //// txtBoxConfirmarContraseña
            //// 
            //txtBoxConfirmarContraseña.Enabled = false;
            //txtBoxConfirmarContraseña.Location = new System.Drawing.Point(319, 69);
            //txtBoxConfirmarContraseña.Name = "txtBoxConfirmarContraseña";
            //txtBoxConfirmarContraseña.Size = new System.Drawing.Size(113, 24);
            //txtBoxConfirmarContraseña.TabIndex = 6;
            //// 
            //// lblUsuario
            //// 
            //lblUsuario.AutoSize = true;
            //lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //lblUsuario.Location = new System.Drawing.Point(160, 7);
            //lblUsuario.Name = "lblUsuario";
            //lblUsuario.Size = new System.Drawing.Size(60, 18);
            //lblUsuario.TabIndex = 3;
            //lblUsuario.Text = "Usuario";
            //// 
            //// lblContraseña
            //// 
            //lblContraseña.AutoSize = true;
            //lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //lblContraseña.Location = new System.Drawing.Point(160, 38);
            //lblContraseña.Name = "lblContraseña";
            //lblContraseña.Size = new System.Drawing.Size(85, 18);
            //lblContraseña.TabIndex = 4;
            //lblContraseña.Text = "Contraseña";
            //// 
            //// lblRepetirContraseña
            //// 
            //lblRepetirContraseña.AutoSize = true;
            //lblRepetirContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //lblRepetirContraseña.Location = new System.Drawing.Point(160, 68);
            //lblRepetirContraseña.Name = "lblRepetirContraseña";
            //lblRepetirContraseña.Size = new System.Drawing.Size(155, 18);
            //lblRepetirContraseña.TabIndex = 5;
            //lblRepetirContraseña.Text = "Confirmar Contraseña";
            //// 
            //// checkedListBoxRol
            //// 
            //checkedListBoxRol.BackColor = System.Drawing.SystemColors.Control;
            //checkedListBoxRol.BorderStyle = System.Windows.Forms.BorderStyle.None;
            //checkedListBoxRol.CheckOnClick = true;
            //checkedListBoxRol.Enabled = false;
            //checkedListBoxRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //checkedListBoxRol.FormattingEnabled = true;
            //checkedListBoxRol.Items.AddRange(new object[] {
            //        "Encargado de Reportes",
            //        "Encargado de Compras",
            //        "Encargado de Ventas",
            //        "Encargado de Datos"});
            //checkedListBoxRol.Location = new System.Drawing.Point(187, 121);
            //checkedListBoxRol.Name = "checkedListBoxRol";
            //checkedListBoxRol.Size = new System.Drawing.Size(213, 114);
            //checkedListBoxRol.TabIndex = 0;
            //#endregion

            //grpBoxDatosUsuario = new System.Windows.Forms.GroupBox();

            //panel1 = new System.Windows.Forms.Panel();
            //grpBoxDatosUsuario.Controls.Add(panel1);

            //panel1.Dock = System.Windows.Forms.DockStyle.Fill;

        }

        private void radioButtonProveedor_CheckedChanged(object sender, EventArgs e)
        {
            txtBoxRazonSocial.Enabled = radioButtonProveedor.Checked;
        }

    }
}
