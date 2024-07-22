namespace Trabalho3_carteira.View
{
    partial class TelaInicial
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(226, 127);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(39, 22);
            button3.TabIndex = 13;
            button3.Text = "👁️‍🗨️";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(226, 78);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(39, 22);
            button2.TabIndex = 12;
            button2.Text = "👁️‍🗨️";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(183, 153);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 11;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.KeyPress += button1_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(10, 128);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(210, 23);
            textBox2.TabIndex = 10;
            textBox2.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 110);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 9;
            label2.Text = "Confirme a senha:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(10, 80);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(210, 23);
            textBox1.TabIndex = 8;
            textBox1.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 62);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 7;
            label1.Text = "Digite sua senha:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 7);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 14;
            label3.Text = "Insira seu nome:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 28);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(209, 23);
            textBox3.TabIndex = 15;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // TelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(273, 210);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "TelaInicial";
            Text = "Defina seu nome e senha:";
            Load += TelaInicial_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Label label3;
        private TextBox textBox3;
    }
}