using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri1 = new Musteri();
            musteri1.MusteriAdi = "Tolga";
            musteri1.MusteriSoyad = "Demir";
            musteri1.MusteriHesap = "Gold Hesabı";
            musteri1.MusteriİD = 54;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriAdi = "Elifs";
            musteri2.MusteriSoyad = "Coskuner";
            musteri2.MusteriHesap = "Bronz Hesabı";
            musteri2.MusteriİD = 21;

            Musteri musteri3 = new Musteri();
            musteri3.MusteriAdi = "Enes";
            musteri3.MusteriSoyad = "Tengri";
            musteri3.MusteriHesap = "Gold Hesabı";
            musteri3.MusteriİD = 61;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            MusteriManager Musterimanager = new MusteriManager();


            int sayi1 = 1;
            Console.WriteLine("Müşterileri listelemek için 1  e basınız ve entera basınız");
            Console.WriteLine("Ekleme  işlemi için 2 'ye basınız ve entera basınız");
            Console.WriteLine("Delete işlemi için 3 'ye basınız ve entera basınız");

            sayi1 = Convert.ToInt32(Console.ReadLine());
            switch (sayi1)
            {
                case 1:
                    Musterimanager.musteriList(musteriler);
                    break;
                case 2:
                    Musterimanager.musteriAdd(musteri1);
                    break;
                case 3:
                    Musterimanager.musteriDelete(musteri2);
                    break;
            }


        }
    }
}
