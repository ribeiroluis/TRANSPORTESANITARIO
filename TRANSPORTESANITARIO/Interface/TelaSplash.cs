using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TRANSPORTESANITARIO.Interface
{
    public partial class TelaSplash : Form
    {
        public TelaSplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value<100)
                progressBar1.Value += 2;
            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                this.Visible = false;
                frmMenuPrincipal menu = new frmMenuPrincipal();
                menu.ShowDialog();
                this.Close();                
            }              
  
        }
    }
}
