using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TheBigProject
{
    public partial class UControlAnaliz : UserControl
    {
        string metniGeriGetir = string.Empty;
        public Dictionary<string, int> kelimeAyrintilari = new Dictionary<string, int>();
        public Dictionary<string, int> arananEleman = new Dictionary<string, int>();
        public List<int> indeksler = new List<int>();
        public List<int> kullanilanRenkler = new List<int>(); // şu an 20 renk ekledim en fazla 20 aranacak kelime için 20 ayri renk atayabilirim.
        public int sayac = 0;
        public bool temizleButonuKullanildi = false;
        string bilgiMesaji = "Kelime/Harf/Sembol Arayın.(Birden Fazla Aramak İçin Aralarına virgül koyun) Bu Yazıyı Temizlemek İçin Çift Tıklayın.";

        public UControlAnaliz()
        {
            InitializeComponent();
        }

        private void UControlAnaliz_Load(object sender, EventArgs e)
        {
            for (int i = 8; i <= 24; i++)
            {
                cmbFont.Items.Add(i); // combobox değerleri
            }
            txtAra.ForeColor = Color.Gray;
            txtAra.Text = bilgiMesaji;
        }

        private int metindekiKarakterSayisi(string metin)
        {
            int karakter = 0;

            while (karakter < metin.Length)
            {
                karakter++;
            }
            return karakter;
        }

        private int metindekiKelimeSayisi(string metin)
        {
            char[] ayirmaKarakterleri = { ' ' , '\'' ,'\n' , '\t' , ':', '“' ,'"', '´' ,'+','#','^','~',')','(',',', '.','!',
                '?','*','/', '\\' ,'{','}','=','_','-', '–' , '[',']', ';'
                ,'%' , '$' ,'€' , '₺' , '@', '¨' , '|' ,'&' , '<' , '>'};
            string[] tumKelimeler = rchVeri.Text.Split(ayirmaKarakterleri, StringSplitOptions.RemoveEmptyEntries);
            string[] duzenlenmisKelimeler = tumKelimeler.Where(eleman => eleman.Length > 1).ToArray();
            return duzenlenmisKelimeler.Length;
        } // geliştirilecek

        private string metindenSembolTemizle(string metin)
        {
            char[] ayirmaKarakterleri = { ' ' , '\'' ,'\n' , '\t' , ':', '’' ,'“' ,'"', '´' ,'+','#','^','~',')','(',',', '.','!',
                '?','*','/', '\\' ,'{','}','=','_','-', '–' , '[',']', ';' , '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'
                ,'%' , '$' ,'€' , '₺' , '@', '¨' , '|' ,'&' , '<' , '>'};
            string[] tumKelimeler = rchVeri.Text.Split(ayirmaKarakterleri, StringSplitOptions.RemoveEmptyEntries);

            StringBuilder duzenlenmisMetin = new StringBuilder();
            foreach (var kelime in tumKelimeler)
            {
                duzenlenmisMetin.Append(kelime + " ");
            }

            return duzenlenmisMetin.ToString();
        }

        private void richTextBoxRenkSifirla()
        {
            rchVeri.SelectionStart = 0;
            rchVeri.SelectAll(); // hepsini seç ve rengini normale çevir 
            rchVeri.SelectionBackColor = Color.FromArgb(224, 224, 224);
            rchVeri.SelectionStart = 0; // normale çevirdikten sonra selectionu sıfırla
        }

        private int kelimeHighlightla(List<string> kelimeler) // buna uğraş algoritması ağır geldi 
        {
            string duzenlenmisMetin = metindenSembolTemizle(rchVeri.Text);
            metniGeriGetir = rchVeri.Text;
            rchVeri.Text = duzenlenmisMetin; // sakin silme bunu yazıları highlightlarken yerleri kayar yoksa 
            Console.WriteLine("Kelimeler: ");
            Console.WriteLine(duzenlenmisMetin);

            Dictionary<string, Renkler> kelimeRenkleri = new Dictionary<string, Renkler>();
            var kelimelerSet = new HashSet<string>(kelimeler);
            int renkKodu = 0;

            foreach (var kelime in kelimeler)
            {
                renkKodu++;
                if (renkKodu >= Renkler.RenkLimiti) // Limit suan icin 20 array olarak son indeks = 19 oluyor 20 olursa 0 yapacaksın
                    renkKodu = 0;
                kelimeRenkleri.Add(kelime, new Renkler(renkKodu));
            }

            int kacTaneBulundu = 0;
            int baslangicIndeksi = 0;
            StringBuilder karsilastirilan = new StringBuilder();
            while (baslangicIndeksi < duzenlenmisMetin.Length)
            {
                Console.WriteLine("baslangicIndeksi: " + baslangicIndeksi + " " + duzenlenmisMetin[baslangicIndeksi] + " == " + " bosluk");
                if (duzenlenmisMetin[baslangicIndeksi] == ' ')
                {
                    Console.WriteLine("Bosluğa eşit olduğu için karsilastirilan string sıfırlanıyor");
                    karsilastirilan.Clear();
                }
                else
                {
                    Console.WriteLine("Bosluğa eşit olmadığı için karsilastirilan string append ediliyor");
                    while (duzenlenmisMetin[baslangicIndeksi] != ' ')
                    {
                        karsilastirilan.Append(duzenlenmisMetin[baslangicIndeksi]);
                        baslangicIndeksi++;
                    }
                    Console.WriteLine(karsilastirilan.ToString());
                    baslangicIndeksi--;

                    if (kelimelerSet.Contains(karsilastirilan.ToString()))
                    {
                        rchVeri.SelectionStart = baslangicIndeksi - karsilastirilan.Length + 1;
                        rchVeri.SelectionLength = karsilastirilan.Length;
                        rchVeri.SelectionBackColor = Color.FromArgb(0, kelimeRenkleri[karsilastirilan.ToString()].R, kelimeRenkleri[karsilastirilan.ToString()].G, kelimeRenkleri[karsilastirilan.ToString()].B);
                        rchVeri.Select(0, 0);
                        kacTaneBulundu++;
                    }

                }
                baslangicIndeksi++;
            }
            return kacTaneBulundu;
        }

        private List<string> IstisnaKelimeKaldir(List<string> kelimeler, string[] istisnaKelimeler)
        {
            foreach (var istisnaKelime in istisnaKelimeler)
            {
                while (kelimeler.Contains(istisnaKelime))
                {
                    kelimeler.Remove(istisnaKelime);
                }
            }
            return kelimeler;
        }

        private List<string> IstisnaKelimeKaldir(List<string> kelimeler, List<string> istisnaKelimeler) // override fonksiyon
        {
            foreach (var istisnaKelime in istisnaKelimeler)
            {
                while (kelimeler.Contains(istisnaKelime))
                {
                    kelimeler.Remove(istisnaKelime);
                }
            }
            return kelimeler;
        }

        private void btnAnaliz_Click(object sender, EventArgs e)
        {
            rchKaldirilanlar.Clear();
            kelimeAyrintilari.Clear();
            if (rchVeri.Text == string.Empty)
            {
                MessageBox.Show("Lütfen Analiz Yapmadan Önce Metni Yükleyin ve Metin Dilini Seçin");
                goto cikis;
            }
            if (metindekiKelimeSayisi(rchVeri.Text) == 0 && rchVeri.Text != string.Empty)
            {
                MessageBox.Show("Metinde anlamlı bir kelime yok.");
                goto cikis;
            }
            char[] ayirmaKarakterleri = { ' ' , '\'' ,'\n' , '\t' , ':', '“' ,'"' , '’' , '´' ,'+','#','^','~',')','(',',', '.','!',
                '?','*','/', '\\' ,'{','}','=','_','-', '–' , '[',']', ';' , '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'
                ,'%' , '$' ,'€' , '₺' , '@', '¨' , '|' ,'&' , '<' , '>'};
            char[] ayirmaKarakterleriRakamsiz = { ' ' , '\'' ,'\n' , '\t' , ':', '“', '’' ,'"', '´' ,'+','#','^','~',')','(',',', '.','!',
                '?','*','/', '\\' ,'{','}','=','_','-', '–' , '[',']', ';'
                ,'%' , '$' ,'€' , '₺' , '@', '¨' , '|' ,'&' , '<' , '>'};
            char[] kabulEdilenKarakterler = { 'a' , 'b' , 'c' , 'ç'  ,'d' , 'e' , 'f' , 'g' , 'ğ' , 'h' , 'ı' ,'i' , 'j', 'k', 'l', 'm',
                'n', 'o', 'ö', 'p', 'r' , 's', 'ş', 't', 'u', 'ü', 'v', 'y', 'z' , 'q', 'w' , 'x'
            , 'A', 'B' , 'C', 'Ç', 'D', 'E', 'F', 'G', 'Ğ', 'H', 'I', 'İ', 'J', 'K', 'L', 'M', 'N', 'O', 'Ö', 'P', 'R', 'S', 'Ş', 'T'
            , 'U', 'Ü', 'V', 'Y', 'Z' , 'Q' , 'W', 'X' , ' ' ,'\n'};

            char[] kabulEdilenKarakterlerRakamli = { 'a' , 'b' , 'c' , 'ç'  ,'d' , 'e' , 'f' , 'g' , 'ğ' , 'h' , 'ı' ,'i' , 'j', 'k', 'l', 'm',
                'n', 'o', 'ö', 'p', 'r' , 's', 'ş', 't', 'u', 'ü', 'v', 'y', 'z' , 'q', 'w' , 'x'
            , 'A', 'B' , 'C', 'Ç', 'D', 'E', 'F', 'G', 'Ğ', 'H', 'I', 'İ', 'J', 'K', 'L', 'M', 'N', 'O', 'Ö', 'P', 'R', 'S', 'Ş', 'T'
            , 'U', 'Ü', 'V', 'Y', 'Z' , 'Q' , 'W', 'X' , '0' , '1', '2', '3', '4', '5', '6', '7', '8', '9' , ' ' , '\n'};

            string[] istisnaKelimelerAyrintili = { "a", "about", "above", "after", "again", "against", "ain", "all", "am", "an", "and", "any", "are", "aren", "aren't", "as", "at", "be", "because", "been",
                "before", "being", "below", "between", "both", "but", "by", "can", "couldn", "couldn't", "d", "did", "didn", "didn't", "do", "does", "doesn", "doesn't", "doing", "don", "don't", "down",
                "during", "each", "few", "for", "from", "further", "had", "hadn", "hadn't", "has", "hasn", "hasn't", "have", "haven", "haven't", "having", "he", "her", "here", "hers", "herself", "him", "himself", "his", "how", "i", "if", "in", "into", "is", "isn", "isn't", "it", "it's", "its", "itself", "just", "ll", "m", "ma", "me", "mightn", "mightn't", "more", "most", "mustn", "mustn't", "my", "myself", "needn", "needn't", "no", "nor", "not", "now", "o", "of", "off", "on", "once", "only", "or", "other", "our", "ours", "ourselves", "out",
                "over", "own", "re", "s", "same", "shan", "shan't", "she", "she's", "should", "should've", "shouldn", "shouldn't", "so", "some", "such", "t", "than", "that", "that'll", "the", "their", "theirs", "them", "themselves", "then", "there", "these", "they", "this", "those", "through", "to", "too", "under", "until", "up", "ve", "very", "was", "wasn", "wasn't", "we", "were", "weren", "weren't", "what", "when", "where", "which", "while", "who", "whom", "why", "will", "with", "won", "won't", "wouldn", "wouldn't", "y", "you", "you'd",
                "you'll","ll" ,"you're", "you've", "your", "yours", "yourself", "yourselves", "could", "he'd", "he'll", "he's", "here's", "how's", "i'd", "i'll", "i'm", "i've", "let's", "ought", "she'd", "she'll", "that's", "there's", "they'd", "they'll", "they're", "they've", "we'd", "we'll", "we're", "we've", "what's", "when's", "where's", "who's", "why's", "would", "able", "abst", "accordance", "according",
                "accordingly", "across", "act", "actually", "added", "adj", "affected", "affecting", "affects", "afterwards", "ah", "almost", "alone", "along", "already", "also", "although",
                "always", "among", "amongst", "announce", "another", "anybody", "anyhow", "anymore", "anyone", "anything", "anyway", "anyways", "anywhere", "apparently", "approximately",
                "arent", "arise", "around", "aside", "ask", "asking", "auth", "available", "away", "awfully", "b", "back", "became", "become", "becomes", "becoming", "beforehand", "begin", "beginning", "beginnings","begins", "behind", "believe", "beside", "besides", "beyond", "biol", "brief", "briefly", "c", "ca", "came", "cannot", "can't", "cause", "causes", "certain", "certainly", "co", "com", "come", "comes", "contain", "containing", "contains", "couldnt", "date", "different", "done", "downwards", "due", "e", "ed", "edu", "effect", "eg",
                "eight", "eighty", "either", "else", "elsewhere", "end", "ending", "enough", "especially", "et", "etc", "even", "ever", "every", "everybody", "everyone", "everything", "everywhere", "ex", "except", "f", "far", "ff", "fifth", "first", "five", "fix", "followed", "following", "follows", "former", "formerly", "forth", "found", "four", "furthermore", "g", "gave", "get", "gets", "getting", "give", "given", "gives", "giving", "go", "goes", "gone", "got", "gotten", "h", "happens", "hardly", "hed", "hence", "hereafter", "hereby", "herein", "heres", "hereupon", "hes",
                "hi", "hid", "hither", "home", "howbeit", "however", "hundred", "id", "ie", "im", "immediate", "immediately", "importance", "important", "inc", "indeed", "index", "information", "instead", "invention", "inward", "itd", "it'll", "j", "k", "keep", "keeps", "kept", "kg", "km", "know", "known", "knows", "l", "largely", "last", "lately", "later", "latter", "latterly", "least", "less", "lest", "let", "lets", "like", "liked", "likely", "line", "little", "'ll", "look", "looking", "looks", "ltd", "made", "mainly", "make", "makes", "many", "may", "maybe", "mean",
                "means", "meantime", "meanwhile", "merely", "mg", "might", "million", "miss", "ml", "moreover", "mostly", "mr", "mrs", "much", "mug", "must", "n", "na", "name", "namely", "nay", "nd", "near", "nearly", "necessarily", "necessary", "need", "needs", "neither", "never", "nevertheless", "new", "next", "nine", "ninety", "nobody", "non", "none", "nonetheless", "noone", "normally", "nos", "noted", "nothing", "nowhere", "obtain", "obtained", "obviously", "often", "oh", "ok", "okay", "old", "omitted", "one", "ones", "onto", "ord", "others",
                "otherwise", "outside", "overall", "owing", "p", "page", "pages", "part", "particular", "particularly", "past", "per", "perhaps", "placed", "please", "plus", "poorly", "possible", "possibly", "potentially", "pp", "predominantly", "present", "previously", "primarily", "probably", "promptly", "proud", "provides", "put", "q", "que", "quickly", "quite", "qv", "r", "ran", "rather", "rd", "readily", "really", "recent", "recently", "ref", "refs", "regarding", "regardless", "regards", "related", "relatively", "research", "respectively", "resulted", "resulting",
                "results", "right", "run", "said", "saw", "say", "saying", "says", "sec", "section", "see", "seeing", "seem", "seemed", "seeming", "seems", "seen", "self", "selves", "sent", "seven", "several", "shall", "shed", "shes", "show", "showed", "shown", "showns", "shows", "significant", "significantly", "similar", "similarly", "since", "six", "slightly", "somebody", "somehow", "someone", "somethan", "something", "sometime", "sometimes", "somewhat", "somewhere", "soon", "sorry", "specifically", "specified", "specify", "specifying", "still",
                "stop", "strongly", "sub", "substantially", "successfully", "sufficiently", "suggest", "sup", "sure", "take", "taken", "taking", "tell", "tends", "th", "thank", "thanks", "thanx", "thats", "that've", "thence", "thereafter", "thereby", "thered", "therefore", "therein", "there'll", "thereof", "therere", "theres", "thereto", "thereupon", "there've", "theyd", "theyre", "think", "thou", "though", "thoughh", "thousand", "throug", "throughout", "thru", "thus", "til", "tip", "together", "took", "toward", "towards", "tried", "tries", "truly", "try", "trying", "ts",
                "twice", "two", "u", "un", "unfortunately", "unless", "unlike", "unlikely", "unto", "upon", "ups", "us", "use", "used", "useful", "usefully", "usefulness", "uses", "using", "usually", "v", "value", "various", "'ve", "via", "viz", "vol", "vols", "vs", "w", "want", "wants", "wasnt", "way", "wed", "welcome", "went", "werent", "whatever", "what'll", "whats", "whence", "whenever", "whereafter", "whereas", "whereby", "wherein", "wheres", "whereupon", "wherever", "whether", "whim", "whither", "whod", "whoever", "whole", "who'll", "whomever",
                "whos", "whose", "widely", "willing", "wish", "within", "without", "wont", "words", "world", "wouldnt", "www", "x", "yes", "yet", "youd", "youre", "z",
                "zero", "a's", "ain't", "allow", "allows", "apart", "appear", "appreciate", "appropriate", "associated", "best", "better", "c'mon", "c's", "cant", "changes", "clearly", "concerning", "consequently", "consider", "considering", "corresponding", "course", "currently", "definitely", "described", "despite", "entirely", "exactly", "example", "going", "greetings", "hello", "help", "hopefully", "ignored", "inasmuch", "indicate", "indicated", "indicates", "inner", "insofar", "it'd", "keep", "keeps", "novel", "presumably", "reasonably",
                "second", "secondly", "sensible", "serious", "seriously", "sure", "t's", "third", "thorough", "thoroughly", "three", "well", "wonder", "a", "about", "above", "above", "across", "after", "afterwards", "again", "against", "all", "almost", "alone", "along", "already", "also", "although", "always", "am", "among", "amongst", "amoungst", "amount", "an", "and", "another", "any", "anyhow", "anyone", "anything", "anyway", "anywhere", "are", "around", "as", "at", "back", "be", "became", "because", "become", "becomes", "becoming", "been", "before", "beforehand", "behind", "being",
                "below", "beside", "besides", "between", "beyond", "bill", "both", "bottom", "but", "by", "call", "can", "cannot", "cant", "co", "con", "could", "couldnt", "cry", "de", "describe", "detail", "do", "done", "down", "due", "during", "each", "eg", "eight", "either", "eleven", "else", "elsewhere", "empty", "enough", "etc", "even", "ever", "every", "everyone", "everything", "everywhere", "except", "few", "fifteen", "fify", "fill", "find", "fire", "first", "five", "for", "former", "formerly", "forty", "found", "four", "from", "front", "full", "further", "get", "give", "go", "had",
                "has", "hasnt", "have", "he", "hence", "her", "here", "hereafter", "hereby", "herein", "hereupon", "hers", "herself", "him", "himself", "his", "how", "however", "hundred", "ie", "if", "in", "inc", "indeed", "interest", "into", "is", "it", "its", "itself", "keep", "last", "latter", "latterly", "least", "less", "ltd", "made", "many", "may", "me", "meanwhile", "might", "mill", "mine", "more", "moreover", "most", "mostly", "move", "much", "must", "my", "myself", "name", "namely", "neither", "never", "nevertheless", "next", "nine",
                "no", "nobody", "none", "noone", "nor", "not", "nothing", "now", "nowhere", "of", "off", "often", "on", "once", "one", "only", "onto", "or", "other", "others", "otherwise", "our", "ours", "ourselves", "out", "over", "own", "part", "per", "perhaps", "please", "put", "rather", "re", "same", "see", "seem", "seemed", "seeming", "seems", "serious", "several", "she", "should", "show", "side", "since", "sincere", "six", "sixty", "so", "some", "somehow", "someone", "something", "sometime", "sometimes", "somewhere", "still", "such", "system", "take", "ten", "than", "that", "the",
                "their", "them", "themselves", "then", "thence", "there", "thereafter", "thereby", "therefore", "therein", "thereupon", "these", "they", "thickv", "thin", "third", "this", "those", "though", "three", "through", "throughout", "thru", "thus", "to", "together", "too", "top", "toward", "towards", "twelve", "twenty", "two", "un", "under", "until", "up", "upon", "us", "very", "via", "was", "we", "well", "were", "what", "whatever", "when", "whence", "whenever", "where", "whereafter", "whereas", "whereby", "wherein", "whereupon", "wherever",
                "whether", "which", "while", "whither", "who", "whoever", "whole", "whom", "whose", "why", "will", "with", "within", "without", "would", "yet", "you", "your", "yours", "yourself", "yourselves", "the", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "co", "op",
                "research-articl", "pagecount", "cit", "ibid", "les", "le", "au", "que", "est", "pas", "vol", "el", "los", "pp", "u201d", "well-b", "http", "volumtype", "par", "0o", "0s", "3a", "3b", "3d", "6b", "6o", "a1", "a2", "a3", "a4", "ab", "ac", "ad", "ae", "af", "ag", "aj", "al", "an", "ao", "ap", "ar", "av", "aw", "ax", "ay", "az", "b1", "b2", "b3", "ba", "bc", "bd", "be", "bi", "bj", "bk", "bl", "bn", "bp", "br", "bs", "bt", "bu", "bx", "c1", "c2", "c3", "cc", "cd", "ce", "cf", "cg", "ch", "ci", "cj", "cl", "cm", "cn", "cp", "cq", "cr", "cs", "ct", "cu", "cv", "cx", "cy", "cz",
                "d2", "da", "dc", "dd", "de", "df", "di", "dj", "dk", "dl", "do", "dp", "dr", "ds", "dt", "du", "dx", "dy", "e2", "e3", "ea", "ec", "ed", "ee", "ef", "ei", "ej", "el", "em", "en", "eo", "ep", "eq", "er", "es", "et", "eu", "ev", "ex", "ey", "f2", "fa", "fc", "ff", "fi", "fj", "fl", "fn", "fo", "fr", "fs", "ft", "fu", "fy", "ga", "ge", "gi", "gj", "gl", "go", "gr", "gs", "gy", "h2", "h3", "hh", "hi", "hj", "ho", "hr", "hs", "hu", "hy", "i", "i2", "i3", "i4", "i6", "i7", "i8", "ia", "ib", "ic", "ie", "ig", "ih", "ii", "ij", "il", "in",
                "io", "ip", "iq", "ir", "iv", "ix", "iy", "iz", "jj", "jr", "js", "jt", "ju", "ke", "kg", "kj", "km", "ko", "l2", "la", "lb", "lc", "lf", "lj", "ln", "lo", "lr", "ls", "lt", "m2", "ml", "mn", "mo", "ms", "mt", "mu", "n2", "nc", "nd", "ne", "ng", "ni", "nj", "nl", "nn", "nr", "ns", "nt", "ny", "oa", "ob", "oc", "od", "of", "og", "oi", "oj", "ol", "om", "on", "oo", "oq", "or", "os", "ot", "ou", "ow", "ox", "oz", "p1", "p2", "p3", "pc", "pd", "pe", "pf", "ph", "pi", "pj", "pk", "pl", "pm", "pn", "po", "pq", "pr", "ps", "pt", "pu", "py", "qj", "qu", "r2", "ra", "rc", "rd", "rf",
                "rh", "ri", "rj", "rl", "rm", "rn", "ro", "rq", "rr", "rs", "rt", "ru", "rv", "ry", "s2", "sa", "sc", "sd", "se", "sf", "si", "sj", "sl", "sm", "sn", "sp", "sq", "sr", "ss", "st", "sy", "sz", "t1", "t2", "t3", "tb", "tc", "td", "te", "tf", "th", "ti", "tj", "tl", "tm", "tn", "tp", "tq", "tr", "ts", "tt", "tv", "tx", "ue", "ui", "uj", "uk", "um", "un", "uo", "ur", "ut", "va", "wa", "vd", "wi", "vj", "vo", "wo", "vq", "vt", "vu", "x1", "x2", "x3", "xf", "xi", "xj", "xk", "xl", "xn", "xo", "xs", "xt", "xv", "xx", "y2", "yj", "yl", "yr", "ys", "yt", "zi", "zz" };


            string[] istisnaKelimelerOptimal = {"ll", "a", "about", "above", "after", "again", "against", "all", "am", "an", "and", "any", "are", "aren't", "as", "at", "be", "because", "been", "before", "being", "below",
                "between", "both", "but", "by", "can", "can't", "cannot", "could", "couldn't", "did", "didn't", "do", "does", "doesn't", "doing", "don't", "down", "during", "each", "few", "for",
                "from", "further", "had", "hadn't", "has", "hasn't", "have", "haven't", "having", "he", "he'd", "he'll", "he's", "her", "here", "here's", "hers", "herself", "him", "himself", "his", "how", "how's",
                "i", "i'd", "i'll", "i'm", "i've", "if", "in", "into", "is", "isn't", "it", "it's", "its", "itself", "let's", "me", "more", "most", "mustn't", "my", "myself", "no", "nor", "not", "of", "off", "on",
                "once", "only", "or", "other", "ought", "our", "ours", "ourselves", "out", "over", "own", "same", "shan't", "she", "she'd", "she'll", "she's", "should", "shouldn't", "so", "some", "such", "than",
                "that", "that's", "the", "their", "theirs", "them", "themselves", "then", "there", "there's", "these", "they", "they'd", "they'll", "they're", "they've", "this", "those", "through",
                "to", "too", "under", "until", "up", "very", "was", "wasn't", "we", "we'd", "we'll", "we're", "we've", "were", "weren't", "what", "what's", "when", "when's", "where", "where's", "which", "while",
                "who", "who's", "whom", "why", "why's", "with", "won't", "would", "wouldn't", "you", "you'd", "you'll", "you're", "you've", "your", "yours", "yourself", "yourselves"};
            string[] istisnaKelimelerKullanici;
            string[] tumKelimeler;

            if (checkRakam.Checked == true) // rakamlar çıkarılsın demek
            {
                string metin = StringKaan.MetindenBelliKarakterlerHariciniKaldir(rchVeri.Text, kabulEdilenKarakterler);
                tumKelimeler = metin.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                //tumKelimeler = rchVeri.Text.Split(ayirmaKarakterleri, StringSplitOptions.RemoveEmptyEntries);
            }
            else // rakamları çıkarma demek
            {
                string metin = StringKaan.MetindenBelliKarakterlerHariciniKaldir(rchVeri.Text, kabulEdilenKarakterlerRakamli);
                tumKelimeler = metin.Split(new char[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                //tumKelimeler = rchVeri.Text.Split(ayirmaKarakterleriRakamsiz, StringSplitOptions.RemoveEmptyEntries);
            }

            List<string> duzenlenmisKelimeler = new List<string>();
            List<string> kaldirilmayanKelimeler = new List<string>();

            if (cmbIstisna.SelectedItem == cmbIstisna.Items[4]) // KELIME ÇIKARMAYIN
            {
                duzenlenmisKelimeler = tumKelimeler.ToList();
            }
            else
            {
                duzenlenmisKelimeler = tumKelimeler.Where(eleman => eleman.Length > 1).ToList();
            }

            ///////// ---------------- DIL SECIMI -------------------  //////////

            if (cmbDil.Text == "İngilizce") // türkçe karakter kaldır
            {
                duzenlenmisKelimeler = duzenlenmisKelimeler.ConvertAll(eleman => OzelFonksiyonlar.TurkceKarakterKaldir(eleman));
                duzenlenmisKelimeler = duzenlenmisKelimeler.ConvertAll(eleman => OzelFonksiyonlar.ToLowerIngilizce(eleman));
            }
            else if (cmbDil.Text == "Türkçe") // türkçe karakterleri dahil et
            {
                duzenlenmisKelimeler = duzenlenmisKelimeler.ConvertAll(eleman => OzelFonksiyonlar.ToLowerTurkce(eleman));
            }
            else
            {
                MessageBox.Show("Dil Seçiminde Bir Hata Oluştu");
                goto cikis;
            }

            /////////------------- ISTISNA KELIMELER MENUSU SECIMI --------------- //////////

            if (cmbIstisna.SelectedItem == cmbIstisna.Items[0]) // OPTIMAL KELIMELER
            {
                //kaldirilmayanKelimeler = duzenlenmisKelimeler; // böyle yapma çünkü listler ref alıyor birinin değeri değişince diğeri de değişiyor eleman sayılar hep aynı kalır yani
                foreach (var kelime in duzenlenmisKelimeler)
                {
                    kaldirilmayanKelimeler.Add(kelime); // böyle yaparsan birbirlerini point etmezler
                }
                IstisnaKelimeKaldir(kaldirilmayanKelimeler, istisnaKelimelerOptimal);
            }
            else if (cmbIstisna.SelectedItem == cmbIstisna.Items[1]) // AYRINTILI
            {
                //kaldirilmayanKelimeler = duzenlenmisKelimeler; // böyle yapma çünkü listler ref alıyor birinin değeri değişince diğeri de değişiyor eleman sayılar hep aynı kalır yani
                foreach (var kelime in duzenlenmisKelimeler)
                {
                    kaldirilmayanKelimeler.Add(kelime); // böyle yaparsan birbirlerini point etmezler
                }
                IstisnaKelimeKaldir(kaldirilmayanKelimeler, istisnaKelimelerAyrintili);
            }
            else if (cmbIstisna.SelectedItem == cmbIstisna.Items[2]) // SİZİN EKLEDİKLERİNİZ
            {
                char[] karakterler = { ' ', '\n' };
                if (rchYasakKelimeler.Text == string.Empty)
                {
                    MessageBox.Show("İstisna Edilmesi İçin Hiç Kelime Girmediniz Hiçbir şey İstisna Edilmesini İstemiyorsanız 'KELİME ÇIKARMAYIN' Seçeneğini Seçin");
                    goto cikis;
                }

                istisnaKelimelerKullanici = rchYasakKelimeler.Text.Split(karakterler, StringSplitOptions.RemoveEmptyEntries);
                List<string> istisnaKelimelerKullaniciList = istisnaKelimelerKullanici.ToList();

                if (cmbDil.Text == "İngilizce")
                {
                    istisnaKelimelerKullaniciList = istisnaKelimelerKullaniciList.ConvertAll(istisnaKelime => OzelFonksiyonlar.ToLowerIngilizce(istisnaKelime));
                }
                if (cmbDil.Text == "Türkçe")
                {
                    istisnaKelimelerKullaniciList = istisnaKelimelerKullaniciList.ConvertAll(istisnaKelime => OzelFonksiyonlar.ToLowerTurkce(istisnaKelime));
                }

                //kaldirilmayanKelimeler = duzenlenmisKelimeler; // böyle yapma çünkü listler ref alıyor birinin değeri değişince diğeri de değişiyor eleman sayılar hep aynı kalır yani
                foreach (var kelime in duzenlenmisKelimeler)
                {
                    kaldirilmayanKelimeler.Add(kelime); // böyle yaparsan birbirlerini point etmezler
                }
                IstisnaKelimeKaldir(kaldirilmayanKelimeler, istisnaKelimelerKullaniciList);
            }
            else if (cmbIstisna.SelectedItem == cmbIstisna.Items[3]) // OPTİMAL + SİZİN EKLEDİKLERİNİZ
            {
                char[] karakterler = { ' ', '\n' };
                istisnaKelimelerKullanici = rchYasakKelimeler.Text.Split(karakterler, StringSplitOptions.RemoveEmptyEntries);

                List<string> istisnaKelimelerKullaniciList = istisnaKelimelerKullanici.ToList();
                List<string> istisnaKelimelerOptimalList = istisnaKelimelerOptimal.ToList();

                if (cmbDil.Text == "İngilizce")
                {
                    istisnaKelimelerKullaniciList = istisnaKelimelerKullaniciList.ConvertAll(istisnaKelime => OzelFonksiyonlar.ToLowerIngilizce(istisnaKelime));
                    foreach (var istisnaKelime in istisnaKelimelerKullaniciList)
                    {
                        if (!istisnaKelimelerOptimalList.Contains(istisnaKelime))
                        {
                            istisnaKelimelerOptimalList.Add(istisnaKelime);
                        }
                    }
                }
                if (cmbDil.Text == "Türkçe")
                {
                    istisnaKelimelerKullaniciList = istisnaKelimelerKullaniciList.ConvertAll(istisnaKelime => OzelFonksiyonlar.ToLowerTurkce(istisnaKelime));
                    foreach (var istisnaKelime in istisnaKelimelerKullaniciList)
                    {
                        if (!istisnaKelimelerOptimalList.Contains(istisnaKelime))
                        {
                            istisnaKelimelerOptimalList.Add(istisnaKelime);
                        }
                    }
                }
                //kaldirilmayanKelimeler = duzenlenmisKelimeler; // böyle yapma çünkü listler ref alıyor birinin değeri değişince diğeri de değişiyor eleman sayılar hep aynı kalır yani
                foreach (var kelime in duzenlenmisKelimeler)
                {
                    kaldirilmayanKelimeler.Add(kelime); // böyle yaparsan birbirlerini point etmezler
                }
                IstisnaKelimeKaldir(kaldirilmayanKelimeler, istisnaKelimelerOptimalList);
            }
            else if (cmbIstisna.SelectedItem == cmbIstisna.Items[4]) // KELIME ÇIKARMAYIN
            {
                MessageBox.Show("Normal Analiz Yapılacak Hiçbir Şey İstisna Edilmeyecek");
            }
            else
            {
                MessageBox.Show("Seçimde Bir Hata Oluştu");
                goto cikis;
            }

            ////////////////////////////////////////////////////////////////////////////////////////////

            if (cmbIstisna.SelectedItem == cmbIstisna.Items[4])
            {
                rchKaldirilanlar.AppendText("Kaldirilacak Kelime Yok");
            }
            else
            {
                int kaldirilanKelime = 0;
                int kaldirilanToplam = 0;
                rchKaldirilanlar.AppendText("Kaldirilan Kelimeler Sunlar : \n");
                foreach (var kelime in duzenlenmisKelimeler)
                {
                    if (!kaldirilmayanKelimeler.Contains(kelime)) // kelime kaldirilmayanlar listinde yoksa kaldirilmis demektir
                    {
                        if (!rchKaldirilanlar.Text.Contains(kelime))
                        {
                            rchKaldirilanlar.AppendText(kelime + " ");
                            kaldirilanKelime++;
                        }
                        kaldirilanToplam++;
                    }
                }
                rchKaldirilanlar.AppendText("\nKaldirilan Farkli Kelime Sayisi: " + kaldirilanKelime);
                rchKaldirilanlar.AppendText("\nKaldirilan Toplam Kelime Sayisi: " + kaldirilanToplam);
            }


            //if (kaldirilmayanKelimeler.Count != 0)
            if (cmbIstisna.SelectedItem != cmbIstisna.Items[4])
                duzenlenmisKelimeler = kaldirilmayanKelimeler;

            ////////////////////////////////////////////////////////////////////////////////////////////
            //Dictionary<string, int> kelimeAyrintilari = new Dictionary<string, int>();
            int bulunanKelimeToplam = 0;

            foreach (var kelime in duzenlenmisKelimeler) // eleman tekrari önleme
            {
                if (!kelimeAyrintilari.Keys.Contains(kelime))
                {
                    kelimeAyrintilari.Add(kelime, 1);
                }
                else
                {
                    kelimeAyrintilari[kelime] += 1;
                }
                bulunanKelimeToplam++;
            }
            if (rchVeri.Text != string.Empty)
            {
                IstatistikEkrani istatistikEkrani = new IstatistikEkrani(kelimeAyrintilari);
                istatistikEkrani.FormClosed += OnIstatistikEkraniClosed;
                btnAyrintilar.Enabled = false;
                istatistikEkrani.Show();
            }
            cikis:;
        }

        public void btnAra_Click(object sender, EventArgs e)
        {
            arananEleman.Clear();
            temizleButonuKullanildi = false;
            if (rchVeri.Text == string.Empty)
            {
                MessageBox.Show("Lütfen Aramadan Önce Metni Yükleyin");
                goto cikis;
            }
            if (txtAra.Text == string.Empty || txtAra.Text == bilgiMesaji)
            {
                MessageBox.Show("Aranacak Eleman Girmediniz !");
                goto cikis;
            }
            else
            {
                string[] kelimeler = txtAra.Text.Split(',');
                List<string> kelimelerList = new List<string>();

                for (int i = 0; i < kelimeler.Length; i++)
                {
                    if (!kelimelerList.Contains(kelimeler[i])) // search ekraninda ayni kelime yazilirsa onu almamasi icin yapildi
                    {
                        kelimelerList.Add(kelimeler[i]);
                    }
                }

                int bulunanKelimeKacTane;
                int bulunanKelimeToplam = 0;
                int kelimeIndeks = 0;
                lblKelimeSayac.Text = bulunanKelimeToplam.ToString();
                List<int> kullanilanRenkler = new List<int>(); // şu an 20 renk ekledim en fazla 20 aranacak kelime için 20 ayri renk atayabilirim.
                foreach (string kelime in kelimelerList)
                {
                    bulunanKelimeKacTane = 0;
                    Random rastgele = new Random();
                    int kod = rastgele.Next(0, Renkler.RenkLimiti);
                    int baslangicIndeksi = 0;

                    if (kullanilanRenkler.Count == Renkler.RenkLimiti) // atanacak renk kalmadiğinda yani 20 den fazla eleman ararsak bu listi sifirlayarak ayni renkleri yine rastgele seciyor 
                        kullanilanRenkler.Clear();

                    while (kullanilanRenkler.Contains(kod)) // renk cakismasi olmamasi icin eger kullanilan renk gelirse baska renk gelene kadar döngü devam ediyor
                    {
                        kod = rastgele.Next(0, Renkler.RenkLimiti);
                    } // random oldugu icin performans sıkıntısı olabilir ama 20 renk olduğu için bu bilgisayar için çok masrafli değil bence
                    kullanilanRenkler.Add(kod);

                    Renkler renkler = new Renkler(kod);
                    while (baslangicIndeksi < rchVeri.TextLength)
                    {
                        int kelimeBaslangicIndeksi = rchVeri.Find(kelime, baslangicIndeksi, RichTextBoxFinds.None);

                        if (kelimeBaslangicIndeksi != -1) // kelime bulunduysa
                        {
                            bulunanKelimeKacTane++;
                            bulunanKelimeToplam++;

                            lblKelimeSayac.Text = bulunanKelimeToplam.ToString();

                            rchVeri.SelectionStart = kelimeBaslangicIndeksi;
                            rchVeri.SelectionLength = kelime.Length;

                            rchVeri.SelectionBackColor = Color.FromArgb(0, renkler.R, renkler.G, renkler.B);
                            rchVeri.Select(0, 0);
                        }
                        else
                        {
                            break;
                        }

                        baslangicIndeksi = kelimeBaslangicIndeksi + kelime.Length;
                    }
                    if (!arananEleman.ContainsKey(kelime)) // ayni kelimenin liste eklenmemesi icin
                    {
                        arananEleman.Add(kelime, bulunanKelimeKacTane);
                    }
                    kelimeIndeks++;
                }
                if (bulunanKelimeToplam == 0)
                {
                    MessageBox.Show("Hiç eleman bulunamadı");
                    goto cikis;
                }
            }
            if (checkBildirim.Checked == true)
            {
                MessageBox.Show("Arama Tamamlandı! Ekranda Bulunan Kelimeleri Renkli Olarak Görebilirsiniz Detaylar İçin Ayrıntılar Butonunu Kullanın.");
            }

            cikis:;
        }

        private void btnSqlAra_Click(object sender, EventArgs e) //burada kaldın
        {
            arananEleman.Clear();
            temizleButonuKullanildi = false;
            if (rchVeri.Text == string.Empty)
            {
                MessageBox.Show("Lütfen Aramadan Önce Metni Yükleyin");
                goto cikis;
            }

            char[] ayirmaKarakterleri = { ' ' , '\'' ,'\n' , '\t' , ':', '“' ,'"', '´' ,'+','#','^','~',')','(',',', '.','!',
                '?','*','/', '\\' ,'{','}','=','_','-', '–' , '[',']', ';' , '0', '1', '2', '3', '4', '5', '6', '7', '8', '9'
                ,'%' , '$' ,'€' , '₺' , '@', '¨' , '|' ,'&' , '<' , '>'};

            string[] istisnaKelimelerOptimal = { "a", "about", "above", "after", "again", "against", "all", "am", "an", "and", "any", "are", "aren't", "as", "at", "be", "because", "been", "before", "being", "below",
                "between", "both", "but", "by", "can", "can't", "cannot", "could", "couldn't", "did", "didn't", "do", "does", "doesn't", "doing", "don't", "down", "during", "each", "few", "for",
                "from", "further", "had", "hadn't", "has", "hasn't", "have", "haven't", "having", "he", "he'd", "he'll", "he's", "her", "here", "here's", "hers", "herself", "him", "himself", "his", "how", "how's",
                "i", "i'd", "i'll", "i'm", "i've", "if", "in", "into", "is", "isn't", "it", "it's", "its", "itself", "let's", "me", "more", "most", "mustn't", "my", "myself", "no", "nor", "not", "of", "off", "on",
                "once", "only", "or", "other", "ought", "our", "ours", "ourselves", "out", "over", "own", "same", "shan't", "she", "she'd", "she'll", "she's", "should", "shouldn't", "so", "some", "such", "than",
                "that", "that's", "the", "their", "theirs", "them", "themselves", "then", "there", "there's", "these", "they", "they'd", "they'll", "they're", "they've", "this", "those", "through",
                "to", "too", "under", "until", "up", "very", "was", "wasn't", "we", "we'd", "we'll", "we're", "we've", "were", "weren't", "what", "what's", "when", "when's", "where", "where's", "which", "while",
                "who", "who's", "whom", "why", "why's", "with", "won't", "would", "wouldn't", "you", "you'd", "you'll", "you're", "you've", "your", "yours", "yourself", "yourselves"};
            KelimeHavuzuDal kelimeHavuzuDal = new KelimeHavuzuDal();
            List<string> yasakliKelimeler = new List<string>();
            yasakliKelimeler = kelimeHavuzuDal.KelimeleriGetir();

            if (yasakliKelimeler.Count <= 0)
            {
                return;
            }

            foreach (var kelime in istisnaKelimelerOptimal)
            {
                yasakliKelimeler.Add(kelime);
            }

            string[] tumKelimeler;
            List<string> tumKelimelerList = new List<string>();

            tumKelimeler = rchVeri.Text.Split(ayirmaKarakterleri, StringSplitOptions.RemoveEmptyEntries);
            tumKelimelerList = tumKelimeler.Where(eleman => eleman.Length > 1).ToList();

            ///////////////////////////////////////////////////////////////////////
            // ----------------------ARAMA BÖLÜMÜ--------------------------------//
            ///////////////////////////////////////////////////////////////////////
            //int kacKelimeBulundu = 0;

            List<string> boyanacaklar = new List<string>();
            foreach (var kelime in tumKelimelerList)
            {
                if (!yasakliKelimeler.Contains(kelime)) // ayni kelimenin liste eklenmemesi icin
                {
                    if (!arananEleman.Keys.Contains(kelime))
                    {
                        boyanacaklar.Add(kelime);
                        arananEleman.Add(kelime, 1);
                    }
                    else
                    {
                        arananEleman[kelime] += 1;
                    }
                }
            }

            lblKelimeSayac.Text = kelimeHighlightla(boyanacaklar).ToString();

            //foreach (KeyValuePair<string, int> kelime in arananEleman)
            //{
            //    kacKelimeBulundu = kelimeHighlightla(kelime.Key);
            //}

            if (arananEleman.Count == 0)
            {
                MessageBox.Show("Hiç eleman bulunamadı");
                goto cikis;
            }

            if (rchVeri.Text != string.Empty)
            {
                IstatistikEkrani istatistikEkrani = new IstatistikEkrani(arananEleman);
                istatistikEkrani.ShowDialog();
            }

            cikis:;
        }

        private void txtAra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
            }
        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            indeksler.Clear();
            string siradakiKelime;
            if (temizleButonuKullanildi)
            {
                MessageBox.Show("Görüntülenecek Eleman Yok !");
                goto cikis;
            }
            else
            {
                List<string> bulunanKelimeler = new List<string>();
                if (rchVeri.Text == string.Empty)
                {
                    MessageBox.Show("Lütfen Aramadan Önce Metni Yükleyin");
                    goto cikis;
                }
                if (txtAra.Text == string.Empty || txtAra.Text == bilgiMesaji)
                {
                    MessageBox.Show("Aranacak Eleman Girmediniz !");
                    goto cikis;
                }
                else
                {
                    string[] kelimeler = txtAra.Text.Split(',');
                    List<string> kelimelerList = new List<string>();

                    for (int i = 0; i < kelimeler.Length; i++)
                    {
                        if (!kelimelerList.Contains(kelimeler[i])) // search ekraninda ayni kelime yazilirsa onu almamasi icin yapildi
                        {
                            kelimelerList.Add(kelimeler[i]);
                        }
                    }
                    foreach (string kelime in kelimelerList)
                    {
                        int baslangicIndeksi = 0;

                        while (baslangicIndeksi < rchVeri.TextLength)
                        {
                            int kelimeBaslangicIndeksi = rchVeri.Find(kelime, baslangicIndeksi, RichTextBoxFinds.None);

                            if (kelimeBaslangicIndeksi != -1) // kelime bulunduysa
                            {
                                rchVeri.Select(0, 0);
                                bulunanKelimeler.Add(kelime);
                            }
                            else
                            {
                                break;
                            }

                            baslangicIndeksi = kelimeBaslangicIndeksi + kelime.Length;
                            indeksler.Add(baslangicIndeksi);
                        }
                    }
                }

                if (sayac == 0)
                {
                    if (bulunanKelimeler.Count <= 1)
                    {
                        siradakiKelime = bulunanKelimeler[sayac];
                    }
                    else
                    {
                        siradakiKelime = bulunanKelimeler[sayac + 1];
                    }
                }
                else
                    siradakiKelime = bulunanKelimeler[sayac - 1];

                if (sayac >= indeksler.Count || sayac < 0) // 0 1 2 3 4
                {
                    sayac = 0;
                    if (checkBildirim.Checked == true)
                        MessageBox.Show("Tüm Elemanlar Dolaşıldı Başa Dönülüyor...");
                }
                if (siradakiKelime != bulunanKelimeler[sayac]) // siradakiKelime bir butona basılmadan önceki kalan kelime oluyor
                {
                    if (checkBildirim.Checked == true)
                        MessageBox.Show("Sıradaki Kelime: " + bulunanKelimeler[sayac]);
                }

                rchVeri.SelectionStart = indeksler[sayac] - bulunanKelimeler[sayac].Length;
                rchVeri.SelectionLength = bulunanKelimeler[sayac].Length;
                rchVeri.Focus(); // believe believe believe honor honor
                sayac++;
                //if (sayac >= indeksler.Count || sayac < 0) // 0 1 2 3 4
                //{
                //    sayac = 0;
                //}
            }
            cikis:;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            rchKaldirilanlar.Text = string.Empty;
            lblKelimeSayac.Text = "0";
            richTextBoxRenkSifirla();
            arananEleman.Clear();
            sayac = 0;
            indeksler.Clear();
            temizleButonuKullanildi = true;
        }

        private void rchVeri_TextChanged(object sender, EventArgs e)
        {
            lblKarakterDeger.Text = metindekiKarakterSayisi(rchVeri.Text).ToString();
            lblKelimeDeger.Text = metindekiKelimeSayisi(rchVeri.Text).ToString();
        }

        private void btnAyrintilar_Click(object sender, EventArgs e)
        {
            if (txtAra.Text != string.Empty && txtAra.Text != bilgiMesaji)
            {
                IstatistikEkrani istatistikEkrani = new IstatistikEkrani(arananEleman);
                istatistikEkrani.FormClosed += OnIstatistikEkraniClosed;
                btnAyrintilar.Enabled = false;
                istatistikEkrani.Show();
                //IstatistikEkrani.GetForm.Show();
            }
            else
                MessageBox.Show("Aranacak Eleman Girmediniz !");
        }

        private void OnIstatistikEkraniClosed(object sender, FormClosedEventArgs e)
        {
            btnAyrintilar.Enabled = true;
        }

        private void btnDosyaEkle_Click(object sender, EventArgs e)
        {
            Stream dosya;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    dosya = openFileDialog1.OpenFile();
                    string dosyaAdi = openFileDialog1.FileName;
                    string dosyaMetni = File.ReadAllText(dosyaAdi, Encoding.GetEncoding("UTF-8"));
                    rchVeri.Text = dosyaMetni;
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void btnTurkce_Click(object sender, EventArgs e)
        {
            //    ç, ı, ü, ğ, ö, ş,
            string cevrilecekMetin;
            cevrilecekMetin = OzelFonksiyonlar.TurkceKarakterKaldir(rchVeri.Text);
            rchVeri.Text = cevrilecekMetin;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.CreatePrompt = false;
            saveFileDialog.OverwritePrompt = true;
            saveFileDialog.FileName = "dosyaAdi";
            saveFileDialog.DefaultExt = "rtf";
            saveFileDialog.Filter =
                "RTF Formati (*.rtf)|*.rtf|Tum Dosyalar (*.*)|*.*";
            saveFileDialog.InitialDirectory =
                Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory); // açılan pencere masaüstündeki dosyaları gösteriyor böyle yapınca

            DialogResult result = saveFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    rchVeri.SaveFile(saveFileDialog.FileName);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.CreatePrompt = false;
            saveFileDialog.OverwritePrompt = false;
            saveFileDialog.FileName = "dosyaAdi";
            saveFileDialog.DefaultExt = "rtf";
            saveFileDialog.Filter =
                "RTF Formati (*.rtf)|*.rtf|Tum Dosyalar (*.*)|*.*";
            saveFileDialog.InitialDirectory =
                Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    rchVeri.LoadFile(saveFileDialog.FileName);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }

        }

        private void txtAra_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            txtAra.Text = string.Empty;
            txtAra.ForeColor = Color.DarkSalmon;
        }

        private void cmbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            rchVeri.Font = new Font("Microsoft Sans Serif", Convert.ToInt16(cmbFont.Text));
        }

        private void btnEskiHal_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(metniGeriGetir))
            {
                rchVeri.Text = metniGeriGetir;
            }
            else
            {
                MessageBox.Show("Metinde herhangi bir değişiklik yapılmadı. Bu butonu Kaydedilmeyen Kelime Ara Butonunu Kullandıysanız Kullanın !");
                return;
            }
            richTextBoxRenkSifirla();
            MessageBox.Show("Metin Hafızadaki Değere Geri Çekildi !");
        }

        private void btnHafiza_Click(object sender, EventArgs e)
        {
            metniGeriGetir = rchVeri.Text;
            MessageBox.Show("Metin Hafızaya Kaydedildi !");
        }

    }
}

