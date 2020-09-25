using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMVC3A.DTO
{
    class tblCategoriaDTO
    {
        private int id;
        private string descricao;

        public int Id { get => id; set => id = value; }
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
                    throw new Exception("O campo Descrição é obrigatório.");
                }

            }
            get { return this.descricao; }
        }
    }
}
