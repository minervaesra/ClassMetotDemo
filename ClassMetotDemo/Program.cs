using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Ali";
            musteri1.Soyad = "Alkan";
            musteri1.Telefon = 123456;
            musteri1.Tc = 11111111;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Esra";
            musteri2.Soyad = "Kara";
            musteri2.Telefon = 1234567;
            musteri2.Tc = 22222222;

            Musteri musteri3 = new Musteri();



            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri3);
            Console.ReadKey();


            MusteriManager musteriManager1 = new MusteriManager();
            musteriManager.Sil(musteri3);
            Console.ReadKey();


            MusteriManager musteriManager2 = new MusteriManager();
            musteriManager.Listele(musteri1 );
            Console.WriteLine("................");
            musteriManager.Listele(musteri2);
            Console.WriteLine("................");
            Console.ReadKey();
        }
    }
}
