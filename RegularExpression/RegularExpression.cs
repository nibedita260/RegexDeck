using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegularExpression
{
    class RegularExpression
    {
        const string FIRSTNAME_PATTERN = "^[A-Z]{1}[a-z]{3,20}$";
        public void FirstnameCheck(string firstName)
        {
            if (Regex.IsMatch(firstName, FIRSTNAME_PATTERN)){
                Console.WriteLine("First Name Validated");
            }
            else
            {
                Console.WriteLine("First Name is not Validated");
            }
        }
    }
}
