/*
Given an array nums with n objects colored red, white, or blue, sort them in-place so that objects of the same color are adjacent, with the colors in the order red, white, and blue.
We will use the integers 0, 1, and 2 to represent the color red, white, and blue, respectively.
You must solve this problem without using the library's sort function.
Example 1:
Input: nums = [2,0,2,1,1,0]
Output: [0,0,1,1,2,2]

Example 2:
Input: nums = [2,0,1]
Output: [0,1,2]
*/

namespace ChallengeLab_11._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 0, 2, 1, 1, 0 };

            Solution solution = new Solution();

            solution.SortColors(nums);
            foreach (int i in nums)
            {
                Console.Write(i);
            }
        }
        public class Solution
        {
            public void SortColors(int[] nums)
            {
                int temp = 0;

                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[i] > nums[j])
                        {
                            temp = nums[i];
                            nums[i] = nums[j];
                            nums[j] = temp;
                        }
                    }
                }
            }
        }
    }
}
