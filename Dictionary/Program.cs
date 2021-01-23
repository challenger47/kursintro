using System;

namespace Dictionary
{
    class Program
    {
       
            static void Main(string[] args)
            {
                MyDictionary<string, string> names = new MyDictionary<string, string>();

                names.Add("1", "Mehmet");
                names.Add("2", "Ceyhan");
                names.Add("3", "Deniz");
                names.Add("4", "Erkan");

            names.GetAll();
            Console.ReadLine();
            }
        
    }
}
