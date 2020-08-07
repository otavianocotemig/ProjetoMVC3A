using ProjetoMVC3A.BLL;
using ProjetoMVC3A.DTO;
using System;
using System.Windows.Forms;

namespace ProjetoMVC3A.UI
{
    public partial class FrmLogin : Form
    {
        // Armazena o email do usuario logado
        public static string email_usuario_logado;

        public FrmLogin()
        {
            InitializeComponent();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Instanciando o DTO do cliente para armazenar os dados da tela
                tblClienteDTO cliente = new tblClienteDTO();
                cliente.Email_cliente = txtEmail.Text.Trim();
                cliente.Senha_cliente = txtSenha.Text.Trim();
                // Instanciando a BLL para pesquisa do email e senha do cliente no banco
                tblClienteBLL bllCliente = new tblClienteBLL();
                if (bllCliente.Autenticar(cliente.Email_cliente, cliente.Senha_cliente))
                {
                    MessageBox.Show("Acesso Liberado. ", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Instanciando o novo formulário do sistema com acesso liberado
                    // Armazenando o valor na varial gloval estática para uso no sistema
                    email_usuario_logado = cliente.Email_cliente;
                    this.Hide();
             
                     FrmMain Frmprincipal = new FrmMain();
                     Frmprincipal.ShowDialog();
                   
                    
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Cliente não Localizado", "Falhou!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lblEsqueciSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tblClienteBLL bllCliente = new tblClienteBLL();
            string senha = bllCliente.RecuperarSenha(txtEmail.Text.Trim());
            MessageBox.Show(senha, "Falhou!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
