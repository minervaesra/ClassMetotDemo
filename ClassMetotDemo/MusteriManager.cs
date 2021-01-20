using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        string ekleMesaj = "Müşteri bilgileriniz sisteme başarıyla yüklenmiştir";
        string silMesaj = "Müşteri bilgileriniz silinmiştir";
        string listeMesaj = "Sistemde kayıtlı bilgileriniz listelenmiştir";

        public void Ekle(Musteri musteri, string mesaj="Müşteri bilgilerinizi giriniz")
        {
            Console.WriteLine(mesaj+"\n");
            Console.WriteLine("Sayın    :" + musteri.Ad + "\t" + musteri.Soyad);
            Console.WriteLine("Adınızı giriniz  :"+"\n");
            Console.WriteLine("Soyadınızı giriniz  :"+"\n");
            Console.WriteLine("Telefon numaranızı giriniz  :"+"\n");
            Console.WriteLine("TC Kimlik numaranızı giriniz  :"+"\n");
            Console.WriteLine(ekleMesaj);
            Console.ReadKey();

        }

        public void Sil(Musteri musteri, string mesaj2="Müşteri bilgilerinizin silinmesini onaylıyormusunuz  :  E / H")
        {
            Console.WriteLine(mesaj2+"\n");
            Console.WriteLine("Sayın    :"  + musteri.Ad + musteri.Soyad);
            mesaj2 = "E";

            if (mesaj2 == "E")
            {
                Console.WriteLine(silMesaj);
            }
            else
            {
                Console.WriteLine("Silme işlemi başarısız. Lütfen tekrar deneyin");
            }
            Console.ReadKey();
        }


        public void Listele(Musteri musteri, string mesaj3="Sistemde kayıtlı müşteriler listelenmiştir")
        {
            Console.WriteLine("Sayın" + "\t" + musteri.Ad + "\t" + musteri.Soyad + "\t" + mesaj3);
            Musteri[] musteriler = new Musteri[] { };
            Console.WriteLine(musteri.Ad + "\n" + musteri.Soyad + "\n" + musteri.Telefon + "\n" + musteri.Tc+ "\n");
            Console.WriteLine(silMesaj);
            Console.ReadKey();
        }
        

    }
}
