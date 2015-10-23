using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathmagician
{
    class Integers
    {
        public static void PrintListOfInt(int num)
        {
            int userNum = num;
            for (int i = 1; i <= userNum; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
