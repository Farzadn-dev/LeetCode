public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        int mid = 0, left = 0, right = nums.Length - 1;
        while (left <= right)
        {
            mid = left + (right - left) / 2;
            if (nums[mid] == target)
                return mid;

            //Target is in left Side
            if (nums[mid] > target)
                right = mid - 1;

            //Target is in right side
            else
                left = mid + 1;
        }

        return nums[mid] > target ? mid : mid + 1;
    }
}