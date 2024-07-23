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
using System.Security.Cryptography;
using Trabalho3_carteira.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Trabalho3_carteira.View
{
    public partial class TelaEditaSenha : Form
    {
        public TelaEditaSenha()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lbl_SenAtual.Text) == true)
            {
                MessageBox.Show("Digite sua senha atual.");
            }
            else if (string.IsNullOrEmpty(lbl_NovaSen.Text) == true)
            {
                MessageBox.Show("Insira uma nova senha.");
            }
            else if (string.IsNullOrEmpty(lbl_confsen.Text) == true)
            {

                MessageBox.Show("Insira uma nova senha.");

            }
            else
            {
                List<Carteira> carteiralista = new List<Carteira>();
                carteiralista = CarteiraController.vercarteira();


                string ins = ComputeSha256Hash(lbl_SenAtual.Text);
                string senha = carteiralista[0].Senha;
                string nome = carteiralista[0].Nome;

                if (conf(senha, ins) == 1)
                {

                    string novsenha = ComputeSha256Hash(lbl_NovaSen.Text);
                    string csen = ComputeSha256Hash(lbl_confsen.Text);


                    if (conf(novsenha, csen) == 1)
                    {
                        Carteira usercarteira = new Carteira();
                        usercarteira.Senha = novsenha;
                        usercarteira.Nome = nome;

                        CarteiraController.Alterar(usercarteira);

                        MessageBox.Show("Senha alterada!");
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Senhas divergentes.");
                    }
                }
                else
                {
                    MessageBox.Show("Senha incorreta!");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lbl_SenAtual.UseSystemPasswordChar == false)
            {
                lbl_SenAtual.UseSystemPasswordChar = true;
            }
            else if (lbl_SenAtual.UseSystemPasswordChar == true)
            {
                lbl_SenAtual.UseSystemPasswordChar = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (lbl_NovaSen.UseSystemPasswordChar == false)
            {
                lbl_NovaSen.UseSystemPasswordChar = true;
            }
            else if (lbl_NovaSen.UseSystemPasswordChar == true)
            {
                lbl_NovaSen.UseSystemPasswordChar = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (lbl_confsen.UseSystemPasswordChar == false)
            {
                lbl_confsen.UseSystemPasswordChar = true;
            }
            else if (lbl_confsen.UseSystemPasswordChar == true)
            {
                lbl_confsen.UseSystemPasswordChar = false;
            }
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

                return 1;


            }
            else

                return 0;
        }

        private void TelaEditaSenha_Load(object sender, EventArgs e)
        {

        }
    }
}
