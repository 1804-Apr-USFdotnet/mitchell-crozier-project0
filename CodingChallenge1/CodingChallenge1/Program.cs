using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool finished = false;
            while (!finished)
            {
                Console.WriteLine("Enter a string");
                string myString = Console.ReadLine();
                if (isPalindrome(myString))
                {
                    Console.WriteLine("Is a palindrome");
                }
                else
                {
                    Console.WriteLine("Not a palindrome");
                }
            }
            
        }
        protected static bool isPalindrome(string myString)
        {
            myString = myString.Replace(",", "");
            myString = myString.Replace(" ", "");
            return myString.ToUpper().SequenceEqual(myString.ToUpper().Reverse());

        }
    }
}
