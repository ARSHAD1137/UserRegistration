
using System;
using System.Text;

namespace UserRegistration
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To User Registration");

            Name pattern = new Name();
            bool firstname = pattern.ValidateName(FirstName());
            Console.WriteLine(firstname);
            bool lastname = pattern.ValidateName1(LastName());
            Console.WriteLine(lastname);

        }
       

        public static string FirstName()
        {
            Console.WriteLine("First Name:");
            string FirstName = Console.ReadLine();
            return FirstName;
        }
        public static string LastName()
        {
            Console.WriteLine("Last Name:");
            string LastName = Console.ReadLine();
            return LastName;
        }
    }
}
