using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri İd:" + musteri.Id + "|" + "Adi:" + musteri.Adi + " Adlı  müşterimiz sistemimize eklendi.");

        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Müşteri İd:" + musteri.Id + "|" + "Adi:" + musteri.Adi + "|" + "Bakiye:" + musteri);

        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " Adlı müşterimiz sistemimizden silindi.");

        }
    }
}
