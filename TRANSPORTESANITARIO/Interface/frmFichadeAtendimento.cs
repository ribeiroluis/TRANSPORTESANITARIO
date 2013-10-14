using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TRANSPORTESANITARIO.Controles;

namespace TRANSPORTESANITARIO.Interface
{
    public partial class frmFichadeAtendimento : frmModelo
    {
        string HoraPedido;
        string Solicitante;
        string Telefone1 = "";
        Atendimento objAtendimento;

        public frmFichadeAtendimento()
        {
            InitializeComponent();
        }
        private void txTelefone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Telefone1 = txTelefone.Text;
                objAtendimento.TelefonePaciente = Telefone1;
                this.ActiveControl = txHorarionoLocal;
            }
        }

        private void txSolicitante_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Solicitante =  txSolicitante.Text.ToUpper();
                this.ActiveControl = cbUnidadeOrigem;
                txSolicitante.Text = Solicitante;
                objAtendimento.Solicitante = Solicitante;
                
                
            }
        }

        private void frmFichadeAtendimento_Load(object sender, EventArgs e)
        {
            objAtendimento = new Atendimento();
            
            HoraPedido = DateTime.Now.ToShortTimeString();
            txHoraPedido.Text = HoraPedido;
            objAtendimento.DataAtendimento = DateTime.Now.ToShortDateString();
            objAtendimento.HoraAtendimento = txHoraPedido.Text;
            txData.Text = objAtendimento.DataAtendimento;
            txNumeroAtendimento.Text = objAtendimento.IdAtendimento.ToString().PadLeft(5, '0');
            CarregarEstabelecimentos();
            this.ActiveControl = txSolicitante;
            
        }

        private void cbUnidadeOrigem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (cbUnidadeOrigem.Text.Equals("Acrescentar novo..."))
                {
                    frmIncluirEstabelecimento incluir = new frmIncluirEstabelecimento();
                    incluir.ShowDialog();
                    this.ActiveControl = cbUnidadeOrigem;                   
                }
            }
        }

        private void CarregarEstabelecimentos()
        {
            cbUnidadeOrigem.Items.Clear();
            cbUnidadeOrigem.Items.Add("Acrescentar novo...");
            foreach (DataRow linhas in objAtendimento.RetornaEstabelecimentosdeSaude().Rows)
            {
                cbUnidadeOrigem.Items.Add(linhas["NOME_ESTABELECIMENTO"].ToString());
            }
        }
    }
}
