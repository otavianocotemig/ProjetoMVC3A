using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMVC3A.DTO
{
    class tblFornecedorDTO
    {
        private int id_fornecedor;
        private string nome_fornecedor, email_fornecedor, telefone_fornecedor;

        public int Id_fornecedor { get => Id_fornecedor; set => Id_fornecedor = value; }
        
        public string Email_fornecedor
        {
            set
            {
                if (value != string.Empty)
                {
                    this.email_fornecedor = value ;
                }
                else
                {
                    throw new Exception("O campo Email é obrigatório.");
                }
            }
            get { return this.email_fornecedor;  }
        }

        public string Nome_fornecedor
        {

            set
            {
                if (value != string.Empty)
                {
                    this.nome_fornecedor = value;
                }
                else
                {
                    throw new Exception("O campo Nome é obrigatório!");
                }
            }
            get { return this.nome_fornecedor; }
        }

        public string Telefone_fornecedor
        {

            set
            {
                if (value != string.Empty)
                {
                    this.telefone_fornecedor = value;
                }
                else
                {
                    throw new Exception("O campo Telefone é obrigatório!");
                }
            }
            get { return this.telefone_fornecedor; }
        }


    }
}
