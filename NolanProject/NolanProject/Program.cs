using NolanProject;
using System;
using System.Text.RegularExpressions;

namespace NolanProject
{
    class Program
    {
        public static int secilenfilm;
        public static int secilenSeans;
        public static string odemesekli;
        public static string odeme;

        static void Main(string[] args)
        {
           
            // Rezervasyonu alacak kullanıcının bilgilerini alıyoruz
            Console.Write("Adınız: ");
            string ad = Console.ReadLine();
            Console.Write("Soyadınız: ");
            string soyad = Console.ReadLine();
            Console.Write("E-posta adresiniz: ");
            string email = Console.ReadLine();
            Console.Write("Telefon numaranız: ");
            string telefon = Console.ReadLine();
            Console.Write("\n");

            // Film Secimleri 
            Film film1 = new Film();
            film1.Adi = "Oppenheimer";
            film1.Sure = 2.30;
            film1.FilmYonetmeni = "Christopher Nolan";

            Film film2 = new Film();
            film2.Adi = "The Prestige";
            film2.Sure = 2.10;
            film2.FilmYonetmeni = "Christopher Nolan";


            bool filmsecimi = true;
            while (filmsecimi)
            {
                try
                {
                    Console.WriteLine("Filmler \n1. " + film1.Adi + "\nSuresi:" + film1.Sure + "\nDirector:" + film1.FilmYonetmeni);
                    Console.WriteLine("2. " + film2.Adi + "\nSuresi:" + film2.Sure + "\nDirector:" + film2.FilmYonetmeni);
                    Console.Write("Film Seciniz :");
                    secilenfilm = Convert.ToInt32(Console.ReadLine());
                    
                }
                catch (Exception)
                {
                    Console.WriteLine("\nMevcut Filmleri Seciniz\n");
                    filmsecimi = true;
                }
                switch (secilenfilm)
                {
                    case 1:
                        Console.WriteLine("1.Filmi Sectiniz");
                        filmsecimi = false;
                        break;
                    case 2:
                        Console.WriteLine("2.Filmi Sectiniz");
                        filmsecimi = false;
                        break;
                    default:
                        Console.WriteLine("\nBu Film Mevcut Degil");
                        filmsecimi = true;
                        break; 


                }
            }
            Console.Write("\n");

            // Seans tarihi ve Saatini Seciyoruz
            Seans seans1 = new Seans();
            seans1.Tarih = DateTime.Now.Date;
            seans1.Saat = new TimeSpan(14, 0, 0);
            Seans seans2 = new Seans();
            seans2.Tarih = DateTime.Now.Date;
            seans2.Saat = new TimeSpan(22, 0, 0);
            
            Console.Write("\n");

            bool seanssecimi = true;
            while (seanssecimi)
            {
                try
                {
                    Console.WriteLine("Seanslar \n1. " + seans1.Tarih.ToString("dd.MM.yyyy") + " " + seans1.Saat.ToString(@"hh\:mm"));
                    Console.WriteLine("2. " + seans2.Tarih.ToString("dd.MM.yyyy") + " " + seans2.Saat.ToString(@"hh\:mm"));
                    Console.Write("Seans Seciniz :");
                    secilenSeans = Convert.ToInt32(Console.ReadLine());

                }
                catch (Exception)
                {
                    Console.WriteLine("\nMevcut Seanslari Seciniz\n");
                    seanssecimi = true;
                }
                switch (secilenSeans)
                {
                    case 1:
                        Console.WriteLine("1.Seansi Sectiniz");
                        seanssecimi  = false;
                        break;
                    case 2:
                        Console.WriteLine("2.Seansi Sectiniz");
                        seanssecimi = false;
                        break;
                    default:
                        Console.WriteLine("\nBu Seans Mevcut Degil");
                        seanssecimi = true;
                        break;


                }
            }
            Console.Write("\n");

            string[] bosKoltuklar = { "2A", "3A", "4A", "5A" };
            while (true)
            {
                Console.WriteLine("Boş koltuklar: " + string.Join(", ", bosKoltuklar));
                Console.Write("Lütfen boş bir koltuk seçin (örnek: 2A): ");
                string koltukNo = Console.ReadLine().ToUpper();

                // Koltuk numarasını doğru formatta mı girildiğini kontrol ediyoruz
                Regex regex = new Regex(@"^\d+[A-Z]$");
                if (!regex.IsMatch(koltukNo))
                {
                    Console.WriteLine("\nKoltuk numarası yanlış formatta. Lütfen doğru formatta girin. Örnek: 2A");
                    continue;
                }

                // Seçilen koltuğun boş olup olmadığını kontrol ediyoruz
                if (!bosKoltuklar.Contains(koltukNo))
                {
                    Console.WriteLine("\nSeçtiğiniz koltuk doludur. Lütfen boş bir koltuk seçin.");
                    continue;
                }

                

                // Koltuk seçimi doğru ise, while döngüsünden çıkılıyor.
                break;
            }
            Console.Write("\n");

            // Ödeme şeklini belirliyoruz 
            bool odemeseklie = true;
            while (odemeseklie)
            {
                try
                {
                    Console.Write("Ödeme şekli (nakit/kart): ");
                    string odemesekli = Console.ReadLine().ToLower();
                    odeme = odemesekli;
                    if (odemesekli == "nakit")
                    {
                        odemeseklie = false;

                    }
                    else if (odemesekli == "kart")
                    {
                        odemeseklie = false;
                        
                    }
                    
                }
                catch (Exception)
                {  
                    odemeseklie=true; 

                    
                } 
            }

            // Rezervasyonu oluşturuyoruz
            Rezervasyon rezervasyon = new Rezervasyon();
            rezervasyon.OdemeSekli = odemesekli;
            Rezervasyon rezervasyon1 = new Rezervasyon();
            rezervasyon1.Film = film1;
            rezervasyon1.Seans = seans1;
            Rezervasyon rezervasyon2 = new Rezervasyon();
            rezervasyon2.Film = film2;
            rezervasyon2.Seans = seans2;
            if (secilenfilm == 1)
            {
                rezervasyon1.Film.Adi = film1.Adi;
                if (secilenSeans == 1)
                {
                    rezervasyon1.Seans.Tarih = seans1.Tarih;
                    rezervasyon1.Seans.Saat = seans1.Saat;
                }
                else if (secilenSeans == 2)
                {
                    rezervasyon1.Seans.Tarih = seans2.Tarih;
                    rezervasyon1.Seans.Saat = seans2.Saat;
                }

            }
            else if (secilenfilm == 2)
            {
                rezervasyon2.Film.Adi = film2.Adi;
                if (secilenSeans == 1)
                {
                    rezervasyon2.Seans.Tarih = seans1.Tarih;
                    rezervasyon2.Seans.Saat = seans1.Saat;

                }
                else if (secilenSeans == 2)
                {
                    rezervasyon2.Seans.Tarih = seans2.Tarih;
                    rezervasyon2.Seans.Saat = seans2.Saat;
                }
                rezervasyon2.Film.Adi = film2.Adi;
            }

            // Rezervasyon bilgilerini ekrana yazdırıyoruz
            Console.WriteLine("\nRezervasyon Bilgileri:");
            Console.WriteLine("Adı: {0}", ad);
            Console.WriteLine("Soyadı: {0}", soyad);
            Console.WriteLine("E-posta adresi: {0}", email);
            Console.WriteLine("Telefon numarası: {0}", telefon);
            Console.WriteLine("Ödeme şekli: {0}", odeme);
            Console.WriteLine("Toplam tutar: {0:c}", rezervasyon.Tutar());

            switch (secilenfilm)
            {
                case 1:
                    Console.WriteLine("Film Adi: " + rezervasyon1.Film.Adi);
                    Console.WriteLine("Tarih: " + rezervasyon1.Seans.Tarih.ToString("dd.MM.yyyy"));
                    Console.WriteLine("Saat: " + rezervasyon1.Seans.Saat);
                    break;
                case 2:
                    Console.WriteLine("Film Adi: " + rezervasyon2.Film.Adi);
                    Console.WriteLine("Tarih: " + rezervasyon2.Seans.Tarih.ToString("dd.MM.yyyy"));
                    Console.WriteLine("Saat: " + rezervasyon2.Seans.Saat);
                    break;
            }
        

            // Rezervasyonu onaylamak isteyip istemediğini soruyoruz
            Console.Write("\nRezervasyonu onaylıyor musunuz? (E/H): ");
            string cevap = Console.ReadLine().ToUpper();

            if (cevap == "E")
            {
                // Rezervasyonu kaydediyoruz
                Console.WriteLine("\nRezervasyonunuz kaydedildi. İyi seyirler!");
            }
            else
            {
                // Rezervasyonu iptal ediyoruz
                Console.WriteLine("\nRezervasyon iptal edildi.");
            }

            Console.ReadLine();
        }
    }
}
