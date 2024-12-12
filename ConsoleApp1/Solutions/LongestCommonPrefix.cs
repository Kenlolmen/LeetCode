using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//link https://leetcode.com/problems/longest-common-prefix/description/

namespace ConsoleApp1.Solutions
{
    public class LongestCommonPrefix
    {
        public string function(string[] strs)
        {
            int minLength = strs.Min(s => s.Length);
            StringBuilder commonPrefix = new StringBuilder(); 

            for (int i = 0; i < minLength; i++)
            {
                char currentChar = strs[0][i];

                for (int j = 1; j < strs.Length; j++)
                {
                    if (strs[j][i] != currentChar) 
                    {
                        return commonPrefix.ToString(); 
                    }
                }

                commonPrefix.Append(currentChar);
            }

            return commonPrefix.ToString(); 
        }


    }
}
