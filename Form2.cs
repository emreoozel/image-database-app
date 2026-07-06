using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proje
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-433LF0G\\SQLEXPRESS;Initial Catalog = Resimler; Integrated Security = True;");
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'resimlerDataSet.Resimler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.resimlerTableAdapter.Fill(this.resimlerDataSet.Resimler);

        }

        int secilen = -1;
        string seciliKutucuk;

        private void label2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(resimAdiLbl.Text))
            {
                MessageBox.Show("Resim seçili değil", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                textBox1.Text = resimAdiLbl.Text;
                seciliKutucuk = "Resim_Adi";
            }
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.BackColor = Color.LightGray;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = Color.Transparent;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(resimSahibiLbl.Text) && secilen == -1)
            {
                MessageBox.Show("Resim seçili değil", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                textBox1.Text = resimSahibiLbl.Text;
                seciliKutucuk = "Resim_Sahibi";
            }
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label5.BackColor = Color.LightGray;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.BackColor = Color.Transparent;
        }

        private void SilBtn_Click(object sender, EventArgs e)
        {

            if (secilen == -1) {
                MessageBox.Show("Silmek istediğiniz resmin üstüne tıklayın", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                var result = MessageBox.Show("Bu resim veri tabanından silinecek. Bu resim silinsin mi?", "Dikkat!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    SqlCommand sil = new SqlCommand("Delete from Resimler Where Resim_ID = @p1", baglanti);
                    sil.Parameters.AddWithValue("@p1", dataGridView1.Rows[secilen].Cells[0].Value.ToString());
                   
                    baglanti.Open();
                    sil.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Silme işlemi başarılı.");
                    tabloyuYenile();
                    secilen = -1;
                    resimIdLbl.Text = "";
                    resimAdiLbl.Text = "";
                    resimBoyutuLbl.Text = "";
                    resimSahibiLbl.Text = "";
                    resimTuruLbl.Text = "";
                    resimTarihiLbl.Text = "";
                    resimEklenmeTarihiLbl.Text = "";
                }
            }
        }

        private void yenileBtn_Click(object sender, EventArgs e)
        {
            tabloyuYenile();
        }

        private void tabloyuYenile()
        {
            string query = "SELECT * FROM Resimler";
            SqlDataAdapter resimlerTableAdapter = new SqlDataAdapter(query, baglanti);
            DataTable table = new DataTable();
            resimlerTableAdapter.Fill(table);

            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            secilen = dataGridView1.SelectedCells[0].RowIndex;

            resimIdLbl.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            resimAdiLbl.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            resimBoyutuLbl.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            resimSahibiLbl.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            resimTuruLbl.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            string[] resimTarihiArray = dataGridView1.Rows[secilen].Cells[5].Value.ToString().Split(' ');
            resimTarihiLbl.Text = resimTarihiArray[0];
            string[] resimEklenmeTarihiArray = dataGridView1.Rows[secilen].Cells[6].Value.ToString().Split(' ');
            resimEklenmeTarihiLbl.Text = resimEklenmeTarihiArray[0];
        }

        private void DegistirBtn_Click(object sender, EventArgs e)
        {
            if (secilen != -1 && seciliKutucuk != null)
            {
                SqlCommand update = new SqlCommand($"Update Resimler Set {seciliKutucuk} = @textBox Where Resim_ID = @seciliResimID", baglanti);
                update.Parameters.AddWithValue("@textBox", textBox1.Text);
                update.Parameters.AddWithValue("@seciliResimID", dataGridView1.Rows[secilen].Cells[0].Value);
                baglanti.Open();
                update.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Değiştirme yapıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tabloyuYenile();
            } else if (secilen == -1)
            {
                MessageBox.Show("Lütfen bir resim seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else if (secilen != -1)
            {
                MessageBox.Show("Lütfen bir sütun seçin", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) && secilen == -1)
            {
                MessageBox.Show("Lütfen bir resim seçin", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            if (string.IsNullOrWhiteSpace(textBox1.Text) && secilen != -1 && seciliKutucuk == "Resim_Sahibi")
            {
                MessageBox.Show("Resim sahibi sütunu seçili", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else if (string.IsNullOrWhiteSpace(textBox1.Text) && secilen != -1)
            {
                MessageBox.Show("Lütfen bir sütun seçin", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
