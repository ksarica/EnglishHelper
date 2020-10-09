using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace TheBigProject
{
    public partial class UControlSql : UserControl
    {
        public UControlSql()
        {
            InitializeComponent();
            KelimeleriAktar();
        }
        KelimeHavuzuDal _kelimeDal = new KelimeHavuzuDal();
        private void UControlSql_Load(object sender, EventArgs e)
        {

        }

        public void KelimeleriAktar()
        {
            //dgwSql.DataSource = _kelimeDal.HepsiniGetir();

            // COLUMNLAR = SatırNo[0] | Id[1] | KelimeIngilizce[2] | Aciklama[3] | Sayac[4]

            dgwSql.Rows.Clear();
            int satirNo;
            List<KelimeHavuzu> dbKelimeler = new List<KelimeHavuzu>();

            try
            {
                dbKelimeler = _kelimeDal.HepsiniGetir();
            }
            catch (Exception)
            {
                MessageBox.Show("Veritabanına Bağlanılamadı ! Lütfen Programın Diğer Bölümlerini Kullanın !");
            }

            foreach (var eleman in dbKelimeler)
            {
                satirNo = dgwSql.Rows.Add();
                dgwSql.Rows[satirNo].Cells[1].Value = eleman.Id;
                dgwSql.Rows[satirNo].Cells[2].Value = eleman.KelimeIngilizce;
                dgwSql.Rows[satirNo].Cells[3].Value = eleman.Aciklama;
                dgwSql.Rows[satirNo].Cells[4].Value = eleman.Sayac;
            }

            this.dgwSql.Sort(this.dgwSql.Columns[4], ListSortDirection.Descending); // hangi kelimeden en çok varsa o en üstte gözükecek.

            int numaralandirma = 1; // görünüm için kelimelerin numaralandırılması.
            foreach (DataGridViewRow row in dgwSql.Rows)
            {
                row.Cells[0].Value = numaralandirma;
                numaralandirma++;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            _kelimeDal.Ekle(new KelimeHavuzu
            {
                KelimeIngilizce = OzelFonksiyonlar.ToLowerIngilizce(tbxEkleKelime.Text),
                Aciklama = OzelFonksiyonlar.ToLowerIngilizce(tbxEkleAciklama.Text),
                Sayac = 1
            });
            KelimeleriAktar();
            MessageBox.Show("Kelime Eklendi!");
            tbxEkleKelime.Clear();
            tbxEkleAciklama.Clear();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwSql.CurrentRow.Cells[1].Value);
            _kelimeDal.Sil(id);
            KelimeleriAktar();
            MessageBox.Show("Kayıt Başarıyla Silindi !");
        }

        private void btnSecilenler_Click(object sender, EventArgs e)
        {
            if (dgwSql.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Seçilen Eleman Yok ya da Elemanlar Tamamen Seçilmedi ! Lütfen SatirNo nun Solundaki Hücreye Tıklayarak Seçin");
                return;
            }
            foreach (DataGridViewRow row in dgwSql.SelectedRows)
            {
                int id = Convert.ToInt32(row.Cells[1].Value);
                _kelimeDal.Sil(id);
            }
            KelimeleriAktar();
            MessageBox.Show("Kayıt(lar) Başarıyla Silindi !");
        }

        private void btnHepsiniSil_Click(object sender, EventArgs e)
        {
            _kelimeDal.HepsiniSil();
            KelimeleriAktar();
            MessageBox.Show("Tüm veriler veritabanından silindi ! ");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            KelimeHavuzu kelime = new KelimeHavuzu
            {
                Id = Convert.ToInt32(dgwSql.CurrentRow.Cells[1].Value),
                KelimeIngilizce = OzelFonksiyonlar.ToLowerTurkce(tbxGuncelleKelime.Text),
                Aciklama = OzelFonksiyonlar.ToLowerTurkce(tbxGuncelleAciklama.Text),
                Sayac = Convert.ToInt32(tbxGuncelleSayac.Text)
            };
            _kelimeDal.Guncelle(kelime);
            KelimeleriAktar();
            MessageBox.Show("Güncellendi!");
        }

        // seçilen hücredeki kelimenin tüm özelliklerini güncelleme ve silme panosuna bastırır.
        private void dgwSql_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwSql.RowCount <= 0)
                return;
            tbxGuncelleId.Text = dgwSql.CurrentRow.Cells[1].Value.ToString();
            tbxGuncelleKelime.Text = dgwSql.CurrentRow.Cells[2].Value.ToString();
            tbxGuncelleAciklama.Text = dgwSql.CurrentRow.Cells[3].Value.ToString();
            tbxGuncelleSayac.Text = dgwSql.CurrentRow.Cells[4].Value.ToString();

            tbxSilId.Text = dgwSql.CurrentRow.Cells[1].Value.ToString();
            tbxSilKelime.Text = dgwSql.CurrentRow.Cells[2].Value.ToString();
            tbxSilAciklama.Text = dgwSql.CurrentRow.Cells[3].Value.ToString();
            tbxSilSayac.Text = dgwSql.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            KelimeleriAktar();
        }

        private void btnSelenium_Click(object sender, EventArgs e)
        {
            List<string> kelimeler = new List<string>();
            List<KelimeHavuzu> databaseElemanlari = new List<KelimeHavuzu>();
            KelimeHavuzuDal _kelimeDal = new KelimeHavuzuDal();
            databaseElemanlari = _kelimeDal.HepsiniGetir();

            if (databaseElemanlari.Count <= 0)
            {
                MessageBox.Show("Veritabanınızda Hiç Eleman Bulunamadı !");
                return;
            }

            MessageBox.Show("Lütfen Çeviriler Aktarılırken Programa Müdahalede Bulunmayın !\nHer kelime için beklenecek süre 2.25 saniyedir. İnternet hızınızdan dolayı program hata verirse kapatıp yeniden deneyin. ");

            var options = new ChromeOptions();
            options.AddArguments("--disable-gpu");
            IWebDriver chromeDriver = new ChromeDriver(options);
            chromeDriver.Navigate().GoToUrl("https://translate.google.com");
            IWebElement textBoxSol;


            string topluKelimeler = string.Empty;
            StringBuilder topluKelimelerSB = new StringBuilder(topluKelimeler);
            int kacParcayaBolunecek = 500;
            int tamKisim = (databaseElemanlari.Count / kacParcayaBolunecek); // 1564  icin ==> 3
            int kalanKisim = (databaseElemanlari.Count % kacParcayaBolunecek); // 1564 icin ==> 64

            // -------------------------------------    TAM KISIM --------------------------------------------

            // ORNEK :  5 parcaya bolunecekse ve 12 elemanımız varsa dış loop 0,1,2 olacak ic loop 0x5 den (0x5)+5 e kadar gidecek 
            //              yani (0-5) ==> (5,10) ==> (10,12) olarak indeksleri gezecek (10,12) kısmını ayrı olarak yapıyoruz  

            for (int parcaSayisi = 0; parcaSayisi < tamKisim; parcaSayisi++)
            {
                List<int> aciklamaEklenecekIndeksler = new List<int>();
                for (int indeks = (parcaSayisi * kacParcayaBolunecek); indeks < (parcaSayisi * kacParcayaBolunecek) + kacParcayaBolunecek; indeks++)
                {
                    Console.WriteLine("KelimeIndeksNo: " + indeks + " Kelime: " + databaseElemanlari[indeks].KelimeIngilizce);
                    if (databaseElemanlari[indeks].Aciklama != string.Empty && databaseElemanlari[indeks].Aciklama != null)
                    {
                        Console.WriteLine(databaseElemanlari[indeks].KelimeIngilizce + " Kelimesinin Aciklama satiri dolu olduğu için yeni kelimeye gecilecek.");
                        //continue; // bunu kullanırsan loop 1 indeks artıyor diğer kodlar çalışmadan mesela kelimeIndeksNo++ çalışmıyor continue bu işe yarıyormuş bak bunu öğrendin
                    }
                    else
                    {
                        Console.WriteLine(databaseElemanlari[indeks].KelimeIngilizce + " Kelimesinin Aciklama Satiri Bos olduğu için aciklama eklenecek.");
                        //var wait = new WebDriverWait(chromeDriver, new TimeSpan(0, 0, 2));
                        aciklamaEklenecekIndeksler.Add(indeks);
                        topluKelimelerSB.Append(databaseElemanlari[indeks].KelimeIngilizce); topluKelimelerSB.Append("\n");
                    }

                    // ic for loop bitisi
                }

                Console.WriteLine();
                Console.Write("Aciklama Eklenecek Kelimelerin Indeksleri: ");
                foreach (var item in aciklamaEklenecekIndeksler)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();

                topluKelimeler = topluKelimelerSB.ToString();
                // buradan gelen sonuc boş olmamalı ne durumda boş olur ? eğer gezdiği elemanların hepsinin açıklaması dolu ise boş gelir

                if (!string.IsNullOrEmpty(topluKelimeler))
                {
                    textBoxSol = chromeDriver.FindElement(By.Id("source"));
                    textBoxSol.SendKeys(topluKelimeler);
                    Thread.Sleep(2250);

                    string cevrilenMetin;
                    //var result = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("body > div.frame > div.page.tlid-homepage.homepage.translate-text > div.homepage-content-wrap > div.tlid-source-target.main-header > div.source-target-row > div.tlid-results-container.results-container > div.tlid-result.result-dict-wrapper > div.result.tlid-copy-target > div.text-wrap.tlid-copy-target")));
                    var result = chromeDriver.FindElement(By.CssSelector("body > div.frame > div.page.tlid-homepage.homepage.translate-text > div.homepage-content-wrap > div.tlid-source-target.main-header > div.source-target-row > div.tlid-results-container.results-container > div.tlid-result.result-dict-wrapper > div.result.tlid-copy-target > div.text-wrap.tlid-copy-target"));

                    cevrilenMetin = result.Text;
                    textBoxSol.Clear();
                    Console.WriteLine("Çevrilen Metin: " + cevrilenMetin);

                    Console.WriteLine("Suanki cumle: \n" + topluKelimelerSB.ToString());
                    topluKelimelerSB.Clear();

                    string[] geriBirlestirilecekKelimeler = cevrilenMetin.Split('\n');

                    // cevrilen metin alindiktan sonra parcalarin birlestirilip teker teker database e atılması gerekiyor...
                    // aciklamasi bos olanlari databaseden alıp cevirilerini aldiktan sonra teker teker aciklamalarini güncelliyoruz...
                    // yukaridan asagiya sira sira aldigimiz icin aciklamasi bos olmayanlarin sirayi kaydirmasina bir etkisinin olmayacağını varsayıyorum...
                    Console.WriteLine("*****************************\nGüncelleme Kısmına Geçildi ! \n***********************************");
                    for (int i = 0; i < aciklamaEklenecekIndeksler.Count; i++)
                    {
                        databaseElemanlari[aciklamaEklenecekIndeksler[i]].Aciklama = OzelFonksiyonlar.ToLowerTurkce(geriBirlestirilecekKelimeler[i]);
                        _kelimeDal.Guncelle(databaseElemanlari[aciklamaEklenecekIndeksler[i]]);
                        Console.WriteLine("Database elemanlarindan " + aciklamaEklenecekIndeksler[i] + ". indekse Açıklama Eklendi ! ");
                    }
                }

            }

            // ------------------------------ KALAN KISIM BURADA -----------------------------------

            List<int> aciklamaEklenecekIndekslerKalan = new List<int>();
            for (int indeks = (tamKisim * kacParcayaBolunecek); indeks < (tamKisim * kacParcayaBolunecek) + kalanKisim; indeks++)
            {
                Console.WriteLine("KelimeIndeksNo: " + indeks + " Kelime: " + databaseElemanlari[indeks].KelimeIngilizce);
                if (databaseElemanlari[indeks].Aciklama != string.Empty && databaseElemanlari[indeks].Aciklama != null)
                {
                    Console.WriteLine(databaseElemanlari[indeks].KelimeIngilizce + " Kelimesinin Aciklama satiri dolu olduğu için yeni kelimeye gecilecek.");
                    //continue; // bunu kullanırsan loop 1 indeks artıyor diğer kodlar çalışmadan mesela kelimeIndeksNo++ çalışmıyor continue bu işe yarıyormuş bak bunu öğrendin
                }
                else
                {
                    Console.WriteLine(databaseElemanlari[indeks].KelimeIngilizce + " Kelimesinin Aciklama Satiri Bos olduğu için aciklama eklenecek.");
                    //var wait = new WebDriverWait(chromeDriver, new TimeSpan(0, 0, 2));
                    aciklamaEklenecekIndekslerKalan.Add(indeks);
                    topluKelimelerSB.Append(databaseElemanlari[indeks].KelimeIngilizce); topluKelimelerSB.Append("\n");
                }
                Console.WriteLine("Suanki cumle: \n" + topluKelimelerSB.ToString());
            }

            Console.WriteLine();
            Console.Write("Aciklama Eklenecek Kelimelerin Indeksleri: ");
            foreach (var item in aciklamaEklenecekIndekslerKalan)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            topluKelimeler = topluKelimelerSB.ToString();
            // buradan gelen sonuc boş olmamalı ne durumda boş olur ? eğer gezdiği elemanların hepsinin açıklaması dolu ise boş gelir

            if (!string.IsNullOrEmpty(topluKelimeler))
            {
                textBoxSol = chromeDriver.FindElement(By.Id("source"));
                textBoxSol.SendKeys(topluKelimeler);
                Thread.Sleep(2250);

                string cevrilenMetin;
                //var result = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("body > div.frame > div.page.tlid-homepage.homepage.translate-text > div.homepage-content-wrap > div.tlid-source-target.main-header > div.source-target-row > div.tlid-results-container.results-container > div.tlid-result.result-dict-wrapper > div.result.tlid-copy-target > div.text-wrap.tlid-copy-target")));
                var result = chromeDriver.FindElement(By.CssSelector("body > div.frame > div.page.tlid-homepage.homepage.translate-text > div.homepage-content-wrap > div.tlid-source-target.main-header > div.source-target-row > div.tlid-results-container.results-container > div.tlid-result.result-dict-wrapper > div.result.tlid-copy-target > div.text-wrap.tlid-copy-target"));

                cevrilenMetin = result.Text;
                textBoxSol.Clear();
                Console.WriteLine("Çevrilen Metin: " + cevrilenMetin);

                Console.WriteLine("Suanki cumle: \n" + topluKelimelerSB.ToString());
                topluKelimelerSB.Clear();

                string[] geriBirlestirilecekKelimeler = cevrilenMetin.Split('\n');

                // cevrilen metin alindiktan sonra parcalarin birlestirilip teker teker database e atılması gerekiyor...
                // aciklamasi bos olanlari databaseden alıp cevirilerini aldiktan sonra teker teker aciklamalarini güncelliyoruz...
                // yukaridan asagiya sira sira aldigimiz icin aciklamasi bos olmayanlarin sirayi kaydirmasina bir etkisinin olmayacağını varsayıyorum...
                Console.WriteLine("*****************************\nGüncelleme Kısmına Geçildi ! \n***********************************");
                for (int i = 0; i < aciklamaEklenecekIndekslerKalan.Count; i++)
                {
                    databaseElemanlari[aciklamaEklenecekIndekslerKalan[i]].Aciklama = OzelFonksiyonlar.ToLowerTurkce(geriBirlestirilecekKelimeler[i]);
                    _kelimeDal.Guncelle(databaseElemanlari[aciklamaEklenecekIndekslerKalan[i]]);
                    Console.WriteLine("Database elemanlarindan " + aciklamaEklenecekIndekslerKalan[i] + ". indekse Açıklama Eklendi ! ");
                }
            }

            MessageBox.Show("Kelime Çevirisi Aktarımları Tamamlandı !");
            chromeDriver.Close();
            KelimeleriAktar();
        }

        private void btnAraligindaSil_Click(object sender, EventArgs e)
        {
            // girilen değerin numeric olduğunun kontrolü yapılıyor...
            if (Int32.TryParse(tbxIdIlk.Text, out var cevrilenDegerIlk) && Int32.TryParse(tbxIdIkinci.Text, out var cevrilenDegerIkinci))
            {
                _kelimeDal.BelirliIdAraligindakileriSil(cevrilenDegerIlk, cevrilenDegerIkinci);
                KelimeleriAktar();
                MessageBox.Show(tbxIdIlk.Text + " ile " + tbxIdIkinci.Text + " Id Aralığındaki Tüm Veriler Silindi ! ");
            }
            else
            {
                MessageBox.Show("Lütfen Geçerli Sayı Girin.");
            }
        }

        // SIRALAMA FONKSIYONLARI

        private void btnSatirArtan_Click(object sender, EventArgs e)
        {
            this.dgwSql.Sort(this.dgwSql.Columns[0], ListSortDirection.Ascending);
        }

        private void btnSatirAzalan_Click(object sender, EventArgs e)
        {
            this.dgwSql.Sort(this.dgwSql.Columns[0], ListSortDirection.Descending);
        }

        private void btnIdArtan_Click(object sender, EventArgs e)
        {
            this.dgwSql.Sort(this.dgwSql.Columns[1], ListSortDirection.Ascending);
        }

        private void btnIdAzalan_Click(object sender, EventArgs e)
        {
            this.dgwSql.Sort(this.dgwSql.Columns[1], ListSortDirection.Descending);
        }

        private void btnAlfabeArtan_Click(object sender, EventArgs e)
        {
            this.dgwSql.Sort(this.dgwSql.Columns[2], ListSortDirection.Ascending);
        }

        private void btnAlfabeAzalan_Click(object sender, EventArgs e)
        {
            this.dgwSql.Sort(this.dgwSql.Columns[2], ListSortDirection.Descending);
        }

        private void btnAciklamaArtan_Click(object sender, EventArgs e)
        {
            this.dgwSql.Sort(this.dgwSql.Columns[3], ListSortDirection.Ascending);
        }

        private void btnAciklamaAzalan_Click(object sender, EventArgs e)
        {
            this.dgwSql.Sort(this.dgwSql.Columns[3], ListSortDirection.Descending);
        }

        private void btnSayacArtan_Click(object sender, EventArgs e)
        {
            this.dgwSql.Sort(this.dgwSql.Columns[4], ListSortDirection.Ascending);
        }

        private void btnSayacAzalan_Click(object sender, EventArgs e)
        {
            this.dgwSql.Sort(this.dgwSql.Columns[4], ListSortDirection.Descending);
        }


    }
}
