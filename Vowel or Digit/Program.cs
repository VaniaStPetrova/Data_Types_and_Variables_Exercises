using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {

            char input = char.Parse(Console.ReadLine());//a, e, i, o, u, and sometimes y
            bool look = false;

            switch (input)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                case 'y': Console.WriteLine("vowel"); look = true; break;
            }

            if (48 <= input && input <= 57)
            {
                Console.WriteLine("digit");
            }
            else if (!look)
            {
                Console.WriteLine("other");
            }
        }
    }
}
