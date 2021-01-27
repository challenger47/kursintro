using System;
using System.Collections.Generic;

namespace Oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Başlarına I ifadesini de koysaydık aynı sonucu alıyorduk...
            ICreditManager ihtiyacKrediManager = new IhtiyacKrediManager();
            ICreditManager tasitKrediManager = new TasitKrediManager();
            ICreditManager konutKrediManager = new KonutKrediManager();
            ILoggerService dataBaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();
            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };
            BasvuruManager basvuruManager = new BasvuruManager();

            basvuruManager.BasvuruYap(tasitKrediManager,loggers);
            List<ICreditManager> krediler = new List<ICreditManager>() {ihtiyacKrediManager,tasitKrediManager };
            //basvuruManager.KrediOnBilgilendirmeYap(krediler);

            Console.ReadLine();
        }
    }
}
