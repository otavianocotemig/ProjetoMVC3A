using ProjetoMVC3A.BLL;
using ProjetoMVC3A.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMVC3A.UI
{

    public partial class FrmFornecedor : Form
    {
        tblFornecedorBLL bllFornecedor = new tblFornecedorBLL();
        tblFornecedorDTO dtoFornecedor = new tblFornecedorDTO();

        public FrmFornecedor()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                dtoFornecedor.Nome_fornecedor = txtNome.Text.ToString();
                GridFornecedores.DataSource = bllFornecedor.ListarFornecedores();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
