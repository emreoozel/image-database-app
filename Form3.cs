using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proje
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-433LF0G\\SQLEXPRESS;Initial Catalog = Resimler; Integrated Security = True;");

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) && string.IsNullOrWhiteSpace(textBox2.Text)) {
                MessageBox.Show("Lütfen bilgilerinizi girin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Lütfen kullanıcı adınızı girin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Lütfen şifrenizi girin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                SqlCommand bilgiler = new SqlCommand("SELECT * FROM Kullanıcılar WHERE Kullanıcı_Adı = @kullaniciAdi and Kullanıcı_Sifresi = @kullaniciSifresi", baglanti);
                bilgiler.Parameters.AddWithValue("@kullaniciAdi", textBox1.Text);
                bilgiler.Parameters.AddWithValue("@kullaniciSifresi", textBox2.Text);
                baglanti.Open();
                SqlDataReader reader = bilgiler.ExecuteReader();
                if (reader.Read())
                {
                    var form = new Form1();
                    form.WindowState = FormWindowState.Normal;
                    form.SetDesktopLocation(280, 200);
                    this.Hide();
                    form.Closed += (s, args) => this.Close();
                    form.Show();
                } else {
                    MessageBox.Show("Hatalı giriş!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                baglanti.Close();   
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!textBox2.Text.All(char.IsDigit))
            {
                MessageBox.Show("Şifre sadece rakam içerebilir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                for (int i = 0; i < textBox2.Text.Length; i++)
                {
                    string karakter = textBox2.Text.Substring(i, 1);
                    if (!karakter.All(char.IsDigit))
                    {
                        textBox2.Text = textBox2.Text.Remove(i, 1);
                        string text = textBox2.Text;
                        textBox2.Clear();
                        textBox2.SelectedText = text;
                    }
                }
            }
        }

    }
}
