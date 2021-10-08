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
                Console.WriteLine("Choose 1.FirstNameValidate");
                options = Convert.ToInt32(Console.ReadLine());
                switch (options)
                {
                    case 1:RegularExpression regularExpression = new RegularExpression();
                        Console.WriteLine("enter firstname");
                        string firstName = Console.ReadLine();
                        regularExpression.FirstnameCheck(firstName);
                        break;
                    default:
                        Console.WriteLine("choose valid oprions");
                        break;
                }

            }
        }
    }
}
