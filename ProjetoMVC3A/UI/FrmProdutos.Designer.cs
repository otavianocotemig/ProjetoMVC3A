namespace ProjetoMVC3A.UI
{
    partial class FrmProdutos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPesquisarProdutos = new System.Windows.Forms.Button();
            this.txtPesquisarProdutos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnsair = new System.Windows.Forms.Button();
            this.GridProdutos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisarProdutos
            // 
            this.btnPesquisarProdutos.Location = new System.Drawing.Point(546, 97);
            this.btnPesquisarProdutos.Name = "btnPesquisarProdutos";
            this.btnPesquisarProdutos.Size = new System.Drawing.Size(114, 23);
            this.btnPesquisarProdutos.TabIndex = 52;
            this.btnPesquisarProdutos.Text = "Pesquisar";
            this.btnPesquisarProdutos.UseVisualStyleBackColor = true;
            this.btnPesquisarProdutos.Click += new System.EventHandler(this.btnPesquisarProdutos_Click);
            // 
            // txtPesquisarProdutos
            // 
            this.txtPesquisarProdutos.Location = new System.Drawing.Point(227, 100);
            this.txtPesquisarProdutos.Name = "txtPesquisarProdutos";
            this.txtPesquisarProdutos.Size = new System.Drawing.Size(312, 20);
            this.txtPesquisarProdutos.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Pesquisar Produtos";
            // 
            // btnsair
            // 
            this.btnsair.Location = new System.Drawing.Point(666, 98);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(88, 23);
            this.btnsair.TabIndex = 49;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = true;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // GridProdutos
            // 
            this.GridProdutos.AllowUserToAddRows = false;
            this.GridProdutos.AllowUserToDeleteRows = false;
            this.GridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridProdutos.Location = new System.Drawing.Point(22, 126);
            this.GridProdutos.Name = "GridProdutos";
            this.GridProdutos.ReadOnly = true;
            this.GridProdutos.Size = new System.Drawing.Size(732, 198);
            this.GridProdutos.TabIndex = 48;
            // 
            // FrmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPesquisarProdutos);
            this.Controls.Add(this.txtPesquisarProdutos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.GridProdutos);
            this.Name = "FrmProdutos";
            this.Text = "Manutenção de Produtos";
            this.Load += new System.EventHandler(this.FrmProdutos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisarProdutos;
        private System.Windows.Forms.TextBox txtPesquisarProdutos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.DataGridView GridProdutos;
    }
}