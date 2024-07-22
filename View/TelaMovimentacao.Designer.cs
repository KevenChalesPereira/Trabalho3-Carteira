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
            bntDeposito.Location = new Point(11, 183);
            bntDeposito.Margin = new Padding(2, 2, 2, 2);
            bntDeposito.Name = "bntDeposito";
            bntDeposito.Size = new Size(78, 20);
            bntDeposito.TabIndex = 0;
            bntDeposito.Text = "Deposito";
            bntDeposito.UseVisualStyleBackColor = true;
            bntDeposito.Click += bntDeposito_Click;
            // 
            // bntRetirada
            // 
            bntRetirada.Location = new Point(97, 183);
            bntRetirada.Margin = new Padding(2, 2, 2, 2);
            bntRetirada.Name = "bntRetirada";
            bntRetirada.Size = new Size(78, 20);
            bntRetirada.TabIndex = 1;
            bntRetirada.Text = "Retirada";
            bntRetirada.UseVisualStyleBackColor = true;
            bntRetirada.Click += bntRetirada_Click;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(22, 24);
            lblValor.Margin = new Padding(2, 0, 2, 0);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(36, 15);
            lblValor.TabIndex = 2;
            lblValor.Text = "Valor:";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(22, 62);
            lblCategoria.Margin = new Padding(2, 0, 2, 0);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(61, 15);
            lblCategoria.TabIndex = 3;
            lblCategoria.Text = "Categoria:";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(22, 100);
            lblDescricao.Margin = new Padding(2, 0, 2, 0);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(58, 15);
            lblDescricao.TabIndex = 4;
            lblDescricao.Text = "Descrição";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(97, 24);
            txtValor.Margin = new Padding(2, 2, 2, 2);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(129, 23);
            txtValor.TabIndex = 5;
            // 
            // cbCategoria
            // 
            cbCategoria.DisplayMember = "Nome";
            cbCategoria.FormattingEnabled = true;
            cbCategoria.Location = new Point(97, 62);
            cbCategoria.Margin = new Padding(2, 2, 2, 2);
            cbCategoria.Name = "cbCategoria";
            cbCategoria.Size = new Size(129, 23);
            cbCategoria.TabIndex = 6;
            cbCategoria.ValueMember = "Id";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(97, 98);
            txtDescricao.Margin = new Padding(2, 2, 2, 2);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(129, 23);
            txtDescricao.TabIndex = 7;
            // 
            // bntCadastraCategoria
            // 
            bntCadastraCategoria.Location = new Point(179, 164);
            bntCadastraCategoria.Margin = new Padding(2, 2, 2, 2);
            bntCadastraCategoria.Name = "bntCadastraCategoria";
            bntCadastraCategoria.Size = new Size(78, 42);
            bntCadastraCategoria.TabIndex = 8;
            bntCadastraCategoria.Text = "Cadastrar Categoria";
            bntCadastraCategoria.UseVisualStyleBackColor = true;
            bntCadastraCategoria.Click += bntCadastraCategoria_Click;
            // 
            // lblCalendario
            // 
            lblCalendario.AutoSize = true;
            lblCalendario.Location = new Point(22, 142);
            lblCalendario.Margin = new Padding(2, 0, 2, 0);
            lblCalendario.Name = "lblCalendario";
            lblCalendario.Size = new Size(133, 15);
            lblCalendario.TabIndex = 10;
            lblCalendario.Text = "Data da movimentação:";
            // 
            // dtpData
            // 
            dtpData.Format = DateTimePickerFormat.Short;
            dtpData.Location = new Point(160, 136);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(92, 23);
            dtpData.TabIndex = 11;
            // 
            // TelaMovimentacao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(267, 226);
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
            Margin = new Padding(2, 2, 2, 2);
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