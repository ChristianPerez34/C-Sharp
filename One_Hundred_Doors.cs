/*
 * Created by SharpDevelop.
 * User: christian
 * Date: 12/17/2016
 * Time: 10:03 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _100_doors
{
	class One_Hundred_Doors
	{
		public static void Main(string[] args)
		{
			//There are 100 doors in a row that are all initially closed. You make 100 passes by the doors.
			//The first time through, visit every door and   toggle   the door   (if the door is closed,   open it;   if it is open,   close it).
			//The second time, only visit every second door (#2, #4, #6,....)
			//The third time visit every third door (#3, #6, #9,...)
			
			int i;
			string[] door = new string[101];
			for(i = 1; i < 101; i++)
			{
				int a = (int)Math.Sqrt(i);
				if(a*a == i)
				{
					door[i] = "open";
				}
				else
				{
					door[i] = "closed";
				}
				Console.WriteLine("{0} {1}",i,door[i]);
				
			}
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}