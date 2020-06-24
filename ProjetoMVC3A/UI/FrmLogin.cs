using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoMVC3A.BLL;
using ProjetoMVC3A.DAL;
using ProjetoMVC3A.DTO;

namespace ProjetoMVC3A.UI
{
    public partial class FrmLogin : Form
    {
      
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
                    MessageBox.Show("Seja bemvindo ","Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cliente não Localizado", "Falhou!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }catch (Exception ex)
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
