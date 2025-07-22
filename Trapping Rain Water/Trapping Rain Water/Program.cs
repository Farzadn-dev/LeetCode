public class Solution
{
    public int Trap(int[] height)
    {
        int left = 0, right = height.Length - 1;
        int leftMax = height[left], rightMax = height[right];
        int water = 0;
        while (left < right)
        {
            if (height[right] <= height[left])
            {
                right--;
                if (rightMax >= height[right])
                    water += rightMax - height[right];
                else
                    rightMax = height[right];
            }
            else
            {
                left++;
                if (leftMax >= height[left])
                    water += leftMax - height[left];
                else
                    leftMax = height[left];
            }
        }

        return water;
    }
}