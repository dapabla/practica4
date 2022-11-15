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
           
            if (this.GetRichTextBox().Modified==true)
            {
                DialogResult decision = MessageBox.Show("¿Quieres cerrar sin guardar?", "Aviso", MessageBoxButtons.YesNoCancel);
                if ( decision == DialogResult.No)
                {
                    guardar_Hijo.PerformClick();
                }else if (decision == DialogResult.Cancel)
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
            saveFileDialog.Filter = "Archivos de texto|*.txt|Archivo de texto enriquecido|*.rtf|Todos los archivos|*.*";
            saveFileDialog.InitialDirectory = "c:\\";
            DialogResult decision = saveFileDialog.ShowDialog();

            if (decision == DialogResult.OK)
            {
                String[] partes = saveFileDialog.FileName.Split('\\');
                this.Text = partes[partes.Length - 1];
                if (saveFileDialog.FileName.EndsWith(".txt"))
                {
                    this.textoHijo.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
                }
                if (saveFileDialog.FileName.EndsWith(".rtf"))
                {
                    this.textoHijo.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
                }
               
                this.GetRichTextBox().Modified = false;
                this.nombre = saveFileDialog.FileName;
                Padre p = (Padre)this.MdiParent;
                p.getTitulo_S().Text = this.Text;
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
                if (this.nombre.EndsWith(".txt"))
                {
                    this.textoHijo.SaveFile(this.nombre, RichTextBoxStreamType.PlainText);
                }
                if (this.nombre.EndsWith(".rtf"))
                {
                    this.textoHijo.SaveFile(this.nombre, RichTextBoxStreamType.RichText);
                }
                this.GetRichTextBox().Modified = false;
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

        public String getNombre()
        {
            return this.nombre;
        }

        private void fuente_Hijo_Click(object sender, EventArgs e)
        {
            FontDialog fuente = new FontDialog();
            fuente.ShowColor = true;
            fuente.Font = this.GetRichTextBox().Font;

            if (fuente.ShowDialog() != DialogResult.Cancel)
            {
                this.GetRichTextBox().Font = fuente.Font;
                this.GetRichTextBox().ForeColor = fuente.Color;
            }
            else
            {
                fuente.Dispose();
            }
        }

        private void cerrar_Hijo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void centrar_Hijo_Click(object sender, EventArgs e)
        {
            this.GetRichTextBox().SelectionAlignment = HorizontalAlignment.Center;

        }

        private void alinearizq_Hijo_Click(object sender, EventArgs e)
        {
            this.GetRichTextBox().SelectionAlignment = HorizontalAlignment.Left;
        }

        private void alineardcha_Hijo_Click(object sender, EventArgs e)
        {
            this.GetRichTextBox().SelectionAlignment = HorizontalAlignment.Right;
        }

        private void diseño_Hijo_Click(object sender, EventArgs e)
        {

            FontDialog fuente = new FontDialog();
            fuente.ShowColor = true;
            fuente.Font = this.GetRichTextBox().Font;

            if (fuente.ShowDialog() != DialogResult.Cancel)
            {
                this.GetRichTextBox().Font = fuente.Font;
                this.GetRichTextBox().ForeColor = fuente.Color;
            }
            else
            {
                fuente.Dispose();
            }
        }
    }
}
