using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho3_carteira.Controller;
using Trabalho3_carteira.Model;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Trabalho3_carteira.View
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {


            InitializeComponent();




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtpData_ValueChanged(object sender, EventArgs e)
        {
            atualiza_dtg();

        }

        private void TelaPrincipal_Load(object sender, EventArgs e)
        {

            atualiza_dtg();

            dtpData.MaxDate = DateTime.Today;
            dtpData.Value = DateTime.Today;

        }

        private void datagMovimentacoes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar.Visible = true;
            bntExcluir.Visible = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Movimentacoes selecionada = (Movimentacoes)datagMovimentacoes.SelectedRows[0].DataBoundItem;
            new TelaEditar(selecionada).ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            new TelaMovimentacao().Show();
            this.Close();
            atualiza_dtg();

        }

        public void atualiza_dtg()
        {
            DateTime data = dtpData.Value.Date;
            datagMovimentacoes.DataSource = MovimentacoesController.Mostra_Movimentacoes(data);

            lblSaldo.Text = MovimentacoesController.Mostra_Saldo_Total().ToString();
            lblSaldoDia.Text = MovimentacoesController.Mostra_Saldo_Dia(data).ToString();
        }

        private void alterarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TelaEditaSenha telaedsenha = new TelaEditaSenha();
            telaedsenha.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja Excluir?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (resultado == DialogResult.Yes)
            {

                Movimentacoes Excluir = (Movimentacoes)datagMovimentacoes.SelectedRows[0].DataBoundItem;
                MovimentacoesController.Excluir(Excluir);
                atualiza_dtg();
            }

        }

        private void TelaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }
    }
}
