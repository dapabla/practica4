
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
    public partial class Padre : Form
    {
        int i = 0;
        public Padre()
        {
            InitializeComponent();
            this.apartado2.Visible = false;
            this.titulo_S.Text = "";
            this.deshacer_boton.Enabled = false;
            this.hacer_boton.Enabled = false;
            this.alinear.Enabled = false;
            this.negrita.Enabled = false;   
            this.cursiva.Enabled = false;
            this.cortar_boton.Enabled = false;
            this.copiar_boton.Enabled = false;
            this.pegar_boton.Enabled = false;

            foreach (ToolStripMenuItem x in this.mStrip.Items)
            {
                x.MouseHover += new EventHandler(menuHover);
                x.MouseLeave += new EventHandler(menuLeave);


                foreach (ToolStripItem y in x.DropDownItems)
                {
                    y.MouseHover += new EventHandler(menuHover);
                    y.MouseLeave += new EventHandler(menuLeave);
                    
                }
            }

        }

        private void a1_sub1_Click(object sender, EventArgs e)
        {
            this.i = this.i + 1;
            Hijo hijo = new Hijo();
            hijo.Text = "Documento " + i;
            hijo.MdiParent = this;
            hijo.Show();


            foreach (ToolStripMenuItem x in this.mStrip.Items)
            {
                x.MouseHover += new EventHandler(menuHover);
                x.MouseLeave += new EventHandler(menuLeave);


                foreach (ToolStripItem y in x.DropDownItems)
                {
                    y.MouseHover += new EventHandler(menuHover);
                    y.MouseLeave += new EventHandler(menuLeave);
                }
            }
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
                this.deshacer_boton.Enabled = false;
                this.hacer_boton.Enabled = false;
                this.alinear.Enabled = false;
                this.negrita.Enabled = false;
                this.cursiva.Enabled = false;
                this.cortar_boton.Enabled = false;
                this.copiar_boton.Enabled = false;
                this.pegar_boton.Enabled = false;
            }
            else
            {
                this.apartado2.Visible = true;
                this.titulo_S.Text = this.ActiveMdiChild.Text;
                this.deshacer_boton.Enabled = true;
                this.hacer_boton.Enabled = true;
                this.alinear.Enabled = true;
                this.alinear_izquierda.Checked = true;
                this.negrita.Enabled = true;
                this.cursiva.Enabled = true;
                this.cortar_boton.Enabled = true;
                this.copiar_boton.Enabled = true;
                this.pegar_boton.Enabled = true;
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
            ventana.Filter = "Archivos de texto|*.txt|Archivo de texto enriquecido|*.rtf|Todos los archivos|*.*";
            ventana.InitialDirectory = "c:\\";
            DialogResult decision = ventana.ShowDialog();
            String ruta = ventana.FileName;

            if (decision==DialogResult.OK)
            {
                Hijo hijo = new Hijo(ruta);
                hijo.MdiParent = this;
                if (hijo.getNombre().EndsWith(".txt"))
                {
                    hijo.GetRichTextBox().LoadFile(ventana.FileName, RichTextBoxStreamType.PlainText);
                }
                if (hijo.getNombre().EndsWith(".rtf"))
                {
                    hijo.GetRichTextBox().LoadFile(ventana.FileName, RichTextBoxStreamType.RichText);
                }
                
                hijo.GetRichTextBox().Modified = false;
                String[] partes = ventana.FileName.Split('\\');
                hijo.Text = partes[partes.Length-1];

                hijo.Show();
            }
            else if(decision == DialogResult.Cancel){
                ventana.Dispose();
            }
        }

        public void menuHover(object sender, EventArgs e)
        {
            if (sender is ToolStripSeparator)
            {
                this.constante_S.Text = "";
            }
            else
            {
                this.constante_S.Text = sender.ToString();
            }
            
        }
        public void menuLeave(object sender, EventArgs e)
        {
            this.constante_S.Text = "";
        }
        public ToolStripStatusLabel getTitulo_S()
        {
            return this.titulo_S;
        }

        private void cerrarTodo_Padre_Click(object sender, EventArgs e)
        {
            foreach(Hijo hijo in this.MdiChildren)
            {
                hijo.Close();
            }
        }

        private void nuevo_boton_Click(object sender, EventArgs e)
        {
            a1_sub1.PerformClick();
        }

        private void abrir_boton_Click(object sender, EventArgs e)
        {
            abrir_Padre.PerformClick();
        }

        private void deshacer_boton_Click(object sender, EventArgs e)
        {
            Hijo activo = (Hijo)this.ActiveMdiChild;
            activo.GetRichTextBox().Undo();
        }

        private void hacer_boton_Click(object sender, EventArgs e)
        {
            Hijo activo = (Hijo)this.ActiveMdiChild;
            activo.GetRichTextBox().Redo();
        }

        private void alinear_izquierda_Click(object sender, EventArgs e)
        {
            Hijo activo = (Hijo)this.ActiveMdiChild;
            activo.GetRichTextBox().SelectionAlignment = HorizontalAlignment.Left;
            alinear_centro.Checked = false;
            alinear_derecha.Checked = false;
        }

        private void alinear_centro_Click(object sender, EventArgs e)
        {
            Hijo activo = (Hijo)this.ActiveMdiChild;
            activo.GetRichTextBox().SelectionAlignment = HorizontalAlignment.Center;
            alinear_izquierda.Checked = false;
            alinear_derecha.Checked = false;
        }

        private void alinear_derecha_Click(object sender, EventArgs e)
        {
            Hijo activo = (Hijo)this.ActiveMdiChild;
            activo.GetRichTextBox().SelectionAlignment = HorizontalAlignment.Right;
            alinear_izquierda.Checked = false;
            alinear_centro.Checked = false;
        }

        private void negrita_Click(object sender, EventArgs e)
        {
            Hijo activo = (Hijo)this.ActiveMdiChild;
            if (activo.GetRichTextBox().SelectionFont.Bold)
            {
                activo.GetRichTextBox().SelectionFont = new Font(activo.GetRichTextBox().Font, FontStyle.Regular);
                negrita.Checked = false;
            }
            else
            {
                activo.GetRichTextBox().SelectionFont = new Font(activo.GetRichTextBox().Font, FontStyle.Bold);
                negrita.Checked = true;
                cursiva.Checked = false;
            }
        }

        private void cursiva_Click(object sender, EventArgs e)
        {
            Hijo activo = (Hijo)this.ActiveMdiChild;
            if (activo.GetRichTextBox().SelectionFont.Italic)
            {
                activo.GetRichTextBox().SelectionFont = new Font(activo.GetRichTextBox().Font, FontStyle.Regular);
                cursiva.Checked = false;
            }
            else
            {
                activo.GetRichTextBox().SelectionFont = new Font(activo.GetRichTextBox().Font, FontStyle.Italic);
                negrita.Checked = false;
                cursiva.Checked = true;
            }
        }

        private void copiar_boton_Click(object sender, EventArgs e)
        {
            Hijo activo = (Hijo)this.ActiveMdiChild;
            activo.GetRichTextBox().Copy();
        }

        private void pegar_boton_Click(object sender, EventArgs e)
        {
            Hijo activo = (Hijo)this.ActiveMdiChild;
            activo.GetRichTextBox().Paste();
        }

        private void cortar_boton_Click(object sender, EventArgs e)
        {
            Hijo activo = (Hijo)this.ActiveMdiChild;
            activo.GetRichTextBox().Cut();
        }
        public ContextMenuStrip getMenuClick()
        {
            return this.menuClick;
        }

        private void cortarMenuClick_Click(object sender, EventArgs e)
        {
            cortar_boton.PerformClick();
        }

        private void copiarMenuClick_Click(object sender, EventArgs e)
        {
            copiar_boton.PerformClick();
        }

        private void pegarMenuClick_Click(object sender, EventArgs e)
        {
            pegar_boton.PerformClick();
        }
    }
}
