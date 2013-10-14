using System;
using System.Collections.Generic;
using System.Text;
using TRANSPORTESANITARIO.BancoDados.AtendimentoDataSetTableAdapters;
using System.Data;

namespace TRANSPORTESANITARIO.Controles
{
    class Atendimento
    {
        public int IdAtendimento { get; set; }

        public string HoraAtendimento { get; set; }
        public string DataAtendimento { get; set; }
        public string Solicitante { get; set; }
        public string HoraConsultaExame { get; set; }
        public string DataconsultaExame { get; set; }
        public string TelefonePaciente { get; set; }

        public EstabelecimentoSaude _EstabelecimentoSaudeOrigem { get; set; }
        public EstabelecimentoSaude _EstabelecimentoSaudeDestino { get; set; }
        public Paciente _PacienteOrigem { get; set; }
        public Paciente _Pacientedestino { get; set; }

        public int PADiastolica { get; set; }
        public int PASistolica { get; set; }
        public int FrequenciaCardiaca { get; set; }
        public int FrequenciaRespiratoria { get; set; }
        public int Temperatura { get; set; }
        public int Saturacao { get; set; }

        public Empenho _Empenho { get; set; }
        public Funcionario FuncionarioResponsavel { get; set; }

        public Atendimento()
        {
            IdAtendimento = RetornaULtimoEmpenho() + 1;
            _EstabelecimentoSaudeOrigem = new EstabelecimentoSaude();
            _EstabelecimentoSaudeOrigem = new EstabelecimentoSaude();
        }

        public int RetornaULtimoEmpenho()
        {            
            try
            {
                tb_atendimentoTableAdapter bdAtendimento = new tb_atendimentoTableAdapter();
                var i = bdAtendimento.RetornaUltimoEmpenho();
                if (i == null)
                    return 0;
                else
                    return (int)i;
            }
            catch (Exception err)
            {
                System.Windows.Forms.MessageBox.Show(err.Message);
                return 0;
            }
        }

        public DataTable RetornaEstabelecimentosdeSaude()
        {
           return _EstabelecimentoSaudeOrigem.RetornaEstabelecimentosCadastrados();

        }

        
        
    }
}
