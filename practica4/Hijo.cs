using System;
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
    public partial class Hijo : Form
    {
        public Hijo()
        {
            InitializeComponent();
        }

        private void Hijo_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            if (MessageBox.Show("¿Quiere cerrar xxxxxxx?", "", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
