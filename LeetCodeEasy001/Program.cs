using System;
using System.Collections.Generic;

class Program
{
    public static int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> numToIndex = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (numToIndex.ContainsKey(complement))
            {
                return new int[] { numToIndex[complement], i };
            }

            numToIndex[nums[i]] = i;
        }

        // No solution found, return an empty array or handle as needed
        return new int[0];
    }

    static void Main(string[] args)
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;

        int[] result = TwoSum(nums, target);
        Console.WriteLine(string.Join(", ", result));  // Output: 0, 1
    }
}
