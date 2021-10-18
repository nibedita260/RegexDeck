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
        const string PHONE_NUMBER_PATTEREN = "^([+][0-9]{2}[ ]){0,1}[6-9]{1}[0-9]{9}$";
        const string PASSWORD_PATTEREN = "^[A-Za-z]{8,20}$";
        const string PASSWORD_PATTEREN1 = "^[A-Z]{1}[a-z]{7,20}$";
        const string PASSWORD_PATTEREN2 = "^(?=.*[A-Z])(?=.*[0-9]).{8,}$";
        const string PASSWORD_PATTEREN3 = "^(?=.*[A-Z]).{8,}$";
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
        public void PHNoCheck(string phno)
        {
            if (Regex.IsMatch(phno, PHONE_NUMBER_PATTEREN))
            {
                Console.WriteLine("phno is Validated");
            }
            else
            {
                Console.WriteLine("phno is not Validated");
            }
        }
        public void PasswordCheck(string password)
        {
            if (Regex.IsMatch(password, PASSWORD_PATTEREN))
            {
                Console.WriteLine("password is Validated");
            }
            else
            {
                Console.WriteLine("password is not Validated");
            }
        }
        public void PasswordCheck1(string password)
        {
            if (Regex.IsMatch(password, PASSWORD_PATTEREN1))
            {
                Console.WriteLine("password is Validated");
            }
            else
            {
                Console.WriteLine("password is not Validated");
            }
        }
        public void PasswordCheck2(string password)
        {
            if (Regex.IsMatch(password, PASSWORD_PATTEREN2))
            {
                Console.WriteLine("password is Validated");
            }
            else
            {
                Console.WriteLine("password is not Validated");
            }
        }
        public void PasswordCheck3(string password)
        {
            if (Regex.IsMatch(password, PASSWORD_PATTEREN3))
            {
                Console.WriteLine("password is Validated");
            }
            else
            {
                Console.WriteLine("password is not Validated");
            }
        }
        public void SampleEmailCheck(string email)
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
        public string LambdaExpressionFirstnameCheck(string firstName) => Regex.IsMatch(firstName, FIRSTNAME_PATTERN) ? "firstName is Validated" : "firstName is not Validated";
        public string LambdaExpressionLastnameCheck(string lastName) => Regex.IsMatch(lastName, LASTNAME_PATTERN) ? "lastName is Validated" : "lastName is not Validated";
        public string LambdaExpressionEmailCheck(string email) => Regex.IsMatch(email, EMAIL_PATTEREN) ? "email is Validated" : "email is not Validated";
        public string LambdaExpressionPhoneNumberCheck(string phno) => Regex.IsMatch(phno, PHONE_NUMBER_PATTEREN) ? "phno is Validated" : "phno is not Validated";
        public string LambdaExpressionpasswordCheck(string password) => Regex.IsMatch(password, PASSWORD_PATTEREN3) ? "password is Validated" : "password is not Validated";
    }
}
