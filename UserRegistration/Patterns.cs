using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class Name
    {
        string Name_Validator = "^[A-Z]{1}[a-z]{3,}$";

        public bool ValidateName(string firstname)
        {
            return Regex.IsMatch(firstname, Name_Validator);
        }
        public bool ValidateName1(string lastname)
        {
            return Regex.IsMatch(lastname, Name_Validator);
        }
      
    }
    public class Email
    {
        string Email_Validator = "^[a-zA-Z0-9]+([.]{1}[a-zA-Z0-9]+)?[@]{1}[a-zA-Z]+[.][A-Za-z]{3}$";
        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, Email_Validator);
        }
    }
    public class MobileNo
    {
        string MoblieNo_Validator = "^[91]{2}[ ]*[0-9]{10}$";
        public bool ValidateMobilNo(string mobile)
        {
            return Regex.IsMatch(mobile, MoblieNo_Validator);
        }
    }
  

}
