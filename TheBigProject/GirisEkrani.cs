using System.Collections.Generic;
using System;
using System.Windows.Forms;
using TheBigProject.UserControls;

namespace TheBigProject
{
    public partial class GirisEkrani : Form
    {
        static GirisEkrani _obje;
        public GirisEkrani()
        {
            InitializeComponent();
        }

        public static GirisEkrani Instance
        {
            get
            {
                if (_obje == null)
                {
                    _obje = new GirisEkrani();
                }
                return _obje;
            }
        }

        public Panel PnlSayfalar // buttonlara basıldığında değişen ekranlar
        {
            get { return panelSayfalar; }
            set { panelSayfalar = value; }
        }

        public Panel PnlButton // hangi sayfanın açık olduğunu gösteren sembolik gösterge butonu
        {
            get { return buttonPanel; }
            set { buttonPanel = value; }
        }

        public Panel PnlSol // soldaki siyah butonların olduğu panel
        {
            get { return panelSol; }
            set { panelSol = value; }
        }

        public Button BtnEgzersiz // egzersiz butonu instance' i
        {
            get { return btnEgzersiz; }
            set { btnEgzersiz = value; }
        }

        private void GirisEkrani_Load(object sender, EventArgs e)
        {
            UControlAnaSayfa girisEkrani = new UControlAnaSayfa();
            girisEkrani.Dock = DockStyle.Fill;
            PnlSayfalar.Controls.Add(girisEkrani); // açılış ekrani yuklemesi

            buttonPanel.Height = btnAnaSayfa.Height; // gösterge butonunun anasayfayı göstermesi
            buttonPanel.Top = btnAnaSayfa.Top;
            _obje = this; // ref atanınca ekran yükleniyor
        }


        // ********************************************************************************************
        // ----------------------------     Button Eventleri     --------------------------------
        // ********************************************************************************************

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            if (!GirisEkrani.Instance.PnlSayfalar.Controls.ContainsKey("UControlAnaSayfa")) // hiç çağrılmadıysa oluştur, oluşturulduysa aşağıda diğer panellerin önüne al
            {
                UControlAnaSayfa uControlAnaSayfa = new UControlAnaSayfa();
                uControlAnaSayfa.Dock = DockStyle.Fill;
                GirisEkrani.Instance.PnlSayfalar.Controls.Add(uControlAnaSayfa);
            }

            GirisEkrani.Instance.PnlSayfalar.Controls["UControlAnaSayfa"].BringToFront();
            buttonPanel.Height = btnAnaSayfa.Height;
            buttonPanel.Top = btnAnaSayfa.Top;
        }

        private void btnAnaliz_Click(object sender, EventArgs e)
        {
            if (!GirisEkrani.Instance.PnlSayfalar.Controls.ContainsKey("UControlAnaliz"))
            {
                UControlAnaliz uControlAnaliz = new UControlAnaliz();
                uControlAnaliz.Dock = DockStyle.Fill;
                GirisEkrani.Instance.PnlSayfalar.Controls.Add(uControlAnaliz);
            }

            GirisEkrani.Instance.PnlSayfalar.Controls["UControlAnaliz"].BringToFront();
            buttonPanel.Height = btnAnaliz.Height;
            buttonPanel.Top = btnAnaliz.Top;
        }

        private void btnSql_Click(object sender, EventArgs e)
        {
            if (!GirisEkrani.Instance.PnlSayfalar.Controls.ContainsKey("UControlSql"))
            {
                UControlSql uControlSql = new UControlSql();
                uControlSql.Dock = DockStyle.Fill;
                GirisEkrani.Instance.PnlSayfalar.Controls.Add(uControlSql);
            }
            GirisEkrani.Instance.PnlSayfalar.Controls["UControlSql"].BringToFront();

            buttonPanel.Height = btnSql.Height;
            buttonPanel.Top = btnSql.Top;
        }

        private void btnEkstra_Click(object sender, EventArgs e)
        {
            KelimeHavuzuDal kelimeHavuzuDal = new KelimeHavuzuDal();
            List<KelimeHavuzu> kelimeler = kelimeHavuzuDal.HepsiniGetir();
            if (!GirisEkrani.Instance.PnlSayfalar.Controls.ContainsKey("UControlEkstra"))
            {
                UControlEkstra uControlEkstra = new UControlEkstra();
                uControlEkstra.Dock = DockStyle.Fill;
                GirisEkrani.Instance.PnlSayfalar.Controls.Add(uControlEkstra);
            }
            GirisEkrani.Instance.PnlSayfalar.Controls["UControlEkstra"].BringToFront();

            buttonPanel.Height = btnEgzersiz.Height;
            buttonPanel.Top = btnEgzersiz.Top;
        }
    }
}