using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    class Fib
    {
        public static bool CheckIfFib(int num)
        {
            double result = Math.Sqrt(5 * (num * num) + 4);
            double result2 = Math.Sqrt(5 * (num * num) - 4);
            bool isSquare2 = result2 % 1 == 0;
            bool isSquare = result % 1 == 0;
            
            if (isSquare || isSquare2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void PrintFib(int num)
        {
            int count = 0;
            int count2 = 0;
            while(count != num)
            {
                if (CheckIfFib(count2))
                {
                    Console.WriteLine(count2);
                    count++;
                }
                count2++;
            }
        }
    }
}
