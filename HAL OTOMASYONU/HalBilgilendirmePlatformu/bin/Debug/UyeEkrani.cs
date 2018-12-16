using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HalBilgilendirmePlatformu
{
    public partial class UyeEkrani : Form
    {
        public UyeEkrani()
        {
            InitializeComponent();
        }

        private void UyeEkrani_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(Baglanti.baglanti);
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT id as 'Sıra Numarası', sehir as 'Şehir', meyve_sebze as 'Meyve & Sebze',birim as 'Birim Fiyatı',Endusukfiyat as 'En Düşük Fiyat',EnyuksekFiyat as 'En Düşük Fiyat',tarih as 'Tarih' FROM HalBilgilendirmeFormu", baglanti);
            SqlDataReader veriyukle = komut.ExecuteReader();
            DataTable tablo = new DataTable();
            tablo.Load(veriyukle);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        private void Cikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void uyeCıkıs_Click(object sender, EventArgs e)
        {
            HalAnaEkran hae = new HalAnaEkran();
            hae.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook workbook = excel.Workbooks.Add(System.Reflection.Missing.Value);
            Microsoft.Office.Interop.Excel.Worksheet sheet1 = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];

            int StartCol = 1, StartRow = 1;

            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {
                Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow, StartCol + j];
                myRange.Value2 = dataGridView1.Columns[j].HeaderText;
            }
            StartRow++;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    try
                    {
                        Microsoft.Office.Interop.Excel.Range myRange = (Microsoft.Office.Interop.Excel.Range)sheet1.Cells[StartRow + i, StartCol + j];
                        myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                    }
                    catch (Exception)
                    {
                        ;
                    }
                }
            }

        }

        private void Sara_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(Baglanti.baglanti); baglanti.Open();
            string srg = (textBox1.Text.ToString());

            string sorgu = "Select * from HalBilgilendirmeFormu where sehir like '%" + srg + "%'";
            SqlDataAdapter adap = new SqlDataAdapter(sorgu, baglanti);

            DataSet ds = new DataSet();

            adap.Fill(ds, "sehir");

            this.dataGridView1.DataSource = ds.Tables[0];

            baglanti.Close();
            textBox1.Clear();
        }

        private void msAra_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(Baglanti.baglanti); baglanti.Open();
            string srg = (textBox2.Text.ToString());

            string sorgu = "Select * from HalBilgilendirmeFormu where meyve_sebze like '%" + srg + "%'";
            SqlDataAdapter adap1 = new SqlDataAdapter(sorgu, baglanti);

            DataSet ds1 = new DataSet();

            adap1.Fill(ds1, "meyve_sebze");

            this.dataGridView1.DataSource = ds1.Tables[0];

            baglanti.Close();
            textBox2.Clear();
        }

        private void sEkle_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    //Sehir.Items.Add(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
            //    //MeyveSebze.Items.Add(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
            //    //EnDusukFiyat.Items.Add(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
            //    //EnYuksekFiyat.Items.Add(dataGridView1.SelectedRows[0].Cells[5].Value.ToString());
            //}
            //catch (Exception Ex)
            //{
            //    MessageBox.Show("Satırı seçerek listeye ekleyiniz.\n\n" + Ex);
            //}
            //{
            //    Double sonuc = 0;

            //    for (int i = 0; i < EnDusukFiyat.Items.Count; i++)
            //    {
            //        sonuc += Convert.ToDouble(EnDusukFiyat.Items[i]);
            //    }

            //    toplamDusuk.Text = sonuc.ToString();
            //}
            //{
            //    Double sonuc = 0;

            //    for (int i = 0; i < EnYuksekFiyat.Items.Count; i++)
            //    {
            //        sonuc += Convert.ToDouble(EnYuksekFiyat.Items[i]);
            //    }

            //    toplamYuksek.Text = sonuc.ToString();
            //}
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection baglanti = new SqlConnection(Baglanti.baglanti);
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
                string kayit = "insert into HalBilgilendirmeFormu(sehir,meyve_sebze,birim,Endusukfiyat,EnyuksekFiyat,tarih) values (@textBox3,@textBox4,@textBox7,@textBox5,@textBox6,@dateTimePicker1)";
                // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
                komut.Parameters.AddWithValue("@textBox3", textBox3.Text);
                komut.Parameters.AddWithValue("@textBox4", textBox4.Text);
                komut.Parameters.AddWithValue("@textBox7", textBox7.Text);
                komut.Parameters.AddWithValue("@textBox5", textBox5.Text);
                komut.Parameters.AddWithValue("@textBox6", textBox6.Text);
                komut.Parameters.AddWithValue("@dateTimePicker1", DateTime.Parse(dateTimePicker1.Value.ToString()));
                //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
                komut.ExecuteNonQuery();
                //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                komut.Dispose();
                DataSet ds = new DataSet();
                baglanti.Close();
                ds.Clear();
                listele();
                MessageBox.Show("Müşteri Kayıt İşlemi Gerçekleşti.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }
        void listele()
        {
            SqlConnection baglanti = new SqlConnection(Baglanti.baglanti); DataSet ds = new DataSet();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("Select * from HalBilgilendirmeFormu", baglanti);
            adtr.Fill(ds, "HalBilgilendirmeFormu");
            dataGridView1.DataSource = ds.Tables["HalBilgilendirmeFormu"];
            adtr.Dispose();
            baglanti.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {

            DialogResult c;
            c = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (c == DialogResult.Yes)
            {
                SqlConnection baglanti = new SqlConnection(Baglanti.baglanti); string kayit = "Delete from HalBilgilendirmeFormu where id=" + textBox9.Text + "";

                SqlCommand komut = new SqlCommand(kayit, baglanti);
                baglanti.Open();
                komut.Connection = baglanti;
                komut.ExecuteNonQuery();
                komut.Dispose();

                DataSet ds = new DataSet();
                baglanti.Close();
                ds.Clear(); 
                listele();

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-4M8UDE2\\SQLEXPRESS;Initial Catalog=Hal_Projesi;Integrated Security=True");
            baglanti.Open();
            //string sql = "";
            string sql = "update HalBilgilendirmeFormu set sehir='" + textBox3.Text + "', meyve_sebze='" + textBox4.Text + "', birim='" + textBox7.Text + "', Endusukfiyat='" + textBox5.Text + "', Enyuksekfiyat='" + textBox6.Text + "', tarih='" + DateTime.Parse(dateTimePicker1.Text).ToString("yyyy'/'MM'/'dd") + "' where id=" + textBox9.Text + ""; 
            SqlCommand com = new SqlCommand(sql, baglanti);
            com.ExecuteNonQuery();
            DataSet ds = new DataSet();
            baglanti.Close();
            ds.Clear();
            listele();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            textBox9.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}

