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
            string prompt = "> ";
            Console.WriteLine("What do you want me to do?");
            Console.Write(prompt);
            string response = Console.ReadLine();
            if (response.Equals("natural numbers"))
            {
                Console.WriteLine("How many?");
                Console.Write(prompt);
                string response_length = Console.ReadLine();
                int length;
                bool parsed = int.TryParse(response_length, out length);
                if (parsed)
                {
                    NaturalNumbers nats = new NaturalNumbers();
                    Console.WriteLine(nats.ToString(nats.GetSequence(length)));
                }
                else
                {
                    Console.WriteLine("Whoops!");
                }

            }
            else if (response.Equals("even numbers"))
            {
                Console.WriteLine("How many?");
                Console.Write(prompt);
                string response_length = Console.ReadLine();
                int length;
                bool parsed = int.TryParse(response_length, out length);
                if (parsed)
                {
                    EvenNumbers even = new EvenNumbers();
                    Console.WriteLine(even.ToString(even.GetSequence(length)));
                }
                else
                {
                    Console.WriteLine("Whoops!");
                }

            }
            else if (response.Equals("odd numbers"))
            {
                Console.WriteLine("How many?");
                Console.Write(prompt);
                string response_length = Console.ReadLine();
                int length;
                bool parsed = int.TryParse(response_length, out length);
                if (parsed)
                {
                    OddNumbers odd = new OddNumbers();
                    Console.WriteLine(odd.ToString(odd.GetSequence(length)));
                }
                else
                {
                    Console.WriteLine("Whoops!");
                }

            }
            else if (response.Equals("fibonacci numbers"))
            {
                Console.WriteLine("How many?");
                Console.Write(prompt);
                string response_length = Console.ReadLine();
                int length;
                bool parsed = int.TryParse(response_length, out length);
                if (parsed)
                {
                    FibonacciNumbers fibonacci = new FibonacciNumbers();
                    Console.WriteLine(fibonacci.ToString(fibonacci.GetSequence(length)));
                }
                else
                {
                    Console.WriteLine("Whoops!");
                }

            }
            else if (response.Equals("prime numbers"))
            {
                Console.WriteLine("How many?");
                Console.Write(prompt);
                string response_length = Console.ReadLine();
                int length;
                bool parsed = int.TryParse(response_length, out length);
                if (parsed)
                {
                    PrimeNumbers primes = new PrimeNumbers();
                    Console.WriteLine(primes.ToString(primes.GetSequence(length)));
                }
                else
                {
                    Console.WriteLine("Whoops!");
                }

            }
            else
            {
                Console.WriteLine("Nope! Do better next time.");
            }
            Console.WriteLine("Press any key to exit..");
            Console.ReadKey();
        }
    }
}
