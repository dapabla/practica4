﻿namespace practica4
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
            this.barraEstado_Padre = new System.Windows.Forms.StatusStrip();
            this.constante_S = new System.Windows.Forms.ToolStripStatusLabel();
            this.titulo_S = new System.Windows.Forms.ToolStripStatusLabel();
            this.ver_Padre = new System.Windows.Forms.ToolStripMenuItem();
            this.barraDeEstadoVer_Padre = new System.Windows.Forms.ToolStripMenuItem();
            this.mStrip.SuspendLayout();
            this.barraEstado_Padre.SuspendLayout();
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
            this.apartado2_1.Size = new System.Drawing.Size(180, 22);
            this.apartado2_1.Text = "Arrange Icons";
            this.apartado2_1.Click += new System.EventHandler(this.apartado2_1_Click);
            // 
            // apartado2_2
            // 
            this.apartado2_2.Name = "apartado2_2";
            this.apartado2_2.Size = new System.Drawing.Size(180, 22);
            this.apartado2_2.Text = "Cascada";
            this.apartado2_2.Click += new System.EventHandler(this.apartado2_2_Click);
            // 
            // apartado2_3
            // 
            this.apartado2_3.Name = "apartado2_3";
            this.apartado2_3.Size = new System.Drawing.Size(180, 22);
            this.apartado2_3.Text = "Horizontal";
            this.apartado2_3.Click += new System.EventHandler(this.horizontalToolStripMenuItem_Click);
            // 
            // apartado2_4
            // 
            this.apartado2_4.Name = "apartado2_4";
            this.apartado2_4.Size = new System.Drawing.Size(180, 22);
            this.apartado2_4.Text = "Vertical";
            this.apartado2_4.Click += new System.EventHandler(this.apartado2_4_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
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
            this.constante_S.Size = new System.Drawing.Size(50, 17);
            this.constante_S.Text = "Ejemplo";
            // 
            // titulo_S
            // 
            this.titulo_S.Name = "titulo_S";
            this.titulo_S.Size = new System.Drawing.Size(744, 17);
            this.titulo_S.Spring = true;
            this.titulo_S.Text = "toolStripStatusLabel2";
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
            this.barraDeEstadoVer_Padre.Size = new System.Drawing.Size(180, 22);
            this.barraDeEstadoVer_Padre.Text = "Barra de estado";
            this.barraDeEstadoVer_Padre.Click += new System.EventHandler(this.barraDeEstadoVer_Padre_Click);
            // 
            // Padre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 450);
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
    }
}

