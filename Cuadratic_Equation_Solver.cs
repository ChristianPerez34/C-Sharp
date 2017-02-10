using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuadratic
{
    class Cuadratic_Equation_Solver
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Solve cuadratic formulas in the form of");
            Console.WriteLine("ax^2 + bx + c = 0");
            Console.Write("Input a: ");
            Equation_Solver();
        }

        static void Equation_Solver()
        {
            double a = Double.Parse(Console.ReadLine());
            Console.Write("Input b: ");
            double b = Double.Parse(Console.ReadLine());
            Console.Write("Input c: ");
            double c = Double.Parse(Console.ReadLine());
            double d = Math.Pow(b, 2) - 4 * (a * c);
            if (d < 0)
                Console.WriteLine("THere is no solution");
            else if (d == 0)
            {
                double solution = (-1 * b) / (2 * a);
                Console.WriteLine("The solution is {0}", solution);
            }
            else
            {
                double pos_sol = ((-b) + Math.Sqrt(d)) / (2 * a);
                double neg_sol = ((-b) - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("Solution: {0} and {1}", pos_sol, neg_sol);
            }
        }
    }
}
