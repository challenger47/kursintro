using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager();
            Gamer gamer1 = new Gamer() { Id = 1, Name = "Ersin" };
            Game game1 = new Game() { Id = 1, Name = "I.G.I" ,Price=1000};
            SalesManager salesManager = new SalesManager();
            ICompanyManager acompanyManager = new ACompanyManager();
            gamerManager.Add(gamer1);


            acompanyManager.Apply();
            
            salesManager.Sell(gamer1,game1);
            Console.ReadLine();
        }
    }
}
