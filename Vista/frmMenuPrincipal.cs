﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
//using System.Data;
using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using Modelos;
using LibreriaClasesCompartidas;
using Controladores;

using System.Reflection;


namespace Vista
{
    public partial class frmMenuPrincipal : frmMaterialSkinBase
    {
        #region Atributos
        List<Form> glb_lst_formsActivos;
        Form glb_form;
        bool currentFormLocked
        { 
            get { return glb_lst_formsActivos.Count >1;} 
        }
        ModeloUsuario UsuarioActual;
        #endregion

        #region Constructores
        private frmMenuPrincipal()
        {
            InitializeComponent();

            this.inicializarForm();
            this.MinimizeBox = true;
            this.MaximizeBox = true;

            this.inicializarEventos();
            glb_lst_formsActivos = new List<Form>();
        }

        private void inicializarOpciones()
        {
            this.toolStripbtnABM.Enabled =
            this.toolStripbtnGestionPedidos.Enabled =
            this.toolStripbtnPedidoCliente.Enabled =
            this.toolStripbtnPedidoProveedor.Enabled =
            this.tlsbtnDevolucion.Enabled =
            this.toolStripbtnReportes.Enabled = false;

            this.exportarDatosToolStripMenuItem.Enabled = 
            this.importarDatosToolStripMenuItem.Enabled =
            this.baseDeDatosToolStripMenuItem.Enabled =
            this.configuracionToolStripMenuItem.Enabled =
            false;


            if (!object.Equals(this.UsuarioActual, null))
            {
                foreach (ModeloRoles rol in this.UsuarioActual.roles)
                {
                    switch (rol.codigo)
                    {
                        case 1:
                            this.toolStripbtnABM.Enabled =
                            this.toolStripbtnGestionPedidos.Enabled =
                            this.toolStripbtnPedidoCliente.Enabled =
                            this.toolStripbtnPedidoProveedor.Enabled =
                            this.tlsbtnDevolucion.Enabled =
                            this.toolStripbtnReportes.Enabled = true;

                            this.exportarDatosToolStripMenuItem.Enabled =
                            this.importarDatosToolStripMenuItem.Enabled =
                            this.baseDeDatosToolStripMenuItem.Enabled =
                            this.configuracionToolStripMenuItem.Enabled = true;
                            break;
                        case 2:
                            this.toolStripbtnReportes.Enabled = true;
                            break;
                        case 3:
                            this.toolStripbtnABM.Enabled = true;

                            this.exportarDatosToolStripMenuItem.Enabled =
                            this.importarDatosToolStripMenuItem.Enabled =
                            this.configuracionToolStripMenuItem.Enabled = true;
                            break;
                        case 4:
                            this.toolStripbtnGestionPedidos.Enabled =
                            this.toolStripbtnPedidoCliente.Enabled =
                            this.toolStripbtnPedidoProveedor.Enabled =
                            this.tlsbtnDevolucion.Enabled = true;
                            break;
                        default:
                            break;
                    }
                }
            }
        }

        public frmMenuPrincipal(ModeloUsuario p_usuarioActual) : this()
        {
            UsuarioActual = p_usuarioActual;
            this.inicializarOpciones();
            if (this.inicializarModoFormulario(p_usuarioActual))
            {
                lblNombreUsuario.Text = p_usuarioActual.usuario ;
            }
            else 
            {
                MessageBox.Show("El usuario actual no posee roles asignados. Contacte al administrador.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            this.actualizarColores();
            ControladorAFIP.Iniciar();
            ControladorParametrosGenerales.Iniciar();
            ModeloPedido.cuitEmisor = ControladorAFIP.CuitEmisor;
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
        
        private void inicializarEventos()
        {
            this.btnSalir.Click += (s, e) => { this.Close(); };
            this.salirToolStripMenuItem.Click += (s, e) => { this.Close(); };

            this.ayudaToolStripButton.Click += this.mostrarManualDeAyuda;
            this.verAyudaToolStripMenuItem.Click += this.mostrarManualDeAyuda;

            this.inicializarFuncionesDeTexto();
        }
        private void inicializarFuncionesDeTexto()
        {
            this.copiarToolStripButton.Click += this.copiarTextoEnControl;
            this.copiarToolStripMenuItem.Click += this.copiarTextoEnControl;

            this.cortarToolStripButton.Click += this.cortarTextoEnControl;
            this.cortarToolStripMenuItem.Click += this.cortarTextoEnControl;

            this.pegarToolStripButton.Click += this.pegarTextoEnControl;
            this.pegarToolStripMenuItem.Click += this.pegarTextoEnControl;

            this.seleccionarTodoToolStripMenuItem.Click += this.seleccionarTodoTextoEnControl;
            this.eliminarToolStripMenuItem.Click += this.eliminarTodoTextoEnControl;
            this.deshacerToolStripMenuItem.Click += this.deshacerTextoEnControl;
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
            //Width = 800;
            //Height = 600;
            
            this.tblLayoutPanelPrincipal.Location = new Point(3, 60);
            this.tblLayoutPanelPrincipal.Height = Height - 60; // 60 pixeles para que se vea título de ventana principal
            this.tblLayoutPanelPrincipal.Width = Width -3; //un margen derecho de 3
        }
        /// <summary>
        /// Actualiza color de tableLayout que se encuentra al bottom del form
        /// </summary>
        public override void actualizarColores()
        {
            /*
             * códigos de colores extraídos de: https://www.materialui.co/colors
             */
            if(this.tblLayoutPanelPrincipal_Bottom == null)
            { return; }
            base.actualizarColores();
            
            switch (Properties.Settings.Default.color_scheme)
            {
                case 0:
                    this.tblLayoutPanelPrincipal_Bottom.BackColor = Color.FromArgb(0, 188, 212);    //Cyan500
                    break;
                case 1:
                    this.tblLayoutPanelPrincipal_Bottom.BackColor = Color.FromArgb(30,136,229);   //Blue600
                    break;
                case 2:
                    this.tblLayoutPanelPrincipal_Bottom.BackColor = Color.FromArgb(55,71,79);    //BlueGrey800
                    break;
                case 3:
                    this.tblLayoutPanelPrincipal_Bottom.BackColor = Color.FromArgb(63,81,181);   //Indigo500
                    break;
                case 4:
                    this.tblLayoutPanelPrincipal_Bottom.BackColor = Color.FromArgb(67,160,71);  //Green600
                    break;
                case 5:
                    this.tblLayoutPanelPrincipal_Bottom.BackColor = Color.FromArgb(255,193,7);   //Amber500
                    break;
                case 6:
                    this.tblLayoutPanelPrincipal_Bottom.BackColor = Color.FromArgb(121,85,72);   //Brown500
                    break;
                default:
                    //en caso que no sea ninguno de los preestablecidos, lo seteamos en 0
                    this.tblLayoutPanelPrincipal_Bottom.BackColor = Color.FromArgb(0, 188, 212);    //Cyan500
                    Properties.Settings.Default.color_scheme = 0;
                    Properties.Settings.Default.Save();
                    break;

            }
        }
        #endregion

        #region Auxiliares para agregar forms
        private void agregarFormulario(Form p_form)
        {
            Type T = p_form.GetType();
            //glb_form.FormClosing += (s, p) => { this.glb_form = new Form(); };//Permite abrir el mismo tipo de formulario recién cerrado.   //se crea evento por cada form agregada(revisar)
            foreach (Type t in T.Assembly.GetTypes())
            {//Chequea si hereda de frmMaterialSkinBase
                if (t == typeof(frmMaterialSkinBase))
                {
                    p_form.TopLevel = false;
                    p_form.Dock = DockStyle.Fill;
                    this.pnlContenedorForm.Controls.Add(p_form);
                    p_form.Show();
                    (p_form as frmMaterialSkinBase).inicializarForm(this.pnlContenedorForm.Width, this.pnlContenedorForm.Height);

                    glb_lst_formsActivos.Add(p_form);
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
            else if (glb_form.GetType() != T ||                     //Si son distintos tipos de formularios
                    this.pnlContenedorForm.Controls.Count == 0 ||   //En caso de que el glb_form se cerro y frmMenuPrincipal no se entero
                    glb_form.GetType() == typeof(frmImportar))      //Hay distintos tipos de importar (articulos, clientes, etc) bajo el mismo type de formulario
            {
                return this.cerrarFormActual(glb_form);
                //Mensaje para confirmar que si cierre se pierde el progreso hecho en el form 
                //return true;
            }
            //else if ()
            //{
            //    this.cerrarFormActual(glb_form);
            //    return true;    //lo cerramos por mas de que ya esté abierto porque puede haber importación de distintos tipos de modelos y no lo detecta
            //}
            else
            {
                return false;
            }
        }

        private bool cerrarFormActual(Form p_form)
        {
            if (p_form == glb_form)
            {
                glb_form.DialogResult = System.Windows.Forms.DialogResult.OK;
                glb_form.Close();
                if(glb_form.DialogResult != System.Windows.Forms.DialogResult.Cancel)   //En caso de que se agregue mensaje de confirmación cerrar ventana
                {
                    glb_lst_formsActivos.Remove(glb_form);
                    glb_form = new Form();
                    this.pnlContenedorForm.Controls.Clear();
                    return true;
                }
                
                return false;
            }
            glb_lst_formsActivos.Remove(p_form);

           
            return true;
        }
        #endregion
        
        #endregion

        #region Eventos

        #region Timer
        private void timerFechaHora_Tick(object sender, EventArgs e)
        {
            lblFechaLog.Text = DateTime.Today.ToString("dd/MM/yyyy");
            lblHoraLog.Text = DateTime.Now.ToString("HH:mm:ss tt");
        }
        #endregion

        #region ABMs
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

        #region Pedidos
        private void toolStripbtnPedidoCliente_Click(object sender, EventArgs e)
        {
            if (!this.validarAgregarFormulario(typeof(frmPedidoCierre)))
            {
                if (currentFormLocked)
                {
                    return;
                }
                else if (glb_form.GetType() != typeof(frmPedidoCierre) || (glb_form as frmPedidoCierre).getCodigoTipoPedido() == Constantes.CodigosTiposPedidos.Persona)//En caso de que se agregue mensaje de confirmación cerrar ventana
                {
                    return;
                }
            }

            if (glb_form != null && glb_form.GetType() == typeof(frmPedidoCierre) && (glb_form as frmPedidoCierre).getCodigoTipoPedido() == Constantes.CodigosTiposPedidos.Proveedor)
            {
                this.cerrarFormActual(glb_form);
            }

            glb_form = new frmPedidoCierre(new ModeloPedido() { codigoTipoPedido = Constantes.CodigosTiposPedidos.Persona });
            this.agregarFormulario(glb_form);

            (glb_form as frmPedidoCierre).AgregarLineaPedido += evento_agregarFormEmergente;
            (glb_form as frmPedidoCierre).BuscarCliente += evento_agregarFormEmergente;
            (glb_form as frmPedidoCierre).MostrarDetallesArticulo += evento_agregarFormEmergente;
            (glb_form as frmPedidoCierre).MostrarComprobante += evento_agregarFormEmergente;

        }
        private void toolStripbtnPedidoProveedor_Click(object sender, EventArgs e)
        {
            if (!this.validarAgregarFormulario(typeof(frmPedidoCierre)))
            {
                if (currentFormLocked)
                {
                    return;
                }
                else if (glb_form.GetType() != typeof(frmPedidoCierre) || (glb_form as frmPedidoCierre).getCodigoTipoPedido() == Constantes.CodigosTiposPedidos.Proveedor)//En caso de que se agregue mensaje de confirmación cerrar ventana
                {
                    return;
                }
            }
            if (glb_form != null && glb_form.GetType() == typeof(frmPedidoCierre) && (glb_form as frmPedidoCierre).getCodigoTipoPedido() == Constantes.CodigosTiposPedidos.Persona)
            {
                this.cerrarFormActual(glb_form);
            }

            glb_form = new frmPedidoCierre(new ModeloPedido() { codigoTipoPedido = Constantes.CodigosTiposPedidos.Proveedor });
            this.agregarFormulario(glb_form);

            (glb_form as frmPedidoCierre).AgregarLineaPedido += evento_agregarFormEmergente;
            (glb_form as frmPedidoCierre).MostrarDetallesArticulo += evento_agregarFormEmergente;
            (glb_form as frmPedidoCierre).MostrarComprobante += evento_agregarFormEmergente;
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
        private void toolStripbtnGestionPedidos_Click(object sender, EventArgs e)
        {
            if (!this.validarAgregarFormulario(typeof(frmPedidoGestion)))
            {
                return;
            }

            glb_form = new frmPedidoGestion();
            (glb_form as frmPedidoGestion).verDetallesPedido += evento_agregarFormEmergente;
            (glb_form as frmPedidoGestion).MostrarComprobante += evento_agregarFormEmergente;
            this.agregarFormulario(glb_form);
        }
        #endregion

        #region Reportes
        private void toolStripbtnReportes_Click(object sender, EventArgs e)
        {
            if (!this.validarAgregarFormulario(typeof(frmReporteSeleccion)))
            {
                return;
            }

            glb_form = new frmReporteSeleccion();
            this.agregarFormulario(glb_form);

            (glb_form as frmReporteSeleccion).MostrarComprobante += evento_agregarFormEmergente;
        }
        #endregion

        #region Auxiliares para agregar forms
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
            if (sender.GetType() == typeof(frmPedidoNuevo))
            {
                (sender as frmPedidoNuevo).MostrarDetallesArticulo += this.evento_agregarFormEmergente;
            }
            if (sender.GetType() == typeof(frmPedidoCierre))
            {
                (sender as frmPedidoCierre).MostrarComprobante += this.evento_agregarFormEmergente;
            }
        }
        
        public void evento_cerrarFormEmergente(object sender, EventArgs e)
        {
            this.cerrarFormActual(sender as Form);
        }

        public void evento_iniciarDevolverPedido(object sender, EventArgs e)
        {
            this.cerrarFormActual(glb_form);
            glb_form = new frmPedidoCierre((sender as frmPedidoDevolucion).controlador.pedidoActual, (sender as frmPedidoDevolucion).glb_mod_pedidoOriginal);
            this.agregarFormulario(glb_form);

            (glb_form as frmPedidoCierre).AgregarLineaPedido += evento_agregarFormEmergente;
            (glb_form as frmPedidoCierre).BuscarCliente += evento_agregarFormEmergente;
            (glb_form as frmPedidoCierre).MostrarComprobante += evento_agregarFormEmergente;
        }
        public void evento_continuarDevolverPedido(object sender, EventArgs e)
        {
            glb_form = new frmPedidoCierre((sender as frmPedidoDevolucion).controlador.pedidoActual, (sender as frmPedidoDevolucion).glb_mod_pedidoOriginal);
            this.cerrarFormActual(sender as Form);
        }
        #endregion

        #region Exportar, importar, BackUp y restauración de base de datos
      
        #region Exportar
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
                    exito = lcl_con_excel.Exportar(T, direccionDeArchivo);
                };
                bw.RunWorkerCompleted += (s, e) =>
                {
                    lcl_frm_loading.Hide();

                    if (exito)
                    {
                        MessageBox.Show(lcl_con_excel.errorActual, "Éxito", MessageBoxButtons.OK);
                    }
                    else
                    {
                        System.Windows.Forms.DialogResult dialogResult = MessageBox.Show(lcl_con_excel.errorActual, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
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
        #endregion
       
        #region Importar
        private void artículoImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.validarAgregarFormulario(typeof(frmImportar)))
            {
                return;
            }

            glb_form = new frmImportar(typeof(ModeloArticulos));

            this.agregarFormulario(glb_form);
        }
        private void artículoProveedorImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.validarAgregarFormulario(typeof(frmImportar)))
            {
                return;
            }

            glb_form = new frmImportar(typeof(ModeloArticuloProveedores));

            this.agregarFormulario(glb_form);
        }
        private void clientesImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.validarAgregarFormulario(typeof(frmImportar)))
            {
                return;
            }

            glb_form = new frmImportar(typeof(ModeloCliente));

            this.agregarFormulario(glb_form);
        }
        private void proveedorImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.validarAgregarFormulario(typeof(frmImportar)))
            {
                return;
            }

            glb_form = new frmImportar(typeof(ModeloProveedor));

            this.agregarFormulario(glb_form);
        }

        private void preciosParaVentaImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.validarAgregarFormulario(typeof(frmImportar)))
            {
                return;
            }

            glb_form = new frmImportar(typeof(ModeloValorArticulo), true);

            this.agregarFormulario(glb_form);
        }

        private void preciosParaCompraImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.validarAgregarFormulario(typeof(frmImportar)))
            {
                return;
            }

            glb_form = new frmImportar(typeof(ModeloValorArticulo), false);

            this.agregarFormulario(glb_form);
        }
        #endregion

        #region BackUp base de datos
        private void backUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog lcl_fbd = new FolderBrowserDialog();
            lcl_fbd.Description = "Destino de Archivo de Respaldo de Base de Datos";
            //lcl_fbd.SelectedPath = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName + "\\Datos";
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
        #endregion

        #region Restaurar Base de datos
        private void restaurarBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = null;
            OpenFileDialog lcl_ofd = new OpenFileDialog();
            lcl_ofd.Filter = "Archivo de BackUp |*.bak";
            lcl_ofd.FilterIndex = 1;
            lcl_ofd.Multiselect = false;
            if (lcl_ofd.ShowDialog() == DialogResult.OK)
            {
                if (lcl_ofd.CheckPathExists && lcl_ofd.CheckFileExists)
                {
                    filePath = lcl_ofd.FileName;
                }
            }
            if (!string.IsNullOrWhiteSpace(filePath))
            {
                this.restoreDatabase(filePath);
            }
        }
        private void restoreDatabase(string p_path)
        {
            bool exito = false;
            ControladorBD lcl_con_bd = new ControladorBD();

            frmLoading lcl_frm_loading = new frmLoading("Espere por favor. Realizando restauración de base de datos.");
            frmResultadoBusqueda lcl_frm_resultadoBusqueda = new frmResultadoBusqueda();

            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += (s, e) =>
            {
                exito = lcl_con_bd.restoreDatabase(p_path);
            };
            bw.RunWorkerCompleted += (s, e) =>
            {
                lcl_frm_loading.Hide();

                if (exito)
                {
                    MessageBox.Show("Restauración de base de datos exitosa", "Éxito", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show(lcl_con_bd.errorActual, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            bw.RunWorkerAsync();
            lcl_frm_loading.ShowDialog();
        }
        #endregion

        #endregion

        #region Manual de Ayuda
        private void mostrarManualDeAyuda(object sender, EventArgs e)
        {
            if (glb_form == null || glb_form.IsDisposed)//null en caso que no se haya abierto ninguna ventana, y IsDisposed en caso de que se haya abierto y cerrado una ventana
            {
                string lcl_dir_help = System.IO.Path.GetDirectoryName(
            System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase); 
                //lcl_dir_help = lcl_dir_help + "\\Vista\\Resources\\HelpMenu\\helpmenuproyecto.chm";
                lcl_dir_help = lcl_dir_help + @"\Resources\HelpMenu\help.chm";
                Help.ShowHelp(this, lcl_dir_help, HelpNavigator.TableOfContents);
                
            }
            else
            { this.mostrarManual(glb_form.GetType()); }
        }
        private void mostrarManual(Type p_ventanaActiva)
        { 
            
            string topic = "";
            if (p_ventanaActiva == typeof(frmABMArticulo))
            { topic = "1_ALTASBAJASYMODIFICACIONES"; }
            else if (p_ventanaActiva == typeof(frmABMDescuentos))
            { topic = "5_DESCUENTO"; }
            else if (p_ventanaActiva == typeof(frmABMEntidad))
            {
                if ((glb_form as frmABMEntidad).tipoEntidadSeleccionada == Constantes.TiposEntidad.TiposPersona.Cliente)
                { topic = "3_CLIENTES"; }
                else if ((glb_form as frmABMEntidad).tipoEntidadSeleccionada == Constantes.TiposEntidad.TiposPersona.ContactoProveedor)
                { topic = "4_CONTACTODEPROVEEDOR"; }
                else if ((glb_form as frmABMEntidad).tipoEntidadSeleccionada == Constantes.TiposEntidad.TiposPersona.Usuario)
                { topic = "7_USUARIO"; }
                else
                { topic = "6_PROVEEDOR"; }
            }
            else if (p_ventanaActiva == typeof(frmPedidoGestion))
            { topic = "8_ADMINISTRADORDEPEDIDOS"; }
            else if (p_ventanaActiva == typeof(frmPedidoCierre))
            {
                if ((glb_form as frmPedidoCierre).modoFormulario == "Pedido Cliente")
                { topic = "38_PEDIDODECLIENTE-VENTAS"; }
                else if ((glb_form as frmPedidoCierre).modoFormulario == "Pedido a Proveedor(es)")
                { topic = "31_PEDIDOAPROVEEDORES-COMPRAS"; }
                else { topic = "13_DEVOLUCIONES"; }
            }
            else if (p_ventanaActiva == typeof(frmPedidoDevolucion))
            { topic = "13_DEVOLUCIONES"; }
            else if (p_ventanaActiva == typeof(frmPedidoNuevo))
            {
                if ((glb_form as frmPedidoNuevo).controlador.pedidoActual.codigoTipoPedido == Constantes.CodigosTiposPedidos.Persona)
                { topic = "40_AGREGARUNARTCULOALPEDIDODEVENTA"; }
                else { topic = "33_AGREGARUNARTCULOALPEDIDODEPROVEEDOR"; }
            }
            
            else if (p_ventanaActiva == typeof(frmReporteSeleccion))
            {
                if ((glb_form as frmReporteSeleccion).tabControl.SelectedTab == (glb_form as frmReporteSeleccion).tabProveedores)
                { topic = "35_REPORTESDECOMPRA"; }
                else if ((glb_form as frmReporteSeleccion).tabControl.SelectedTab == (glb_form as frmReporteSeleccion).tabClientes)
                { topic = "37_REPORTESDEVENTAS"; }
                else { topic = "36_REPORTESDEINVENTARIO"; }
            }
            else if (p_ventanaActiva == typeof(frmImportar))
            { topic = "17_MANEJODEDATOS"; }
            else if (p_ventanaActiva == typeof(frmConfiguracion))
            { topic = "26_CONFIGURACIN"; }
            else if (p_ventanaActiva == typeof(frmOpcionesUsuario))
            {
                if ((glb_form as frmOpcionesUsuario).tbControlPrincipal.SelectedTab == (glb_form as frmOpcionesUsuario).tbEstiloVisual)
                { topic = "23_ESTILOVISUAL"; }
                else if ((glb_form as frmOpcionesUsuario).tbControlPrincipal.SelectedTab == (glb_form as frmOpcionesUsuario).tbPageDatosGenerales)
                { topic = "24_DATOSGENERALES"; }
                else
                { topic = "25_DATOSDECONTACTO"; }
            }
            else
            { topic = "1_ALTASBAJASYMODIFICACIONES"; }

            string lcl_dir_help = System.IO.Path.GetDirectoryName(
            System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase); 
            lcl_dir_help = lcl_dir_help + @"\Resources\HelpMenu\help.chm";

            Help.ShowHelp(glb_form, lcl_dir_help, HelpNavigator.Topic, topic + ".htm");

                    }
        #endregion

        #region Funciones de texto
        private void copiarTextoEnControl(object sender, EventArgs e)
        {
            if ((this.ActiveControl as Form) == null)
            {
                return;
            }
            Control c = (this.ActiveControl as Form).ActiveControl;

            if (c is TextBox)
            {
                if ((c as TextBox).SelectedText != "")
                {
                    (c as TextBox).Copy();
                }
            }
            else if (c is RichTextBox)
            {
                if ((c as RichTextBox).SelectedText != "")
                {
                    (c as RichTextBox).Copy();
                }
            }
        }
        private void cortarTextoEnControl(object sender, EventArgs e)
        {
            if ((this.ActiveControl as Form) == null)
            {
                return;
            }
            Control c = (this.ActiveControl as Form).ActiveControl;
            
            if (c is TextBox)
            {
                if ((c as TextBox).SelectedText != "")
                {
                    (c as TextBox).Cut();
                }
                
            }
            else if (c is RichTextBox)
            {
                if ((c as RichTextBox).SelectedText != "")
                {
                    (c as RichTextBox).Cut();
                }
            }
        }
        private void pegarTextoEnControl(object sender, EventArgs e)
        {
            if ((this.ActiveControl as Form) == null)
            {
                return;
            }
            Control c = (this.ActiveControl as Form).ActiveControl;

            if (c is TextBox)
            {
                ((TextBox)c).Paste();
            }
            else if (c is RichTextBox)
            {
                ((RichTextBox)c).Paste();
            }
        }
        private void seleccionarTodoTextoEnControl(object sender, EventArgs e)
        {
            if ((this.ActiveControl as Form) == null)
            {
                return;
            }
            Control c = (this.ActiveControl as Form).ActiveControl;

            if (c is TextBox)
            {
                (c as TextBox).SelectAll();
            }
            else if (c is RichTextBox)
            {
                (c as RichTextBox).SelectAll();
            }
        }
        private void eliminarTodoTextoEnControl(object sender, EventArgs e)
        {
            if ((this.ActiveControl as Form) == null)
            {
                return;
            }
            Control c = (this.ActiveControl as Form).ActiveControl;

            if (c is TextBox)
            {
                (c as TextBox).Text = "";
            }
            else if (c is RichTextBox)
            {
                (c as RichTextBox).Text = "";
            }
        }
        private void deshacerTextoEnControl(object sender, EventArgs e)
        {
            if ((this.ActiveControl as Form) == null)
            {
                return;
            }
            Control c = (this.ActiveControl as Form).ActiveControl;

            if (c is TextBox)
            {
                if ((c as TextBox).CanUndo)
                {
                    (c as TextBox).Undo();
                }
                
            }
            else if (c is RichTextBox)
            {
                if ((c as RichTextBox).CanUndo)
                {
                    (c as RichTextBox).Undo();
                }
            }
        }
        #endregion

        #region Eventos propios de frmMenuPrincipal
        private void frmMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Validar que se puede cerrar
            if (MessageBox.Show("¿Esta seguro que desea cerrar la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                //hacer cosas que haya que hacer antes de cerrar. Guardar log de usuario, algo
            }
            else
            {
                e.Cancel = true;
            }
        }
        private void frmMenuPrincipal_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            this.mostrarManualDeAyuda(sender, hlpevent);
        }
        #endregion

        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.validarAgregarFormulario(typeof(frmConfiguracion)))
            {
                return;
            }

            glb_form = new frmConfiguracion();
            this.agregarFormulario(glb_form);
        }
        private void opcionesDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.validarAgregarFormulario(typeof(frmOpcionesUsuario)))
            {
                return;
            }

            glb_form = new frmOpcionesUsuario(UsuarioActual);

            this.agregarFormulario(glb_form);

            (glb_form as frmOpcionesUsuario).ActualizarColoresEvent += this.actualizarColores;
            (glb_form as frmOpcionesUsuario).ActualizarUsuario += this.actualizarUsuario;
        }

        private void actualizarUsuario(object sender, EventArgs e)
        {
            UsuarioActual = (sender as ModeloUsuario);
        }
        private void actualizarColores(object sender, EventArgs e)
        {
            this.actualizarColores();
        }
        #endregion

        
    }    
}
