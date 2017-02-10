/*
 * Created by SharpDevelop.
 * User: christian
 * Date: 12/28/2016
 * Time: 2:17 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Coins
{
	class Program
	{
		public static void Main(string[] args)
		{
			Coin_Throw c1 = new Coin_Throw();
			Coin_Throw c2 = new Coin_Throw();
			do{
				Console.WriteLine(c1.Throw() + " " + c2.Throw());
			}while(c1.Throw() != "H" || c2.Throw() != "H");
	
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}