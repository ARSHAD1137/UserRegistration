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
}
