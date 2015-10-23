using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    class Primes
    {
        public static bool CheckIfPrime(int num)
        {
            if (num == 1)
                return false;
            if (num == 2)
                return true;

            if (num % 2 == 0)
                return false; //Even number     

            for (int i = 3; i < num; i += 2)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        } 
        
        public static void PrintListOfPrimes(int num)
        {
            int count = 0;
            int count2 = 0;

            while (count != num)
            {
                if(CheckIfPrime(count2))
                {
                    Console.WriteLine(count2);
                    count++;
                }
                count2++;
            }
        }  
    }
}
