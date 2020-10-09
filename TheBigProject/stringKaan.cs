using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBigProject
{
    public static class StringKaan
    {
        public static int s_ArananKarakterdenKacTaneVar(string kelime, char Aranan)
        {
            int kacTane = 0;
            for (int i = 0; i < kelime.Length; i++)
            {
                if (kelime[i] == Aranan)
                {
                    kacTane++;
                }
            }
            return kacTane;
        }

        // Yeni Eklendi !
        public static string MetindenBelliKarakterlerHariciniKaldir(string metin, char[] istisnaKarakterler)
        {
            StringBuilder metinSB = new StringBuilder();
            for (int i = 0; i < metin.Length; i++)
            {
                if (istisnaKarakterler.Contains(metin[i])) // hello,my name# is Thomas ==Anderson !
                {
                    metinSB.Append(metin[i]);
                }
                else
                {
                    metinSB.Append(' ');
                }
            }
            return metinSB.ToString();
        }

        public static string MetindenKarakterSil(string satir, char silinecekSembol)
        {
            int baslangicNoktasi = s_BaslangicNoktasi(satir, silinecekSembol);
            while (baslangicNoktasi != -1)
            {
                baslangicNoktasi = s_BaslangicNoktasi(satir, silinecekSembol);
                satir = s_sil(satir, baslangicNoktasi, 1);
            }
            return satir;
        }

        public static string s_2KarakterinYerleriniDegistir(string kelime, int indeks1, int indeks2)
        {
            StringBuilder kelimeSB = new StringBuilder(kelime);
            char temp = '\0';
            if ((indeks1 >= 0 && indeks1 < kelime.Length && (indeks2 >= 0 && indeks2 < kelime.Length)))
            {
                temp = kelimeSB[indeks1];
                kelimeSB[indeks1] = kelimeSB[indeks2];
                kelimeSB[indeks2] = temp;
            }

            return kelimeSB.ToString();
        }

        public static int s_BaslangicNoktasi(string kelime, char aranan)
        {
            int indeks = -99;
            for (int i = 0; i < kelime.Length; i++)
            {
                if (kelime[i] == aranan)
                {
                    indeks = i;
                    break;
                }
                else
                {
                    indeks = -1;
                }
            }

            return indeks;
        }

        public static int s_TekrarEdenKarakterin_Secileninin_Indeksi(string sozcuk, char Aranan, int kacinciSi)
        {
            int sayac = 0;
            // ORNEK: 23.546.743

            if (kacinciSi <= 0 || kacinciSi > s_ArananKarakterdenKacTaneVar(sozcuk, Aranan))
                return -1;
            else
            {
                for (int indeks = 0; indeks < sozcuk.Length; indeks++)
                {
                    if (sozcuk[indeks] == Aranan)
                    {
                        sayac++;
                    }
                    if (sayac == kacinciSi)
                        return indeks;
                }
            }
            return -1;
        }

        //public static string s_SatiriStringlereBol(string satir)
        //{
        //    // bu fonksiyon nonalpha karakterler kaldirildiktan sonra kullaniliyor.

        //    // array dondurmek icin fonksiyona pointer koyuluyormus onu ogrendim.

        //    // satirdaki kelimeleri bosluk gordugu anda bir arraye atiyor ve boylece bir cumledeki
        //    // kelimeleri teker teker ayirip bir arrayde tutmus oluyoruz
        //    string dizi;
        //    dizi = new string[500]; // kac eleman oldugunu return etmiyorum.
        //                            // pointer kullanip edebilirdim ama onu mainde farkli bir sekilde hallettim diye hatirliyorum
        //                            // yalniz , arrayi boyle return ettigimizde mainde kafa karistirici bir olay oluyor

        //    // burada array 500 elemanli bir string arrayi ama mainde biz string *dizi[500];
        //    // dedigimizde 500 x 500 luk bir array oluyor 500 satir var her satirda 500 kelime var 

        //    // yani biz string *dizi dedigimizde o satirdaki tum kelimeler teker teker atilmis sekilde
        //    // bu pointera kopyalaniyor suan *dizi bir array dizi[0] dizi[1] yazinca elemanlara
        //    // erisebiliyoruz 

        //    int i = 0;
        //    int j = 0;

        //    // ORNEK : Satirimiz = "At last Welcome Neo" olsun
        //    while (satir[i] != '\0')
        //    {
        //        if (satir[i] != ' ')
        //        {

        //            dizi[j] += satir[i]; // toplama stringde de calisiyor
        //        }
        //        else
        //        {
        //            j++; // bu bosluk var demek yani yeni kelime atamasi yapmak icin indeksi artiriyoruz
        //        }
        //        i++; // bosluk olana kadar indeks her arttiginda yeni harf gelecek
        //    }

        //    return dizi;
        //}


        public static string s_numune(string sozcuk, int bas_nok, int kac_harf)
        {
            string kelime = string.Empty;
            for (int i = 0; i < kac_harf; i++) // kelimenin "kac_harf" sayisi kadarini alir ve return eder
            {         // yani ornegin s_numune(gozluk,0,3) dersek bize "goz" sozcugunu return eder
                kelime = kelime + sozcuk[bas_nok];
                bas_nok++;
            }
            return kelime;
        }

        public static string s_sil(string kelime, int bas_nok, int kacHarf)
        {
            // 01234567
            // morpheus
            string yeni = string.Empty;
            for (int i = 0; i < kelime.Length; i++)
            {
                if (i < bas_nok || (i > (bas_nok + kacHarf - 1)))
                {
                    yeni = yeni + kelime[i];
                }
            }
            return yeni;
        }

        public static int s_AramaSayisi(string sozcuk, int kacligrup)
        {
            // örnek gozluk 6 harflidir ve ozl 3 harflidir 6 harfli bir kelimenin 3 lü 3 lü 
            // soldan sağa olacak kombinasyon sayısı bu formülle çıkar

            // gozluk(3) = goz , ozl , zlu , luk = 4 tane
            // formülden = 6-3+1 = 4 
            //cout << "AramaSayisi Test: " << s_uzunluk(kelime) - kacligrup + 1 << endl;
            return sozcuk.Length - kacligrup + 1;
        }


        //public static string KelimeyeKarakterEkle(string kelime, char eklenecek, int kacinciKaraktere, int kacKere) // revise et
        //{
        //    // NOT kacinciKaraktere degeri icin soldan saga bakiyorsaniz
        //    // mesela deger 4 ise 4 harf sonraki yere karakteri koyar
        //    // tam tersinde ise deger 4 ise sondan 3. harfin sonrasina koyar

        //    // ORNEK DEGER 4 OLSUN
        //    // 1234567 BUNA NOKTA KOYALIM SONUC SU OLACAK : 1234.567
        //    // BASTAN 4. SONDAN 3.
        //    // 213
        //    StringBuilder kelimeSB = new StringBuilder(kelime);
        //    for (int i = 0; i < kacKere; i++)
        //    {
        //        kelimeSB.Append(eklenecek);
        //    }

        //    // 012345678
        //    // 9876543.. i = 8 den i = 5 e kadar
        //    // 9876543..  i = 8
        //    // 98765433.  i = 7
        //    // 98765443.  i = 6
        //    // 98765543.  i = 5

        //    char temp = eklenecek;
        //    for (int i = kelime.Length - 1; i >= kacinciKaraktere; i--)
        //    {
        //        if (i == kacinciKaraktere)
        //        {
        //            for (int j = kacinciKaraktere; j < kacinciKaraktere + kacKere; j++)
        //            {
        //                kelimeSB[i] = temp;
        //            }
        //        }
        //        else
        //            kelimeSB[i] = kelimeSB[i - kacKere]; // kac kez ekleyeceksen o kadar oteleyeceksin 
        //    }
        //    return kelimeSB.ToString();
        //}


        //public static string MetindenKelimeSil(string satir, string silinecekSozcuk) // C# uyarla C# uyumlu değil \0 görmüyor C#
        //{
        //    string karsilastirma = "";
        //    for (int i = 0; i < satir.Length; i++)
        //    {
        //        //cout << satir[i] << endl;
        //        if (satir[i] != ' ')
        //        {
        //            karsilastirma = karsilastirma + satir[i];
        //        }
        //        else
        //        {
        //            if (karsilastirma == silinecekSozcuk)
        //            {
        //                satir = s_sil(satir, i - karsilastirma.Length - 1, karsilastirma.Length + 1);
        //            }
        //            karsilastirma = "";
        //        }

        //        if (satir[i + 1] == '\0')
        //        {
        //            if (karsilastirma == silinecekSozcuk)
        //            {
        //                satir = s_sil(satir, i - karsilastirma.Length, karsilastirma.Length + 1);
        //            }
        //            karsilastirma = "";
        //        }
        //    }
        //    if (satir[0] == ' ')
        //        satir = s_sil(satir, 0, 1);
        //    return satir;
        //}

        //public static string s_KarakteriBaskasiylaDegistir(string kelime, char neIleDegisecek, int baslangicNoktasi)
        //{
        //    if (baslangicNoktasi != -1)
        //    {
        //        kelime[baslangicNoktasi] = neIleDegisecek;
        //    }

        //    return kelime;
        //}

        public static int s_kelimeAra(string grup, string aranacakString)
        {
            int indeks = 0;
            int grubunHarfSayisi;

            grubunHarfSayisi = grup.Length;

            for (int j = 0; j < s_AramaSayisi(aranacakString, grubunHarfSayisi); j++) // Koydugumuz bu sınır
            {  // sayesinde grup kac harfliyse o kadar harfli gruplarla karsılastirma yapiyor.

                //cout << grup << "==" << s_numune(aranacakString, j, grubunHarfSayisi) << endl;
                if (grup == s_numune(aranacakString, j, grubunHarfSayisi)) // gozluk , 0 , 3 = goz
                {
                    indeks = j;
                    break;
                }
                else
                {
                    indeks = -1;
                }
            }
            return indeks;
        }
    }
}

//public static string NonAlphaTemizle(string temizlenecekstring)
//{
//    char nonAlpha[] = { ':', '"'
//,'+','#','^','~',')','(',',', '.','!','?','*','/','{','}','=','_','-','[',']', ';' ,'%' ,'@' , '£' , '<' , '>' , '|' , '&' , '€' , '$' , '~'};
//    // bu arrayin icinde " " (bosluk) karakteri de vardi onu sildim cunku kelimeleri  
//    // parcalamak icin bosluklara ihtiyacim vardi neden bu arrayin icinde oldugunu anlamadim

//    int baslangicIndeksi = 0;
//    string test = "'";
//    for (int i = 0; i < 32; i++)
//    {
//        //cout << baslangicIndeksi << endl;
//        baslangicIndeksi = s_BaslangicNoktasi(temizlenecekstring, nonAlpha[i]);
//        // s_sil fonksiyonu icin silinecek elemanin baslangic indeksi lazim

//        while (baslangicIndeksi != -1) // buldukca silmeye devam edecek
//        {
//            //cout << baslangicIndeksi << endl;
//            baslangicIndeksi = s_BaslangicNoktasi(temizlenecekstring, nonAlpha[i]);
//            temizlenecekstring = s_sil(temizlenecekstring, baslangicIndeksi, 1);
//            // her adimda 1 karakter siliniyor 
//        }

//    }
//    baslangicIndeksi = s_BaslangicNoktasi(temizlenecekstring, test[0]);
//    if (baslangicIndeksi != -1)
//        temizlenecekstring = s_sil(temizlenecekstring, baslangicIndeksi, 1);

//    return temizlenecekstring;
//}

//        public static double virgulluSayiCevirme(string sayi)
//        {
//            double virgulluKisim = 0.0;
//            double islemdeKullanilacak = 0;
//            double cevrilenSayi = 0.0;

//            bool negatif = false;

//            //string test = "-82.423,63";
//            //string test2 = "0,00";
//            //string test3 = "2.191.604.74";
//            //string test4 = "0,65";
//            //string test5 = "54.65";

//            if (sayi[0] == '-')
//            {
//                sayi = s_sil(sayi, 0, 1);
//                negatif = true;
//                //cout << "- isareti kaldirildi : " << sayi << endl;
//            }


//            int kacNoktaVar = s_ArananKarakterdenKacTaneVar(sayi, '.');
//            int baslangicNoktasi = s_BaslangicNoktasi(sayi, ',');
//            int noktaIndeks = 0;

//            //cout << "Virgulun baslangic Noktasi: " << baslangicNoktasi << endl;
//            //cout << "Sayida kac nokta var: " << kacNoktaVar << endl;

//            if (baslangicNoktasi == -1)
//            {
//                if (kacNoktaVar > 0)
//                {
//                    noktaIndeks = s_TekrarEdenKarakterin_Secileninin_Indeksi(sayi, '.', kacNoktaVar);
//                    //cout << "Nokta Indeksi: " << noktaIndeks << endl;
//                    sayi = s_KarakteriBaskasiylaDegistir(sayi, ',', noktaIndeks);
//                    //cout << "Nokta Virgul ile degistirildi - " << sayi << endl;
//                }
//            }

//            for (int i = 0; i < s_KelimeKacHarfli(sayi); i++)
//            {
//                if (sayi[i] == ',')
//                    islemdeKullanilacak = (sayi[i + 1] - 48) * 10 + sayi[i + 2] - 48;

//                //cout << islemdeKullanilacak << endl;
//                virgulluKisim = islemdeKullanilacak / 100;
//                if (negatif)
//                    virgulluKisim *= -1;
//                //cout << "Virgullu Kisim Hesaplandi !  " << virgulluKisim << endl;
//            }

//            baslangicNoktasi = s_BaslangicNoktasi(sayi, ',');
//            if (baslangicNoktasi < s_KelimeKacHarfli(sayi) && baslangicNoktasi >= 0)
//            {
//                sayi = s_sil(sayi, baslangicNoktasi, 3); // 54,65
//            }
//            //cout << "Sayinin Virgullu Kismi Ayrildi  ! " << sayi << " ve " << virgulluKisim << endl;
//            int n = 0;
//            //														   012345678
//            for (int i = s_KelimeKacHarfli(sayi) - 1; i >= 0; i--) // 1.982.381
//            {
//                //cout << "i indeksi: " << i << endl;
//                //cout << "sayi[" << i << "]("<< sayi[i] <<") " << "!= '.'" << endl;
//                if (sayi[i] != '.')
//                {
//                    //cout << cevrilenSayi << " + " << ((sayi[i] - 48)*pow(10, n));
//                    cevrilenSayi = cevrilenSayi + ((sayi[i] - 48) * Math.Pow(10, n));
//                    //cout << " = " << cevrilenSayi << endl;;
//                    n++;
//                }
//            }

//            if (negatif)
//                cevrilenSayi *= -1;

//            return cevrilenSayi + virgulluKisim;
//        }



//        public static string sayiyiNoktaVirgulFormatinaDonustur(double sayi)
//        {
//            string stringSayi = sayi.ToString();
//            // ORNEK 1234567.89 => 1234567,89 => 1234567 => 1.234.567,89
//            string virgulluKisim;

//            //cout << stringSayi << " (double dan stringe)" << endl;
//            // -82423.630000

//            int noktaIndeks = s_BaslangicNoktasi(stringSayi, '.');
//            if (noktaIndeks != -1) // nokta varsa virgul yap
//            {
//                stringSayi = s_KarakteriBaskasiylaDegistir(stringSayi, ',', noktaIndeks);
//            }

//            //cout << stringSayi << endl;

//            int baslangicNoktasi = s_BaslangicNoktasi(stringSayi, ',');

//            virgulluKisim = s_sil(stringSayi, 0, baslangicNoktasi);
//            stringSayi = s_sil(stringSayi, baslangicNoktasi, 7);
//            virgulluKisim = s_sil(virgulluKisim, 3, 4);

//            // 012345  SIMDI ARAYA NOKTALARI EKLEYECEZ
//            // -82423
//            // 500000

//            //cout << stringSayi << " " << virgulluKisim << endl;

//            int sayac = 0;
//            for (int i = s_KelimeKacHarfli(stringSayi) - 1; i >= 0; i--)
//            {
//                if (stringSayi[i] != '-')
//                    sayac++;
//                if (sayac % 3 == 0)
//                {
//                    if (i != 0)
//                    {
//                        stringSayi = KelimeyeKarakterEkle(stringSayi, '.', i, 1);
//                        sayac = 0;
//                    }
//                }
//            }

//            return stringSayi + virgulluKisim;
//        }
//    }
//}
