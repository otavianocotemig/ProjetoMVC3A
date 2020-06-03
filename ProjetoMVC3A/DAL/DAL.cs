using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMVC3A.DAL
{
    class DAL
    {
        private MySqlConnection conexao;
        private string string_conexao = "Persist security info= false; " + "server = localhost; " +
                                         "Database=dbmvc " + " user=root; pwd=;";
        private void conectar()
        {
            conexao = new MySqlConnection(string_conexao);
            conexao.Open();
        }                                    

    }
}
