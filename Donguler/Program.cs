using System;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Gelşitirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";

            //array - dizi 'lerde bu verilerimizi tutarız

            string[] kurslar = new string[] { "Yazılım Gelşitirici Yetiştirme Kampı", "Programlamaya başlangıç için temel kurs","Java","Python","C#"};

            //burada dinamikleştirmek için gideceği sayıyı dizimizin uzunluğu olarak veriyoruz.
            for (int i = 0; i<kurslar.Length;  i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");
            //foreach<< dizi temelli yapıları tek tek dönmeye yarar.
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
