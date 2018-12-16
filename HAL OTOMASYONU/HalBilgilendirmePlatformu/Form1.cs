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
    public partial class HalAnaEkran : Form
    {
        public HalAnaEkran()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hal_ProjesiDataSet.HalBilgilendirmeFormu' table. You can move, or remove it, as needed.
            this.halBilgilendirmeFormuTableAdapter.Fill(this.hal_ProjesiDataSet.HalBilgilendirmeFormu);
            // TODO: This line of code loads data into the 'hALDataSet.FiyatListesi' table. You can move, or remove it, as needed.
            //this.fiyatListesiTableAdapter.Fill(this.hALDataSet.FiyatListesi);
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-4M8UDE2\\SQLEXPRESS;Initial Catalog=Hal_Projesi;Integrated Security=True"); 
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM HalBilgilendirmeFormu", baglanti);
            SqlDataReader veriyukle = komut.ExecuteReader();
            DataTable tablo = new DataTable();
            tablo.Load(veriyukle);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
            //SqlCommand komut = new SqlCommand(kayit, baglanti);
           // komut.ExecuteNonQuery();
            //baglanti.Close();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uyeGirisi uG = new uyeGirisi();
            uG.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uyeKaydi uk = new uyeKaydi();
            uk.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-4M8UDE2\\SQLEXPRESS;Initial Catalog=Hal_Projesi;Integrated Security=True");
            baglanti.Open();
            string srg = (textBox1.Text.ToString());

            string sorgu = "Select * from HalBilgilendirmeFormu where sehir like '%" + srg + "%'";
            SqlDataAdapter adap = new SqlDataAdapter(sorgu, baglanti);

            DataSet ds = new DataSet();

            adap.Fill(ds, "sehir");

            this.dataGridView1.DataSource = ds.Tables[0];

            baglanti.Close();
            textBox1.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-4M8UDE2\\SQLEXPRESS;Initial Catalog=Hal_Projesi;Integrated Security=True");
            baglanti.Open();
            string srg = (textBox2.Text.ToString());

            string sorgu = "Select * from HalBilgilendirmeFormu where meyve_sebze like '%" + srg + "%'";
            SqlDataAdapter adap1 = new SqlDataAdapter(sorgu, baglanti);

            DataSet ds1 = new DataSet();

            adap1.Fill(ds1, "meyve_sebze");

            this.dataGridView1.DataSource = ds1.Tables[0];

            baglanti.Close();
            textBox2.Clear();
        }
    }
}
