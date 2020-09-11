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
    public partial class FrmProdutos : Form
    {
        // Instanciar a BLL e DTO da classe
        tblProdutoBLL bllProduto = new tblProdutoBLL();
        tblProdutoDTO dtoProduto = new tblProdutoDTO();
        tblCategoriaBLL bllCategoria = new tblCategoriaBLL();


        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
               GridProdutos.DataSource = bllProduto.PesquisarProdutos();
               this.PreencheCategoria();
        }

        private void btnPesquisarProdutos_Click(object sender, EventArgs e)
        {
            string condicao = "nomeProduto like '%" + txtPesquisarProdutos.Text + "%' or descricao like '%" + txtPesquisarProdutos.Text + "%'";
            GridProdutos.DataSource = bllProduto.PesquisarProdutos(condicao);
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Metodo para Preencher a categoria do produto
        public void PreencheCategoria()
        {
            comboCategoria.DataSource = bllCategoria.ListarCategoria();
            comboCategoria.DisplayMember = "descricao";
            comboCategoria.ValueMember = "id";
        }
    }
}
