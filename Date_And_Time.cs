using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shows today's date and time.");
          string Date = DateTime.Now.ToString("M/d/yyyy");
            string time = DateTime.Now.ToString("h:mm:ss tt");
            Console.WriteLine(Date);
            Console.WriteLine(time);
        }
    }
}
