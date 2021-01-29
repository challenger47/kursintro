using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkGameSeller
{
    interface ICompanyService
    {
        void Add(Company company);
        void Delete(Company company);
        void Update(Company company);
    }
}
