﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int toConvert = int.Parse(Console.ReadLine());

            string hexadecimal = Convert.ToString(toConvert, 16).ToUpper();
            string binary = Convert.ToString(toConvert, 2).ToUpper();

            Console.WriteLine(hexadecimal + Environment.NewLine + binary);
        }
    }
}
