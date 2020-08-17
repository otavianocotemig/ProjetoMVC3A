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
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            try
            {
                dtoCliente.Email_cliente = txtEmail.Text.ToString();
                dtoCliente.Nome_cliente = txtNome.Text.ToString();
                dtoCliente.Sobrenome_cliente = txtSobrenome.Text.ToString();
                dtoCliente.Senha_cliente = txtSenha.Text.ToString();
                dtoCliente.Cpf_cliente = txtCpf.Text.ToString();
                //dtoCliente.Tp_usuario = int.Parse(cmbTipoUsuario.SelectedValue.ToString());

                bllCliente.InserirCliente(dtoCliente);
                MessageBox.Show("Inserção Realizada com Sucesso. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GridClientes.DataSource = bllCliente.ListarClientes();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
