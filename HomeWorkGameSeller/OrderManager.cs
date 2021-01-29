using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkGameSeller
{
    class OrderManager
    {
        public void Sell(Gamer gamer, Game game, Company company)
        {
            Console.WriteLine(game.Name +game.Price + " Sold to " + gamer.Name + " BY " + company.Name + " % " + company.DiscountRate);

        }

      
    }
}
