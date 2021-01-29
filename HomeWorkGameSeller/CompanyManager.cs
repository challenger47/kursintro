using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkGameSeller
{
    class CompanyManager: ICompanyService
    {
        public void Add(Company company)
        {
            Console.WriteLine("Company Added");
        }
        public void Update(Company company)
        {
            Console.WriteLine("Company Updated");
        }
        public void Delete(Company company)
        {
            Console.WriteLine("Company Deleted");
        }
    }
}
