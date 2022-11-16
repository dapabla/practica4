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
            this.mStrip = new System.Windows.Forms.MenuStrip();
            this.apartado1 = new System.Windows.Forms.ToolStripMenuItem();
            this.a1_sub1 = new System.Windows.Forms.ToolStripMenuItem();
            this.abrir_Padre = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cerrarTodo_Padre = new System.Windows.Forms.ToolStripMenuItem();
            this.a1_sub2 = new System.Windows.Forms.ToolStripMenuItem();
            this.apartado2 = new System.Windows.Forms.ToolStripMenuItem();
            this.apartado2_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.apartado2_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.apartado2_3 = new System.Windows.Forms.ToolStripMenuItem();
            this.apartado2_4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ver_Padre = new System.Windows.Forms.ToolStripMenuItem();
            this.barraDeEstadoVer_Padre = new System.Windows.Forms.ToolStripMenuItem();
            this.barraEstado_Padre = new System.Windows.Forms.StatusStrip();
            this.constante_S = new System.Windows.Forms.ToolStripStatusLabel();
            this.titulo_S = new System.Windows.Forms.ToolStripStatusLabel();
            this.herramientas_Padre = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.nuevo_boton = new System.Windows.Forms.ToolStripButton();
            this.abrir_boton = new System.Windows.Forms.ToolStripButton();
            this.deshacer_boton = new System.Windows.Forms.ToolStripButton();
            this.hacer_boton = new System.Windows.Forms.ToolStripButton();
            this.alinear = new System.Windows.Forms.ToolStripDropDownButton();
            this.alinear_izquierda = new System.Windows.Forms.ToolStripMenuItem();
            this.alinear_centro = new System.Windows.Forms.ToolStripMenuItem();
            this.alinear_derecha = new System.Windows.Forms.ToolStripMenuItem();
            this.negrita = new System.Windows.Forms.ToolStripButton();
            this.cursiva = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.mStrip.SuspendLayout();
            this.barraEstado_Padre.SuspendLayout();
            this.herramientas_Padre.SuspendLayout();
            this.SuspendLayout();
            // 
            // mStrip
            // 
            this.mStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apartado1,
            this.apartado2,
            this.ver_Padre});
            this.mStrip.Location = new System.Drawing.Point(0, 0);
            this.mStrip.MdiWindowListItem = this.apartado2;
            this.mStrip.Name = "mStrip";
            this.mStrip.Size = new System.Drawing.Size(840, 24);
            this.mStrip.TabIndex = 0;
            this.mStrip.Text = "menuStrip1";
            // 
            // apartado1
            // 
            this.apartado1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.a1_sub1,
            this.abrir_Padre,
            this.toolStripSeparator2,
            this.cerrarTodo_Padre,
            this.a1_sub2});
            this.apartado1.Name = "apartado1";
            this.apartado1.Size = new System.Drawing.Size(60, 20);
            this.apartado1.Text = "Archivo";
            // 
            // a1_sub1
            // 
            this.a1_sub1.Name = "a1_sub1";
            this.a1_sub1.Size = new System.Drawing.Size(134, 22);
            this.a1_sub1.Text = "Nuevo";
            this.a1_sub1.Click += new System.EventHandler(this.a1_sub1_Click);
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
            // a1_sub2
            // 
            this.a1_sub2.Name = "a1_sub2";
            this.a1_sub2.Size = new System.Drawing.Size(134, 22);
            this.a1_sub2.Text = "Salir";
            this.a1_sub2.Click += new System.EventHandler(this.a1_sub2_Click);
            // 
            // apartado2
            // 
            this.apartado2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apartado2_1,
            this.apartado2_2,
            this.apartado2_3,
            this.apartado2_4,
            this.toolStripSeparator1});
            this.apartado2.Name = "apartado2";
            this.apartado2.Size = new System.Drawing.Size(61, 20);
            this.apartado2.Text = "Ventana";
            // 
            // apartado2_1
            // 
            this.apartado2_1.Name = "apartado2_1";
            this.apartado2_1.Size = new System.Drawing.Size(147, 22);
            this.apartado2_1.Text = "Arrange Icons";
            this.apartado2_1.Click += new System.EventHandler(this.apartado2_1_Click);
            // 
            // apartado2_2
            // 
            this.apartado2_2.Name = "apartado2_2";
            this.apartado2_2.Size = new System.Drawing.Size(147, 22);
            this.apartado2_2.Text = "Cascada";
            this.apartado2_2.Click += new System.EventHandler(this.apartado2_2_Click);
            // 
            // apartado2_3
            // 
            this.apartado2_3.Name = "apartado2_3";
            this.apartado2_3.Size = new System.Drawing.Size(147, 22);
            this.apartado2_3.Text = "Horizontal";
            this.apartado2_3.Click += new System.EventHandler(this.horizontalToolStripMenuItem_Click);
            // 
            // apartado2_4
            // 
            this.apartado2_4.Name = "apartado2_4";
            this.apartado2_4.Size = new System.Drawing.Size(147, 22);
            this.apartado2_4.Text = "Vertical";
            this.apartado2_4.Click += new System.EventHandler(this.apartado2_4_Click);
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
            this.titulo_S.Size = new System.Drawing.Size(825, 17);
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
            this.toolStripSeparator5});
            this.herramientas_Padre.Location = new System.Drawing.Point(0, 24);
            this.herramientas_Padre.Name = "herramientas_Padre";
            this.herramientas_Padre.Size = new System.Drawing.Size(840, 25);
            this.herramientas_Padre.TabIndex = 4;
            this.herramientas_Padre.Text = "toolStrip1";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // nuevo_boton
            // 
            this.nuevo_boton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nuevo_boton.Image = global::practica4.Properties.Resources.nuevo;
            this.nuevo_boton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.nuevo_boton.Name = "nuevo_boton";
            this.nuevo_boton.Size = new System.Drawing.Size(23, 22);
            this.nuevo_boton.Text = "toolStripButton1";
            this.nuevo_boton.Click += new System.EventHandler(this.nuevo_boton_Click);
            // 
            // abrir_boton
            // 
            this.abrir_boton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.abrir_boton.Image = global::practica4.Properties.Resources.abrir;
            this.abrir_boton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.abrir_boton.Name = "abrir_boton";
            this.abrir_boton.Size = new System.Drawing.Size(23, 22);
            this.abrir_boton.Text = "toolStripButton1";
            this.abrir_boton.Click += new System.EventHandler(this.abrir_boton_Click);
            // 
            // deshacer_boton
            // 
            this.deshacer_boton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deshacer_boton.Image = global::practica4.Properties.Resources.deshacer;
            this.deshacer_boton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deshacer_boton.Name = "deshacer_boton";
            this.deshacer_boton.Size = new System.Drawing.Size(23, 22);
            this.deshacer_boton.Text = "toolStripButton1";
            this.deshacer_boton.Click += new System.EventHandler(this.deshacer_boton_Click);
            // 
            // hacer_boton
            // 
            this.hacer_boton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hacer_boton.Image = global::practica4.Properties.Resources.redo;
            this.hacer_boton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.hacer_boton.Name = "hacer_boton";
            this.hacer_boton.Size = new System.Drawing.Size(23, 22);
            this.hacer_boton.Text = "toolStripButton2";
            this.hacer_boton.Click += new System.EventHandler(this.hacer_boton_Click);
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
            this.alinear.Text = "toolStripDropDownButton1";
            // 
            // alinear_izquierda
            // 
            this.alinear_izquierda.CheckOnClick = true;
            this.alinear_izquierda.Image = global::practica4.Properties.Resources.izquierda;
            this.alinear_izquierda.Name = "alinear_izquierda";
            this.alinear_izquierda.Size = new System.Drawing.Size(180, 22);
            this.alinear_izquierda.Text = "izquierda";
            this.alinear_izquierda.Click += new System.EventHandler(this.alinear_izquierda_Click);
            // 
            // alinear_centro
            // 
            this.alinear_centro.CheckOnClick = true;
            this.alinear_centro.Image = global::practica4.Properties.Resources.alinear;
            this.alinear_centro.Name = "alinear_centro";
            this.alinear_centro.Size = new System.Drawing.Size(180, 22);
            this.alinear_centro.Text = "centrar";
            this.alinear_centro.Click += new System.EventHandler(this.alinear_centro_Click);
            // 
            // alinear_derecha
            // 
            this.alinear_derecha.CheckOnClick = true;
            this.alinear_derecha.Image = global::practica4.Properties.Resources.derecha;
            this.alinear_derecha.Name = "alinear_derecha";
            this.alinear_derecha.Size = new System.Drawing.Size(180, 22);
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
            this.negrita.Text = "toolStripButton1";
            this.negrita.Click += new System.EventHandler(this.negrita_Click);
            // 
            // cursiva
            // 
            this.cursiva.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cursiva.Image = global::practica4.Properties.Resources.cursiva;
            this.cursiva.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cursiva.Name = "cursiva";
            this.cursiva.Size = new System.Drawing.Size(23, 22);
            this.cursiva.Text = "toolStripButton2";
            this.cursiva.Click += new System.EventHandler(this.cursiva_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // Padre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 450);
            this.Controls.Add(this.herramientas_Padre);
            this.Controls.Add(this.barraEstado_Padre);
            this.Controls.Add(this.mStrip);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mStrip;
        private System.Windows.Forms.ToolStripMenuItem apartado1;
        private System.Windows.Forms.ToolStripMenuItem a1_sub1;
        private System.Windows.Forms.ToolStripMenuItem a1_sub2;
        private System.Windows.Forms.ToolStripMenuItem apartado2;
        private System.Windows.Forms.ToolStripMenuItem apartado2_1;
        private System.Windows.Forms.ToolStripMenuItem apartado2_2;
        private System.Windows.Forms.ToolStripMenuItem apartado2_3;
        private System.Windows.Forms.ToolStripMenuItem apartado2_4;
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
    }
}

