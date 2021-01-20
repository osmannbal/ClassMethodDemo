using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        public void musteriEkle(Musteri musterix)
        {
            Console.WriteLine(musterix.Adi + " " + musterix.Soyadi + " " + "Eklendi");
            Console.WriteLine(" ");
        }

        public void musteriSil(Musteri musterix)
        {
            Console.WriteLine(musterix.Adi + " " + musterix.Soyadi + " " + "Silindi");
            Console.WriteLine(" ");
        }

        public void musteriListele(Musteri musterix)
        {
            Console.WriteLine(musterix.Adi + " " + musterix.Soyadi + " " + musterix.Id + " " + musterix.Cinsiyet + " " + musterix.Adres + " " + musterix.TelefonNo);
            Console.WriteLine(" ");
        }

        public void musteriAdresiniGöster(Musteri musterix)
        {
            Console.WriteLine(musterix.Adi + " " + musterix.Soyadi + " " + musterix.Adres);
            Console.WriteLine(" ");
        }
    }
}
