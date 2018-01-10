using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int Values1 = int.Parse(Console.ReadLine());
            int Values2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Before:\na = {0}\nb = {1}\nAfter:\na = {2}\nb = {3}", Values1, Values2, Values2, Values1);
        }
    }
}
