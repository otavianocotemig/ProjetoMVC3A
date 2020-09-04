using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMVC3A.DTO
{
    class tblProdutoDTO
    {
        // Atributos da Tabela
        private int id, quantidade, tbl_categoria_id, tbl_fornecedor_id;
        private String nomeProduto, descricao;
        private double preco, peso;

        // Metodos Get e Set Padrão
        public int Id { get => id; set => id = value; }
        public int Tbl_categoria_id { get => tbl_categoria_id; set => tbl_categoria_id = value; }
        public int Tbl_fornecedor_id { get => tbl_fornecedor_id; set => tbl_fornecedor_id = value; }
        public double Preco { get => preco; set => preco = value; }
        public double Peso { get => peso; set => peso = value; }

        // Metodos Get e Set - Verificar Preenchimento
        public string NomeProduto
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nomeProduto = value;
                }
                else
                {
                    throw new Exception("O campo Nome do Produto é obrigatório.");
                }

            }
            get { return this.nomeProduto; }
        }
        public string Descricao
        {
            set
            {
                if (value != string.Empty)
                {
                    this.descricao = value;
                }
                else
                {
                    throw new Exception("O campo Descrição do Produto é obrigatório.");
                }

            }
            get { return this.descricao; }
        }

        public int Quantidade
        {
            set
            {
                if (value != 0)
                {
                    this.quantidade = value;
                }
                else
                {
                    throw new Exception("O campo Quantidade do Produto é obrigatório.");
                }

            }
            get { return this.quantidade; }
        }

     




    }
}
