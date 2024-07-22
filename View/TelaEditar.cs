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
                rdSaque.Select();
            }
            else
            {
                rdDeposito.Select();
            }

            cbCategoriaEditar.DataSource = CategoriaController.Busca_Cat();
            cbCategoriaEditar.SelectedValue = (int)edicao.Categoria;


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Movimentacoes movimentacoes = new Movimentacoes();

            movimentacoes.Id = edicao.Id;
            movimentacoes.Valor = double.Parse(txtValor.Text);
           

            if (rdDeposito.Checked){

                movimentacoes.Tipo = 0;
            }
            else { movimentacoes.Tipo = 1; }
        }
    }
}
