using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1, value2, sum;
            Console.WriteLine("Computes the sum of two numbers.");
            Console.WriteLine("Input numbers to be added: ");
            sum result = new SumOfTwoNumbers.sum();
            result.ThisSum();
        }
    }

    class sum
    {
        public void ThisSum()
        {
            int value1, value2, sum;
            value1 = Int32.Parse(Console.ReadLine());
            value2 = Int32.Parse(Console.ReadLine());
            sum = value1 + value2;
            Console.WriteLine("{0} + {1} = {2}", value1, value2, sum);
        }
    }
}