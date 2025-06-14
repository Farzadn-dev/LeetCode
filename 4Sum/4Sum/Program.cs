public class Solution
{
    public IList<IList<int>> FourSum(int[] nums, int target)
    {
        if (nums.Length < 4)
            return new List<IList<int>>();

        Array.Sort(nums);
        List<IList<int>> result = new List<IList<int>>();

        for (int cursor1 = 0; cursor1 < nums.Length - 3; cursor1++)
        {
            // Skip duplicates for cursor1
            if (cursor1 > 0 && nums[cursor1] == nums[cursor1 - 1])
                continue;

            // Early exit if the smallest possible sum is greater than the target
            if ((long)nums[cursor1] + nums[cursor1 + 1] + nums[cursor1 + 2] + nums[cursor1 + 3] > target)
                break;

            // Early exit if the largest possible sum is less than the target
            if ((long)nums[cursor1] + nums[nums.Length - 3] + nums[nums.Length - 2] + nums[nums.Length - 1] < target)
                continue;

            for (int cursor2 = cursor1 + 1; cursor2 < nums.Length - 2; cursor2++)
            {
                // Skip duplicates for cursor2
                if (cursor2 > cursor1 + 1 && nums[cursor2] == nums[cursor2 - 1])
                    continue;

                // Early exit if the smallest possible sum is greater than the target
                if ((long)nums[cursor1] + nums[cursor2] + nums[cursor2 + 1] + nums[cursor2 + 2] > target)
                    break;

                // Early exit if the largest possible sum is less than the target
                if ((long)nums[cursor1] + nums[cursor2] + nums[nums.Length - 2] + nums[nums.Length - 1] < target)
                    continue;

                int left = cursor2 + 1;
                int right = nums.Length - 1;

                while (right > left)
                {
                    long sum = (long)nums[cursor1] + nums[cursor2] + nums[left] + nums[right];

                    if (sum == target)
                    {
                        result.Add(new List<int> { nums[cursor1], nums[cursor2], nums[left], nums[right] });

                        // Skip duplicates for left and right
                        while (left < right && nums[left] == nums[left + 1])
                            left++;
                        while (left < right && nums[right] == nums[right - 1])
                            right--;
                        left++;
                        right--;
                    }
                    else if (sum < target)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }
        }

        return result;
    }
}
