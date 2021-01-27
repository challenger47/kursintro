using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SalesManager
    {
        
        public void Sell(Gamer gamer,Game game)
        {
            Console.WriteLine(game.Name+" Named Game sold "+ gamer.Name);
        }
    }
}
