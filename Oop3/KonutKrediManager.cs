using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class KonutKrediManager : ICreditManager
    {
        public void Hesapla()
        {
            Console.WriteLine("knt Hesaplandı");
        }

        public void Kaydet()
        {
            throw new NotImplementedException();
        }
    }
}
