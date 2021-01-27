using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine(gamer.Name + "Named Gamer Added");

        }


        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.Name + "Named Gamer Updated");
        }
        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.Name + "Named Gamer Deleted");
        }
    }
}
