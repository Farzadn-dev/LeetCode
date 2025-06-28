public class Solution
{
    public int Divide(int dividend, int divisor)
    {
        var res = (Int64)dividend / divisor;
        if (res > int.MaxValue)
            return int.MaxValue;

        if (res < int.MinValue)
            return int.MinValue;

        return (int)res;
    }
}