using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class EsnafKrediManager : ICreditManager
    {
        public void Hesapla()
        {
            Console.WriteLine("Esnaf kredisi hesaplandı");
        }

        public void Kaydet()
        {
            throw new NotImplementedException();
        }
    }
}
