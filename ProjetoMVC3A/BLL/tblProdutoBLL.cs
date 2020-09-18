using ProjetoMVC3A.DAL;
using ProjetoMVC3A.DTO;
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
        // Metodo para incluir Produto
        public void InserirProduto(tblProdutoDTO ObjProduto)
        {
            string sql = string.Format($@"INSERT INTO tbl_produto VALUES (NULL, '{ObjProduto.NomeProduto}',
                                                                                '{ObjProduto.Descricao}',
                                                                                '{ObjProduto.Preco}',
                                                                                '{ObjProduto.Quantidade}',
                                                                                '{ObjProduto.Peso}',    
                                                                                '{ObjProduto.Tbl_categoria_id}',    
                                                                                '{ObjProduto.Tbl_fornecedor_id}');");
            daoBanco.ExecutarComando(sql);
        }
        // Metodo utilizado para excluir Produto no Banco
        public void ExcluirProduto(tblProdutoDTO objProduto)
        {
            string sql = string.Format($@"DELETE FROM tbl_produto where id = {objProduto.Id};");
            daoBanco.ExecutarComando(sql);
        }

        // metodo utilizado para alterar dados do Produto
        public void AlterarProduto(tblProdutoDTO dtoProduto)
        {
            string sql = string.Format($@"UPDATE tbl_produto set nomeProduto = '{dtoProduto.NomeProduto}',
                                                                 descricao = '{dtoProduto.Descricao}',
                                                                 preco = '{dtoProduto.Preco}',
                                                                 peso = '{dtoProduto.Peso}',
                                                                 quantidade = '{dtoProduto.Quantidade}',
                                                                 tbl_categoria_id  = '{dtoProduto.Tbl_categoria_id}',
                                                                 tbl_fornecedor_id = '{dtoProduto.Tbl_fornecedor_id}'
                                                   where id = '{dtoProduto.Id}';");
            daoBanco.ExecutarComando(sql);
        }
        
    }

  
}
