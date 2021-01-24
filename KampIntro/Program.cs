using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety = tip güvenliği
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;
            double faizeOrani = 1.45;
            bool sistemeGirisYapmismi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.55;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Degismedi butonu");
            }
            if (sistemeGirisYapmismi == true)
            {
                Console.WriteLine("Kullanıcı ayaları butonu");
            }
            else
            {
                Console.WriteLine("Giris yap butonu");
            }
            
            
           


            
           

        }
    }
}
