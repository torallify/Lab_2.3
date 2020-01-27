using System;
using System.Text.RegularExpressions;

namespace Lab_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            char key;
            do
            {

                Console.Write("\nPlease enter a valid Name: ");
                string name = Console.ReadLine();
                string namePattern = @"^[A-Z][A-z]{1,30}$";

                if (Regex.IsMatch(name, namePattern))
                {
                    Console.WriteLine("Name is valid!\n");
                }
                else
                {
                    Console.WriteLine("Sorry, name is not valid!\n");
                }

                Console.Write("Enter a valid email address: ");
                string email = Console.ReadLine();
                string emailPattern = @"^([a-z]{5,30})@([a-z]{5,10})((\.[a-z]{2,3}))$";

                if (Regex.IsMatch(email, emailPattern))
                {
                    Console.WriteLine("Email is valid!\n");
                }
                else
                {
                    Console.WriteLine("Sorry, Email is not valid!\n");
                }

                Console.Write("Please enter a valid phone number: ");
                string phoneNumber = Console.ReadLine();
                string phoneNumberPattern = @"((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}";

                if (Regex.IsMatch(phoneNumber, phoneNumberPattern))
                {
                    Console.WriteLine("Phone number is valid!\n");
                }
                else
                {
                    Console.WriteLine("Sorry, phone number is not valid!\n");
                }

                Console.Write("Enter a valid date: ");
                string date = Console.ReadLine();
                string datePattern = @"^(0[1-9]|1[0-2])\/(0[1-9]|1\d|2\d|3[01])\/(19|20)\d{2}$";

                if (Regex.IsMatch(date, datePattern))
                {
                    Console.WriteLine("Date is valid!\n");
                }
                else
                {
                    Console.WriteLine("Sorry, date is not valid!\n");
                }

                Console.Write("Would you like to try again (y/n)? ");
                key = Console.ReadKey().KeyChar;
                key = char.ToLower(key);

                while (key != 'y' && key != 'n')
                {
                    Console.Write("\nInvalid input. Please press y or n: ");
                    key = Console.ReadKey().KeyChar;
                    key = char.ToLower(key);
                }
                Console.WriteLine();
            } while (key == 'y');

            Console.WriteLine("\nGoodbye! Come again!");
        }
    }
}
