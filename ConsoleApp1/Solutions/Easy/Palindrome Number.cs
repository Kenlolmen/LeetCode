using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// link https://leetcode.com/problems/palindrome-number/description/

namespace ConsoleApp1.Solutions.Easy
{
    public class Palindrome_Number
    {
        public bool IsPalindrome(int x)
        {

            if (x < 0 || x % 10 == 0)
            {
                if (x == 0) return true;
            }

            var newx = x.ToString();
            var size = newx.Length;
            if (size == 1) return true;

            int left = 0;
            int right = size - 1;
            while (left < right)
            {
                if (newx[left] != newx[right]) return false;
                left++;
                right--;
            }

            return true;
        }


        public void implementation()
        {
            int a = 121; //true
            int b = -121; // false
            int c = 10; // false
            int d = 1122;

            Console.WriteLine($"result : {IsPalindrome(a)}");
            Console.WriteLine($"result : {IsPalindrome(b)}");
            Console.WriteLine($"result : {IsPalindrome(c)}");
            Console.WriteLine($"result : {IsPalindrome(d)}");

        }
    }
}
