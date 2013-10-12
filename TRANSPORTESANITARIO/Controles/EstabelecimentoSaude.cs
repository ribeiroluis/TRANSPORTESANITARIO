using System;
using System.Collections.Generic;
using System.Text;
using TRANSPORTESANITARIO.BancoDados;
using TRANSPORTESANITARIO.BancoDados.DataSetEstabelecimentoSaudeTableAdapters;
using System.Data;
using System.Windows.Forms;

namespace TRANSPORTESANITARIO.Controles
{
    class EstabelecimentoSaude
    {
        public int IdEstabelecimentoSaude { get; set; }
        public string NomeEstabelecimento { get; set; }
        public CEP Cep { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string PontoReferencia { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }

        private tb_estabelicimento_saudeTableAdapter bdEstabelecimento;        

        public EstabelecimentoSaude()
        {
            bdEstabelecimento = new tb_estabelicimento_saudeTableAdapter();
            Cep = new CEP();

        }

        public DataTable RetornaLogradouros()
        {
            try
            {
                tb_cepTableAdapter bdEnderecos = new tb_cepTableAdapter();
                return bdEnderecos.GetData();

            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable RetornaEstabelecimentosCadastrados()
        {
            DataTable tb = new DataTable();
            try
            {
                tb = bdEstabelecimento.GetData();
                return tb;
            }
            catch (Exception err)
            {
                return tb;
                MessageBox.Show(err.Message);
            }
        }

        public int IncluirEstabelecimento()
        {
            var i = 0;

            try
            {
                IdEstabelecimentoSaude = RetornaUltimoIDEstabelecimento() + 1;
                i = bdEstabelecimento.Insert(IdEstabelecimentoSaude,
                    NomeEstabelecimento, Cep._CEP,
                    Numero, Complemento,
                    PontoReferencia,
                    Telefone1,
                    Telefone2);
                return i;

            }
            catch (Exception)
            {
                return i;                
            }
            
            
        }

        public int RetornaUltimoIDEstabelecimento()
        {
            try
            {
                var id = bdEstabelecimento.RetornaUltimoId();
                if (id == null)
                    return 0;
                else
                    return (int)id;
            }
            catch (Exception err)
            {

                System.Windows.Forms.MessageBox.Show(err.Message);
                return 0;
            }
        }

        public bool ValidaLogradouro()
        {
            try
            {
                tb_cepTableAdapter bdLogradouros = new tb_cepTableAdapter();
                var cep = bdLogradouros.RetornaCepPorLogradouro(Cep.Logradouro);
                if (cep != null)
                {
                    Cep._CEP = (int)cep;
                    return true;
                }
                else
                    return false;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public void RetornaEstabelecimento()
        {
            try
            {                
                DataRow Linha = bdEstabelecimento.RetornaEstabelecimentoPorNome(NomeEstabelecimento)[0];
                IdEstabelecimentoSaude = (int)Linha["idESTABELICIMENTO_SAUDE"];
                NomeEstabelecimento = Linha["NOME_ESTABELECIMENTO"].ToString();
                Cep._CEP = (int)Linha["TB_CEP_CEP"];
                Cep.RetornaLogradouro();                
                Numero = (int)Linha["NUMERO_ESTABELECIMENTO"];
                Complemento = Linha["COMPLEMENTO_ESTABELECIMENTO"].ToString();
                PontoReferencia = Linha["PONTOREFERENCIA_ESTABELECIMENTO"].ToString();
                Telefone1 = Linha["TELEFONE1_ESTABELECIMENTO"].ToString();
                Telefone2 = Linha["TELEFONE2_ESTABELECIMENTO"].ToString();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public void RetornaEstabelecimentoPorID()
        {
            try
            {
                DataRow Linha = bdEstabelecimento.RetornaEstabelecimentoPorIDComepleto(IdEstabelecimentoSaude)[0];
                NomeEstabelecimento = Linha["NOME_ESTABELECIMENTO"].ToString();
                Cep._CEP = (int)Linha["TB_CEP_CEP"];
                Cep.RetornaLogradouro();
                Numero = (int)Linha["NUMERO_ESTABELECIMENTO"];
                Complemento = Linha["COMPLEMENTO_ESTABELECIMENTO"].ToString();
                PontoReferencia = Linha["PONTOREFERENCIA_ESTABELECIMENTO"].ToString();
                Telefone1 = Linha["TELEFONE1_ESTABELECIMENTO"].ToString();
                Telefone2 = Linha["TELEFONE2_ESTABELECIMENTO"].ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }


        

    }
}
