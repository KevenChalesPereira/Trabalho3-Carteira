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
    public partial class TelaSenha : Form
    {
        public TelaSenha()
        {
            InitializeComponent();
        }



        private void TelaSenha_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
            else
            {
                List<Carteira> carteiralista = new List<Carteira>();
                carteiralista = CarteiraController.vercarteira();


                string ins = ComputeSha256Hash(textBox1.Text);
                string senha = carteiralista[0].Senha;

                if (conf(senha, ins) == 1)
                {
                    this.Visible = false;
                    TelaPrincipal t = new TelaPrincipal();
                    t.ShowDialog();
                    if (t.IsDisposed)
                    {
                        Close();
                    }
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
                    MessageBox.Show("Senha incorreta!");
                return 0;
            }

        }

        private void TelaSenha_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dispose();
        }
    }
}

