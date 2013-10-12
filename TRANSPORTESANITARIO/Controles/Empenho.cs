using System;
using System.Collections.Generic;
using System.Text;

namespace TRANSPORTESANITARIO.Controles
{
    class Empenho
    {
        public int IdEmpenho { get; set; }        
        public string Data { get; set; }
        public string HoraInicio { get; set; }
        public string HoraFim { get; set; }
        public string Evolucao { get; set; }
        public FuncionarioAmbulancia _FuncionarioAmbulancia { get; set; }
        public Empenho()
        {
            _FuncionarioAmbulancia = new FuncionarioAmbulancia();
        }



    }
}
