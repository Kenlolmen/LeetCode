using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//link  https://leetcode.com/problems/two-sum/description/

namespace ConsoleApp1.Solutions
{
    public class TwoSum
    {
        public int[] Function(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }

                }
            }
            throw new ArgumentException("No solution found");
        }

        public void implementation()
        {
            int[] n1 = { 2, 7, 11, 15 };
            int t1 = 9;

            int[] n2 = { 3, 2, 4 };
            int t2 = 6;

            int[] n3 = { 3, 3 };
            int t3 = 6;

            Console.WriteLine($"[{string.Join(", ", Function(n1, t1))}]");
            Console.WriteLine($"[{string.Join(", ", Function(n2, t2))}]");
            Console.WriteLine($"[{string.Join(", ", Function(n3, t3))}]");
        }
    }
}

