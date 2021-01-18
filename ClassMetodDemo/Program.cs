using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1
 ;           customer1.Name = "Ahmet";
            customer1.Surname = "Poyraz";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Mehmet";
            customer2.Surname = "Duman";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Name = "Serap";
            customer3.Surname = "Demir";

            CustomerManager customerManager = new CustomerManager();
            Customer[] customers = new Customer[] { customer1, customer2, customer3 };
            customerManager.Add(customer1);
            customerManager.Delete(customer2);
            customerManager.List(customers);
            Console.ReadLine();  


        }
    }
}
