using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace cad._setor
{
    class setor
    {
       
       
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }

        }

        public bool InserirSetor()
        {
            try
            {
                
                MySqlConnection conexao = new conexaoBD().conectar();
                
                string inserir = "INSERT INTO funcionario (nome) VALUES (@nome)";

                MySqlCommand comando = new MySqlCommand(inserir, conexao);
                comando.Parameters.AddWithValue("@nome", nome);
                comando.ExecuteNonQuery();
                conexao.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar: " + ex.Message);
                return false;
            }
        }

    }
}
