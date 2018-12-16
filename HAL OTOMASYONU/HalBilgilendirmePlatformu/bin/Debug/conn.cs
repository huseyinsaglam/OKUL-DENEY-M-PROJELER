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
    public partial class conn : Form
    {
        public conn()
        {
            InitializeComponent();
            txtKaydet.Text = Baglanti.baglanti;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Baglanti.baglanti = txtKaydet.Text;
            Properties.Settings.Default["conn"] = txtKaydet.Text;
            Properties.Settings.Default.Save();
        }

        private void conn_Load(object sender, EventArgs e)
        {

        }
    }
}
