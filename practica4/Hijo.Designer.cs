﻿namespace practica4
{
    partial class Hijo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textoHijo = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivo_Hijo = new System.Windows.Forms.ToolStripMenuItem();
            this.guardar_Hijo = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComo_Hijo = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrar_Hijo = new System.Windows.Forms.ToolStripMenuItem();
            this.edicion_Hijo = new System.Windows.Forms.ToolStripMenuItem();
            this.deshacer_Hijo = new System.Windows.Forms.ToolStripMenuItem();
            this.separadorEdicion_Hijo = new System.Windows.Forms.ToolStripSeparator();
            this.cortar_Hijo = new System.Windows.Forms.ToolStripMenuItem();
            this.copiar_Hijo = new System.Windows.Forms.ToolStripMenuItem();
            this.pegar_Hijo = new System.Windows.Forms.ToolStripMenuItem();
            this.diseño_Hijo = new System.Windows.Forms.ToolStripMenuItem();
            this.fuente_Hijo = new System.Windows.Forms.ToolStripMenuItem();
            this.parrafo_Hijo = new System.Windows.Forms.ToolStripMenuItem();
            this.alinearizq_Hijo = new System.Windows.Forms.ToolStripMenuItem();
            this.centrar_Hijo = new System.Windows.Forms.ToolStripMenuItem();
            this.alineardcha_Hijo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textoHijo
            // 
            this.textoHijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textoHijo.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textoHijo.Location = new System.Drawing.Point(0, 24);
            this.textoHijo.Name = "textoHijo";
            this.textoHijo.Size = new System.Drawing.Size(800, 426);
            this.textoHijo.TabIndex = 0;
            this.textoHijo.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivo_Hijo,
            this.edicion_Hijo,
            this.diseño_Hijo});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // archivo_Hijo
            // 
            this.archivo_Hijo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardar_Hijo,
            this.guardarComo_Hijo,
            this.cerrar_Hijo});
            this.archivo_Hijo.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.archivo_Hijo.Name = "archivo_Hijo";
            this.archivo_Hijo.Size = new System.Drawing.Size(60, 20);
            this.archivo_Hijo.Text = "Archivo";
            // 
            // guardar_Hijo
            // 
            this.guardar_Hijo.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.guardar_Hijo.MergeIndex = 2;
            this.guardar_Hijo.Name = "guardar_Hijo";
            this.guardar_Hijo.Size = new System.Drawing.Size(150, 22);
            this.guardar_Hijo.Text = "Guardar";
            this.guardar_Hijo.Click += new System.EventHandler(this.guardar_Hijo_Click);
            // 
            // guardarComo_Hijo
            // 
            this.guardarComo_Hijo.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.guardarComo_Hijo.MergeIndex = 3;
            this.guardarComo_Hijo.Name = "guardarComo_Hijo";
            this.guardarComo_Hijo.Size = new System.Drawing.Size(150, 22);
            this.guardarComo_Hijo.Text = "Guardar como";
            this.guardarComo_Hijo.Click += new System.EventHandler(this.guardarComo_Hijo_Click);
            // 
            // cerrar_Hijo
            // 
            this.cerrar_Hijo.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.cerrar_Hijo.MergeIndex = 5;
            this.cerrar_Hijo.Name = "cerrar_Hijo";
            this.cerrar_Hijo.Size = new System.Drawing.Size(150, 22);
            this.cerrar_Hijo.Text = "Cerrar";
            this.cerrar_Hijo.Click += new System.EventHandler(this.cerrar_Hijo_Click);
            // 
            // edicion_Hijo
            // 
            this.edicion_Hijo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deshacer_Hijo,
            this.separadorEdicion_Hijo,
            this.cortar_Hijo,
            this.copiar_Hijo,
            this.pegar_Hijo});
            this.edicion_Hijo.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.edicion_Hijo.MergeIndex = 1;
            this.edicion_Hijo.Name = "edicion_Hijo";
            this.edicion_Hijo.Size = new System.Drawing.Size(58, 20);
            this.edicion_Hijo.Text = "Edición";
            // 
            // deshacer_Hijo
            // 
            this.deshacer_Hijo.Name = "deshacer_Hijo";
            this.deshacer_Hijo.Size = new System.Drawing.Size(122, 22);
            this.deshacer_Hijo.Text = "Deshacer";
            this.deshacer_Hijo.Click += new System.EventHandler(this.deshacer_Hijo_Click);
            // 
            // separadorEdicion_Hijo
            // 
            this.separadorEdicion_Hijo.Name = "separadorEdicion_Hijo";
            this.separadorEdicion_Hijo.Size = new System.Drawing.Size(119, 6);
            // 
            // cortar_Hijo
            // 
            this.cortar_Hijo.Name = "cortar_Hijo";
            this.cortar_Hijo.Size = new System.Drawing.Size(122, 22);
            this.cortar_Hijo.Text = "Cortar";
            this.cortar_Hijo.Click += new System.EventHandler(this.cortar_Hijo_Click);
            // 
            // copiar_Hijo
            // 
            this.copiar_Hijo.Name = "copiar_Hijo";
            this.copiar_Hijo.Size = new System.Drawing.Size(122, 22);
            this.copiar_Hijo.Text = "Copiar";
            this.copiar_Hijo.Click += new System.EventHandler(this.copiar_Hijo_Click);
            // 
            // pegar_Hijo
            // 
            this.pegar_Hijo.Name = "pegar_Hijo";
            this.pegar_Hijo.Size = new System.Drawing.Size(122, 22);
            this.pegar_Hijo.Text = "Pegar";
            this.pegar_Hijo.Click += new System.EventHandler(this.pegar_Hijo_Click);
            // 
            // diseño_Hijo
            // 
            this.diseño_Hijo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fuente_Hijo,
            this.parrafo_Hijo});
            this.diseño_Hijo.Name = "diseño_Hijo";
            this.diseño_Hijo.Size = new System.Drawing.Size(55, 20);
            this.diseño_Hijo.Text = "Diseño";
            // 
            // fuente_Hijo
            // 
            this.fuente_Hijo.Name = "fuente_Hijo";
            this.fuente_Hijo.Size = new System.Drawing.Size(112, 22);
            this.fuente_Hijo.Text = "Fuente";
            this.fuente_Hijo.Click += new System.EventHandler(this.fuente_Hijo_Click);
            // 
            // parrafo_Hijo
            // 
            this.parrafo_Hijo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alinearizq_Hijo,
            this.centrar_Hijo,
            this.alineardcha_Hijo});
            this.parrafo_Hijo.Name = "parrafo_Hijo";
            this.parrafo_Hijo.Size = new System.Drawing.Size(112, 22);
            this.parrafo_Hijo.Text = "Párrafo";
            // 
            // alinearizq_Hijo
            // 
            this.alinearizq_Hijo.Name = "alinearizq_Hijo";
            this.alinearizq_Hijo.Size = new System.Drawing.Size(183, 22);
            this.alinearizq_Hijo.Text = "Alinear a la izquierda";
            this.alinearizq_Hijo.Click += new System.EventHandler(this.alinearizq_Hijo_Click);
            // 
            // centrar_Hijo
            // 
            this.centrar_Hijo.Name = "centrar_Hijo";
            this.centrar_Hijo.Size = new System.Drawing.Size(183, 22);
            this.centrar_Hijo.Text = "Centrar";
            this.centrar_Hijo.Click += new System.EventHandler(this.centrar_Hijo_Click);
            // 
            // alineardcha_Hijo
            // 
            this.alineardcha_Hijo.Name = "alineardcha_Hijo";
            this.alineardcha_Hijo.Size = new System.Drawing.Size(183, 22);
            this.alineardcha_Hijo.Text = "Alinear a la derecha";
            this.alineardcha_Hijo.Click += new System.EventHandler(this.alineardcha_Hijo_Click);
            // 
            // Hijo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textoHijo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Hijo";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Hijo_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox textoHijo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivo_Hijo;
        private System.Windows.Forms.ToolStripMenuItem guardar_Hijo;
        private System.Windows.Forms.ToolStripMenuItem guardarComo_Hijo;
        private System.Windows.Forms.ToolStripMenuItem cerrar_Hijo;
        private System.Windows.Forms.ToolStripMenuItem edicion_Hijo;
        private System.Windows.Forms.ToolStripMenuItem deshacer_Hijo;
        private System.Windows.Forms.ToolStripMenuItem cortar_Hijo;
        private System.Windows.Forms.ToolStripMenuItem copiar_Hijo;
        private System.Windows.Forms.ToolStripMenuItem pegar_Hijo;
        private System.Windows.Forms.ToolStripSeparator separadorEdicion_Hijo;
        private System.Windows.Forms.ToolStripMenuItem diseño_Hijo;
        private System.Windows.Forms.ToolStripMenuItem fuente_Hijo;
        private System.Windows.Forms.ToolStripMenuItem parrafo_Hijo;
        private System.Windows.Forms.ToolStripMenuItem alinearizq_Hijo;
        private System.Windows.Forms.ToolStripMenuItem centrar_Hijo;
        private System.Windows.Forms.ToolStripMenuItem alineardcha_Hijo;
    }
}