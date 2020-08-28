using ProjetoMVC3A.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMVC3A.BLL
{
    class tblTipousuarioBLL
    {
        // Conexão com o Banco de Dados - DAL - Data Acess Layer
        private DALBD daoBanco = new DALBD();

        public DataTable ListarTipoUsuario()
        {
            string sql = string.Format($@"select * from tbl_tipousuario");
            return daoBanco.ExecutarConsulta(sql);
        }

    }
}
