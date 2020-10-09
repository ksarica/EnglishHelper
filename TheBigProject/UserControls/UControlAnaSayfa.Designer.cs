namespace TheBigProject
{
    partial class UControlAnaSayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UControlAnaSayfa));
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.lblDeveloper = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Franklin Gothic Medium", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblBaslik.Location = new System.Drawing.Point(497, 28);
            this.lblBaslik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(387, 61);
            this.lblBaslik.TabIndex = 1;
            this.lblBaslik.Text = "ENGLISH HELPER";
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCopyright.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblCopyright.Location = new System.Drawing.Point(408, 793);
            this.lblCopyright.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(603, 21);
            this.lblCopyright.TabIndex = 2;
            this.lblCopyright.Text = "Icons made by surang, Smashicons, Freepik, monkik, Phatplus from www.flaticon.com" +
    "";
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Font = new System.Drawing.Font("Franklin Gothic Medium", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAciklama.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.lblAciklama.Location = new System.Drawing.Point(242, 194);
            this.lblAciklama.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(911, 208);
            this.lblAciklama.TabIndex = 3;
            this.lblAciklama.Text = resources.GetString("lblAciklama.Text");
            // 
            // lblDeveloper
            // 
            this.lblDeveloper.AutoSize = true;
            this.lblDeveloper.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDeveloper.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblDeveloper.Location = new System.Drawing.Point(560, 756);
            this.lblDeveloper.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDeveloper.Name = "lblDeveloper";
            this.lblDeveloper.Size = new System.Drawing.Size(273, 21);
            this.lblDeveloper.TabIndex = 4;
            this.lblDeveloper.Text = "KAAN SARICA - srca.kaan@gmail.com";
            this.lblDeveloper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UControlAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(36)))), ((int)(((byte)(70)))));
            this.Controls.Add(this.lblDeveloper);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.lblBaslik);
            this.Name = "UControlAnaSayfa";
            this.Size = new System.Drawing.Size(1383, 845);
            this.Load += new System.EventHandler(this.UControlAnaSayfa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Label lblDeveloper;
    }
}
