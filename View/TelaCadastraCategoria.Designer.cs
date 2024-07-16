namespace Trabalho3_carteira.View
{
    partial class TelaCadastraCategoria
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
            lblID = new Label();
            lblCategoria = new Label();
            txtID = new TextBox();
            txtCategoria = new TextBox();
            lblCadastro = new Button();
            SuspendLayout();
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(253, 112);
            lblID.Name = "lblID";
            lblID.Size = new Size(75, 25);
            lblID.TabIndex = 0;
            lblID.Text = "Código:";
            lblID.Click += label1_Click;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(236, 183);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(92, 25);
            lblCategoria.TabIndex = 1;
            lblCategoria.Text = "Categoria:";
            // 
            // txtID
            // 
            txtID.Location = new Point(334, 106);
            txtID.Name = "txtID";
            txtID.Size = new Size(150, 31);
            txtID.TabIndex = 2;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(334, 180);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(150, 31);
            txtCategoria.TabIndex = 3;
            // 
            // lblCadastro
            // 
            lblCadastro.Location = new Point(349, 296);
            lblCadastro.Name = "lblCadastro";
            lblCadastro.Size = new Size(112, 34);
            lblCadastro.TabIndex = 4;
            lblCadastro.Text = "Cadastrar";
            lblCadastro.UseVisualStyleBackColor = true;
            lblCadastro.Click += lblCadastro_Click;
            // 
            // TelaCadastraCategoria
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCadastro);
            Controls.Add(txtCategoria);
            Controls.Add(txtID);
            Controls.Add(lblCategoria);
            Controls.Add(lblID);
            Name = "TelaCadastraCategoria";
            Text = "TelaCadastraCategoria";
            Load += TelaCadastraCategoria_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblID;
        private Label lblCategoria;
        private TextBox txtID;
        private TextBox txtCategoria;
        private Button lblCadastro;
    }
}