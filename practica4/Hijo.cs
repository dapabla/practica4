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
           
            if (MessageBox.Show("¿Quiere cerrar " + this.Text +"?", "", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public RichTextBox GetRichTextBox()
        {
            return textoHijo;
        }

        private void guardarComo_Hijo_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Seleccione el archivo a guardar";
        }
    }
}
