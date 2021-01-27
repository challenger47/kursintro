using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class BasvuruManager
    {
        public void BasvuruYap(ICreditManager creditManager,List<ILoggerService> loggerServices)
        {
            creditManager.Hesapla();//yaparsak hangi sini gönderirsek onu yapar doğru olan bu
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla(); dersek tüm başvuruları konut kredisi üzerinden yapar bu yanlış
            
        }
        public void KrediOnBilgilendirmeYap(List<ICreditManager>krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
//İnterface leri birbirinin alternatifi olan ama farklı işlemler yapılabilecek 