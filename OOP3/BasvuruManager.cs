using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    internal class BasvuruManager
    {
        //kredi başvurusu oludğunu varsayarsak
        //method injection işlemi yapılıyor metotların hangi isimle gideceğini
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {
            //Başvuran bilgilerini değerlendirme
            //bu şekilde parametreye hangi kredi tipinden yollarsak
            //operasyon o kredi tipinde gerçekleşecektir.
            //

            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }


        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
