using System;
namespace ClassMetotDemo
{
    public class MusteriManager
    {
        public void Ekle (Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi : " + musteri.Id + " " + musteri.Adi + " " + musteri.Soyadi + " " + musteri.Yas + " " + musteri.Bakiye);
        }

        public void Listele (Musteri musteri)
        {
            Console.WriteLine(musteri.Id);
            Console.WriteLine(musteri.Adi);
            Console.WriteLine(musteri.Soyadi);

            Console.WriteLine("------------");
        }

        public void Sil (Musteri musteri)
        {
            Console.WriteLine("Müşteri silindi! " + musteri.Adi + " " + musteri.Soyadi);
        }
    }
}