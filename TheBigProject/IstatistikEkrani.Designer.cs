namespace TheBigProject
{
    partial class IstatistikEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IstatistikEkrani));
            this.dgwSonuc = new System.Windows.Forms.DataGridView();
            this.SatırNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kelime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miktarı = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.btnSecilenler = new System.Windows.Forms.Button();
            this.lblVeriTabani = new System.Windows.Forms.Label();
            this.lblSecenek = new System.Windows.Forms.Label();
            this.btnAlttan = new System.Windows.Forms.Button();
            this.btnUstten = new System.Windows.Forms.Button();
            this.btnTum = new System.Windows.Forms.Button();
            this.lblFarkliBaslik = new System.Windows.Forms.Label();
            this.lblFarkliDeger = new System.Windows.Forms.Label();
            this.lblToplamBaslik = new System.Windows.Forms.Label();
            this.lblToplamDeger = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSonuc)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwSonuc
            // 
            this.dgwSonuc.AllowUserToAddRows = false;
            this.dgwSonuc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.dgwSonuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSonuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SatırNo,
            this.Kelime,
            this.Miktarı});
            this.dgwSonuc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(40)))));
            this.dgwSonuc.Location = new System.Drawing.Point(12, 74);
            this.dgwSonuc.Name = "dgwSonuc";
            this.dgwSonuc.ReadOnly = true;
            this.dgwSonuc.Size = new System.Drawing.Size(548, 250);
            this.dgwSonuc.TabIndex = 0;
            // 
            // SatırNo
            // 
            this.SatırNo.HeaderText = "SatırNo";
            this.SatırNo.Name = "SatırNo";
            this.SatırNo.ReadOnly = true;
            // 
            // Kelime
            // 
            this.Kelime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Kelime.HeaderText = "Kelime";
            this.Kelime.Name = "Kelime";
            this.Kelime.ReadOnly = true;
            // 
            // Miktarı
            // 
            this.Miktarı.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Miktarı.HeaderText = "Miktarı";
            this.Miktarı.Name = "Miktarı";
            this.Miktarı.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(41)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.lblAciklama);
            this.panel1.Controls.Add(this.btnSecilenler);
            this.panel1.Controls.Add(this.lblVeriTabani);
            this.panel1.Controls.Add(this.lblSecenek);
            this.panel1.Controls.Add(this.btnAlttan);
            this.panel1.Controls.Add(this.btnUstten);
            this.panel1.Controls.Add(this.btnTum);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(574, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 336);
            this.panel1.TabIndex = 12;
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAciklama.ForeColor = System.Drawing.Color.Snow;
            this.lblAciklama.Location = new System.Drawing.Point(23, 47);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(208, 72);
            this.lblAciklama.TabIndex = 18;
            this.lblAciklama.Text = "Aşağıdaki seçeneklerden birini\r\nseçin. Teker teker kelime seçmek \r\niçin hücrelere" +
    " CTRL + SOL TIK \r\nuygulayın.";
            // 
            // btnSecilenler
            // 
            this.btnSecilenler.BackColor = System.Drawing.Color.Transparent;
            this.btnSecilenler.FlatAppearance.BorderSize = 0;
            this.btnSecilenler.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnSecilenler.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSecilenler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecilenler.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSecilenler.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSecilenler.Location = new System.Drawing.Point(3, 198);
            this.btnSecilenler.Margin = new System.Windows.Forms.Padding(0);
            this.btnSecilenler.Name = "btnSecilenler";
            this.btnSecilenler.Size = new System.Drawing.Size(238, 30);
            this.btnSecilenler.TabIndex = 17;
            this.btnSecilenler.Text = "Seçili Olanlar";
            this.btnSecilenler.UseVisualStyleBackColor = false;
            this.btnSecilenler.Click += new System.EventHandler(this.btnSecilenler_Click);
            // 
            // lblVeriTabani
            // 
            this.lblVeriTabani.AutoSize = true;
            this.lblVeriTabani.Font = new System.Drawing.Font("Franklin Gothic Medium", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVeriTabani.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lblVeriTabani.Location = new System.Drawing.Point(37, 7);
            this.lblVeriTabani.Name = "lblVeriTabani";
            this.lblVeriTabani.Size = new System.Drawing.Size(175, 24);
            this.lblVeriTabani.TabIndex = 16;
            this.lblVeriTabani.Text = "Veritabanına Kaydet";
            // 
            // lblSecenek
            // 
            this.lblSecenek.AutoSize = true;
            this.lblSecenek.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSecenek.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lblSecenek.Location = new System.Drawing.Point(56, 128);
            this.lblSecenek.Name = "lblSecenek";
            this.lblSecenek.Size = new System.Drawing.Size(146, 21);
            this.lblSecenek.TabIndex = 13;
            this.lblSecenek.Text = "Ekleme Seçenekleri";
            // 
            // btnAlttan
            // 
            this.btnAlttan.BackColor = System.Drawing.Color.Transparent;
            this.btnAlttan.FlatAppearance.BorderSize = 0;
            this.btnAlttan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnAlttan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAlttan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlttan.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAlttan.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAlttan.Location = new System.Drawing.Point(3, 258);
            this.btnAlttan.Margin = new System.Windows.Forms.Padding(0);
            this.btnAlttan.Name = "btnAlttan";
            this.btnAlttan.Size = new System.Drawing.Size(238, 30);
            this.btnAlttan.TabIndex = 15;
            this.btnAlttan.Text = "Alttan 20 Tanesi";
            this.btnAlttan.UseVisualStyleBackColor = false;
            this.btnAlttan.Click += new System.EventHandler(this.btnAlttan_Click);
            // 
            // btnUstten
            // 
            this.btnUstten.BackColor = System.Drawing.Color.Transparent;
            this.btnUstten.FlatAppearance.BorderSize = 0;
            this.btnUstten.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnUstten.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUstten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUstten.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUstten.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUstten.Location = new System.Drawing.Point(3, 228);
            this.btnUstten.Margin = new System.Windows.Forms.Padding(0);
            this.btnUstten.Name = "btnUstten";
            this.btnUstten.Size = new System.Drawing.Size(238, 30);
            this.btnUstten.TabIndex = 14;
            this.btnUstten.Text = "Üstten 20 Tanesi";
            this.btnUstten.UseVisualStyleBackColor = false;
            this.btnUstten.Click += new System.EventHandler(this.btnUstten_Click);
            // 
            // btnTum
            // 
            this.btnTum.BackColor = System.Drawing.Color.Transparent;
            this.btnTum.FlatAppearance.BorderSize = 0;
            this.btnTum.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnTum.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTum.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTum.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTum.Location = new System.Drawing.Point(3, 168);
            this.btnTum.Margin = new System.Windows.Forms.Padding(0);
            this.btnTum.Name = "btnTum";
            this.btnTum.Size = new System.Drawing.Size(238, 30);
            this.btnTum.TabIndex = 13;
            this.btnTum.Text = "Tüm Elemanlar";
            this.btnTum.UseVisualStyleBackColor = false;
            this.btnTum.Click += new System.EventHandler(this.btnTum_Click);
            // 
            // lblFarkliBaslik
            // 
            this.lblFarkliBaslik.AutoSize = true;
            this.lblFarkliBaslik.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFarkliBaslik.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lblFarkliBaslik.Location = new System.Drawing.Point(28, 47);
            this.lblFarkliBaslik.Name = "lblFarkliBaslik";
            this.lblFarkliBaslik.Size = new System.Drawing.Size(175, 21);
            this.lblFarkliBaslik.TabIndex = 8;
            this.lblFarkliBaslik.Text = "Farklı Eleman Sayısı:";
            // 
            // lblFarkliDeger
            // 
            this.lblFarkliDeger.AutoSize = true;
            this.lblFarkliDeger.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFarkliDeger.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lblFarkliDeger.Location = new System.Drawing.Point(196, 47);
            this.lblFarkliDeger.Name = "lblFarkliDeger";
            this.lblFarkliDeger.Size = new System.Drawing.Size(20, 21);
            this.lblFarkliDeger.TabIndex = 10;
            this.lblFarkliDeger.Text = "0";
            // 
            // lblToplamBaslik
            // 
            this.lblToplamBaslik.AutoSize = true;
            this.lblToplamBaslik.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamBaslik.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lblToplamBaslik.Location = new System.Drawing.Point(272, 46);
            this.lblToplamBaslik.Name = "lblToplamBaslik";
            this.lblToplamBaslik.Size = new System.Drawing.Size(134, 21);
            this.lblToplamBaslik.TabIndex = 9;
            this.lblToplamBaslik.Text = "Toplam Eleman:";
            // 
            // lblToplamDeger
            // 
            this.lblToplamDeger.AutoSize = true;
            this.lblToplamDeger.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamDeger.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lblToplamDeger.Location = new System.Drawing.Point(409, 47);
            this.lblToplamDeger.Name = "lblToplamDeger";
            this.lblToplamDeger.Size = new System.Drawing.Size(20, 21);
            this.lblToplamDeger.TabIndex = 11;
            this.lblToplamDeger.Text = "0";
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.Transparent;
            this.btnTemizle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnTemizle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTemizle.Location = new System.Drawing.Point(486, 43);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(74, 30);
            this.btnTemizle.TabIndex = 1;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // IstatistikEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(75)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(815, 336);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblToplamDeger);
            this.Controls.Add(this.lblFarkliDeger);
            this.Controls.Add(this.lblToplamBaslik);
            this.Controls.Add(this.lblFarkliBaslik);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.dgwSonuc);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(250, 250);
            this.Name = "IstatistikEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "IstatistikEkrani";
            this.Load += new System.EventHandler(this.IstatistikEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSonuc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dgwSonuc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFarkliBaslik;
        private System.Windows.Forms.Label lblFarkliDeger;
        private System.Windows.Forms.Label lblToplamBaslik;
        private System.Windows.Forms.Label lblToplamDeger;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnAlttan;
        private System.Windows.Forms.Button btnUstten;
        private System.Windows.Forms.Button btnTum;
        private System.Windows.Forms.Label lblVeriTabani;
        private System.Windows.Forms.Label lblSecenek;
        private System.Windows.Forms.Button btnSecilenler;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.DataGridViewTextBoxColumn SatırNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kelime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miktarı;
    }
}