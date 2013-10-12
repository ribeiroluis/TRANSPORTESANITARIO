using System;
using System.Collections.Generic;
using System.Text;
using TRANSPORTESANITARIO.BancoDados.AmbulanciaEmpenhoDataSetTableAdapters;
using System.Data;

namespace TRANSPORTESANITARIO.Controles
{
    class FuncionarioAmbulancia
    {
        public int idFuncionarioAmbulancia { get; set; }
        public Ambulancia _Ambulancia { get; set; }
        public DateTime Data { get; set; }
        public DateTime HoraIncio { get; set; }
        public DateTime HoraFim { get; set; }
        public Funcionario Motorista { get; set; }
        public Funcionario Enfermagem { get; set; }
        public int KM_Percorrido { get; set; }
        tb_funcionario_ambulanciaTableAdapter  BDFuncionarioAmbulancia { get; set; }
        tb_baixaambulanciaTableAdapter BDBaixaAmbulancia { get; set; }

        public FuncionarioAmbulancia()
        {
            _Ambulancia = new Ambulancia();
            Motorista = new Funcionario();
            Enfermagem = new Funcionario();
            BDFuncionarioAmbulancia = new tb_funcionario_ambulanciaTableAdapter();
            BDBaixaAmbulancia = new tb_baixaambulanciaTableAdapter();
        }

        public bool PesquisaAmbulanciaDoDia()
        {
            try
            {
                DataTable x = BDFuncionarioAmbulancia.PesquisaAmbulanciaRegistrado(_Ambulancia.Numero);
                int cont = 0;
                foreach (DataRow linha in x.Rows)
                {
                    string _auxdata = Convert.ToDateTime(linha["DATA_FUNCIONARIOAMBULANCIA"]).ToShortDateString();
                    var horafim = linha["HORAFIM_FUNCIONARIOAMBULANCIA"].ToString();
                    string _auxdata2 = Data.ToShortDateString();
                    if (_auxdata.Equals(_auxdata2) && horafim.Equals(""))
                    {
                        cont++;
                        idFuncionarioAmbulancia = (int)linha["idFUNCIONARIOAMBULANCIA"];
                    }
                }
                if (cont == 0)
                    x = null;

                
                if (x == null || x.Rows.Count == 0)
                {                    
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool InsereAmbulanciaDia()
        {
            try
            {
                int i = 0;
                if (Enfermagem.Matricula == 0)
                    i = BDFuncionarioAmbulancia.InserirAmbulanciaDia(_Ambulancia.Numero, Motorista.Matricula,
                    null, Data, HoraIncio, KM_Percorrido);
                else
                    i = BDFuncionarioAmbulancia.InserirAmbulanciaDia(_Ambulancia.Numero, Motorista.Matricula,
                    Enfermagem.Matricula, Data, HoraIncio, KM_Percorrido);

                if (i == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }

        public bool AtualizaAmbulancia()
        {
            try
            {
                int i = 0;
                if (Enfermagem.Matricula == 0)
                    i = BDFuncionarioAmbulancia.AtualizaAmbulancia(_Ambulancia.Numero, Motorista.Matricula, null,
                        Data, HoraIncio, idFuncionarioAmbulancia);
                else
                    i = BDFuncionarioAmbulancia.AtualizaAmbulancia(_Ambulancia.Numero, Motorista.Matricula, Enfermagem.Matricula,
                        Data, HoraIncio, idFuncionarioAmbulancia);

                if (i == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                
                throw;
            }

            
 
        }

        public bool AtualizaAmbulancia(bool fim)
        {
            try
            {
                int i = 0;
                if (idFuncionarioAmbulancia != 0)
                    i = BDFuncionarioAmbulancia.AtualizaAmbulanciaFim(DateTime.Now, idFuncionarioAmbulancia);

                if (i == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                
                throw;
            }
 
        }

        public bool BaixarAmbulancia()
        {
            try
            {
                int i = BDBaixaAmbulancia.InsereBaixa(DateTime.Now, _Ambulancia.Numero, _Ambulancia.MotivoBaixa);
                if (i == 1)
                {
                    if (_Ambulancia.AtualizarStatusAmbulancia())
                        return true;
                    else
                        return false;
                }
                else
                    return false;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool RetornarAmbulancia()
        {
            try
            {
                int idBaixa = (int)BDBaixaAmbulancia.RetornaIDBaixa(_Ambulancia.Numero);
                int i = BDBaixaAmbulancia.RetornaAmbulancia(DateTime.Now, idBaixa);

                if (i == 1)
                {
                    if (_Ambulancia.AtualizarStatusAmbulancia())
                        return true;
                    else
                        return false;
                }
                else
                    return false;
            }
            catch (Exception)
            {

                throw;
            }
 
        }

        public bool PreencheFuncionarioAmbulancia()
        {
            try
            {
                DataTable x = BDFuncionarioAmbulancia.PesquisaAmbulanciaRegistrado(_Ambulancia.Numero);
                foreach (DataRow linha in x.Rows)
                {
                    var horafim = linha["HORAFIM_FUNCIONARIOAMBULANCIA"].ToString();
                    if (horafim.Equals(""))
                    {
                        _Ambulancia.PesquisaAmbulancia();
                        idFuncionarioAmbulancia = (int)linha["idFUNCIONARIOAMBULANCIA"];
                        Enfermagem.Matricula = (int)linha["TECNICO_FUNCIONARIO"];
                        Motorista.Matricula = (int)linha["MOTORISTA_FUNCIONARIO"];
                        Data = Convert.ToDateTime(linha["DATA_FUNCIONARIOAMBULANCIA"]);
                        Enfermagem.RetornaProfissionalResponsavelAtendimento();
                        Motorista.RetornaProfissionalResponsavelAtendimento();
                        return true;
                    }
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
 
        }



        
    }
}
