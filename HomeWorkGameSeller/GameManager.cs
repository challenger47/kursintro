using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkGameSeller
{
    class GameManager
    {
        public void Add(Game game)
        {
            Console.WriteLine("Oyun eklendi");
           
        }
        public void Update(Game game)
        {
            Console.WriteLine("Oyun Güncellendi");

        }
        public void Delete(Game game)
        {
            Console.WriteLine("Oyun Silindi");

        }
    }
}
