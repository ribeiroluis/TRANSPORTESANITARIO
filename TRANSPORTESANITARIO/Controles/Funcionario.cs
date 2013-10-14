using System;
using System.Collections.Generic;
using System.Text;

namespace TRANSPORTESANITARIO.Controles
{
    class Funcionario
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public string TelefoneFixo { get; set; }
        public string TelefoneCelular { get; set; }
        public CEP _Cep { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Apelido { get; set; }
    }
}
