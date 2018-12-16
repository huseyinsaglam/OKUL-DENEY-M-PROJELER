namespace HalBilgilendirmePlatformu
{
    partial class HalAnaEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HalAnaEkran));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fiyatListesiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hALDataSet = new HalBilgilendirmePlatformu.HALDataSet();
            this.fiyatListesiTableAdapter = new HalBilgilendirmePlatformu.HALDataSetTableAdapters.FiyatListesiTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.meyveSebzeAra = new System.Windows.Forms.Button();
            this.sehirAra = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.uyeKayit = new System.Windows.Forms.Button();
            this.uyeGiris = new System.Windows.Forms.Button();
            this.fiyatListesiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hal_ProjesiDataSet = new HalBilgilendirmePlatformu.Hal_ProjesiDataSet();
            this.halBilgilendirmeFormuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.halBilgilendirmeFormuTableAdapter = new HalBilgilendirmePlatformu.Hal_ProjesiDataSetTableAdapters.HalBilgilendirmeFormuTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meyvesebzeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endusukfiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enyuksekFiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.halBilgilendirmeFormuBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiyatListesiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hALDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiyatListesiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hal_ProjesiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.halBilgilendirmeFormuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.halBilgilendirmeFormuBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.sehirDataGridViewTextBoxColumn,
            this.meyvesebzeDataGridViewTextBoxColumn,
            this.birimDataGridViewTextBoxColumn,
            this.endusukfiyatDataGridViewTextBoxColumn,
            this.enyuksekFiyatDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.halBilgilendirmeFormuBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 309);
            this.dataGridView1.TabIndex = 0;
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(523, 23);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Şehirler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Meyve ve Sebze";
            // 
            // meyveSebzeAra
            // 
            this.meyveSebzeAra.BackColor = System.Drawing.Color.OrangeRed;
            this.meyveSebzeAra.Image = global::HalBilgilendirmePlatformu.Properties.Resources.Search_icon;
            this.meyveSebzeAra.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.meyveSebzeAra.Location = new System.Drawing.Point(629, 12);
            this.meyveSebzeAra.Name = "meyveSebzeAra";
            this.meyveSebzeAra.Size = new System.Drawing.Size(72, 40);
            this.meyveSebzeAra.TabIndex = 5;
            this.meyveSebzeAra.Text = "Ara";
            this.meyveSebzeAra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.meyveSebzeAra.UseVisualStyleBackColor = false;
            this.meyveSebzeAra.Click += new System.EventHandler(this.button5_Click);
            // 
            // sehirAra
            // 
            this.sehirAra.BackColor = System.Drawing.Color.OrangeRed;
            this.sehirAra.Image = global::HalBilgilendirmePlatformu.Properties.Resources.Search_icon;
            this.sehirAra.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sehirAra.Location = new System.Drawing.Point(197, 12);
            this.sehirAra.Name = "sehirAra";
            this.sehirAra.Size = new System.Drawing.Size(81, 40);
            this.sehirAra.TabIndex = 4;
            this.sehirAra.Text = "Ara";
            this.sehirAra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sehirAra.UseVisualStyleBackColor = false;
            this.sehirAra.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Image = global::HalBilgilendirmePlatformu.Properties.Resources.exit;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(710, 393);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(67, 30);
            this.button3.TabIndex = 3;
            this.button3.Text = "Çıkış";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // uyeKayit
            // 
            this.uyeKayit.BackColor = System.Drawing.Color.Goldenrod;
            this.uyeKayit.Image = global::HalBilgilendirmePlatformu.Properties.Resources.user_group_new;
            this.uyeKayit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uyeKayit.Location = new System.Drawing.Point(154, 383);
            this.uyeKayit.Name = "uyeKayit";
            this.uyeKayit.Size = new System.Drawing.Size(102, 36);
            this.uyeKayit.TabIndex = 2;
            this.uyeKayit.Text = "Üye Kaydı";
            this.uyeKayit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uyeKayit.UseVisualStyleBackColor = false;
            this.uyeKayit.Click += new System.EventHandler(this.button2_Click);
            // 
            // uyeGiris
            // 
            this.uyeGiris.BackColor = System.Drawing.Color.SandyBrown;
            this.uyeGiris.Image = global::HalBilgilendirmePlatformu.Properties.Resources.clint_icon;
            this.uyeGiris.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uyeGiris.Location = new System.Drawing.Point(32, 383);
            this.uyeGiris.Name = "uyeGiris";
            this.uyeGiris.Size = new System.Drawing.Size(116, 36);
            this.uyeGiris.TabIndex = 1;
            this.uyeGiris.Text = "Üye Girişi";
            this.uyeGiris.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uyeGiris.UseVisualStyleBackColor = false;
            this.uyeGiris.Click += new System.EventHandler(this.button1_Click);
            // 
            // fiyatListesiBindingSource1
            // 
            this.fiyatListesiBindingSource1.DataMember = "FiyatListesi";
            this.fiyatListesiBindingSource1.DataSource = this.hALDataSet;
            // 
            // hal_ProjesiDataSet
            // 
            this.hal_ProjesiDataSet.DataSetName = "Hal_ProjesiDataSet";
            this.hal_ProjesiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // halBilgilendirmeFormuBindingSource
            // 
            this.halBilgilendirmeFormuBindingSource.DataMember = "HalBilgilendirmeFormu";
            this.halBilgilendirmeFormuBindingSource.DataSource = this.hal_ProjesiDataSet;
            // 
            // halBilgilendirmeFormuTableAdapter
            // 
            this.halBilgilendirmeFormuTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // sehirDataGridViewTextBoxColumn
            // 
            this.sehirDataGridViewTextBoxColumn.DataPropertyName = "sehir";
            this.sehirDataGridViewTextBoxColumn.HeaderText = "sehir";
            this.sehirDataGridViewTextBoxColumn.Name = "sehirDataGridViewTextBoxColumn";
            // 
            // meyvesebzeDataGridViewTextBoxColumn
            // 
            this.meyvesebzeDataGridViewTextBoxColumn.DataPropertyName = "meyve_sebze";
            this.meyvesebzeDataGridViewTextBoxColumn.HeaderText = "meyve_sebze";
            this.meyvesebzeDataGridViewTextBoxColumn.Name = "meyvesebzeDataGridViewTextBoxColumn";
            // 
            // birimDataGridViewTextBoxColumn
            // 
            this.birimDataGridViewTextBoxColumn.DataPropertyName = "birim";
            this.birimDataGridViewTextBoxColumn.HeaderText = "birim";
            this.birimDataGridViewTextBoxColumn.Name = "birimDataGridViewTextBoxColumn";
            // 
            // endusukfiyatDataGridViewTextBoxColumn
            // 
            this.endusukfiyatDataGridViewTextBoxColumn.DataPropertyName = "Endusukfiyat";
            this.endusukfiyatDataGridViewTextBoxColumn.HeaderText = "Endusukfiyat";
            this.endusukfiyatDataGridViewTextBoxColumn.Name = "endusukfiyatDataGridViewTextBoxColumn";
            // 
            // enyuksekFiyatDataGridViewTextBoxColumn
            // 
            this.enyuksekFiyatDataGridViewTextBoxColumn.DataPropertyName = "EnyuksekFiyat";
            this.enyuksekFiyatDataGridViewTextBoxColumn.HeaderText = "EnyuksekFiyat";
            this.enyuksekFiyatDataGridViewTextBoxColumn.Name = "enyuksekFiyatDataGridViewTextBoxColumn";
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "tarih";
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            // 
            // halBilgilendirmeFormuBindingSource1
            // 
            this.halBilgilendirmeFormuBindingSource1.DataMember = "HalBilgilendirmeFormu";
            this.halBilgilendirmeFormuBindingSource1.DataSource = this.hal_ProjesiDataSet;
            // 
            // HalAnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(789, 431);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.meyveSebzeAra);
            this.Controls.Add(this.sehirAra);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.uyeKayit);
            this.Controls.Add(this.uyeGiris);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HalAnaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hal Bilgilendirme Platformu";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiyatListesiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hALDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fiyatListesiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hal_ProjesiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.halBilgilendirmeFormuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.halBilgilendirmeFormuBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private HALDataSet hALDataSet;
        private System.Windows.Forms.BindingSource fiyatListesiBindingSource;
        private HALDataSetTableAdapters.FiyatListesiTableAdapter fiyatListesiTableAdapter;
        private System.Windows.Forms.Button uyeGiris;
        private System.Windows.Forms.Button uyeKayit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button sehirAra;
        private System.Windows.Forms.Button meyveSebzeAra;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource fiyatListesiBindingSource1;
        private Hal_ProjesiDataSet hal_ProjesiDataSet;
        private System.Windows.Forms.BindingSource halBilgilendirmeFormuBindingSource;
        private Hal_ProjesiDataSetTableAdapters.HalBilgilendirmeFormuTableAdapter halBilgilendirmeFormuTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meyvesebzeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endusukfiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enyuksekFiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource halBilgilendirmeFormuBindingSource1;
    }
}

