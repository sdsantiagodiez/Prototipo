﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos;
using LibreriaClasesCompartidas;
using Controladores;


namespace Vista
{
    public partial class frmMenuPrincipal : frmMaterialSkinBase
    {
        #region Atributos
        Form glb_form;
        bool currentFormLocked;
        #endregion

        #region Constructores
        public frmMenuPrincipal()
        {
            InitializeComponent();

            this.inicializarForm();
            this.MinimizeBox = true;
            this.MaximizeBox = true;
        }

        public frmMenuPrincipal(ModeloUsuario usuarioActual) : this()
        {
            if (this.inicializarModoFormulario(usuarioActual))
            {
                lblNombreUsuario.Text = usuarioActual.usuario ;
            }
            else 
            {
                MessageBox.Show("El usuario actual no posee roles asignados. Contacte al administrador.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Métodos

        #region Inicialización
        private bool inicializarModoFormulario(ModeloUsuario p_mod_usuario)
        {
            this.inicializarModoAdmin(false);

            if(p_mod_usuario.roles.Count == 0)
            { return false; }
            
            foreach (ModeloRoles r in p_mod_usuario.roles)
            {
                switch (r.descripcion)
                {
                    case Constantes.TipoRoles.Admin:
                        this.inicializarModoAdmin(true);
                        return true;
                    case Constantes.TipoRoles.Compras:
                        this.inicializarModoCompras(true);
                        break;
                    case Constantes.TipoRoles.Ventas:
                        this.inicializarModoVentas(true);
                        break;
                    case Constantes.TipoRoles.Datos_Reportes:
                        this.inicializarModoReportes(true);
                        break;
                    case Constantes.TipoRoles.Datos_ABM:
                        this.inicializarModoABM(true);
                        break;
                    default:
                        break;
                }
            }
            return true;
        }

        private void inicializarModoAdmin(bool inicializar)
        {
            this.inicializarModoABM(inicializar);
            this.inicializarModoCompras(inicializar);
            this.inicializarModoVentas(inicializar);
            this.inicializarModoReportes(inicializar);
        }
        private void inicializarModoCompras(bool inicializar)
        {
          //  this.inicializarControles(inicializar, pnlCompras);
        }
        private void inicializarModoVentas(bool inicializar)
        {
           // this.inicializarControles(inicializar, pnlVentas);
        }
        private void inicializarModoReportes(bool inicializar)
        {
           // this.inicializarControles(inicializar, pnlReportes);
        }
        private void inicializarModoABM(bool inicializar)
        {
            // this.inicializarControles(inicializar, pnlABM);
        }
        
        private void inicializarControles(bool inicializar, Control controlContenedor)
        {
            foreach (Control c in controlContenedor.Controls)
            {
                c.Enabled = inicializar;
            }
        }

        public override void inicializarForm()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
            //Width = 1280;
            //Height = 1024;
            
            this.tblLayoutPanelPrincipal.Location = new Point(3, 60);
            this.tblLayoutPanelPrincipal.Height = Height - 60; // 60 pixeles para que se vea título de ventana principal
            this.tblLayoutPanelPrincipal.Width = Width -3; //un margen derecho de 3
        }
        #endregion

        private void exportarDatos(Type T)
        {
            FolderBrowserDialog lcl_fbd = new FolderBrowserDialog();
            lcl_fbd.Description = "Destino de Datos a Exportar";

            if (lcl_fbd.ShowDialog() == DialogResult.OK)
            {
                string direccionDeArchivo = lcl_fbd.SelectedPath;
                bool exito = false;
                ControladorExcel lcl_con_excel = new ControladorExcel();
                
                frmLoading lcl_frm_loading = new frmLoading("Espere por favor. Realizando exportación de datos.");
                frmResultadoBusqueda lcl_frm_resultadoBusqueda = new frmResultadoBusqueda();
                
                BackgroundWorker bw = new BackgroundWorker();
                bw.DoWork += (s, e) =>
                {
                    exito = lcl_con_excel.ExportarAExcel(T,direccionDeArchivo);
                };
                bw.RunWorkerCompleted += (s, e) =>
                {
                    lcl_frm_loading.Hide();

                    if(exito)
                    {
                        MessageBox.Show(lcl_con_excel.errorActual,"Éxito",MessageBoxButtons.OK);
                    }
                    else
                    {
                        System.Windows.Forms.DialogResult dialogResult = MessageBox.Show(lcl_con_excel.errorActual,"Error",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
                        if (dialogResult == System.Windows.Forms.DialogResult.Retry)
                        {
                            this.exportarDatos(T);
                        }
                    }
                };

                bw.RunWorkerAsync();
                lcl_frm_loading.ShowDialog();  
            }
            else
            {
                return;
            }
        }

        private void agregarFormulario(Form p_form)
        {
            Type T = p_form.GetType();
            glb_form.FormClosing += (s, p) => { this.glb_form = new Form(); };//Permite abrir el mismo tipo de formulario recién cerrado.
            foreach (Type t in T.Assembly.GetTypes())
            {//Chequea si hereda de frmMaterialSkinBase
                if (t == typeof(frmMaterialSkinBase))
                {
                    p_form.TopLevel = false;
                    p_form.Dock = DockStyle.Fill;
                    this.pnlContenedorForm.Controls.Add(p_form);
                    p_form.Show();
                    (p_form as frmMaterialSkinBase).inicializarForm(this.pnlContenedorForm.Width, this.pnlContenedorForm.Height);
                    return;
                }    
            }
        }

        private bool validarAgregarFormulario(Type T)
        {
            if (currentFormLocked)
            {
                return false;
            }
            if(glb_form == null )
            {
                return true;
            }
            else if (glb_form.GetType() != T)
            {
                glb_form.Close();
                //Mensaje para confirmar que si cierre se pierde el progreso hecho en el form 
                return true;
            }
            else if (glb_form.GetType() == typeof(frmImportarPreview))
            {
                return true;    //lo cerramos por mas de que ya esté abierto porque puede haber importación de distintos tipos de modelos y no lo detecta
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Eventos

        #region Button
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Timer
        private void timerFechaHora_Tick(object sender, EventArgs e)
        {
            lblFechaLog.Text = DateTime.Today.ToString("dd/MM/yyyy");
            lblHoraLog.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }
        #endregion

        #region ToolStripMenuItem
        private void tsmi_ABMentidades_Click(object sender, EventArgs e)
        {
            if ( !this.validarAgregarFormulario(typeof(frmABMEntidad)))
            {
                return;
            }
            
            glb_form = new frmABMEntidad();
           
            this.agregarFormulario(glb_form);
        }
        private void tsmi_ABMarticulos_Click(object sender, EventArgs e)
        {
            if (!this.validarAgregarFormulario(typeof(frmABMArticulo)))
            {
                return;
            }

            glb_form = new frmABMArticulo();
            this.agregarFormulario(glb_form);
        }

        private void tsmi_ABMdescuentos_Click(object sender, EventArgs e)
        {
            if (!this.validarAgregarFormulario(typeof(frmABMDescuentos)))
            {
                return;
            }

            glb_form = new frmABMDescuentos();
            this.agregarFormulario(glb_form);

            (glb_form as frmABMDescuentos).abrirDescuentosArticuloProveedor += evento_agregarFormEmergente;
        }
        #endregion
   
        #region toolStripButton
        private void toolStripbtnPedidoCliente_Click(object sender, EventArgs e)
        {
            if (!this.validarAgregarFormulario(typeof(frmPedidoCierre)))
            {
                if ((glb_form as frmPedidoCierre).getCodigoTipoPedido() == Constantes.CodigosTiposPedidos.TipoPedidoPersona)
                {
                    return;
                }
                else if (currentFormLocked)
                {
                    return;
                }
            }

            if (glb_form != null && glb_form.GetType() == typeof(frmPedidoCierre) && (glb_form as frmPedidoCierre).getCodigoTipoPedido() == Constantes.CodigosTiposPedidos.TipoPedidoProveedor)
            {
                glb_form.Close();
            }
            
            glb_form = new frmPedidoCierre(new ModeloPedido() {codigoTipoPedido = Constantes.CodigosTiposPedidos.TipoPedidoPersona });
            this.agregarFormulario(glb_form);

            (glb_form as frmPedidoCierre).AgregarLineaPedido += evento_agregarFormEmergente;
            (glb_form as frmPedidoCierre).BuscarCliente += evento_agregarFormEmergente;
            (glb_form as frmPedidoCierre).MostrarDetallesArticulo += evento_agregarFormEmergente;

        }

        private void toolStripbtnPedidoProveedor_Click(object sender, EventArgs e)
        {
            if (!this.validarAgregarFormulario(typeof(frmPedidoCierre)))
            {
                if ((glb_form as frmPedidoCierre).getCodigoTipoPedido() == Constantes.CodigosTiposPedidos.TipoPedidoProveedor)
                {
                    return;
                }
                else if (currentFormLocked)
                {
                    return;
                }
            }
            if (glb_form != null && glb_form.GetType() == typeof(frmPedidoCierre) && (glb_form as frmPedidoCierre).getCodigoTipoPedido() == Constantes.CodigosTiposPedidos.TipoPedidoPersona)
            {
                glb_form.Close();
            }
            
            glb_form = new frmPedidoCierre(new ModeloPedido() { codigoTipoPedido = Constantes.CodigosTiposPedidos.TipoPedidoProveedor });
            this.agregarFormulario(glb_form);

            (glb_form as frmPedidoCierre).AgregarLineaPedido += evento_agregarFormEmergente;
            (glb_form as frmPedidoCierre).MostrarDetallesArticulo += evento_agregarFormEmergente;
        }

        private void tlsbtnDevolucion_Click(object sender, EventArgs e)
        {
            if (!this.validarAgregarFormulario(typeof(frmPedidoDevolucion)))
            {
                return;
            }

            glb_form = new frmPedidoDevolucion();
            this.agregarFormulario(glb_form);
            (glb_form as frmPedidoDevolucion).IniciarDevolucionPedido += evento_iniciarDevolverPedido;
        }

        private void toolStripbtnFacturacion_Click(object sender, EventArgs e)
        {
            if (!this.validarAgregarFormulario(typeof(frmFacturacionMasiva)))
            {
                return;
            }

            glb_form = new frmFacturacionMasiva();
            this.agregarFormulario(glb_form);
        }

        private void toolStripbtnReportes_Click(object sender, EventArgs e)
        {
            if (!this.validarAgregarFormulario(typeof(frmReporteSeleccion)))
            {
                return;
            }

            glb_form = new frmReporteSeleccion();
            this.agregarFormulario(glb_form);
        }
        #endregion
 
        /// <summary>
        /// Forms nacidas de formularios principales que ocupan todo el panel principal. Ej: frmPedidoNuevo en frmPedidoCierre para agregar lineas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void evento_agregarFormEmergente(object sender, EventArgs e)
        {
            this.agregarFormulario(sender as Form);
            (sender as frmMaterialSkinBase).BringToFront();
            (sender as frmMaterialSkinBase).CerrarForm += evento_cerrarFormEmergente;
            if (sender.GetType() == typeof(frmPedidoDevolucion))
            {
                (sender as frmPedidoDevolucion).ContinuarDevolucionPedido += this.evento_continuarDevolverPedido;
            }
            this.currentFormLocked = true;
        }

        public void evento_cerrarFormEmergente(object sender, EventArgs e)
        {
            this.currentFormLocked = false;
        }

        public void evento_iniciarDevolverPedido(object sender, EventArgs e)
        {
            glb_form.Close();
            glb_form = new frmPedidoCierre((sender as frmPedidoDevolucion).controlador.pedidoActual, (sender as frmPedidoDevolucion).glb_mod_pedidoOriginal);
            this.agregarFormulario(glb_form);

            (glb_form as frmPedidoCierre).AgregarLineaPedido += evento_agregarFormEmergente;
            (glb_form as frmPedidoCierre).BuscarCliente += evento_agregarFormEmergente;
        }
        public void evento_continuarDevolverPedido(object sender, EventArgs e)
        {
            glb_form = new frmPedidoCierre((sender as frmPedidoDevolucion).controlador.pedidoActual, (sender as frmPedidoDevolucion).glb_mod_pedidoOriginal);
            (sender as Form).Close();
        }
        #endregion

        #region ToolStripMenuItem Exportar
        private void articuloProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.exportarDatos(typeof(ModeloArticuloProveedores));
        }

        private void artículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.exportarDatos(typeof(ModeloArticulos));
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.exportarDatos(typeof(ModeloCliente));
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.exportarDatos(typeof(ModeloProveedor));
        }

        private void descuentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.exportarDatos(typeof(ModeloDescuentoArticuloProveedor));
        }
        #endregion

        private void artículoImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.validarAgregarFormulario(typeof(frmImportarPreview)))
            {
                return;
            }

            glb_form = new frmImportarPreview(typeof(ModeloArticulos));

            this.agregarFormulario(glb_form);
        }
        private void artículoProveedorImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.validarAgregarFormulario(typeof(frmImportarPreview)))
            {
                return;
            }

            glb_form = new frmImportarPreview(typeof(ModeloArticuloProveedores));

            this.agregarFormulario(glb_form);
        }
        private void clientesImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.validarAgregarFormulario(typeof(frmImportarPreview)))
            {
                return;
            }

            glb_form = new frmImportarPreview(typeof(ModeloCliente));

            this.agregarFormulario(glb_form);
        }
        private void proveedorImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.validarAgregarFormulario(typeof(frmImportarPreview)))
            {
                return;
            }

            glb_form = new frmImportarPreview(typeof(ModeloProveedor));

            this.agregarFormulario(glb_form);
        }

        private void articuloProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void descuentosImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("proximamente");
        }


        private void preciosParaVentaImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("proximamente");
        }

        private void preciosParaCompraImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("proximamente");
        }

        private void toolStripbtnReimpresion_Click(object sender, EventArgs e)
        {
            if (!this.validarAgregarFormulario(typeof(frmReimpresion)))
            {
                return;
            }

            glb_form = new frmReimpresion();
            this.agregarFormulario(glb_form);
        }

        private void backUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog lcl_fbd = new FolderBrowserDialog();
            lcl_fbd.Description = "Destino de Archivo de Respaldo de Base de Datos";
            lcl_fbd.SelectedPath = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName +"\\Datos";
            string folderLocation;
            if (lcl_fbd.ShowDialog() == DialogResult.OK)
            {
                folderLocation = lcl_fbd.SelectedPath;
                bool exitoBackUp = false;
                frmLoading lcl_frm_loading = new frmLoading("Espere por favor. Realizando Backup de Base de Datos.");
                BackgroundWorker bw = new BackgroundWorker();
                ControladorBD lcl_con_BD = new ControladorBD();
                bw.DoWork += (s, ev) =>
                {
                    exitoBackUp = lcl_con_BD.backUpDatabase(folderLocation);
                };
                bw.RunWorkerCompleted += (s, ev) =>
                {
                lcl_frm_loading.Hide();
                if (exitoBackUp)
                { MessageBox.Show("El BackUp se realizó correctamente.", "Back Up OK", MessageBoxButtons.OK, MessageBoxIcon.Information); }
                else
                { MessageBox.Show("Error al realizar el BackUp.", "Back Up Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                };

                bw.RunWorkerAsync();
                lcl_frm_loading.ShowDialog(); 
            }
            else
            {
                return;
            }
        }

        

        

        

        

        

        

    
    }

    
}
