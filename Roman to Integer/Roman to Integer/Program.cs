/*
 Symbol       Value
I             1
V             5
X             10
L             50
C             100
D             500
M             1000
 */


public class Solution
{
    public int RomanToInt(string s)
    {
        var res = 0;
        for (int i = s.Length - 1; i >= 0;)
        {
            switch (s[i])
            {
                case 'I':
                    res += 1;
                    i--;
                    break;

                case 'V' when i > 0 && s[i - 1] == 'I':
                    res += 4;
                    i -= 2;
                    break;
                case 'V':
                    res += 5;
                    i--;
                    break;

                case 'X' when i > 0 && s[i - 1] == 'I':
                    res += 9;
                    i -= 2;
                    break;
                case 'X':
                    res += 10;
                    i--;
                    break;

                case 'L' when i > 0 && s[i - 1] == 'X':
                    res += 40;
                    i -= 2;
                    break;
                case 'L':
                    res += 50;
                    i--;
                    break;

                case 'C' when i > 0 && s[i - 1] == 'X':
                    res += 90;
                    i -= 2;
                    break;
                case 'C':
                    res += 100;
                    i--;
                    break;

                case 'D' when i > 0 && s[i - 1] == 'C':
                    res += 400;
                    i -= 2;
                    break;
                case 'D':
                    res += 500;
                    i--;
                    break;

                case 'M' when i > 0 && s[i - 1] == 'C':
                    res += 900;
                    i -= 2;
                    break;
                case 'M':
                    res += 1000;
                    i--;
                    break;

                default:
                    return res;
            }
 
        }
        return res;
    }
}