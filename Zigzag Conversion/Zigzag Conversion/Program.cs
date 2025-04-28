using System.Text;

public class Solution
{
    public string Convert(string s, int numRows)
    {
        if (numRows == 1 || s.Length <= numRows)
            return s;

        var isGoingDown = true;
        var i = 0;
        var chars = new char[numRows, s.Length];
        for (var column = 0; column < s.Length; column++)
        {
            if (isGoingDown)
            {
                for (var row = 0; row < numRows; row++)
                    if (i < s.Length)
                        chars[row, column] = s[i++];

                isGoingDown = !isGoingDown;
                continue;
            }

            for (var row = numRows - 2; row > 0; row--)
                if (i < s.Length)
                    chars[row, column++] = s[i++];

            isGoingDown = !isGoingDown;
        }
        return CharListToString(chars);
    }

    private string CharListToString(char[,] chars)
    {
        StringBuilder sb = new();
        for (int i = 0; i < chars.GetLength(0); i++)
        {
            for (int j = 0; j < chars.GetLength(1); j++)
            {
                var c = chars[i, j];
                if (c != '\0')
                    sb.Append(c);
            }
        }
        return sb.ToString();
    }
}


/* AI Solution which is faster
 public class Solution
{
    public string Convert(string s, int numRows)
    {
        if (numRows == 1 || s.Length <= numRows)
            return s;

        var chars = new List<char>[numRows];
        for (int i = 0; i < numRows; i++)
            chars[i] = new List<char>();

        int currentRow = 0;
        bool goingDown = false;

        foreach (char c in s)
        {
            chars[currentRow].Add(c);
            if (currentRow == 0 || currentRow == numRows - 1)
                goingDown = !goingDown;
            currentRow += goingDown ? 1 : -1;
        }

        StringBuilder result = new();
        foreach (var row in chars)
            result.Append(string.Join("", row));

        return result.ToString();
    }
}
 */