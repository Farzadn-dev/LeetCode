public class Solution
{
    public int[] SearchRange(int[] nums, int target)
    {
        int first = FindFirst(nums, target);
        if (first == -1) return [-1,-1];

        int last = FindLast(nums, target);
        return [ first, last ];
    }

    private int FindFirst(int[] nums, int target)
    {
        int left = 0, right = nums.Length - 1;
        int result = -1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (nums[mid] == target)
            {
                result = mid;
                right = mid - 1; // keep searching left
            }

            //Numbers is in Right Side
            else if (nums[mid] < target)
            {
                left = mid + 1;
            }

            //Number is in Left Side
            else
            {
                right = mid - 1;
            }
        }
        return result;
    }

    private int FindLast(int[] nums, int target)
    {
        int left = 0, right = nums.Length - 1;
        int result = -1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (nums[mid] == target)
            {
                result = mid;
                left = mid + 1; // keep searching right
            }

            //Numbers is in Right Side
            else if (nums[mid] < target)
            {
                left = mid + 1;
            }

            //Number is in Left Side
            else
            {
                right = mid - 1;
            }
        }
        return result;
    }
}