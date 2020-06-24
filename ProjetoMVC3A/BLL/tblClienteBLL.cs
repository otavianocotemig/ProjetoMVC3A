using ProjetoMVC3A.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Runtime.InteropServices.WindowsRuntime;

namespace ProjetoMVC3A.BLL
{
    class tblClienteBLL
    {
        private DALBD daoBanco = new DALBD();

        public Boolean Autenticar(string email, string senha)
        {
            string consulta = string.Format($@"select * from tbl_cliente where email_cliente = '{email}' and senha_cliente='{senha}';");
            DataTable dt = daoBanco.ExecutarConsulta(consulta);
            if (dt.Rows.Count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string RecuperarSenha(string email)
        {
           
            string consulta = string.Format($@"select * from tbl_cliente where email_cliente = '{email}';");
            DataTable dt = daoBanco.ExecutarConsulta(consulta);
            if (dt.Rows.Count == 1)
            {
                return dt.Rows[0].["senha_cliente"].ToString;
                
            }
            else
            {
                return "";
            }
        }


    }
}
