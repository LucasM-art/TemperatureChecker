using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnhancedIfStatementsChallenge
{
    internal class Program
    {
        static int temperature;
        static string userInput;
        static string result;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the temperature checker!");
            Console.WriteLine();
            Console.WriteLine("Whats the temperature? (in celcius): ");

            Checker();

            Console.Read();
        }

        static void Checker()
        {
            userInput = Console.ReadLine();
            bool success = Int32.TryParse(userInput, out temperature);

            result = temperature <= 15 ? "It's too cold here" : temperature >= 16 && temperature <= 28 ? "It's ok" : "It's hot here";

            if (success)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("That's not a number");
            }
        }
    }
}
