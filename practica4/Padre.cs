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
    }
}
