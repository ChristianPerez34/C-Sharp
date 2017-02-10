/*
 * Created by SharpDevelop.
 * User: christian
 * Date: 12/18/2016
 * Time: 1:59 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Yatzy
{
	class Yatzy
	{
		static Random rand = new Random();
		public static void Main(string[] args)
		{
			Start_Game();
			Console.WriteLine("Press any key...");
			Console.ReadKey(true);
		}
		
		static void Start_Game()
		{
			First_Roll();
		}
		
		static void First_Roll()
		{
			int[] dice = new int[5];
			int i;
			int count = 0;
			for(i = 0; i < 5; i++)
			{
				dice[i] = rand.Next(1,7);
				Console.WriteLine(dice[i]);
				count += 1;
			}
			for(i = 0; i < 5; ++i)
			{
				while(dice[i] != dice[0])
				{
					dice[i] = rand.Next(1,7);
					count += 1;
				}
			}
			
			Console.WriteLine("Yatze after {0} attempts",count);
			
			for(i = 0; i < 5; i++)
			{
				Console.WriteLine(dice[i]);
			}
		}
	}
}