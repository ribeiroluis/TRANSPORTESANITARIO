using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TRANSPORTESANITARIO.Interface
{
    public partial class frmGerenciaEmpenhos : frmModelo
    {
        public frmGerenciaEmpenhos()
        {
            InitializeComponent();
        }

        private void Relogio_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void frmGerenciaEmpenhos_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
