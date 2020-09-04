﻿namespace ProjetoMVC3A.UI
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupDoBancoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençãoDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manutençãoDeFornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.email_usuario = new System.Windows.Forms.Label();
            this.manutençãoDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ferramentasToolStripMenuItem,
            this.administraçãoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(792, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ferramentasToolStripMenuItem
            // 
            this.ferramentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alterarSenhaToolStripMenuItem});
            this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            this.ferramentasToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.ferramentasToolStripMenuItem.Text = "Ferramentas";
            // 
            // alterarSenhaToolStripMenuItem
            // 
            this.alterarSenhaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("alterarSenhaToolStripMenuItem.Image")));
            this.alterarSenhaToolStripMenuItem.Name = "alterarSenhaToolStripMenuItem";
            this.alterarSenhaToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.alterarSenhaToolStripMenuItem.Text = "Meu Perfil";
            this.alterarSenhaToolStripMenuItem.Click += new System.EventHandler(this.alterarSenhaToolStripMenuItem_Click_1);
            // 
            // administraçãoToolStripMenuItem
            // 
            this.administraçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupDoBancoToolStripMenuItem,
            this.manutençãoDeClientesToolStripMenuItem,
            this.manutençãoDeFornecedoresToolStripMenuItem,
            this.manutençãoDeProdutosToolStripMenuItem});
            this.administraçãoToolStripMenuItem.Name = "administraçãoToolStripMenuItem";
            this.administraçãoToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.administraçãoToolStripMenuItem.Text = "Administração ";
            // 
            // setupDoBancoToolStripMenuItem
            // 
            this.setupDoBancoToolStripMenuItem.Name = "setupDoBancoToolStripMenuItem";
            this.setupDoBancoToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.setupDoBancoToolStripMenuItem.Text = "Setup do Banco";
            // 
            // manutençãoDeClientesToolStripMenuItem
            // 
            this.manutençãoDeClientesToolStripMenuItem.Name = "manutençãoDeClientesToolStripMenuItem";
            this.manutençãoDeClientesToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.manutençãoDeClientesToolStripMenuItem.Text = "Manutenção de Clientes";
            this.manutençãoDeClientesToolStripMenuItem.Click += new System.EventHandler(this.manutençãoDeClientesToolStripMenuItem_Click);
            // 
            // manutençãoDeFornecedoresToolStripMenuItem
            // 
            this.manutençãoDeFornecedoresToolStripMenuItem.Name = "manutençãoDeFornecedoresToolStripMenuItem";
            this.manutençãoDeFornecedoresToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.manutençãoDeFornecedoresToolStripMenuItem.Text = "Manutenção de Fornecedores";
            this.manutençãoDeFornecedoresToolStripMenuItem.Click += new System.EventHandler(this.manutençãoDeFornecedoresToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // email_usuario
            // 
            this.email_usuario.AutoSize = true;
            this.email_usuario.ForeColor = System.Drawing.Color.Yellow;
            this.email_usuario.Location = new System.Drawing.Point(598, 40);
            this.email_usuario.Name = "email_usuario";
            this.email_usuario.Size = new System.Drawing.Size(0, 13);
            this.email_usuario.TabIndex = 2;
            // 
            // manutençãoDeProdutosToolStripMenuItem
            // 
            this.manutençãoDeProdutosToolStripMenuItem.Name = "manutençãoDeProdutosToolStripMenuItem";
            this.manutençãoDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.manutençãoDeProdutosToolStripMenuItem.Text = "Manutenção de Produtos";
            this.manutençãoDeProdutosToolStripMenuItem.Click += new System.EventHandler(this.manutençãoDeProdutosToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 446);
            this.Controls.Add(this.email_usuario);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Formulário Principal - Menu Sistema";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarSenhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupDoBancoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Label email_usuario;
        private System.Windows.Forms.ToolStripMenuItem manutençãoDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manutençãoDeFornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manutençãoDeProdutosToolStripMenuItem;
    }
}