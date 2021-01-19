using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri m1 = new Musteri();
            m1.musteriId = 1;
            m1.ad = "Sümeyye";
            m1.soyad = "Karatekin";
            m1.bakiye = 12000;
            m1.hesapNo = 963852741;

            Musteri m2 = new Musteri();
            m2.musteriId = 2;
            m2.ad = "Sümeyye";
            m2.soyad = "Kara";
            m2.bakiye = 5000;
            m2.hesapNo = 147258369;

            Musteri m3 = new Musteri();
            m3.musteriId = 3;
            m3.ad = "Sümeyye";
            m3.soyad = "Kara Tekin";
            m3.bakiye = 6490;
            m3.hesapNo = 987654321;

            Musteri[] müsteriler = new Musteri[] { m1, m2, m3 };
            foreach (Musteri m in müsteriler)
            {
                Console.WriteLine(m.ad +" "+ m.soyad +" Hesap No : " +m.hesapNo+ " Müşteri Hesabında  " + m.bakiye + "TL");
            }

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(m1);
            musteriManager.Sil(m2);
            musteriManager.List(m3);
        }
    }
}