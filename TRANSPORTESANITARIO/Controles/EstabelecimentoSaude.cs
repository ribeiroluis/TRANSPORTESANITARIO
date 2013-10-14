using System;
using System.Collections.Generic;
using System.Text;
using TRANSPORTESANITARIO.BancoDados;
using TRANSPORTESANITARIO.BancoDados.DataSetEstabelecimentoSaudeTableAdapters;
using System.Data;

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
                System.Windows.Forms.MessageBox.Show(err.Message);
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
            catch (Exception err)
            {
                return i;
                System.Windows.Forms.MessageBox.Show(err.Message);
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


        

    }
}
