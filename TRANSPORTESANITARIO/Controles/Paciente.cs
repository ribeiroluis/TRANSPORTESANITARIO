using System;
using System.Collections.Generic;
using System.Text;
using TRANSPORTESANITARIO.BancoDados.PacientesDataSetTableAdapters;
using System.Data;
using System.Windows.Forms;

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
        tb_pacienteTableAdapter bdPaciente;
        public bool ExistePaciente { get; set; }

        public Paciente()
        {
            Cep = new CEP();
            bdPaciente = new tb_pacienteTableAdapter();
            RetornaUltimoID();
        }

        public DataTable RetornaPacientesCadastrados()
        {
            try
            {
                return bdPaciente.GetData();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void RetornaUltimoID()
        {
            try
            {
                var id = bdPaciente.RetornaUltimoIdCadastrado();
                if (id != null)
                    IDPaciente = (int)id + 1;
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public DataTable VerificaNomeCadastrado(string _nome)
        {
            try
            {
                _nome = "%" + _nome + "%";
                DataTable tabelaPaciente = bdPaciente.RetornaPacientePorNome(_nome);
                if (tabelaPaciente.Rows.Count == 1)
                {
                    DataRow linha = tabelaPaciente.Rows[0];
                    string _auxnome = linha["NOME_PACIENTE"].ToString();
                    string _idade = linha["IDADE_PACIENTE"].ToString();
                    string historico = linha["HISTORICO_PACIENTE"].ToString();
                    string dados = "\nNome: " + _auxnome + "\nIdade: " + _idade + "\nHistórico: " + historico;


                    DialogResult resultado = MessageBox.Show("Confirmar o paciente: " + dados,"Atencao",
                        MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        IDPaciente = (int)linha["idPACIENTE"];
                        NomePaciente = linha["NOME_PACIENTE"].ToString();
                        Sexo = Convert.ToChar(linha["SEXO_PACIENTE"]);
                        Idade = (int)linha["IDADE_PACIENTE"];
                        Historico = linha["HISTORICO_PACIENTE"].ToString();
                        Cep._CEP = (int)linha["TB_CEP_CEP"];
                        Cep.RetornaLogradouro();
                        Numero = (int)linha["NUMERO_PACIENTE"];
                        Complemento = linha["COMPLEMENTO_PACIENTE"].ToString();
                        PontoReferencia = linha["PONTOREFERENCIA_PACIENTE"].ToString();
                        Telefone1 = linha["TELEFONE1_PACIENTE"].ToString();
                        Telefone2 = linha["TELEFONE2_PACIENTE"].ToString();
                    }
                    else
                        return null;

                }
                else if (tabelaPaciente.Rows.Count > 1)
                {
                    return tabelaPaciente;
                }
                else
                    return null;
                
                return tabelaPaciente;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void PreenchePacientePorID()
        {
            try
            {
                DataTable tabelaPaciente = bdPaciente.RetornaPacientePorID(IDPaciente);
                if (tabelaPaciente.Rows.Count == 1)
                {
                    DataRow linha = tabelaPaciente.Rows[0];
                    IDPaciente = (int)linha["idPACIENTE"];
                    NomePaciente = linha["NOME_PACIENTE"].ToString();
                    Sexo = char.Parse(linha["SEXO_PACIENTE"].ToString());
                    Idade = (int)linha["IDADE_PACIENTE"];
                    Historico = linha["HISTORICO_PACIENTE"].ToString();

                    if (linha["TB_CEP_CEP"] != null)
                    {
                        Cep._CEP = (int)linha["TB_CEP_CEP"];
                        Cep.RetornaLogradouro();
                    }
                    if (!linha["NUMERO_PACIENTE"].ToString().Equals(""))
                        Numero = (int)linha["NUMERO_PACIENTE"];
                    if (!linha["COMPLEMENTO_PACIENTE"].ToString().Equals(""))
                        Complemento = linha["COMPLEMENTO_PACIENTE"].ToString();
                    if (!linha["PONTOREFERENCIA_PACIENTE"].ToString().Equals(""))
                        PontoReferencia = linha["PONTOREFERENCIA_PACIENTE"].ToString();
                    if (!linha["TELEFONE1_PACIENTE"].ToString().Equals(""))
                        Telefone1 = linha["TELEFONE1_PACIENTE"].ToString();
                    if (!linha["TELEFONE2_PACIENTE"].ToString().Equals(""))
                        Telefone2 = linha["TELEFONE2_PACIENTE"].ToString();
                }               
                
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool InserePaciente()
        {
            try
            {
                RetornaUltimoID();
                int x = bdPaciente.Insert(IDPaciente, NomePaciente, Sexo.ToString(), Idade, Historico,
                    Cep._CEP, Numero, Complemento, PontoReferencia, Telefone1, Telefone2);
                if (x == 1)
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                throw;
            }
            

        }

        public void VerificaExistePaciente()
        {
            try
            {
                DataTable tbPaciente = bdPaciente.RetornaPacientePorID(IDPaciente);
                if (tbPaciente.Rows.Count == 1)
                {
                    DataRow linha = tbPaciente.Rows[0];
                    IDPaciente = (int)linha["idPACIENTE"];
                    ExistePaciente = true;
                }
                else
                    ExistePaciente = false;

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool AtualizaPaciente()
        {
            try
            {
                int i = bdPaciente.AtualizaPaciente(Idade, Historico, Telefone1, IDPaciente);
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

        
    }
}


