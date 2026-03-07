
using System;

class TwoSum
{
    public static void SumOfTwoNumbers()
    {
        int[] nums = {2, 7, 11, 15};
        int target = 9;

        for(int i = 0; i < nums.Length; i++)
        {
            for(int j = i + 1; j < nums.Length; i++)
            {
                if(nums[i] + nums[j] == target)
                {
                    Console.WriteLine($"Index: {i}, {j}");
                }
            }
        }

    }
}