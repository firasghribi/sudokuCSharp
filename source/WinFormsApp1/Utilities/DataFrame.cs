using System.Text;

public class DataFrame
{
    public static string Transform2dArrayToString(int[][] matrixArray)
    {
        if (matrixArray == null || matrixArray.Length != 9 || matrixArray.Any(row => row.Length != 9))
        {
            throw new ArgumentException("An error has occured while transforming the 2D Array to String, the source format is invalid, please try again.");
        }

        StringBuilder str = new StringBuilder();
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                str.Append(matrixArray[i][j]);
            }
            str.AppendLine();
        }
        return str.ToString();
    }

    public static int[][] TransformStringTo2dArray(string str)
    {
        string[] lines = str.Split('\n', StringSplitOptions.RemoveEmptyEntries);
        int[][] matrixArray = new int[lines.Length][];

        for (int i = 0; i < lines.Length; i++)
        {
            string line = lines[i].Trim();
            matrixArray[i] = new int[line.Length];

            for (int j = 0; j < line.Length; j++)
            {
                if (line[j] == ' ')
                {
                    matrixArray[i][j] = 0;
                }
                else if (char.IsDigit(line[j]))
                {
                    matrixArray[i][j] = int.Parse(line[j].ToString());
                }
                else
                {
                    throw new ArgumentException($"There is an invalid character '{line[j]}' in input/imported/pasted source format string.");
                }
            }
        }

        return matrixArray;
    }
}