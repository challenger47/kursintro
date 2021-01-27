using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class BCompanyManager : ICompanyManager
    {
        public void Add()
        {
            Console.WriteLine("New Company Added");
        }

        public void Apply()
        {
            Console.WriteLine("B Company Applied");
        }
    }
}
