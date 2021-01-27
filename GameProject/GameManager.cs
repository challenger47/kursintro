using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Business
{
    class GameManager
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.Name + " Game Added");
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.Name + "Game updated");
        }
        public void Delete(Game game)
        {
            Console.WriteLine(game.Name + "Game Deleted");
        }
    }
}
