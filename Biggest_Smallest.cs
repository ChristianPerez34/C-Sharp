using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Biggest_and_the_Smallest_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0, i, sum, min, max, average;
            int[] numbers = new int[100];
            Console.WriteLine("Computes the number of entered numbers, the smallest number, the biggest number, the sum of entered numbers, and its average");
            for (i = 0; i < numbers.Length; i++)
                {
                Console.Write("Enter a number(enter 0 to stop): ");
                numbers[i] = Int32.Parse(Console.ReadLine());
                    if (numbers[i] == 0)
                    {
                    numbers = numbers.Where(val => val != 0).ToArray();
                    sum = numbers.Sum();
                        min = numbers.Min();
                        max = numbers.Max();
                        average = sum / count;
                        Console.WriteLine("Amount of entered numbers: {0}", count);
                        Console.WriteLine("The sum is: {0}", sum);
                        Console.WriteLine("The smallest number is: {0}", min);
                        Console.WriteLine("The largest number is: {0}", max);
                        Console.WriteLine("Average: {0}",average);
                    break;
                        

                    }
                    count += 1;
                }           
            }

        }
}

