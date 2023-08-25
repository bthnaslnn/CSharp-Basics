using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    internal class NewEStateUserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
