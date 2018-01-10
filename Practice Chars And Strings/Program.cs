using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Chars_And_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string one = Console.ReadLine();
            char two = char.Parse(Console.ReadLine());
            char three = char.Parse(Console.ReadLine());
            char four = char.Parse(Console.ReadLine());
            string five = Console.ReadLine();

            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}", one, two, three, four, five);

        }
    }
}
