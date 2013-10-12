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
    public partial class frmMotivoBaixa : frmModelo
    {
        public string  MotivoBaixa { get; set; }

        public frmMotivoBaixa()
        {
            InitializeComponent();
        }

        private void txMotivo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = btnSalvar;
                txMotivo.Text = txMotivo.Text.ToUpper();
                MotivoBaixa = txMotivo.Text;

            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
