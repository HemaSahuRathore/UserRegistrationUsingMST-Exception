using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationWithMSTestNException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Problem with Exception And Unit Tests");

            UserRegistration urObj = new UserRegistration();

            Console.Write("\nEnter your First Name : ");
            string firstName = Console.ReadLine();
            urObj.ValidateName(firstName);

            Console.Write("\nEnter your Last Name : ");
            string lastName = Console.ReadLine();
            urObj.ValidateName(lastName);
            Console.ReadLine();
        }
    }
}
