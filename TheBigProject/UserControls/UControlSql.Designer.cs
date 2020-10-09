namespace TheBigProject
{
    partial class UControlSql
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgwSql = new System.Windows.Forms.DataGridView();
            this.SatirNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KelimeIngilizce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Aciklama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sayac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxGuncelle = new System.Windows.Forms.GroupBox();
            this.lblGuncelleId = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.tbxGuncelleId = new System.Windows.Forms.TextBox();
            this.tbxGuncelleAciklama = new System.Windows.Forms.TextBox();
            this.tbxGuncelleSayac = new System.Windows.Forms.TextBox();
            this.lblGuncelleKelime = new System.Windows.Forms.Label();
            this.lblGuncelleSayac = new System.Windows.Forms.Label();
            this.tbxGuncelleKelime = new System.Windows.Forms.TextBox();
            this.lblGuncelleAciklama = new System.Windows.Forms.Label();
            this.gbxEkle = new System.Windows.Forms.GroupBox();
            this.lblEkleId = new System.Windows.Forms.Label();
            this.tbxEkleId = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.tbxEkleAciklama = new System.Windows.Forms.TextBox();
            this.tbxEkleSayac = new System.Windows.Forms.TextBox();
            this.lblEkleKelime = new System.Windows.Forms.Label();
            this.lblEkleSayac = new System.Windows.Forms.Label();
            this.tbxEkleKelime = new System.Windows.Forms.TextBox();
            this.lblEkleAciklama = new System.Windows.Forms.Label();
            this.btnYenile = new System.Windows.Forms.Button();
            this.gbxSil = new System.Windows.Forms.GroupBox();
            this.lblSilId = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.tbxSilId = new System.Windows.Forms.TextBox();
            this.tbxSilAciklama = new System.Windows.Forms.TextBox();
            this.tbxSilSayac = new System.Windows.Forms.TextBox();
            this.lblSilKelime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxSilKelime = new System.Windows.Forms.TextBox();
            this.lblSilAciklama = new System.Windows.Forms.Label();
            this.btnHepsiniSil = new System.Windows.Forms.Button();
            this.btnSecilenler = new System.Windows.Forms.Button();
            this.btnSelenium = new System.Windows.Forms.Button();
            this.lblSQLBaslik = new System.Windows.Forms.Label();
            this.tbxIdIlk = new System.Windows.Forms.TextBox();
            this.lblIdSil = new System.Windows.Forms.Label();
            this.tbxIdIkinci = new System.Windows.Forms.TextBox();
            this.lblIle = new System.Windows.Forms.Label();
            this.btnAraligindaSil = new System.Windows.Forms.Button();
            this.btnAdArtan = new System.Windows.Forms.Button();
            this.btnAdAzalan = new System.Windows.Forms.Button();
            this.btnSayacArtan = new System.Windows.Forms.Button();
            this.btnSayacAzalan = new System.Windows.Forms.Button();
            this.lblSayacSirala = new System.Windows.Forms.Label();
            this.lblAdSirala = new System.Windows.Forms.Label();
            this.lblIdSirala = new System.Windows.Forms.Label();
            this.btnIdAzalan = new System.Windows.Forms.Button();
            this.btnIdArtan = new System.Windows.Forms.Button();
            this.lblAciklamaSirala = new System.Windows.Forms.Label();
            this.btnAciklamaAzalan = new System.Windows.Forms.Button();
            this.btnAciklamaArtan = new System.Windows.Forms.Button();
            this.lblSatirNo = new System.Windows.Forms.Label();
            this.btnSatirAzalan = new System.Windows.Forms.Button();
            this.btnSatirArtan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSql)).BeginInit();
            this.gbxGuncelle.SuspendLayout();
            this.gbxEkle.SuspendLayout();
            this.gbxSil.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwSql
            // 
            this.dgwSql.AllowUserToAddRows = false;
            this.dgwSql.AllowUserToDeleteRows = false;
            this.dgwSql.AllowUserToOrderColumns = true;
            this.dgwSql.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dgwSql.ColumnHeadersHeight = 30;
            this.dgwSql.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SatirNo,
            this.Id,
            this.KelimeIngilizce,
            this.Aciklama,
            this.Sayac});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwSql.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgwSql.Location = new System.Drawing.Point(202, 512);
            this.dgwSql.Name = "dgwSql";
            this.dgwSql.ReadOnly = true;
            this.dgwSql.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgwSql.RowTemplate.Height = 24;
            this.dgwSql.Size = new System.Drawing.Size(977, 309);
            this.dgwSql.TabIndex = 0;
            this.dgwSql.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwSql_CellContentClick);
            // 
            // SatirNo
            // 
            this.SatirNo.HeaderText = "SatirNo";
            this.SatirNo.Name = "SatirNo";
            this.SatirNo.ReadOnly = true;
            this.SatirNo.Width = 90;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // KelimeIngilizce
            // 
            this.KelimeIngilizce.HeaderText = "KelimeIngilizce";
            this.KelimeIngilizce.Name = "KelimeIngilizce";
            this.KelimeIngilizce.ReadOnly = true;
            this.KelimeIngilizce.Width = 300;
            // 
            // Aciklama
            // 
            this.Aciklama.HeaderText = "Aciklama";
            this.Aciklama.Name = "Aciklama";
            this.Aciklama.ReadOnly = true;
            this.Aciklama.Width = 320;
            // 
            // Sayac
            // 
            this.Sayac.HeaderText = "Sayac";
            this.Sayac.Name = "Sayac";
            this.Sayac.ReadOnly = true;
            this.Sayac.Width = 90;
            // 
            // gbxGuncelle
            // 
            this.gbxGuncelle.Controls.Add(this.lblGuncelleId);
            this.gbxGuncelle.Controls.Add(this.btnGuncelle);
            this.gbxGuncelle.Controls.Add(this.tbxGuncelleId);
            this.gbxGuncelle.Controls.Add(this.tbxGuncelleAciklama);
            this.gbxGuncelle.Controls.Add(this.tbxGuncelleSayac);
            this.gbxGuncelle.Controls.Add(this.lblGuncelleKelime);
            this.gbxGuncelle.Controls.Add(this.lblGuncelleSayac);
            this.gbxGuncelle.Controls.Add(this.tbxGuncelleKelime);
            this.gbxGuncelle.Controls.Add(this.lblGuncelleAciklama);
            this.gbxGuncelle.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxGuncelle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbxGuncelle.Location = new System.Drawing.Point(542, 105);
            this.gbxGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.gbxGuncelle.Name = "gbxGuncelle";
            this.gbxGuncelle.Padding = new System.Windows.Forms.Padding(2);
            this.gbxGuncelle.Size = new System.Drawing.Size(286, 257);
            this.gbxGuncelle.TabIndex = 10;
            this.gbxGuncelle.TabStop = false;
            this.gbxGuncelle.Text = "Kelime Güncelleyin";
            // 
            // lblGuncelleId
            // 
            this.lblGuncelleId.AutoSize = true;
            this.lblGuncelleId.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGuncelleId.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblGuncelleId.Location = new System.Drawing.Point(11, 45);
            this.lblGuncelleId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGuncelleId.Name = "lblGuncelleId";
            this.lblGuncelleId.Size = new System.Drawing.Size(20, 18);
            this.lblGuncelleId.TabIndex = 10;
            this.lblGuncelleId.Text = "Id";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.Black;
            this.btnGuncelle.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnGuncelle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGuncelle.Location = new System.Drawing.Point(134, 219);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(138, 33);
            this.btnGuncelle.TabIndex = 7;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // tbxGuncelleId
            // 
            this.tbxGuncelleId.Enabled = false;
            this.tbxGuncelleId.Location = new System.Drawing.Point(134, 43);
            this.tbxGuncelleId.Margin = new System.Windows.Forms.Padding(2);
            this.tbxGuncelleId.Name = "tbxGuncelleId";
            this.tbxGuncelleId.Size = new System.Drawing.Size(138, 22);
            this.tbxGuncelleId.TabIndex = 11;
            this.tbxGuncelleId.Text = "Güncellenemez";
            // 
            // tbxGuncelleAciklama
            // 
            this.tbxGuncelleAciklama.Location = new System.Drawing.Point(134, 136);
            this.tbxGuncelleAciklama.Margin = new System.Windows.Forms.Padding(2);
            this.tbxGuncelleAciklama.Name = "tbxGuncelleAciklama";
            this.tbxGuncelleAciklama.Size = new System.Drawing.Size(138, 22);
            this.tbxGuncelleAciklama.TabIndex = 5;
            // 
            // tbxGuncelleSayac
            // 
            this.tbxGuncelleSayac.Location = new System.Drawing.Point(134, 187);
            this.tbxGuncelleSayac.Margin = new System.Windows.Forms.Padding(2);
            this.tbxGuncelleSayac.Name = "tbxGuncelleSayac";
            this.tbxGuncelleSayac.Size = new System.Drawing.Size(138, 22);
            this.tbxGuncelleSayac.TabIndex = 6;
            // 
            // lblGuncelleKelime
            // 
            this.lblGuncelleKelime.AutoSize = true;
            this.lblGuncelleKelime.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGuncelleKelime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblGuncelleKelime.Location = new System.Drawing.Point(11, 93);
            this.lblGuncelleKelime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGuncelleKelime.Name = "lblGuncelleKelime";
            this.lblGuncelleKelime.Size = new System.Drawing.Size(96, 18);
            this.lblGuncelleKelime.TabIndex = 1;
            this.lblGuncelleKelime.Text = "Kelimeİngilizce";
            // 
            // lblGuncelleSayac
            // 
            this.lblGuncelleSayac.AutoSize = true;
            this.lblGuncelleSayac.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGuncelleSayac.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblGuncelleSayac.Location = new System.Drawing.Point(11, 190);
            this.lblGuncelleSayac.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGuncelleSayac.Name = "lblGuncelleSayac";
            this.lblGuncelleSayac.Size = new System.Drawing.Size(44, 18);
            this.lblGuncelleSayac.TabIndex = 5;
            this.lblGuncelleSayac.Text = "Sayaç";
            // 
            // tbxGuncelleKelime
            // 
            this.tbxGuncelleKelime.Location = new System.Drawing.Point(134, 92);
            this.tbxGuncelleKelime.Margin = new System.Windows.Forms.Padding(2);
            this.tbxGuncelleKelime.Name = "tbxGuncelleKelime";
            this.tbxGuncelleKelime.Size = new System.Drawing.Size(138, 22);
            this.tbxGuncelleKelime.TabIndex = 4;
            // 
            // lblGuncelleAciklama
            // 
            this.lblGuncelleAciklama.AutoSize = true;
            this.lblGuncelleAciklama.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGuncelleAciklama.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblGuncelleAciklama.Location = new System.Drawing.Point(11, 139);
            this.lblGuncelleAciklama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGuncelleAciklama.Name = "lblGuncelleAciklama";
            this.lblGuncelleAciklama.Size = new System.Drawing.Size(63, 18);
            this.lblGuncelleAciklama.TabIndex = 3;
            this.lblGuncelleAciklama.Text = "Açıklama";
            // 
            // gbxEkle
            // 
            this.gbxEkle.Controls.Add(this.lblEkleId);
            this.gbxEkle.Controls.Add(this.tbxEkleId);
            this.gbxEkle.Controls.Add(this.btnEkle);
            this.gbxEkle.Controls.Add(this.tbxEkleAciklama);
            this.gbxEkle.Controls.Add(this.tbxEkleSayac);
            this.gbxEkle.Controls.Add(this.lblEkleKelime);
            this.gbxEkle.Controls.Add(this.lblEkleSayac);
            this.gbxEkle.Controls.Add(this.tbxEkleKelime);
            this.gbxEkle.Controls.Add(this.lblEkleAciklama);
            this.gbxEkle.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxEkle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbxEkle.Location = new System.Drawing.Point(49, 105);
            this.gbxEkle.Margin = new System.Windows.Forms.Padding(2);
            this.gbxEkle.Name = "gbxEkle";
            this.gbxEkle.Padding = new System.Windows.Forms.Padding(2);
            this.gbxEkle.Size = new System.Drawing.Size(286, 257);
            this.gbxEkle.TabIndex = 9;
            this.gbxEkle.TabStop = false;
            this.gbxEkle.Text = "Kelime Ekleyin";
            // 
            // lblEkleId
            // 
            this.lblEkleId.AutoSize = true;
            this.lblEkleId.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEkleId.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEkleId.Location = new System.Drawing.Point(16, 46);
            this.lblEkleId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEkleId.Name = "lblEkleId";
            this.lblEkleId.Size = new System.Drawing.Size(20, 18);
            this.lblEkleId.TabIndex = 8;
            this.lblEkleId.Text = "Id";
            // 
            // tbxEkleId
            // 
            this.tbxEkleId.Enabled = false;
            this.tbxEkleId.Location = new System.Drawing.Point(138, 46);
            this.tbxEkleId.Margin = new System.Windows.Forms.Padding(2);
            this.tbxEkleId.Name = "tbxEkleId";
            this.tbxEkleId.Size = new System.Drawing.Size(138, 22);
            this.tbxEkleId.TabIndex = 9;
            this.tbxEkleId.Text = "Id Otomatik Atanır";
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.Black;
            this.btnEkle.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnEkle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEkle.Location = new System.Drawing.Point(138, 220);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(138, 33);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // tbxEkleAciklama
            // 
            this.tbxEkleAciklama.Location = new System.Drawing.Point(138, 134);
            this.tbxEkleAciklama.Margin = new System.Windows.Forms.Padding(2);
            this.tbxEkleAciklama.Name = "tbxEkleAciklama";
            this.tbxEkleAciklama.Size = new System.Drawing.Size(138, 22);
            this.tbxEkleAciklama.TabIndex = 2;
            // 
            // tbxEkleSayac
            // 
            this.tbxEkleSayac.Enabled = false;
            this.tbxEkleSayac.Location = new System.Drawing.Point(138, 185);
            this.tbxEkleSayac.Margin = new System.Windows.Forms.Padding(2);
            this.tbxEkleSayac.Name = "tbxEkleSayac";
            this.tbxEkleSayac.Size = new System.Drawing.Size(138, 22);
            this.tbxEkleSayac.TabIndex = 6;
            this.tbxEkleSayac.Text = "1 (Değiştirilemez) ";
            // 
            // lblEkleKelime
            // 
            this.lblEkleKelime.AutoSize = true;
            this.lblEkleKelime.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEkleKelime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEkleKelime.Location = new System.Drawing.Point(16, 91);
            this.lblEkleKelime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEkleKelime.Name = "lblEkleKelime";
            this.lblEkleKelime.Size = new System.Drawing.Size(96, 18);
            this.lblEkleKelime.TabIndex = 1;
            this.lblEkleKelime.Text = "Kelimeİngilizce";
            // 
            // lblEkleSayac
            // 
            this.lblEkleSayac.AutoSize = true;
            this.lblEkleSayac.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEkleSayac.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEkleSayac.Location = new System.Drawing.Point(16, 186);
            this.lblEkleSayac.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEkleSayac.Name = "lblEkleSayac";
            this.lblEkleSayac.Size = new System.Drawing.Size(44, 18);
            this.lblEkleSayac.TabIndex = 5;
            this.lblEkleSayac.Text = "Sayaç";
            // 
            // tbxEkleKelime
            // 
            this.tbxEkleKelime.Location = new System.Drawing.Point(138, 90);
            this.tbxEkleKelime.Margin = new System.Windows.Forms.Padding(2);
            this.tbxEkleKelime.Name = "tbxEkleKelime";
            this.tbxEkleKelime.Size = new System.Drawing.Size(138, 22);
            this.tbxEkleKelime.TabIndex = 1;
            // 
            // lblEkleAciklama
            // 
            this.lblEkleAciklama.AutoSize = true;
            this.lblEkleAciklama.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEkleAciklama.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblEkleAciklama.Location = new System.Drawing.Point(16, 135);
            this.lblEkleAciklama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEkleAciklama.Name = "lblEkleAciklama";
            this.lblEkleAciklama.Size = new System.Drawing.Size(63, 18);
            this.lblEkleAciklama.TabIndex = 3;
            this.lblEkleAciklama.Text = "Açıklama";
            // 
            // btnYenile
            // 
            this.btnYenile.BackColor = System.Drawing.Color.Black;
            this.btnYenile.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnYenile.FlatAppearance.BorderSize = 0;
            this.btnYenile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnYenile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYenile.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnYenile.Location = new System.Drawing.Point(49, 512);
            this.btnYenile.Margin = new System.Windows.Forms.Padding(2);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(138, 85);
            this.btnYenile.TabIndex = 13;
            this.btnYenile.Text = "Tabloyu Yenile";
            this.btnYenile.UseVisualStyleBackColor = false;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // gbxSil
            // 
            this.gbxSil.Controls.Add(this.lblSilId);
            this.gbxSil.Controls.Add(this.btnSil);
            this.gbxSil.Controls.Add(this.tbxSilId);
            this.gbxSil.Controls.Add(this.tbxSilAciklama);
            this.gbxSil.Controls.Add(this.tbxSilSayac);
            this.gbxSil.Controls.Add(this.lblSilKelime);
            this.gbxSil.Controls.Add(this.label3);
            this.gbxSil.Controls.Add(this.tbxSilKelime);
            this.gbxSil.Controls.Add(this.lblSilAciklama);
            this.gbxSil.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxSil.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbxSil.Location = new System.Drawing.Point(1034, 105);
            this.gbxSil.Margin = new System.Windows.Forms.Padding(2);
            this.gbxSil.Name = "gbxSil";
            this.gbxSil.Padding = new System.Windows.Forms.Padding(2);
            this.gbxSil.Size = new System.Drawing.Size(287, 257);
            this.gbxSil.TabIndex = 12;
            this.gbxSil.TabStop = false;
            this.gbxSil.Text = "Kelime Silin";
            // 
            // lblSilId
            // 
            this.lblSilId.AutoSize = true;
            this.lblSilId.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSilId.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSilId.Location = new System.Drawing.Point(7, 46);
            this.lblSilId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSilId.Name = "lblSilId";
            this.lblSilId.Size = new System.Drawing.Size(20, 18);
            this.lblSilId.TabIndex = 10;
            this.lblSilId.Text = "Id";
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Black;
            this.btnSil.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnSil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSil.Location = new System.Drawing.Point(134, 222);
            this.btnSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(138, 33);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // tbxSilId
            // 
            this.tbxSilId.Location = new System.Drawing.Point(134, 43);
            this.tbxSilId.Margin = new System.Windows.Forms.Padding(2);
            this.tbxSilId.Name = "tbxSilId";
            this.tbxSilId.Size = new System.Drawing.Size(138, 22);
            this.tbxSilId.TabIndex = 8;
            // 
            // tbxSilAciklama
            // 
            this.tbxSilAciklama.Location = new System.Drawing.Point(134, 136);
            this.tbxSilAciklama.Margin = new System.Windows.Forms.Padding(2);
            this.tbxSilAciklama.Name = "tbxSilAciklama";
            this.tbxSilAciklama.Size = new System.Drawing.Size(138, 22);
            this.tbxSilAciklama.TabIndex = 10;
            // 
            // tbxSilSayac
            // 
            this.tbxSilSayac.Location = new System.Drawing.Point(134, 187);
            this.tbxSilSayac.Margin = new System.Windows.Forms.Padding(2);
            this.tbxSilSayac.Name = "tbxSilSayac";
            this.tbxSilSayac.Size = new System.Drawing.Size(138, 22);
            this.tbxSilSayac.TabIndex = 11;
            // 
            // lblSilKelime
            // 
            this.lblSilKelime.AutoSize = true;
            this.lblSilKelime.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSilKelime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSilKelime.Location = new System.Drawing.Point(7, 93);
            this.lblSilKelime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSilKelime.Name = "lblSilKelime";
            this.lblSilKelime.Size = new System.Drawing.Size(96, 18);
            this.lblSilKelime.TabIndex = 1;
            this.lblSilKelime.Text = "Kelimeİngilizce";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(7, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sayaç";
            // 
            // tbxSilKelime
            // 
            this.tbxSilKelime.Location = new System.Drawing.Point(134, 92);
            this.tbxSilKelime.Margin = new System.Windows.Forms.Padding(2);
            this.tbxSilKelime.Name = "tbxSilKelime";
            this.tbxSilKelime.Size = new System.Drawing.Size(138, 22);
            this.tbxSilKelime.TabIndex = 9;
            // 
            // lblSilAciklama
            // 
            this.lblSilAciklama.AutoSize = true;
            this.lblSilAciklama.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSilAciklama.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSilAciklama.Location = new System.Drawing.Point(7, 139);
            this.lblSilAciklama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSilAciklama.Name = "lblSilAciklama";
            this.lblSilAciklama.Size = new System.Drawing.Size(63, 18);
            this.lblSilAciklama.TabIndex = 3;
            this.lblSilAciklama.Text = "Açıklama";
            // 
            // btnHepsiniSil
            // 
            this.btnHepsiniSil.BackColor = System.Drawing.Color.Black;
            this.btnHepsiniSil.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnHepsiniSil.FlatAppearance.BorderSize = 0;
            this.btnHepsiniSil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnHepsiniSil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnHepsiniSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHepsiniSil.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHepsiniSil.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHepsiniSil.Location = new System.Drawing.Point(1196, 732);
            this.btnHepsiniSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnHepsiniSil.Name = "btnHepsiniSil";
            this.btnHepsiniSil.Size = new System.Drawing.Size(138, 85);
            this.btnHepsiniSil.TabIndex = 16;
            this.btnHepsiniSil.Text = "Veritabanını Temizle";
            this.btnHepsiniSil.UseVisualStyleBackColor = false;
            this.btnHepsiniSil.Click += new System.EventHandler(this.btnHepsiniSil_Click);
            // 
            // btnSecilenler
            // 
            this.btnSecilenler.BackColor = System.Drawing.Color.Black;
            this.btnSecilenler.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnSecilenler.FlatAppearance.BorderSize = 0;
            this.btnSecilenler.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnSecilenler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSecilenler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecilenler.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSecilenler.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSecilenler.Location = new System.Drawing.Point(1196, 512);
            this.btnSecilenler.Margin = new System.Windows.Forms.Padding(2);
            this.btnSecilenler.Name = "btnSecilenler";
            this.btnSecilenler.Size = new System.Drawing.Size(138, 85);
            this.btnSecilenler.TabIndex = 14;
            this.btnSecilenler.Text = "Seçili Olanları Sil";
            this.btnSecilenler.UseVisualStyleBackColor = false;
            this.btnSecilenler.Click += new System.EventHandler(this.btnSecilenler_Click);
            // 
            // btnSelenium
            // 
            this.btnSelenium.BackColor = System.Drawing.Color.Black;
            this.btnSelenium.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnSelenium.FlatAppearance.BorderSize = 0;
            this.btnSelenium.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnSelenium.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSelenium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelenium.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSelenium.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSelenium.Location = new System.Drawing.Point(49, 732);
            this.btnSelenium.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelenium.Name = "btnSelenium";
            this.btnSelenium.Size = new System.Drawing.Size(138, 85);
            this.btnSelenium.TabIndex = 15;
            this.btnSelenium.Text = "Kelime Çevirilerini SQL e Aktar";
            this.btnSelenium.UseVisualStyleBackColor = false;
            this.btnSelenium.Click += new System.EventHandler(this.btnSelenium_Click);
            // 
            // lblSQLBaslik
            // 
            this.lblSQLBaslik.AutoSize = true;
            this.lblSQLBaslik.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSQLBaslik.ForeColor = System.Drawing.Color.Gold;
            this.lblSQLBaslik.Location = new System.Drawing.Point(485, 13);
            this.lblSQLBaslik.Name = "lblSQLBaslik";
            this.lblSQLBaslik.Size = new System.Drawing.Size(467, 61);
            this.lblSQLBaslik.TabIndex = 17;
            this.lblSQLBaslik.Text = "VERİTABANI BÖLÜMÜ";
            // 
            // tbxIdIlk
            // 
            this.tbxIdIlk.Location = new System.Drawing.Point(592, 385);
            this.tbxIdIlk.Name = "tbxIdIlk";
            this.tbxIdIlk.Size = new System.Drawing.Size(100, 25);
            this.tbxIdIlk.TabIndex = 18;
            // 
            // lblIdSil
            // 
            this.lblIdSil.AutoSize = true;
            this.lblIdSil.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIdSil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblIdSil.Location = new System.Drawing.Point(304, 385);
            this.lblIdSil.Name = "lblIdSil";
            this.lblIdSil.Size = new System.Drawing.Size(261, 24);
            this.lblIdSil.TabIndex = 19;
            this.lblIdSil.Text = "Şu Id Aralığındaki Verileri Silin:";
            // 
            // tbxIdIkinci
            // 
            this.tbxIdIkinci.Location = new System.Drawing.Point(790, 385);
            this.tbxIdIkinci.Name = "tbxIdIkinci";
            this.tbxIdIkinci.Size = new System.Drawing.Size(100, 25);
            this.tbxIdIkinci.TabIndex = 20;
            // 
            // lblIle
            // 
            this.lblIle.AutoSize = true;
            this.lblIle.Font = new System.Drawing.Font("Franklin Gothic Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblIle.Location = new System.Drawing.Point(719, 386);
            this.lblIle.Name = "lblIle";
            this.lblIle.Size = new System.Drawing.Size(30, 24);
            this.lblIle.TabIndex = 21;
            this.lblIle.Text = "ile";
            // 
            // btnAraligindaSil
            // 
            this.btnAraligindaSil.BackColor = System.Drawing.Color.White;
            this.btnAraligindaSil.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnAraligindaSil.FlatAppearance.BorderSize = 0;
            this.btnAraligindaSil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnAraligindaSil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnAraligindaSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAraligindaSil.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAraligindaSil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAraligindaSil.Location = new System.Drawing.Point(953, 385);
            this.btnAraligindaSil.Margin = new System.Windows.Forms.Padding(2);
            this.btnAraligindaSil.Name = "btnAraligindaSil";
            this.btnAraligindaSil.Size = new System.Drawing.Size(99, 25);
            this.btnAraligindaSil.TabIndex = 13;
            this.btnAraligindaSil.Text = "Sil";
            this.btnAraligindaSil.UseVisualStyleBackColor = false;
            this.btnAraligindaSil.Click += new System.EventHandler(this.btnAraligindaSil_Click);
            // 
            // btnAdArtan
            // 
            this.btnAdArtan.BackColor = System.Drawing.Color.Black;
            this.btnAdArtan.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnAdArtan.FlatAppearance.BorderSize = 0;
            this.btnAdArtan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnAdArtan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btnAdArtan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdArtan.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdArtan.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdArtan.Location = new System.Drawing.Point(629, 458);
            this.btnAdArtan.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdArtan.Name = "btnAdArtan";
            this.btnAdArtan.Size = new System.Drawing.Size(67, 49);
            this.btnAdArtan.TabIndex = 22;
            this.btnAdArtan.Text = "ARTAN";
            this.btnAdArtan.UseVisualStyleBackColor = false;
            this.btnAdArtan.Click += new System.EventHandler(this.btnAlfabeArtan_Click);
            // 
            // btnAdAzalan
            // 
            this.btnAdAzalan.BackColor = System.Drawing.Color.Black;
            this.btnAdAzalan.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnAdAzalan.FlatAppearance.BorderSize = 0;
            this.btnAdAzalan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnAdAzalan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnAdAzalan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdAzalan.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdAzalan.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdAzalan.Location = new System.Drawing.Point(700, 458);
            this.btnAdAzalan.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdAzalan.Name = "btnAdAzalan";
            this.btnAdAzalan.Size = new System.Drawing.Size(67, 49);
            this.btnAdAzalan.TabIndex = 23;
            this.btnAdAzalan.Text = "AZALAN";
            this.btnAdAzalan.UseVisualStyleBackColor = false;
            this.btnAdAzalan.Click += new System.EventHandler(this.btnAlfabeAzalan_Click);
            // 
            // btnSayacArtan
            // 
            this.btnSayacArtan.BackColor = System.Drawing.Color.Black;
            this.btnSayacArtan.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnSayacArtan.FlatAppearance.BorderSize = 0;
            this.btnSayacArtan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnSayacArtan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btnSayacArtan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSayacArtan.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSayacArtan.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSayacArtan.Location = new System.Drawing.Point(997, 458);
            this.btnSayacArtan.Margin = new System.Windows.Forms.Padding(2);
            this.btnSayacArtan.Name = "btnSayacArtan";
            this.btnSayacArtan.Size = new System.Drawing.Size(67, 49);
            this.btnSayacArtan.TabIndex = 24;
            this.btnSayacArtan.Text = "ARTAN";
            this.btnSayacArtan.UseVisualStyleBackColor = false;
            this.btnSayacArtan.Click += new System.EventHandler(this.btnSayacArtan_Click);
            // 
            // btnSayacAzalan
            // 
            this.btnSayacAzalan.BackColor = System.Drawing.Color.Black;
            this.btnSayacAzalan.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnSayacAzalan.FlatAppearance.BorderSize = 0;
            this.btnSayacAzalan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnSayacAzalan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSayacAzalan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSayacAzalan.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSayacAzalan.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSayacAzalan.Location = new System.Drawing.Point(1068, 458);
            this.btnSayacAzalan.Margin = new System.Windows.Forms.Padding(2);
            this.btnSayacAzalan.Name = "btnSayacAzalan";
            this.btnSayacAzalan.Size = new System.Drawing.Size(67, 49);
            this.btnSayacAzalan.TabIndex = 25;
            this.btnSayacAzalan.Text = "AZALAN";
            this.btnSayacAzalan.UseVisualStyleBackColor = false;
            this.btnSayacAzalan.Click += new System.EventHandler(this.btnSayacAzalan_Click);
            // 
            // lblSayacSirala
            // 
            this.lblSayacSirala.AutoSize = true;
            this.lblSayacSirala.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayacSirala.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblSayacSirala.Location = new System.Drawing.Point(1012, 425);
            this.lblSayacSirala.Name = "lblSayacSirala";
            this.lblSayacSirala.Size = new System.Drawing.Size(95, 21);
            this.lblSayacSirala.TabIndex = 26;
            this.lblSayacSirala.Text = "Sayaca Göre";
            // 
            // lblAdSirala
            // 
            this.lblAdSirala.AutoSize = true;
            this.lblAdSirala.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSirala.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblAdSirala.Location = new System.Drawing.Point(663, 425);
            this.lblAdSirala.Name = "lblAdSirala";
            this.lblAdSirala.Size = new System.Drawing.Size(78, 21);
            this.lblAdSirala.TabIndex = 27;
            this.lblAdSirala.Text = "İsme Göre";
            // 
            // lblIdSirala
            // 
            this.lblIdSirala.AutoSize = true;
            this.lblIdSirala.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIdSirala.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblIdSirala.Location = new System.Drawing.Point(469, 425);
            this.lblIdSirala.Name = "lblIdSirala";
            this.lblIdSirala.Size = new System.Drawing.Size(77, 21);
            this.lblIdSirala.TabIndex = 30;
            this.lblIdSirala.Text = "Id ye Göre";
            // 
            // btnIdAzalan
            // 
            this.btnIdAzalan.BackColor = System.Drawing.Color.Black;
            this.btnIdAzalan.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnIdAzalan.FlatAppearance.BorderSize = 0;
            this.btnIdAzalan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnIdAzalan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnIdAzalan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIdAzalan.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIdAzalan.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIdAzalan.Location = new System.Drawing.Point(506, 458);
            this.btnIdAzalan.Margin = new System.Windows.Forms.Padding(2);
            this.btnIdAzalan.Name = "btnIdAzalan";
            this.btnIdAzalan.Size = new System.Drawing.Size(67, 49);
            this.btnIdAzalan.TabIndex = 29;
            this.btnIdAzalan.Text = "AZALAN";
            this.btnIdAzalan.UseVisualStyleBackColor = false;
            this.btnIdAzalan.Click += new System.EventHandler(this.btnIdAzalan_Click);
            // 
            // btnIdArtan
            // 
            this.btnIdArtan.BackColor = System.Drawing.Color.Black;
            this.btnIdArtan.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnIdArtan.FlatAppearance.BorderSize = 0;
            this.btnIdArtan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnIdArtan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btnIdArtan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIdArtan.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIdArtan.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIdArtan.Location = new System.Drawing.Point(435, 458);
            this.btnIdArtan.Margin = new System.Windows.Forms.Padding(2);
            this.btnIdArtan.Name = "btnIdArtan";
            this.btnIdArtan.Size = new System.Drawing.Size(67, 49);
            this.btnIdArtan.TabIndex = 28;
            this.btnIdArtan.Text = "ARTAN";
            this.btnIdArtan.UseVisualStyleBackColor = false;
            this.btnIdArtan.Click += new System.EventHandler(this.btnIdArtan_Click);
            // 
            // lblAciklamaSirala
            // 
            this.lblAciklamaSirala.AutoSize = true;
            this.lblAciklamaSirala.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAciklamaSirala.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblAciklamaSirala.Location = new System.Drawing.Point(818, 425);
            this.lblAciklamaSirala.Name = "lblAciklamaSirala";
            this.lblAciklamaSirala.Size = new System.Drawing.Size(127, 21);
            this.lblAciklamaSirala.TabIndex = 33;
            this.lblAciklamaSirala.Text = "Açıklamaya Göre";
            // 
            // btnAciklamaAzalan
            // 
            this.btnAciklamaAzalan.BackColor = System.Drawing.Color.Black;
            this.btnAciklamaAzalan.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnAciklamaAzalan.FlatAppearance.BorderSize = 0;
            this.btnAciklamaAzalan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnAciklamaAzalan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnAciklamaAzalan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAciklamaAzalan.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAciklamaAzalan.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAciklamaAzalan.Location = new System.Drawing.Point(885, 458);
            this.btnAciklamaAzalan.Margin = new System.Windows.Forms.Padding(2);
            this.btnAciklamaAzalan.Name = "btnAciklamaAzalan";
            this.btnAciklamaAzalan.Size = new System.Drawing.Size(67, 49);
            this.btnAciklamaAzalan.TabIndex = 32;
            this.btnAciklamaAzalan.Text = "AZALAN";
            this.btnAciklamaAzalan.UseVisualStyleBackColor = false;
            this.btnAciklamaAzalan.Click += new System.EventHandler(this.btnAciklamaAzalan_Click);
            // 
            // btnAciklamaArtan
            // 
            this.btnAciklamaArtan.BackColor = System.Drawing.Color.Black;
            this.btnAciklamaArtan.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnAciklamaArtan.FlatAppearance.BorderSize = 0;
            this.btnAciklamaArtan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnAciklamaArtan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btnAciklamaArtan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAciklamaArtan.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAciklamaArtan.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAciklamaArtan.Location = new System.Drawing.Point(814, 458);
            this.btnAciklamaArtan.Margin = new System.Windows.Forms.Padding(2);
            this.btnAciklamaArtan.Name = "btnAciklamaArtan";
            this.btnAciklamaArtan.Size = new System.Drawing.Size(67, 49);
            this.btnAciklamaArtan.TabIndex = 31;
            this.btnAciklamaArtan.Text = "ARTAN";
            this.btnAciklamaArtan.UseVisualStyleBackColor = false;
            this.btnAciklamaArtan.Click += new System.EventHandler(this.btnAciklamaArtan_Click);
            // 
            // lblSatirNo
            // 
            this.lblSatirNo.AutoSize = true;
            this.lblSatirNo.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSatirNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblSatirNo.Location = new System.Drawing.Point(287, 425);
            this.lblSatirNo.Name = "lblSatirNo";
            this.lblSatirNo.Size = new System.Drawing.Size(60, 21);
            this.lblSatirNo.TabIndex = 36;
            this.lblSatirNo.Text = "SatırNo";
            // 
            // btnSatirAzalan
            // 
            this.btnSatirAzalan.BackColor = System.Drawing.Color.Black;
            this.btnSatirAzalan.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnSatirAzalan.FlatAppearance.BorderSize = 0;
            this.btnSatirAzalan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnSatirAzalan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnSatirAzalan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatirAzalan.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatirAzalan.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSatirAzalan.Location = new System.Drawing.Point(324, 458);
            this.btnSatirAzalan.Margin = new System.Windows.Forms.Padding(2);
            this.btnSatirAzalan.Name = "btnSatirAzalan";
            this.btnSatirAzalan.Size = new System.Drawing.Size(67, 49);
            this.btnSatirAzalan.TabIndex = 35;
            this.btnSatirAzalan.Text = "AZALAN";
            this.btnSatirAzalan.UseVisualStyleBackColor = false;
            this.btnSatirAzalan.Click += new System.EventHandler(this.btnSatirAzalan_Click);
            // 
            // btnSatirArtan
            // 
            this.btnSatirArtan.BackColor = System.Drawing.Color.Black;
            this.btnSatirArtan.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.btnSatirArtan.FlatAppearance.BorderSize = 0;
            this.btnSatirArtan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnSatirArtan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen;
            this.btnSatirArtan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatirArtan.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSatirArtan.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSatirArtan.Location = new System.Drawing.Point(253, 458);
            this.btnSatirArtan.Margin = new System.Windows.Forms.Padding(2);
            this.btnSatirArtan.Name = "btnSatirArtan";
            this.btnSatirArtan.Size = new System.Drawing.Size(67, 49);
            this.btnSatirArtan.TabIndex = 34;
            this.btnSatirArtan.Text = "ARTAN";
            this.btnSatirArtan.UseVisualStyleBackColor = false;
            this.btnSatirArtan.Click += new System.EventHandler(this.btnSatirArtan_Click);
            // 
            // UControlSql
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(36)))), ((int)(((byte)(70)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.lblSatirNo);
            this.Controls.Add(this.btnSatirAzalan);
            this.Controls.Add(this.btnSatirArtan);
            this.Controls.Add(this.lblAciklamaSirala);
            this.Controls.Add(this.btnAciklamaAzalan);
            this.Controls.Add(this.btnAciklamaArtan);
            this.Controls.Add(this.lblIdSirala);
            this.Controls.Add(this.btnIdAzalan);
            this.Controls.Add(this.btnIdArtan);
            this.Controls.Add(this.lblAdSirala);
            this.Controls.Add(this.lblSayacSirala);
            this.Controls.Add(this.btnSayacAzalan);
            this.Controls.Add(this.btnSayacArtan);
            this.Controls.Add(this.btnAdAzalan);
            this.Controls.Add(this.btnAdArtan);
            this.Controls.Add(this.btnAraligindaSil);
            this.Controls.Add(this.lblIle);
            this.Controls.Add(this.tbxIdIkinci);
            this.Controls.Add(this.lblIdSil);
            this.Controls.Add(this.tbxIdIlk);
            this.Controls.Add(this.lblSQLBaslik);
            this.Controls.Add(this.btnSelenium);
            this.Controls.Add(this.btnSecilenler);
            this.Controls.Add(this.btnHepsiniSil);
            this.Controls.Add(this.gbxSil);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.gbxGuncelle);
            this.Controls.Add(this.gbxEkle);
            this.Controls.Add(this.dgwSql);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "UControlSql";
            this.Size = new System.Drawing.Size(1383, 845);
            this.Load += new System.EventHandler(this.UControlSql_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSql)).EndInit();
            this.gbxGuncelle.ResumeLayout(false);
            this.gbxGuncelle.PerformLayout();
            this.gbxEkle.ResumeLayout(false);
            this.gbxEkle.PerformLayout();
            this.gbxSil.ResumeLayout(false);
            this.gbxSil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwSql;
        private System.Windows.Forms.GroupBox gbxGuncelle;
        private System.Windows.Forms.Label lblGuncelleId;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox tbxGuncelleId;
        private System.Windows.Forms.TextBox tbxGuncelleAciklama;
        private System.Windows.Forms.TextBox tbxGuncelleSayac;
        private System.Windows.Forms.Label lblGuncelleKelime;
        private System.Windows.Forms.Label lblGuncelleSayac;
        private System.Windows.Forms.TextBox tbxGuncelleKelime;
        private System.Windows.Forms.Label lblGuncelleAciklama;
        private System.Windows.Forms.GroupBox gbxEkle;
        private System.Windows.Forms.Label lblEkleId;
        private System.Windows.Forms.TextBox tbxEkleId;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox tbxEkleAciklama;
        private System.Windows.Forms.TextBox tbxEkleSayac;
        private System.Windows.Forms.Label lblEkleKelime;
        private System.Windows.Forms.Label lblEkleSayac;
        private System.Windows.Forms.TextBox tbxEkleKelime;
        private System.Windows.Forms.Label lblEkleAciklama;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.GroupBox gbxSil;
        private System.Windows.Forms.Label lblSilId;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox tbxSilId;
        private System.Windows.Forms.TextBox tbxSilAciklama;
        private System.Windows.Forms.TextBox tbxSilSayac;
        private System.Windows.Forms.Label lblSilKelime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxSilKelime;
        private System.Windows.Forms.Label lblSilAciklama;
        private System.Windows.Forms.Button btnHepsiniSil;
        private System.Windows.Forms.Button btnSecilenler;
        private System.Windows.Forms.Button btnSelenium;
        private System.Windows.Forms.Label lblSQLBaslik;
        private System.Windows.Forms.TextBox tbxIdIlk;
        private System.Windows.Forms.Label lblIdSil;
        private System.Windows.Forms.TextBox tbxIdIkinci;
        private System.Windows.Forms.Label lblIle;
        private System.Windows.Forms.Button btnAraligindaSil;
        private System.Windows.Forms.Button btnAdArtan;
        private System.Windows.Forms.Button btnAdAzalan;
        private System.Windows.Forms.Button btnSayacArtan;
        private System.Windows.Forms.Button btnSayacAzalan;
        private System.Windows.Forms.Label lblSayacSirala;
        private System.Windows.Forms.Label lblAdSirala;
        private System.Windows.Forms.Label lblIdSirala;
        private System.Windows.Forms.Button btnIdAzalan;
        private System.Windows.Forms.Button btnIdArtan;
        private System.Windows.Forms.Label lblAciklamaSirala;
        private System.Windows.Forms.Button btnAciklamaAzalan;
        private System.Windows.Forms.Button btnAciklamaArtan;
        private System.Windows.Forms.Label lblSatirNo;
        private System.Windows.Forms.Button btnSatirAzalan;
        private System.Windows.Forms.Button btnSatirArtan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SatirNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn KelimeIngilizce;
        private System.Windows.Forms.DataGridViewTextBoxColumn Aciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sayac;
    }
}
