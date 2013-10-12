using System;
using System.Collections.Generic;
using System.Text;
using TRANSPORTESANITARIO.BancoDados.DataSetEstabelecimentoSaudeTableAdapters;
using System.Data;

namespace TRANSPORTESANITARIO.Controles
{
    class CEP
    {
        public int _CEP { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }

        public CEP()
        {

        }

        public void RetornaLogradouro()
        {
            ViewLogradourosTableAdapter bdcep = new ViewLogradourosTableAdapter();
            DataRow Linha = bdcep.GetData(_CEP).Rows[0];
            Logradouro = Linha["LOGRADOURO_CEP"].ToString();
            Bairro = Linha["NOME_BAIRRO"].ToString();
            Cidade = Linha["NOME_CIDADE"].ToString();
        }


    
    }
}
