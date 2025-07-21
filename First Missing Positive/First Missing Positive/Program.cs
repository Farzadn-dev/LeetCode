//This Code is Optimized by AI
public class Solution
{
    public int FirstMissingPositive(int[] nums)
    {
        int n = nums.Length;

        // Place numbers in their correct index
        for (int i = 0; i < n; i++)
        {
            while (nums[i] > 0 && nums[i] <= n && nums[nums[i] - 1] != nums[i])
            {
                // Swap nums[i] with nums[nums[i] - 1]
                int temp = nums[nums[i] - 1];
                nums[nums[i] - 1] = nums[i];
                nums[i] = temp;
            }
        }

        // First index where number is not index + 1
        for (int i = 0; i < n; i++)
        {
            if (nums[i] != i + 1)
                return i + 1;
        }

        // If all are in place
        return n + 1;
    }
}