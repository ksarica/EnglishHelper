namespace TheBigProject.UserControls
{
    partial class UControlEkstra
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UControlEkstra));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnGit = new System.Windows.Forms.Button();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.txtKacKelime = new System.Windows.Forms.TextBox();
            this.lblKacKelime = new System.Windows.Forms.Label();
            this.lblCagrilmaTipi = new System.Windows.Forms.Label();
            this.cmbCagrilmaTipi = new System.Windows.Forms.ComboBox();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.txtKacSaniye = new System.Windows.Forms.TextBox();
            this.lblKacSaniye = new System.Windows.Forms.Label();
            this.lblGirisMesaj = new System.Windows.Forms.Label();
            this.lblKelimeIngilizce = new System.Windows.Forms.Label();
            this.lblKelimeTurkce = new System.Windows.Forms.Label();
            this.lblUyari = new System.Windows.Forms.Label();
            this.btnVeritabani = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnIleri = new System.Windows.Forms.Button();
            this.pictureSearch = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGit
            // 
            this.btnGit.BackColor = System.Drawing.Color.PowderBlue;
            this.btnGit.FlatAppearance.BorderSize = 0;
            this.btnGit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btnGit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnGit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGit.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGit.ForeColor = System.Drawing.Color.Black;
            this.btnGit.Location = new System.Drawing.Point(1723, 143);
            this.btnGit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGit.Name = "btnGit";
            this.btnGit.Size = new System.Drawing.Size(85, 43);
            this.btnGit.TabIndex = 41;
            this.btnGit.Text = "Git";
            this.btnGit.UseVisualStyleBackColor = false;
            this.btnGit.Click += new System.EventHandler(this.btnGit_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(36)))), ((int)(((byte)(70)))));
            this.txtUrl.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUrl.ForeColor = System.Drawing.Color.DarkSalmon;
            this.txtUrl.Location = new System.Drawing.Point(912, 143);
            this.txtUrl.Margin = new System.Windows.Forms.Padding(0);
            this.txtUrl.Multiline = true;
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(807, 42);
            this.txtUrl.TabIndex = 40;
            this.txtUrl.Click += new System.EventHandler(this.txtUrl_Click);
            this.txtUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAra_KeyDown);
            // 
            // txtKacKelime
            // 
            this.txtKacKelime.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKacKelime.Location = new System.Drawing.Point(389, 215);
            this.txtKacKelime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKacKelime.Name = "txtKacKelime";
            this.txtKacKelime.ShortcutsEnabled = false;
            this.txtKacKelime.Size = new System.Drawing.Size(211, 34);
            this.txtKacKelime.TabIndex = 50;
            this.txtKacKelime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKacKelime_KeyPress);
            // 
            // lblKacKelime
            // 
            this.lblKacKelime.AutoSize = true;
            this.lblKacKelime.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKacKelime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblKacKelime.Location = new System.Drawing.Point(51, 215);
            this.lblKacKelime.Name = "lblKacKelime";
            this.lblKacKelime.Size = new System.Drawing.Size(293, 38);
            this.lblKacKelime.TabIndex = 48;
            this.lblKacKelime.Text = "Kaç Kelime Getirilsin:";
            // 
            // lblCagrilmaTipi
            // 
            this.lblCagrilmaTipi.AutoSize = true;
            this.lblCagrilmaTipi.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCagrilmaTipi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblCagrilmaTipi.Location = new System.Drawing.Point(56, 143);
            this.lblCagrilmaTipi.Name = "lblCagrilmaTipi";
            this.lblCagrilmaTipi.Size = new System.Drawing.Size(290, 38);
            this.lblCagrilmaTipi.TabIndex = 50;
            this.lblCagrilmaTipi.Text = "Kelime Çağrılma Tipi:";
            // 
            // cmbCagrilmaTipi
            // 
            this.cmbCagrilmaTipi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cmbCagrilmaTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCagrilmaTipi.DropDownWidth = 50;
            this.cmbCagrilmaTipi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCagrilmaTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbCagrilmaTipi.FormattingEnabled = true;
            this.cmbCagrilmaTipi.Items.AddRange(new object[] {
            "Rastgele",
            "En Üstten",
            "En Alttan"});
            this.cmbCagrilmaTipi.Location = new System.Drawing.Point(389, 143);
            this.cmbCagrilmaTipi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbCagrilmaTipi.Name = "cmbCagrilmaTipi";
            this.cmbCagrilmaTipi.Size = new System.Drawing.Size(211, 26);
            this.cmbCagrilmaTipi.TabIndex = 49;
            // 
            // btnBaslat
            // 
            this.btnBaslat.BackColor = System.Drawing.Color.PowderBlue;
            this.btnBaslat.FlatAppearance.BorderSize = 0;
            this.btnBaslat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btnBaslat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnBaslat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBaslat.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaslat.ForeColor = System.Drawing.Color.Black;
            this.btnBaslat.Location = new System.Drawing.Point(335, 369);
            this.btnBaslat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(267, 34);
            this.btnBaslat.TabIndex = 52;
            this.btnBaslat.Text = "BAŞLAT";
            this.btnBaslat.UseVisualStyleBackColor = false;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(667, 190);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(1141, 809);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // txtKacSaniye
            // 
            this.txtKacSaniye.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKacSaniye.Location = new System.Drawing.Point(389, 283);
            this.txtKacSaniye.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKacSaniye.Name = "txtKacSaniye";
            this.txtKacSaniye.ShortcutsEnabled = false;
            this.txtKacSaniye.Size = new System.Drawing.Size(211, 34);
            this.txtKacSaniye.TabIndex = 54;
            this.txtKacSaniye.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKacSaniye_KeyPress_1);
            // 
            // lblKacSaniye
            // 
            this.lblKacSaniye.AutoSize = true;
            this.lblKacSaniye.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKacSaniye.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblKacSaniye.Location = new System.Drawing.Point(43, 283);
            this.lblKacSaniye.Name = "lblKacSaniye";
            this.lblKacSaniye.Size = new System.Drawing.Size(301, 38);
            this.lblKacSaniye.TabIndex = 53;
            this.lblKacSaniye.Text = "Kaç Saniye Beklensin:";
            // 
            // lblGirisMesaj
            // 
            this.lblGirisMesaj.AutoSize = true;
            this.lblGirisMesaj.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGirisMesaj.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lblGirisMesaj.Location = new System.Drawing.Point(556, 21);
            this.lblGirisMesaj.Name = "lblGirisMesaj";
            this.lblGirisMesaj.Size = new System.Drawing.Size(751, 75);
            this.lblGirisMesaj.TabIndex = 55;
            this.lblGirisMesaj.Text = "KELİME EGZERZİSİ BÖLÜMÜ";
            // 
            // lblKelimeIngilizce
            // 
            this.lblKelimeIngilizce.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKelimeIngilizce.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblKelimeIngilizce.Location = new System.Drawing.Point(43, 450);
            this.lblKelimeIngilizce.Name = "lblKelimeIngilizce";
            this.lblKelimeIngilizce.Size = new System.Drawing.Size(617, 80);
            this.lblKelimeIngilizce.TabIndex = 56;
            this.lblKelimeIngilizce.Text = "İngilizce:";
            // 
            // lblKelimeTurkce
            // 
            this.lblKelimeTurkce.Font = new System.Drawing.Font("Franklin Gothic Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKelimeTurkce.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblKelimeTurkce.Location = new System.Drawing.Point(41, 572);
            this.lblKelimeTurkce.Name = "lblKelimeTurkce";
            this.lblKelimeTurkce.Size = new System.Drawing.Size(619, 80);
            this.lblKelimeTurkce.TabIndex = 57;
            this.lblKelimeTurkce.Text = "Türkçe:";
            // 
            // lblUyari
            // 
            this.lblUyari.AutoSize = true;
            this.lblUyari.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUyari.ForeColor = System.Drawing.Color.Khaki;
            this.lblUyari.Location = new System.Drawing.Point(44, 325);
            this.lblUyari.Name = "lblUyari";
            this.lblUyari.Size = new System.Drawing.Size(546, 42);
            this.lblUyari.TabIndex = 58;
            this.lblUyari.Text = "Lütfen Sayfanın Yüklenmesi İçin Yeterli Bir Süre Verin Minimum ( 1 Saniye )\r\nAksi" +
    " Halde Ekranda Bazı Kelimeleri Atlayacaktır...";
            // 
            // btnVeritabani
            // 
            this.btnVeritabani.BackColor = System.Drawing.Color.PowderBlue;
            this.btnVeritabani.FlatAppearance.BorderSize = 0;
            this.btnVeritabani.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btnVeritabani.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnVeritabani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVeritabani.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVeritabani.ForeColor = System.Drawing.Color.Black;
            this.btnVeritabani.Location = new System.Drawing.Point(48, 369);
            this.btnVeritabani.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVeritabani.Name = "btnVeritabani";
            this.btnVeritabani.Size = new System.Drawing.Size(267, 34);
            this.btnVeritabani.TabIndex = 59;
            this.btnVeritabani.Text = "Veritabanını Çağır/Yenile";
            this.btnVeritabani.UseVisualStyleBackColor = false;
            this.btnVeritabani.Click += new System.EventHandler(this.btnVeritabani_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.BackColor = System.Drawing.Color.PowderBlue;
            this.btnYenile.FlatAppearance.BorderSize = 0;
            this.btnYenile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btnYenile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYenile.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile.ForeColor = System.Drawing.Color.Black;
            //this.btnYenile.Image = global::TheBigProject.Properties.Resources.reload;
            this.btnYenile.Location = new System.Drawing.Point(787, 143);
            this.btnYenile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(55, 43);
            this.btnYenile.TabIndex = 46;
            this.btnYenile.UseVisualStyleBackColor = false;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.PowderBlue;
            this.btnGeri.FlatAppearance.BorderSize = 0;
            this.btnGeri.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btnGeri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeri.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.ForeColor = System.Drawing.Color.Black;
            //this.btnGeri.Image = global::TheBigProject.Properties.Resources.left_arrow;
            this.btnGeri.Location = new System.Drawing.Point(667, 143);
            this.btnGeri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(55, 43);
            this.btnGeri.TabIndex = 45;
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnIleri
            // 
            this.btnIleri.BackColor = System.Drawing.Color.PowderBlue;
            this.btnIleri.FlatAppearance.BorderSize = 0;
            this.btnIleri.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btnIleri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnIleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIleri.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIleri.ForeColor = System.Drawing.Color.Black;
            //this.btnIleri.Image = global::TheBigProject.Properties.Resources.skip_track;
            this.btnIleri.Location = new System.Drawing.Point(727, 143);
            this.btnIleri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIleri.Name = "btnIleri";
            this.btnIleri.Size = new System.Drawing.Size(55, 43);
            this.btnIleri.TabIndex = 43;
            this.btnIleri.UseVisualStyleBackColor = false;
            this.btnIleri.Click += new System.EventHandler(this.btnIleri_Click);
            // 
            // pictureSearch
            // 
            this.pictureSearch.Image = ((System.Drawing.Image)(resources.GetObject("pictureSearch.Image")));
            this.pictureSearch.Location = new System.Drawing.Point(847, 143);
            this.pictureSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureSearch.Name = "pictureSearch";
            this.pictureSearch.Size = new System.Drawing.Size(63, 43);
            this.pictureSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureSearch.TabIndex = 42;
            this.pictureSearch.TabStop = false;
            // 
            // UControlEkstra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(36)))), ((int)(((byte)(70)))));
            this.Controls.Add(this.btnVeritabani);
            this.Controls.Add(this.lblUyari);
            this.Controls.Add(this.lblKelimeTurkce);
            this.Controls.Add(this.lblKelimeIngilizce);
            this.Controls.Add(this.lblGirisMesaj);
            this.Controls.Add(this.txtKacSaniye);
            this.Controls.Add(this.lblKacSaniye);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.cmbCagrilmaTipi);
            this.Controls.Add(this.lblCagrilmaTipi);
            this.Controls.Add(this.txtKacKelime);
            this.Controls.Add(this.lblKacKelime);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnIleri);
            this.Controls.Add(this.pictureSearch);
            this.Controls.Add(this.btnGit);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.webBrowser1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UControlEkstra";
            this.Size = new System.Drawing.Size(1844, 1040);
            this.Load += new System.EventHandler(this.UControlEkstra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureSearch;
        private System.Windows.Forms.Button btnGit;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnIleri;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.TextBox txtKacKelime;
        private System.Windows.Forms.Label lblKacKelime;
        private System.Windows.Forms.Label lblCagrilmaTipi;
        private System.Windows.Forms.ComboBox cmbCagrilmaTipi;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox txtKacSaniye;
        private System.Windows.Forms.Label lblKacSaniye;
        private System.Windows.Forms.Label lblGirisMesaj;
        private System.Windows.Forms.Label lblKelimeIngilizce;
        private System.Windows.Forms.Label lblKelimeTurkce;
        private System.Windows.Forms.Label lblUyari;
        private System.Windows.Forms.Button btnVeritabani;
    }
}
