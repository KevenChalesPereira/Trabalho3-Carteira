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
            movimentacoesBindingSource1 = new BindingSource(components);
            dtpData = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            lblSaldoDia = new Label();
            label5 = new Label();
            btnEditar = new Button();
            ((System.ComponentModel.ISupportInitialize)datagMovimentacoes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)movimentacoesBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)movimentacoesBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 55);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 0;
            label1.Text = "Saldo disponivel:";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Location = new Point(153, 55);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(27, 15);
            lblSaldo.TabIndex = 1;
            lblSaldo.Text = "----";
            // 
            // button1
            // 
            button1.ForeColor = Color.Red;
            button1.Location = new Point(12, 415);
            button1.Name = "button1";
            button1.Size = new Size(97, 23);
            button1.TabIndex = 2;
            button1.Text = "movimentação";
            button1.UseVisualStyleBackColor = true;
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
            datagMovimentacoes.Location = new Point(237, 55);
            datagMovimentacoes.MultiSelect = false;
            datagMovimentacoes.Name = "datagMovimentacoes";
            datagMovimentacoes.ReadOnly = true;
            datagMovimentacoes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            datagMovimentacoes.RowHeadersVisible = false;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new Font("High Tower Text", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            datagMovimentacoes.RowsDefaultCellStyle = dataGridViewCellStyle1;
            datagMovimentacoes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagMovimentacoes.Size = new Size(503, 150);
            
            datagMovimentacoes.CellClick += datagMovimentacoes_CellClick;
            datagMovimentacoes.CellContentClick += dataGridView1_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            dataDataGridViewTextBoxColumn.HeaderText = "Data";
            dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            tipoDataGridViewTextBoxColumn.ReadOnly = true;
            tipoDataGridViewTextBoxColumn.Visible = false;
            // 
            // Nome_Tipo
            // 
            Nome_Tipo.DataPropertyName = "Nome_Tipo";
            Nome_Tipo.HeaderText = "Tipo";
            Nome_Tipo.Name = "Nome_Tipo";
            Nome_Tipo.ReadOnly = true;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            valorDataGridViewTextBoxColumn.DataPropertyName = "Valor";
            valorDataGridViewTextBoxColumn.HeaderText = "Valor";
            valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            valorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            categoriaDataGridViewTextBoxColumn.ReadOnly = true;
            categoriaDataGridViewTextBoxColumn.Visible = false;
            // 
            // Nome_Categoria
            // 
            Nome_Categoria.DataPropertyName = "Nome_Categoria";
            Nome_Categoria.HeaderText = "Categoria";
            Nome_Categoria.Name = "Nome_Categoria";
            Nome_Categoria.ReadOnly = true;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // movimentacoesBindingSource
            // 
            movimentacoesBindingSource.DataSource = typeof(Model.Movimentacoes);
            // 
            // movimentacoesBindingSource1
            // 
            movimentacoesBindingSource1.DataSource = typeof(Model.Movimentacoes);
            // 
            // dtpData
            // 
            dtpData.Format = DateTimePickerFormat.Short;
            dtpData.Location = new Point(699, 12);
            dtpData.Margin = new Padding(8);
            dtpData.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(89, 23);
            dtpData.TabIndex = 4;
            dtpData.ValueChanged += dtpData_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(127, 55);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 5;
            label2.Text = "R$";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(127, 85);
            label3.Name = "label3";
            label3.Size = new Size(20, 15);
            label3.TabIndex = 8;
            label3.Text = "R$";
            // 
            // lblSaldoDia
            // 
            lblSaldoDia.AutoSize = true;
            lblSaldoDia.Location = new Point(153, 85);
            lblSaldoDia.Name = "lblSaldoDia";
            lblSaldoDia.Size = new Size(27, 15);
            lblSaldoDia.TabIndex = 7;
            lblSaldoDia.Text = "----";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 85);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 6;
            label5.Text = "Saldo do dia:";
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(665, 211);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 9;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Visible = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // TelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
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
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "TelaPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaPrincipal";
            Load += TelaPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)datagMovimentacoes).EndInit();
            ((System.ComponentModel.ISupportInitialize)movimentacoesBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)movimentacoesBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblSaldo;
        private Button button1;
        private DataGridView datagMovimentacoes;
        private BindingSource movimentacoesBindingSource1;
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
    }
}