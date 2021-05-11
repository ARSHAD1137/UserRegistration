
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

        }
       

        public static string FirstName()
        {
            Console.WriteLine("Enter a First Name:");
            string FirstName = Console.ReadLine();
            return FirstName;
        }
    }
}
