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
        tblFornecedorBLL bllFornecedor = new tblFornecedorBLL();



        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
               GridProdutos.DataSource = bllProduto.PesquisarProdutos();
               this.PreencheCategoria();
            this.PreencheFornecedor();

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

        // Metodo para Preencher a Fornecedor
        public void PreencheFornecedor()
        {
            comboFornecedor.DataSource = bllFornecedor.ListarFornecedores();
            comboFornecedor.DisplayMember = "nome";
            comboFornecedor.ValueMember = "id";
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                dtoProduto.NomeProduto = txtNome.Text;
                dtoProduto.Descricao = txtDescricao.Text;
                dtoProduto.Peso = double.Parse(txtPeso.Text);
                dtoProduto.Quantidade = int.Parse(txtQuantidade.Text);
                dtoProduto.Preco = double.Parse(txtPreco.Text);
                dtoProduto.Tbl_categoria_id =   int.Parse(comboCategoria.SelectedValue.ToString());
                dtoProduto.Tbl_fornecedor_id = int.Parse(comboFornecedor.SelectedValue.ToString());
                //
                bllProduto.InserirProduto(dtoProduto);
                MessageBox.Show("Inserção Realizada com Sucesso. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GridProdutos.DataSource = bllProduto.PesquisarProdutos();
                new LimpaForm(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
           
        }

        private void GridProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GridProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = GridProdutos.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = GridProdutos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDescricao.Text = GridProdutos.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPreco.Text = GridProdutos.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtQuantidade.Text = GridProdutos.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtPeso.Text = GridProdutos.Rows[e.RowIndex].Cells[5].Value.ToString();
            comboCategoria.SelectedItem = GridProdutos.Rows[e.RowIndex].Cells[6].Value.ToString();
            comboFornecedor.SelectedItem = GridProdutos.Rows[e.RowIndex].Cells[7].Value.ToString();
            //
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnNovo.Enabled = false;

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Está ação irá deletar o registro selecionado e não poderá ser desfeito, deseja continuar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                   dtoProduto.Id = Convert.ToInt32(txtId.Text);
                   bllProduto.ExcluirProduto(dtoProduto);
                   GridProdutos.DataSource = bllProduto.PesquisarProdutos();
                    new LimpaForm(this);
                    btnExcluir.Enabled = false;
                    btnEditar.Enabled = false;
                    btnNovo.Enabled = true;

                  
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                dtoProduto.Id = int.Parse(txtId.Text);
                dtoProduto.NomeProduto = txtNome.Text;
                dtoProduto.Descricao = txtDescricao.Text;
                dtoProduto.Peso = double.Parse(txtPeso.Text);
                dtoProduto.Quantidade = int.Parse(txtQuantidade.Text);
                dtoProduto.Preco = double.Parse(txtPreco.Text);
                dtoProduto.Tbl_categoria_id = int.Parse(comboCategoria.SelectedValue.ToString());
                dtoProduto.Tbl_fornecedor_id = int.Parse(comboFornecedor.SelectedValue.ToString());
                //
                bllProduto.AlterarProduto(dtoProduto);
                MessageBox.Show("Alteraçãp Realizada com Sucesso. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GridProdutos.DataSource = bllProduto.PesquisarProdutos();
                new LimpaForm(this);
                btnExcluir.Enabled = false;
                btnEditar.Enabled = false;
                btnNovo.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
