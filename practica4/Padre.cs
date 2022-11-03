﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica4
{
    public partial class Padre : Form
    {
        int i = 0;
        public Padre()
        {
            InitializeComponent();
            this.apartado2.Visible = false;
            this.titulo_S.Text = "";

        }

        private void a1_sub1_Click(object sender, EventArgs e)
        {
            this.i = this.i + 1;
            Hijo hijo = new Hijo();
            hijo.Text = "Documento " + i;
            hijo.MdiParent = this;

            hijo.Show();
        }


        private void a1_sub2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Padre_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void apartado2_1_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void apartado2_2_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void apartado2_4_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void Padre_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                this.apartado2.Visible = false;
                this.titulo_S.Text = "";
            }
            else
            {
                this.apartado2.Visible = true;
                this.titulo_S.Text = this.ActiveMdiChild.Text;
            }
        }

        private void barraDeEstadoVer_Padre_Click(object sender, EventArgs e)
        {
            if (this.barraDeEstadoVer_Padre.CheckState==CheckState.Checked)
            {
                barraEstado_Padre.Visible = true;
            }
            else
            {
                barraEstado_Padre.Visible = false;
            }
        }

        private void abrir_Padre_Click(object sender, EventArgs e)
        {
            OpenFileDialog ventana = new OpenFileDialog();
            ventana.Title = "Seleccione el archivo a abrir";
            ventana.Filter = "Archivos de texto|*.txt|Todos los archivos|*.*";
            DialogResult decision = ventana.ShowDialog();
            Hijo hijo = new Hijo();

            if (decision==DialogResult.OK)
            {
                
                hijo.MdiParent = this;
                hijo.GetRichTextBox().LoadFile(ventana.FileName, RichTextBoxStreamType.PlainText);
                String[] partes = ventana.FileName.Split('\\');
                hijo.Text = partes[partes.Length-1];


                hijo.Show();
            }
            else if(decision == DialogResult.Cancel){
                ventana.Dispose();
            }
        }
    }
}
