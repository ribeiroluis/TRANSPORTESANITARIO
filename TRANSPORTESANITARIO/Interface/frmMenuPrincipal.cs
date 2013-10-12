using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TRANSPORTESANITARIO.Interface
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }
        private void novoEmpenhoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmFichadeAtendimento atende = new frmFichadeAtendimento(5995);
            atende.MdiParent = this;
            atende.Show();

        }
    }
}
