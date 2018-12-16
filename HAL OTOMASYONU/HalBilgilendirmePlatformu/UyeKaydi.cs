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
    public partial class uyeKaydi : Form
    {
        public uyeKaydi()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void uyeKaydi_Load(object sender, EventArgs e)
        {
            sifre.MaxLength = 8;
            sifre.PasswordChar = '*';
            sifre.TextAlign = HorizontalAlignment.Center;

            sifreTekrar.MaxLength = 8;
            sifreTekrar.PasswordChar = '*';
            sifreTekrar.TextAlign = HorizontalAlignment.Center;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(Baglanti.baglanti); try
            {
                if (sifre.Text == sifreTekrar.Text) 
                
                
                
                {
                    if (baglanti.State == ConnectionState.Closed)
                        baglanti.Open();
                    string kayit = "insert into UyeKaydi(KullaniciAdi,Sifre) values (@kullanici,@sifre)";
                    SqlCommand komut = new SqlCommand(kayit, baglanti);
                    komut.Parameters.AddWithValue("@kullanici", kullanici.Text);
                    komut.Parameters.AddWithValue("@sifre", sifre.Text);
                    //komut.Parameters.AddWithValue("@Bsehir", Bsehir.Text);
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kayıt İşlemi Gerçekleşti.");
                    UyeEkrani ue = new UyeEkrani();
                    ue.Show();
                    this.Hide();
                    MessageBox.Show("Hoş Geldiniz.");
                
                
                }
                else
                    MessageBox.Show("Sifreler uyusmuyor");
                sifre.Text = "";
                sifreTekrar.Text = "";

       

            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HalAnaEkran hae = new HalAnaEkran();
            hae.Show();
            this.Hide();
        }
    }
}
