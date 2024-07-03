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

namespace Trabalho3_carteira.View
{
    public partial class TelaEditar : Form
    {
        Movimentacoes edicao = new Movimentacoes();
        public TelaEditar(Movimentacoes mov)
        {
            InitializeComponent();
            edicao = mov;
        }

        private void TelaEditar_Load(object sender, EventArgs e)
        {


            txtValor.Text = edicao.Valor.ToString();

            if (edicao.Descricao != null)
                txtDesc.Text = edicao.Descricao.ToString();

            if (edicao.Tipo == 1)
            {
                radioButton1.Select();
            }
            else
            {
                radioButton2.Select();
            }

            comboBox2.DataSource = CategoriaController.Busca_Cat();
            comboBox2.SelectedValue = (int)edicao.Categoria;


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }
    }
}
