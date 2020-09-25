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
    public partial class FrmCadCategoria : Form
    {
       tblCategoriaDTO categoriaDTO = new tblCategoriaDTO();
        tblCategoriaBLL categoriaBLL = new tblCategoriaBLL();


        public FrmCadCategoria()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                categoriaDTO.Descricao = txtDescricao.Text;
                //
               categoriaBLL.InserirCategoria(categoriaDTO);
                MessageBox.Show("Inserção Realizada com Sucesso. ", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
