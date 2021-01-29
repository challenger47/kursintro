using System;

namespace HomeWorkGameSeller
{
    class Program
    {
        static void Main(string[] args)
        {
           
        //    GameManager gameManager = new GameManager();
        //    gameManager.Add(new Game() { Id = 1, Name = "I.G.I", Price = 1000 });
        //    CompanyManager companyManager = new CompanyManager();
        //    companyManager.Add(new Company { Id = 1, Name = "Student",DiscountRate=10 });
           
        //GamerManager gamerManager = new GamerManager(new UserValidationManager());
        //    gamerManager.Add(new Gamer {
        //        Id = 1,
        //        Name = "Ersin",
        //        Surname = "Akyuz",
        //        BirthYear = 1984,
        //        IdentityNo = 12345678999,
           
        //    });
            OrderManager orderManager = new OrderManager();
            orderManager.Sell(new Gamer { Id=1,Name="Ersin"},new Game { Id=1,Name="I.G.I",Price=1000},new Company { Id=1,Name="Student Discount",DiscountRate=10});

            Console.ReadLine();
        }
    }
}
