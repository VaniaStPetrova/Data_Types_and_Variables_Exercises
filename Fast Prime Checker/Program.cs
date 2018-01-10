using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int givenNum = int.Parse(Console.ReadLine());
            for (int cycle = 2; cycle <= givenNum; cycle++)
            {
                bool look = true;
                for (int cycle2 = 2; cycle2 <= Math.Sqrt(cycle); cycle2++)
                {
                    if (cycle % cycle2 == 0)
                    {
                        look = false;
                        break;
                    }
                }
                Console.WriteLine("{0} -> {1}", cycle, look);
            }
        }
    }
}
