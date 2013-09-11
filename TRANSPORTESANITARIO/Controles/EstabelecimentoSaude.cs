using System;
using System.Collections.Generic;
using System.Text;

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
        
    }
}
