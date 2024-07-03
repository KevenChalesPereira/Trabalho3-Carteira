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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtValor = new TextBox();
            comboBox2 = new ComboBox();
            txtDesc = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            panel1 = new Panel();
            btnSalvar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 30);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Valor : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 167);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 1;
            label2.Text = "Descrição :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 63);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 2;
            label3.Text = "Tipo ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 96);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 3;
            label4.Text = "Categoria";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(69, 27);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(264, 23);
            txtValor.TabIndex = 4;
            // 
            // comboBox2
            // 
            comboBox2.DisplayMember = "Nome";
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(69, 93);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(264, 23);
            comboBox2.TabIndex = 6;
            comboBox2.ValueMember = "Id";
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(69, 159);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(264, 105);
            txtDesc.TabIndex = 7;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(3, 5);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(57, 19);
            radioButton1.TabIndex = 8;
            radioButton1.TabStop = true;
            radioButton1.Text = "Saque";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(66, 5);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(72, 19);
            radioButton2.TabIndex = 9;
            radioButton2.TabStop = true;
            radioButton2.Text = "Depósito";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButton1);
            panel1.Controls.Add(radioButton2);
            panel1.Location = new Point(69, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(137, 23);
            panel1.TabIndex = 10;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(135, 304);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 32);
            btnSalvar.TabIndex = 11;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // TelaEditar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 450);
            Controls.Add(btnSalvar);
            Controls.Add(panel1);
            Controls.Add(txtDesc);
            Controls.Add(comboBox2);
            Controls.Add(txtValor);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TelaEditar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar";
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
        private ComboBox comboBox2;
        private TextBox txtDesc;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Panel panel1;
        private Button btnSalvar;
    }
}