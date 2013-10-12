using System;
using System.Collections.Generic;
using System.Text;
using TRANSPORTESANITARIO.BancoDados.FuncionariosDataSetTableAdapters;
using System.Data;

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
        public Cargo  _Cargo { get; set; }
        tb_funcionarioTableAdapter bdFuncionario;

        public Funcionario()
        {
            bdFuncionario = new tb_funcionarioTableAdapter();
            _Cep = new CEP();
            _Cargo = new Cargo(); 
        }

        public void RetornaProfissionalResponsavelAtendimento()
        {
            try
            {
                DataRow Linha = bdFuncionario.RetornaFuncionarioMatricula(Matricula).Rows[0];                
                Matricula = (int)Linha["MATRICULA_FUNCIONARIO"];
                Apelido = Linha["APELIDO_FUNCIONARIO"].ToString();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable RetornaFuncionariosporCargo(string cargo)
        {
            try
            {
                cargo = "%" + cargo + "%";
                DataTable tb = bdFuncionario.RetornaNomePorCargo(cargo);
                return tb;
            }
            catch (Exception)
            {                
                throw;
            }
        }

        public void PreencheFuncionarioPorApelido()
        {
            try
            {
                DataRow Linha = bdFuncionario.RetornaFuncionarioporApelido(Apelido).Rows[0];
                Matricula = (int)Linha["MATRICULA_FUNCIONARIO"];
                Nome = Linha["NOME_FUNCIONARIO"].ToString();
                TelefoneFixo = Linha["TELEFONEFIXO_FUNCIONARIO"].ToString();
                TelefoneCelular = Linha["TELEFONECELULAR_FUNCIONARIO"].ToString();
                _Cep._CEP = (int)Linha["TB_CEP_CEP"];
                Numero = (int)Linha["NUMERO_FUNCIONARIO"];
                Complemento = Linha["COMPLEMENTO_FUNCIONARIO"].ToString();
                _Cargo.IdCargo = (int)Linha["TB_CARGO_idCARGO"];
                
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
