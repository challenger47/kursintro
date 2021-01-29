using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkGameSeller
{
    class NewEStateUserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
