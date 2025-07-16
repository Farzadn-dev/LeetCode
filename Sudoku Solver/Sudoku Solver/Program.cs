public class Solution
{
    public void SolveSudoku(char[][] board)
    {
        Solve(board);
    }

    private bool Solve(char[][] board)
    {
        for (int row = 0; row < 9; row++)
        {
            for (int col = 0; col < 9; col++)
            {
                if (board[row][col] != '.') continue;

                for (char number = '1'; number <= '9'; number++)
                {
                    if (IsValid(board, row, col, number))
                    {
                        board[row][col] = number;
                        if (Solve(board)) return true; //Solved

                        board[row][col] = '.'; //BackTrack
                    }
                }

                return false; //No valid number found!
            }
        }
        return true; //All cells are filled
    }

    private bool IsValid(char[][] board, int row, int col, char num)
    {
        for (int i = 0; i < 9; i++)
        {
            if (board[row][i] == num || board[i][col] == num)
                return false;

            int boxRow = 3 * (row / 3) + i / 3;
            int boxCol = 3 * (col / 3) + i % 3;

            if (board[boxRow][boxCol] == num)
                return false;
        }
        return true;
    }
}

#region The Fastest Way(Ai generated) No way to understand 😅
/*
 public class Solution 
{
    private readonly int[] rows = new int[9];
    private readonly int[] cols = new int[9];
    private readonly int[,] boxes = new int[3,3];
    
    public void SolveSudoku(char[][] board) 
    {
        // Precompute initial constraints
        for (int row = 0; row < 9; row++) 
        {
            for (int col = 0; col < 9; col++) 
            {
                if (board[row][col] != '.')
                    SetConstraint(row, col, board[row][col], true);
            }
        }
        Solve(board);
    }

    private bool Solve(char[][] board) 
    {
        (int row, int col) = FindBestCell(board);
        if (row == -1) return true; // All cells filled

        int originalRowMask = rows[row];
        int originalColMask = cols[col];
        int originalBoxMask = boxes[row/3, col/3];
        
        // Combine existing constraints
        int used = originalRowMask | originalColMask | originalBoxMask;
        
        for (char num = '1'; num <= '9'; num++) 
        {
            if ((used & (1 << (num - '1'))) != 0) continue;
            
            // Update board and constraints
            board[row][col] = num;
            SetConstraint(row, col, num, true);
            
            if (Solve(board)) return true;
            
            // Restore constraints (faster than recomputing)
            board[row][col] = '.';
            rows[row] = originalRowMask;
            cols[col] = originalColMask;
            boxes[row/3, col/3] = originalBoxMask;
        }
        return false;
    }

    // This is the key optimization - finds the cell with fewest possibilities
    private (int row, int col) FindBestCell(char[][] board) 
    {
        int minCount = 10;
        (int r, int c) best = (-1, -1);
        
        for (int row = 0; row < 9; row++) 
        {
            for (int col = 0; col < 9; col++) 
            {
                if (board[row][col] != '.') continue;
                
                int used = rows[row] | cols[col] | boxes[row/3, col/3];
                int count = 9 - BitCount(used);
                
                if (count < minCount) 
                {
                    minCount = count;
                    best = (row, col);
                    if (count == 1) return best; // Early exit for speed
                }
            }
        }
        return best;
    }

    private void SetConstraint(int row, int col, char num, bool add) 
    {
        int mask = 1 << (num - '1');
        if (add) 
        {
            rows[row] |= mask;
            cols[col] |= mask;
            boxes[row/3, col/3] |= mask;
        }
        else 
        {
            rows[row] &= ~mask;
            cols[col] &= ~mask;
            boxes[row/3, col/3] &= ~mask;
        }
    }

    private static int BitCount(int n) 
    {
        int count = 0;
        while (n != 0) 
        {
            n &= (n - 1);
            count++;
        }
        return count;
    }
}

 */
#endregion