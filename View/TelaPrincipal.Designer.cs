namespace Trabalho3_carteira.View
{
    partial class TelaPrincipal
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            label1 = new Label();
            lblSaldo = new Label();
            button1 = new Button();
            datagMovimentacoes = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dataDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tipoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Nome_Tipo = new DataGridViewTextBoxColumn();
            valorDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            categoriaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Nome_Categoria = new DataGridViewTextBoxColumn();
            descricaoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            movimentacoesBindingSource = new BindingSource(components);
            dtpData = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            lblSaldoDia = new Label();
            label5 = new Label();
            btnEditar = new Button();
            movimentacoesBindingSource1 = new BindingSource(components);
            menuStrip1 = new MenuStrip();
            alterarSenhaToolStripMenuItem = new ToolStripMenuItem();
            bntExcluir = new Button();
            ((System.ComponentModel.ISupportInitialize)datagMovimentacoes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)movimentacoesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)movimentacoesBindingSource1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 92);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(147, 25);
            label1.TabIndex = 0;
            label1.Text = "Saldo disponivel:";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Location = new Point(219, 92);
            lblSaldo.Margin = new Padding(4, 0, 4, 0);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(40, 25);
            lblSaldo.TabIndex = 1;
            lblSaldo.Text = "----";
            // 
            // button1
            // 
            button1.ForeColor = Color.Red;
            button1.Location = new Point(17, 692);
            button1.Margin = new Padding(4, 5, 4, 5);
            button1.Name = "button1";
            button1.Size = new Size(139, 38);
            button1.TabIndex = 2;
            button1.Text = "movimentação";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // datagMovimentacoes
            // 
            datagMovimentacoes.AllowUserToAddRows = false;
            datagMovimentacoes.AllowUserToDeleteRows = false;
            datagMovimentacoes.AllowUserToResizeColumns = false;
            datagMovimentacoes.AllowUserToResizeRows = false;
            datagMovimentacoes.AutoGenerateColumns = false;
            datagMovimentacoes.BackgroundColor = SystemColors.ControlLight;
            datagMovimentacoes.BorderStyle = BorderStyle.Fixed3D;
            datagMovimentacoes.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            datagMovimentacoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagMovimentacoes.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, dataDataGridViewTextBoxColumn, tipoDataGridViewTextBoxColumn, Nome_Tipo, valorDataGridViewTextBoxColumn, categoriaDataGridViewTextBoxColumn, Nome_Categoria, descricaoDataGridViewTextBoxColumn });
            datagMovimentacoes.DataSource = movimentacoesBindingSource;
            datagMovimentacoes.Location = new Point(339, 92);
            datagMovimentacoes.Margin = new Padding(4, 5, 4, 5);
            datagMovimentacoes.MultiSelect = false;
            datagMovimentacoes.Name = "datagMovimentacoes";
            datagMovimentacoes.ReadOnly = true;
            datagMovimentacoes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            datagMovimentacoes.RowHeadersVisible = false;
            datagMovimentacoes.RowHeadersWidth = 62;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            datagMovimentacoes.RowsDefaultCellStyle = dataGridViewCellStyle1;
            datagMovimentacoes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagMovimentacoes.Size = new Size(719, 250);
            datagMovimentacoes.TabIndex = 10;
            datagMovimentacoes.CellClick += datagMovimentacoes_CellClick;
            datagMovimentacoes.CellContentClick += dataGridView1_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 8;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Visible = false;
            idDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            dataDataGridViewTextBoxColumn.HeaderText = "Data";
            dataDataGridViewTextBoxColumn.MinimumWidth = 8;
            dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            dataDataGridViewTextBoxColumn.ReadOnly = true;
            dataDataGridViewTextBoxColumn.Width = 150;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            tipoDataGridViewTextBoxColumn.MinimumWidth = 8;
            tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            tipoDataGridViewTextBoxColumn.ReadOnly = true;
            tipoDataGridViewTextBoxColumn.Visible = false;
            tipoDataGridViewTextBoxColumn.Width = 150;
            // 
            // Nome_Tipo
            // 
            Nome_Tipo.DataPropertyName = "Nome_Tipo";
            Nome_Tipo.HeaderText = "Tipo";
            Nome_Tipo.MinimumWidth = 8;
            Nome_Tipo.Name = "Nome_Tipo";
            Nome_Tipo.ReadOnly = true;
            Nome_Tipo.Width = 150;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            valorDataGridViewTextBoxColumn.MinimumWidth = 8;
            valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            valorDataGridViewTextBoxColumn.ReadOnly = true;
            valorDataGridViewTextBoxColumn.Width = 150;
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            categoriaDataGridViewTextBoxColumn.MinimumWidth = 8;
            categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            categoriaDataGridViewTextBoxColumn.ReadOnly = true;
            categoriaDataGridViewTextBoxColumn.Visible = false;
            categoriaDataGridViewTextBoxColumn.Width = 150;
            // 
            // Nome_Categoria
            // 
            Nome_Categoria.DataPropertyName = "Nome_Categoria";
            Nome_Categoria.HeaderText = "Categoria";
            Nome_Categoria.MinimumWidth = 8;
            Nome_Categoria.Name = "Nome_Categoria";
            Nome_Categoria.ReadOnly = true;
            Nome_Categoria.Width = 150;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            descricaoDataGridViewTextBoxColumn.MinimumWidth = 8;
            descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            descricaoDataGridViewTextBoxColumn.Width = 150;
            // 
            // movimentacoesBindingSource
            // 
            movimentacoesBindingSource.DataSource = typeof(Model.Movimentacoes);
            // 
            // dtpData
            // 
            dtpData.Format = DateTimePickerFormat.Short;
            dtpData.Location = new Point(999, 20);
            dtpData.Margin = new Padding(11, 13, 11, 13);
            dtpData.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(125, 31);
            dtpData.TabIndex = 4;
            dtpData.ValueChanged += dtpData_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(181, 92);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(33, 25);
            label2.TabIndex = 5;
            label2.Text = "R$";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(181, 142);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(33, 25);
            label3.TabIndex = 8;
            label3.Text = "R$";
            // 
            // lblSaldoDia
            // 
            lblSaldoDia.AutoSize = true;
            lblSaldoDia.Location = new Point(219, 142);
            lblSaldoDia.Margin = new Padding(4, 0, 4, 0);
            lblSaldoDia.Name = "lblSaldoDia";
            lblSaldoDia.Size = new Size(40, 25);
            lblSaldoDia.TabIndex = 7;
            lblSaldoDia.Text = "----";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 142);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(117, 25);
            label5.TabIndex = 6;
            label5.Text = "Saldo do dia:";
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(950, 352);
            btnEditar.Margin = new Padding(4, 5, 4, 5);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(107, 38);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Visible = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // movimentacoesBindingSource1
            // 
            movimentacoesBindingSource1.DataSource = typeof(Model.Movimentacoes);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { alterarSenhaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(1143, 35);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // alterarSenhaToolStripMenuItem
            // 
            alterarSenhaToolStripMenuItem.Name = "alterarSenhaToolStripMenuItem";
            alterarSenhaToolStripMenuItem.Size = new Size(131, 29);
            alterarSenhaToolStripMenuItem.Text = "Alterar senha";
            alterarSenhaToolStripMenuItem.Click += alterarSenhaToolStripMenuItem_Click;
            // 
            // bntExcluir
            // 
            bntExcluir.Location = new Point(834, 352);
            bntExcluir.Margin = new Padding(4, 5, 4, 5);
            bntExcluir.Name = "bntExcluir";
            bntExcluir.Size = new Size(107, 38);
            bntExcluir.TabIndex = 12;
            bntExcluir.Text = "Excluir";
            bntExcluir.UseVisualStyleBackColor = true;
            bntExcluir.Visible = false;
            bntExcluir.Click += button2_Click;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1143, 750);
            Controls.Add(bntExcluir);
            Controls.Add(btnEditar);
            Controls.Add(label3);
            Controls.Add(lblSaldoDia);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(dtpData);
            Controls.Add(datagMovimentacoes);
            Controls.Add(button1);
            Controls.Add(lblSaldo);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "TelaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            FormClosing += TelaPrincipal_FormClosing;
            Load += TelaPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)datagMovimentacoes).EndInit();
            ((System.ComponentModel.ISupportInitialize)movimentacoesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)movimentacoesBindingSource1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblSaldo;
        private Button button1;
        private DataGridView datagMovimentacoes;
        private BindingSource movimentacoesBindingSource;
        private DateTimePicker dtpData;
        private Label label2;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Nome_Tipo;
        private DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Nome_Categoria;
        private DataGridViewTextBoxColumn saldodiaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private Label label3;
        private Label lblSaldoDia;
        private Label label5;
        private Button btnEditar;
        private BindingSource movimentacoesBindingSource1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem alterarSenhaToolStripMenuItem;
        private Button bntExcluir;
    }
}