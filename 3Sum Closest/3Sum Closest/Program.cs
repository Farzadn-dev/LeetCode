public class Solution
{
    public int ThreeSumClosest(int[] nums, int target)
    {
        Array.Sort(nums); // Faster than LINQ OrderBy

        int closestSum = nums[0] + nums[1] + nums[2];
        int n = nums.Length;

        for (int i = 0; i < n - 2; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
                continue;

            int left = i + 1, right = n - 1;
            while (left < right)
            {
                int sum = nums[i] + nums[left] + nums[right];

                if (sum == target)
                    return sum;

                if (Math.Abs(sum - target) < Math.Abs(closestSum - target))
                    closestSum = sum;

                if (sum < target)
                    left++;
                else
                    right--;
            }
        }

        return closestSum;
    }
}
