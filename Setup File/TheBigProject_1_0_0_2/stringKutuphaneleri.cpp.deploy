using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

int s_KelimeKacHarfli(string kelime)
{
	int i = 0;
	int kacKarakter = 0;

	while (kelime[i] != '\0')
	{
		kacKarakter++;
		i++;
	}
	return kacKarakter;

}

string s_KucukHarfCevir(string kelime)
{
	int i = 0;
	while (kelime[i] != '\0')
	{
		kelime[i] = kelime[i] + 32;
	}
	return kelime;
}

int s_SatirdaKacBoslukVar(string kelime)
{
	int i = 0;
	int kacBosluk = 0;

	while (kelime[i] != '\0')
	{
		if (kelime[i] == ' ')
			kacBosluk++;

		i++;
	}
	return kacBosluk;
}

string *s_SatiriStringlereBol(string satir)
{
	// bu fonksiyon nonalpha karakterler kaldirildiktan sonra kullaniliyor.

	// array dondurmek icin fonksiyona pointer koyuluyormus onu ogrendim.

	// satirdaki kelimeleri bosluk gordugu anda bir arraye atiyor ve boylece bir cumledeki
	// kelimeleri teker teker ayirip bir arrayde tutmus oluyoruz
	string *dizi;
	dizi = new string[500]; // kac eleman oldugunu return etmiyorum.
	// pointer kullanip edebilirdim ama onu mainde farkli bir sekilde hallettim diye hatirliyorum
	// yalniz , arrayi boyle return ettigimizde mainde kafa karistirici bir olay oluyor

	// burada array 500 elemanli bir string arrayi ama mainde biz string *dizi[500];
	// dedigimizde 500 x 500 luk bir array oluyor 500 satir var her satirda 500 kelime var 

	// yani biz string *dizi dedigimizde o satirdaki tum kelimeler teker teker atilmis sekilde
	// bu pointera kopyalaniyor suan *dizi bir array dizi[0] dizi[1] yazinca elemanlara
	// erisebiliyoruz 

	int i = 0;
	int j = 0;

	// ORNEK : Satirimiz = "At last Welcome Neo" olsun
	while (satir[i] != '\0')
	{
		if (satir[i] != ' ')
		{
			if (global_Secim == "1")
			{
				cout << dizi[j] << endl; // bosluk olana kadar harf harf stringe ekliyoruz
			}
				
			dizi[j] += satir[i]; // toplama stringde de calisiyor
		}
		else
		{
			j++; // bu bosluk var demek yani yeni kelime atamasi yapmak icin indeksi artiriyoruz
		}
		i++; // bosluk olana kadar indeks her arttiginda yeni harf gelecek
	}

	return dizi;
}


string s_numune(string sozcuk, int bas_nok, int kac_harf)
{
	string word;
	for (int i = 0; i < kac_harf; i++) // kelimenin "kac_harf" sayisi kadarini alir ve return eder
	{         // yani ornegin s_numune(gozluk,0,3) dersek bize "goz" sozcugunu return eder
		word = word + sozcuk[bas_nok];
		bas_nok++;
	}
	return word;
}

string s_sil(string sozcuk, int bas_nok, int kac_harf)
{   // stringden istenilen harf sayisi kadarını belli bir noktadan başlayıp siler
	// 0 1 2 3 4 5
	// g o z l u k 
	// yapilan islem silme degil , istenmeyen harfleri es gecme gibi dusunebiliriz
	string word;
	int j = 0;
	for (int i = 0; i < s_KelimeKacHarfli(sozcuk); i++)
	{
		if (i < bas_nok || i > bas_nok + kac_harf - 1) // bas_nok=1 kac_harf=3; i<1 || i>4
		{
			word = word + sozcuk[i];
		}
	}
	return word;
}

int s_BaslangicIndeksi(string sozcuk, char basHarfi)
{
	// aranan kelimenin bas harfinin indeksini return ediyor
	int indeks;
	bool bulundu = false;

	for (int i = 0; i < s_KelimeKacHarfli(sozcuk); i++)
	{
		if (basHarfi == sozcuk[i])
		{
			indeks = i;
			bulundu = true;
			break;
		}
	}
	if (bulundu)
		return indeks;
	else
		return -1;
}

int AramaSayisi(string sozcuk, int kacligrup)
{
	// örnek gozluk 6 harflidir ve ozl 3 harflidir 6 harfli bir kelimenin 3 lü 3 lü 
	// soldan sağa olacak kombinasyon sayısı bu formülle çıkar

	// gozluk(3) = goz , ozl , zlu , luk = 4 tane
	// formülden = 6-3+1 = 4 
	//cout << "AramaSayisi Test: " << s_uzunluk(kelime) - kacligrup + 1 << endl;
	return s_KelimeKacHarfli(sozcuk) - kacligrup + 1;
}

int s_kelimeAra(string grup , string aranacakString)
{
	int indeks = 0;
	int grubunHarfSayisi;
	if (global_Secim == "1")
	cout << "Fonksiyon" << endl;
	grubunHarfSayisi = s_KelimeKacHarfli(grup);

	for (int j = 0; j < AramaSayisi(aranacakString , grubunHarfSayisi); j++) // Koydugumuz bu sınır
	{  // sayesinde grup kac harfliyse o kadar harfli gruplarla karsılastirma yapiyor.
		if (global_Secim == "1")
		cout << grup << "==" << s_numune(aranacakString , j, grubunHarfSayisi) << endl;
		if (grup == s_numune(aranacakString , j, grubunHarfSayisi)) // gozluk , 0 , 3 = goz
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

string NonAlphaTemizle(string temizlenecekstring)
{
	char nonAlpha[21] = { ':', '"'
	,'+','#','^','~',')','(',',', '.','!','?','*','/','{','}','=','_','-','[',']', };
	// bu arrayin icinde " " (bosluk) karakteri de vardi onu sildim cunku kelimeleri  
	// parcalamak icin bosluklara ihtiyacim vardi neden bu arrayin icinde oldugunu anlamadim
	
	int baslangicIndeksi = 0;

	for (int i = 0; i < 21; i++)
	{
		//cout << baslangicIndeksi << endl;
		baslangicIndeksi = s_BaslangicIndeksi(temizlenecekstring, nonAlpha[i]);
		// s_sil fonksiyonu icin silinecek elemanin baslangic indeksi lazim

		while (baslangicIndeksi != -1) // buldukca silmeye devam edecek
		{
			//cout << baslangicIndeksi << endl;
			baslangicIndeksi = s_BaslangicIndeksi(temizlenecekstring, nonAlpha[i]);
			temizlenecekstring = s_sil(temizlenecekstring, baslangicIndeksi, 1);
			// her adimda 1 karakter siliniyor 
		}
	
	}

	return temizlenecekstring;
}

