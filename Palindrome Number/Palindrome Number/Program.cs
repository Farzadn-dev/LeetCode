public class Solution
{
    //public bool IsPalindrome(int x) => x.ToString() == new string(x.ToString().Reverse().ToArray()); //Via Stringify
    public bool IsPalindrome(int x)
    {
        if (x < 0) return false; //Negative numbers cannot be palindromes 13ms
        int temp = x;
        int reverse = 0;
        while (temp > 0)
        {
            int digit = temp % 10;
            reverse = reverse * 10 + digit;
            temp /= 10;
        }
        return x == reverse;
    }//2ms
}