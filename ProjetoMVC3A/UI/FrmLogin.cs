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
using ProjetoMVC3A.DAL;

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
            
           
        }
    }
}
