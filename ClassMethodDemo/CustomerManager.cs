using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        

        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Id +" "+customer.Name+" "+customer.Surname+" Succesfully Added");
        }
        public void Delete(Customer customer)
        {
            //customer.Remove(customer2); Gerekli eklentiler eklenince yani o konuya geldiğimizde kullanılacak
            Console.WriteLine(customer.Id + " " + customer.Name + " " + customer.Surname + " Succesfully Deleted");
        }
        public void List(Customer[] List)
        {
            foreach (Customer customer in List)
            {
                Console.WriteLine(customer.Id + customer.Name + customer.Surname);
            }
        }

    }
}
