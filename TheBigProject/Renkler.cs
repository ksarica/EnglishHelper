using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBigProject
{

    public class Renkler
    {
        public int RenkIndeksi { get; set; }
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }
        public const int RenkLimiti = 20;


        public Renkler(int renkIndeksi)
        {
            this.RenkIndeksi = renkIndeksi;
            RenkAta();
        }

        public void RenkAta()
        {
            switch (RenkIndeksi)
            {
                case 0: // Sari
                    {
                        this.R = 255;
                        this.G = 255;
                        this.B = 51;
                        break;
                    }

                case 1: // Mavi
                    {
                        this.R = 83;
                        this.G = 141;
                        this.B = 246;
                        break;
                    }

                case 2: // Mor
                    {
                        this.R = 104;
                        this.G = 32;
                        this.B = 206;
                        break;
                    }

                case 3: // Yesil
                    {
                        this.R = 178;
                        this.G = 255;
                        this.B = 102;
                        break;
                    }

                case 4: // AcikMavi
                    {
                        this.R = 51;
                        this.G = 255;
                        this.B = 255;
                        break;
                    }

                case 5: // Kirmizi
                    {
                        this.R = 153;
                        this.G = 0;
                        this.B = 0;
                        break;
                    }

                case 6: // Turuncu
                    {
                        this.R = 255;
                        this.G = 128;
                        this.B = 0;
                        break;
                    }

                case 7: // Pembe
                    {
                        this.R = 255;
                        this.G = 153;
                        this.B = 204;
                        break;
                    }

                case 8: // Turkuaz
                    {
                        this.R = 0;
                        this.G = 153;
                        this.B = 153;
                        break;
                    }

                case 9: // Altin
                    {
                        this.R = 153;
                        this.G = 153;
                        this.B = 0;
                        break;
                    }

                case 10: // AcikKirmizi
                    {
                        this.R = 255;
                        this.G = 153;
                        this.B = 153;
                        break;
                    }

                case 11: // KoyuYesil
                    {
                        this.R = 0;
                        this.G = 102;
                        this.B = 0;
                        break;
                    }

                case 12: // Magenta
                    {
                        this.R = 186;
                        this.G = 79;
                        this.B = 218;
                        break;
                    }

                case 13: // Kahverengi
                    {
                        this.R = 102;
                        this.G = 51;
                        this.B = 0;
                        break;
                    }

                case 14: // ekstra renkler
                    {
                        this.R = 118;
                        this.G = 10;
                        this.B = 118;
                        break;
                    }

                case 15: // acik pembe
                    {
                        this.R = 205;
                        this.G = 170;
                        this.B = 231;
                        break;
                    }

                case 16: // eflatunsu mor
                    {
                        this.R = 151;
                        this.G = 130;
                        this.B = 228;
                        break;
                    }

                case 17: // gümüş rengi
                    {
                        this.R = 135;
                        this.G = 144;
                        this.B = 171;
                        break;
                    }

                case 18: // ekstra renkler
                    {
                        this.R = 182;
                        this.G = 199;
                        this.B = 90;
                        break;
                    }

                case 19: // ekstra renkler
                    {
                        this.R = 167;
                        this.G = 150;
                        this.B = 141;
                        break;
                    }

                default: // Beyaz
                    {
                        this.R = 255;
                        this.G = 255;
                        this.B = 255;
                        break;
                    }
            }
        }
    }
}
