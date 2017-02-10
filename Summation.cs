using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculates the summation from 1 to n, for a given n");
            Console.Write("Input number: ");
            int n = Int32.Parse(Console.ReadLine());
            int result = Summation(n);
            Console.WriteLine("Summation from 1 to {0} = {1}", n, result);
        }

        static int Summation(int N)
        {
            if (N == 1 || N == 0)
                return N;
            else
                return N + Summation(N-1);
        }
    }
}
