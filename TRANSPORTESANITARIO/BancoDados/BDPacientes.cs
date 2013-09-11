using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TRANSPORTESANITARIO.Controles;

namespace TRANSPORTESANITARIO.BancoDados
{
    class BDPacientes
    {
        public BDPacientes()
        {

        }

        public List<Paciente> RetornaListadePacientesCadastrados()
        {
            //criar rotina...
            Paciente p = new Paciente();
            p.NomePaciente = "Luis Henrique Ribeiro";
            p.Idade = 30;
            p.IDPaciente = 1;
            p.Historico = "Acamado, TCP, DDLL";
            CEP _cep = new CEP();
            _cep._CEP = 32604624;
            p.Cep = _cep;
            p.Complemento = "201";
            p.Numero = 275;
            p.PontoReferencia = "Supermercado bh";
            p.Sexo = 'M';
            p.Telefone1 = "35967866";
            List<Paciente> lista = new List<Paciente>();
            lista.Add(p);
            return lista;

        }
    }
}
