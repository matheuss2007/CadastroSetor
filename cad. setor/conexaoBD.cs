using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace cad._setor
{
    class conexaoBD
    {
        private string conexaoBanco = "Server=localhost; Database=setor; Uid=root; Pwd='';";

        public MySqlConnection conectar()
        {
            MySqlConnection conexao = new MySqlConnection(conexaoBanco);

            conexao.Open();
            return conexao;
        }

            

    }

    
}
