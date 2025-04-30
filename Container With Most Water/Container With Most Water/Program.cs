public class Solution
{
    public int MaxArea(int[] height)
    {
        int maxArea = 0,left = 0,right = height.Length - 1;

        while(left < right)
        {
            var area = (right - left) * Math.Min(height[left], height[right]);
            maxArea = Math.Max(maxArea, area);

            if (height[left] < height[right])
                left++;
            else
                right--;
        }
        
        return maxArea;
    }
}