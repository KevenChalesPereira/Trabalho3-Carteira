namespace Trabalho3_carteira.View
{
    partial class TelaMovimentacao
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
            bntDeposito = new Button();
            bntRetirada = new Button();
            lblValor = new Label();
            lblCategoria = new Label();
            lblDescricao = new Label();
            txtValor = new TextBox();
            cbCategoria = new ComboBox();
            txtDescricao = new TextBox();
            bntCadastraCategoria = new Button();
            lblCalendario = new Label();
            dtpData = new DateTimePicker();
            SuspendLayout();
            // 
            // bntDeposito
            // 
            bntDeposito.Location = new Point(33, 390);
            bntDeposito.Name = "bntDeposito";
            bntDeposito.Size = new Size(111, 33);
            bntDeposito.TabIndex = 0;
            bntDeposito.Text = "Deposito";
            bntDeposito.UseVisualStyleBackColor = true;
            bntDeposito.Click += bntDeposito_Click;
            // 
            // bntRetirada
            // 
            bntRetirada.Location = new Point(163, 390);
            bntRetirada.Name = "bntRetirada";
            bntRetirada.Size = new Size(111, 33);
            bntRetirada.TabIndex = 1;
            bntRetirada.Text = "Retirada";
            bntRetirada.UseVisualStyleBackColor = true;
            bntRetirada.Click += bntRetirada_Click;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(31, 40);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(56, 25);
            lblValor.TabIndex = 2;
            lblValor.Text = "Valor:";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(31, 103);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(92, 25);
            lblCategoria.TabIndex = 3;
            lblCategoria.Text = "Categoria:";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(31, 167);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(88, 25);
            lblDescricao.TabIndex = 4;
            lblDescricao.Text = "Descrição";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(139, 40);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(183, 31);
            txtValor.TabIndex = 5;
            // 
            // cbCategoria
            // 
            cbCategoria.DisplayMember = "Nome";
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(139, 103);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(183, 33);
            cbCategoria.TabIndex = 6;
            cbCategoria.ValueMember = "Id";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(139, 163);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(183, 31);
            txtDescricao.TabIndex = 7;
            // 
            // bntCadastraCategoria
            // 
            bntCadastraCategoria.Location = new Point(299, 367);
            bntCadastraCategoria.Name = "bntCadastraCategoria";
            bntCadastraCategoria.Size = new Size(111, 70);
            bntCadastraCategoria.TabIndex = 8;
            bntCadastraCategoria.Text = "Cadastrar Categoria";
            bntCadastraCategoria.UseVisualStyleBackColor = true;
            bntCadastraCategoria.Click += bntCadastraCategoria_Click;
            // 
            // lblCalendario
            // 
            lblCalendario.AutoSize = true;
            lblCalendario.Location = new Point(31, 237);
            lblCalendario.Name = "lblCalendario";
            lblCalendario.Size = new Size(201, 25);
            lblCalendario.TabIndex = 10;
            lblCalendario.Text = "Data da movimentação:";
            // 
            // dtpData
            // 
            dtpData.Location = new Point(37, 290);
            dtpData.Margin = new Padding(4, 5, 4, 5);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(284, 31);
            dtpData.TabIndex = 11;
            // 
            // TelaMovimentacao
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 465);
            Controls.Add(dtpData);
            Controls.Add(lblCalendario);
            Controls.Add(bntCadastraCategoria);
            Controls.Add(txtDescricao);
            Controls.Add(cbCategoria);
            Controls.Add(txtValor);
            Controls.Add(lblDescricao);
            Controls.Add(lblCategoria);
            Controls.Add(lblValor);
            Controls.Add(bntRetirada);
            Controls.Add(bntDeposito);
            Name = "TelaMovimentacao";
            Text = "Movimentação";
            Load += TelaMovimentacao_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bntDeposito;
        private Button bntRetirada;
        private Label lblValor;
        private Label lblCategoria;
        private Label lblDescricao;
        private TextBox txtValor;
        private ComboBox cbCategoria;
        private TextBox txtDescricao;
        private Button bntCadastraCategoria;
        private Label lblCalendario;
        private DateTimePicker dtpData;
    }
}