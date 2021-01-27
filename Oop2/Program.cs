using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {

            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNo = "123456";
            customer1.Name = "Ersin";
            customer1.Surname = "AKYÜZ";
            customer1.TcNo = "21211321313110";


            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNo = "555550";
            customer2.CorporateName = "Medipa";

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);







            Console.ReadLine();

        }
    }
}
