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


namespace Trabalho3_carteira.View
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {

        }


        static string ComputeSha256Hash(string? rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }

        }

        static void conf(string? sen, string? con)
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
                MessageBox.Show("Senha correta!");
                //Console.WriteLine(sen);
                //Console.WriteLine(con);
            }
            else
                MessageBox.Show("Senha incorreta!");

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
            string senha = ComputeSha256Hash(textBox1.Text);
            string teste = ComputeSha256Hash(textBox2.Text);
            conf(senha, teste);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
