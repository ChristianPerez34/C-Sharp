using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sorts 2 numbers in ascending order.");
            Console.Write("Input first number: ");
            int number1 = Int32.Parse(Console.ReadLine());
            Console.Write("Input second number: ");
            int number2 = Int32.Parse(Console.ReadLine());
            if(number1> number2)
            {
                Console.WriteLine("{0} {1}", number2, number1);
            }
            else
            {
                Console.WriteLine("{0} {1}", number1, number2);
            }
        }
    }
}
