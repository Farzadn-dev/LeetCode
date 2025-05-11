using System.Text;

public class Solution
{
    public string LongestCommonPrefix(string[] strs)
    {
        switch (strs.Length)
        {
            case 0:
                return "";
            case 1:
                return strs[0];
        }

        var sb = new StringBuilder();
        for (int i = 0; i < strs[0].Length; i++)
        {
            char c = strs[0][i];
            for (int j = 1; j < strs.Length; j++)
            {
                if (i >= strs[j].Length || strs[j][i] != c)
                    return sb.ToString();
            }
            sb.Append(c);
        }
        return sb.ToString();
    }
}