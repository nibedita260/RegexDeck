using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegularExpression
{
    public class RegularExpressionValidation
    {
        const string FIRSTNAME_PATTERN = "^[A-Z]{1}[a-z]{3,20}$";
        const string LASTNAME_PATTERN = "^[A-Z]{1}[a-z]{3,20}$";
        const string EMAIL_PATTEREN = "^[0-9a-zA-Z]+[.-_--]{0,2}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";
        const string PHONE_NUMBER_PATTEREN = "^([+][0-9]{2}[ ]){0,1}[6-9]{1}[0-9]{9}$";
        const string PASSWORD_PATTEREN = "^[A-Za-z]{8,20}$";
        const string PASSWORD_PATTEREN1 = "^[A-Z]{1}[a-z]{7,20}$";
        const string PASSWORD_PATTEREN2 = "^(?=.*[A-Z])(?=.*[0-9]).{8,}$";
        const string PASSWORD_PATTEREN3 = "^(?=.*[A-Z]).{8,}$";
        public string FirstnameCheck(string firstName)
        {
            try
            {
                if (string.IsNullOrEmpty(firstName))
                    throw new RegularExpressionCustomException(RegularExpressionCustomException.InvalidUserdetails.EMPTY_NAME, "FirstName Could not be Empty");
                if (Regex.IsMatch(firstName, FIRSTNAME_PATTERN))
                    return "First Name Validated";
                else
                    throw new RegularExpressionCustomException(RegularExpressionCustomException.InvalidUserdetails.INVALID_NAME, "First name starts with Cap and has minimum 3 characters");
            }
            catch(RegularExpressionCustomException e)
            {
                Console.WriteLine(e.Message);
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }
        public void LastNameCheck(string lastName)
        {
            try
            {
                if (string.IsNullOrEmpty(lastName))
                    throw new RegularExpressionCustomException(RegularExpressionCustomException.InvalidUserdetails.EMPTY_NAME, "LastName Could not be Empty");
                if (Regex.IsMatch(lastName, LASTNAME_PATTERN))
                    Console.WriteLine("Last Name Validated");
                else
                    throw new RegularExpressionCustomException(RegularExpressionCustomException.InvalidUserdetails.INVALID_NAME, "Last name starts with Cap and has minimum 3 characters ");
            }
            catch(RegularExpressionCustomException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public string EmailCheck(string email)
        {
            try
            {
                if (string.IsNullOrEmpty(email))
                    throw new RegularExpressionCustomException(RegularExpressionCustomException.InvalidUserdetails.EMPTY_EMAIL, "Email Could not be Empty");
                if (Regex.IsMatch(email, EMAIL_PATTEREN))
                    return "email is Validated";
                else
                    throw new RegularExpressionCustomException(RegularExpressionCustomException.InvalidUserdetails.INVALID_EMAIL, "E.g. abc.xyz@bl.co.in - Email has 3 mandatory parts (abc, bl & co) and 2 optional(xyz & in) with precise @ and.positions");
            }
            catch(RegularExpressionCustomException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }
        public string PHNoCheck(string phno)
        {
            try
            {
                if (string.IsNullOrEmpty(phno))
                    throw new RegularExpressionCustomException(RegularExpressionCustomException.InvalidUserdetails.EMPTY_PHONE_NO, "Phone Number Could not be Empty");
                if (Regex.IsMatch(phno, PHONE_NUMBER_PATTEREN))
                   return "phno is Validated";
                else
                    throw new RegularExpressionCustomException(RegularExpressionCustomException.InvalidUserdetails.INVALID_PHONE_NO, "Phone Number Should Have 10 digits and First digits Must starts from [6..9] and [+91 ] is for optional Mobile Format - E.g. 91 6919819801 - Country code follow by space and 10 digit number");
            }
            catch(RegularExpressionCustomException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }
        public void PasswordCheck(string password)
        {
            try
            {
                if (string.IsNullOrEmpty(password))
                    throw new RegularExpressionCustomException(RegularExpressionCustomException.InvalidUserdetails.EMPTY_PASSWORD, "Password Could not be Empty");
                if (Regex.IsMatch(password, PASSWORD_PATTEREN))
                    Console.WriteLine("password is Validated");
                else
                    throw new RegularExpressionCustomException(RegularExpressionCustomException.InvalidUserdetails.INVALID_PASSWORD, "Password Have minimum 8 Characters");
            }
            catch(RegularExpressionCustomException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void PasswordCheck1(string password)
        {
            try
            {
                if (string.IsNullOrEmpty(password))
                    throw new RegularExpressionCustomException(RegularExpressionCustomException.InvalidUserdetails.EMPTY_PASSWORD, "Password Could not be Empty");
                if (Regex.IsMatch(password, PASSWORD_PATTEREN1))
                    Console.WriteLine("password is Validated");
                else
                    throw new RegularExpressionCustomException(RegularExpressionCustomException.InvalidUserdetails.INVALID_PASSWORD, "Password Have minimum 8 Characters, Should have at least 1 Upper Case");
            }
            catch (RegularExpressionCustomException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void PasswordCheck2(string password)
        {
            try
            {
                if (string.IsNullOrEmpty(password))
                    throw new RegularExpressionCustomException(RegularExpressionCustomException.InvalidUserdetails.EMPTY_PASSWORD, "Password Could not be Empty");
                if (Regex.IsMatch(password, PASSWORD_PATTEREN2))
                    Console.WriteLine("password is Validated");
                else
                    throw new RegularExpressionCustomException(RegularExpressionCustomException.InvalidUserdetails.INVALID_PASSWORD, "Password Have minimum 8 Characters, Should have at least 1 Upper Case and Should have at least 1 numeric number ");
            }
            catch (RegularExpressionCustomException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public string PasswordCheck3(string password)
        {
            try
            {
                if (string.IsNullOrEmpty(password))
                    throw new RegularExpressionCustomException(RegularExpressionCustomException.InvalidUserdetails.EMPTY_PASSWORD, "Password Could not be Empty");
                if (Regex.IsMatch(password, PASSWORD_PATTEREN3))
                    return "password is Validated";
                else
                    throw new RegularExpressionCustomException(RegularExpressionCustomException.InvalidUserdetails.INVALID_PASSWORD, "Password Have minimum 8 Characters, Should have at least 1 Upper Case and Should have at least 1 numeric number and Has exactly 1 Special Character");
            }
            catch (RegularExpressionCustomException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }
        public void SampleEmailCheck(string email)
        {
            try
            {
                if (string.IsNullOrEmpty(email))
                    throw new RegularExpressionCustomException(RegularExpressionCustomException.InvalidUserdetails.EMPTY_EMAIL, "Email Could not be Empty");
                if (Regex.IsMatch(email, EMAIL_PATTEREN))
                    Console.WriteLine("email is Validated");
                else
                    throw new RegularExpressionCustomException(RegularExpressionCustomException.InvalidUserdetails.INVALID_EMAIL, "E.g. abc.xyz@bl.co.in - Email has 3 mandatory parts (abc, bl & co) and 2 optional(xyz & in) with precise @ and.positions");
            }
            catch (RegularExpressionCustomException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public string LambdaExpressionFirstnameCheck(string firstName) => Regex.IsMatch(firstName, FIRSTNAME_PATTERN) ? "firstName is Validated" : "firstName is not Validated";
        public string LambdaExpressionLastnameCheck(string lastName) => Regex.IsMatch(lastName, LASTNAME_PATTERN) ? "lastName is Validated" : "lastName is not Validated";
        public string LambdaExpressionEmailCheck(string email) => Regex.IsMatch(email, EMAIL_PATTEREN) ? "email is Validated" : "email is not Validated";
        public string LambdaExpressionPhoneNumberCheck(string phno) => Regex.IsMatch(phno, PHONE_NUMBER_PATTEREN) ? "phno is Validated" : "phno is not Validated";
        public string LambdaExpressionpasswordCheck(string password) => Regex.IsMatch(password, PASSWORD_PATTEREN3) ? "password is Validated" : "password is not Validated";
    }
}
