using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    class Odd
    {
        public static bool CheckIfOdd(int num)
        {
            if (num % 2 == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void PrintOdds(int num)
        {
            int count = 0;
            int count2 = 0;
            while (count != num)
            {
                if (CheckIfOdd(count2))
                {
                    Console.WriteLine(count2);
                    count++;
                }
                count2++;
            }
        }
    }
}
