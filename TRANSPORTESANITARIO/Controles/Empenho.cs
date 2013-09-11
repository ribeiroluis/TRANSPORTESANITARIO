using System;
using System.Collections.Generic;
using System.Text;

namespace TRANSPORTESANITARIO.Controles
{
    class Empenho
    {
        public int IdEmpenho { get; set; }
        public string Horario { get; set; }
        public string Data { get; set; }
        public string Evolucao { get; set; }
        public AmbulanciaEmpenho _AmbulanciaEmpenho { get; set; }



    }
}
