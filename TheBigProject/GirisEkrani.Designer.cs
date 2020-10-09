namespace TheBigProject
{
    partial class GirisEkrani
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisEkrani));
            this.panelSol = new System.Windows.Forms.Panel();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.btnEgzersiz = new System.Windows.Forms.Button();
            this.btnSql = new System.Windows.Forms.Button();
            this.btnAnaliz = new System.Windows.Forms.Button();
            this.btnAnaSayfa = new System.Windows.Forms.Button();
            this.panelSayfalar = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureTranslate = new System.Windows.Forms.PictureBox();
            this.pictureSql = new System.Windows.Forms.PictureBox();
            this.pictureAnaliz = new System.Windows.Forms.PictureBox();
            this.pictureAnaSayfa = new System.Windows.Forms.PictureBox();
            this.panelSol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTranslate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSql)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAnaliz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAnaSayfa)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSol
            // 
            this.panelSol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panelSol.Controls.Add(this.pictureBox4);
            this.panelSol.Controls.Add(this.pictureTranslate);
            this.panelSol.Controls.Add(this.pictureSql);
            this.panelSol.Controls.Add(this.pictureAnaliz);
            this.panelSol.Controls.Add(this.pictureAnaSayfa);
            this.panelSol.Controls.Add(this.buttonPanel);
            this.panelSol.Controls.Add(this.btnEgzersiz);
            this.panelSol.Controls.Add(this.btnSql);
            this.panelSol.Controls.Add(this.btnAnaliz);
            this.panelSol.Controls.Add(this.btnAnaSayfa);
            this.panelSol.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSol.Location = new System.Drawing.Point(0, 0);
            this.panelSol.Margin = new System.Windows.Forms.Padding(0);
            this.panelSol.Name = "panelSol";
            this.panelSol.Size = new System.Drawing.Size(157, 687);
            this.panelSol.TabIndex = 22;
            // 
            // buttonPanel
            // 
            this.buttonPanel.BackColor = System.Drawing.Color.Tomato;
            this.buttonPanel.Location = new System.Drawing.Point(0, 85);
            this.buttonPanel.Margin = new System.Windows.Forms.Padding(0);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(11, 45);
            this.buttonPanel.TabIndex = 24;
            // 
            // btnEgzersiz
            // 
            this.btnEgzersiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnEgzersiz.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEgzersiz.FlatAppearance.BorderSize = 0;
            this.btnEgzersiz.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.btnEgzersiz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.btnEgzersiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEgzersiz.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEgzersiz.ForeColor = System.Drawing.Color.Green;
            this.btnEgzersiz.Location = new System.Drawing.Point(46, 238);
            this.btnEgzersiz.Margin = new System.Windows.Forms.Padding(1);
            this.btnEgzersiz.Name = "btnEgzersiz";
            this.btnEgzersiz.Size = new System.Drawing.Size(110, 45);
            this.btnEgzersiz.TabIndex = 26;
            this.btnEgzersiz.Text = "Egzersiz";
            this.btnEgzersiz.UseVisualStyleBackColor = false;
            this.btnEgzersiz.Click += new System.EventHandler(this.btnEkstra_Click);
            // 
            // btnSql
            // 
            this.btnSql.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnSql.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSql.FlatAppearance.BorderSize = 0;
            this.btnSql.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.btnSql.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.btnSql.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSql.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSql.ForeColor = System.Drawing.Color.Blue;
            this.btnSql.Location = new System.Drawing.Point(46, 187);
            this.btnSql.Margin = new System.Windows.Forms.Padding(1);
            this.btnSql.Name = "btnSql";
            this.btnSql.Size = new System.Drawing.Size(110, 45);
            this.btnSql.TabIndex = 25;
            this.btnSql.Text = "Veri Tabanı";
            this.btnSql.UseVisualStyleBackColor = false;
            this.btnSql.Click += new System.EventHandler(this.btnSql_Click);
            // 
            // btnAnaliz
            // 
            this.btnAnaliz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnAnaliz.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAnaliz.FlatAppearance.BorderSize = 0;
            this.btnAnaliz.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.btnAnaliz.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.btnAnaliz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnaliz.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaliz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAnaliz.Location = new System.Drawing.Point(46, 136);
            this.btnAnaliz.Margin = new System.Windows.Forms.Padding(1);
            this.btnAnaliz.Name = "btnAnaliz";
            this.btnAnaliz.Size = new System.Drawing.Size(110, 45);
            this.btnAnaliz.TabIndex = 24;
            this.btnAnaliz.Text = "Analiz";
            this.btnAnaliz.UseVisualStyleBackColor = false;
            this.btnAnaliz.Click += new System.EventHandler(this.btnAnaliz_Click);
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnAnaSayfa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAnaSayfa.FlatAppearance.BorderSize = 0;
            this.btnAnaSayfa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.btnAnaSayfa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCyan;
            this.btnAnaSayfa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnaSayfa.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnaSayfa.ForeColor = System.Drawing.Color.LightSalmon;
            this.btnAnaSayfa.Location = new System.Drawing.Point(46, 85);
            this.btnAnaSayfa.Margin = new System.Windows.Forms.Padding(1);
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            this.btnAnaSayfa.Size = new System.Drawing.Size(110, 45);
            this.btnAnaSayfa.TabIndex = 23;
            this.btnAnaSayfa.Text = "Ana Sayfa";
            this.btnAnaSayfa.UseVisualStyleBackColor = false;
            this.btnAnaSayfa.Click += new System.EventHandler(this.btnAnaSayfa_Click);
            // 
            // panelSayfalar
            // 
            this.panelSayfalar.AutoSize = true;
            this.panelSayfalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSayfalar.Location = new System.Drawing.Point(157, 0);
            this.panelSayfalar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelSayfalar.Name = "panelSayfalar";
            this.panelSayfalar.Size = new System.Drawing.Size(998, 687);
            this.panelSayfalar.TabIndex = 24;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::TheBigProject.Properties.Resources.english;
            this.pictureBox4.Location = new System.Drawing.Point(19, 10);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(118, 64);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // pictureTranslate
            // 
            this.pictureTranslate.Image = global::TheBigProject.Properties.Resources.memorize__1_;
            this.pictureTranslate.Location = new System.Drawing.Point(9, 235);
            this.pictureTranslate.Margin = new System.Windows.Forms.Padding(2);
            this.pictureTranslate.Name = "pictureTranslate";
            this.pictureTranslate.Size = new System.Drawing.Size(38, 45);
            this.pictureTranslate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureTranslate.TabIndex = 29;
            this.pictureTranslate.TabStop = false;
            // 
            // pictureSql
            // 
            this.pictureSql.Image = global::TheBigProject.Properties.Resources.database__1_;
            this.pictureSql.Location = new System.Drawing.Point(9, 187);
            this.pictureSql.Margin = new System.Windows.Forms.Padding(2);
            this.pictureSql.Name = "pictureSql";
            this.pictureSql.Size = new System.Drawing.Size(38, 45);
            this.pictureSql.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSql.TabIndex = 28;
            this.pictureSql.TabStop = false;
            // 
            // pictureAnaliz
            // 
            this.pictureAnaliz.Image = global::TheBigProject.Properties.Resources.data__1_;
            this.pictureAnaliz.Location = new System.Drawing.Point(9, 136);
            this.pictureAnaliz.Margin = new System.Windows.Forms.Padding(2);
            this.pictureAnaliz.Name = "pictureAnaliz";
            this.pictureAnaliz.Size = new System.Drawing.Size(38, 45);
            this.pictureAnaliz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureAnaliz.TabIndex = 27;
            this.pictureAnaliz.TabStop = false;
            // 
            // pictureAnaSayfa
            // 
            this.pictureAnaSayfa.Image = global::TheBigProject.Properties.Resources.house;
            this.pictureAnaSayfa.Location = new System.Drawing.Point(9, 85);
            this.pictureAnaSayfa.Margin = new System.Windows.Forms.Padding(2);
            this.pictureAnaSayfa.Name = "pictureAnaSayfa";
            this.pictureAnaSayfa.Size = new System.Drawing.Size(38, 45);
            this.pictureAnaSayfa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureAnaSayfa.TabIndex = 0;
            this.pictureAnaSayfa.TabStop = false;
            // 
            // GirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(1155, 687);
            this.Controls.Add(this.panelSayfalar);
            this.Controls.Add(this.panelSol);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(1878, 2038);
            this.Name = "GirisEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnglishHelper";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GirisEkrani_Load);
            this.panelSol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureTranslate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSql)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAnaliz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAnaSayfa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelSol;
        private System.Windows.Forms.Button btnAnaSayfa;
        private System.Windows.Forms.Button btnEgzersiz;
        private System.Windows.Forms.Button btnSql;
        private System.Windows.Forms.Button btnAnaliz;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Panel panelSayfalar;
        private System.Windows.Forms.PictureBox pictureAnaSayfa;
        private System.Windows.Forms.PictureBox pictureTranslate;
        private System.Windows.Forms.PictureBox pictureSql;
        private System.Windows.Forms.PictureBox pictureAnaliz;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

