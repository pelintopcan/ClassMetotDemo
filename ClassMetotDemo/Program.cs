using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        { 
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Pelin";
            musteri1.Soyadi = "Topcan";
            musteri1.Yas = 19;
            musteri1.Bakiye = 402.98;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Melisa";
            musteri2.Soyadi = "Yıldız";
            musteri2.Yas = 20;
            musteri2.Bakiye = 890.09;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Deniz";
            musteri3.Soyadi = "Arslan";
            musteri3.Yas = 30;
            musteri3.Bakiye = 7869.45;

            

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri3);


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (Musteri musteri in musteriler)
            {
                musteriManager.Listele(musteri);
            }


            musteriManager.Sil(musteri1);
        }
    }
}
