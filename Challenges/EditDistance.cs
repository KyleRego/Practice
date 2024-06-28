namespace Challenges;

public class EditDistance
{
    // Try this again
    // Hint for next time:
    // "From intuition, we have deduced that we must try all three operations and find the minimum."

    // use backtracking?

    // this seems correct but it uses too much time
    // it is not using recursion in a very optimwal way.. TODO try again with recursion

    public static int MinDistance(string word1, string word2)
    {
        List<int> minOperations = [int.MaxValue];

        BackTrack(0, word1, word2, 0, minOperations);

        return minOperations.First();
    }

    private static void BackTrack(int numOperationsUsedSoFar,
                                    string wordToChange, string targetWord,
                                    int currentIndex, List<int> minOperations)
    {
        if (wordToChange == targetWord)
        {
            int minSoFar = minOperations.First();

            if (numOperationsUsedSoFar < minSoFar)
            {
                minOperations[0] = numOperationsUsedSoFar;
            }

            return;
        }
        else if (currentIndex < wordToChange.Length && currentIndex < targetWord.Length)
        {
            if (wordToChange[currentIndex] == targetWord[currentIndex])
            {
                BackTrack(numOperationsUsedSoFar, wordToChange, targetWord, currentIndex + 1, minOperations);
            }
        }

        numOperationsUsedSoFar += 1;

        if (currentIndex < wordToChange.Length)
        {
            string wordAfterDelete = wordToChange.Remove(currentIndex, 1);
            BackTrack(numOperationsUsedSoFar, wordAfterDelete, targetWord, currentIndex, minOperations);
        }

        if (currentIndex < targetWord.Length)
        {
            char charFromTargetWord = targetWord[currentIndex];

            if (currentIndex <= wordToChange.Length)
            {
                string wordAfterInsert = wordToChange.Insert(currentIndex, charFromTargetWord.ToString());
                BackTrack(numOperationsUsedSoFar, wordAfterInsert, targetWord, currentIndex + 1, minOperations);

                if (currentIndex + 1 < wordAfterInsert.Length)
                {
                    string wordAfterSwap = wordAfterInsert.Remove(currentIndex + 1, 1);
                    BackTrack(numOperationsUsedSoFar, wordAfterSwap, targetWord, currentIndex + 1, minOperations);
                }
            }
        }
    }
}