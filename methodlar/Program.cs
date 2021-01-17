using System;

namespace methodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "elma";
            product1.Price = 5;
            product1.Description = "Amasya Elması";

            Product product2 = new Product();
            product2.Name = "Karpuz";
            product2.Price = 20;
            product2.Description = "Diyarbakır Karpuzu";

            Product[] products = new Product[] { product1, product2 };
            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Description);
                Console.WriteLine("--------ssssss--------");
                
            }
            Console.WriteLine("-------Methodlar-----------");
            SepetManager sepet = new SepetManager();
            sepet.Add(product1);
            sepet.Add(product2);

            Console.ReadLine();
        }
    }
}
