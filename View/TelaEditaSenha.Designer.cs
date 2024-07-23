namespace Trabalho3_carteira.View
{
    partial class TelaEditaSenha
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
            btn_salvar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lbl_confsen = new TextBox();
            lbl_SenAtual = new TextBox();
            lbl_NovaSen = new TextBox();
            btn_cancelar = new Button();
            Botãovis1 = new Button();
            Botãovis2 = new Button();
            Botãovis3 = new Button();
            SuspendLayout();
            // 
            // btn_salvar
            // 
            btn_salvar.Location = new Point(159, 197);
            btn_salvar.Margin = new Padding(3, 4, 3, 4);
            btn_salvar.Name = "btn_salvar";
            btn_salvar.Size = new Size(86, 31);
            btn_salvar.TabIndex = 0;
            btn_salvar.Text = "Salvar";
            btn_salvar.UseVisualStyleBackColor = true;
            btn_salvar.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 1;
            label1.Text = "Senha Atual:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 73);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 2;
            label2.Text = "Nova Senha:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 135);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 3;
            label3.Text = "Confirme a senha:";
            // 
            // lbl_confsen
            // 
            lbl_confsen.Location = new Point(130, 131);
            lbl_confsen.Margin = new Padding(3, 4, 3, 4);
            lbl_confsen.Name = "lbl_confsen";
            lbl_confsen.Size = new Size(114, 27);
            lbl_confsen.TabIndex = 4;
            lbl_confsen.UseSystemPasswordChar = true;
            // 
            // lbl_SenAtual
            // 
            lbl_SenAtual.Location = new Point(130, 8);
            lbl_SenAtual.Margin = new Padding(3, 4, 3, 4);
            lbl_SenAtual.Name = "lbl_SenAtual";
            lbl_SenAtual.Size = new Size(114, 27);
            lbl_SenAtual.TabIndex = 5;
            lbl_SenAtual.UseSystemPasswordChar = true;
            // 
            // lbl_NovaSen
            // 
            lbl_NovaSen.Location = new Point(130, 69);
            lbl_NovaSen.Margin = new Padding(3, 4, 3, 4);
            lbl_NovaSen.Name = "lbl_NovaSen";
            lbl_NovaSen.Size = new Size(114, 27);
            lbl_NovaSen.TabIndex = 6;
            lbl_NovaSen.UseSystemPasswordChar = true;
            // 
            // btn_cancelar
            // 
            btn_cancelar.Location = new Point(46, 197);
            btn_cancelar.Margin = new Padding(3, 4, 3, 4);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(86, 31);
            btn_cancelar.TabIndex = 7;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = true;
            btn_cancelar.Click += button2_Click;
            // 
            // Botãovis1
            // 
            Botãovis1.Location = new Point(251, 7);
            Botãovis1.Margin = new Padding(3, 4, 3, 4);
            Botãovis1.Name = "Botãovis1";
            Botãovis1.Size = new Size(40, 31);
            Botãovis1.TabIndex = 8;
            Botãovis1.Text = "👁️‍🗨️";
            Botãovis1.UseVisualStyleBackColor = true;
            Botãovis1.Click += button3_Click;
            // 
            // Botãovis2
            // 
            Botãovis2.Location = new Point(251, 68);
            Botãovis2.Margin = new Padding(3, 4, 3, 4);
            Botãovis2.Name = "Botãovis2";
            Botãovis2.Size = new Size(40, 31);
            Botãovis2.TabIndex = 9;
            Botãovis2.Text = "👁️‍🗨️";
            Botãovis2.UseVisualStyleBackColor = true;
            Botãovis2.Click += button4_Click;
            // 
            // Botãovis3
            // 
            Botãovis3.Location = new Point(251, 135);
            Botãovis3.Margin = new Padding(3, 4, 3, 4);
            Botãovis3.Name = "Botãovis3";
            Botãovis3.Size = new Size(40, 31);
            Botãovis3.TabIndex = 10;
            Botãovis3.Text = "👁️‍🗨️";
            Botãovis3.UseVisualStyleBackColor = true;
            Botãovis3.Click += button5_Click;
            // 
            // TelaEditaSenha
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 255);
            Controls.Add(Botãovis3);
            Controls.Add(Botãovis2);
            Controls.Add(Botãovis1);
            Controls.Add(btn_cancelar);
            Controls.Add(lbl_NovaSen);
            Controls.Add(lbl_SenAtual);
            Controls.Add(lbl_confsen);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_salvar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "TelaEditaSenha";
            Text = "Altere sua senha:";
            Load += TelaEditaSenha_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_salvar;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox lbl_confsen;
        private TextBox lbl_SenAtual;
        private TextBox lbl_NovaSen;
        private Button btn_cancelar;
        private Button Botãovis1;
        private Button Botãovis2;
        private Button Botãovis3;
    }
}