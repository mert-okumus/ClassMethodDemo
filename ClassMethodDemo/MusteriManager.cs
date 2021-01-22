using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Musteri Numarasi: "+musteri.Id);
            Console.WriteLine("Ad: "+musteri.Ad);
            Console.WriteLine("Soyad: "+musteri.Soyad);
            Console.WriteLine("----------");
        }
        
        public void Listele(Musteri[] musteriler)
        {
            Console.WriteLine("Musteri Listesi");
            foreach (Musteri x in musteriler)
            {
                Console.WriteLine(x.Id);
                Console.WriteLine(x.Ad);
                Console.WriteLine(x.Soyad);
            }
        }


    }
}
