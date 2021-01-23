using System;

namespace MyDictionary
{
    class Program
    {

        static void Main(string[] args)
        {
            Dictionary<string, string> names = new Dictionary<string, string>();

            names.Add("1", "Mehmet");
            names.Add("2", "Ceyhan");
            names.Add("3", "Deniz");
            names.Add("4", "Erkan");

            names.GetAll();
            Console.ReadLine();
        }

    }
}
