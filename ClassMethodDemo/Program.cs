using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 12967541;
            musteri1.Adi = " Mustafa";
            musteri1.Soyadi = "Sağlam";
            musteri1.TelefonNo = 05395661835;
            musteri1.Cinsiyet = "Erkek";
            musteri1.Adres = "Bayrampaşa / Istanbul";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 75391156;
            musteri2.Adi = "Hakan";
            musteri2.Soyadi = "Beyaz";
            musteri2.TelefonNo = 05448923174;
            musteri2.Cinsiyet = "Erkek";
            musteri2.Adres = "Şişli / İstanbul";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 83427196;
            musteri3.Adi = "Sena";
            musteri3.Soyadi = "Art";
            musteri3.TelefonNo = 05338516729;
            musteri3.Adres = "Çankaya / Ankara";
            musteri3.Cinsiyet = "Kadın";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.musteriEkle(musteri1);
            musteriManager.musteriEkle(musteri2);
            musteriManager.musteriEkle(musteri3);

            musteriManager.musteriSil(musteri1);
            musteriManager.musteriSil(musteri2);
            musteriManager.musteriSil(musteri3);

            musteriManager.musteriListele(musteri1);
            musteriManager.musteriListele(musteri2);
            musteriManager.musteriListele(musteri3);

            musteriManager.musteriAdresiniGöster(musteri1);
            musteriManager.musteriAdresiniGöster(musteri2);
            musteriManager.musteriAdresiniGöster(musteri3);
        }
    }
}
