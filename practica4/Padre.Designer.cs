namespace practica4
{
    partial class Padre
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Padre));
            this.mStrip = new System.Windows.Forms.MenuStrip();
            this.archivo_Padre = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevo_Padre = new System.Windows.Forms.ToolStripMenuItem();
            this.abrir_Padre = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cerrarTodo_Padre = new System.Windows.Forms.ToolStripMenuItem();
            this.salir_Padre = new System.Windows.Forms.ToolStripMenuItem();
            this.ventana_Padre = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeIcons_Padre = new System.Windows.Forms.ToolStripMenuItem();
            this.cascada_Padre = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontal_Padre = new System.Windows.Forms.ToolStripMenuItem();
            this.vertical_Padre = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ver_Padre = new System.Windows.Forms.ToolStripMenuItem();
            this.barraDeEstadoVer_Padre = new System.Windows.Forms.ToolStripMenuItem();
            this.barraEstado_Padre = new System.Windows.Forms.StatusStrip();
            this.constante_S = new System.Windows.Forms.ToolStripStatusLabel();
            this.titulo_S = new System.Windows.Forms.ToolStripStatusLabel();
            this.herramientas_Padre = new System.Windows.Forms.ToolStrip();
            this.nuevo_boton = new System.Windows.Forms.ToolStripButton();
            this.abrir_boton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.deshacer_boton = new System.Windows.Forms.ToolStripButton();
            this.hacer_boton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.alinear = new System.Windows.Forms.ToolStripDropDownButton();
            this.alinear_izquierda = new System.Windows.Forms.ToolStripMenuItem();
            this.alinear_centro = new System.Windows.Forms.ToolStripMenuItem();
            this.alinear_derecha = new System.Windows.Forms.ToolStripMenuItem();
            this.negrita = new System.Windows.Forms.ToolStripButton();
            this.cursiva = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.copiar_boton = new System.Windows.Forms.ToolStripButton();
            this.pegar_boton = new System.Windows.Forms.ToolStripButton();
            this.cortar_boton = new System.Windows.Forms.ToolStripButton();
            this.menuClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cortarMenuClick = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarMenuClick = new System.Windows.Forms.ToolStripMenuItem();
            this.pegarMenuClick = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.fuenteMenuClick = new System.Windows.Forms.ToolStripMenuItem();
            this.parrafoMenuClick = new System.Windows.Forms.ToolStripMenuItem();
            this.alinearIzquierdaMenuClick = new System.Windows.Forms.ToolStripMenuItem();
            this.centrarMenuClick = new System.Windows.Forms.ToolStripMenuItem();
            this.alinearDerechaMenuClick = new System.Windows.Forms.ToolStripMenuItem();
            this.contextBarraEstado = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.barraEstadoMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mStrip.SuspendLayout();
            this.barraEstado_Padre.SuspendLayout();
            this.herramientas_Padre.SuspendLayout();
            this.menuClick.SuspendLayout();
            this.contextBarraEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // mStrip
            // 
            this.mStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivo_Padre,
            this.ventana_Padre,
            this.ver_Padre});
            this.mStrip.Location = new System.Drawing.Point(0, 0);
            this.mStrip.MdiWindowListItem = this.ventana_Padre;
            this.mStrip.Name = "mStrip";
            this.mStrip.Size = new System.Drawing.Size(840, 24);
            this.mStrip.TabIndex = 0;
            this.mStrip.Text = "menuStrip1";
            // 
            // archivo_Padre
            // 
            this.archivo_Padre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevo_Padre,
            this.abrir_Padre,
            this.toolStripSeparator2,
            this.cerrarTodo_Padre,
            this.salir_Padre});
            this.archivo_Padre.Name = "archivo_Padre";
            this.archivo_Padre.Size = new System.Drawing.Size(60, 20);
            this.archivo_Padre.Text = "Archivo";
            // 
            // nuevo_Padre
            // 
            this.nuevo_Padre.Name = "nuevo_Padre";
            this.nuevo_Padre.Size = new System.Drawing.Size(134, 22);
            this.nuevo_Padre.Text = "Nuevo";
            this.nuevo_Padre.Click += new System.EventHandler(this.nuevo_Padre_Click);
            // 
            // abrir_Padre
            // 
            this.abrir_Padre.Name = "abrir_Padre";
            this.abrir_Padre.Size = new System.Drawing.Size(134, 22);
            this.abrir_Padre.Text = "Abrir";
            this.abrir_Padre.Click += new System.EventHandler(this.abrir_Padre_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(131, 6);
            // 
            // cerrarTodo_Padre
            // 
            this.cerrarTodo_Padre.Name = "cerrarTodo_Padre";
            this.cerrarTodo_Padre.Size = new System.Drawing.Size(134, 22);
            this.cerrarTodo_Padre.Text = "Cerrar todo";
            this.cerrarTodo_Padre.Click += new System.EventHandler(this.cerrarTodo_Padre_Click);
            // 
            // salir_Padre
            // 
            this.salir_Padre.Name = "salir_Padre";
            this.salir_Padre.Size = new System.Drawing.Size(134, 22);
            this.salir_Padre.Text = "Salir";
            this.salir_Padre.Click += new System.EventHandler(this.salir_Padre_Click);
            // 
            // ventana_Padre
            // 
            this.ventana_Padre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arrangeIcons_Padre,
            this.cascada_Padre,
            this.horizontal_Padre,
            this.vertical_Padre,
            this.toolStripSeparator1});
            this.ventana_Padre.Name = "ventana_Padre";
            this.ventana_Padre.Size = new System.Drawing.Size(61, 20);
            this.ventana_Padre.Text = "Ventana";
            // 
            // arrangeIcons_Padre
            // 
            this.arrangeIcons_Padre.Name = "arrangeIcons_Padre";
            this.arrangeIcons_Padre.Size = new System.Drawing.Size(147, 22);
            this.arrangeIcons_Padre.Text = "Arrange Icons";
            this.arrangeIcons_Padre.Click += new System.EventHandler(this.arrangeIcons_Padre_Click);
            // 
            // cascada_Padre
            // 
            this.cascada_Padre.Name = "cascada_Padre";
            this.cascada_Padre.Size = new System.Drawing.Size(147, 22);
            this.cascada_Padre.Text = "Cascada";
            this.cascada_Padre.Click += new System.EventHandler(this.cascada_Padre_Click);
            // 
            // horizontal_Padre
            // 
            this.horizontal_Padre.Name = "horizontal_Padre";
            this.horizontal_Padre.Size = new System.Drawing.Size(147, 22);
            this.horizontal_Padre.Text = "Horizontal";
            this.horizontal_Padre.Click += new System.EventHandler(this.horizontal_Padre_Click);
            // 
            // vertical_Padre
            // 
            this.vertical_Padre.Name = "vertical_Padre";
            this.vertical_Padre.Size = new System.Drawing.Size(147, 22);
            this.vertical_Padre.Text = "Vertical";
            this.vertical_Padre.Click += new System.EventHandler(this.vertical_Padre_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(144, 6);
            // 
            // ver_Padre
            // 
            this.ver_Padre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barraDeEstadoVer_Padre});
            this.ver_Padre.Name = "ver_Padre";
            this.ver_Padre.Size = new System.Drawing.Size(35, 20);
            this.ver_Padre.Text = "Ver";
            // 
            // barraDeEstadoVer_Padre
            // 
            this.barraDeEstadoVer_Padre.Checked = true;
            this.barraDeEstadoVer_Padre.CheckOnClick = true;
            this.barraDeEstadoVer_Padre.CheckState = System.Windows.Forms.CheckState.Checked;
            this.barraDeEstadoVer_Padre.Name = "barraDeEstadoVer_Padre";
            this.barraDeEstadoVer_Padre.Size = new System.Drawing.Size(155, 22);
            this.barraDeEstadoVer_Padre.Text = "Barra de estado";
            this.barraDeEstadoVer_Padre.Click += new System.EventHandler(this.barraDeEstadoVer_Padre_Click);
            // 
            // barraEstado_Padre
            // 
            this.barraEstado_Padre.ContextMenuStrip = this.contextBarraEstado;
            this.barraEstado_Padre.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.constante_S,
            this.titulo_S});
            this.barraEstado_Padre.Location = new System.Drawing.Point(0, 428);
            this.barraEstado_Padre.Name = "barraEstado_Padre";
            this.barraEstado_Padre.Size = new System.Drawing.Size(840, 22);
            this.barraEstado_Padre.TabIndex = 2;
            this.barraEstado_Padre.Text = "statusStrip1";
            // 
            // constante_S
            // 
            this.constante_S.Name = "constante_S";
            this.constante_S.Size = new System.Drawing.Size(0, 17);
            // 
            // titulo_S
            // 
            this.titulo_S.Name = "titulo_S";
            this.titulo_S.Size = new System.Drawing.Size(794, 17);
            this.titulo_S.Spring = true;
            this.titulo_S.Text = "toolStripStatusLabel2";
            // 
            // herramientas_Padre
            // 
            this.herramientas_Padre.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevo_boton,
            this.abrir_boton,
            this.toolStripSeparator3,
            this.deshacer_boton,
            this.hacer_boton,
            this.toolStripSeparator4,
            this.alinear,
            this.negrita,
            this.cursiva,
            this.toolStripSeparator5,
            this.copiar_boton,
            this.pegar_boton,
            this.cortar_boton});
            this.herramientas_Padre.Location = new System.Drawing.Point(0, 24);
            this.herramientas_Padre.Name = "herramientas_Padre";
            this.herramientas_Padre.Size = new System.Drawing.Size(840, 25);
            this.herramientas_Padre.TabIndex = 4;
            this.herramientas_Padre.Text = "toolStrip1";
            // 
            // nuevo_boton
            // 
            this.nuevo_boton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nuevo_boton.Image = global::practica4.Properties.Resources.nuevo;
            this.nuevo_boton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nuevo_boton.Name = "nuevo_boton";
            this.nuevo_boton.Size = new System.Drawing.Size(23, 22);
            this.nuevo_boton.Text = "Nuevo";
            this.nuevo_boton.Click += new System.EventHandler(this.nuevo_boton_Click);
            // 
            // abrir_boton
            // 
            this.abrir_boton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.abrir_boton.Image = global::practica4.Properties.Resources.abrir;
            this.abrir_boton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.abrir_boton.Name = "abrir_boton";
            this.abrir_boton.Size = new System.Drawing.Size(23, 22);
            this.abrir_boton.Text = "Abrir";
            this.abrir_boton.Click += new System.EventHandler(this.abrir_boton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // deshacer_boton
            // 
            this.deshacer_boton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deshacer_boton.Image = global::practica4.Properties.Resources.deshacer;
            this.deshacer_boton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deshacer_boton.Name = "deshacer_boton";
            this.deshacer_boton.Size = new System.Drawing.Size(23, 22);
            this.deshacer_boton.Text = "Deshacer";
            this.deshacer_boton.Click += new System.EventHandler(this.deshacer_boton_Click);
            // 
            // hacer_boton
            // 
            this.hacer_boton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hacer_boton.Image = global::practica4.Properties.Resources.redo;
            this.hacer_boton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.hacer_boton.Name = "hacer_boton";
            this.hacer_boton.Size = new System.Drawing.Size(23, 22);
            this.hacer_boton.Text = "Rehacer";
            this.hacer_boton.Click += new System.EventHandler(this.hacer_boton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // alinear
            // 
            this.alinear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.alinear.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alinear_izquierda,
            this.alinear_centro,
            this.alinear_derecha});
            this.alinear.Image = global::practica4.Properties.Resources.alinear;
            this.alinear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.alinear.Name = "alinear";
            this.alinear.Size = new System.Drawing.Size(29, 22);
            this.alinear.Text = "Párrafo";
            // 
            // alinear_izquierda
            // 
            this.alinear_izquierda.CheckOnClick = true;
            this.alinear_izquierda.Image = global::practica4.Properties.Resources.izquierda;
            this.alinear_izquierda.Name = "alinear_izquierda";
            this.alinear_izquierda.Size = new System.Drawing.Size(122, 22);
            this.alinear_izquierda.Text = "izquierda";
            this.alinear_izquierda.Click += new System.EventHandler(this.alinear_izquierda_Click);
            // 
            // alinear_centro
            // 
            this.alinear_centro.CheckOnClick = true;
            this.alinear_centro.Image = global::practica4.Properties.Resources.alinear;
            this.alinear_centro.Name = "alinear_centro";
            this.alinear_centro.Size = new System.Drawing.Size(122, 22);
            this.alinear_centro.Text = "centrar";
            this.alinear_centro.Click += new System.EventHandler(this.alinear_centro_Click);
            // 
            // alinear_derecha
            // 
            this.alinear_derecha.CheckOnClick = true;
            this.alinear_derecha.Image = global::practica4.Properties.Resources.derecha;
            this.alinear_derecha.Name = "alinear_derecha";
            this.alinear_derecha.Size = new System.Drawing.Size(122, 22);
            this.alinear_derecha.Text = "derecha";
            this.alinear_derecha.Click += new System.EventHandler(this.alinear_derecha_Click);
            // 
            // negrita
            // 
            this.negrita.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.negrita.Image = global::practica4.Properties.Resources.negrita;
            this.negrita.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.negrita.Name = "negrita";
            this.negrita.Size = new System.Drawing.Size(23, 22);
            this.negrita.Text = "Negrita";
            this.negrita.Click += new System.EventHandler(this.negrita_Click);
            // 
            // cursiva
            // 
            this.cursiva.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cursiva.Image = global::practica4.Properties.Resources.cursiva;
            this.cursiva.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cursiva.Name = "cursiva";
            this.cursiva.Size = new System.Drawing.Size(23, 22);
            this.cursiva.Text = "Cursiva";
            this.cursiva.Click += new System.EventHandler(this.cursiva_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // copiar_boton
            // 
            this.copiar_boton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copiar_boton.Image = global::practica4.Properties.Resources.copiar;
            this.copiar_boton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copiar_boton.Name = "copiar_boton";
            this.copiar_boton.Size = new System.Drawing.Size(23, 22);
            this.copiar_boton.Text = "Copiar";
            this.copiar_boton.Click += new System.EventHandler(this.copiar_boton_Click);
            // 
            // pegar_boton
            // 
            this.pegar_boton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pegar_boton.Image = global::practica4.Properties.Resources.pegar;
            this.pegar_boton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pegar_boton.Name = "pegar_boton";
            this.pegar_boton.Size = new System.Drawing.Size(23, 22);
            this.pegar_boton.Text = "Pegar";
            this.pegar_boton.Click += new System.EventHandler(this.pegar_boton_Click);
            // 
            // cortar_boton
            // 
            this.cortar_boton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cortar_boton.Image = global::practica4.Properties.Resources.cortar;
            this.cortar_boton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cortar_boton.Name = "cortar_boton";
            this.cortar_boton.Size = new System.Drawing.Size(23, 22);
            this.cortar_boton.Text = "Cortar";
            this.cortar_boton.Click += new System.EventHandler(this.cortar_boton_Click);
            // 
            // menuClick
            // 
            this.menuClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cortarMenuClick,
            this.copiarMenuClick,
            this.pegarMenuClick,
            this.toolStripSeparator6,
            this.fuenteMenuClick,
            this.parrafoMenuClick});
            this.menuClick.Name = "menuClick";
            this.menuClick.Size = new System.Drawing.Size(122, 120);
            // 
            // cortarMenuClick
            // 
            this.cortarMenuClick.Image = global::practica4.Properties.Resources.cortar;
            this.cortarMenuClick.Name = "cortarMenuClick";
            this.cortarMenuClick.Size = new System.Drawing.Size(121, 22);
            this.cortarMenuClick.Text = "Cortar";
            this.cortarMenuClick.Click += new System.EventHandler(this.cortarMenuClick_Click);
            // 
            // copiarMenuClick
            // 
            this.copiarMenuClick.Image = global::practica4.Properties.Resources.copiar;
            this.copiarMenuClick.Name = "copiarMenuClick";
            this.copiarMenuClick.Size = new System.Drawing.Size(121, 22);
            this.copiarMenuClick.Text = "Copiar";
            this.copiarMenuClick.Click += new System.EventHandler(this.copiarMenuClick_Click);
            // 
            // pegarMenuClick
            // 
            this.pegarMenuClick.Image = global::practica4.Properties.Resources.pegar;
            this.pegarMenuClick.Name = "pegarMenuClick";
            this.pegarMenuClick.Size = new System.Drawing.Size(121, 22);
            this.pegarMenuClick.Text = "Pegar";
            this.pegarMenuClick.Click += new System.EventHandler(this.pegarMenuClick_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(118, 6);
            // 
            // fuenteMenuClick
            // 
            this.fuenteMenuClick.Image = global::practica4.Properties.Resources.fuente;
            this.fuenteMenuClick.Name = "fuenteMenuClick";
            this.fuenteMenuClick.Size = new System.Drawing.Size(121, 22);
            this.fuenteMenuClick.Text = "Fuente...";
            this.fuenteMenuClick.Click += new System.EventHandler(this.fuenteMenuClick_Click);
            // 
            // parrafoMenuClick
            // 
            this.parrafoMenuClick.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alinearIzquierdaMenuClick,
            this.centrarMenuClick,
            this.alinearDerechaMenuClick});
            this.parrafoMenuClick.Image = global::practica4.Properties.Resources.parrafo;
            this.parrafoMenuClick.Name = "parrafoMenuClick";
            this.parrafoMenuClick.Size = new System.Drawing.Size(121, 22);
            this.parrafoMenuClick.Text = "Párrafo...";
            // 
            // alinearIzquierdaMenuClick
            // 
            this.alinearIzquierdaMenuClick.Checked = true;
            this.alinearIzquierdaMenuClick.CheckOnClick = true;
            this.alinearIzquierdaMenuClick.CheckState = System.Windows.Forms.CheckState.Checked;
            this.alinearIzquierdaMenuClick.Image = global::practica4.Properties.Resources.izquierda;
            this.alinearIzquierdaMenuClick.Name = "alinearIzquierdaMenuClick";
            this.alinearIzquierdaMenuClick.Size = new System.Drawing.Size(162, 22);
            this.alinearIzquierdaMenuClick.Text = "Alinear izquierda";
            this.alinearIzquierdaMenuClick.Click += new System.EventHandler(this.alinearIzquierdaMenuClick_Click);
            // 
            // centrarMenuClick
            // 
            this.centrarMenuClick.CheckOnClick = true;
            this.centrarMenuClick.Image = global::practica4.Properties.Resources.centrar;
            this.centrarMenuClick.Name = "centrarMenuClick";
            this.centrarMenuClick.Size = new System.Drawing.Size(162, 22);
            this.centrarMenuClick.Text = "Centrar";
            this.centrarMenuClick.Click += new System.EventHandler(this.centrarMenuClick_Click);
            // 
            // alinearDerechaMenuClick
            // 
            this.alinearDerechaMenuClick.CheckOnClick = true;
            this.alinearDerechaMenuClick.Image = global::practica4.Properties.Resources.derecha;
            this.alinearDerechaMenuClick.Name = "alinearDerechaMenuClick";
            this.alinearDerechaMenuClick.Size = new System.Drawing.Size(162, 22);
            this.alinearDerechaMenuClick.Text = "Alinear derecha";
            this.alinearDerechaMenuClick.Click += new System.EventHandler(this.alinearDerechaMenuClick_Click);
            // 
            // contextBarraEstado
            // 
            this.contextBarraEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.barraEstadoMenu});
            this.contextBarraEstado.Name = "contextBarraEstado";
            this.contextBarraEstado.Size = new System.Drawing.Size(156, 26);
            // 
            // barraEstadoMenu
            // 
            this.barraEstadoMenu.Checked = true;
            this.barraEstadoMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.barraEstadoMenu.Name = "barraEstadoMenu";
            this.barraEstadoMenu.Size = new System.Drawing.Size(155, 22);
            this.barraEstadoMenu.Text = "Barra de estado";
            this.barraEstadoMenu.Click += new System.EventHandler(this.barraEstadoMenu_Click);
            // 
            // Padre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 450);
            this.Controls.Add(this.herramientas_Padre);
            this.Controls.Add(this.barraEstado_Padre);
            this.Controls.Add(this.mStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mStrip;
            this.Name = "Padre";
            this.Text = "Editor de textos";
            this.Load += new System.EventHandler(this.Padre_Load);
            this.MdiChildActivate += new System.EventHandler(this.Padre_MdiChildActivate);
            this.mStrip.ResumeLayout(false);
            this.mStrip.PerformLayout();
            this.barraEstado_Padre.ResumeLayout(false);
            this.barraEstado_Padre.PerformLayout();
            this.herramientas_Padre.ResumeLayout(false);
            this.herramientas_Padre.PerformLayout();
            this.menuClick.ResumeLayout(false);
            this.contextBarraEstado.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mStrip;
        private System.Windows.Forms.ToolStripMenuItem archivo_Padre;
        private System.Windows.Forms.ToolStripMenuItem nuevo_Padre;
        private System.Windows.Forms.ToolStripMenuItem salir_Padre;
        private System.Windows.Forms.ToolStripMenuItem ventana_Padre;
        private System.Windows.Forms.ToolStripMenuItem arrangeIcons_Padre;
        private System.Windows.Forms.ToolStripMenuItem cascada_Padre;
        private System.Windows.Forms.ToolStripMenuItem horizontal_Padre;
        private System.Windows.Forms.ToolStripMenuItem vertical_Padre;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.StatusStrip barraEstado_Padre;
        private System.Windows.Forms.ToolStripStatusLabel constante_S;
        private System.Windows.Forms.ToolStripStatusLabel titulo_S;
        private System.Windows.Forms.ToolStripMenuItem abrir_Padre;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cerrarTodo_Padre;
        private System.Windows.Forms.ToolStripMenuItem ver_Padre;
        private System.Windows.Forms.ToolStripMenuItem barraDeEstadoVer_Padre;
        private System.Windows.Forms.ToolStrip herramientas_Padre;
        private System.Windows.Forms.ToolStripButton nuevo_boton;
        private System.Windows.Forms.ToolStripButton abrir_boton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton deshacer_boton;
        private System.Windows.Forms.ToolStripButton hacer_boton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripDropDownButton alinear;
        private System.Windows.Forms.ToolStripMenuItem alinear_izquierda;
        private System.Windows.Forms.ToolStripMenuItem alinear_centro;
        private System.Windows.Forms.ToolStripMenuItem alinear_derecha;
        private System.Windows.Forms.ToolStripButton negrita;
        private System.Windows.Forms.ToolStripButton cursiva;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton copiar_boton;
        private System.Windows.Forms.ToolStripButton pegar_boton;
        private System.Windows.Forms.ToolStripButton cortar_boton;
        private System.Windows.Forms.ContextMenuStrip menuClick;
        private System.Windows.Forms.ToolStripMenuItem cortarMenuClick;
        private System.Windows.Forms.ToolStripMenuItem copiarMenuClick;
        private System.Windows.Forms.ToolStripMenuItem pegarMenuClick;
        private System.Windows.Forms.ToolStripMenuItem fuenteMenuClick;
        private System.Windows.Forms.ToolStripMenuItem parrafoMenuClick;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem alinearIzquierdaMenuClick;
        private System.Windows.Forms.ToolStripMenuItem centrarMenuClick;
        private System.Windows.Forms.ToolStripMenuItem alinearDerechaMenuClick;
        private System.Windows.Forms.ContextMenuStrip contextBarraEstado;
        private System.Windows.Forms.ToolStripMenuItem barraEstadoMenu;
    }
}

