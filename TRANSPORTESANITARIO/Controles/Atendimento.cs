using System;
using System.Collections.Generic;
using System.Text;
using TRANSPORTESANITARIO.BancoDados;

namespace TRANSPORTESANITARIO.Controles
{
    class Atendimento
    {
        public int IdAtendimento { get; set; }
        public string Hora { get; set; }
        public string Data { get; set; }
        public EstabelecimentoSaude _EstabelecimentoSaude { get; set; }
        public Paciente _Paciente { get; set; }
        public int PADiastolica { get; set; }
        public int PASistolica { get; set; }
        public int FrequenciaCardiaca { get; set; }
        public int FrequenciaRespiratoria { get; set; }
        public int Temperatura { get; set; }
        public int Saturacao { get; set; }
        public Empenho _Empenho { get; set; }
        public Funcionario FuncionarioResponsavel { get; set; }

        public int RetornaULtimoEmpenho()
        {
            BDAtendimento bd = new BDAtendimento();
            IdAtendimento = bd.RetornaUltimoEmpenho();
            return IdAtendimento;
        }

        
        
    }
}
