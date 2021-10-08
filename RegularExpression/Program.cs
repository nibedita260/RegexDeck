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
                Console.WriteLine("Choose 1.FirstNameValidate 2. LastNameValidate");
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
                    default:
                        Console.WriteLine("choose valid oprions");
                        break;
                }

            }
        }
    }
}
