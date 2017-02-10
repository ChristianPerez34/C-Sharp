/*
 * Created by SharpDevelop.
 * User: christian
 * Date: 2/10/2017
 * Time: 6:18 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace LargestPrimeFactor
{
	class Program
	{
		public static void Main(string[] args)
		{
			Int64 number = Int64.Parse(Console.ReadLine());
			int squareRoot = (int) Math.Sqrt(number);
			int largestPrime = 0;
			for( int i = 2; i < squareRoot; i++){
				if(isPrime(i) && number % i == 0)
					largestPrime = i;
			}
			Console.WriteLine(largestPrime);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static Boolean isPrime(int num){
			if (num < 2)
				return false;
			if (num == 2)
				return true;
			if (num % 2 == 0)
				return false;
			for(int i = 3; i * i <= num; i += 2)
				if (num % i == 0)
					return false;
			return true;
		}
	}
}