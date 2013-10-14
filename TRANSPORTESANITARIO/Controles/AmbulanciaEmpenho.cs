using System;
using System.Collections.Generic;
using System.Text;

namespace TRANSPORTESANITARIO.Controles
{
    class AmbulanciaEmpenho
    {
        public int IdAmbulanciaEmpenho { get; set; }
        public Ambulancia _Ambulancia { get; set; }
        public string Data { get; set; }
        public string HoraIncio { get; set; }
        public string HoraFim { get; set; }
        public Funcionario Motorista { get; set; }
        public Funcionario Enfermagem { get; set; }
        public int KMInicial { get; set; }
        public int KMFinal { get; set; }
        public bool Disponivel { get; set; }
        public string Observacao { get; set; }

        
    }
}
