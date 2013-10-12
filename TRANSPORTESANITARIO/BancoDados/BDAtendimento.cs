using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;


namespace TRANSPORTESANITARIO.BancoDados
{
    class BDAtendimento
    {
        string _conxaoMysql = "server=localhost; user id=root; password=mestre123456; database=transportesanitariobd";
        MySqlConnection conexao = null;

        public BDAtendimento()
        {
            try
            {
                conexao = new MySqlConnection(_conxaoMysql);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public int RetornaUltimoEmpenho()
        {
            //criar rotina de max
            return 1;
        }
    
    }
}
