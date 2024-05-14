public class SudokuSolver
{
    public static int[][] SolveSudoku(int[][] sudoku)
    // the sudoku solver, uses trial and error strategy and recursive, it returns a valid and solved sudoku, else a null for non solved.
    {
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                if (sudoku[i][j] == 0)
                {
                    for (int k = 1; k <= 9; k++)
                    {
                        if (IsValidNumber(sudoku, i, j, k))
                        {
                            sudoku[i][j] = k;
                            if (SolveSudoku(sudoku) != null)
                                return sudoku;
                            sudoku[i][j] = 0;
                        }
                    }
                    return null;
                }
            }
        }
        return sudoku;
    }

    private static bool IsValidNumber(int[][] sudoku, int row, int col, int number)
        // check if the number is valid and can be pushed to the sudoku array. true if valid, false if not.
    {
        for (int i = 0; i < 9; i++)
        {
            if (sudoku[i][col] == number || sudoku[row][i] == number)
                return false;
        }

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (sudoku[row - row % 3 + i][col - col % 3 + j] == number)
                    return false;
            }
        }

        return true;
    }

    public static bool IsValidSudoku(int[][] sudoku)
        // this will return true if all checks are passed, otherwise , it returns an exception with error.
    {

        // this will checking if the sudoku entered has the 9 columns by 9 row ( 9x9 ) criteria.
        if (sudoku.Length != 9)
        {
            throw new ArgumentException("The sudoku must have 9 columns by 9 rows ( 9x9 ). Please check your sudoku in the input box and try again.");
        }

        foreach (int[] row in sudoku)
        {
            if (row.Length != 9)
            {
                throw new ArgumentException("The sudoku must have 9 columns by 9 rows ( 9x9 ). Please check your sudoku in the input box and try again.");
            }
        }

        // this will checking for duplicate number in a row.
        for (int i = 0; i < 9; i++)
        {
            HashSet<int> rowSet = new HashSet<int>();
            for (int j = 0; j < 9; j++)
            {
                if (sudoku[i][j] != 0 && !rowSet.Add(sudoku[i][j]))
                {
                    throw new ArgumentException($"There is a duplicate number in row {i + 1}.");
                }
            }
        }

        // this will checking for duplicate number in a column.
        for (int i = 0; i < 9; i++)
        {
            HashSet<int> colomnSet = new HashSet<int>();
            for (int j = 0; j < 9; j++)
            {
                if (sudoku[j][i] != 0 && !colomnSet.Add(sudoku[j][i]))
                {
                    throw new ArgumentException($"There is a duplicate number in column {i + 1}.");
                }
            }
        }

        // this will checking for duplicate number in a 3x3 subgrid
        for (int subGridRow = 0; subGridRow < 3; subGridRow++)
        {
            for (int subGridCol = 0; subGridCol < 3; subGridCol++)
            {
                HashSet<int> subGridSet = new HashSet<int>();
                for (int i = subGridRow * 3; i < subGridRow * 3 + 3; i++)
                {
                    for (int j = subGridCol * 3; j < subGridCol * 3 + 3; j++)
                    {
                        if (sudoku[i][j] != 0 && !subGridSet.Add(sudoku[i][j]))
                        {
                            throw new ArgumentException($"There is a duplicate number in the 3x3 subgrid starting at row {subGridRow * 3 + 1}, column {subGridCol * 3 + 1}.");
                        }
                    }
                }
            }
        }

        return true;
    }

}