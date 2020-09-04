using ProjetoMVC3A.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMVC3A.BLL
{
    class tblProdutoBLL
    {
        // Conectar com o banco de dados
        DALBD daoBanco = new DALBD();

        // Criar os metodos da classe
        // CRUD - Inserir - Pesquisar - Alterar - Deletar
        public DataTable PesquisarProdutos(string condicao)
        {
            string sql = string.Format($@"select * from tbl_produto where " + condicao);
            return daoBanco.ExecutarConsulta(sql);
        }
        public DataTable PesquisarProdutos()
        {
            string sql = string.Format($@"select * from tbl_produto");
            return daoBanco.ExecutarConsulta(sql);
        }
    }

  
}
