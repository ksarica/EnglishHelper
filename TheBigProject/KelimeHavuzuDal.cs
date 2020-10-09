using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace TheBigProject
{
    public class KelimeHavuzuDal
    {
        SqlConnection _baglanti = new SqlConnection(@"Data Source=KS\KAANSQL;Initial Catalog=KelimeDb;Integrated Security=True");

        private void BaglantiKontrol()
        {
            // Bağlantı kapalıysa aç SQL den bir şey getirmen gerektiğinde bir komut lazım olduğunda bunu çağır
            if (_baglanti.State == ConnectionState.Closed)
            {
                _baglanti.Open();
            }
        }

        public List<KelimeHavuzu> HepsiniGetir()
        {
            BaglantiKontrol();
            SqlCommand komut = new SqlCommand("Select * from Kelimeler", _baglanti);
            SqlDataReader reader = komut.ExecuteReader();

            List<KelimeHavuzu> Kelimeler = new List<KelimeHavuzu>();

            while (reader.Read())
            {
                KelimeHavuzu kelime = new KelimeHavuzu
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    KelimeIngilizce = reader["KelimeIngilizce"].ToString(),
                    Aciklama = reader["Aciklama"].ToString(),
                    Sayac = Convert.ToInt32(reader["Sayac"])
                };
                Kelimeler.Add(kelime);
            }

            reader.Close();
            _baglanti.Close();
            return Kelimeler;
        }

        public List<string> KelimeleriGetir()
        {
            BaglantiKontrol();
            SqlCommand komut = new SqlCommand("Select KelimeIngilizce from Kelimeler", _baglanti);
            SqlDataReader reader = komut.ExecuteReader();

            List<string> Kelimeler = new List<string>();

            while (reader.Read())
            {
                string kelime = reader["KelimeIngilizce"].ToString();
                Kelimeler.Add(kelime);
            }

            reader.Close();
            _baglanti.Close();
            return Kelimeler;
        }

        public HashSet<KelimeHavuzu> HepsiniGetirHashSet()
        {
            BaglantiKontrol();
            SqlCommand komut = new SqlCommand("Select * from Kelimeler", _baglanti);
            SqlDataReader reader = komut.ExecuteReader();

            HashSet<KelimeHavuzu> Kelimeler = new HashSet<KelimeHavuzu>();

            while (reader.Read())
            {
                KelimeHavuzu kelime = new KelimeHavuzu
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    KelimeIngilizce = reader["KelimeIngilizce"].ToString(),
                    Aciklama = reader["Aciklama"].ToString(),
                    Sayac = Convert.ToInt32(reader["Sayac"])
                };
                Kelimeler.Add(kelime);
            }

            reader.Close();
            _baglanti.Close();
            return Kelimeler;
        }

        public HashSet<string> KelimeleriGetirHashSet()
        {
            BaglantiKontrol();
            SqlCommand komut = new SqlCommand("Select KelimeIngilizce from Kelimeler", _baglanti);
            SqlDataReader reader = komut.ExecuteReader();

            HashSet<string> Kelimeler = new HashSet<string>();

            while (reader.Read())
            {
                string kelime = reader["KelimeIngilizce"].ToString();
                Kelimeler.Add(kelime);
            }

            reader.Close();
            _baglanti.Close();
            return Kelimeler;
        }

        public void Ekle(KelimeHavuzu eklenecek)
        {
            BaglantiKontrol();
            HashSet<KelimeHavuzu> kelimeler = HepsiniGetirHashSet();
            string arananKelime = eklenecek.KelimeIngilizce;
            Console.WriteLine(eklenecek.Id + " " + eklenecek.KelimeIngilizce + " " + eklenecek.Aciklama + " " + eklenecek.Sayac);
            
            bool bulundu = false;
            int bulunanId = 0;
            int bulunanSayac = 0;

            foreach (var kelime in kelimeler) // binary search yapman lazım optimizasyon için
            {
                Console.WriteLine(kelime.KelimeIngilizce + " == " + arananKelime);
                if (kelime.KelimeIngilizce == arananKelime)
                {
                    bulunanId = kelime.Id;
                    bulunanSayac = kelime.Sayac;
                    bulundu = true;
                    break;
                }
            }
            if (bulundu == true) // bulunduysa yeni kayıt eklenmeyecek sadece sayac 1 arttırılacak // UPDATE KULLANILACAK
            {
                Console.WriteLine(eklenecek.Sayac + " 1 arttırıldı Güncellemeye Gönderiliyor");
                eklenecek.Id = bulunanId;
                eklenecek.Sayac += bulunanSayac;
                Guncelle(eklenecek);
            }
            else // bulunmadıysa yeni kayıt eklenecek. // INSERT KULLANILACAK
            {
                BaglantiKontrol();
                SqlCommand komut = new SqlCommand(
                    "Insert into Kelimeler values(@KelimeIngilizce,@Aciklama,@Sayac)", _baglanti);
                // ekleme yaparken id eklemiyoruz otomatik 1 arttıracak
                komut.Parameters.AddWithValue("@KelimeIngilizce", eklenecek.KelimeIngilizce);
                komut.Parameters.AddWithValue("@Aciklama", eklenecek.Aciklama);
                komut.Parameters.AddWithValue("@Sayac", eklenecek.Sayac);
                int sayi = komut.ExecuteNonQuery();
                Console.WriteLine("Bulunmadi etkilenen row: " + sayi);
                _baglanti.Close();
            }
        }

        public void Guncelle(KelimeHavuzu eklenecek)
        {
            BaglantiKontrol();
            Console.WriteLine(eklenecek.Id + " " + eklenecek.KelimeIngilizce + " " + eklenecek.Aciklama + " " + eklenecek.Sayac);
            SqlCommand komut = new SqlCommand(
                "update Kelimeler set KelimeIngilizce=@kelimeIngilizce, Aciklama=@aciklama, Sayac=@sayac where Id=@id", _baglanti);
            komut.Parameters.AddWithValue("@kelimeIngilizce", eklenecek.KelimeIngilizce);
            komut.Parameters.AddWithValue("@aciklama", eklenecek.Aciklama);
            komut.Parameters.AddWithValue("@sayac", eklenecek.Sayac);
            komut.Parameters.AddWithValue("@id", eklenecek.Id);
            int sayi = komut.ExecuteNonQuery();
            Console.WriteLine(sayi + "Etkilendi update fonksiyonu");
            _baglanti.Close();
        }

        public void Sil(int id)
        {
            BaglantiKontrol();
            SqlCommand komut = new SqlCommand(
                "Delete from Kelimeler where Id=@id", _baglanti);
            komut.Parameters.AddWithValue("@id", id);
            komut.ExecuteNonQuery();
            _baglanti.Close();
        }

        public void HepsiniSil()
        {
            BaglantiKontrol();
            SqlCommand komut = new SqlCommand(
                "Delete from Kelimeler where Id>0", _baglanti);
            komut.ExecuteNonQuery();
            _baglanti.Close();
        }

        public void BelirliIdAraligindakileriSil(int baslangicId, int bitisId)
        {
            BaglantiKontrol();
            SqlCommand komut = new SqlCommand(
                "Delete from Kelimeler where Id between @baslangic and @bitis", _baglanti);
            komut.Parameters.AddWithValue("@baslangic", baslangicId);
            komut.Parameters.AddWithValue("@bitis", bitisId);
            komut.ExecuteNonQuery();
            _baglanti.Close();
        }
    }
}
