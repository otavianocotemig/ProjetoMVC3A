using ProjetoMVC3A.BLL;
using ProjetoMVC3A.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMVC3A.UI
{
    public partial class FrmAlterarSenha : Form
    {
        // Instanciando a BLL e DTO
        tblClienteBLL bllCliente = new tblClienteBLL();
        tblClienteDTO dtoCliente = new tblClienteDTO();
        
        public FrmAlterarSenha()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmAlterarSenha_Load(object sender, EventArgs e)
        {
            txtEmail.Text = FrmLogin.email_usuario_logado;
            // selecionar os dados do cliente logado
            DataTable DtResult = bllCliente.ListarClientes(FrmLogin.email_usuario_logado);
            txtCodigo.Text = DtResult.Rows[0]["id_cliente"].ToString();
            txtNome.Text = DtResult.Rows[0]["nome_cliente"].ToString();
            txtSobrenome.Text = DtResult.Rows[0]["sobrenome_cliente"].ToString();
            txtCpf.Text = DtResult.Rows[0]["cpf_cliente"].ToString();

        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            string Erro = "OK";
            // Consistencias de alteração
          
            if (txtSenhaAtual.Text.ToString() != bllCliente.RecuperarSenha(txtEmail.Text))
            {
                MessageBox.Show("Senha Atual não confere. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                Erro = "NOTOK";
            }
            // Verificar se as nova senha e repita nova são igual
            if (txtNovaSenha.Text.ToString() != txtRNovaSenha.Text.ToString())
            {
                MessageBox.Show("Nova senha não confere com a senha redigitada. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Erro = "NOTOK";
            }
            // Alteração da senha
            if (Erro == "OK")
            {
                dtoCliente.Email_cliente = txtEmail.Text.ToString();
                dtoCliente.Nome_cliente = txtNome.Text.ToString();
                dtoCliente.Sobrenome_cliente = txtSobrenome.Text.ToString();
                dtoCliente.Senha_cliente = txtNovaSenha.Text.ToString();
                dtoCliente.Cpf_cliente = txtCpf.Text.ToString();
                bllCliente.AlterarCliente(dtoCliente);
                MessageBox.Show("Alteração |Realizada com Sucesso. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
