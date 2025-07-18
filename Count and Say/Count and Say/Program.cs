using System.Text;
new Solution().CountAndSay(6);
public class Solution
{
    public string CountAndSay(int n)
    {
        if (n == 1) return "1";
        string result = "1";

        for (int i = 2; i <= n; i++)
            result = Describe(result);
        
        return result;
    }

    private string Describe(string input)
    {
        StringBuilder sb = new StringBuilder(input.Length * 2);
        int count = 1;
        char prev = input[0];

        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] == prev)        
                count++;
            
            else
            {
                sb.Append((char)(count + '0')).Append(prev);
                prev = input[i];
                count = 1;
            }
        }

        sb.Append((char)(count + '0')).Append(prev); // final group
        return sb.ToString();
    }
}