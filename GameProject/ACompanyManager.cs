using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class ACompanyManager : ICompanyManager
    {
        public void Add()
        {
            Console.WriteLine("A new company Added");

        }

        public void Apply()
        {
            Console.WriteLine("Acompany discount Applied");
        }
    }
}
