﻿using System;

namespace RegularExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isExit = false;
            int options;
            while (!isExit)
            {
                Console.WriteLine("Choose 1.FirstNameValidate 2. LastNameValidate 3. EmailValidate 4.PhnoValidate 5.PasswordValidate 6.PasswordRule2Validate 7.PasswordRule3Validate 8.PasswordRule4Validate 9.SampleEmailValidation");
                options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:RegularExpression regularExpression = new RegularExpression();
                        Console.WriteLine("enter firstname");
                        string firstName = Console.ReadLine();
                        regularExpression.FirstnameCheck(firstName);
                        break;
                    case 2:
                        RegularExpression regularExpression1 = new RegularExpression();
                        Console.WriteLine("enter lastname");
                        string lastName = Console.ReadLine();
                        regularExpression1.LastNameCheck(lastName);
                        break;
                    case 3:
                        RegularExpression regularExpression2 = new RegularExpression();
                        Console.WriteLine("enter email");
                        string email = Console.ReadLine();
                        regularExpression2.EmailCheck(email);
                        break;
                    case 4:
                        RegularExpression regularExpression3 = new RegularExpression();
                        Console.WriteLine("enter phno");
                        string phno = Console.ReadLine();
                        regularExpression3.PHNoCheck(phno);
                        break;
                    case 5:
                        RegularExpression regularExpression4 = new RegularExpression();
                        Console.WriteLine("enter password");
                        string password = Console.ReadLine();
                        regularExpression4.PasswordCheck(password);
                        break;
                    case 6:
                        RegularExpression regularExpression5 = new RegularExpression();
                        Console.WriteLine("enter password");
                        string password1 = Console.ReadLine();
                        regularExpression5.PasswordCheck1(password1);
                        break;
                    case 7:
                        RegularExpression regularExpression6 = new RegularExpression();
                        Console.WriteLine("enter password");
                        string password2 = Console.ReadLine();
                        regularExpression6.PasswordCheck2(password2);
                        break;
                    case 8:
                        RegularExpression regularExpression7 = new RegularExpression();
                        Console.WriteLine("enter password");
                        string password3 = Console.ReadLine();
                        regularExpression7.PasswordCheck3(password3);
                        break;
                    case 9:
                        RegularExpression regularExpression8 = new RegularExpression();
                        regularExpression8.SampleEmailCheck("abc@yahoo.com");
                        regularExpression8.SampleEmailCheck("abc-100@yahoo.com");
                        regularExpression8.SampleEmailCheck("abc.100@yahoo.com");
                        regularExpression8.SampleEmailCheck("abc111@abc.com");
                        regularExpression8.SampleEmailCheck("abc-100@abc.net");
                        regularExpression8.SampleEmailCheck("abc.100@abc.com.au");
                        regularExpression8.SampleEmailCheck("abc@1.com");
                        regularExpression8.SampleEmailCheck("abc@gmail.com.com");
                        regularExpression8.SampleEmailCheck("abc+100@gmail.com");
                        break;
                    default:
                        Console.WriteLine("choose valid options");
                        break;
                }

            }
        }
    }
}
