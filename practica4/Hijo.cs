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
        private String nombre;
        public Hijo()
        {
            InitializeComponent();
            this.nombre = "";
        }

        public Hijo(String nombre)
        {
            InitializeComponent();
            this.nombre = nombre;
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
            saveFileDialog.Filter = "Archivos de texto|*.txt|Todos los archivos|*.*";
            DialogResult decision = saveFileDialog.ShowDialog();

            if (decision == DialogResult.OK)
            {
                this.textoHijo.SaveFile(saveFileDialog.FileName,RichTextBoxStreamType.PlainText);
                this.nombre = saveFileDialog.FileName;
                String[] partes = saveFileDialog.FileName.Split('\\');
                this.Text = partes[partes.Length-1];
            }
            else if (decision == DialogResult.Cancel)
            {
                saveFileDialog.Dispose();
            }
        }

        private void guardar_Hijo_Click(object sender, EventArgs e)
        {
            if (this.nombre == "")
            {
                guardarComo_Hijo.PerformClick();
            }else
            {
                this.textoHijo.SaveFile(this.nombre, RichTextBoxStreamType.PlainText);
            }
            
        }
    }
}
