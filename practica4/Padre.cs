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
        public Padre()
        {
            InitializeComponent();
        }

        private void a1_sub1_Click(object sender, EventArgs e)
        {
            Hijo hijo = new Hijo();
            hijo.MdiParent = this;
        }
    }
}
