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
using System.Data.OleDb;


namespace HalBilgilendirmePlatformu
{
    public partial class uyeGirisi : Form
    {
        public uyeGirisi()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // HalAnaEkran hae = new HalAnaEkran();
           // hae.Show();
            //this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox1.Text) ||
                String.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Giriş Başarısız! Eksiksiz Girdiniz!", "..:: HATA ::..",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
            {
                SqlConnection baglanti = new SqlConnection(Baglanti.baglanti);
                baglanti.Open();

                string sql = "SELECT * FROM UyeKaydi WHERE KullaniciAdi=@textBox1 and Sifre=@textBox2";
                SqlParameter prms1 = new SqlParameter("@textBox1", textBox1.Text);
                SqlParameter prms2 = new SqlParameter("@textBox2", textBox2.Text);

                SqlCommand cmd = new SqlCommand(sql, baglanti);
                cmd.Parameters.Add(prms1);
                cmd.Parameters.Add(prms2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    UyeEkrani ek = new UyeEkrani();
                    ek.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı veya Şifre YANLIŞ!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void uyeGirisi_Load(object sender, EventArgs e)
        {
            textBox2.MaxLength = 8;
            textBox2.PasswordChar = '*';
            textBox2.TextAlign = HorizontalAlignment.Center;
        }
    }
}
