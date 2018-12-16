namespace HalBilgilendirmePlatformu
{
    partial class uyeKaydi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uyeKaydi));
            this.button2 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kullanici = new System.Windows.Forms.TextBox();
            this.sifreTekrar = new System.Windows.Forms.TextBox();
            this.sifre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIcon2 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSalmon;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.ImageKey = "iptal.png";
            this.button2.ImageList = this.ımageList1;
            this.button2.Location = new System.Drawing.Point(246, 285);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 69);
            this.button2.TabIndex = 6;
            this.button2.Text = "İptal";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "iptal.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Şifre Tekrar :";
            // 
            // kullanici
            // 
            this.kullanici.Location = new System.Drawing.Point(191, 78);
            this.kullanici.Name = "kullanici";
            this.kullanici.Size = new System.Drawing.Size(100, 20);
            this.kullanici.TabIndex = 1;
            this.kullanici.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // sifreTekrar
            // 
            this.sifreTekrar.Location = new System.Drawing.Point(191, 196);
            this.sifreTekrar.Name = "sifreTekrar";
            this.sifreTekrar.Size = new System.Drawing.Size(100, 20);
            this.sifreTekrar.TabIndex = 3;
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(191, 139);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(100, 20);
            this.sifre.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightBlue;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button1.Image = global::HalBilgilendirmePlatformu.Properties.Resources.save_icon_floppy_disk_53341;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(87, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 69);
            this.button1.TabIndex = 5;
            this.button1.Text = "Kaydet";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // notifyIcon2
            // 
            this.notifyIcon2.Text = "notifyIcon2";
            this.notifyIcon2.Visible = true;
            // 
            // uyeKaydi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(424, 397);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.sifreTekrar);
            this.Controls.Add(this.kullanici);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "uyeKaydi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Üye Kaydı";
            this.Load += new System.EventHandler(this.uyeKaydi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox kullanici;
        private System.Windows.Forms.TextBox sifreTekrar;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.NotifyIcon notifyIcon2;
    }
}