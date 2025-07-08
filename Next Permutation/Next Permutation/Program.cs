public class Solution
{
    public void NextPermutation(int[] nums)
    {
        if (nums.Length == 1)
            return;

        int temp;
        if (nums.Length == 2)
        {
            temp = nums[0];
            nums[0] = nums[1];
            nums[1] = temp;
            return;
        }

        bool chainFunction = false;
        int smallestIndex;
        for (int i = nums.Length - 1; i > 0; i--)
        {
            if (nums[i] > nums[i - 1])
            {
                if (chainFunction)
                {
                    smallestIndex = GetClosestNumberIndex(nums, i - 1);
                    temp = nums[i - 1];
                    nums[i - 1] = nums[smallestIndex];
                    nums[smallestIndex] = temp;

                    Array.Reverse(nums, i, nums.Length - i);
                    return;
                }

                temp = nums[i];
                nums[i] = nums[i - 1];
                nums[i - 1] = temp;
                return;
            }
            chainFunction = true;
        }

        Array.Reverse(nums);
    }

    private int GetClosestNumberIndex(int[] nums, int i)
    {
        int result = -1;
        for (int j = nums.Length - 1; j > i; j--)
        {
            if (nums[j] > nums[i])
            {
                result = j;
                break;
            }
        }
        return result;
    }
}