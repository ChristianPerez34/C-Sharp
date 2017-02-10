using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Div_Mod
{
    class Quotient_Mod
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculates division and mod of 2 numbers");
            Console.Write("Input first number: ");
            int number1 = Int32.Parse(Console.ReadLine());
            Console.Write("Input second number: ");
            int number2 = Int32.Parse(Console.ReadLine());
            int quotient = number1 / number2;
            int mod = number1 % number2;
            Console.WriteLine("{0} div {1} = {2}", number1, number2, quotient);
            Console.WriteLine("{0} mod {1} = {2}", number1, number2, mod);
            Console.WriteLine("{0} = {1} * {2} + {3}", number1, number2, quotient, mod);
        }
    }
}
