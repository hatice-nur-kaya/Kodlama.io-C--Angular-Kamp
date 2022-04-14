using System;
using System.Collections.Generic;
using System.Text;

namespace OyunOdevi
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthDay == 1999 && gamer.firstName == "Hatice Nur" && gamer.lastName == "KAYA" && gamer.IdentityNumber == 12125456654)
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
