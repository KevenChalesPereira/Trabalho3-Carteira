using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho3_carteira.View
{
    public partial class TelaSenha : Form
    {
        public TelaSenha()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TelaPrincipal tela = new TelaPrincipal();
            tela.ShowDialog();
            this.Close();
        }

        private void TelaSenha_Load(object sender, EventArgs e)
        {

        }

        private void bntTelaMovimentacao_Click(object sender, EventArgs e)
        {
            TelaMovimentacao tela = new TelaMovimentacao();
            tela.ShowDialog();
            this.Close();
        }

        private void bntCriaSenha_Click(object sender, EventArgs e)
        {
            TelaInicial tela = new TelaInicial();
            tela.ShowDialog();
            this.Close();
        }
    }
}
