namespace TheBigProject
{
    partial class UControlAnaliz
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UControlAnaliz));
            this.rchVeri = new System.Windows.Forms.RichTextBox();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.lblKelimeSayac = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnDosyaEkle = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.lblSayacBaslik = new System.Windows.Forms.Label();
            this.lblYaziBoyutu = new System.Windows.Forms.Label();
            this.cmbFont = new System.Windows.Forms.ComboBox();
            this.lblKarakterDeger = new System.Windows.Forms.Label();
            this.lblKarakter = new System.Windows.Forms.Label();
            this.btnAyrintilar = new System.Windows.Forms.Button();
            this.lblKelimeDeger = new System.Windows.Forms.Label();
            this.lblKelime = new System.Windows.Forms.Label();
            this.pnlCizgi = new System.Windows.Forms.Panel();
            this.pictureSearch = new System.Windows.Forms.PictureBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnYukle = new System.Windows.Forms.Button();
            this.btnTurkce = new System.Windows.Forms.Button();
            this.btnSonraki = new System.Windows.Forms.Button();
            this.checkBildirim = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.rchYasakKelimeler = new System.Windows.Forms.RichTextBox();
            this.cmbDil = new System.Windows.Forms.ComboBox();
            this.cmbIstisna = new System.Windows.Forms.ComboBox();
            this.btnAnaliz = new System.Windows.Forms.Button();
            this.btnSqlAra = new System.Windows.Forms.Button();
            this.btnEskiHal = new System.Windows.Forms.Button();
            this.btnHafiza = new System.Windows.Forms.Button();
            this.pnlArama = new System.Windows.Forms.Panel();
            this.lblYasakKelimeler = new System.Windows.Forms.Label();
            this.lblStopWords = new System.Windows.Forms.Label();
            this.lblDil = new System.Windows.Forms.Label();
            this.pnlAnaliz = new System.Windows.Forms.Panel();
            this.checkRakam = new System.Windows.Forms.CheckBox();
            this.rchKaldirilanlar = new System.Windows.Forms.RichTextBox();
            this.lblArama = new System.Windows.Forms.Label();
            this.lblAnaliz = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSearch)).BeginInit();
            this.pnlArama.SuspendLayout();
            this.pnlAnaliz.SuspendLayout();
            this.SuspendLayout();
            // 
            // rchVeri
            // 
            this.rchVeri.AcceptsTab = true;
            this.rchVeri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rchVeri.Font = new System.Drawing.Font("Arial", 13.5F);
            this.rchVeri.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rchVeri.Location = new System.Drawing.Point(37, 129);
            this.rchVeri.Margin = new System.Windows.Forms.Padding(0);
            this.rchVeri.Name = "rchVeri";
            this.rchVeri.Size = new System.Drawing.Size(599, 547);
            this.rchVeri.TabIndex = 22;
            this.rchVeri.Text = "";
            this.rchVeri.TextChanged += new System.EventHandler(this.rchVeri_TextChanged);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.Black;
            this.btnTemizle.FlatAppearance.BorderSize = 0;
            this.btnTemizle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnTemizle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTemizle.Location = new System.Drawing.Point(208, 99);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(2);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(174, 25);
            this.btnTemizle.TabIndex = 25;
            this.btnTemizle.Text = "Sonuçları Temizle";
            this.toolTip1.SetToolTip(this.btnTemizle, "Arama sonuçlarını sıfırlar\r\nve kelimelerin renklerini\r\neski haline dönüştürür.");
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // lblKelimeSayac
            // 
            this.lblKelimeSayac.AutoSize = true;
            this.lblKelimeSayac.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKelimeSayac.ForeColor = System.Drawing.Color.SandyBrown;
            this.lblKelimeSayac.Location = new System.Drawing.Point(186, 65);
            this.lblKelimeSayac.Name = "lblKelimeSayac";
            this.lblKelimeSayac.Size = new System.Drawing.Size(17, 18);
            this.lblKelimeSayac.TabIndex = 26;
            this.lblKelimeSayac.Text = "0";
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.PowderBlue;
            this.btnAra.FlatAppearance.BorderSize = 0;
            this.btnAra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btnAra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.ForeColor = System.Drawing.Color.Black;
            this.btnAra.Location = new System.Drawing.Point(911, 15);
            this.btnAra.Margin = new System.Windows.Forms.Padding(2);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(79, 35);
            this.btnAra.TabIndex = 24;
            this.btnAra.Text = "Ara";
            this.toolTip1.SetToolTip(this.btnAra, resources.GetString("btnAra.ToolTip"));
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnDosyaEkle
            // 
            this.btnDosyaEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(40)))));
            this.btnDosyaEkle.FlatAppearance.BorderSize = 0;
            this.btnDosyaEkle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnDosyaEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDosyaEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDosyaEkle.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDosyaEkle.ForeColor = System.Drawing.Color.White;
            this.btnDosyaEkle.Location = new System.Drawing.Point(37, 96);
            this.btnDosyaEkle.Margin = new System.Windows.Forms.Padding(0);
            this.btnDosyaEkle.Name = "btnDosyaEkle";
            this.btnDosyaEkle.Size = new System.Drawing.Size(599, 25);
            this.btnDosyaEkle.TabIndex = 11;
            this.btnDosyaEkle.Text = "Buraya Dosya Yükleyin";
            this.toolTip1.SetToolTip(this.btnDosyaEkle, resources.GetString("btnDosyaEkle.ToolTip"));
            this.btnDosyaEkle.UseVisualStyleBackColor = false;
            this.btnDosyaEkle.Click += new System.EventHandler(this.btnDosyaEkle_Click);
            // 
            // txtAra
            // 
            this.txtAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(36)))), ((int)(((byte)(70)))));
            this.txtAra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAra.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAra.ForeColor = System.Drawing.Color.DarkSalmon;
            this.txtAra.Location = new System.Drawing.Point(58, 15);
            this.txtAra.Margin = new System.Windows.Forms.Padding(0);
            this.txtAra.Multiline = true;
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(841, 31);
            this.txtAra.TabIndex = 23;
            this.txtAra.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAra_KeyDown);
            this.txtAra.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtAra_MouseDoubleClick);
            // 
            // lblSayacBaslik
            // 
            this.lblSayacBaslik.AutoSize = true;
            this.lblSayacBaslik.Font = new System.Drawing.Font("Rockwell Nova", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayacBaslik.ForeColor = System.Drawing.Color.SandyBrown;
            this.lblSayacBaslik.Location = new System.Drawing.Point(16, 63);
            this.lblSayacBaslik.Name = "lblSayacBaslik";
            this.lblSayacBaslik.Size = new System.Drawing.Size(164, 22);
            this.lblSayacBaslik.TabIndex = 27;
            this.lblSayacBaslik.Text = "Bulunan Elemanlar:";
            // 
            // lblYaziBoyutu
            // 
            this.lblYaziBoyutu.AutoSize = true;
            this.lblYaziBoyutu.BackColor = System.Drawing.Color.Transparent;
            this.lblYaziBoyutu.Font = new System.Drawing.Font("Rockwell Nova Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYaziBoyutu.ForeColor = System.Drawing.Color.SandyBrown;
            this.lblYaziBoyutu.Location = new System.Drawing.Point(444, 67);
            this.lblYaziBoyutu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYaziBoyutu.Name = "lblYaziBoyutu";
            this.lblYaziBoyutu.Size = new System.Drawing.Size(95, 22);
            this.lblYaziBoyutu.TabIndex = 37;
            this.lblYaziBoyutu.Text = "Yazı Boyutu:";
            // 
            // cmbFont
            // 
            this.cmbFont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cmbFont.DropDownWidth = 50;
            this.cmbFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbFont.FormattingEnabled = true;
            this.cmbFont.Location = new System.Drawing.Point(555, 67);
            this.cmbFont.Name = "cmbFont";
            this.cmbFont.Size = new System.Drawing.Size(81, 23);
            this.cmbFont.TabIndex = 36;
            this.cmbFont.SelectedIndexChanged += new System.EventHandler(this.cmbFont_SelectedIndexChanged);
            // 
            // lblKarakterDeger
            // 
            this.lblKarakterDeger.AutoSize = true;
            this.lblKarakterDeger.Font = new System.Drawing.Font("Rockwell Nova Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKarakterDeger.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblKarakterDeger.Location = new System.Drawing.Point(344, 69);
            this.lblKarakterDeger.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKarakterDeger.Name = "lblKarakterDeger";
            this.lblKarakterDeger.Size = new System.Drawing.Size(18, 22);
            this.lblKarakterDeger.TabIndex = 35;
            this.lblKarakterDeger.Text = "0";
            // 
            // lblKarakter
            // 
            this.lblKarakter.AutoSize = true;
            this.lblKarakter.BackColor = System.Drawing.Color.Transparent;
            this.lblKarakter.Font = new System.Drawing.Font("Rockwell Nova Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKarakter.ForeColor = System.Drawing.Color.SandyBrown;
            this.lblKarakter.Location = new System.Drawing.Point(235, 69);
            this.lblKarakter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKarakter.Name = "lblKarakter";
            this.lblKarakter.Size = new System.Drawing.Size(113, 22);
            this.lblKarakter.TabIndex = 34;
            this.lblKarakter.Text = "Karakter Sayısı:";
            // 
            // btnAyrintilar
            // 
            this.btnAyrintilar.BackColor = System.Drawing.Color.Black;
            this.btnAyrintilar.FlatAppearance.BorderSize = 0;
            this.btnAyrintilar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnAyrintilar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAyrintilar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyrintilar.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAyrintilar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAyrintilar.Location = new System.Drawing.Point(20, 99);
            this.btnAyrintilar.Name = "btnAyrintilar";
            this.btnAyrintilar.Size = new System.Drawing.Size(183, 25);
            this.btnAyrintilar.TabIndex = 31;
            this.btnAyrintilar.Text = "Ayrıntılar";
            this.toolTip1.SetToolTip(this.btnAyrintilar, "Ara Butonunu Kullandığınızda \r\nKelime İstatistiklerini Gösterir");
            this.btnAyrintilar.UseVisualStyleBackColor = false;
            this.btnAyrintilar.Click += new System.EventHandler(this.btnAyrintilar_Click);
            // 
            // lblKelimeDeger
            // 
            this.lblKelimeDeger.AutoSize = true;
            this.lblKelimeDeger.Font = new System.Drawing.Font("Rockwell Nova Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKelimeDeger.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblKelimeDeger.Location = new System.Drawing.Point(135, 69);
            this.lblKelimeDeger.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKelimeDeger.Name = "lblKelimeDeger";
            this.lblKelimeDeger.Size = new System.Drawing.Size(18, 22);
            this.lblKelimeDeger.TabIndex = 33;
            this.lblKelimeDeger.Text = "0";
            // 
            // lblKelime
            // 
            this.lblKelime.AutoSize = true;
            this.lblKelime.BackColor = System.Drawing.Color.Transparent;
            this.lblKelime.Font = new System.Drawing.Font("Rockwell Nova Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKelime.ForeColor = System.Drawing.Color.SandyBrown;
            this.lblKelime.Location = new System.Drawing.Point(37, 69);
            this.lblKelime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKelime.Name = "lblKelime";
            this.lblKelime.Size = new System.Drawing.Size(102, 22);
            this.lblKelime.TabIndex = 32;
            this.lblKelime.Text = "Kelime Sayısı:";
            // 
            // pnlCizgi
            // 
            this.pnlCizgi.BackColor = System.Drawing.Color.Gray;
            this.pnlCizgi.Location = new System.Drawing.Point(58, 46);
            this.pnlCizgi.Margin = new System.Windows.Forms.Padding(0);
            this.pnlCizgi.Name = "pnlCizgi";
            this.pnlCizgi.Size = new System.Drawing.Size(841, 1);
            this.pnlCizgi.TabIndex = 38;
            // 
            // pictureSearch
            // 
            this.pictureSearch.Image = ((System.Drawing.Image)(resources.GetObject("pictureSearch.Image")));
            this.pictureSearch.Location = new System.Drawing.Point(37, 17);
            this.pictureSearch.Margin = new System.Windows.Forms.Padding(2);
            this.pictureSearch.Name = "pictureSearch";
            this.pictureSearch.Size = new System.Drawing.Size(19, 31);
            this.pictureSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureSearch.TabIndex = 39;
            this.pictureSearch.TabStop = false;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.LightSalmon;
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnKaydet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnKaydet.Location = new System.Drawing.Point(37, 694);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(294, 25);
            this.btnKaydet.TabIndex = 40;
            this.btnKaydet.Text = "Metni RTF Olarak Kaydet";
            this.toolTip1.SetToolTip(this.btnKaydet, ".RTF formatı metnin tüm font\r\nrenk vs özelliklerini de kayıtlı\r\ntutar bu butonla " +
        "bilgisayarınızda\r\nnereye kaydedeceğinizi seçin.");
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnYukle
            // 
            this.btnYukle.BackColor = System.Drawing.Color.LightSalmon;
            this.btnYukle.FlatAppearance.BorderSize = 0;
            this.btnYukle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnYukle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnYukle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYukle.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYukle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnYukle.Location = new System.Drawing.Point(341, 694);
            this.btnYukle.Name = "btnYukle";
            this.btnYukle.Size = new System.Drawing.Size(294, 25);
            this.btnYukle.TabIndex = 41;
            this.btnYukle.Text = "Buraya RTF Dosyası Yükleyin";
            this.toolTip1.SetToolTip(this.btnYukle, "Bilgisayarınızdan .RTF dosyalarını buraya\r\nyükleyin. .TXT için yukarıdaki butonu " +
        "kullanın.");
            this.btnYukle.UseVisualStyleBackColor = false;
            this.btnYukle.Click += new System.EventHandler(this.btnYukle_Click);
            // 
            // btnTurkce
            // 
            this.btnTurkce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(40)))));
            this.btnTurkce.FlatAppearance.BorderSize = 0;
            this.btnTurkce.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnTurkce.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnTurkce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTurkce.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTurkce.ForeColor = System.Drawing.Color.White;
            this.btnTurkce.Location = new System.Drawing.Point(668, 153);
            this.btnTurkce.Margin = new System.Windows.Forms.Padding(0);
            this.btnTurkce.Name = "btnTurkce";
            this.btnTurkce.Size = new System.Drawing.Size(114, 66);
            this.btnTurkce.TabIndex = 42;
            this.btnTurkce.Text = "Metinden Türkçe Karakter Kaldırın";
            this.toolTip1.SetToolTip(this.btnTurkce, resources.GetString("btnTurkce.ToolTip"));
            this.btnTurkce.UseVisualStyleBackColor = false;
            this.btnTurkce.Click += new System.EventHandler(this.btnTurkce_Click);
            // 
            // btnSonraki
            // 
            this.btnSonraki.BackColor = System.Drawing.Color.PowderBlue;
            this.btnSonraki.FlatAppearance.BorderSize = 0;
            this.btnSonraki.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CadetBlue;
            this.btnSonraki.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnSonraki.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSonraki.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSonraki.ForeColor = System.Drawing.Color.Black;
            this.btnSonraki.Location = new System.Drawing.Point(1000, 15);
            this.btnSonraki.Margin = new System.Windows.Forms.Padding(2);
            this.btnSonraki.Name = "btnSonraki";
            this.btnSonraki.Size = new System.Drawing.Size(183, 36);
            this.btnSonraki.TabIndex = 43;
            this.btnSonraki.Text = "Bir Sonraki Kelimeye Gidin";
            this.toolTip1.SetToolTip(this.btnSonraki, resources.GetString("btnSonraki.ToolTip"));
            this.btnSonraki.UseVisualStyleBackColor = false;
            this.btnSonraki.Click += new System.EventHandler(this.btnSonraki_Click);
            // 
            // checkBildirim
            // 
            this.checkBildirim.AutoSize = true;
            this.checkBildirim.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBildirim.ForeColor = System.Drawing.Color.SandyBrown;
            this.checkBildirim.Location = new System.Drawing.Point(1197, 16);
            this.checkBildirim.Margin = new System.Windows.Forms.Padding(2);
            this.checkBildirim.Name = "checkBildirim";
            this.checkBildirim.Size = new System.Drawing.Size(175, 36);
            this.checkBildirim.TabIndex = 44;
            this.checkBildirim.Text = "Yandaki Buton İçin \r\nMessageBox Bildirimleri Aktif";
            this.toolTip1.SetToolTip(this.checkBildirim, "Aktif ederseniz imlecin hangi kelimede\r\nolduğunu, hangi kelimeye geçildiğini,\r\ntü" +
        "m elemanların gezilip başa dönüleceği\r\ngibi bilgilendirmeleri alırsınız. Bildiri" +
        "m\r\nistemiyorsanız kapatabilirsiniz.\r\n");
            this.checkBildirim.UseVisualStyleBackColor = true;
            // 
            // rchYasakKelimeler
            // 
            this.rchYasakKelimeler.Location = new System.Drawing.Point(70, 134);
            this.rchYasakKelimeler.Name = "rchYasakKelimeler";
            this.rchYasakKelimeler.Size = new System.Drawing.Size(270, 94);
            this.rchYasakKelimeler.TabIndex = 46;
            this.rchYasakKelimeler.Text = "";
            this.toolTip1.SetToolTip(this.rchYasakKelimeler, "Örnek kullanım:\r\nkalem silgi defter\r\nya da \r\nkalem\r\nsilgi\r\ndefter");
            // 
            // cmbDil
            // 
            this.cmbDil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cmbDil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDil.DropDownWidth = 50;
            this.cmbDil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbDil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbDil.FormattingEnabled = true;
            this.cmbDil.Items.AddRange(new object[] {
            "İngilizce",
            "Türkçe"});
            this.cmbDil.Location = new System.Drawing.Point(205, 12);
            this.cmbDil.Name = "cmbDil";
            this.cmbDil.Size = new System.Drawing.Size(135, 23);
            this.cmbDil.TabIndex = 22;
            this.toolTip1.SetToolTip(this.cmbDil, "İngilizce Seçerseniz Türkçe Karakterler\r\nİngilizceye Uyarlanır\r\nTürkçe Seçerseniz" +
        " Karakterler Türkçeye\r\nGöre Ayarlanır.");
            // 
            // cmbIstisna
            // 
            this.cmbIstisna.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cmbIstisna.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIstisna.DropDownWidth = 50;
            this.cmbIstisna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbIstisna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbIstisna.FormattingEnabled = true;
            this.cmbIstisna.Items.AddRange(new object[] {
            "Optimal Kelimeler",
            "Ayrıntılı",
            "Sizin Ekledikleriniz",
            "Optimal+Ekledikleriniz",
            "Kelime Çıkarmayın"});
            this.cmbIstisna.Location = new System.Drawing.Point(205, 51);
            this.cmbIstisna.Name = "cmbIstisna";
            this.cmbIstisna.Size = new System.Drawing.Size(135, 23);
            this.cmbIstisna.TabIndex = 48;
            this.toolTip1.SetToolTip(this.cmbIstisna, resources.GetString("cmbIstisna.ToolTip"));
            // 
            // btnAnaliz
            // 
            this.btnAnaliz.BackColor = System.Drawing.Color.Black;
            this.btnAnaliz.FlatAppearance.BorderSize = 0;
            this.btnAnaliz.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnAnaliz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAnaliz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnaliz.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaliz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAnaliz.Location = new System.Drawing.Point(68, 237);
            this.btnAnaliz.Name = "btnAnaliz";
            this.btnAnaliz.Size = new System.Drawing.Size(273, 25);
            this.btnAnaliz.TabIndex = 13;
            this.btnAnaliz.Text = "Metni Analiz Et";
            this.toolTip1.SetToolTip(this.btnAnaliz, "Seçenekleri ayarladıktan sonra bu \r\nbutondan metni analiz edebilirsiniz.");
            this.btnAnaliz.UseVisualStyleBackColor = false;
            this.btnAnaliz.Click += new System.EventHandler(this.btnAnaliz_Click);
            // 
            // btnSqlAra
            // 
            this.btnSqlAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(216)))));
            this.btnSqlAra.FlatAppearance.BorderSize = 0;
            this.btnSqlAra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btnSqlAra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSqlAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSqlAra.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSqlAra.ForeColor = System.Drawing.Color.Black;
            this.btnSqlAra.Location = new System.Drawing.Point(20, 15);
            this.btnSqlAra.Margin = new System.Windows.Forms.Padding(2);
            this.btnSqlAra.Name = "btnSqlAra";
            this.btnSqlAra.Size = new System.Drawing.Size(362, 30);
            this.btnSqlAra.TabIndex = 53;
            this.btnSqlAra.Text = "Veritabanına Kaydedilmeyen Kelime Ara";
            this.toolTip1.SetToolTip(this.btnSqlAra, "Metin yükledikten sonra Butonu kullanın.\r\nVeritabanında olmayan kelimeleri göster" +
        "ir.\r\nİsterseniz sonra bu kelimeleri çıkan menüden\r\nekleyebilirsiniz.");
            this.btnSqlAra.UseVisualStyleBackColor = false;
            this.btnSqlAra.Click += new System.EventHandler(this.btnSqlAra_Click);
            // 
            // btnEskiHal
            // 
            this.btnEskiHal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(40)))));
            this.btnEskiHal.FlatAppearance.BorderSize = 0;
            this.btnEskiHal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnEskiHal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEskiHal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEskiHal.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEskiHal.ForeColor = System.Drawing.Color.White;
            this.btnEskiHal.Location = new System.Drawing.Point(668, 393);
            this.btnEskiHal.Margin = new System.Windows.Forms.Padding(2);
            this.btnEskiHal.Name = "btnEskiHal";
            this.btnEskiHal.Size = new System.Drawing.Size(114, 66);
            this.btnEskiHal.TabIndex = 54;
            this.btnEskiHal.Text = "Metni Hafızadan Geri Getir";
            this.toolTip1.SetToolTip(this.btnEskiHal, "Metni Hafızada Tutulan Haline Geri Çevirir.");
            this.btnEskiHal.UseVisualStyleBackColor = false;
            this.btnEskiHal.Click += new System.EventHandler(this.btnEskiHal_Click);
            // 
            // btnHafiza
            // 
            this.btnHafiza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(40)))));
            this.btnHafiza.FlatAppearance.BorderSize = 0;
            this.btnHafiza.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy;
            this.btnHafiza.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnHafiza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHafiza.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHafiza.ForeColor = System.Drawing.Color.White;
            this.btnHafiza.Location = new System.Drawing.Point(668, 273);
            this.btnHafiza.Margin = new System.Windows.Forms.Padding(2);
            this.btnHafiza.Name = "btnHafiza";
            this.btnHafiza.Size = new System.Drawing.Size(114, 66);
            this.btnHafiza.TabIndex = 55;
            this.btnHafiza.Text = "Metni Hafızada Tut";
            this.toolTip1.SetToolTip(this.btnHafiza, "Eğer Metinde Değişiklik Yapacaksanız Ya da Program Tarafından\r\nMetin Değişir ve E" +
        "ski Haline Döndürmek İsterseniz Bu Tuşu Kullanın.");
            this.btnHafiza.UseVisualStyleBackColor = false;
            this.btnHafiza.Click += new System.EventHandler(this.btnHafiza_Click);
            // 
            // pnlArama
            // 
            this.pnlArama.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlArama.Controls.Add(this.btnSqlAra);
            this.pnlArama.Controls.Add(this.btnTemizle);
            this.pnlArama.Controls.Add(this.btnAyrintilar);
            this.pnlArama.Controls.Add(this.lblSayacBaslik);
            this.pnlArama.Controls.Add(this.lblKelimeSayac);
            this.pnlArama.Location = new System.Drawing.Point(840, 108);
            this.pnlArama.Name = "pnlArama";
            this.pnlArama.Size = new System.Drawing.Size(420, 149);
            this.pnlArama.TabIndex = 51;
            // 
            // lblYasakKelimeler
            // 
            this.lblYasakKelimeler.AutoSize = true;
            this.lblYasakKelimeler.BackColor = System.Drawing.Color.Transparent;
            this.lblYasakKelimeler.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYasakKelimeler.ForeColor = System.Drawing.Color.SandyBrown;
            this.lblYasakKelimeler.Location = new System.Drawing.Point(69, 99);
            this.lblYasakKelimeler.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYasakKelimeler.Name = "lblYasakKelimeler";
            this.lblYasakKelimeler.Size = new System.Drawing.Size(272, 32);
            this.lblYasakKelimeler.TabIndex = 47;
            this.lblYasakKelimeler.Text = "Boşluk koyarak veya alt alta yazarak siz de ek olarak \r\nistisna kelime ekleyebili" +
    "rsiniz.";
            // 
            // lblStopWords
            // 
            this.lblStopWords.AutoSize = true;
            this.lblStopWords.BackColor = System.Drawing.Color.Transparent;
            this.lblStopWords.Font = new System.Drawing.Font("Rockwell Nova Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStopWords.ForeColor = System.Drawing.Color.SandyBrown;
            this.lblStopWords.Location = new System.Drawing.Point(68, 52);
            this.lblStopWords.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStopWords.Name = "lblStopWords";
            this.lblStopWords.Size = new System.Drawing.Size(127, 22);
            this.lblStopWords.TabIndex = 49;
            this.lblStopWords.Text = "İstisna Kelimeler:";
            // 
            // lblDil
            // 
            this.lblDil.AutoSize = true;
            this.lblDil.BackColor = System.Drawing.Color.Transparent;
            this.lblDil.Font = new System.Drawing.Font("Rockwell Nova Cond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDil.ForeColor = System.Drawing.Color.SandyBrown;
            this.lblDil.Location = new System.Drawing.Point(68, 11);
            this.lblDil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDil.Name = "lblDil";
            this.lblDil.Size = new System.Drawing.Size(80, 22);
            this.lblDil.TabIndex = 22;
            this.lblDil.Text = "Metin Dili:";
            // 
            // pnlAnaliz
            // 
            this.pnlAnaliz.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAnaliz.Controls.Add(this.checkRakam);
            this.pnlAnaliz.Controls.Add(this.rchKaldirilanlar);
            this.pnlAnaliz.Controls.Add(this.rchYasakKelimeler);
            this.pnlAnaliz.Controls.Add(this.btnAnaliz);
            this.pnlAnaliz.Controls.Add(this.lblYasakKelimeler);
            this.pnlAnaliz.Controls.Add(this.cmbDil);
            this.pnlAnaliz.Controls.Add(this.cmbIstisna);
            this.pnlAnaliz.Controls.Add(this.lblStopWords);
            this.pnlAnaliz.Controls.Add(this.lblDil);
            this.pnlAnaliz.Location = new System.Drawing.Point(840, 376);
            this.pnlAnaliz.Name = "pnlAnaliz";
            this.pnlAnaliz.Size = new System.Drawing.Size(420, 343);
            this.pnlAnaliz.TabIndex = 52;
            // 
            // checkRakam
            // 
            this.checkRakam.AutoSize = true;
            this.checkRakam.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkRakam.ForeColor = System.Drawing.Color.SandyBrown;
            this.checkRakam.Location = new System.Drawing.Point(205, 77);
            this.checkRakam.Margin = new System.Windows.Forms.Padding(2);
            this.checkRakam.Name = "checkRakam";
            this.checkRakam.Size = new System.Drawing.Size(124, 20);
            this.checkRakam.TabIndex = 51;
            this.checkRakam.Text = "Rakamlar Çıkarılsın";
            this.checkRakam.UseVisualStyleBackColor = true;
            // 
            // rchKaldirilanlar
            // 
            this.rchKaldirilanlar.Location = new System.Drawing.Point(69, 269);
            this.rchKaldirilanlar.Name = "rchKaldirilanlar";
            this.rchKaldirilanlar.ReadOnly = true;
            this.rchKaldirilanlar.Size = new System.Drawing.Size(271, 60);
            this.rchKaldirilanlar.TabIndex = 50;
            this.rchKaldirilanlar.Text = "";
            // 
            // lblArama
            // 
            this.lblArama.AutoSize = true;
            this.lblArama.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblArama.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblArama.Location = new System.Drawing.Point(935, 67);
            this.lblArama.Name = "lblArama";
            this.lblArama.Size = new System.Drawing.Size(210, 34);
            this.lblArama.TabIndex = 53;
            this.lblArama.Text = "ARAMA BÖLÜMÜ";
            // 
            // lblAnaliz
            // 
            this.lblAnaliz.AutoSize = true;
            this.lblAnaliz.Font = new System.Drawing.Font("Franklin Gothic Medium", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAnaliz.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAnaliz.Location = new System.Drawing.Point(938, 330);
            this.lblAnaliz.Name = "lblAnaliz";
            this.lblAnaliz.Size = new System.Drawing.Size(207, 34);
            this.lblAnaliz.TabIndex = 56;
            this.lblAnaliz.Text = "ANALİZ BÖLÜMÜ";
            // 
            // UControlAnaliz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(36)))), ((int)(((byte)(70)))));
            this.Controls.Add(this.lblAnaliz);
            this.Controls.Add(this.btnEskiHal);
            this.Controls.Add(this.btnHafiza);
            this.Controls.Add(this.lblArama);
            this.Controls.Add(this.pnlAnaliz);
            this.Controls.Add(this.pnlArama);
            this.Controls.Add(this.checkBildirim);
            this.Controls.Add(this.btnSonraki);
            this.Controls.Add(this.btnTurkce);
            this.Controls.Add(this.btnYukle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.pictureSearch);
            this.Controls.Add(this.pnlCizgi);
            this.Controls.Add(this.rchVeri);
            this.Controls.Add(this.btnDosyaEkle);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.lblYaziBoyutu);
            this.Controls.Add(this.cmbFont);
            this.Controls.Add(this.lblKarakterDeger);
            this.Controls.Add(this.lblKarakter);
            this.Controls.Add(this.lblKelimeDeger);
            this.Controls.Add(this.lblKelime);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UControlAnaliz";
            this.Size = new System.Drawing.Size(1383, 845);
            this.Load += new System.EventHandler(this.UControlAnaliz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureSearch)).EndInit();
            this.pnlArama.ResumeLayout(false);
            this.pnlArama.PerformLayout();
            this.pnlAnaliz.ResumeLayout(false);
            this.pnlAnaliz.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rchVeri;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label lblKelimeSayac;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnDosyaEkle;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.Label lblSayacBaslik;
        private System.Windows.Forms.Label lblYaziBoyutu;
        private System.Windows.Forms.ComboBox cmbFont;
        private System.Windows.Forms.Label lblKarakterDeger;
        private System.Windows.Forms.Label lblKarakter;
        private System.Windows.Forms.Button btnAyrintilar;
        private System.Windows.Forms.Label lblKelimeDeger;
        private System.Windows.Forms.Label lblKelime;
        private System.Windows.Forms.Panel pnlCizgi;
        private System.Windows.Forms.PictureBox pictureSearch;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnYukle;
        private System.Windows.Forms.Button btnTurkce;
        private System.Windows.Forms.Button btnSonraki;
        private System.Windows.Forms.CheckBox checkBildirim;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel pnlArama;
        private System.Windows.Forms.RichTextBox rchYasakKelimeler;
        private System.Windows.Forms.Label lblYasakKelimeler;
        private System.Windows.Forms.ComboBox cmbDil;
        private System.Windows.Forms.Label lblStopWords;
        private System.Windows.Forms.Label lblDil;
        private System.Windows.Forms.ComboBox cmbIstisna;
        private System.Windows.Forms.Button btnAnaliz;
        private System.Windows.Forms.Panel pnlAnaliz;
        private System.Windows.Forms.RichTextBox rchKaldirilanlar;
        private System.Windows.Forms.Button btnSqlAra;
        private System.Windows.Forms.CheckBox checkRakam;
        private System.Windows.Forms.Button btnEskiHal;
        private System.Windows.Forms.Button btnHafiza;
        private System.Windows.Forms.Label lblArama;
        private System.Windows.Forms.Label lblAnaliz;
    }
}
