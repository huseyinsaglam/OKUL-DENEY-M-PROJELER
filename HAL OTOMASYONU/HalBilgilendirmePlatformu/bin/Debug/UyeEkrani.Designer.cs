namespace HalBilgilendirmePlatformu
{
    partial class UyeEkrani
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UyeEkrani));
            this.fiyatListesiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hALDataSet = new HalBilgilendirmePlatformu.HALDataSet();
            this.fiyatListesiTableAdapter = new HalBilgilendirmePlatformu.HALDataSetTableAdapters.FiyatListesiTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Cikis = new System.Windows.Forms.Button();
            this.toplamDusuk = new System.Windows.Forms.TextBox();
            this.toplamYuksek = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.excelKaydet = new System.Windows.Forms.Button();
            this.sEkle = new System.Windows.Forms.Button();
            this.uyeCıkıs = new System.Windows.Forms.Button();
            this.msAra = new System.Windows.Forms.Button();
            this.Sara = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.hal_ProjesiDataSet1 = new HalBilgilendirmePlatformu.Hal_ProjesiDataSet();
            this.button4 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.fiyatListesiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hALDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hal_ProjesiDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // fiyatListesiBindingSource
            // 
            this.fiyatListesiBindingSource.DataMember = "FiyatListesi";
            this.fiyatListesiBindingSource.DataSource = this.hALDataSet;
            // 
            // hALDataSet
            // 
            this.hALDataSet.DataSetName = "HALDataSet";
            this.hALDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fiyatListesiTableAdapter
            // 
            this.fiyatListesiTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Şehirler :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(406, 22);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Meyve ve Sebze :";
            // 
            // Cikis
            // 
            this.Cikis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Cikis.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Cikis.Image = global::HalBilgilendirmePlatformu.Properties.Resources.exit;
            this.Cikis.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Cikis.Location = new System.Drawing.Point(1083, 375);
            this.Cikis.Name = "Cikis";
            this.Cikis.Size = new System.Drawing.Size(75, 30);
            this.Cikis.TabIndex = 7;
            this.Cikis.Text = "Çıkış";
            this.Cikis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cikis.UseVisualStyleBackColor = false;
            this.Cikis.Click += new System.EventHandler(this.Cikis_Click);
            // 
            // toplamDusuk
            // 
            this.toplamDusuk.Location = new System.Drawing.Point(1045, 311);
            this.toplamDusuk.Name = "toplamDusuk";
            this.toplamDusuk.Size = new System.Drawing.Size(100, 20);
            this.toplamDusuk.TabIndex = 14;
            this.toplamDusuk.Visible = false;
            // 
            // toplamYuksek
            // 
            this.toplamYuksek.Location = new System.Drawing.Point(1045, 337);
            this.toplamYuksek.Name = "toplamYuksek";
            this.toplamYuksek.Size = new System.Drawing.Size(100, 20);
            this.toplamYuksek.TabIndex = 15;
            this.toplamYuksek.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(890, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "En Düşük Toplam Fiyat   :";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(890, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "En Yüksek Toplam Fiyat :";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(890, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Meyve ve Sebze";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1010, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Min Fiyat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1093, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Max Fiyat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(787, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Şehirler";
            // 
            // excelKaydet
            // 
            this.excelKaydet.BackColor = System.Drawing.Color.LightGreen;
            this.excelKaydet.Image = global::HalBilgilendirmePlatformu.Properties.Resources.EXCEL;
            this.excelKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.excelKaydet.Location = new System.Drawing.Point(216, 366);
            this.excelKaydet.Name = "excelKaydet";
            this.excelKaydet.Size = new System.Drawing.Size(376, 39);
            this.excelKaydet.TabIndex = 10;
            this.excelKaydet.Text = "Excel\'e Kaydet";
            this.excelKaydet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.excelKaydet.UseVisualStyleBackColor = false;
            this.excelKaydet.Click += new System.EventHandler(this.button6_Click);
            // 
            // sEkle
            // 
            this.sEkle.BackColor = System.Drawing.Color.Aquamarine;
            this.sEkle.Image = global::HalBilgilendirmePlatformu.Properties.Resources.sepet;
            this.sEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sEkle.Location = new System.Drawing.Point(12, 366);
            this.sEkle.Name = "sEkle";
            this.sEkle.Size = new System.Drawing.Size(374, 39);
            this.sEkle.TabIndex = 9;
            this.sEkle.Text = "Sepete Ekle";
            this.sEkle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sEkle.UseVisualStyleBackColor = false;
            this.sEkle.Visible = false;
            this.sEkle.Click += new System.EventHandler(this.sEkle_Click);
            // 
            // uyeCıkıs
            // 
            this.uyeCıkıs.BackColor = System.Drawing.Color.SeaGreen;
            this.uyeCıkıs.ForeColor = System.Drawing.Color.MintCream;
            this.uyeCıkıs.Image = global::HalBilgilendirmePlatformu.Properties.Resources.üçıkış;
            this.uyeCıkıs.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uyeCıkıs.Location = new System.Drawing.Point(1058, 12);
            this.uyeCıkıs.Name = "uyeCıkıs";
            this.uyeCıkıs.Size = new System.Drawing.Size(100, 48);
            this.uyeCıkıs.TabIndex = 8;
            this.uyeCıkıs.Text = "Üye Çıkışı";
            this.uyeCıkıs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uyeCıkıs.UseVisualStyleBackColor = false;
            this.uyeCıkıs.Click += new System.EventHandler(this.uyeCıkıs_Click);
            // 
            // msAra
            // 
            this.msAra.BackColor = System.Drawing.Color.Tomato;
            this.msAra.Image = global::HalBilgilendirmePlatformu.Properties.Resources.Search_icon;
            this.msAra.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.msAra.Location = new System.Drawing.Point(512, 12);
            this.msAra.Name = "msAra";
            this.msAra.Size = new System.Drawing.Size(80, 35);
            this.msAra.TabIndex = 5;
            this.msAra.Text = "Ara";
            this.msAra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.msAra.UseVisualStyleBackColor = false;
            this.msAra.Click += new System.EventHandler(this.msAra_Click);
            // 
            // Sara
            // 
            this.Sara.BackColor = System.Drawing.Color.Tomato;
            this.Sara.Image = global::HalBilgilendirmePlatformu.Properties.Resources.Search_icon;
            this.Sara.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Sara.Location = new System.Drawing.Point(169, 12);
            this.Sara.Name = "Sara";
            this.Sara.Size = new System.Drawing.Size(75, 35);
            this.Sara.TabIndex = 3;
            this.Sara.Text = "Ara";
            this.Sara.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Sara.UseVisualStyleBackColor = false;
            this.Sara.Click += new System.EventHandler(this.Sara_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 88);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(756, 254);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(774, 104);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(80, 20);
            this.textBox3.TabIndex = 24;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(893, 104);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(80, 20);
            this.textBox4.TabIndex = 25;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(995, 104);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(80, 20);
            this.textBox5.TabIndex = 26;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(1083, 104);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(80, 20);
            this.textBox6.TabIndex = 27;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(847, 188);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 28;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.Red;
            this.textBox8.Location = new System.Drawing.Point(909, 395);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(64, 20);
            this.textBox8.TabIndex = 29;
            this.textBox8.Text = "Silme";
            this.textBox8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(871, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Birim";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1018, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Tarih";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(825, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Temizle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(909, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 33;
            this.button2.Text = "Kaydet";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1013, 234);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 34;
            this.button3.Text = "Silme";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.Red;
            this.textBox9.ForeColor = System.Drawing.Color.YellowGreen;
            this.textBox9.Location = new System.Drawing.Point(825, 395);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(75, 20);
            this.textBox9.TabIndex = 35;
            this.textBox9.Text = "Silme";
            this.textBox9.Visible = false;
            // 
            // hal_ProjesiDataSet1
            // 
            this.hal_ProjesiDataSet1.DataSetName = "Hal_ProjesiDataSet";
            this.hal_ProjesiDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1094, 234);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 36;
            this.button4.Text = "Güncelle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(1013, 185);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(86, 20);
            this.dateTimePicker1.TabIndex = 37;
            // 
            // UyeEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1170, 417);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toplamYuksek);
            this.Controls.Add(this.toplamDusuk);
            this.Controls.Add(this.excelKaydet);
            this.Controls.Add(this.sEkle);
            this.Controls.Add(this.uyeCıkıs);
            this.Controls.Add(this.Cikis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.msAra);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Sara);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "UyeEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hal Bilgilendirme Platformu";
            this.Load += new System.EventHandler(this.UyeEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fiyatListesiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hALDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hal_ProjesiDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HALDataSet hALDataSet;
        private System.Windows.Forms.BindingSource fiyatListesiBindingSource;
        private HALDataSetTableAdapters.FiyatListesiTableAdapter fiyatListesiTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Sara;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button msAra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Cikis;
        private System.Windows.Forms.Button uyeCıkıs;
        private System.Windows.Forms.Button sEkle;
        private System.Windows.Forms.Button excelKaydet;
        private System.Windows.Forms.TextBox toplamDusuk;
        private System.Windows.Forms.TextBox toplamYuksek;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox9;
        private Hal_ProjesiDataSet hal_ProjesiDataSet1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}