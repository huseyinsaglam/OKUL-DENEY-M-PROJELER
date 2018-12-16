using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalBilgilendirmePlatformu
{
    public partial class acilis : Form
    {
        public acilis()
        {
            InitializeComponent();
            if(Properties.Settings.Default.conn != string.Empty){
                Baglanti.baglanti = Properties.Settings.Default.conn;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uyeKaydi ek = new uyeKaydi();
            ek.Show();
            //this.Close();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uyeGirisi  ek = new uyeGirisi ();
            ek.Show();
            //this.Close();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void acilis_Load(object sender, EventArgs e)
        {

        }

        private void btnAyar_Click(object sender, EventArgs e)
        {
            conn ayar = new conn();
            ayar.ShowDialog();
        }
    }
}
