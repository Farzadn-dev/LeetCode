using System.Text.RegularExpressions;

var s = new Solution().IsMatch("aaa","ab*a*c*a");
Console.WriteLine(s);



public class Solution
{
    public bool IsMatch(string s, string p) => Regex.IsMatch(s, "^" + p + "$");
}