using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weekday
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SHows the day of the week when an integer from 1 to 7 is entered");
            Console.Write("Input number: ");
            int number = Int32.Parse(Console.ReadLine());
            switch(number)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;

                case 2:
                    Console.WriteLine("Tuesday");
                    break;

                case 3:
                    Console.WriteLine("Wednesday");
                    break;

                case 4:
                    Console.WriteLine("Thursday");
                    break;

                case 5:
                    Console.WriteLine("Friday");
                    break;

                case 6:
                    Console.WriteLine("Saturday");
                    break;

                case 7:
                    Console.WriteLine("Sunday");
                    break;

                default:
                    Console.WriteLine("Invalid day. Number must be between 1 and 7");
                    break;
            }
        }
    }
}
