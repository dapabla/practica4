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
            this.arrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mStrip
            // 
            this.mStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apartado1,
            this.apartado2});
            this.mStrip.Location = new System.Drawing.Point(0, 0);
            this.mStrip.Name = "mStrip";
            this.mStrip.Size = new System.Drawing.Size(800, 24);
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
            this.a1_sub1.Size = new System.Drawing.Size(180, 22);
            this.a1_sub1.Text = "Nuevo";
            this.a1_sub1.Click += new System.EventHandler(this.a1_sub1_Click);
            // 
            // a1_sub2
            // 
            this.a1_sub2.Name = "a1_sub2";
            this.a1_sub2.Size = new System.Drawing.Size(180, 22);
            this.a1_sub2.Text = "Salir";
            // 
            // apartado2
            // 
            this.apartado2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arrangeIconsToolStripMenuItem,
            this.cascadaToolStripMenuItem,
            this.horizontalToolStripMenuItem,
            this.verticalToolStripMenuItem});
            this.apartado2.Name = "apartado2";
            this.apartado2.Size = new System.Drawing.Size(61, 20);
            this.apartado2.Text = "Ventana";
            // 
            // arrangeIconsToolStripMenuItem
            // 
            this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.arrangeIconsToolStripMenuItem.Text = "Arrange Icons";
            // 
            // cascadaToolStripMenuItem
            // 
            this.cascadaToolStripMenuItem.Name = "cascadaToolStripMenuItem";
            this.cascadaToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.cascadaToolStripMenuItem.Text = "Cascada";
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.horizontalToolStripMenuItem.Text = "Horizontal";
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.verticalToolStripMenuItem.Text = "Vertical";
            // 
            // Padre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mStrip;
            this.Name = "Padre";
            this.Text = "Editor de textos";
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
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
    }
}

