using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Cross_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculates the cross sum of a given number");
           Cross();
        }

        static void Cross()
        {
            Console.Write("Input number: ");
            long number = Int64.Parse(Console.ReadLine());
            int result = number.ToString().Sum(c => c - '0');
            while (result > 9)
            {
                result = result.ToString().Sum(c => c - '0');
            }
            Console.WriteLine("Cross sum of {0} is {1}", number, result);
        }
    }
}
