using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What would you like for me to do?");

            string userWants = Console.ReadLine().ToLower();

            Console.WriteLine("How many should I print?");

            int userInput = Int32.Parse(Console.ReadLine());

            if (userWants == "integers" || userWants == "primes" || userWants == "fibonacci" || userWants == "even" || userWants == "odd")
            {
                if (userWants == "integers")
                {
                    Integers.PrintListOfInt(userInput);
                }
                if (userWants == "primes")
                {
                    Primes.PrintListOfPrimes(userInput);
                }
                if (userWants == "fibonacci")
                {
                    Fib.PrintFib(userInput);
                }
                if (userWants == "even")
                {
                    Even.PrintEvens(userInput);
                }
                if (userWants == "odd")
                {
                    Odd.PrintOdds(userInput);
                }
            }
            else
            {
                Console.WriteLine("WHOOPS!");
            }
        }
    }
}
