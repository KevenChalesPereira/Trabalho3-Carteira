namespace Trabalho3_carteira.View
{
    partial class TelaEditar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaEditar));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtValor = new TextBox();
            cbCategoriaEditar = new ComboBox();
            txtDesc = new TextBox();
            rdSaque = new RadioButton();
            rdDeposito = new RadioButton();
            panel1 = new Panel();
            btnSalvar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 50);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 0;
            label1.Text = "Valor : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 278);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 1;
            label2.Text = "Descrição :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 105);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(52, 25);
            label3.TabIndex = 2;
            label3.Text = "Tipo ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 160);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(88, 25);
            label4.TabIndex = 3;
            label4.Text = "Categoria";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(99, 45);
            txtValor.Margin = new Padding(4, 5, 4, 5);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(375, 31);
            txtValor.TabIndex = 4;
            // 
            // cbCategoriaEditar
            // 
            cbCategoriaEditar.DisplayMember = "Nome";
            cbCategoriaEditar.FormattingEnabled = true;
            cbCategoriaEditar.Location = new Point(99, 155);
            cbCategoriaEditar.Margin = new Padding(4, 5, 4, 5);
            cbCategoriaEditar.Name = "cbCategoriaEditar";
            cbCategoriaEditar.Size = new Size(375, 33);
            cbCategoriaEditar.TabIndex = 6;
            cbCategoriaEditar.ValueMember = "Id";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(99, 265);
            txtDesc.Margin = new Padding(4, 5, 4, 5);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(375, 172);
            txtDesc.TabIndex = 7;
            // 
            // rdSaque
            // 
            rdSaque.AutoSize = true;
            rdSaque.Location = new Point(4, 8);
            rdSaque.Margin = new Padding(4, 5, 4, 5);
            rdSaque.Name = "rdSaque";
            rdSaque.Size = new Size(86, 29);
            rdSaque.TabIndex = 8;
            rdSaque.TabStop = true;
            rdSaque.Text = "Saque";
            rdSaque.UseVisualStyleBackColor = true;
            // 
            // rdDeposito
            // 
            rdDeposito.AutoSize = true;
            rdDeposito.Location = new Point(94, 8);
            rdDeposito.Margin = new Padding(4, 5, 4, 5);
            rdDeposito.Name = "rdDeposito";
            rdDeposito.Size = new Size(110, 29);
            rdDeposito.TabIndex = 9;
            rdDeposito.TabStop = true;
            rdDeposito.Text = "Depósito";
            rdDeposito.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(rdSaque);
            panel1.Controls.Add(rdDeposito);
            panel1.Location = new Point(99, 105);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(196, 38);
            panel1.TabIndex = 10;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(193, 507);
            btnSalvar.Margin = new Padding(4, 5, 4, 5);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(107, 53);
            btnSalvar.TabIndex = 11;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // TelaEditar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 750);
            Controls.Add(btnSalvar);
            Controls.Add(panel1);
            Controls.Add(txtDesc);
            Controls.Add(cbCategoriaEditar);
            Controls.Add(txtValor);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "TelaEditar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar movimentação";
            FormClosing += TelaEditar_FormClosing;
            Load += TelaEditar_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtValor;
        private ComboBox cbCategoriaEditar;
        private TextBox txtDesc;
        private RadioButton rdSaque;
        private RadioButton rdDeposito;
        private Panel panel1;
        private Button btnSalvar;
    }
}