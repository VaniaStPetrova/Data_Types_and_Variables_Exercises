using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstName = Console.ReadLine();
            string LastName = Console.ReadLine();
            int Age = int.Parse(Console.ReadLine());
            string Gender = Console.ReadLine(); //(m or f)
            long PersonalIDnumber = long.Parse(Console.ReadLine());
            long UniqueEmployeeNumber = long.Parse(Console.ReadLine());

            Console.WriteLine("First name: {0}", FirstName);
            Console.WriteLine("Last name: {0}", LastName);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Gender: {0}", Gender);
            Console.WriteLine("Personal ID: {0}", PersonalIDnumber);
            Console.WriteLine("Unique Employee number: {0}", UniqueEmployeeNumber);
        }
    }
}
