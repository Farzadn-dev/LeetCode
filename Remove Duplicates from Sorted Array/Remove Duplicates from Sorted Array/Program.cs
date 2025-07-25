﻿public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0) return 0;

        int lastUniqeIndex = 0;
        int countOfUniqe = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[lastUniqeIndex])
            {
                countOfUniqe++;
                nums[++lastUniqeIndex] = nums[i];
            }
        }
        return countOfUniqe;
    }
}
