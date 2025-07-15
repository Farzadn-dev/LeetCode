public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        HashSet<char> set = [];
        //row checking
        for (int row = 0; row < 9; row++)
        {
            set.Clear();
            for (int col = 0; col < 9; col++)
            {
                char val = board[row][col];
                if (val != '.' && !set.Add(val))
                    return false;
            }
        }

        //col checking
        for (int col = 0; col < 9; col++)
        {
            set.Clear();
            for (int row = 0; row < 9; row++)
            {
                char val = board[row][col];
                if (val != '.' && !set.Add(val))
                    return false;
            }
        }

        //box checking
        for (int boxRow = 0; boxRow < 9; boxRow += 3)
        {
            for (int boxCol = 0; boxCol < 9; boxCol += 3)
            {
                set.Clear();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        char value = board[boxRow + i][boxCol + j];
                        if (value != '.' && !set.Add(value))
                            return false;
                    }
                }
            }
        }

        return true;
    }
}


#region Simpler Way
/*
 public class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        bool[,] rowUsed = new bool[9, 9];
        bool[,] colUsed = new bool[9, 9];
        bool[,] boxUsed = new bool[9, 9];

        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                char c = board[i][j];
                if (c == '.') continue;

                int num = c - '1';              // Convert '1'-'9' to 0-8
                int boxIndex = (i / 3) * 3 + (j / 3);

                if (rowUsed[i, num] || colUsed[j, num] || boxUsed[boxIndex, num])
                    return false;

                rowUsed[i, num] = colUsed[j, num] = boxUsed[boxIndex, num] = true;
            }
        }

        return true;
    }
}
*/
#endregion