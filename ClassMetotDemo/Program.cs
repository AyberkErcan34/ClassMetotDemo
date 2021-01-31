using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Orhan";
            musteri1.Bakiye = 106;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Ayhan";
            musteri2.Bakiye = 7867;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Yahya";
            musteri3.Bakiye = 1378;

            Musteri musteri4 = new Musteri();
            musteri4.Id = 4;
            musteri4.Adi = "Ömer";
            musteri4.Bakiye = 246;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };


            // Object

            MusteriManager musteriManager = new MusteriManager();
            //Ekle

            for (int i = 0; i < musteriler.Length; i++)
            {
                musteriManager.Ekle(musteriler[i]);
            }

            Console.WriteLine("------------------------------------------------");

            //Sil

            musteriManager.Sil(musteri1);

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("                Müşteriler                      ");
            Console.WriteLine("-------------------------------------------------");

            //Listele

            foreach (Musteri list in musteriler)
            {
                musteriManager.Listele(list);
                Console.WriteLine("-----------------------------------------");
            }






            Console.ReadKey();
        }
    }
}
