﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable_in_Hex_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string textInput = Console.ReadLine();

            int answer = Convert.ToInt32(textInput, 16);

            Console.WriteLine(answer);
        }
    }
}
