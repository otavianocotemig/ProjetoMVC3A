using ProjetoMVC3A.BLL;
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
        }

        private void btnAlterarSenha_Click(object sender, EventArgs e)
        {
            string Erro = "OK";
            // Consistencias de alteração
            tblClienteBLL bllCliente = new tblClienteBLL();
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
                bllCliente.AlterarSenhaCliente(txtEmail.Text, txtNovaSenha.Text);
            }


        }
    }
}
