namespace Trabalho3_carteira.View
{
    partial class TelaSenha
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
            button1 = new Button();
            bntTelaMovimentacao = new Button();
            bntCriaSenha = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 23);
            button1.Name = "button1";
            button1.Size = new Size(112, 61);
            button1.TabIndex = 0;
            button1.Text = "Tela Principal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // bntTelaMovimentacao
            // 
            bntTelaMovimentacao.Location = new Point(130, 23);
            bntTelaMovimentacao.Name = "bntTelaMovimentacao";
            bntTelaMovimentacao.Size = new Size(156, 61);
            bntTelaMovimentacao.TabIndex = 1;
            bntTelaMovimentacao.Text = "Tela Cadastro Movimentações";
            bntTelaMovimentacao.UseVisualStyleBackColor = true;
            bntTelaMovimentacao.Click += bntTelaMovimentacao_Click;
            // 
            // bntCriaSenha
            // 
            bntCriaSenha.Location = new Point(292, 23);
            bntCriaSenha.Name = "bntCriaSenha";
            bntCriaSenha.Size = new Size(156, 61);
            bntCriaSenha.TabIndex = 2;
            bntCriaSenha.Text = "Tela Cadastro de senha";
            bntCriaSenha.UseVisualStyleBackColor = true;
            bntCriaSenha.Click += bntCriaSenha_Click;
            // 
            // TelaSenha
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bntCriaSenha);
            Controls.Add(bntTelaMovimentacao);
            Controls.Add(button1);
            Name = "TelaSenha";
            Text = "Form1";
            Load += TelaSenha_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button bntTelaMovimentacao;
        private Button bntCriaSenha;
    }
}