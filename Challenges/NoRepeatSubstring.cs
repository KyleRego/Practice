namespace Challenges;

// Given a string s, find the length of the longest substring
// without repeating characters.

public class NoRepeatSubstringLength
{
    public static int Soln(string input)
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

    public static int Soln2(string input)
    {
        if (input.Length <= 1) return input.Length;

        Dictionary<char, int> map = [];

        int leftIndex = 0;
        int rightIndex = 0;

        int longestStreak = 0;
        int currentStreak = 0;

        while (rightIndex < input.Length)
        {
            char character = input[rightIndex];

            if (map.TryGetValue(character, out int characterCount))
            {
                if (characterCount == 0)
                {
                    // this is duplicated below; I would probably try to not duplicate it
                    map[character] = 1;
                    rightIndex += 1;
                    currentStreak += 1;
                    longestStreak = (currentStreak > longestStreak) ? currentStreak : longestStreak;
                }
                else if (characterCount == 1)
                {
                    map[character] += 1;

                    while (map[character] == 2)
                    {
                        if (leftIndex >= input.Length) return longestStreak;

                        char leftChar = input[leftIndex];

                        map[leftChar] -= 1;
                        currentStreak -= 1;

                        leftIndex += 1;
                    }

                    rightIndex += 1;
                    currentStreak += 1;
                }
                else
                {
                    throw new ApplicationException();
                }
            }
            else
            {
                map[character] = 1;
                rightIndex += 1;
                currentStreak += 1;
                longestStreak = (currentStreak > longestStreak) ? currentStreak : longestStreak;
            }
        }

        return longestStreak;
    }
}