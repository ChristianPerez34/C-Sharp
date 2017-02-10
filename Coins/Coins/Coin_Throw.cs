/*
 * Created by SharpDevelop.
 * User: christian
 * Date: 12/28/2016
 * Time: 2:18 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Coins
{
	/// <summary>
	/// Description of Coin_Throw.
	/// </summary>
	public class Coin_Throw
	{
		Random rand = new Random();
		string throw_coin;
		public Coin_Throw()
		{
			Throw();	
		}
		
		public string Throw()
		{
			throw_coin = (rand.Next(0,2) == 0) ? "H":"T";
			return throw_coin;

		}
	}
}
