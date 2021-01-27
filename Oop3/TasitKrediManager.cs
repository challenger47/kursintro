using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class TasitKrediManager : ICreditManager
    {
        public void Hesapla()
        {
            Console.WriteLine("tst Hesaplandı");
        }

        public void Kaydet()
        {
            throw new NotImplementedException();
        }
    }
}
