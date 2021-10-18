using System;

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
                Console.WriteLine("Choose 1.FirstNameValidate 2. LastNameValidate 3. EmailValidate 4.PhnoValidate 5.PasswordValidate 6.PasswordRule2Validate 7.PasswordRule3Validate 8.PasswordRule4Validate 9.SampleEmailValidation 10.LambaExpressionToValidateUserFields");
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
                    case 10:RegularExpression regularExpression9 = new RegularExpression();
                        Console.WriteLine("enter firstname");
                        string firstName1 = Console.ReadLine();
                        string output1=regularExpression9.LambdaExpressionFirstnameCheck(firstName1);
                        Console.WriteLine(output1);
                        Console.WriteLine("enter lastname");
                        string lastName1 = Console.ReadLine();
                        string output2 = regularExpression9.LambdaExpressionLastnameCheck(lastName1);
                        Console.WriteLine(output2);
                        Console.WriteLine("enter email");
                        string email1 = Console.ReadLine();
                        string output3 = regularExpression9.LambdaExpressionEmailCheck(email1);
                        Console.WriteLine(output3);
                        Console.WriteLine("enter phno");
                        string phno1 = Console.ReadLine();
                        string output4 = regularExpression9.LambdaExpressionPhoneNumberCheck(phno1);
                        Console.WriteLine(output4);
                        Console.WriteLine("enter password");
                        string password4 = Console.ReadLine();
                        string output5 = regularExpression9.LambdaExpressionpasswordCheck(password4);
                        Console.WriteLine(output5);
                        break;
                    default:
                        Console.WriteLine("choose valid options");
                        break;
                }
            }
        }
    }
}
