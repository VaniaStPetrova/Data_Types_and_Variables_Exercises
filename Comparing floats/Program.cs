using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparing_floats
{
    class Program
    {
        static void Main(string[] args)
        {
            double Num1 = double.Parse(Console.ReadLine());
            double Num2 = double.Parse(Console.ReadLine());

            double difference = Math.Abs(Num1 - Num2);

            if (difference <= 0.000001)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
