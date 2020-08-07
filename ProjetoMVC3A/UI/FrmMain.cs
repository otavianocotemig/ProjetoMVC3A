using ProjetoMVC3A.BLL;
using ProjetoMVC3A.DTO;
using System;
using System.Windows.Forms;


namespace ProjetoMVC3A.UI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void lblSair_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Close();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // Verificando o Tipo do Usuário 1 = Normal 0 = Administrador
            tblClienteBLL bllCliente = new tblClienteBLL();
            email_usuario.Text = FrmLogin.email_usuario_logado;
            if ((bllCliente.VerificarTipoUsuario(FrmLogin.email_usuario_logado)) == 1){
                this.administraçãoToolStripMenuItem.Visible = false;

            }
        }

        private void alterarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
       
    }
}
