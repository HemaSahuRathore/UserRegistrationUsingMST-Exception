using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationWithMSTestNException
{
    public class UserRegistrationException : Exception
    {
        public string message;
        public ExceptionTypes exceptionType;
        
        public enum ExceptionTypes
        {
            EMPTY_MESSAGE,
            NULL_MESSAGE
        }

        public UserRegistrationException(string message, ExceptionTypes exceptionType) : base(message)
        {
            this.message = message;
            this.exceptionType = exceptionType;
        }   
    }
}
