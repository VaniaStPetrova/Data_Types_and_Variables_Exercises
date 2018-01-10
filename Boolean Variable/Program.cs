using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            bool answer = Convert.ToBoolean(text);
            Console.WriteLine(answer ? "Yes" : "No");

        }
    }
}
