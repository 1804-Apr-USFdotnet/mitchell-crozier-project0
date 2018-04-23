using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome.Tests
{
    [TestClass()]
    public class PalindromicTests
    {
        private readonly Palindromic palindromic;
        public PalindromicTests()
        {
            palindromic = new Palindromic();
        }
        [TestMethod()]
        public void isPalindromeTest()
        {
            bool expected = true;
            Assert.IsTrue(Palindrome.Palindromic.isPalindrome("Racecar") == expected);
        }
        [TestMethod()]
        public void isPalindromeTest2()
        {
            bool expected = true;
            Assert.IsTrue(Palindrome.Palindromic.isPalindrome("1221") == expected);
        }
        [TestMethod()]
        public void isPalindromeTest3()
        {
            bool expected = true;
            Assert.IsTrue(Palindrome.Palindromic.isPalindrome("racecar") == expected);
        }
        [TestMethod()]
        public void isPalindromeTest4()
        {
            bool expected = true;
            Assert.IsTrue(Palindrome.Palindromic.isPalindrome("Never Odd, or Even") == expected);
        }
        [TestMethod()]
        public void isPalindromeTest5()
        {
            bool expected = false;
            Assert.IsTrue(Palindrome.Palindromic.isPalindrome("1231") == expected);
        }
        [TestMethod()]
        public void isPalindromeTest6()
        {
            bool expected = false;
            Assert.IsTrue(Palindrome.Palindromic.isPalindrome("aBc") == expected);
        }
    }
}