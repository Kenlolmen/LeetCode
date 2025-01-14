using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// link https://leetcode.com/problems/roman-to-integer/description/

namespace ConsoleApp1.Solutions.Easy
{
    public class RomanToInteger
    {
        public int RomanToInt(string s)
        {
            int value = 0;
            Dictionary<char, int> RomanInt = new Dictionary<char, int>
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

            for (int i = 0; i < s.Length; i++)
            {
                int current = RomanInt[s[i]];

                if (i + 1 < s.Length && RomanInt[s[i + 1]] > current)
                {
                    value -= current;
                }
                else
                {
                    value += current;
                }
            }
            Console.WriteLine($"{value}");
            return value;
     
        }
        public void implementation()
        {
            RomanToInt("III");
            RomanToInt("MMCD");
            RomanToInt("IV");
            RomanToInt("XVI");
            RomanToInt("XL");

        }
    }
}
