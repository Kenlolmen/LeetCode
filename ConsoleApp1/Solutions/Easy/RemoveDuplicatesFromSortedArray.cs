using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Solutions.Easy
{
    internal class RemoveDuplicatesFromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {

            if (nums.Length == 0) return 0; 

            int k = 1; 

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[k - 1]) 
                {
                    nums[k] = nums[i]; 
                    k++; 
                }
            }

            Console.WriteLine($"tablica: " +string.Join(", ", nums));
            Console.WriteLine($"k: {k}");
            return k;
        }
        
        public void implementation()
        {
            int[] list1 = { 0, 0, 0, 1, 1, 1, 2, 2, 3 };
            RemoveDuplicates(list1);
        }

    }
}
