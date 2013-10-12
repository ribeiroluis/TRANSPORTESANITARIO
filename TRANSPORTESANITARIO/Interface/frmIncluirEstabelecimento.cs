using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TRANSPORTESANITARIO.Controles;
using TRANSPORTESANITARIO.BancoDados.DataSetEstabelecimentoSaudeTableAdapters;

namespace TRANSPORTESANITARIO.Interface
{
    public partial class frmIncluirEstabelecimento : frmModelo
    {
        EstabelecimentoSaude ObjEstabelecimentoSaude = new EstabelecimentoSaude();
        public int IdEstabelecimento;

        public frmIncluirEstabelecimento()
        {
            InitializeComponent();

        }

        private void frmIncluirEstabelecimento_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txNome;

            DataTable TabelaEnderecos = ObjEstabelecimentoSaude.RetornaLogradouros();
            foreach (DataRow ruas in TabelaEnderecos.Rows)
            {
                txLogradouro.AutoCompleteCustomSource.Add(ruas["LOGRADOURO_CEP"].ToString());
            }
        }

        private void txNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txNome.Text = ValidaTexto(txNome.Text.ToUpper());
                if (!txNome.Text.Equals(""))
                {
                    ObjEstabelecimentoSaude.NomeEstabelecimento = txNome.Text;
                    txLogradouro.ReadOnly = false;
                    this.ActiveControl = txLogradouro;
                }
            }
        }

        private string ValidaTexto(string texto)
        {
            bool stopErro = true;
            foreach (char caractere in texto)
            {
                if (caractere != 32)
                {
                    if (caractere < 65 || caractere > 90)
                    {
                        MessageBox.Show("Não utilize acentuação ou caracteres especiais:\n^`:'çáéí...");
                        stopErro = false;
                        break;
                    }
                }
            }

            if (stopErro)
            {
                return texto;
            }

            return string.Empty;
        }

        private void txLogradouro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    ObjEstabelecimentoSaude.Cep.Logradouro = txLogradouro.Text;
                    if (ObjEstabelecimentoSaude.ValidaLogradouro())
                    {
                        txNumero.ReadOnly = false;
                        this.ActiveControl = txNumero;
                    }
                    else
                    {
                        MessageBox.Show("Verifique o logradouro!");
                        ObjEstabelecimentoSaude.Cep.Logradouro = string.Empty;
                    }

                }
                catch (Exception err)
                {

                    MessageBox.Show(err.Message);
                }
            }
        }

        private void txNumero_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    ObjEstabelecimentoSaude.Numero = int.Parse(txNumero.Text);
                    txComplemento.ReadOnly = false;
                    this.ActiveControl = txComplemento;
                }
                catch (Exception err)
                {

                    MessageBox.Show(err.Message);
                }
            }
        }

        private void txComplemento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    ObjEstabelecimentoSaude.Complemento = txComplemento.Text.ToUpper();
                    txTelefone1.ReadOnly = false;
                    this.ActiveControl = txTelefone1;
                }
                catch (Exception err)
                {

                    MessageBox.Show(err.Message);
                }
            }
        }

        private void txTelefone1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (txTelefone1.Text.Equals("") || txTelefone1.Text.Length < 10)
                    {
                        MessageBox.Show("Pelo menos um telefone necessita ser cadastrado.\nVerifique o telefone, pode estar errado.");
                        txTelefone1.Text = string.Empty;
                        this.ActiveControl = txTelefone1;
                    }
                    else
                    {
                        ObjEstabelecimentoSaude.Telefone1 = txTelefone1.Text;
                        txTelefone2.ReadOnly = false;
                        this.ActiveControl = txTelefone2;
                    }
                }
                catch (Exception err)
                {

                    MessageBox.Show(err.Message);
                }
            }
        }

        private void txTelefone2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (!txTelefone2.Text.Equals("") && txTelefone1.Text.Length < 10)
                    {
                        MessageBox.Show("Telefone incorreto");
                        txTelefone2.Text = string.Empty;
                        this.ActiveControl = txTelefone2;
                    }
                    else
                    {
                        ObjEstabelecimentoSaude.Telefone2 = txTelefone2.Text;
                        txPontoReferencia.ReadOnly = false;
                        this.ActiveControl = txPontoReferencia;
                    }
                }
                catch (Exception err)
                {

                    MessageBox.Show(err.Message);
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                ObjEstabelecimentoSaude.PontoReferencia = txPontoReferencia.Text.ToUpper();
                txPontoReferencia.Text = ObjEstabelecimentoSaude.PontoReferencia;
                int i = ObjEstabelecimentoSaude.IncluirEstabelecimento();
                if (i == 1)
                {
                    MessageBox.Show("Salvo com sucesso.");
                    IdEstabelecimento = ObjEstabelecimentoSaude.IdEstabelecimentoSaude;
                    this.Close();
                }
                else
                    MessageBox.Show("Erro ao gravar.");
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}