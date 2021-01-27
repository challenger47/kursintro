using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class IhtiyacKrediManager : ICreditManager
    {
        public void Hesapla()
        {
            Console.WriteLine("iht Hesaplandı");
        }

        public void Kaydet()
        {
            throw new NotImplementedException();
        }
    }
}
