using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public class Palindromic
    {
        public static bool isPalindrome(string myString)
        {
            myString = myString.Replace(",", "");
            myString = myString.Replace(" ", "");
            return myString.ToUpper().SequenceEqual(myString.ToUpper().Reverse());

        }
    }
}
