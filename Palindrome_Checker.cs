/*
 * Created by SharpDevelop.
 * User: christian
 * Date: 12/17/2016
 * Time: 9:01 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
	class Palindrome_Checker
	{
		static void Main(string[] args)
        {
            Console.WriteLine("Checks if sentence is a palindrome");
            Console.Write("Enter a sentence or word: ");
            string sentence_word = Console.ReadLine();
            palindrome(sentence_word);
            if(palindrome(sentence_word)==true)
            {
            	Console.WriteLine("It is a palindrome");
            }
            else
            {
            	Console.WriteLine("It is not a palindrome");
            }
            Console.WriteLine("Press any key to continue.....");
            Console.ReadKey(true);
        }

        static bool palindrome(string myString)
        {
            return myString.SequenceEqual(myString.Reverse());
        }
	}
}
