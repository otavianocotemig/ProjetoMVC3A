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
    public partial class FrmCliente : Form
    {

        // Instanciando a BLL e DTO
        tblClienteBLL bllCliente = new tblClienteBLL();
        tblClienteDTO dtoCliente = new tblClienteDTO();
        tblTipousuarioBLL bllTipousuario = new tblTipousuarioBLL();

        public FrmCliente()
        {
            InitializeComponent();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            GridClientes.DataSource = bllCliente.ListarClientes();
            this.PreencheTipoUsuario();
          
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                // Passo os dados para o DTO
                dtoCliente.Email_cliente = txtEmail.Text.ToString();
                dtoCliente.Nome_cliente = txtNome.Text.ToString();
                dtoCliente.Sobrenome_cliente = txtSobrenome.Text.ToString();
                dtoCliente.Senha_cliente = txtSenha.Text.ToString();
                dtoCliente.Cpf_cliente = txtCpf.Text.ToString();
                dtoCliente.Tp_usuario = int.Parse(cmbTipoUsuario.SelectedValue.ToString());

       

                bllCliente.InserirCliente(dtoCliente);
                MessageBox.Show("Inserção Realizada com Sucesso. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GridClientes.DataSource = bllCliente.ListarClientes();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // Passo os dados para o DTO
            dtoCliente.Email_cliente = txtEmail.Text.ToString();
            dtoCliente.Nome_cliente = txtNome.Text.ToString();
            dtoCliente.Sobrenome_cliente = txtSobrenome.Text.ToString();
            dtoCliente.Senha_cliente = txtSenha.Text.ToString();
            dtoCliente.Cpf_cliente = txtCpf.Text.ToString();
            dtoCliente.Tp_usuario = int.Parse(cmbTipoUsuario.SelectedValue.ToString());

            bllCliente.AlterarCliente(dtoCliente);
            GridClientes.DataSource = bllCliente.ListarClientes();
        }

        private void GridClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = GridClientes.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = GridClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSobrenome.Text = GridClientes.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtEmail.Text = GridClientes.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtSenha.Text = GridClientes.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtCpf.Text = GridClientes.Rows[e.RowIndex].Cells[5].Value.ToString();
            cmbTipoUsuario.SelectedItem = GridClientes.Rows[e.RowIndex].Cells[6].Value.ToString();
            cmbTipoUsuario.Refresh();

            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Está ação irá deletar o registro selecionado e não poderá ser desfeito, deseja continuar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    dtoCliente.Id_cliente = Convert.ToInt32(txtCodigo.Text);
                    bllCliente.ExcluirCliente(dtoCliente);
                    GridClientes.DataSource = bllCliente.ListarClientes();
                }
                  
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisarClientes_Click(object sender, EventArgs e)
        {
            string condicao = "nome_cliente like '%" + txtPesquisarClientes.Text + "%'" +
                              "or sobrenome_cliente like '%" + txtPesquisarClientes.Text + "%'" +
                              "or email_cliente like '%"+ txtPesquisarClientes.Text+"%'";
            GridClientes.DataSource = bllCliente.PesquisarClientes(condicao);

        }

        // Metodo para Preencher tipo do usuario
        public void PreencheTipoUsuario()
        {
            cmbTipoUsuario.DataSource = bllTipousuario.ListarTipoUsuario();
            cmbTipoUsuario.DisplayMember = "descricao";
            cmbTipoUsuario.ValueMember = "id";
            
        }
    }
}

