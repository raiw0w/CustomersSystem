using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void musteriAdd(Musteri musteri)
        {
            Console.WriteLine("Eklendi \n Ad= Caner  \n Soyad= Güneş \n Hesap Türü= Silver \n İD= 34 ");
        }

        public void musteriDelete(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi = " + musteri.MusteriAdi + " " + musteri.MusteriSoyad);
        }

        public void musteriList(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("Musteri Adı = " + musteri.MusteriAdi + "\nMusteri Soyad =" + musteri.MusteriSoyad + "\nMusteri Hesap Cinsi =" + musteri.MusteriHesap + "\nMusteri İD = " + musteri.MusteriİD);
                Console.WriteLine("_________________________");
            }

        }

    }
}

