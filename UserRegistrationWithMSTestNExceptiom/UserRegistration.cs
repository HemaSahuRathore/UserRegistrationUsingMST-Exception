using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationWithMSTestNException
{
    public class UserRegistration
    {
        //name validation
        public string namePattern = "^[A-Z]{1}[a-z]{2,}$";

        //Method to validate Name
        public string ValidateName(string name)
        {
            string valid = "Valid";
            string Invalid = "InValid";

            UserRegistration ur = new UserRegistration();

            try
            {
                if (name.Equals(string.Empty))
                {
                    throw new UserRegistrationException("Name cannot be Empty", UserRegistrationException.ExceptionTypes.EMPTY_MESSAGE);
                }
                else if (Regex.IsMatch(name, ur.namePattern))
                {
                    return valid;
                }
                else
                    return Invalid;

            }
            catch(NullReferenceException ex)
            {
                throw new UserRegistrationException("Name cannot be Null", UserRegistrationException.ExceptionTypes.NULL_MESSAGE);
            }
           
        }

    }
}
