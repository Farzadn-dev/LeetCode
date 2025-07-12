public class Solution
{
    public int Search(int[] nums, int target)
    {
        int left = 0;
        int right = nums.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (nums[mid] == target)
                return mid;

            //Left side is sorted
            if (nums[left] <= nums[mid])
            {
                //Number is in Left Side
                if (nums[left] <= target && target < nums[mid])
                    right = mid - 1;

                //Number is in Right Side
                else
                    left = mid + 1;
            }

            //Right side is sorted
            else
            {
                //Number is in Right Side
                if (nums[mid] < target && target <= nums[right])
                    left = mid + 1;

                //Number is in Left Side
                else
                    right = mid - 1;
            }
        }

        return -1;
    }
}