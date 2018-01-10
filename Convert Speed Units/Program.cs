using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            float distanceInMeters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float totalSeconds = (hours * 60 + minutes) * 60 + seconds;

            Console.WriteLine("{0}", distanceInMeters / totalSeconds);

            float kmsPerHour = distanceInMeters / 1000f;
            float totalHours = (((seconds / 60) + minutes) / 60) + hours;

            Console.WriteLine("{0}", kmsPerHour / totalHours);

            float milesPerHour = distanceInMeters / 1609f;

            Console.WriteLine("{0}", milesPerHour / totalHours);
        }
    }
}
