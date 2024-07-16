using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trabalho3_carteira.Data;
using Trabalho3_carteira.Model;

namespace Trabalho3_carteira.View
{
    public partial class TelaCadastraCategoria : Form
    {
        public TelaCadastraCategoria()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TelaCadastraCategoria_Load(object sender, EventArgs e)
        {
            DataContext db = new DataContext();
            var maxId = db.Categorias.Max(categoria => categoria.Id);
            var nextId = maxId + 1;
            txtID.Text = nextId.ToString();
            txtID.Enabled = false;
        }

        private void lblCadastro_Click(object sender, EventArgs e)
        {
            try
            {
                DataContext db = new DataContext();
                Categorias cad = new Categorias();
                cad.Nome = txtCategoria.Text;
                db.Categorias.Add(cad);
                db.SaveChanges();
            MessageBox.Show("Movimentação salva com sucesso.");
        }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar a categoria: {ex.Message}");
            }
}
    }
}
