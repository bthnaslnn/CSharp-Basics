using System;

namespace Kamp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            //Do not repeat yourself - Kenini tekrarlama DRY
            //değer tutucu ,alias >> değişkenlerimiz

            string KategoriEtiketi = "Kategori";
            int ogrenciSayisi = 320;
            double FaizOrani = 1.69;
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarBugun>dolarDun)
            {
                Console.WriteLine("Artış Butonu");

            }
            else 
            {
                Console.WriteLine("Değişmedi butonu"); 
            }


            if (sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

                Console.WriteLine(KategoriEtiketi);
        }
    }
}
