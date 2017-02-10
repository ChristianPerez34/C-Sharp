using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Perimeter_Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculates the perimeter and area of a circle.");
            Console.WriteLine("Input circle radius: ");
            Calculation result = new Calculation();
            result.Circle();
        }
    }
    class Calculation
    {
        public void Circle()
        {
            double radius, perimeter, area;
            radius = Int32.Parse(Console.ReadLine());
            perimeter = 2 * Math.PI * radius;
            perimeter = Math.Round(perimeter, 2);
            area = 4 * Math.PI * Math.Pow(radius, 2);
            area = Math.Round(area, 2);
            Console.WriteLine("Area = {0} \t Perimeter = {1}", area, perimeter);
        }
    }
   
}
