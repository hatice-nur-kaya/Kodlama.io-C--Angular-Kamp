using System;
using System.Collections.Generic;
using System.Text;

namespace Odev3
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Sepete Eklendi." + musteri.MusteriAdi);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Sepetten Silindi." + musteri.MusteriAdi);
        }
        public void Güncelle(Musteri[] musteriler)
        {
            Console.WriteLine("Müşteri Listesi:");
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.MusteriAdi );
            }
            Console.WriteLine("");
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Sepete Listelendi." + musteri.MusteriAdi);
        }
    }
}
