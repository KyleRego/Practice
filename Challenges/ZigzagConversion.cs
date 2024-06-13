namespace Challenges;

// TODO: Solve this again
public class ZigzagConversion
{
    public static string Soln(string input, int rows)
    {
        if (rows == 1)
        {
            return input;
        }

        int numSections = (int)Math.Ceiling(input.Length / (2 * rows - 2.0));
        int columns = numSections * (rows - 1);

        char[][] matrix = new char[rows][];

        for (int k = 0; k < rows; k += 1)
        {
            matrix[k] = new char[columns];

            for (int h = 0; h < columns; h += 1)
            {
                matrix[k][h] = ' ';
            }
        }

        int curRow = 0;
        int curCol = 0;
        int stringIndex = 0;

        while (stringIndex < input.Length)
        {
            while (curRow < rows && stringIndex < input.Length)
            {
                matrix[curRow][curCol] = input[stringIndex];
                curRow += 1;
                stringIndex += 1;
            }

            curRow -= 2;
            curCol += 1;

            while (curRow > 0 && curCol < columns && stringIndex < input.Length)
            {
                matrix[curRow][curCol] = input[stringIndex];
                curRow -= 1;
                curCol += 1;
                stringIndex += 1;
            }
        }

        string answer = "";

        foreach (char[] row in matrix)
        {
            foreach (char c in row)
            {
                if (c != ' ')
                {
                    answer += c;
                }
            }
        }

        return answer;
    }
}