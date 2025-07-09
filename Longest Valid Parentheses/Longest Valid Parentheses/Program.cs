public class Solution
{
    public int LongestValidParentheses(string s)
    {
        // Initialize a stack to keep track of the indices of the parentheses
        Stack<int> stack = new Stack<int>();
        // Push a base index of -1 to handle cases where the valid substring starts from the beginning of the string
        stack.Push(-1);
        int maxLength = 0; // Variable to store the maximum length of valid parentheses substring found

        // Iterate through the string
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                // Push the index of the open parenthesis onto the stack
                stack.Push(i);
            }
            else
            {
                // Pop the top of the stack, which represents the index of the last unmatched open parenthesis
                stack.Pop();
                if (stack.Count == 0)
                {
                    // If the stack becomes empty after popping, push the current index as the new base index
                    stack.Push(i);
                }
                else
                {
                    // Calculate the length of the valid substring ending at the current index
                    maxLength = Math.Max(maxLength, i - stack.Peek());
                }
            }
        }

        // Return the maximum length of valid parentheses substring found
        return maxLength;
    }
}



#region Fastest Way
/*
 public class Solution
{
    public int LongestValidParentheses(string s)
    {
        // Check if the input string is null or empty
        if (string.IsNullOrEmpty(s))
        {
            return 0; // Return 0 if the string is null or empty
        }

        // Create a DP array where dp[i] represents the length of the longest valid parentheses substring ending at index i
        int[] dp = new int[s.Length];
        int maxLength = 0; // Variable to store the maximum length of valid parentheses substring found

        // Iterate through the string starting from the second character
        for (int i = 1; i < s.Length; i++)
        {
            // If the current character is a close parenthesis
            if (s[i] == ')')
            {
                // If the previous character is an open parenthesis, the current substring is valid
                if (s[i - 1] == '(')
                {
                    // Add 2 to the length of the valid substring ending at i-2 (if it exists)
                    dp[i] = (i >= 2 ? dp[i - 2] : 0) + 2;
                }
                // If the previous character is a close parenthesis, check if the character before the matched substring is an open parenthesis
                else if (i - dp[i - 1] > 0 && s[i - dp[i - 1] - 1] == '(')
                {
                    // Add 2 to the length of the valid substring ending at i - dp[i - 1] - 2 (if it exists) and the length of the matched substring
                    dp[i] = dp[i - 1] + (i - dp[i - 1] >= 2 ? dp[i - dp[i - 1] - 2] : 0) + 2;
                }
                // Update maxLength with the maximum of itself and dp[i]
                maxLength = Math.Max(maxLength, dp[i]);
            }
        }

        // Return the maximum length of valid parentheses substring found
        return maxLength;
    }
}
 */
#endregion

