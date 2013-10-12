using System;
using System.Collections.Generic;
using System.Text;
using TRANSPORTESANITARIO.BancoDados.AmbulanciaEmpenhoDataSetTableAdapters;
using System.Data;

namespace TRANSPORTESANITARIO.Controles
{
    class Ambulancia
    {
        public int Numero { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public int Status { get; set; }
        public string  MotivoBaixa { get; set; }
        tb_ambulanciaTableAdapter bdAmbulancia;

        public Ambulancia()
        {
            bdAmbulancia = new tb_ambulanciaTableAdapter();
        }

        public void PesquisaAmbulancia()
        {
            try
            {
                DataRow Linha = bdAmbulancia.PesquisaPorNumero(Numero).Rows[0];
                Modelo = Linha["MODELO_AMBULANCIA"].ToString();
                Ano = (int)Linha["ANO_AMBULANCIA"];
                //0 - OCUPADA
                //1 - DISPONIVEL
                // 3 - BAIXADA
                Status = (int)(Linha["STATUS_AMBULANCIA"]);
                MotivoBaixa = Linha["MOTIVO_BAIXA"].ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool AtualizarStatusAmbulancia()
        {
            try
            {
                if (bdAmbulancia.AtualizaStatusAmbulancia(Status, MotivoBaixa, Numero) == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                
                throw;
            }
        }


    }
}
