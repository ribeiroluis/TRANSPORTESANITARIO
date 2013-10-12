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
    public partial class frmPacientesCadstrados : frmModelo
    {
        DataTable dados;
        public int ID = 0;
        public frmPacientesCadstrados( DataTable _dados)
        {
            InitializeComponent();
            dados = _dados;
        }

        private void frmPacientesCadstrados_Load(object sender, EventArgs e)
        {
            dtgDados.DataSource = dados;
        }        

        private void linkNovo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ID = 0;
            this.Close();
        }

        private void dtgDados_DoubleClick(object sender, EventArgs e)
        {
            var id = dtgDados.CurrentRow.Cells[0].Value;
            ID = (int)id;
            this.Close();
        }
    }
}
