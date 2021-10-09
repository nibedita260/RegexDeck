using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegularExpression
{
    class RegularExpression
    {
        const string FIRSTNAME_PATTERN = "^[A-Z]{1}[a-z]{3,20}$";
        const string LASTNAME_PATTERN = "^[A-Z]{1}[a-z]{3,20}$";
        const string EMAIL_PATTEREN = "^[0-9a-zA-Z]+[.-_--]{0,2}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";
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
        public void LastNameCheck(string lastName)
        {
            if (Regex.IsMatch(lastName, LASTNAME_PATTERN))
            {
                Console.WriteLine("Last Name Validated");
            }
            else
            {
                Console.WriteLine("Last Name is not Validated");
            }
        }
        public void EmailCheck(string email)
        {
            if (Regex.IsMatch(email, EMAIL_PATTEREN))
            {
                Console.WriteLine("email is Validated");
            }
            else
            {
                Console.WriteLine("email is not Validated");
            }
        }
    }
}
