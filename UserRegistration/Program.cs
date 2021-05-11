
using System;
using System.Text;

namespace UserRegistration
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To User Registration");
            Console.WriteLine("Enter Choice: \n 1: Name Validator\n 2: Email Validator");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                     Name pattern = new Name();
                     bool firstname = pattern.ValidateName(FirstName());
                     Console.WriteLine(firstname);
                     bool lastname = pattern.ValidateName1(LastName());
                     Console.WriteLine(lastname);
                 break;
                case 2:
                    Email pattern1 = new Email();
                    bool email = pattern1.ValidateEmail(EmailID());
                    Console.WriteLine(email);
                    break;
            }
                
            
            
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
        public static string EmailID()
        {
            Console.WriteLine("Email:");
            string Email = Console.ReadLine();
            return Email;
        }
    }
}
