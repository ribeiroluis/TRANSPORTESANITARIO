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
        public bool StatusAtendimento { get; set; }

        public DateTime HoraAtendimento { get; set; }
        public DateTime DataAtendimento { get; set; }
        public string Solicitante { get; set; }
        public DateTime HoraConsultaExame { get; set; }
        public DateTime DataconsultaExame { get; set; }

        public EstabelecimentoSaude _EstabelecimentoSaudeOrigem { get; set; }
        public EstabelecimentoSaude _EstabelecimentoSaudeDestino { get; set; }
        public Paciente _Paciente { get; set; }

        public int PADiastolica { get; set; }
        public int PASistolica { get; set; }
        public int FrequenciaCardiaca { get; set; }
        public int FrequenciaRespiratoria { get; set; }
        public int Temperatura { get; set; }
        public int Saturacao { get; set; }
        public string  Observacao { get; set; }

        public string EvolucaoEmpenho { get; set; }
        public int Ambulancia { get; set; }
        public string  ProfTecnicoEnfermagem { get; set; }
        public string Motorista { get; set; }


        public Empenho _Empenho { get; set; }
        public Funcionario FuncionarioResponsavel { get; set; }

        tb_atendimentoTableAdapter bdAtendimento;




        public Atendimento()
        {
           
            _EstabelecimentoSaudeOrigem = new EstabelecimentoSaude();
            _EstabelecimentoSaudeDestino = new EstabelecimentoSaude();
            _Paciente = new Paciente();
            FuncionarioResponsavel = new Funcionario();
            bdAtendimento = new tb_atendimentoTableAdapter();
            _Empenho = new Empenho();
            IdAtendimento = RetornaULtimoEmpenho() + 1;
        }

        public int RetornaULtimoEmpenho()
        {            
            try
            {
                
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

        private void InserePaciente()
        {
            _Paciente.VerificaExistePaciente();

            if (!_Paciente.ExistePaciente)
            {
                _Paciente.InserePaciente();
            }
            else
                _Paciente.AtualizaPaciente();
            
        }
        
        public bool IncluirAtendimento()
        {
            try
            {
                InserePaciente();
                int a = bdAtendimento.Insert(IdAtendimento, Convert.ToDateTime(HoraAtendimento),
                    Convert.ToDateTime(DataAtendimento), Convert.ToDateTime(HoraConsultaExame),
                    Convert.ToDateTime(DataconsultaExame), _EstabelecimentoSaudeOrigem.IdEstabelecimentoSaude,
                    _EstabelecimentoSaudeDestino.IdEstabelecimentoSaude, _Paciente.IDPaciente, _Paciente.IDPaciente, PADiastolica, PADiastolica,
                    FrequenciaCardiaca, FrequenciaRespiratoria, Temperatura, Saturacao, FuncionarioResponsavel.Matricula,
                    0, Solicitante, Observacao);

                if (a == 1)
                    return true;
                else
                    return false;

            }
            catch (Exception)
            {
                
                throw;
            }
            
        }

        public bool PesquisaAtendimento()
        {
            try
            {
                DataRow Linha = bdAtendimento.RetornaDadosEmpenho(IdAtendimento)[0];
                HoraAtendimento = DateTime.Parse(Linha["HORARIO_ATENDIMENTO"].ToString());
                DateTime data = DateTime.Parse(Linha["DATA_ATENDIMENTO"].ToString());
                DataAtendimento = data;
                HoraConsultaExame = DateTime.Parse(Linha["HORACONSULTA_ATENDIMENTO"].ToString());
                data = DateTime.Parse(Linha["DATACONSULTA_ATENDIMENTO"].ToString());
                DataconsultaExame = data;
                _EstabelecimentoSaudeOrigem.IdEstabelecimentoSaude = int.Parse(Linha["ESTABELECIMENTOorigem_ATENDIMENTO"].ToString());
                _EstabelecimentoSaudeOrigem.RetornaEstabelecimentoPorID();
                _EstabelecimentoSaudeDestino.IdEstabelecimentoSaude = int.Parse(Linha["ESTABELECIMENTOdestino_ATENDIMENTO"].ToString());
                _Paciente.IDPaciente = int.Parse(Linha["PACIENTEorigem_ATENDIMENTO"].ToString());
                _Paciente.PreenchePacientePorID();
                PADiastolica = int.Parse(Linha["PADISTOLICA_ATENDIMENTO"].ToString());
                PASistolica = int.Parse(Linha["PASISTOLICA_ATENDIMENTO"].ToString());
                FrequenciaCardiaca = int.Parse(Linha["FREQUENCIACARDIACA_ATENDIMENTO"].ToString());
                FrequenciaRespiratoria = int.Parse(Linha["FREQUENCIARESPIRATORIA_ATENDIMENTO"].ToString());
                Temperatura = int.Parse(Linha["TEMPERATURA_ATENDIMENTO"].ToString());
                Saturacao = int.Parse(Linha["SATURACAO_ATENDIMENTO"].ToString());
                FuncionarioResponsavel.Matricula = int.Parse(Linha["TB_FUNCIONARIO_MATRICULA_FUNCIONARIORESPONSAVEL"].ToString());
                FuncionarioResponsavel.RetornaProfissionalResponsavelAtendimento();
                StatusAtendimento = Convert.ToBoolean(Linha["STATUS_ATENDIMENTO"]);
                Solicitante = Linha["SOLICITANTE_ATENDIMENTO"].ToString();
                Observacao = Linha["OBSERVACAO_ATENDIMENTO"].ToString();
                return true;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool PesquisaAtendimentoExistente()
        {
            try
            {
                var x = bdAtendimento.PesquisaAtendimentoExistente(IdAtendimento);
                if (x != null)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool AlteraAtendimento()
        {
            try
            {
                int i = bdAtendimento.AtualizaAtendimento(HoraAtendimento, DataAtendimento, HoraConsultaExame, DataconsultaExame, _EstabelecimentoSaudeOrigem.IdEstabelecimentoSaude,
                    _EstabelecimentoSaudeDestino.IdEstabelecimentoSaude, _Paciente.IDPaciente, _Paciente.IDPaciente, PADiastolica, PASistolica, FrequenciaCardiaca,
                    FrequenciaRespiratoria, Temperatura, Saturacao, Solicitante, Convert.ToInt16(StatusAtendimento), Observacao, FuncionarioResponsavel.Matricula, IdAtendimento);
                if (i == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                
                throw;
            }
            return true;
        }


    }
}
