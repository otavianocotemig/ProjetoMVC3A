﻿using ProjetoMVC3A.BLL;
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
            if ((bllCliente.VerificarTipoUsuario(FrmLogin.email_usuario_logado)) != 1){
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

        private void alterarSenhaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmAlterarSenha FrmAlterarSenha = new FrmAlterarSenha();
            FrmAlterarSenha.ShowDialog();
        }

        private void manutençãoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente FrmCliente = new FrmCliente();
            FrmCliente.ShowDialog();
        }

        private void manutençãoDeFornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFornecedor FrmFornecedor = new FrmFornecedor();
            FrmFornecedor.ShowDialog();
        }

        private void manutençãoDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProdutos FrmProdutos = new FrmProdutos();
            FrmProdutos.ShowDialog();
        }
    }
}
