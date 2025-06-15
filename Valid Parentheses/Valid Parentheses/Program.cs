public class Solution
{
    public bool IsValid(string s)
    {
        // Use stackalloc for performance and avoid heap allocations
        Span<char> stack = stackalloc char[s.Length];
        int top = -1;

        foreach (var c in s)
        {
            switch (c)
            {
                case '(':
                case '{':
                case '[':
                    stack[++top] = c;
                    continue;
            }

            if (top < 0)
                return false;

            char open = stack[top--];

            if (!IsMatchingPair(open, c))
                return false;
        }

        return top == -1;
    }

    private bool IsMatchingPair(char open, char close)
    {
        return (open == '(' && close == ')') ||
               (open == '{' && close == '}') ||
               (open == '[' && close == ']');
    }
}
