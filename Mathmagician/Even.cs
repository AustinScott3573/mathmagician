using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    class Even
    {
        public static bool CheckIfEven(int num)
        {
            if(num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void PrintEvens(int num)
        {
            int count = 0;
            int count2 = 0;
            while (count != num)
            {
                if (CheckIfEven(count2))
                {
                    Console.WriteLine(count2);
                    count++;
                }
                count2++;
            }
        }
    }
}
