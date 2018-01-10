using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            byte cent = byte.Parse(Console.ReadLine());
            int y = 100 * cent; //years -- y
            int d = (int)(y * 365.2422); //days --d
            int h = 24 * d; //hours -- h
            ulong min = (ulong)(60 * h);
            ulong sec = 60 * min;
            ulong milS = 1000 * sec;//milliSec -- milS
            decimal micS = 1000 * milS;//microSec -- micS
            decimal nanS = 1000 * micS;//nanoSec -- nanS
            Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds", cent, y, d, h, min, sec, milS, micS, nanS);
        }
    }
}
