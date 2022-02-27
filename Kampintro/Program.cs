using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety = tip güvenliği 
            string kategoriEtileti = "Kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false;
            if (sistemeGirisYapmisMi ==true)
            {
                Console.WriteLine("kullanıcı Ayarları butonu ");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu ");
            }

            Console.WriteLine(kategoriEtileti);


        }
    }
}
