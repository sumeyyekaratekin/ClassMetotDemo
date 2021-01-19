using System;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri m)
        {
            Console.WriteLine("\n" + m.hesapNo + " Hesap Numaralı " + m.ad + " " + m.soyad + " (Müşteri eklendi)");
        }
        public void Sil(Musteri m)
        {
            Console.WriteLine("\n" +m.hesapNo + " Hesap Numaralı "+m.ad +" "+m.soyad +" (Müşteri silindi)");
        }
        public void List(Musteri m)
        {
            Console.WriteLine("\nHesap Numarası : " + m.hesapNo + " Müşteri Adı:  " + m.ad + " " + m.soyad + " Müşteri Hesap Bakiyesi :" +m.bakiye +" (Müşteri bilgileri Listelendi)");
        }
    }
}