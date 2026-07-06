using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-433LF0G\\SQLEXPRESS;Initial Catalog = Resimler; Integrated Security = True;");
        string resimBoyut;
        object resimID;
        string resimTur;
        string resimTarih;

        private void tabloBtn_Click_1(object sender, EventArgs e)
        {
            var form = new Form2();
            if (Application.OpenForms[form.Name] == null)
            {
                form.Show();
                form.WindowState = FormWindowState.Normal;
                form.SetDesktopLocation(280, 200);
            }
            else
            {
                Application.OpenForms[form.Name].Focus();
                form.WindowState = FormWindowState.Normal;
            }
        }

        private void resimEkleBtn_Click_1(object sender, EventArgs e)
        {
            if (resimID != null)
            {
                if (!string.IsNullOrWhiteSpace(textBox2.Text))
                {

                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("insert into Resimler (Resim_ID, Resim_Adi, Resim_Sahibi, Resim_Boyutu, Resim_Türü, Resim_Tarihi) Values (@id, @ad, @sahip, @boyut, @tur, @tarih)", baglanti);
                    komut.Parameters.AddWithValue("@id", resimID);
                    komut.Parameters.AddWithValue("@ad", textBox2.Text);
                    komut.Parameters.AddWithValue("@sahip", textBox1.Text);
                    komut.Parameters.AddWithValue("@boyut", resimBoyut);
                    komut.Parameters.AddWithValue("@tur", resimTur);
                    komut.Parameters.AddWithValue("@tarih", resimTarih);
                    try
                    {
                        komut.ExecuteNonQuery();
                        MessageBox.Show("Kayıt Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resimID = null;
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Number == 2627)
                        {
                            MessageBox.Show("Bu isimde zaten bir resim var", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            resimID = null;
                        }
                        else
                        {
                            MessageBox.Show("Bilinmeyen bir hata oluştu!\n\nResim eklenemedi.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            resimID = null;
                        }
                    }

                    baglanti.Close();

                    textBox1.Clear();
                    textBox2.Clear();
                    resimIdLbl.Text = "";
                    resimYoluLbl.Text = "";
                    resimBoyutuLbl.Text = "";
                    resimTarihiLbl.Text = "";
                    pictureBox1.Image = new Bitmap("C:\\Users\\Emre Özel\\source\\repos\\Proje\\563d0201e4359c2e890569e254ea14790eb370b71d08b6de5052511cc0352313.jpg");
                } else {
                    MessageBox.Show("Lütfen bir isim girin", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } else {
                MessageBox.Show("Lütfen bir resim seçin", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void resimBoyutu(FileInfo file)
        {
            int count = 0;
            double boyut = file.Length;
            while (boyut / 1024 > 1)
            {
                boyut = boyut / 1024;
                count++;
            }
            if (count == 0)
            {
                resimBoyut = boyut + " Byte";
            }
            else if (count == 1)
            {
                resimBoyut = Convert.ToString(boyut).Substring(0, 4) + " KB";
                if (resimBoyut[resimBoyut.Length - 4] == ',')
                {
                    resimBoyut = Convert.ToString(boyut).Substring(0, 3) + " KB";
                }
            }
            else if (count == 2)
            {
                resimBoyut = Convert.ToString(boyut).Substring(0, 4) + " MB";
            }
        }

        private void resimSecBtn_Click_1(object sender, EventArgs e)
        {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Title = "Resim Seç";
                dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.webp;";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = new Bitmap(dlg.FileName);
                    textBox2.Text = dlg.SafeFileName;
                    resimYoluLbl.Text = dlg.FileName;
                    FileInfo fileInfo = new FileInfo(dlg.FileName);
                    resimBoyutu(fileInfo);
                    resimBoyutuLbl.Text = resimBoyut;
                    string dateInfo = Convert.ToString(File.GetCreationTime(dlg.FileName));
                    string[] dateInfoArray = dateInfo.Split(' ');
                    resimTarihiLbl.Text = dateInfoArray[0];
                    string[] resimTarihArray = dateInfoArray[0].Split('.');
                    resimTarih = String.Join("-", resimTarihArray);


                    SqlCommand count = new SqlCommand("Select MAX(Resim_ID) from Resimler", baglanti);
                    baglanti.Open();
                    resimID = count.ExecuteScalar();
                    baglanti.Close();
                    if (resimID is DBNull) {resimID = 0;}
                    resimID = Convert.ToInt32(resimID) + 1;
                    resimIdLbl.Text = Convert.ToString(resimID);


                    string[] resimTurArray = fileInfo.Name.Split('.');
                    resimTur = resimTurArray[resimTurArray.Length - 1];
            }
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (resimID == null)
            {
                MessageBox.Show("Lütfen bir resim seçin", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (resimID == null)
            {
                MessageBox.Show("Lütfen bir resim seçin", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
