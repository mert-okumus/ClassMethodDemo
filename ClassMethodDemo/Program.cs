using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = "123456";
            musteri1.Ad = "Ahmet";
            musteri1.Soyad = "Kara";

            Musteri musteri2 = new Musteri();
            musteri2.Id = "123457";
            musteri2.Ad = "Mehmet";
            musteri2.Soyad = "Soner";

            Musteri musteri3 = new Musteri();
            musteri3.Id = "123458";
            musteri3.Ad = "Elif";
            musteri3.Soyad = "Karaman";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            musteriManager.Listele(musteriler);
                               
        }
    }
}
