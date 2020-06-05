using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMVC3A.DAL
{
    class DALBD
    {
        private MySqlConnection conexao;
        private string string_conexao = "Persist security info= false; " + "server = localhost; " +
                                         "Database=dbmvc " + " user=root; pwd=;";
        // Metodo para conexão com o BD
        public void conectar()
        {
            try
            {
                conexao = new MySqlConnection(string_conexao);
                conexao.Open();
            }
            catch (MySqlException e)
            {
                throw new Exception("Problemas na conexão com o banco de dados. Erro: " + e.Message);

            }
        } 
        // Metodo para Executar Consulta no Banco
        public void ExecutarComando(string sql)
        {
            try
            {
                conectar();
                MySqlCommand comando = new MySqlCommand(sql, conexao);
                comando.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                throw new Exception("Não foi possível executar a instrução no Banco. Erro: " + e.Message);
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
