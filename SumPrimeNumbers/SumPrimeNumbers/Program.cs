/*
 * Created by SharpDevelop.
 * User: christian
 * Date: 2/9/2017
 * Time: 10:02 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace SumPrimeNumbers
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Sums prime numbers between entered prime numbers including said prime numbers");
			Console.Write("Input prime number: ");
			int K = Int32.Parse(Console.ReadLine());
			Console.Write("Input prime number: ");
			int J = Int32.Parse(Console.ReadLine());
			int sum = 0;
			while( K < J){
				if( isPrime(K) == true){
					sum += K;
					K++;
				} else
					K++;
			}
			
			Console.WriteLine(sum + J);
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
		
		public static Boolean isPrime( int num){
			if(num < 2)
				return false;
			if (num == 2)
				return true;
			if (num % 2 == 0)
				return false;
			for( int i = 3; i * i <= num; i += 2)
				if( num % i == 0)
					return false;
			return true;
		}
	}
}