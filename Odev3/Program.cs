using System;

namespace Odev3
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.MusteriId = 1;
            musteri1.MusteriAdi = "Hatice Nur";
            musteri1.MusteriSoyadi = "KAYA";

            Musteri musteri2 = new Musteri();
            musteri2.MusteriId = 1;
            musteri2.MusteriAdi = "Ela Nur";
            musteri2.MusteriSoyadi = "KAYA";

            Musteri musteri3 = new Musteri();
            musteri3.MusteriId = 1;
            musteri3.MusteriAdi = "Kader Nur";
            musteri3.MusteriSoyadi = "KAYA";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Güncelle(musteriler);
            musteriManager.Sil(musteri1);
            musteriManager.Listele(musteri1);
        }
    }
}
