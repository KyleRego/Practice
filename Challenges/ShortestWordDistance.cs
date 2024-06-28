namespace Challenges;

public class ShortestWordDistance
{
    // quick solution based on first thought, it works but only beats 8% of solutions at time
    // so it's not very good
    public static int ShortestDistance(string[] wordsDict, string word1, string word2)
    {
        List<int> word1Positions = [];
        List<int> word2Positions = [];

        for (int i = 0; i < wordsDict.Length; i += 1)
        {
            string word = wordsDict[i];

            if (word == word1)
            {
                word1Positions.Add(i);
            }
            else if (word == word2)
            {
                word2Positions.Add(i);
            }
        }

        // this is a very inefficient way to get the final answer

        int shortestPossible = 0;

        while (true)
        {
            foreach (int pos1 in word1Positions)
            {
                foreach (int pos2 in word2Positions)
                {
                    if (Math.Abs(pos1 - pos2) == shortestPossible)
                    {
                        return shortestPossible;
                    }
                }
            }

            shortestPossible += 1;
        }
    }

    // a better one-pass solution
    // it passes through the array once so O(n * m) time ( m = length of word1 + length of word2 )
    // (? is that * m because for each input string, it must compare against that many letters in the worst case?)
    // it uses a constant amount of memory - O(1) memory
    public static int OnePassSoln(string[] wordsDict, string word1, string word2)
    {
        int shortestSoFar = int.MaxValue;

        int lastSeenWord1 = -1;
        int lastSeenWord2 = -1;

        for (int i = 0; i < wordsDict.Length; i += 1)
        {
            string word = wordsDict[i];

            if (word == word1)
            {
                lastSeenWord1 = i;

                if (lastSeenWord2 != -1)
                {
                    int distance  = lastSeenWord1 - lastSeenWord2;

                    if (distance < shortestSoFar)
                    {
                        shortestSoFar = distance;
                    }
                }
            }
            else if (word == word2)
            {
                lastSeenWord2 = i;

                if (lastSeenWord1 != -1)
                {
                    int distance  = lastSeenWord2 - lastSeenWord1;

                    if (distance < shortestSoFar)
                    {
                        shortestSoFar = distance;
                    }
                }
            }
        }

        return shortestSoFar;
    }
}