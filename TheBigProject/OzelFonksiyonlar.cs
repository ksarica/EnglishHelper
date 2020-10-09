using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBigProject
{
    static public class OzelFonksiyonlar
    {
        static public string TurkceKarakterKaldir(string metin)
        {
            metin = metin.Replace('ç', 'c');
            metin = metin.Replace('ı', 'i');
            metin = metin.Replace('ü', 'u');
            metin = metin.Replace('ğ', 'g');
            metin = metin.Replace('ö', 'o');
            metin = metin.Replace('ş', 's');

            metin = metin.Replace('Ç', 'C');
            metin = metin.Replace('İ', 'I');
            metin = metin.Replace('Ü', 'U');
            metin = metin.Replace('Ğ', 'G');
            metin = metin.Replace('Ö', 'O');
            metin = metin.Replace('Ş', 'S');

            return metin;
        }

        static public string TurkceKarakterKaldirv2(string metin) // YUKARIDAKINDEN HIZLI OLDU BÖYLE
        {
            StringBuilder metinSB = new StringBuilder(metin);
            for (int harf = 0; harf < metinSB.Length; harf++)
            {
                switch (metinSB[harf])
                {
                    case 'ç':
                        metinSB[harf] = 'c';
                        break;
                    case 'ı':
                        metinSB[harf] = 'i';
                        break;
                    case 'ü':
                        metinSB[harf] = 'u';
                        break;
                    case 'ğ':
                        metinSB[harf] = 'g';
                        break;
                    case 'ö':
                        metinSB[harf] = 'o';
                        break;
                    case 'ş':
                        metinSB[harf] = 's';
                        break;
                    case 'Ç':
                        metinSB[harf] = 'C';
                        break;
                    case 'İ':
                        metinSB[harf] = 'I';
                        break;
                    case 'Ü':
                        metinSB[harf] = 'U';
                        break;
                    case 'Ğ':
                        metinSB[harf] = 'G';
                        break;
                    case 'Ö':
                        metinSB[harf] = 'O';
                        break;
                    case 'Ş':
                        metinSB[harf] = 'S';
                        break;
                    default:
                        break;
                }
            }
            return metinSB.ToString();
        }

        static public string ToLowerTurkce(string metin)
        {
            metin = metin.Replace('A', 'a');
            metin = metin.Replace('B', 'b');
            metin = metin.Replace('C', 'c');
            metin = metin.Replace('Ç', 'ç');
            metin = metin.Replace('D', 'd');
            metin = metin.Replace('E', 'e');
            metin = metin.Replace('F', 'f');
            metin = metin.Replace('G', 'g');
            metin = metin.Replace('Ğ', 'ğ');
            metin = metin.Replace('H', 'h');
            metin = metin.Replace('I', 'ı');
            metin = metin.Replace('İ', 'i');
            metin = metin.Replace('J', 'j');
            metin = metin.Replace('K', 'k');
            metin = metin.Replace('L', 'l');
            metin = metin.Replace('M', 'm');
            metin = metin.Replace('N', 'n');
            metin = metin.Replace('O', 'o');
            metin = metin.Replace('Ö', 'ö');
            metin = metin.Replace('P', 'p');
            metin = metin.Replace('R', 'r');
            metin = metin.Replace('S', 's');
            metin = metin.Replace('Ş', 'ş');
            metin = metin.Replace('T', 't');
            metin = metin.Replace('U', 'u');
            metin = metin.Replace('Ü', 'ü');
            metin = metin.Replace('V', 'v');
            metin = metin.Replace('Y', 'y');
            metin = metin.Replace('Z', 'z');
            metin = metin.Replace('Q', 'q');
            metin = metin.Replace('X', 'x');
            metin = metin.Replace('W', 'w');

            return metin;
        }

        static public string ToLowerIngilizce(string metin)
        {
            metin = metin.Replace('A', 'a');
            metin = metin.Replace('B', 'b');
            metin = metin.Replace('C', 'c');
            metin = metin.Replace('Ç', 'c');
            metin = metin.Replace('D', 'd');
            metin = metin.Replace('E', 'e');
            metin = metin.Replace('F', 'f');
            metin = metin.Replace('G', 'g');
            metin = metin.Replace('Ğ', 'g');
            metin = metin.Replace('H', 'h');
            metin = metin.Replace('I', 'i');
            metin = metin.Replace('İ', 'i');
            metin = metin.Replace('J', 'j');
            metin = metin.Replace('K', 'k');
            metin = metin.Replace('L', 'l');
            metin = metin.Replace('M', 'm');
            metin = metin.Replace('N', 'n');
            metin = metin.Replace('O', 'o');
            metin = metin.Replace('Ö', 'ö');
            metin = metin.Replace('P', 'p');
            metin = metin.Replace('R', 'r');
            metin = metin.Replace('S', 's');
            metin = metin.Replace('Ş', 's');
            metin = metin.Replace('T', 't');
            metin = metin.Replace('U', 'u');
            metin = metin.Replace('Ü', 'ü');
            metin = metin.Replace('V', 'v');
            metin = metin.Replace('Y', 'y');
            metin = metin.Replace('Z', 'z');
            metin = metin.Replace('Q', 'q');
            metin = metin.Replace('X', 'x');
            metin = metin.Replace('W', 'w');

            return metin;
        }
    }
}
