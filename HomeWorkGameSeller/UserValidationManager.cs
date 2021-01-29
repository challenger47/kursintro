using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkGameSeller
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1984 && gamer.Name == "Ersin" && gamer.Surname == "Akyuz")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
