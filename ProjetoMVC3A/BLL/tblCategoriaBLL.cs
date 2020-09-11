using ProjetoMVC3A.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMVC3A.BLL
{
    class tblCategoriaBLL
    {
        private DALBD daoBanco = new DALBD();

        public DataTable ListarCategoria()
        {
            string sql = string.Format($@"select * from tbl_Categoria");
            return daoBanco.ExecutarConsulta(sql);
        }

    }
}
