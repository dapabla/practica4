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
            this.a1_sub2 = new System.Windows.Forms.ToolStripMenuItem();
            this.apartado2 = new System.Windows.Forms.ToolStripMenuItem();
            this.apartado2_1 = new System.Windows.Forms.ToolStripMenuItem();
            this.apartado2_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.apartado2_3 = new System.Windows.Forms.ToolStripMenuItem();
            this.apartado2_4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mStrip
            // 
            this.mStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apartado1,
            this.apartado2});
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
            this.a1_sub2});
            this.apartado1.Name = "apartado1";
            this.apartado1.Size = new System.Drawing.Size(60, 20);
            this.apartado1.Text = "Archivo";
            // 
            // a1_sub1
            // 
            this.a1_sub1.Name = "a1_sub1";
            this.a1_sub1.Size = new System.Drawing.Size(109, 22);
            this.a1_sub1.Text = "Nuevo";
            this.a1_sub1.Click += new System.EventHandler(this.a1_sub1_Click);
            // 
            // a1_sub2
            // 
            this.a1_sub2.Name = "a1_sub2";
            this.a1_sub2.Size = new System.Drawing.Size(109, 22);
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
            // Padre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 450);
            this.Controls.Add(this.mStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mStrip;
            this.Name = "Padre";
            this.Text = "Editor de textos";
            this.Load += new System.EventHandler(this.Padre_Load);
            this.MdiChildActivate += new System.EventHandler(this.Padre_MdiChildActivate);
            this.mStrip.ResumeLayout(false);
            this.mStrip.PerformLayout();
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
    }
}

