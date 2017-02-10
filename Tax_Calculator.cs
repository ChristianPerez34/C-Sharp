using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculates a products total value including tax.");
            Console.WriteLine("Tax: 11.5%");
            Unit_read();
        }

        static void Unit_read()
        {
            Console.Write("Input unit's price: ");
            double unit_price = Double.Parse(Console.ReadLine());
            unit_price = Math.Round(unit_price, 2);
            Console.Write("Input the number of uits: ");
            int unit = Int32.Parse(Console.ReadLine());
            Console.WriteLine("{0, -15} {1,25:F}", "Unit price",unit_price);
            Console.WriteLine("{0,-15} {1,25:D}", "Number of units", unit);
            double tax = 0.115;
            double total_price_before_tax = unit_price * unit;
            double total_price = total_price_before_tax + (total_price_before_tax * tax);
            total_price = Math.Round(total_price, 2);
            Console.WriteLine("{0, -15} {1,25:F}", "Total",total_price);
        }
                
        
          
        }
        
}

