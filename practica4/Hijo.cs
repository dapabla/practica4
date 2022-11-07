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
        private String originalText;
        public Hijo()
        {
            InitializeComponent();
            this.nombre = "";
            this.originalText = this.GetRichTextBox().Text;
        }

        public Hijo(String nombre)
        {
            InitializeComponent();
            this.nombre = nombre;
        }

        private void Hijo_FormClosing(object sender, FormClosingEventArgs e)
        {
           
            if (this.GetRichTextBox().Modified==true)
            {
                if(MessageBox.Show("¿Quieres cerrar sin guardar?", "Aviso", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
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
            saveFileDialog.InitialDirectory = "c:\\";
            DialogResult decision = saveFileDialog.ShowDialog();

            if (decision == DialogResult.OK)
            {
                String[] partes = saveFileDialog.FileName.Split('\\');
                this.Text = partes[partes.Length - 1];
                this.textoHijo.SaveFile(saveFileDialog.FileName,RichTextBoxStreamType.PlainText);
                this.originalText = this.GetRichTextBox().Text;
                this.nombre = saveFileDialog.FileName;
            }
            else if (decision == DialogResult.Cancel)
            {
                saveFileDialog.Dispose();
            }
        }

        private void guardar_Hijo_Click(object sender, EventArgs e)
        {
            if (this.nombre =="")
            {
                guardarComo_Hijo.PerformClick();
            }else
            {
                this.textoHijo.SaveFile(this.nombre, RichTextBoxStreamType.PlainText);
                this.originalText = this.GetRichTextBox().Text;
            }
            
        }

        private void deshacer_Hijo_Click(object sender, EventArgs e)
        {

                this.GetRichTextBox().Undo();
        }

        private void cortar_Hijo_Click(object sender, EventArgs e)
        {
            this.GetRichTextBox().Cut();
        }

        private void copiar_Hijo_Click(object sender, EventArgs e)
        {
            this.GetRichTextBox().Copy();
        }

        private void pegar_Hijo_Click(object sender, EventArgs e)
        {
            this.GetRichTextBox().Paste();
        }

        private void textoHijo_TextChanged(object sender, EventArgs e)
        {
            if (originalText!=this.GetRichTextBox().Text)
            {
                this.GetRichTextBox().Modified = true;
            }
            else
            {
                this.GetRichTextBox().Modified = false;
            }
        }
    }
}
