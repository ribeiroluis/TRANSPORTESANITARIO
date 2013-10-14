using System;
using System.Collections.Generic;
using System.Text;
using TRANSPORTESANITARIO.BancoDados;

namespace TRANSPORTESANITARIO.Controles
{
    class Paciente
    {
        public int IDPaciente { get; set; }
        public string NomePaciente { get; set; }
        public char Sexo { get; set; }
        public int Idade { get; set; }
        public string Historico { get; set; }
        public CEP Cep { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string PontoReferencia { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }

        public Paciente()
        {

        }
    }
}


