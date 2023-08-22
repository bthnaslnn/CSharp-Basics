using Microsoft.VisualBasic;
using System;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //classtan değişken tanımlayacağımız zaman newlememiz gerekli
        
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elmasi";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            //type-safety - tip güvenliği sağlarız 'Urun' yazar
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------");

            }

            Console.WriteLine("-----------Metotlar");

            //instance- örnek oluşturuyoruz.
            //class'ta bu şekilde oluşturuluyordu.
            //Metot -- reusebility yapmamı sağladı.
            //encapsulation veriyi class içerinde tutuyoruz.
            //encapsltn yani ayrı ayrı parametre olarak değil de
            // class içerisinde hepsini yazmak.
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 9);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 8);

        }
    }
}


//Dont repeat yourself -DRY   -Clean Code  -Best Practice