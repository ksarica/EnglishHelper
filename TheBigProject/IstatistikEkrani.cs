using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheBigProject
{
    public partial class IstatistikEkrani : Form
    {
        // birden fazla aynı form açılmaması için singleton patterni

        private static IstatistikEkrani instance;
        public static IstatistikEkrani GetForm
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                    instance = new IstatistikEkrani();
                return instance;
            }
        }

        // Default Constructor ************************************************
        public IstatistikEkrani()
        {
            InitializeComponent();
        }

        // ********************************************************************

        // Overloaded Constructor *********************************************
        public IstatistikEkrani(Dictionary<string, int> kelimeler)
        {
            InitializeComponent(); // zorunlu method

            dgwSonuc.Rows.Clear(); // çağrılırken veriler silinip çağrılıyor
            int satirNo;

            int sayac = 0;
            lblFarkliDeger.Text = kelimeler.Keys.Count.ToString();
            foreach (KeyValuePair<string, int> veri in kelimeler)  // key = string , value = int bu dictionary için
            {
                sayac += veri.Value; // toplam eleman sayısını hesaplıyoruz
            }
            lblToplamDeger.Text = sayac.ToString(); // formda toplam eleman sayısını gösteriyoruz

            // tabloya ilgili sonuca göre gelen kelime pairlerinin gösterilmesi
            foreach (KeyValuePair<string, int> veri in kelimeler)
            {
                satirNo = dgwSonuc.Rows.Add(); // dataGridView1.Rows.Add(4); // limit koyabiliyorsun koymazsan ekler sürekli
                dgwSonuc.Rows[satirNo].Cells[1].Value = veri.Key;
                dgwSonuc.Rows[satirNo].Cells[2].Value = veri.Value;
            }

            //this.dataGridView1.Sort(this.dataGridView1.Columns["Kelime"], ListSortDirection.Ascending);
            this.dgwSonuc.Sort(this.dgwSonuc.Columns["Miktarı"], ListSortDirection.Descending); // hangi kelimeden en çok varsa o en üstte gözükecek.

            int numaralandirma = 1; // görünüm için kelimelerin numaralandırılması.
            foreach (DataGridViewRow row in dgwSonuc.Rows)
            {
                row.Cells[0].Value = numaralandirma;
                numaralandirma++;
            }
        }
        // *********************************************************************************************

        private void IstatistikEkrani_Load(object sender, EventArgs e)
        {
            // ekran yüklendiğinde yapılacak bir eylem şuanlık yok
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            // tüm değerleri eski haline döndürür
            dgwSonuc.Rows.Clear();
            lblFarkliDeger.Text = "0";
            lblToplamDeger.Text = "0";
        }

        // ********************************************************************************************
        //  ---------------------    Veritabanı Button Eventleri (Sağ Menü)    ---------------------
        // ********************************************************************************************

        // ***  Tablodaki tum elemanları database 'e ekler.
        private void btnTum_Click(object sender, EventArgs e)
        {
            KelimeHavuzuDal _kelimeDal = new KelimeHavuzuDal();
            foreach (DataGridViewRow row in dgwSonuc.Rows)
            {
                if (Convert.ToInt32(row.Cells["Miktarı"].Value) > 0 && (row.Cells["Kelime"].Value).ToString().Length > 1) // saçma kelime kaydetmemek için ct si 0 olan ve kelime uzunluğu 2 den küçük olan kelimeler eklenmeyecek
                {
                    _kelimeDal.Ekle(new KelimeHavuzu
                    {
                        // id eklemiyorum SQL otomatik atıyor.
                        KelimeIngilizce = OzelFonksiyonlar.ToLowerIngilizce(row.Cells["Kelime"].Value.ToString()),
                        Aciklama = "",
                        Sayac = Convert.ToInt32(row.Cells["Miktarı"].Value)
                    });
                }
            }
            MessageBox.Show("Kelimeler Eklendi ! Veritabanı Bölümünden Yenile Butonuna Basarak Görüntüleyebilirsiniz.");
        }

        // *** mouse ile seçilen elemanları ekler
        private void btnSecilenler_Click(object sender, EventArgs e)
        {
            KelimeHavuzuDal _kelimeDal = new KelimeHavuzuDal();
            DataGridViewSelectedRowCollection selectedRows = dgwSonuc.SelectedRows;
            for (int i = selectedRows.Count - 1; i >= 0; i--)
            {
                if (Convert.ToInt32(selectedRows.Count) > 0 && (selectedRows[i].Cells["Kelime"].Value).ToString().Length > 1) // saçma kelime kaydetmemek için ct si 0 olan ve kelime uzunluğu 2 den küçük olan kelimeler eklenmeyecek
                {
                    _kelimeDal.Ekle(new KelimeHavuzu
                    {
                        KelimeIngilizce = OzelFonksiyonlar.ToLowerIngilizce(selectedRows[i].Cells["Kelime"].Value.ToString()),
                        Aciklama = "",
                        Sayac = Convert.ToInt32(selectedRows[i].Cells["Miktarı"].Value)
                    });
                }
            }
            MessageBox.Show("Kelimeler Eklendi ! Veritabanı Bölümünden Yenile Butonuna Basarak Görüntüleyebilirsiniz.");
        }

        // *** en üstten 20 elemani ekler
        private void btnUstten_Click(object sender, EventArgs e)
        {
            int satirSayisi = dgwSonuc.RowCount;
            KelimeHavuzuDal _kelimeDal = new KelimeHavuzuDal();
            if (satirSayisi >= 20)
            {
                for (int indeks = 0; indeks < 20; indeks++)
                {
                    if (Convert.ToInt32(dgwSonuc.Rows[indeks].Cells["Miktarı"].Value) > 0 && (dgwSonuc.Rows[indeks].Cells["Kelime"].Value).ToString().Length > 1) // saçma kelime kaydetmemek için ct si 0 olan ve kelime uzunluğu 2 den küçük olan kelimeler eklenmeyecek
                    {
                        _kelimeDal.Ekle(new KelimeHavuzu
                        {
                            KelimeIngilizce = OzelFonksiyonlar.ToLowerIngilizce(dgwSonuc.Rows[indeks].Cells["Kelime"].Value.ToString()),
                            Aciklama = "",
                            Sayac = Convert.ToInt32(dgwSonuc.Rows[indeks].Cells["Miktarı"].Value)
                        });
                    }
                }
                MessageBox.Show("Kelimeler Eklendi ! Veritabanı Bölümünden Yenile Butonuna Basarak Görüntüleyebilirsiniz.");
            }
            else
            {
                MessageBox.Show("Satır Sayısı 20 den az !");
            }
        }

        // *** en alttan 20 elemani ekler
        private void btnAlttan_Click(object sender, EventArgs e)
        {
            int satirSayisi = dgwSonuc.RowCount;
            KelimeHavuzuDal _kelimeDal = new KelimeHavuzuDal();
            if (satirSayisi >= 20)
            {
                for (int indeks = satirSayisi - 1; indeks >= (satirSayisi - 20); indeks--)
                {
                    if (Convert.ToInt32(dgwSonuc.Rows[indeks].Cells["Miktarı"].Value) > 0 && (dgwSonuc.Rows[indeks].Cells["Kelime"].Value).ToString().Length > 1) // saçma kelime kaydetmemek için ct si 0 olan ve kelime uzunluğu 2 den küçük olan kelimeler eklenmeyecek
                    {
                        _kelimeDal.Ekle(new KelimeHavuzu
                        {
                            KelimeIngilizce = OzelFonksiyonlar.ToLowerIngilizce(dgwSonuc.Rows[indeks].Cells["Kelime"].Value.ToString()),
                            Aciklama = "",
                            Sayac = Convert.ToInt32(dgwSonuc.Rows[indeks].Cells["Miktarı"].Value)
                        });
                    }
                }
                MessageBox.Show("Kelimeler Eklendi ! Veritabanı Bölümünden Yenile Butonuna Basarak Görüntüleyebilirsiniz.");
            }
            else
            {
                MessageBox.Show("Satır Sayısı 20 den az !");
            }
        }
    }
}
