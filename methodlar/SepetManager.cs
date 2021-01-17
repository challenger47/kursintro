using System;
using System.Collections.Generic;
using System.Text;

namespace methodlar
{
    class SepetManager
    {
        public void Add(Product product)
        {
            Console.WriteLine("Sepete eklendi : "+product.Name);
        }
       
    }
}
