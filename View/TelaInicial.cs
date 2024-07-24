using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using Trabalho3_carteira.Controller;
using Trabalho3_carteira.Model;


namespace Trabalho3_carteira.View
{
    public partial class TelaInicial : Form
    {
        
        public TelaInicial()
        {
            InitializeComponent();
            this.Visible = true;
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBox3;
        }


        static string ComputeSha256Hash(string? rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
              
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }

        }

        static int conf(string? sen, string? con)
        {
            bool bEqual = false;
            if (con.Length == sen.Length)
            {
                int i = 0;
                while ((i < con.Length) && (con[i] == sen[i]))
                {
                    i += 1;
                }
                if (i == con.Length)
                {
                    bEqual = true;
                }
            }

            if (bEqual)
            {
                MessageBox.Show("Cadastro criado!");
                return 1;


            }
            else
                MessageBox.Show("As senhas não conferem!");
            return 0;
        }



        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.UseSystemPasswordChar == false)
            {
                textBox2.UseSystemPasswordChar = true;
            }
            else if (textBox2.UseSystemPasswordChar == true)
            {
                textBox2.UseSystemPasswordChar = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.UseSystemPasswordChar == false)
            {
                textBox1.UseSystemPasswordChar = true;
            }
            else if (textBox1.UseSystemPasswordChar == true)
            {
                textBox1.UseSystemPasswordChar = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox1.Text) == true)
            {
                MessageBox.Show("A Senha não deve ser nula");
            }
            else if (string.IsNullOrEmpty(textBox2.Text) == true)
            {
                MessageBox.Show("A Senha não deve ser nula");
            }
            else if (string.IsNullOrEmpty(textBox3.Text) == true)
            {

                MessageBox.Show("Insira um nome");

            }
            else
            {

                string senha = ComputeSha256Hash(textBox1.Text);
                string teste = ComputeSha256Hash(textBox2.Text);
                string nome = (textBox3.Text);

                Carteira usercarteira = new Carteira();
                usercarteira.Nome = nome;
                usercarteira.Senha = senha;

                if (conf(senha, teste) == 1)
                {

                    CarteiraController.Salvar(usercarteira);
                    this.Visible = false;
                    TelaSenha t = new TelaSenha();
                    t.ShowDialog();
                    if (t.IsDisposed) { 
                    Close();
                    }
                }


            }


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
