﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    public class Name
    {
        string Name_Validator = "^[A-Z]{1}[a-z]{3,}$";

        public bool ValidateName(string result)
        {
            return Regex.IsMatch(result, Name_Validator);
        }
      
    }
}
