﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho3_carteira.Controller;
using Trabalho3_carteira.Data;
using Trabalho3_carteira.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Trabalho3_carteira.View
{
    public partial class TelaMovimentacao : Form
    {
        public TelaMovimentacao()
        {
            InitializeComponent();
        }

        public void TelaMovimentacao_Load(object sender, EventArgs e)
        { //Preenche o Combo box
            
            cbCategoria.DataSource = CategoriaController.Busca_Cat();
           
        }
        private void bntDeposito_Click(object sender, EventArgs e)
        {
            try
            {

                DataContext db = new DataContext();
                Movimentacoes mov = new Movimentacoes();

               
                mov.Data = dtpData.Value.Date;
                mov.Tipo = 0;
                mov.Valor = double.Parse(txtValor.Text);
                mov.Categoria = 0; //cbCategoria.;
                mov.Descricao = txtDescricao.Text;
                //Nome_tipo e Nome_categoria, não podem ser inseridas, apenas leitura
                db.Movimentacoes.Add(mov);
                db.SaveChanges();
                MessageBox.Show("Movimentação salva com sucesso.");
                
                new TelaPrincipal().Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar movimentação: {ex.Message}");
            }

        }

        private void bntCadastraCategoria_Click(object sender, EventArgs e)
        {
            this.Close();
            TelaCadastraCategoria abrirform = new TelaCadastraCategoria();
            abrirform.ShowDialog(); 




        }

        private void bntRetirada_Click(object sender, EventArgs e)
        {
            try
            {

                DataContext db = new DataContext();
                Movimentacoes mov = new Movimentacoes();
                mov.Data = dtpData.Value.Date;
                mov.Tipo = 1;
                mov.Valor = double.Parse(txtValor.Text);
                mov.Categoria = 1;//(Int16)cbCategoria.SelectedValue;
                mov.Descricao = txtDescricao.Text;
                //Nome_tipo e Nome_categoria, não podem ser inseridas, apenas leitura
                db.Movimentacoes.Add(mov);
                db.SaveChanges();
                MessageBox.Show("Movimentação salva com sucesso.");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar movimentação: {ex.Message}");
            }
        }
    }

}

