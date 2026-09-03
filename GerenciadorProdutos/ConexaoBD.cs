using MySql.Data.MySqlClient;
using System;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorProdutos
{
    public static class ConexaoBD
    {
        private static string connectionString = "Server=localhost;Database=loja_db;Uid=root;Pwd=;";

        public static MySqlConnection ObterConexao()
        {
            try
            {
                MySqlConnection conexao = new MySqlConnection(connectionString);
                conexao.Open();
                return conexao;
            }
            catch (Exception ex)
            {
                throw new Exception("Falha ao conectar ao banco de dados: " + ex.Message);
            }
        }
    }
}
