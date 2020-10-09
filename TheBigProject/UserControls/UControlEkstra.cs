using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpeechLib;

// google translate cümle çekme

//textBox = chromeDriver.FindElement(By.Id("source"));
//textBox.SendKeys("pretty");
//Thread.Sleep(750);
//var cumleOrnekleri = chromeDriver.FindElement(By.CssSelector("body > div.frame > div.page.tlid-homepage.homepage.translate-text > div.homepage-content-wrap > div.tlid-result-view.cllist > div.gt-lc.gt-lc-mobile > div.gt-cc > div.gt-cc-r > div > div.gt-cd.gt-cd-mex > div.gt-cd-c"));

namespace TheBigProject.UserControls
{
    public partial class UControlEkstra : UserControl
    {
        static UControlEkstra _obje;
        KelimeHavuzuDal kelimeHavuzuDal = new KelimeHavuzuDal();
        List<KelimeHavuzu> tumKelimeler = new List<KelimeHavuzu>();

        SpVoice sp = new SpVoice();

        public static UControlEkstra Instance
        {
            get
            {
                if (_obje == null)
                {
                    _obje = new UControlEkstra();
                    Console.WriteLine("Yeni UControlEkstra Instance i Oluşturuldu !");
                }
                return _obje;
            }
        }

        public UControlEkstra()
        {
            InitializeComponent();
        }

        private void btnVeritabani_Click(object sender, EventArgs e)
        {
            try
            {
                tumKelimeler = kelimeHavuzuDal.HepsiniGetir();
            }
            catch (Exception)
            {
                MessageBox.Show("Veritabanına Bağlanılamadı ! Lütfen Programın Diğer Bölümlerini Kullanın !");
            }
            finally
            {
                if (tumKelimeler.Count > 0)
                    MessageBox.Show("Veritabanı Başarıyla Çağrıldı !");
                else
                    MessageBox.Show("Veritabanında Hiç Eleman Bulunamadı !");
            }
        }

        private void UControlEkstra_Load(object sender, EventArgs e)
        {
            _obje = this;
        }

        private void txtKacSaniye_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtKacKelime_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtKacSaniye_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private int ListdenRastgeleElemanGetir(List<int> elemanlar) // 1 2 3 4 5 
        {
            Random random = new Random();
            int secilenIndeks = random.Next(0, elemanlar.Count);
            int temp = elemanlar[secilenIndeks];

            Console.WriteLine("Secilen Deger: " + temp + " Bu değer listden silinecek... Sonra Return Edilecek...");

            elemanlar.RemoveAt(secilenIndeks);
            Console.WriteLine("Listde " + temp + " değerini görmemeniz lazım...");
            foreach (var item in elemanlar)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            return temp;
        }

        private void KelimeleriTarayıcıyaYukle(string kelime)
        {
            string kelimeUrl = kelime;
            string url = "https://www.google.com.tr/search?hl=tr&biw=1536&bih=760&tbm=isch&sxsrf" +
                "=ACYBGNRVQvoe6jMY8b" + "PJLxRmOTSdkmG52g%3A1568202091189&sa=1&ei=a914XfmYC4HTkgXuwZmAAw&q="
                + kelimeUrl + "&oq=" + kelimeUrl + "&gs_l=img.3..0l10.6505.12054..12137...0.0..0.131.751.1j6" +
                "......0....1..gws-wiz-img.....0..35i39._Z1hPi3Dxzc&ved=0ahUKEwi5-tKE2MjkAhWBqaQKHe5gBjAQ4dUDCAY&uact=5";

            Console.WriteLine(kelime + " kelimesi için resim yükleniyor... Yeni Kelimeye Geçmeden beklenecek...");

            Console.WriteLine("Fonksiyon Çalışmadan Önceki URL: " + webBrowser1.Url);
            Task.Run(() => webBrowser1.Navigate(url));
            //Thread.Sleep(3000);
            Console.WriteLine("Fonksiyon Çalıştıktan Sonraki URL: " + webBrowser1.Url);
        }

        private async void btnBaslat_Click(object sender, EventArgs e)
        {
            // Başlatma Ayarları ***************************************
            int kacKelimeGetirilecek;
            int kacSaniyeBeklenecek;

            try
            {
                kacKelimeGetirilecek = Convert.ToInt32(txtKacKelime.Text);
                kacSaniyeBeklenecek = Convert.ToInt32(txtKacSaniye.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Gerekli Yerleri Doldurun!");
                return;
            }
            if (kacKelimeGetirilecek <= 0)
            {
                MessageBox.Show("Lütfen 0 dan Büyük Bir Değer Girin ! ");
                return;
            }

            int veritabaniKelimeSayisi = tumKelimeler.Count;

            Dictionary<string, string> secilenKelimeler = new Dictionary<string, string>();

            if (veritabaniKelimeSayisi == 0)
            {
                MessageBox.Show("Veritabanınız Boş Görünüyor. Eğer Boş Değilse, Lütfen Veritabanını Çağır Butonunu Kullanın !");
                return;
            }

            if (veritabaniKelimeSayisi < kacKelimeGetirilecek)
            {
                MessageBox.Show("Veritabanınızda " + veritabaniKelimeSayisi + " Kelime Var. Lütfen " + kacKelimeGetirilecek + " Kelimeden Küçük Bir Değer Girin...");
                return;
            }
            // Başlatma Ayarları Bitiş ***************************************


            ////////////////////////////////////////////////////////////////////////////////////
            // COMBOBOX SEÇİM AYARLARI

            // 5 eleman varsa indeksleri 0 1 2 3 4 dür random.Next(0,5) bu indeksleri basar...

            if (cmbCagrilmaTipi.SelectedItem == cmbCagrilmaTipi.Items[0]) // RASTGELE
            {
                List<int> tumIndeksler = new List<int>();
                secilenKelimeler.Clear();
                Console.WriteLine("Veritabanından Rastgele " + kacKelimeGetirilecek + " Kelime Getirilecek !");

                // önce veritabanındaki kelime sayısı kadar for döngüsünde bunların indekslerinin tutuldugu bir list oluşturacağız 
                // sonra bu listten rastgele bir indeks gelecek, aynı indeksin gelmemesi için getirilen indeks listeden kaldırılacak.

                for (int i = 0; i < tumKelimeler.Count; i++)
                {
                    tumIndeksler.Add(i);
                }

                for (int i = 0; i < kacKelimeGetirilecek; i++)
                {
                    int getirilenIndeks = ListdenRastgeleElemanGetir(tumIndeksler);
                    Console.WriteLine("getirilenIndeks degerine " + getirilenIndeks + " Değeri Atandı ! ");

                    string rastgeleSecilenKelime = tumKelimeler[getirilenIndeks].KelimeIngilizce;
                    string KelimeninTurkcesi = string.Empty;
                    KelimeninTurkcesi = tumKelimeler[getirilenIndeks].Aciklama;
                    if (string.IsNullOrEmpty(KelimeninTurkcesi))
                    {
                        KelimeninTurkcesi = "Veritabanı Bölümünden Çevirileri Alın";
                    }
                    secilenKelimeler.Add(rastgeleSecilenKelime, KelimeninTurkcesi);
                    Console.WriteLine("Veritabanından " + getirilenIndeks + ". indeksten " + rastgeleSecilenKelime + " seçildi !");
                }
                //System.Console.Clear();
                Console.WriteLine("\n\n ************************* TASK BÖLÜMÜ ****************************\n");

                foreach (var kelime in secilenKelimeler)
                {
                    Console.WriteLine(kelime.Key + " Kelimesi için Task Başlatılıyor...");
                    await Task.Run(() =>
                    {
                        lblKelimeIngilizce.Text = "İngilizce: " + kelime.Key;
                        if (string.IsNullOrEmpty(kelime.Value))
                        {
                            lblKelimeTurkce.Text = "Türkçe: " + "Lütfen Veritabanı Bölümünden Çevirileri Alın !";
                        }
                        else
                        {
                            lblKelimeTurkce.Text = "Türkçe: " + kelime.Value;
                        }
                        KelimeleriTarayıcıyaYukle(kelime.Key);
                        sp.Speak(kelime.Key);
                        Thread.Sleep(kacSaniyeBeklenecek * 1000);
                    });
                    Console.WriteLine("Task Bitti ! Loop Yeni Kelimeye Geçecek ... ");
                    continue;
                }
            }

            else if (cmbCagrilmaTipi.SelectedItem == cmbCagrilmaTipi.Items[1]) // EN ÜSTTEN
            {
                secilenKelimeler.Clear();
                Console.WriteLine("Veritabanından " + kacKelimeGetirilecek + " Kelime Getirilecek !");
                for (int i = 0; i < kacKelimeGetirilecek; i++)
                {
                    string siradakiKelime = tumKelimeler[i].KelimeIngilizce;
                    string KelimeninTurkcesi = tumKelimeler[i].Aciklama;
                    secilenKelimeler.Add(siradakiKelime, KelimeninTurkcesi);
                    Console.WriteLine("Veritabanından " + i + ". indeksten " + siradakiKelime + " seçildi !");
                }

                foreach (var kelime in secilenKelimeler)
                {
                    Console.WriteLine(kelime.Key + " Kelimesi için Task Başlatılıyor...");
                    await Task.Run(() =>
                    {
                        lblKelimeIngilizce.Text = "İngilizce: " + kelime.Key;
                        if (string.IsNullOrEmpty(kelime.Value))
                        {
                            lblKelimeTurkce.Text = "Türkçe: " + "Lütfen Veritabanı Bölümünden Çevirileri Alın !";
                        }
                        else
                        {
                            lblKelimeTurkce.Text = "Türkçe: " + kelime.Value;
                        }
                        KelimeleriTarayıcıyaYukle(kelime.Key);
                        sp.Speak(kelime.Key);
                        Thread.Sleep(kacSaniyeBeklenecek * 1000);
                    });
                    Console.WriteLine("Task Bitti ! Loop Yeni Kelimeye Geçecek ... ");
                    continue;
                }
            }

            // 0 1 2 3 4 5 6 7 8 9  ==> en alttan 5 kelime dersem 9 8 7 6 5 i almam gerekiyor
            else if (cmbCagrilmaTipi.SelectedItem == cmbCagrilmaTipi.Items[2]) // EN ALTTAN
            {
                secilenKelimeler.Clear();
                Console.WriteLine("Veritabanından " + kacKelimeGetirilecek + " Kelime Getirilecek !");
                for (int i = (veritabaniKelimeSayisi - 1); i >= (veritabaniKelimeSayisi - kacKelimeGetirilecek); i--)
                {
                    string siradakiKelime = tumKelimeler[i].KelimeIngilizce;
                    string KelimeninTurkcesi = tumKelimeler[i].Aciklama;
                    secilenKelimeler.Add(siradakiKelime, KelimeninTurkcesi);
                    Console.WriteLine("Veritabanından " + i + ". indeksten " + siradakiKelime + " seçildi !");
                }

                foreach (var kelime in secilenKelimeler)
                {
                    Console.WriteLine(kelime.Key + " Kelimesi için Task Başlatılıyor...");
                    await Task.Run(() =>
                    {
                        lblKelimeIngilizce.Text = "İngilizce: " + kelime.Key;
                        if (string.IsNullOrEmpty(kelime.Value))
                        {
                            lblKelimeTurkce.Text = "Türkçe: " + "Lütfen Veritabanı Bölümünden Çevirileri Alın !";
                        }
                        else
                        {
                            lblKelimeTurkce.Text = "Türkçe: " + kelime.Value;
                        }
                        KelimeleriTarayıcıyaYukle(kelime.Key);
                        sp.Speak(kelime.Key);
                        Thread.Sleep(kacSaniyeBeklenecek * 1000);
                    });
                    Console.WriteLine("Task Bitti ! Loop Yeni Kelimeye Geçecek ... ");
                    continue;
                }
            }
            else
            {
                MessageBox.Show("Lütfen Gerekli Yerleri Doldurun !");
                return;
            }

            ////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine();
            foreach (var item in secilenKelimeler)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();

            MessageBox.Show("Tamamlandı !");
        }

        // ----------------------------- WEB BROWSER -----------------------------------

        private void btnGit_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text;

            if (url.ToString().Contains(".com"))
            {
                webBrowser1.Navigate(url);
            }
            else
            {
                webBrowser1.Navigate("https://www.google.com/search?sxsrf=ACYBGNQp8S6XYDtjuXGc-7WjKr97hqzlAA%3A1568116336120&source" +
                    "=hp&ei=cI53Xbu2BIqvmwXx6JCADw&q=" + url + "&oq=" + url + "&gs_l=psy-ab.3..0l2j0i131j0l7.509.1070..1512...0.0..0." +
                    "248.1251.0j7j1......0....1..gws-wiz....." + "10..35i362i39j35i39j0i67j0i10.rQgyTjiCJWk&ved=0ahUKEwi7rrbJmMbkAhWK16" +
                    "YKHXE0BPAQ4dUDCAU&uact=5");
            }

        }

        private void txtAra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                btnGit.PerformClick();
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            txtUrl.Text = e.Url.ToString();
            //if (webBrowser1.Url == e.Url)
            //{
            //    MessageBox.Show("Site Yüklendi !");
            //}
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
                webBrowser1.GoBack();
        }

        private void btnIleri_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
                webBrowser1.GoForward();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void txtUrl_Click(object sender, EventArgs e)
        {
            txtUrl.SelectAll();
        }

 
    }
}