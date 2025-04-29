public class Solution
{
    public int MyAtoi(string s)
    {
        var res = string.Empty;
        s = s.Trim();
        var isNegetive = s.StartsWith("-");
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] is '+' or '-' && i == 0)
            {
                res += s[0];
                continue;
            }
            if ((s[i] == '0' && i == 0) || (i == 1 && s[0] == '-' && s[1] == '0'))
                continue;
            if (s[i] >= '0' && s[i] <= '9')
            {
                res += s[i];
                continue;
            }
            break;
        }
        res = res.Length == 0? "0" : res;
        res = res.Length == 1 && res[0] is '-' or '+'? "0" : res;
        return int.TryParse(res,out var result)?result:isNegetive?int.MinValue:int.MaxValue;
    }
}