namespace Challenges;

// Given a string s, find the length of the longest substring
// without repeating characters.

public class NoRepeatSubstringLength
{
    public static int Sol(string input)
    {
        int longestSoFar = 0;

        for (int i = 0; i < input.Length; i += 1)
        {
            List<char> seenChars = [];
            int lenCounter = 0;

            for (int j = i; j < input.Length; j += 1)
            {
                char currentChar = input[j];

                if (seenChars.Contains(currentChar))
                {
                    longestSoFar = (lenCounter > longestSoFar) ? lenCounter : longestSoFar ;
                    break;
                }
                else
                {
                    seenChars.Add(currentChar);
                    lenCounter += 1;
                }
            }

            longestSoFar = (lenCounter > longestSoFar) ? lenCounter : longestSoFar ;
        }

        return longestSoFar;
    }
}